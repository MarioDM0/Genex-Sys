using Hotel.DAO;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hotel.UI {
    public partial class RealizarCita : Form {
        public RealizarCita ( ) {
            InitializeComponent();
            }

        [DllImport("user32.DLL" , EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture ( );
        [DllImport("user32.DLL" , EntryPoint = "SendMessage")]
        private extern static void SendMessage ( System.IntPtr hwnd , int wmsg , int wparam , int lparam );

        private void LoadTheme ( ) {
            foreach ( Control btns in this.Controls ) {
                if ( btns.GetType() == typeof(Button) ) {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColors.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
                    }
                }
            }

        private void RealizarCita_Load ( object sender , EventArgs e ) {
            LoadTheme();
            }

        private void curpTB_Enter ( object sender , EventArgs e ) {
            if ( cedulaTB.Text == "CEDULA DE DOCTOR" ) {
                cedulaTB.Text = "";
                cedulaTB.ForeColor = Color.LightGray;
                }
            }

        private void curpTB_Leave ( object sender , EventArgs e ) {
            if ( cedulaTB.Text == "" ) {
                cedulaTB.Text = "CEDULA DE DOCTOR";
                cedulaTB.ForeColor = Color.Gainsboro;
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
                nssTB.ForeColor = Color.Gainsboro;
                }
            }

        private void minimizeButton_Click ( object sender , EventArgs e ) {
            this.WindowState = FormWindowState.Minimized;
            }

        private void closeButton_Click ( object sender , EventArgs e ) {
            this.Close();
            }

        private void RealizarCita_MouseDown ( object sender , MouseEventArgs e ) {
            ReleaseCapture();
            SendMessage(this.Handle , 0x112 , 0xf012 , 0);
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

        private void nssTB_KeyPress ( object sender , KeyPressEventArgs e ) {
            SoloNumeros(e);
            }

        private void nssTB_KeyPress_1 ( object sender , KeyPressEventArgs e ) {
            SoloNumeros(e);
            }

        private void cedulaTB_KeyPress ( object sender , KeyPressEventArgs e ) {
            SoloNumeros(e);
            }

        private void realizarCitaButton_Click_1 ( object sender , EventArgs e ) {
            CitaDao cita = new CitaDao();
            ConsultorioDao insert = new ConsultorioDao();
            /*Así inserte todos los registos de las tablas por un total de 700 días desde el 21 de mayo
             * DateTime fecha = diaDTP.Value.Date;
            for ( int i = 0 ; i < 700 ; i++ ) {                    
                for ( int j = 0 ; j < horaCB.Items.Count ; j++ ) {
                    horaCB.SelectedIndex = j;
                    TimeSpan hora = TimeSpan.Parse(horaCB.Text);
                    DateTime fechaCompleta = fecha.Add(hora);
                    insert.Insert(fechaCompleta, false , false , false , false , false , false , false);
                    }                    
                    fecha = fecha.AddDays(1);
                }*/            
            if ( consultorioCB.SelectedIndex == -1 ) {
                MessageBox.Show("Seleccione un consultorio");
                }
            else {
                if ( horaCB.SelectedIndex == -1 ) {
                    MessageBox.Show("Seleccione una hora");
                    }
                else {
                    if ( diaDTP.Value < DateTime.Now.AddDays(-1) ) {
                        MessageBox.Show("Seleccione una fecha valida");
                        }
                    else {
                        DateTime fecha = diaDTP.Value.Date;                         
                        TimeSpan hora = TimeSpan.Parse(horaCB.Text);
                        DateTime fechaCompleta = fecha.Add(hora);                        
                        switch ( cita.Insert(fechaCompleta , cedulaTB.Text , Convert.ToInt32(nssTB.Text) , consultorioCB.Text) ) {
                            case 0:
                                MessageBox.Show("Cita realizada correctamente\nNumero de cita: " + CacheData.cita );
                                break;
                            case 1:
                                MessageBox.Show("Cedula de doctor no existente");
                                break;
                            case 2:
                                MessageBox.Show("Nss no reconocido");
                                break;
                            case 3:
                                MessageBox.Show("Fecha no disponible");
                                break;
                            case 4:
                                MessageBox.Show("El medico tiene cita a ese horario");
                                break;
                            case 5:
                                MessageBox.Show("Ya cuentas con cita a ese horario");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
