using System;

namespace Hotel.DTO {
    public class ConsultorioDTO {
        DateTime _horario;
        bool _uno;
        bool _dos;
        bool _tres;
        bool _cuatro;
        bool _cinco;
        bool _seis;
        bool _siete;

        public DateTime Horario {
            get => _horario;
            set => _horario = value;
            }
        public bool Uno {
            get => _uno;
            set => _uno = value;
            }
        public bool Dos {
            get => _dos;
            set => _dos = value;
            }
        public bool Tres {
            get => _tres;
            set => _tres = value;
            }
        public bool Cuatro {
            get => _cuatro;
            set => _cuatro = value;
            }
        public bool Cinco {
            get => _cinco;
            set => _cinco = value;
            }
        public bool Seis {
            get => _seis;
            set => _seis = value;
            }
        public bool Siete {
            get => _siete;
            set => _siete = value;
            }
        }
    }
