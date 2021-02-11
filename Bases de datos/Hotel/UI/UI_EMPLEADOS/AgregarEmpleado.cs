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

namespace Hotel.UI.UI_EMPLEADOS {
    public partial class AgregarEmpleado : Form {
        public AgregarEmpleado ( ) {
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

        private void agregarButton_Click ( object sender , EventArgs e ) {
            MedicoDao insertar = new MedicoDao();
            bool seInserto = insertar.Insert(nombreTB.Text,apellidoTB.Text,cedulaTB.Text,especializacionTB.Text,horarioTB.Text,(float)Convert.ToDouble(salarioTB.Text),sexoTB.Text[0],passTB.Text);
            string resultado;
            if ( seInserto ) {
                resultado = "Insertado correctamente";
                }
            else {
                resultado = "La cedula ya existe";
                }
            nombreTB.Clear();
            apellidoTB.Clear();cedulaTB.Clear();
            especializacionTB.Clear();
            horarioTB.Clear();
            salarioTB.Clear();
            sexoTB.Clear();
            passTB.Clear();
            MessageBox.Show(resultado);
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
        }
    }
