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
    public partial class AgregarPaciente : Form {
        public AgregarPaciente ( ) {
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

        private void especializacionTB_Enter ( object sender , EventArgs e ) {
            if ( nssTB.Text == "NSS" ) {
                nssTB.Text = "";
                nssTB.ForeColor = Color.LightGray;
                }
            }

        private void especializacionTB_Leave ( object sender , EventArgs e ) {
            if ( nssTB.Text == "" ) {
                nssTB.Text = "NSS";
                nssTB.ForeColor = Color.DimGray;
                }
            }

        private void agregarButton_Click ( object sender , EventArgs e ) {
            PacienteDao insertar = new PacienteDao();
            bool seInserto = insertar.Insert(nombreTB.Text,apellidoTB.Text,curpTB.Text, Convert.ToInt32(nssTB.Text), Convert.ToInt32(cpTB.Text), sexoCB.Text[0] );
            string resultado;
            if ( seInserto ) {
                resultado = "Insertado correctamente";
                }
            else {
                resultado = "NSS o CURP ya existen";
                }
            nombreTB.Clear();
            apellidoTB.Clear();curpTB.Clear();
            nssTB.Clear();
            cpTB.Clear();           
            MessageBox.Show(resultado);
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
        }
    }
