using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Hotel.DAO {
    //Abrir la conexion con los parametros establecidos de postgresql
    class Conexion {
        protected NpgsqlConnection conn = new NpgsqlConnection( "Server=localhost;Port=5432; User Id=admin;Password=md5;Database = postgres" );        
        }
    
    }
