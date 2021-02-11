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

namespace Hotel.UI {
    public partial class Administrador : Form {
        public Administrador ( ) {
            InitializeComponent();
            } 

        private void medicosToolStripMenuItem_Click ( object sender , EventArgs e ) {
            //Objeto para obtener datos mediante metodo de verRegistros
            MedicoDao medico = new MedicoDao();
            indicacionLabel.Text = "Medicos";
            //Mostrar todos los datos de la lista resultante
            datosTablaDGV.DataSource = medico.VerRegistros("medico order by cedula");
            }

        private void pacientesToolStripMenuItem_Click ( object sender , EventArgs e ) {
            //Objeto para obtener datos mediante metodo de verRegistros
            PacienteDao paciente = new PacienteDao();
            indicacionLabel.Text = "Pacientes";
            //Mostrar todos los datos de la lista resultante
            datosTablaDGV.DataSource = paciente.VerRegistros("paciente order by nss");
            }

        private void consultoriosToolStripMenuItem_Click ( object sender , EventArgs e ) {            
            ConsultorioDao consultorio = new ConsultorioDao();
            indicacionLabel.Text = "Consultorio";            
            datosTablaDGV.DataSource = consultorio.VerRegistros("consultorio order by horario");
            }

        private void citasToolStripMenuItem_Click ( object sender , EventArgs e ) {
            //Objeto para obtener datos mediante metodo de verRegistros
            CitaDao cita = new CitaDao();
            indicacionLabel.Text = "Citas";
            //Mostrar todos los datos de la lista resultante
            datosTablaDGV.DataSource = cita.VerRegistros("cita order by numero_cita");
            }

        private void recetasToolStripMenuItem_Click ( object sender , EventArgs e ) {
            //Objeto para obtener datos mediante metodo de verRegistros
            RecetaDao receta = new RecetaDao();
            indicacionLabel.Text = "Recetas";
            //Mostrar todos los datos de la lista resultante
            datosTablaDGV.DataSource = receta.VerRegistros("receta order by numero_receta");
            }
        }
    
    }
