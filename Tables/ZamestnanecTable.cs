using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace str
{
    class ZamestnanecTable
    {
        public static String TABLE_NAME = "Zamestnanec";

        public static String SQL_SELECT = "SELECT * FROM Zamestnanec zam WHERE idZam != 0";
        public static String SQL_SELECT_ID = "SELECT * FROM Zamestnanec WHERE idZam=@idZam";
        public static String SQL_INSERT = "INSERT INTO Zamestnanec (Jmeno, Prijmeni, email, Datum_Narozeni) " +
            "VALUES (@Jmeno, @Prijmeni, @email, @Datum_narozeni)";
        public static String SQL_DELETE_ID = "DELETE FROM Zamestnanec WHERE idZam=@idZam";
        public static String SQL_UPDATE = "UPDATE Zamestnanec SET jmeno=@Jmeno, prijmeni=@Prijmeni, email=@email, " +
            "Datum_narozeni=@Datum_narozeni WHERE idZam=@idZam";
        public static String SQL_STRUPDATE = "UPDATE Strelba SET Zamestnanec_idZam=0 WHERE Zamestnanec_idZam=@idZam";

        public static int insert(Zamestnanec Zamestnanec)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, Zamestnanec);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static int update(Zamestnanec Zamestnanec)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, Zamestnanec);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Zamestnanec> select()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Zamestnanec> Zamestnanci = Read(reader, true);
            reader.Close();
            db.Close();
            return Zamestnanci;
        }

        public static Zamestnanec select(int idZam)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.AddWithValue("@idZam", idZam);
            SqlDataReader reader = db.Select(command);

            Collection<Zamestnanec> zamestnanci = Read(reader);
            Zamestnanec zamestnanec = null;
            if (zamestnanci.Count == 1)
            {
                zamestnanec = zamestnanci[0];
            }
            reader.Close();
            db.Close();
            return zamestnanec;
        }

        public static int delete(int idZam)
            // v analyze je napsano nastaveni priznaku, ma myslenka je nastaveni priznaku abych mohl smazat dany zaznam, tudiz volam jak update tak delete.
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_STRUPDATE);
            command.Parameters.AddWithValue("@idZam", idZam);
            int ret = db.ExecuteNonQuery(command);

            command = db.CreateCommand(SQL_DELETE_ID);
            command.Parameters.AddWithValue("@idZam", idZam);
            ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        private static void PrepareCommand(SqlCommand command, Zamestnanec Zamestnanec)
        {
            command.Parameters.AddWithValue("@idZam", Zamestnanec.idZam);
            command.Parameters.AddWithValue("@Jmeno", Zamestnanec.Jmeno);
            command.Parameters.AddWithValue("@Prijmeni", Zamestnanec.Prijmeni);
            command.Parameters.AddWithValue("@email", Zamestnanec.email);
            command.Parameters.AddWithValue("@Datum_narozeni", Zamestnanec.Datum_narozeni);
        }

        private static Collection<Zamestnanec> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<Zamestnanec> zamestnanci = new Collection<Zamestnanec>();

            while (reader.Read())
            {
                Zamestnanec zamestnanec = new Zamestnanec();
                int i = -1;
                zamestnanec.idZam = reader.GetInt32(++i);
                zamestnanec.Jmeno = reader.GetString(++i);
                zamestnanec.Prijmeni = reader.GetString(++i);
                zamestnanec.email = reader.GetString(++i);
                zamestnanec.Datum_narozeni = reader.GetDateTime(++i).Date;

                zamestnanci.Add(zamestnanec);
            }
            return zamestnanci;
        }
    }
}
