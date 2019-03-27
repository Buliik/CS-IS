using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace str
{
    class StrelbaTable
    {
        public static String TABLE_NAME = "Strelba";

        public static String SQL_SELECT = "SELECT * FROM Strelba s";
        public static String SQL_SELECT_ID = "SELECT * FROM Strelba WHERE idStr=@idStr";
        public static String SQL_INSERT = "INSERT INTO Strelba (Zacatek, Konec, Zbran_idZbr, Zamestnanec_idZam, Zakaznik_idZak, Prostor_idSpr) " +
            "VALUES (@Zacatek, @Konec, @Zbran_idZbr, @Zamestnanec_idZam, @Zakaznik_idZak, @Prostor_idSpr)";
        public static String SQL_DELETE_ID = "DELETE FROM Strelba WHERE idStr=@idStr";
        public static String SQL_UPDATE = "UPDATE Strelba SET Zacatek=@Zacatek, Konec=@Konec, Zbran_idZbr=@Zbran_idZbr, " +
            "Zamestnanec_idZam=@Zamestnanec_idZam, Zakaznik_idZak=@Zakaznik_idZak, Prostor_idSpr=@Prostor_idSpr WHERE idStr=@idStr";
        public static String SQL_CLEANUP = "EXEC procisteniStreleb";

        public static int insert(Strelba Strelba)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, Strelba);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static int update(Strelba Strelba)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, Strelba);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Strelba> select()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Strelba> Strelby = Read(reader, true);
            reader.Close();
            db.Close();
            return Strelby;
        }

        public static Strelba select(int idStr)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.AddWithValue("@idStr", idStr);
            SqlDataReader reader = db.Select(command);

            Collection<Strelba> strelby = Read(reader);
            Strelba strelba = null;
            if (strelby.Count == 1)
            {
                strelba = strelby[0];
            }
            reader.Close();
            db.Close();
            return strelba;
        }

        public static int delete(int idStr)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE_ID);

            command.Parameters.AddWithValue("@idStr", idStr);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static int clean() // procedura 5.f. procisteni streleb
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_CLEANUP);
            int ret = db.ExecuteNonQuery(command);
            return ret;
        }

        private static void PrepareCommand(SqlCommand command, Strelba Strelba)
        {
            command.Parameters.AddWithValue("@idStr", Strelba.idStr);
            command.Parameters.AddWithValue("@Zacatek", Strelba.Zacatek);
            command.Parameters.AddWithValue("@Konec", Strelba.Konec);
            command.Parameters.AddWithValue("@Zbran_idZbr", Strelba.Zbran_idZbr);
            command.Parameters.AddWithValue("@Zamestnanec_idZam", Strelba.Zamestnanec_idZam);
            command.Parameters.AddWithValue("@Zakaznik_idZak", Strelba.Zakaznik_idZak);
            command.Parameters.AddWithValue("@Prostor_idSpr", Strelba.Prostor_idSpr);
        }

        private static Collection<Strelba> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<Strelba> strelby = new Collection<Strelba>();

            while (reader.Read())
            {
                Strelba strelba = new Strelba();
                int i = -1;
                strelba.idStr = reader.GetInt32(++i);
                strelba.Zacatek = reader.GetDateTime(++i);
                strelba.Konec = reader.GetDateTime(++i);
                strelba.Zbran_idZbr = reader.GetInt32(++i);
                strelba.Zamestnanec_idZam = reader.GetInt32(++i);
                strelba.Zakaznik_idZak = reader.GetInt32(++i);
                strelba.Prostor_idSpr = reader.GetInt32(++i);

                strelby.Add(strelba);
            }
            return strelby;
        }
    }
}
