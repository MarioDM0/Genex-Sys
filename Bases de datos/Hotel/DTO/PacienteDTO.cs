using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DAO;

namespace Hotel.DTO {
    public class PacienteDTO {
        string _Nombre;        
        string _Apellido;
        string _Curp;
        int _Nss;
        int _Codigo_Postal;        
        char _Sexo;

        public string Nombre {
            get => _Nombre;
            set => _Nombre = value;
            }
        public string Apellido {
            get => _Apellido;
            set => _Apellido = value;
            }
        public string Curp {
            get => _Curp;
            set => _Curp = value;
            }
        public int Nss {
            get => _Nss;
            set => _Nss = value;
            }
        public int Codigo_Postal {
            get => _Codigo_Postal;
            set => _Codigo_Postal = value;
            }
        public char Sexo {
            get => _Sexo;
            set => _Sexo = value;
            }
        }
    }
