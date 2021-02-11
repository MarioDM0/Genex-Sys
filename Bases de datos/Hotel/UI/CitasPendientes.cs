using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.DAO;
using Hotel.DTO;

namespace Hotel.UI {
    public partial class CitasPendientes : Form {
        public CitasPendientes ( ) {
            InitializeComponent();
            MostrarDatos();
            }

        void MostrarDatos ( ) {
            CitaDao citas = new CitaDao();
            CitaDTO datos = new CitaDTO();
            List<CitaDTO> pendientes = citas.VerRegistros("cita");
            List<CitaDTO> aux = new List<CitaDTO>();
            for ( int i = 0 ; i < pendientes.Count ; i++ ) {
                if ( pendientes[i].Horario.Date == DateTime.Now.Date && CacheData.cedula == pendientes[i].Cedula ) {
                    aux.Add(pendientes[i]);
                    }
                }
            if ( aux.Count > 0 ) {
                datosTablaDGV.DataSource = aux;
                }
            else {
                MessageBox.Show("No tienes citas pendientes");
                }
            }

        }
    
    }
