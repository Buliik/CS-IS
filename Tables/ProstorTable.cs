using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;


namespace str
{
    class ProstorTable
    {
        public static String TABLE_NAME = "Prostor";

        public static String SQL_SELECT = "SELECT * FROM Prostor WHERE idSpr != 0";
        public static String SQL_SELECT_ID = "SELECT * FROM Prostor WHERE idSpr=@idSpr";
        public static String SQL_INSERT = "INSERT INTO Prostor (vzdalenost) VALUES (@vzdalenost)";
        public static String SQL_DELETE_ID = "DELETE FROM Prostor WHERE idSpr=@idSpr";
        public static String SQL_UPDATE = "UPDATE Prostor SET vzdalenost=@vzdalenost WHERE idSpr=@idSpr";
        public static String SQL_REZUPDATE = "UPDATE Rezervace SET Prostor_idSpr=0 WHERE Prostor_idSpr=@idSpr";
        public static String SQL_STRUPDATE = "UPDATE Strelba SET Prostor_idSpr=0 WHERE Prostor_idSpr=@idSpr";

        public static int insert(Prostor Prostor)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, Prostor);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static int update(Prostor Prostor)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, Prostor);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Prostor> select()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Prostor> Prostory = Read(reader, true);
            reader.Close();
            db.Close();
            return Prostory;
        }

        public static Prostor select(int idSpr)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.AddWithValue("@idSpr", idSpr);
            SqlDataReader reader = db.Select(command);

            Collection<Prostor> prostory = Read(reader);
            Prostor prostor = null;
            if (prostory.Count == 1)
            {
                prostor = prostory[0];
            }
            reader.Close();
            db.Close();
            return prostor;
        }

        public static int delete(int idSpr) 
            // v analyze je napsano nastaveni priznaku, ma myslenka je nastaveni priznaku abych mohl smazat dany zaznam, tudiz volam jak update tak delete.
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_REZUPDATE);
            command.Parameters.AddWithValue("@idSpr", idSpr);
            int ret = db.ExecuteNonQuery(command);

            command = db.CreateCommand(SQL_STRUPDATE);
            command.Parameters.AddWithValue("@idSpr", idSpr);
            ret = db.ExecuteNonQuery(command);

            command = db.CreateCommand(SQL_DELETE_ID);
            command.Parameters.AddWithValue("@idSpr", idSpr);
            ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        private static void PrepareCommand(SqlCommand command, Prostor Prostor)
        {
            command.Parameters.AddWithValue("@idSpr", Prostor.idSpr);
            command.Parameters.AddWithValue("@vzdalenost", Prostor.vzdalenost);
        }

        private static Collection<Prostor> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<Prostor> prostory = new Collection<Prostor>();

            while (reader.Read())
            {
                Prostor prostor = new Prostor();
                int i = -1;
                prostor.idSpr = reader.GetInt32(++i);
                prostor.vzdalenost = reader.GetDouble(++i);

                prostory.Add(prostor);
            }
            return prostory;
        }
    }
}
