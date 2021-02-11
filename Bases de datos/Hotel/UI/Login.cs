using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Npgsql;
using Hotel.UI;
using Hotel.DAO;

namespace Hotel {
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent();
            }

        //Metodos para movimiento de form
        [DllImport("user32.DLL" , EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL" , EntryPoint = "SendMessage")]
        private extern static void SendMessage ( System.IntPtr hwnd , int wmsg , int wparam , int lparam );
        
        private void userTB_Enter ( object sender , EventArgs e ) {
            //Cada que se ingrese se vacia si es que no hay caracteres escritos
            if ( userTB.Text == "Usuario" ) {
                userTB.Text = "";
                userTB.ForeColor = Color.LightGray;
                }
            }

        private void userTB_Leave ( object sender , EventArgs e ) {
            //Cada que se sale del text boxx, si no se escribio nada, se vuelve a dejar por defecto
            if ( userTB.Text == "" ) {
                userTB.Text = "Usuario";
                userTB.ForeColor = Color.DimGray;
                }
            }

        private void passwordTB_Enter ( object sender , EventArgs e ) {
            //Cada que se ingrese se vacia si es que no hay caracteres escritos
            if ( passwordTB.Text == "Contraseña" ) {
                passwordTB.Text = "";
                passwordTB.ForeColor = Color.LightGray;
                passwordTB.UseSystemPasswordChar = true;
                }
            }

        private void passwordTB_Leave ( object sender , EventArgs e ) {
            //Cada que se sale del text boxx, si no se escribio nada, se vuelve a dejar por defecto
            if ( passwordTB.Text == "" ) {
                passwordTB.Text = "Contraseña";
                passwordTB.ForeColor = Color.DimGray;
                passwordTB.UseSystemPasswordChar = false;
                }
            }

        private void closeButton_Click ( object sender , EventArgs e ) {                  
            Application.Exit();
            }

        private void minimizeButton_Click ( object sender , EventArgs e ) {
            this.WindowState = FormWindowState.Minimized;
            }

        private void Form1_MouseDown ( object sender , MouseEventArgs e ) {
            ReleaseCapture();
            SendMessage(this.Handle , 0x112 , 0xf012 , 0);
            }

        private void panel1_MouseDown ( object sender , MouseEventArgs e ) {
            ReleaseCapture();
            SendMessage(this.Handle , 0x112 , 0xf012 , 0);
            }

        private void logginButton_Click ( object sender , EventArgs e ) {
            //Al presionar Login revisar todo
            //Si no se ingreso texto alguno en usuario enviar error a label
            if ( userTB.Text != "Usuario" ) {
                //Si no se ingreso texto alguno en contraseña enviar error a label
                if ( passwordTB.Text != "Contraseña" ) {
                    //Revisar que sea el admin con la contraseña para activar el servicio
                    if ( userTB.Text == "admin" && passwordTB.Text == "md5" ) {
                        //Enviar a seleccion de empleado o administrador
                        Seleccion selec = new Seleccion();
                        selec.Show();                        
                        //Sobrecargar funcion de cierre de formulario para mostrar de nuevo este a futuro
                        selec.FormClosed += LogoutPrincipal;
                        this.Hide();                        
                        }
                    else {
                        //Enviar datos incorrectos y limpiar text box's
                        showErrorMessage("Datos incorrectos");
                        userTB.Clear();
                        passwordTB.Clear();
                        }
                    }
                else {
                    showErrorMessage("Ingrese su contraseaña");
                    }
                }
            else {
                showErrorMessage("Ingrese su nombre de usuario");
                }                      
            }

        private void showErrorMessage (string msg ) {
            //Mostrar label de error con su respectivo error
            errorMessageLabel.Text = msg;
            errorMessageLabel.Visible = true;
            }

        private void LogoutPrincipal ( object sender , FormClosedEventArgs e ) {
            //Limpiar todos los campos
            userTB.Clear();
            userTB.Text = "Usuario";
            passwordTB.Clear();            
            errorMessageLabel.Hide();
            //Traer al frente y mostrar formulario oculto
            this.BringToFront();
            this.Show();
            }
        }
    }
