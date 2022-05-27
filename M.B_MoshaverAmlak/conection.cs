using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace M.B_MoshaverAmlak
{
    class conection
    {
        static public string _conectionstring = "server=PARSAM\\MOHAMMAD ; database=Moshaver_Amlak ; integrated security=true";
        static public SqlConnection _conection = new SqlConnection(_conectionstring);
        
        
    }
}
