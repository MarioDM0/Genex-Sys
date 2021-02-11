using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DAO;

namespace Hotel.DTO {
    public class CitaDTO {
        int _Numero_Cita;        
        int _Nss;
        string _Cedula;
        DateTime _horario;

        public int Numero_Cita {
            get => _Numero_Cita;
            set => _Numero_Cita = value;
            }
        public int Nss {
            get => _Nss;
            set => _Nss = value;
            }
        public string Cedula {
            get => _Cedula;
            set => _Cedula = value;
            }
        public DateTime Horario {
            get => _horario;
            set => _horario = value;
            }
        }
    }
