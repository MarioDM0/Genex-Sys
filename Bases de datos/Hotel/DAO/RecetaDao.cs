using Hotel.DTO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace Hotel.DAO {
    class RecetaDao : Conexion {
        NpgsqlDataReader LeerFilas;
        NpgsqlCommand comm = new NpgsqlCommand();


        //Metodos
        public RecetaDTO ObtenerReceta ( DateTime horario) {
            RecetaDTO receta = new RecetaDTO();
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from receta where fecha = '" + horario + "';";
            comm.ExecuteNonQuery();
            LeerFilas = comm.ExecuteReader();
            if ( LeerFilas.HasRows ) {
                while ( LeerFilas.Read() ) {
                    receta.Nummero_Receta = LeerFilas.GetInt32(0);
                    receta.Nombre_Medico = LeerFilas.GetString(1);
                    receta.Apellido_Medico = LeerFilas.GetString(2);
                    receta.Nombre_Paciente = LeerFilas.GetString(3);
                    receta.Apellido_Paciente = LeerFilas.GetString(4);
                    receta.Cedula = LeerFilas.GetString(5);
                    receta.Nss = LeerFilas.GetInt32(6);
                    receta.Fecha = LeerFilas.GetDateTime(7);
                    receta.Receta = LeerFilas.GetString(8);
                    }
                }
            LeerFilas.Close();
            conn.Close();
            return receta;
            }

        public List<RecetaDTO> VerRegistros ( string condicion ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from " + condicion + ";";
            comm.ExecuteNonQuery();            

            LeerFilas = comm.ExecuteReader();
            List<RecetaDTO> listaGenerica = new List<RecetaDTO>();
            while ( LeerFilas.Read() ) {
                listaGenerica.Add(new RecetaDTO {                    
                    Nummero_Receta = LeerFilas.GetInt32(0) ,
                    Nombre_Medico = LeerFilas.GetString(1) ,
                    Apellido_Medico = LeerFilas.GetString(2) ,
                    Nombre_Paciente = LeerFilas.GetString(3) ,
                    Apellido_Paciente = LeerFilas.GetString(4) ,
                    Cedula = LeerFilas.GetString(5) ,
                    Nss = LeerFilas.GetInt32(6) ,
                    Fecha = LeerFilas.GetDateTime(7) ,
                    Receta = LeerFilas.GetString(8)               
                });                
                }
            LeerFilas.Close();
            conn.Close();
            return listaGenerica;
            }

        public bool existeReceta ( DateTime fecha ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from receta where fecha = '" + fecha + "';";
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

        public int ultimaReceta ( ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select MAX(numero_receta) from receta;";
            comm.ExecuteNonQuery();
            LeerFilas = comm.ExecuteReader();
            int resultado = 0;
            while ( LeerFilas.Read() ) {
                resultado = LeerFilas.GetInt32(0) + 1;
                }
            LeerFilas.Close();
            conn.Close();
            return resultado;
            }

        public bool Insert ( int numero , string nombreMedico , string apellidoMedico, string nombrePaciente, string apellidoPaciente, string cedula, int nss , DateTime fecha, string receta ) {
            if (!existeReceta(fecha)) {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO receta VALUES (" + numero + ", '" + nombreMedico + "', '" + apellidoMedico + "' , '" + nombrePaciente + "' , '" + apellidoPaciente + "' , '" + cedula + "' , " + nss + ",'" + fecha + "', '" + receta + "');";
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
                }
            else {
                return false;
                }
            }
        public void Edit ( ) {
            }

        public void Delete ( ) {
            }

        }
    }
