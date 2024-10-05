using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelos
{
    class BDErrorsHandle : Modelo
    {
        const int MYSQL_DUPLICATE_ENTRY = 1062;
        const int MYSQL_ACCESS_DENIED = 1045;
        const int MYSQL_UNKNOWN_COLUMN = 1054;
        const int MYSQL_ERROR_CHILD_ROW = 1452;
        const int MYSQL_TABLE_NOT_EXIST = 1146;
        const int MYSQL_INCORRECT_DATE = 1292;


        public static void MySqlErrorCatch(MySqlException sqlx)
        {
            if (sqlx.Number == MYSQL_DUPLICATE_ENTRY)
                throw new Exception("DUPLICATE_ENTRY");
            if (sqlx.Number == MYSQL_ACCESS_DENIED)
                throw new Exception("ACCESS_DENIED");
            if (sqlx.Number == MYSQL_UNKNOWN_COLUMN)
                throw new Exception("UNKNOWN_COLUMN");
            if (sqlx.Number == MYSQL_ERROR_CHILD_ROW)
                throw new Exception("ERROR_CHILD_ROW");
            if (sqlx.Number == MYSQL_TABLE_NOT_EXIST)
                throw new Exception(" MYSQL_TABLE_NOT_EXIST");

            throw new Exception("UNKNOWN_DB_ERROR");
        }
    }
}
