using Hotel.DAO;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hotel.UI {
    public partial class AreaEmpleados : Form {
        //Todo sobre los botones presionados y los forms activos
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public AreaEmpleados ( ) {
            InitializeComponent();
            random = new Random();
            //Eliminar todo lo relacionado al form
            this.Text = string.Empty;
            this.ControlBox = false;
            //Para no exceder la pantalla completa
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            }

        //Metodos para movimiento de form libre
        [DllImport("user32.DLL" , EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture ( );
        [DllImport("user32.DLL" , EntryPoint = "SendMessage")]
        private extern static void SendMessage ( System.IntPtr hwnd , int wmsg , int wparam , int lparam );

        private void Principal_Load ( object sender , EventArgs e ) {
            //Al iniciar, mostrar el form de bienvenida
            OpenChildForm(new LaSaludEsLoPrimero() , homeButton);
            //Cargar los datos de login y memoria cache
            LoadUserData();
            }

        private void LoadUserData ( ) {
            //Establecer cedula y nombre del medico
            nombreLabel.Text = "Nombre:\n" + CacheData.name;
            cedulaLabel.Text = "Cedula:\n" + CacheData.cedula;
            }        

        private Color SelectThemeColor ( ) {
            //Color de boton aleatorio
            int index = random.Next(ThemeColors.ColorList.Count);
            while ( tempIndex == index ) {
                index = random.Next(ThemeColors.ColorList.Count);
                }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];
            return ColorTranslator.FromHtml(color);
            }

        private void ActivateButton ( object btnSender ) {
            //Revisar si se ha presionado un boton
            if ( btnSender != null ) {
                //Establecer el boton presionado
                if ( currentButton != (Button)btnSender ) {
                    //Tomar el color y cambiar fuentes para resaltar dicho boton
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
                //Desactivar boton a su valor original (solo visualmente)
                if ( previousBtn.GetType() == typeof(Button) ) {
                    previousBtn.BackColor = Color.FromArgb(41 , 128 , 185);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic" , 11.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte)( 0 ) ));
                    }
                }
            }

        private void OpenChildForm ( Form ChildForm , object btnSender ) {
            //Abrir los form hijo para trabajar dentro del principal
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

        private void makeDateButton_Click ( object sender , EventArgs e ) {            
            OpenChildForm(new RealizarConsulta() , sender);
            }                

        private void homePanel_MouseDown ( object sender , MouseEventArgs e ) {
            //Mover unicamente desde el panel
            ReleaseCapture();
            SendMessage(this.Handle , 0x112 , 0xf012 , 0);
            }

        private void closeButton_Click ( object sender , EventArgs e ) {
            if ( MessageBox.Show("¿Estás seguro de salir?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes )
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
            OpenChildForm(new LaSaludEsLoPrimero() , homeButton);
            }

        private void exitButton_Click ( object sender , EventArgs e ) {
            if ( MessageBox.Show("¿Estás seguro de salir?" , "Warning" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes )
                this.Close();
            }

        private void contactButton_Click_1 ( object sender , EventArgs e ) {
            OpenChildForm(new Contacto() , sender);
            }

        private void waitingDateButton_Click ( object sender , EventArgs e ) {
            OpenChildForm(new CitasPendientes() , sender);            
            }

        private void historyButton_Click ( object sender , EventArgs e ) {
            OpenChildForm(new HistorialMedico(),sender);
            }
        }

    }
