using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.DAO;
using Hotel.DTO;

namespace Hotel.UI.UI_EMPLEADOS {
    public partial class ModificarPaciente : Form {
        public ModificarPaciente ( ) {
            InitializeComponent();
            }

        private void nombreTB_Enter ( object sender , EventArgs e ) {
            if ( nombreTB.Text == "Nombre" ) {
                nombreTB.Text = "";
                nombreTB.ForeColor = Color.LightGray;
                }
            }

        private void nombreTB_Leave ( object sender , EventArgs e ) {
            if ( nombreTB.Text == "" ) {
                nombreTB.Text = "Nombre";
                nombreTB.ForeColor = Color.DimGray;
                }
            }

        private void apellidoTB_Enter ( object sender , EventArgs e ) {
            if ( apellidoTB.Text == "Apellido" ) {
                apellidoTB.Text = "";
                apellidoTB.ForeColor = Color.LightGray;
                }
            }

        private void apellidoTB_Leave ( object sender , EventArgs e ) {
            if ( apellidoTB.Text == "" ) {
                apellidoTB.Text = "Apellido";
                apellidoTB.ForeColor = Color.DimGray;
                }
            }

        private void curpTB_Enter ( object sender , EventArgs e ) {
            if ( curpTB.Text == "CURP" ) {
                curpTB.Text = "";
                curpTB.ForeColor = Color.LightGray;
                }
            }

        private void curpTB_Leave ( object sender , EventArgs e ) {
            if ( curpTB.Text == "" ) {
                curpTB.Text = "CURP";
                curpTB.ForeColor = Color.DimGray;
                }
            }

        private void nssTB_Enter ( object sender , EventArgs e ) {
            if ( nssTB.Text == "NSS" ) {
                nssTB.Text = "";
                nssTB.ForeColor = Color.LightGray;
                }
            }

        private void nssTB_Leave ( object sender , EventArgs e ) {
            if ( nssTB.Text == "" ) {
                nssTB.Text = "NSS";
                nssTB.ForeColor = Color.DimGray;
                }
            }

        private void cpTB_Enter ( object sender , EventArgs e ) {
            if ( cpTB.Text == "Codigo Postal" ) {
                cpTB.Text = "";
                cpTB.ForeColor = Color.LightGray;
                }
            }

        private void cpTB_Leave ( object sender , EventArgs e ) {
            if ( cpTB.Text == "" ) {
                cpTB.Text = "Codigo Postal";
                cpTB.ForeColor = Color.DimGray;
                }
            }

        private void sexoTB_Enter ( object sender , EventArgs e ) {
            if ( sexoTB.Text == "Sexo" ) {
                sexoTB.Text = "";
                sexoTB.ForeColor = Color.LightGray;
                }
            }

        private void sexoTB_Leave ( object sender , EventArgs e ) {
            if ( sexoTB.Text == "" ) {
                sexoTB.Text = "Sexo";
                sexoTB.ForeColor = Color.DimGray;
                }
            }

        private void modificarButton_Click ( object sender , EventArgs e ) {
            PacienteDao modificar = new PacienteDao();
            bool seModifico = modificar.Edit(nombreTB.Text,apellidoTB.Text,curpTB.Text, Convert.ToInt32(nssTB.Text),Convert.ToInt32(cpTB.Text),sexoTB.Text[0]);
            if ( seModifico ) {
                MessageBox.Show("Modificado correctamente");
                }
            else {
                MessageBox.Show("Modificado correctamente");
                }
            DesHabilitarDatos();
            }

        private void findButton_Click ( object sender , EventArgs e ) {
            PacienteDTO paciente = new PacienteDTO();
            PacienteDao datos = new PacienteDao();
            if ( datos.existeNss(Convert.ToInt32(findNssTB.Text)) ) {
                paciente = datos.ObtenerPaciente(Convert.ToInt32(findNssTB.Text));
                HabilitarDatos();
                nombreTB.Text = paciente.Nombre;
                apellidoTB.Text = paciente.Apellido;
                curpTB.Text = paciente.Curp;
                nssTB.Text = paciente.Nss.ToString();
                cpTB.Text = paciente.Codigo_Postal.ToString();                
                sexoTB.Text = Convert.ToString(paciente.Sexo);                
                }
            else {
                DesHabilitarDatos();
                MessageBox.Show("No existe el paciente con dicha cedula");
                }
            }

        private void HabilitarDatos ( ) {
            modificarButton.Visible = true;
            cancelarButton.Visible = true;
            lineShape1.Visible = true;
            lineShape2.Visible = true;
            lineShape3.Visible = true;
            lineShape4.Visible = true;
            lineShape5.Visible = true;
            lineShape6.Visible = true;            
            nombreTB.Visible = true;            
            apellidoTB.Visible = true;
            curpTB.Visible = true;
            nssTB.Visible = true;
            cpTB.Visible = true;
            sexoTB.Visible = true;           
            }

        private void DesHabilitarDatos ( ) {
            modificarButton.Visible = false;
            cancelarButton.Visible = false;
            lineShape1.Visible = false;
            lineShape2.Visible = false;
            lineShape3.Visible = false;
            lineShape4.Visible = false;
            lineShape5.Visible = false;
            lineShape6.Visible = false;            
            nombreTB.Visible = false;
            apellidoTB.Visible = false;
            curpTB.Visible = false;
            nssTB.Visible = false;
            cpTB.Visible = false;
            sexoTB.Visible = false;            
            }

        private void cancelarButton_Click ( object sender , EventArgs e ) {
            DesHabilitarDatos();
            }

        private void findCedulaTB_Enter ( object sender , EventArgs e ) {
            if ( findNssTB.Text == "NSS a buscar" ) {
                findNssTB.Text = "";
                findNssTB.ForeColor = Color.LightGray;
                }
            }

        private void findCedulaTB_Leave ( object sender , EventArgs e ) {
            if ( findNssTB.Text == "" ) {
                findNssTB.Text = "NSS a buscar";
                findNssTB.ForeColor = Color.DimGray;
                }
            }
        }
    }
