using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace str
{
    class Historie_zmenTable
    {
        public static String TABLE_NAME = "Historie_zmen";

        public static String SQL_SELECT = "SELECT * FROM Historie_zmen hz";
        public static String SQL_SELECT_ID = "SELECT * FROM Historie_zmen WHERE Zid=@Zid";
        public static String SQL_INSERT = "INSERT INTO Historie_zmen (Datum_zmeny, Zbran_idZbr, Nazev, Typ_zbrane, Raze, Rok_vyroby) " +
            "VALUES (@Datum_zmeny, @Zbran_idZbr, @Nazev, @Typ_zbrane, @Raze, @Rok_vyroby)";
        public static String SQL_DELETE_ID = "DELETE FROM Historie_zmen WHERE Zid=@Zid";

        protected int insert(Historie_zmen Historie_zmen)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, Historie_zmen);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        protected Collection<Historie_zmen> select()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Historie_zmen> Zmeny = Read(reader, true);
            reader.Close();
            db.Close();
            return Zmeny;
        }

        protected Historie_zmen select(int Zid)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.AddWithValue("@Zid", Zid);
            SqlDataReader reader = db.Select(command);

            Collection<Historie_zmen> zmeny = Read(reader);
            Historie_zmen historie_Zmen = null;
            if (zmeny.Count == 1)
            {
                historie_Zmen = zmeny[0];
            }
            reader.Close();
            db.Close();
            return historie_Zmen;
        }

        public static int delete(int Zid)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE_ID);

            command.Parameters.AddWithValue("@Zid", Zid);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        private static void PrepareCommand(SqlCommand command, Historie_zmen Historie_zmen)
        {
            command.Parameters.AddWithValue("@Zid", Historie_zmen.Zid);
            command.Parameters.AddWithValue("@Datum_zmeny", Historie_zmen.Datum_zmeny);
            command.Parameters.AddWithValue("@Zbran_idZbr", Historie_zmen.Zbran_idZbr);
            command.Parameters.AddWithValue("@Nazev", Historie_zmen.Nazev);
            command.Parameters.AddWithValue("@Typ_zbrane", Historie_zmen.Typ_zbrane);
            command.Parameters.AddWithValue("@Raze", Historie_zmen.Raze);
            command.Parameters.AddWithValue("@Rok_vyroby", Historie_zmen.Rok_vyroby);
        }

        private static Collection<Historie_zmen> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<Historie_zmen> zmeny = new Collection<Historie_zmen>();

            while (reader.Read())
            {
                Historie_zmen historie_Zmen = new Historie_zmen();
                int i = -1;
                historie_Zmen.Zid = reader.GetInt32(++i);
                historie_Zmen.Datum_zmeny = reader.GetDateTime(++i);
                historie_Zmen.Zbran_idZbr = reader.GetInt32(++i);
                historie_Zmen.Nazev = reader.GetString(++i);
                historie_Zmen.Typ_zbrane = reader.GetString(++i);
                historie_Zmen.Raze = reader.GetDouble(++i);
                historie_Zmen.Rok_vyroby = reader.GetInt32(++i);

                zmeny.Add(historie_Zmen);
            }
            return zmeny;
        }
    }
}
