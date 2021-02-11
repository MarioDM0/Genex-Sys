using Hotel.DTO;
using Npgsql;
using System.Collections.Generic;
using System.Data;

namespace Hotel.DAO {
    class PacienteDao : Conexion {
        NpgsqlDataReader LeerFilas;
        NpgsqlCommand comm = new NpgsqlCommand();

        //Metodos
        public PacienteDTO ObtenerPaciente ( int nss ) {
            PacienteDTO paciente = new PacienteDTO();
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from paciente where nss = " + nss + ";";
            comm.ExecuteNonQuery();
            LeerFilas = comm.ExecuteReader();
            if ( LeerFilas.HasRows ) {
                while ( LeerFilas.Read() ) {
                    paciente.Nombre = LeerFilas.GetString(0);
                    paciente.Apellido = LeerFilas.GetString(1);
                    paciente.Curp = LeerFilas.GetString(2);
                    paciente.Nss = LeerFilas.GetInt32(3);
                    paciente.Codigo_Postal = LeerFilas.GetInt32(4);
                    paciente.Sexo = LeerFilas.GetChar(5);  
                    }
                }
            LeerFilas.Close();
            conn.Close();
            return paciente;
            }

        public List<PacienteDTO> VerRegistros ( string condicion ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from " + condicion + ";";
            comm.ExecuteNonQuery();            

            LeerFilas = comm.ExecuteReader();
            List<PacienteDTO> listaGenerica = new List<PacienteDTO>();
            while ( LeerFilas.Read() ) {
                listaGenerica.Add(new PacienteDTO {
                    Nombre = LeerFilas.GetString(0),
                    Apellido = LeerFilas.GetString(1),
                    Curp = LeerFilas.GetString(2),
                    Nss = LeerFilas.GetInt32(3),
                    Codigo_Postal = LeerFilas.GetInt32(4) ,                    
                    Sexo = LeerFilas.GetChar(5),                                        
                });                
                }
            LeerFilas.Close();
            conn.Close();
            return listaGenerica;
            }

        public bool existeNss ( int nss ) {
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
        public bool existeCurp ( string curp ) {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from paciente where curp = '" + curp + "';";
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

        public bool Insert ( string nombre , string apellido , string curp , int nss , int cp , char sexo ) {
            if ( !existeNss(nss) && !existeCurp(curp) ) {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO paciente VALUES ('" + nombre + "', '" + apellido + "', '" + curp + "' , " + nss + "," + cp + ", '" + sexo + "');";
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
                }
            else {
                return false;
                }
            }

        public bool Edit ( string nombre , string apellido , string curp , int nss , int cp , char sexo ) {
            if ( existeNss(nss) && existeCurp(curp)) {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "UPDATE paciente SET nombre_paciente = '" + nombre + "', apellido_paciente = '" + apellido + "',  codigo_postal = " + cp+ ", sexo = '" + sexo + "';";
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
                }
            else {
                return false;
                }
            }
        public bool Delete ( int nss ) {
            if ( existeNss(nss) ) {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "DELETE FROM paciente WHERE nss = " + nss + ";";
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
