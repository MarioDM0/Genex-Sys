using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DAO;

namespace Hotel.DTO {
    public class RecetaDTO {
        int _Nummero_Receta;
        string _Nombre_Medico;
        string _Apellido_Medico;
        string _Nombre_Paciente;
        string _Apellido_Paciente;
        string _Cedula;
        int _Nss;
        DateTime _Fecha;
        string _Receta;

        public int Nummero_Receta {
            get => _Nummero_Receta;
            set => _Nummero_Receta = value;
            }
        public string Nombre_Medico {
            get => _Nombre_Medico;
            set => _Nombre_Medico = value;
            }
        public string Apellido_Medico {
            get => _Apellido_Medico;
            set => _Apellido_Medico = value;
            }
        public string Nombre_Paciente {
            get => _Nombre_Paciente;
            set => _Nombre_Paciente = value;
            }
        public string Apellido_Paciente {
            get => _Apellido_Paciente;
            set => _Apellido_Paciente = value;
            }
        public string Cedula {
            get => _Cedula;
            set => _Cedula = value;
            }
        public int Nss {
            get => _Nss;
            set => _Nss = value;
            }
        public DateTime Fecha {
            get => _Fecha;
            set => _Fecha = value;
            }
        public string Receta {
            get => _Receta;
            set => _Receta = value;
            }
        }
    }
