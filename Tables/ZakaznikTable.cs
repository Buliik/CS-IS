using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace str
{
    class ZakaznikTable
    {
        public static String TABLE_NAME = "Zakaznik";

        public static String SQL_SELECT = "SELECT * FROM Zakaznik zak WHERE idZak != 0";
        public static String SQL_SELECT_ID = "SELECT * FROM Zakaznik WHERE idZak=@idZak";
        public static String SQL_INSERT = "INSERT INTO Zakaznik (Jmeno, Prijmeni, email, Datum_Narozeni) " +
            "VALUES (@Jmeno, @Prijmeni, @email, @Datum_narozeni)";
        public static String SQL_DELETE_ID = "DELETE FROM Zakaznik WHERE idZak=@idZak";
        public static String SQL_UPDATE = "UPDATE Zakaznik SET jmeno=@Jmeno, prijmeni=@Prijmeni, email=@email, " +
            "Datum_narozeni=@Datum_narozeni WHERE idZak=@idZak";
        public static String SQL_REZUPDATE = "UPDATE Rezervace SET Zakaznik_idZak=0 WHERE Zakaznik_idZak=@idZak";
        public static String SQL_STRUPDATE = "UPDATE Strelba SET Zakaznik_idZak=0 WHERE Zakaznik_idZak=@idZak";
        public static String SQL_POPULARWEAPONS = "EXEC NejpopularnejsiZbrane @text";

        public static int Insert(Zakaznik Zakaznik)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, Zakaznik);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static int update(Zakaznik Zakaznik)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, Zakaznik);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Zakaznik> select()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Zakaznik> Zakaznici = Read(reader, true);
            reader.Close();
            db.Close();
            return Zakaznici;
        }

        public static Zakaznik select(int idZak)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.AddWithValue("@idZak", idZak);
            SqlDataReader reader = db.Select(command);

            Collection<Zakaznik> zakaznici = Read(reader);
            Zakaznik zakaznik = null;
            if (zakaznici.Count == 1)
            {
                zakaznik = zakaznici[0];
            }
            reader.Close();
            db.Close();
            return zakaznik;
        }

        public static int delete(int idZak)
            // v analyze je napsano nastaveni priznaku, ma myslenka je nastaveni priznaku abych mohl smazat dany zaznam, tudiz volam jak update tak delete.
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_REZUPDATE);
            command.Parameters.AddWithValue("@idZak", idZak);
            int ret = db.ExecuteNonQuery(command);

            command = db.CreateCommand(SQL_STRUPDATE);
            command.Parameters.AddWithValue("@idZak", idZak);
            ret = db.ExecuteNonQuery(command);

            command = db.CreateCommand(SQL_DELETE_ID);
            command.Parameters.AddWithValue("@idZak", idZak);
            ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }

        public static String NejpopularnejsiZbrane() // funkce 2.g. nejpopulárnější zbraně 
                                                     // bug - nepodarilo se mi rozchodit vraceni hodnot funkce
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_POPULARWEAPONS);
            command.Parameters.Add("@text", System.Data.SqlDbType.VarChar);
            var data = command.ExecuteScalar();
            
            String vypis = (data.GetType() != typeof(DBNull) ? Convert.ToString(data) : "");

            db.Close();
            return vypis;
        }

        private static void PrepareCommand(SqlCommand command, Zakaznik Zakaznik)
        {
            command.Parameters.AddWithValue("@idZak", Zakaznik.idZak);
            command.Parameters.AddWithValue("@Jmeno", Zakaznik.Jmeno);
            command.Parameters.AddWithValue("@Prijmeni", Zakaznik.Prijmeni);
            command.Parameters.AddWithValue("@email", Zakaznik.email);
            command.Parameters.AddWithValue("@Datum_narozeni", Zakaznik.Datum_narozeni);
        }

        private static Collection<Zakaznik> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<Zakaznik> zakaznici = new Collection<Zakaznik>();

            while (reader.Read())
            {
                Zakaznik zakaznik = new Zakaznik();
                int i = -1;
                zakaznik.idZak = reader.GetInt32(++i);
                zakaznik.Jmeno = reader.GetString(++i);
                zakaznik.Prijmeni = reader.GetString(++i);
                zakaznik.email = reader.GetString(++i);
                zakaznik.Datum_narozeni = reader.GetDateTime(++i).Date;

                zakaznici.Add(zakaznik);
            }
            return zakaznici;
        }
    }
}
