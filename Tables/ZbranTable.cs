using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace str
{
    class ZbranTable
    {
        public static String TABLE_NAME = "Zbran";

        public static String SQL_SELECT = "SELECT * FROM Zbran zbr WHERE idZbr != 0";
        public static String SQL_SELECT_ID = "SELECT * FROM Zbran WHERE idZbr=@idZbr";
        public static String SQL_INSERT = "INSERT INTO Zbran (Nazev, Typ_zbrane, Raze, Rok_vyroby) " +
            "VALUES (@Nazev, @Typ_zbrane, @Raze, @Rok_vyroby)";
        public static String SQL_DELETE_ID = "DELETE FROM Zbran WHERE idZbr=@idZbr";
        public static String SQL_UPDATE = "UPDATE Zbran SET Nazev=@Nazev, Typ_zbrane=@Typ_zbrane, Raze=@Raze, " +
            "Rok_vyroby=@Rok_vyroby WHERE idZbr=@idZbr";
        public static String SQL_REZUPDATE = "UPDATE Rezervace SET Zbran_idZbr=0 WHERE Zbran_idZbr=@idZbr";
        public static String SQL_STRUPDATE = "UPDATE Strelba SET Zbran_idZbr=0 WHERE Zbran_idZbr=@idZbr";

        public static int insert(Zbran Zbran)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, Zbran);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static int update(Zbran Zbran)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, Zbran);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Zbran> select()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Zbran> Zbrane = Read(reader, true);
            reader.Close();
            db.Close();
            return Zbrane;
        }

        public static Zbran select(int idZbr)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.AddWithValue("@idZbr", idZbr);
            SqlDataReader reader = db.Select(command);

            Collection<Zbran> zbrane = Read(reader);
            Zbran zbran = null;
            if (zbrane.Count == 1)
            {
                zbran = zbrane[0];
            }
            reader.Close();
            db.Close();
            return zbran;
        }

        public static int delete(int idZbr)
            // v analyze je napsano nastaveni priznaku, ma myslenka je nastaveni priznaku abych mohl smazat dany zaznam, tudiz volam jak update tak delete.
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_REZUPDATE);
            command.Parameters.AddWithValue("@idZbr", idZbr);
            int ret = db.ExecuteNonQuery(command);

            command = db.CreateCommand(SQL_STRUPDATE);
            command.Parameters.AddWithValue("@idZbr", idZbr);
            ret = db.ExecuteNonQuery(command);

            command = db.CreateCommand(SQL_DELETE_ID);
            command.Parameters.AddWithValue("@idZbr", idZbr);
            ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        private static void PrepareCommand(SqlCommand command, Zbran Zbran)
        {
            command.Parameters.AddWithValue("@idZbr", Zbran.idZbr);
            command.Parameters.AddWithValue("@Nazev", Zbran.Nazev);
            command.Parameters.AddWithValue("@Typ_zbrane", Zbran.Typ_zbrane);
            command.Parameters.AddWithValue("@Raze", Zbran.Raze);
            command.Parameters.AddWithValue("@Rok_vyroby", Zbran.Rok_vyroby);
        }

        private static Collection<Zbran> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<Zbran> zbrane = new Collection<Zbran>();

            while (reader.Read())
            {
                Zbran zbran = new Zbran();
                int i = -1;
                zbran.idZbr = reader.GetInt32(++i);
                zbran.Nazev = reader.GetString(++i);
                zbran.Typ_zbrane = reader.GetString(++i);
                zbran.Raze = reader.GetDouble(++i);
                zbran.Rok_vyroby = reader.GetInt32(++i);

                zbrane.Add(zbran);
            }
            return zbrane;
        }
    }
}
