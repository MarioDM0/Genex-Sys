using Hotel.DAO;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Hotel.UI.UI_EMPLEADOS;

namespace Hotel.UI {
    public partial class Principal : Form {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Principal ( ) {
            InitializeComponent();            
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            }

        private void hideSubMenu ( ) {
            if ( empleadosPanel.Visible == true )
                empleadosPanel.Visible = false;
            if ( pacientePanel.Visible == true )
                pacientePanel.Visible = false;
            }

        private void showSubMenu ( Panel subMenu ) {
            if ( subMenu.Visible == false ) {
                hideSubMenu();
                subMenu.Visible = true;
                }
            else
                subMenu.Visible = false;
            }        

        [DllImport("user32.DLL" , EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture ( );
        [DllImport("user32.DLL" , EntryPoint = "SendMessage")]
        private extern static void SendMessage ( System.IntPtr hwnd , int wmsg , int wparam , int lparam );

        private void Principal_Load ( object sender , EventArgs e ) {
            OpenChildForm(new LaSaludEsLoPrimero() , homeButton);
            }

        private Color SelectThemeColor ( ) {
            int index = random.Next(ThemeColors.ColorList.Count);
            while ( tempIndex == index ) {
                index = random.Next(ThemeColors.ColorList.Count);
                }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];
            return ColorTranslator.FromHtml(color);
            }

        private void ActivateButton ( object btnSender ) {
            if ( btnSender != null ) {
                if ( currentButton != (Button)btnSender ) {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic" , 13.5F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte)( 0 ) ));
                    homePanel.BackColor = color;
                    logoPanel.BackColor = ThemeColors.ChangeColorBrightness(color , -0.3);
                    ThemeColors.PrimaryColor = color;
                    ThemeColors.SecondaryColor = ThemeColors.ChangeColorBrightness(color , -0.3);
                    }
                }
            }

        private void DisableButton ( ) {
            foreach ( Control previousBtn in menuPanel.Controls ) {
                if ( previousBtn.GetType() == typeof(Button) ) {
                    previousBtn.BackColor = Color.FromArgb(41 , 128 , 185);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic" , 11.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte)( 0 ) ));
                    }
                }
            }

        private void OpenChildForm ( Form ChildForm , object btnSender ) {
            if ( activeForm != null ) {
                activeForm.Close();
                }
            ActivateButton(btnSender);
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(ChildForm);
            this.desktopPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            homeLabel.Text = ChildForm.Text;
            }

        private void employersButton_Click ( object sender , EventArgs e ) {
            showSubMenu(empleadosPanel);
            }

        private void homePanel_MouseDown ( object sender , MouseEventArgs e ) {
            ReleaseCapture();
            SendMessage(this.Handle , 0x112 , 0xf012 , 0);
            }

        private void closeButton_Click ( object sender , EventArgs e ) {
            if ( MessageBox.Show("¿Estás seguro de salir?" , "Warning" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes )
                this.Close();
            }

        private void maximizeButton_Click ( object sender , EventArgs e ) {
            if ( WindowState == FormWindowState.Normal )
                this.WindowState = FormWindowState.Maximized;
            else {
                this.WindowState = FormWindowState.Normal;
                }
            }

        private void minimizeButton_Click ( object sender , EventArgs e ) {
            this.WindowState = FormWindowState.Minimized;
            }

        private void homeButton_Click ( object sender , EventArgs e ) {
            OpenChildForm(new UI.LaSaludEsLoPrimero() , homeButton);
            }

        private void pacienteButton_Click ( object sender , EventArgs e ) {
            showSubMenu(pacientePanel);
            }

        private void verDatosButton_Click ( object sender , EventArgs e ) {
            OpenChildForm(new Administrador(), sender);
            }

        private void añadirEmpleadoButton_Click ( object sender , EventArgs e ) {
            OpenChildForm(new AgregarEmpleado() , sender);            
            }

        private void eliminarEmpleadoButon_Click ( object sender , EventArgs e ) {
            OpenChildForm(new EliminarEmpleado() , sender);            
            }

        private void modificarEmpleadoButton_Click ( object sender , EventArgs e ) {
            OpenChildForm(new ModificarEmpleado() , sender);            
            }

        private void añadirPacienteButton_Click ( object sender , EventArgs e ) {
            OpenChildForm(new AgregarPaciente() , sender);
            }

        private void modificarPacienteButton_Click ( object sender , EventArgs e ) {
            OpenChildForm(new ModificarPaciente() , sender);
            }

        private void eliminarPacienteButton_Click ( object sender , EventArgs e ) {
            OpenChildForm(new EliminarPaciente() , sender);
            }
        }
    }
