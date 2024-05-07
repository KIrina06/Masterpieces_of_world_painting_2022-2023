using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Masterpieces_of_world_painting
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HONOR-PC\SQLEXPRESS;Initial Catalog=Masterpieces of world painting");
    }
}
