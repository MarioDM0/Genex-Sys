using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Npgsql;
using Hotel.UI;
using Hotel.DAO;

namespace Hotel {
    public partial class Seleccion : Form {
        public Seleccion ( ) {
            InitializeComponent();
            }

        [DllImport("user32.DLL" , EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture ( );
        [DllImport("user32.DLL" , EntryPoint = "SendMessage")]
        private extern static void SendMessage ( System.IntPtr hwnd , int wmsg , int wparam , int lparam );             

        private void minimizeButton_Click ( object sender , EventArgs e ) {
            this.WindowState = FormWindowState.Minimized;
            }

        private void closeButton_Click ( object sender , EventArgs e ) {
            this.Close();
            }

        private void Seleccion_MouseDown ( object sender , MouseEventArgs e ) {
            ReleaseCapture();
            SendMessage(this.Handle , 0x112 , 0xf012 , 0);
            }

        private void panel1_MouseDown ( object sender , MouseEventArgs e ) {
            ReleaseCapture();
            SendMessage(this.Handle , 0x112 , 0xf012 , 0);
            }

        private void adminButton_Click ( object sender , EventArgs e ) {
            Principal princ= new Principal();
            princ.Show();
            princ.FormClosed += LogoutPrincipal;
            this.Hide();
            }

        private void LogoutPrincipal ( object sender , FormClosedEventArgs e ) {            
            this.BringToFront();
            this.Show();
            }

        private void employerButton_Click ( object sender , EventArgs e ) {
            LoginEmpleado log= new LoginEmpleado();
            log.Show();
            log.FormClosed += LogoutPrincipal;
            this.Hide();
            }

        private void clientButton_Click ( object sender , EventArgs e ) {
            RealizarCita cita = new RealizarCita();
            cita.Show();
            cita.FormClosed += LogoutPrincipal;
            this.Hide();
            }
        }
    }
