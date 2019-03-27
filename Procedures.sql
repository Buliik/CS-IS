CREATE OR ALTER PROCEDURE procisteniStreleb AS
BEGIN
	DECLARE @currDate DATE;
	DECLARE @oldDate DATE;
	DECLARE @counter Int;
	DECLARE @hold Int;
	DECLARE c CURSOR FOR
	SELECT Poradove_cislo From Strelba
	FOR UPDATE OF Poradove_cislo;

	SET @currdate = GETDATE();
	SET @oldDate = DateAdd(Year, -3, @currdate);
	Delete From Strelba
	Where konec < @oldDate;
	SET @counter = 0;
	
	OPEN c;
	FETCH NEXT FROM c INTO @hold;
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		UPDATE Strelba
		SET Poradove_cislo = @counter
		WHERE Poradove_cislo = @hold;
		SET @counter += 1;

		FETCH NEXT FROM c INTO @hold;
	END;

	CLOSE c;
	DEALLOCATE c;
END;

GO

CREATE OR ALTER PROCEDURE StrelbaDleRezervace (@v_idRez INT, @doba_str INT, @v_idZam INT) AS
BEGIN
	DECLARE @v_Zbran INT;
	DECLARE @v_Prostor INT;
	DECLARE @v_Zakaznik INT;
	DECLARE @v_Zacatek DATETIME;
	DECLARE @v_Konec DATETIME;

	SELECT @v_zbran = Zbran_idZbr, @v_Prostor = Prostor_idSpr, @v_Zakaznik = Zakaznik_idZak, @v_Zacatek = datumStrelby
	FROM Rezervace WHERE idRez = @v_idRez;

	IF (@@rowcount = 0)
		BEGIN
		PRINT 'Dana rezervace se nenachazi v databazi.';
		RETURN;
		END;	

	SET @v_Konec = DATEADD(minute, @doba_str, @v_Zacatek);

	INSERT INTO Strelba (Zacatek, Konec, Zbran_idZbr, Zamestnanec_idZam, Zakaznik_idZak, Prostor_idSpr)
	VALUES (@v_Zacatek, @v_konec, @v_Zbran, @v_idZam, @v_Zakaznik, @v_Prostor);

	DELETE FROM Rezervace
	WHERE idRez = @v_idRez;
END;

GO

CREATE OR ALTER PROCEDURE KontrolaDostupnosti (@id_Zbran INT, @id_Prostor INT, @datum DATETIME, @aktualni_Datum DATETIME, @id_Zakaznik INT) AS
BEGIN 
		DECLARE @Pocet INT;
		DECLARE @err INT;

		SELECT @Pocet = COUNT(*)
		FROM Rezervace r
		WHERE r.Zbran_idZbr = @id_Zbran AND r.datumStrelby != @datum
		IF (@Pocet != 0) 
			RETURN

		SELECT @Pocet = COUNT(*)
		FROM Rezervace r
		WHERE r.Prostor_idSpr = @id_Prostor AND r.datumStrelby != @datum
		IF @Pocet != 0
			RETURN

		INSERT INTO Rezervace (datumVytvoreni, datumStrelby, Zakaznik_idZak, Prostor_idSpr, Zbran_idZbr)
		VALUES (@aktualni_Datum, @datum, @id_Zakaznik, @id_Prostor, @id_Zbran)

END;

GO

CREATE OR ALTER PROCEDURE procisteniRezervaci AS
BEGIN
	DECLARE @currDate DATE;
	DECLARE @counter Int;
	DECLARE @hold Int;
	DECLARE c CURSOR FOR
	SELECT Poradove_cislo From Rezervace
	FOR UPDATE OF Poradove_cislo;

	SET @currdate = GETDATE();
	Delete From Rezervace
	Where datumStrelby < @currDate;
	SET @counter = 0;

	OPEN c;
	FETCH NEXT FROM c INTO @hold
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		UPDATE Rezervace
		SET Poradove_cislo = @counter
		WHERE Poradove_cislo = @hold;
		SET @counter += 1;

		FETCH NEXT FROM c INTO @hold
	END;

	CLOSE c;
	DEALLOCATE c;
END;

GO

CREATE OR ALTER FUNCTION NejpopularnejsiZbrane() RETURNS VARCHAR(1000) AS
BEGIN
	DECLARE @text VARCHAR(1000);
	DECLARE @ZzID INT;
	DECLARE @Zjmeno VARCHAR(30);
	DECLARE @Zprijmeni VARCHAR(30);
	DECLARE @Znazev VARCHAR(30);
	DECLARE @Zcas INT;

	DECLARE c CURSOR FOR 
	SELECT idZak, jmeno, prijmeni FROM Zakaznik

	OPEN c;
	FETCH NEXT FROM c INTO @ZzID, @Zjmeno, @Zprijmeni
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		DECLARE k CURSOR FOR 
		SELECT Zbran.Nazev, SUM(DATEDIFF(minute, Strelba.konec, Strelba.Zacatek))
		FROM Zbran JOIN Strelba ON Zbran.idZbr = Strelba.Zbran_idZbr
		WHERE Strelba.Zakaznik_idZak = @ZzID
		GROUP BY zbran.idZbr, zbran.Nazev
		ORDER BY SUM(DATEDIFF(minute, Strelba.konec, Strelba.Zacatek)) DESC, zbran.Nazev
		OPEN k;
		FETCH NEXT FROM k INTO @Znazev, @Zcas
		SET @text = @text + @Zjmeno + ' ' + @Zprijmeni + ' ' + 'Zbran: ' + @Znazev + 'Celkem minut: ' + @Zcas + '\n';
		CLOSE k;
		DEALLOCATE k;
		FETCH NEXT FROM c INTO @ZzID, @Zjmeno, @Zprijmeni
	END;
	CLOSE c;
	DEALLOCATE c;
	RETURN @text;
END;

GO