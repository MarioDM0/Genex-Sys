using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Bases_de_datos {
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent();
            
            }        

        private void CancelarButton_Click ( object sender , EventArgs e ) {
            userTB.Text = "";
            passwordTB.Text = "";
            }

        private void IniciarButton_Click ( object sender , EventArgs e ) {
            if ( userTB.Text.Length > 0 && passwordTB.Text.Length > 0 ) {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=admin;Password=manzano123;Database = postgres");
                conn.Open();                
                MessageBox.Show("Conectado");
                conn.Close();
                MessageBox.Show("Desconectado");
                //this.Hide();
                Form2 frm = new Form2();
                frm.Show();
                //this.Show();
                }
            else {
                MessageBox.Show("Alguno de los campos se encuentra sin datos","Datos erroneos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        
        }
    }
