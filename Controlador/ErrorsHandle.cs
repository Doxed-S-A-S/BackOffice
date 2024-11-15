using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    class ErrorsHandle
    {
        public static void ErrorHandle(Exception ex)
        {
            if (ex.Message == "DUPLICATE_ENTRY")
                throw new Exception("DUPLICATE_ENTRY");
            if (ex.Message == "ACCESS_DENIED")
                throw new Exception("ACCESS_DENIED");
            if (ex.Message == "UNKNOWN_COLUMN")
                throw new Exception("UNKNOWN_COLUMN");
            if (ex.Message == "UNKNOWN_DB_ERROR")
                throw new Exception("UNKNOWN_DB_ERROR");
            if (ex.Message == "ERROR_CHILD_ROW")
                throw new Exception("ERROR_CHILD_ROW");
            if (ex.Message == "MYSQL_TABLE_NOT_EXIST")
                throw new Exception("MYSQL_TABLE_NOT_EXIST");
            if (ex.Message == "MYSQL_INCORRECT_DATE")
                throw new Exception("MYSQL_INCORRECT_DATE");
            if (ex.Message == "CANNOT_CONNECT_TO_DB")
                throw new Exception("CANNOT_CONNECT_TO_DB");

            throw new Exception("UNKNOWN_ERROR");
        }
    }
}
