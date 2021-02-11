using Hotel.DTO;
using Npgsql;
using System.Collections.Generic;

namespace Hotel.DAO {
    class MedicoDao : Conexion {
        NpgsqlDataReader LeerFilas;
        NpgsqlCommand comm = new NpgsqlCommand();

        public bool Login ( string cedula , string passs ) {
            //Abrir conexion
            conn.Open();
            comm.Connection = conn;
            //Comando para conocer si existe la cedula y la contraseña recibidas
            comm.CommandText = "select * from medico where cedula = '" + cedula + "' and password = '" + passs + "';";
            //Ejecutar comando
            comm.ExecuteNonQuery();
            LeerFilas = comm.ExecuteReader();
            //Si existe tal tupla
            if ( LeerFilas.HasRows ) {
                while ( LeerFilas.Read() ) {
                    //Enviar a los datos de cache cedula y nombre para mostrarlos
                    CacheData.name = LeerFilas.GetString(0)  + " " + LeerFilas.GetString(1);
                    CacheData.cedula = LeerFilas.GetString(2);
                    }
                //Cerrar conexion y avisar que existe tal medico con tal contraseña
                LeerFilas.Close();
                conn.Close();
                return true;
                }
            else {
                //Cerrar conexion y avisar que NO existe tal medico con tal contraseña
                LeerFilas.Close();
                conn.Close();
                return false;
                }
            }

        public MedicoDTO ObtenerMedico ( string cedula ) {
            MedicoDTO medico = new MedicoDTO();
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from medico where cedula = '" + cedula + "';";
            comm.ExecuteNonQuery();
            LeerFilas = comm.ExecuteReader();
            if ( LeerFilas.HasRows ) {
                while ( LeerFilas.Read() ) {
                    medico.Nombre = LeerFilas.GetString(0);
                    medico.Apellido = LeerFilas.GetString(1);
                    medico.Cedula = LeerFilas.GetString(2);
                    medico.Especializacion = LeerFilas.GetString(3);
                    medico.Horario = LeerFilas.GetString(4);
                    medico.Salario = LeerFilas.GetFloat(5);
                    medico.Sexo = LeerFilas.GetChar(6);
                    medico.Password = LeerFilas.GetString(7);
                    }
                }
            LeerFilas.Close();
            conn.Close();
            return medico;
            }

        //Metodos
        public List<MedicoDTO> VerRegistros ( string condicion ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from " + condicion + ";";
            comm.ExecuteNonQuery();

            LeerFilas = comm.ExecuteReader();
            List<MedicoDTO> listaGenerica = new List<MedicoDTO>();
            while ( LeerFilas.Read() ) {
                listaGenerica.Add(new MedicoDTO {
                    Nombre = LeerFilas.GetString(0) ,
                    Apellido = LeerFilas.GetString(1) ,
                    Cedula = LeerFilas.GetString(2) ,
                    Especializacion = LeerFilas.GetString(3) ,
                    Horario = LeerFilas.GetString(4) ,
                    Salario = LeerFilas.GetFloat(5) ,
                    Sexo = LeerFilas.GetChar(6) ,
                    Password = LeerFilas.GetString(7)
                    });
                }
            LeerFilas.Close();
            conn.Close();
            return listaGenerica;
            }
        // VALIDACIONES
        public bool existeCedula ( string cedula ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from medico where cedula = '" + cedula + "';";
            comm.ExecuteNonQuery();
            LeerFilas = comm.ExecuteReader();
            if ( LeerFilas.HasRows ) {
                LeerFilas.Close();
                conn.Close();
                return true;
                }
            else {
                LeerFilas.Close();
                conn.Close();
                return false;
                }
            }

        public bool Insert ( string nombre , string apellido , string cedula , string especializacion , string horario , float salario , char sexo , string pass ) {
            if ( !existeCedula(cedula) ) {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO medico VALUES ('" + nombre + "', '" + apellido + "', '" + cedula + "' , '" + especializacion + "','" + horario + "', " + salario + ", '" + sexo + "','" + pass + "');";
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
                }
            else {
                return false;
                }
            }

        public bool Edit ( string nombre , string apellido , string cedula , string especializacion , string horario , float salario , char sexo , string pass ) {
            if ( existeCedula(cedula) ) {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "UPDATE medico SET nombre_medico = '" + nombre + "', apellido_medico = '" + apellido + "', especializacion = '" + especializacion + "', horario = '" + horario + "', salario = " + salario + ", sexo = '" + sexo + "', password = '" + pass + "' where cedula = '" + cedula + "';";
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
                }
            else {
                return false;
                }
            }

        public bool Delete ( string cedula ) {
            if ( existeCedula(cedula) ) {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "DELETE FROM medico WHERE cedula = '" + cedula + "';";
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
                }
            else {
                return false;
                }
            }

        }
    }
