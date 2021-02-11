using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Npgsql;
using Hotel.UI;
using Hotel.DAO;

namespace Hotel {
    public partial class LoginEmpleado : Form {
        public LoginEmpleado ( ) {
            InitializeComponent();
            }

        [DllImport("user32.DLL" , EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture ( );
        [DllImport("user32.DLL" , EntryPoint = "SendMessage")]
        private extern static void SendMessage ( System.IntPtr hwnd , int wmsg , int wparam , int lparam );

        private void userTB_Enter ( object sender , EventArgs e ) {
            if ( userTB.Text == "ID" ) {
                userTB.Text = "";
                userTB.ForeColor = Color.LightGray;
                }
            }

        private void userTB_Leave ( object sender , EventArgs e ) {
            if ( userTB.Text == "" ) {
                userTB.Text = "ID";
                userTB.ForeColor = Color.DimGray;
                }
            }

        private void passwordTB_Enter ( object sender , EventArgs e ) {
            if ( passwordTB.Text == "Contraseña" ) {
                passwordTB.Text = "";
                passwordTB.ForeColor = Color.LightGray;
                passwordTB.UseSystemPasswordChar = true;
                }
            }

        private void passwordTB_Leave ( object sender , EventArgs e ) {
            if ( passwordTB.Text == "" ) {
                passwordTB.Text = "Contraseña";
                passwordTB.ForeColor = Color.DimGray;
                passwordTB.UseSystemPasswordChar = false;
                }
            }

        private void logginButton_Click ( object sender , EventArgs e ) {
            if ( userTB.Text != "ID" ) {
                if ( passwordTB.Text != "Contraseña" ) {
                    MedicoDao login = new MedicoDao();
                    bool exist = login.Login( userTB.Text , passwordTB.Text);
                    if ( exist ) {
                        AreaEmpleados area = new AreaEmpleados();
                        area.Show();                        
                        area.FormClosed += LogoutPrincipal;
                        this.Hide();
                        }
                    else {
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
            errorMessageLabel.Text = msg;
            errorMessageLabel.Visible = true;
            }

        private void userTB_KeyPress ( object sender , KeyPressEventArgs e ) {
            SoloNumeros(e);
            }

        public static void SoloNumeros ( KeyPressEventArgs v ) {
            if ( Char.IsDigit(v.KeyChar) ) {
                v.Handled = false;
                }
            else if ( Char.IsSeparator(v.KeyChar) ) {
                v.Handled = false;
                }
            else if ( Char.IsControl(v.KeyChar) ) {
                v.Handled = false;
                }
            else {
                v.Handled = true;                
                }
            }

        private void minimizeButton_Click ( object sender , EventArgs e ) {
            this.WindowState = FormWindowState.Minimized;
            }

        private void closeButton_Click ( object sender , EventArgs e ) {
            this.Close();
            }

        private void LogoutPrincipal ( object sender , FormClosedEventArgs e ) {
            userTB.Clear();
            userTB.Text = "Usuario";
            passwordTB.Clear();
            errorMessageLabel.Hide();
            this.BringToFront();
            this.Show();
            }

        private void LoginEmpleado_MouseDown ( object sender , MouseEventArgs e ) {
            ReleaseCapture();
            SendMessage(this.Handle , 0x112 , 0xf012 , 0);
            }
        }
    }
