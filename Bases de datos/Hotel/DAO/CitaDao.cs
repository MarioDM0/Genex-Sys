using Hotel.DTO;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Hotel.DAO {
    class CitaDao : Conexion {
        NpgsqlDataReader LeerFilas;
        NpgsqlCommand comm = new NpgsqlCommand();

        //Metodos
        public CitaDTO ObtenerCita ( DateTime horario ) {
            CitaDTO cita = new CitaDTO();
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from cita where horario = '" + horario + "';";
            comm.ExecuteNonQuery();
            LeerFilas = comm.ExecuteReader();
            if ( LeerFilas.HasRows ) {
                while ( LeerFilas.Read() ) {
                    cita.Numero_Cita = LeerFilas.GetInt32(0);
                    cita.Nss = LeerFilas.GetInt32(1);
                    cita.Cedula = LeerFilas.GetString(2);
                    cita.Horario = LeerFilas.GetDateTime(3);                    
                    }
                }
            LeerFilas.Close();
            conn.Close();
            return cita;
            }

        public List<CitaDTO> VerRegistros ( string condicion ) {
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
            List<CitaDTO> listaGenerica = new List<CitaDTO>();
            //Mientras haya tuplas
            while ( LeerFilas.Read() ) {
                //Añador todos los campos a una clase 
                listaGenerica.Add(new CitaDTO {
                    Numero_Cita = LeerFilas.GetInt32(0) ,
                    Nss = LeerFilas.GetInt32(1) ,
                    Cedula = LeerFilas.GetString(2) ,
                    Horario = LeerFilas.GetDateTime(3) ,
                    });
                }
            //Cerrar conexiones
            LeerFilas.Close();
            conn.Close();
            //Devolver la lista de todo
            return listaGenerica;
            }

        bool existeCedula ( string cedula ) {
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

        public bool existeCita ( DateTime horario, string cedula ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from cita where horario = '" + horario + "' and cedula = '"+cedula+"';";
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

        bool existeNss ( int nss ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from paciente where nss = " + nss + ";";
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

        bool horarioEstaDisponible ( DateTime horario , string consultorio ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from consultorio where horario = '" + horario + "' and " + consultorio + " = true;";
            comm.ExecuteNonQuery();
            LeerFilas = comm.ExecuteReader();
            if ( !LeerFilas.HasRows ) {
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

        int ultimaCita ( ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select MAX(numero_cita) from cita;";
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

        bool medicoEstaDisponible ( DateTime horario , string cedula ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from cita where horario = '" + horario + "' and cedula = '" + cedula + "';";
            comm.ExecuteNonQuery();
            LeerFilas = comm.ExecuteReader();
            if ( !LeerFilas.HasRows ) {
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

        public bool existeHorario ( DateTime horario ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from cita where horario = '" + horario + "';";
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

        bool pacienteEstaDisponible ( DateTime horario , int nss ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from cita where horario = '" + horario + "' and nss = " + nss + ";";
            comm.ExecuteNonQuery();
            LeerFilas = comm.ExecuteReader();
            if ( !LeerFilas.HasRows ) {
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

        //Pendientes
        public int Insert ( DateTime horario , string cedula , int nss , string consultorio ) {
            if ( !existeCedula(cedula) ) {
                //No existe cedula de doctor
                return 1;
                }
            else {
                if ( !existeNss(nss) ) {
                    //No existe nss
                    return 2;
                    }
                else {
                    if ( !horarioEstaDisponible(horario , consultorio) ) {
                        //El horario no está disponible
                        return 3;
                        }
                    else {
                        //Medico tiene cita a esa hora
                        if ( !medicoEstaDisponible(horario , cedula) ) {
                            return 4;
                            }
                        else {
                            //Paciente tiene cita a esa hora
                            if ( !pacienteEstaDisponible(horario , nss) ) {
                                return 5;
                                }
                            else {                                
                                int cita = ultimaCita();
                                comm.CommandText = "INSERT INTO cita VALUES (" + cita + ", " + nss + ", '" + cedula + "', '" + horario + "');";
                                conn.Open();
                                comm.Connection = conn;
                                comm.ExecuteNonQuery();
                                comm.CommandText = "UPDATE consultorio SET " + consultorio + " = true WHERE horario = '" + horario + "';";
                                comm.ExecuteNonQuery();
                                conn.Close();
                                CacheData.cita = cita.ToString();
                                return 0;
                                }
                            }
                        }
                    }

                }
            }
        public void Edit ( ) {
            }
        public void Delete ( ) {
            }

        }
    }
