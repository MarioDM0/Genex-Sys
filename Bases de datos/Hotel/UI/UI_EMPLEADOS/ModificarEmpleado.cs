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
    public partial class ModificarEmpleado : Form {
        public ModificarEmpleado ( ) {
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

        private void cedulaTB_Enter ( object sender , EventArgs e ) {
            if ( cedulaTB.Text == "Cedula" ) {
                cedulaTB.Text = "";
                cedulaTB.ForeColor = Color.LightGray;
                }
            }

        private void cedulaTB_Leave ( object sender , EventArgs e ) {
            if ( cedulaTB.Text == "" ) {
                cedulaTB.Text = "Cedula";
                cedulaTB.ForeColor = Color.DimGray;
                }
            }

        private void especializacionTB_Enter ( object sender , EventArgs e ) {
            if ( especializacionTB.Text == "Especializacion" ) {
                especializacionTB.Text = "";
                especializacionTB.ForeColor = Color.LightGray;
                }
            }

        private void especializacionTB_Leave ( object sender , EventArgs e ) {
            if ( especializacionTB.Text == "" ) {
                especializacionTB.Text = "Especializacion";
                especializacionTB.ForeColor = Color.DimGray;
                }
            }

        private void horarioTB_Enter ( object sender , EventArgs e ) {
            if ( horarioTB.Text == "Horario" ) {
                horarioTB.Text = "";
                horarioTB.ForeColor = Color.LightGray;
                }
            }

        private void salarioTB_Leave ( object sender , EventArgs e ) {
            if ( horarioTB.Text == "" ) {
                horarioTB.Text = "Salario";
                horarioTB.ForeColor = Color.DimGray;
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

    private void passTB_Enter ( object sender , EventArgs e ) {
            if ( passTB.Text == "Contraseña" ) {
                passTB.Text = "";
                passTB.ForeColor = Color.LightGray;
                }
            }

        private void passTB_Leave ( object sender , EventArgs e ) {
            if ( passTB.Text == "" ) {
                passTB.Text = "Contraseña";
                passTB.ForeColor = Color.DimGray;
                }
            }

        private void modificarButton_Click ( object sender , EventArgs e ) {
            MedicoDao modificar = new MedicoDao();
            bool seModifico = modificar.Edit(nombreTB.Text,apellidoTB.Text,cedulaTB.Text,especializacionTB.Text,horarioTB.Text,(float)Convert.ToDouble(salarioTB.Text),sexoTB.Text[0],passTB.Text);
            MessageBox.Show("Modificado correctamente");
            DesHabilitarDatos();
            }

        private void salarioTB_Enter ( object sender , EventArgs e ) {
            if ( salarioTB.Text == "Salario" ) {
                salarioTB.Text = "";
                salarioTB.ForeColor = Color.LightGray;
                }
            }

        private void horarioTB_Leave ( object sender , EventArgs e ) {
            if ( horarioTB.Text == "" ) {
                horarioTB.Text = "Horario";
                horarioTB.ForeColor = Color.DimGray;
                }
            }

        private void findButton_Click ( object sender , EventArgs e ) {
            MedicoDTO medico = new MedicoDTO();
            MedicoDao datos = new MedicoDao();
            if ( datos.existeCedula(findCedulaTB.Text) ) {
                medico = datos.ObtenerMedico(findCedulaTB.Text);
                HabilitarDatos();
                nombreTB.Text = medico.Nombre;
                apellidoTB.Text = medico.Apellido;
                cedulaTB.Text = medico.Cedula;
                especializacionTB.Text = medico.Especializacion;
                horarioTB.Text = medico.Horario;
                salarioTB.Text = Convert.ToString(medico.Salario);
                sexoTB.Text = Convert.ToString(medico.Sexo);
                passTB.Text = medico.Password;
                }
            else {
                DesHabilitarDatos();
                MessageBox.Show("No existe el medico con dicha cedula");
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
            lineShape7.Visible = true;
            lineShape8.Visible = true;
            nombreTB.Visible = true;            
            apellidoTB.Visible = true;
            cedulaTB.Visible = true;
            especializacionTB.Visible = true;
            horarioTB.Visible = true;
            salarioTB.Visible = true;
            sexoTB.Visible = true;
            passTB.Visible = true;
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
            lineShape7.Visible = false;
            lineShape8.Visible = false;
            nombreTB.Visible = false;
            apellidoTB.Visible = false;
            cedulaTB.Visible = false;
            especializacionTB.Visible = false;
            horarioTB.Visible = false;
            salarioTB.Visible = false;
            sexoTB.Visible = false;
            passTB.Visible = false;
            }

        private void cancelarButton_Click ( object sender , EventArgs e ) {
            DesHabilitarDatos();
            }

        private void findCedulaTB_Enter ( object sender , EventArgs e ) {
            if ( findCedulaTB.Text == "Cedula a buscar" ) {
                findCedulaTB.Text = "";
                findCedulaTB.ForeColor = Color.LightGray;
                }
            }

        private void findCedulaTB_Leave ( object sender , EventArgs e ) {
            if ( findCedulaTB.Text == "" ) {
                findCedulaTB.Text = "Cedula a buscar";
                findCedulaTB.ForeColor = Color.DimGray;
                }
            }
        }
    }
