using Hotel.DAO;
using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hotel.UI {
    public partial class HistorialMedico : Form {
        public HistorialMedico ( ) {
            InitializeComponent();
            }

        void HabilitarDatos ( ) {
            medicoLabel.Visible = true;
            nombreMedicoTB.Visible = true;
            apellidoMedicoTB.Visible = true;
            pacienteLabel.Visible = true;
            nombrePacienteTB.Visible = true;
            apellidoPacienteTB.Visible = true;
            lineShape1.Visible = true;
            lineShape2.Visible = true;
            lineShape3.Visible = true;
            lineShape4.Visible = true;
            recetaLabel.Visible = true;
            recetaRTB.Visible = true;
            }

        void deshabilitarDatos ( ) {
            medicoLabel.Visible = false;
            nombreMedicoTB.Visible = false;
            apellidoMedicoTB.Visible = false;
            pacienteLabel.Visible = false;
            nombrePacienteTB.Visible = false;
            apellidoPacienteTB.Visible = false;
            lineShape1.Visible = false;
            lineShape2.Visible = false;
            lineShape3.Visible = false;
            lineShape4.Visible = false;
            recetaLabel.Visible = false;
            recetaRTB.Visible = false;
            }

        private void findButton_Click ( object sender , EventArgs e ) {
            deshabilitarDatos();
            fechasCB.Visible = false;
            RecetaDao receta = new RecetaDao();
            PacienteDao paciente = new PacienteDao();
            if ( paciente.existeNss(Convert.ToInt32(buscarTB.Text)) ) {                
                fechasCB.Items.Clear();                    
                List<RecetaDTO> historial = receta.VerRegistros("receta where nss = " + Convert.ToInt32(buscarTB.Text) + "");
                if ( historial.Count > 0 ) {
                    fechasCB.Visible = true;
                    for ( int i = 0 ; i < historial.Count ; i++ ) {
                        fechasCB.Items.Add(historial[i].Fecha.ToString());
                        }
                    }
                else {
                    MessageBox.Show("El paciente no cuenta con historial medico");
                    }
                }
            else {
                MessageBox.Show("El paciente no existe");
                }
            }


        private void buscarTB_Enter ( object sender , EventArgs e ) {
            if ( buscarTB.Text == "NSS a buscar" ) {
                buscarTB.Text = "";
                }
            }

        private void buscarTB_Leave ( object sender , EventArgs e ) {
            if ( buscarTB.Text == "" ) {
                buscarTB.Text = "NSS a buscar";
                }
            }

        private void fechasCB_SelectedIndexChanged ( object sender , EventArgs e ) {
            RecetaDao receta = new RecetaDao();
            RecetaDTO datos = receta.ObtenerReceta(Convert.ToDateTime(fechasCB.SelectedItem.ToString()));
            nombreMedicoTB.Text = datos.Nombre_Medico;
            apellidoMedicoTB.Text = datos.Apellido_Medico;
            nombrePacienteTB.Text = datos.Nombre_Paciente;
            apellidoPacienteTB.Text = datos.Apellido_Paciente;
            recetaLabel.Text = "Receta #" + datos.Nummero_Receta.ToString();
            recetaRTB.Text = datos.Receta;
            HabilitarDatos();
            }
        }
    }
