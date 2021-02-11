using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.UI {
    public partial class Contacto : Form {
        public Contacto ( ) {            
            InitializeComponent();
            Random random = new Random();
            int index = random.Next(ThemeColors.ColorList.Count);
            this.BackColor = ColorTranslator.FromHtml(ThemeColors.ColorList[index]);
            }

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

        private void Contact_Load ( object sender , EventArgs e ) {            
            LoadTheme();
            }
        }
    }
