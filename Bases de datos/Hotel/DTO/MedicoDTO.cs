using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DAO;

namespace Hotel.DTO {
    public class MedicoDTO {
        string _Nombre;        
        string _Apellido;
        string _Cedula;
        string _Especializacion;
        string _Horario;
        float _Salario;
        char _Sexo;                        
        string password;

        public string Nombre {
            get => _Nombre;
            set => _Nombre = value;
            }
        public string Apellido {
            get => _Apellido;
            set => _Apellido = value;
            }
        public string Cedula {
            get => _Cedula;
            set => _Cedula = value;
            }
        public string Especializacion {
            get => _Especializacion;
            set => _Especializacion = value;
            }
        public string Horario {
            get => _Horario;
            set => _Horario = value;
            }
        public float Salario {
            get => _Salario;
            set => _Salario = value;
            }
        public char Sexo {
            get => _Sexo;
            set => _Sexo = value;
            }
        public string Password {
            get => password;
            set => password = value;
            }

        public bool LoginEmpleado ( string cedula , string password ) {
            MedicoDao empleado = new MedicoDao();
            return empleado.Login(cedula , password);
            }
        }
    }
