using Hotel.DTO;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Hotel.DAO {
    class ConsultorioDao : Conexion {
        NpgsqlDataReader LeerFilas;
        NpgsqlCommand comm = new NpgsqlCommand();

        //Metodos
        public List<ConsultorioDTO> VerRegistros ( string condicion ) {
            //Abrir y clonar conexion
            conn.Open();
            comm.Connection = conn;
            //Comando a ejecutar
            comm.CommandText = "select * from " + condicion + ";";
            //Ejecutar comando respecto a la base de datos
            comm.ExecuteNonQuery();

            //Revisar si hubo filaas
            LeerFilas = comm.ExecuteReader();
            //Crear una lista para todos los registros
            List<ConsultorioDTO> listaGenerica = new List<ConsultorioDTO>();
            //Mientras haya tuplas
            while ( LeerFilas.Read() ) {
                //Añador todos los campos a una clase 
                listaGenerica.Add(new ConsultorioDTO {
                    Horario = LeerFilas.GetDateTime(0) ,
                    Uno = LeerFilas.GetBoolean(1) ,
                    Dos = LeerFilas.GetBoolean(1) ,
                    Tres = LeerFilas.GetBoolean(1) ,
                    Cuatro = LeerFilas.GetBoolean(1) ,
                    Cinco = LeerFilas.GetBoolean(1) ,
                    Seis = LeerFilas.GetBoolean(1) ,
                    Siete = LeerFilas.GetBoolean(1) ,
                    });
                }
            //Cerrar conexiones
            LeerFilas.Close();
            conn.Close();
            //Devolver la lista de todo
            return listaGenerica;
            }


        //Pendientes
        public int Insert ( DateTime horario , bool uno, bool dos, bool tres, bool cuatro, bool cinco , bool seis, bool siete ) {           
            conn.Open();
            comm.Connection = conn;                        
            comm.CommandText = "INSERT INTO consultorio VALUES ('" + horario + "', '"+uno.ToString()+ "' ,'" + dos.ToString() + "', '" + tres.ToString() + "' , '" + cuatro.ToString() + "' , '" + cinco.ToString() + "' , '" + seis.ToString() + "' , '" + siete.ToString() + "');";
            comm.ExecuteNonQuery();            
            conn.Close();
            return 0;                                            
            }
        public void Edit ( ) {
            }
        public void Delete ( ) {
            }

        }
    }
