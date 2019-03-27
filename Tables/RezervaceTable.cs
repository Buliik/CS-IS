using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace str
{
    class RezervaceTable
    {
        public static String TABLE_NAME = "Rezervace";

        public static String SQL_SELECT = "SELECT * FROM Rezervace r";
        public static String SQL_SELECT_ID = "SELECT * FROM Rezervace WHERE idRez=@idRez";
        public static String SQL_INSERT = "EXEC KontrolaDostupnosti @aktualni_Datum=@datumVytvoreni, @datum=@datumStrelby, @id_Zakaznik=@Zakaznik_idZak, @id_Prostor=@Prostor_idSpr, @id_Zbran=@Zbran_idZbr";
        public static String SQL_DELETE_ID = "DELETE FROM Rezervace WHERE idRez=@idRez";
        public static String SQL_UPDATE = "UPDATE Rezervace SET datumVytvoreni=@datumVytvoreni, datumStrelby=@datumStrelby, " +
            "Zakaznik_idZak=@Zakaznik_idZak, Prostor_idSpr=@Prostor_idSpr, Zbran_idZbr=@Zbran_idZbr WHERE idRez=@idRez";
        public static String SQL_CLEANUP = "EXEC procisteniRezervaci";
        public static String SQL_CONVERT = "EXEC StrelbaDleRezervace @v_idRez=@idRez, @doba_str=@dobaStr, @v_idZam=@idZam";

        public static int insert(Rezervace Rezervace) // procedura 6.f. kontrola dostupnosti ybrane a strelneho prostoru
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, Rezervace);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static int update(Rezervace Rezervace)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, Rezervace);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Rezervace> select()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Rezervace> mrezervace = Read(reader, true);
            reader.Close();
            db.Close();
            return mrezervace;
        }

        public static Rezervace select(int idRez)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.AddWithValue("@idRez", idRez);
            SqlDataReader reader = db.Select(command);

            Collection<Rezervace> mrezervace = Read(reader);
            Rezervace rezervace = null;
            if (mrezervace.Count == 1)
            {
                rezervace = mrezervace[0];
            }
            reader.Close();
            db.Close();
            return rezervace;
        }

        public static int delete(int idRez)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE_ID);

            command.Parameters.AddWithValue("@idRez", idRez);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static int clean() // procedura 6.g. procisteni rezervaci 
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_CLEANUP);
            int ret = db.ExecuteNonQuery(command);
            return ret;
        }

        public static void StrelbaDleRezervace(int idRez, int dobaStr, int idZam) // procedura 5.g. vytvoreni funkce dle existujici rezervace 
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_CONVERT);
            command.Parameters.AddWithValue("@idRez", idRez);
            command.Parameters.AddWithValue("@dobaStr", dobaStr);
            command.Parameters.AddWithValue("@idZam", idZam);
            db.ExecuteNonQuery(command);
            db.Close();

        }

        private static void PrepareCommand(SqlCommand command, Rezervace Rezervace)
        {
            command.Parameters.AddWithValue("@idRez", Rezervace.idRez);
            command.Parameters.AddWithValue("@datumVytvoreni", Rezervace.datumVytvoreni);
            command.Parameters.AddWithValue("@datumStrelby", Rezervace.datumStrelby);
            command.Parameters.AddWithValue("@Zakaznik_idZak", Rezervace.Zakaznik_idZak);
            command.Parameters.AddWithValue("@Prostor_idSpr", Rezervace.Prostor_idSpr);
            command.Parameters.AddWithValue("@Zbran_idZbr", Rezervace.Zbran_idZbr);
        }

        private static Collection<Rezervace> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<Rezervace> mrezervace = new Collection<Rezervace>();

            while (reader.Read())
            {
                Rezervace rezervace = new Rezervace();
                int i = -1;
                rezervace.idRez = reader.GetInt32(++i);
                rezervace.datumVytvoreni = reader.GetDateTime(++i);
                rezervace.datumStrelby = reader.GetDateTime(++i);
                rezervace.Zakaznik_idZak = reader.GetInt32(++i);
                rezervace.Prostor_idSpr = reader.GetInt32(++i);
                rezervace.Zbran_idZbr = reader.GetInt32(++i);

                mrezervace.Add(rezervace);
            }
            return mrezervace;                ;
        }
    }
}
