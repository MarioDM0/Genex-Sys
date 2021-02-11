namespace Hotel.UI {
    partial class RealizarCita {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( ) {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarCita));
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cedulaTB = new System.Windows.Forms.TextBox();
            this.nssTB = new System.Windows.Forms.TextBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.realizarCitaButton = new System.Windows.Forms.Button();
            this.consultorioCB = new System.Windows.Forms.ComboBox();
            this.diaDTP = new System.Windows.Forms.DateTimePicker();
            this.horaCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(384, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "CREAR CITA";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(900, 502);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape4.BorderColor = System.Drawing.Color.Silver;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 187;
            this.lineShape4.X2 = 405;
            this.lineShape4.Y1 = 304;
            this.lineShape4.Y2 = 304;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape2.BorderColor = System.Drawing.Color.Silver;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 523;
            this.lineShape2.X2 = 741;
            this.lineShape2.Y1 = 212;
            this.lineShape2.Y2 = 212;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape1.BorderColor = System.Drawing.Color.Silver;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 187;
            this.lineShape1.X2 = 405;
            this.lineShape1.Y1 = 212;
            this.lineShape1.Y2 = 212;
            // 
            // cedulaTB
            // 
            this.cedulaTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cedulaTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cedulaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cedulaTB.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaTB.ForeColor = System.Drawing.Color.Gainsboro;
            this.cedulaTB.Location = new System.Drawing.Point(524, 187);
            this.cedulaTB.Name = "cedulaTB";
            this.cedulaTB.Size = new System.Drawing.Size(219, 25);
            this.cedulaTB.TabIndex = 8;
            this.cedulaTB.Text = "CEDULA DE DOCTOR";
            this.cedulaTB.Enter += new System.EventHandler(this.curpTB_Enter);
            this.cedulaTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulaTB_KeyPress);
            this.cedulaTB.Leave += new System.EventHandler(this.curpTB_Leave);
            // 
            // nssTB
            // 
            this.nssTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nssTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.nssTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nssTB.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nssTB.ForeColor = System.Drawing.Color.Gainsboro;
            this.nssTB.Location = new System.Drawing.Point(188, 279);
            this.nssTB.Name = "nssTB";
            this.nssTB.Size = new System.Drawing.Size(219, 25);
            this.nssTB.TabIndex = 9;
            this.nssTB.Text = "NSS";
            this.nssTB.Enter += new System.EventHandler(this.nssTB_Enter);
            this.nssTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nssTB_KeyPress_1);
            this.nssTB.Leave += new System.EventHandler(this.nssTB_Leave);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(828, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 32);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 12;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(860, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 32);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 11;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // realizarCitaButton
            // 
            this.realizarCitaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.realizarCitaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.realizarCitaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.realizarCitaButton.FlatAppearance.BorderSize = 0;
            this.realizarCitaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.realizarCitaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.realizarCitaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.realizarCitaButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realizarCitaButton.ForeColor = System.Drawing.Color.LightGray;
            this.realizarCitaButton.Location = new System.Drawing.Point(267, 429);
            this.realizarCitaButton.Name = "realizarCitaButton";
            this.realizarCitaButton.Size = new System.Drawing.Size(408, 40);
            this.realizarCitaButton.TabIndex = 13;
            this.realizarCitaButton.Text = "Realizar Cita";
            this.realizarCitaButton.UseVisualStyleBackColor = false;
            this.realizarCitaButton.Click += new System.EventHandler(this.realizarCitaButton_Click_1);
            // 
            // consultorioCB
            // 
            this.consultorioCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.consultorioCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.consultorioCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultorioCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultorioCB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.consultorioCB.FormattingEnabled = true;
            this.consultorioCB.Items.AddRange(new object[] {
            "uno",
            "dos",
            "tres",
            "cuatro",
            "cinco",
            "seis",
            "siete"});
            this.consultorioCB.Location = new System.Drawing.Point(187, 181);
            this.consultorioCB.Name = "consultorioCB";
            this.consultorioCB.Size = new System.Drawing.Size(220, 29);
            this.consultorioCB.TabIndex = 14;
            this.consultorioCB.Text = "Selecciona un consultorio";
            // 
            // diaDTP
            // 
            this.diaDTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diaDTP.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaDTP.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.diaDTP.Location = new System.Drawing.Point(522, 284);
            this.diaDTP.Name = "diaDTP";
            this.diaDTP.Size = new System.Drawing.Size(220, 20);
            this.diaDTP.TabIndex = 15;
            // 
            // horaCB
            // 
            this.horaCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.horaCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.horaCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horaCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaCB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.horaCB.FormattingEnabled = true;
            this.horaCB.Items.AddRange(new object[] {
            "08:00:00",
            "08:30:00",
            "09:00:00",
            "09:30:00",
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "13:00:00",
            "13:30:00",
            "14:00:00",
            "14:30:00",
            "15:00:00",
            "15:30:00",
            "16:00:00",
            "16:30:00",
            "17:00:00",
            "17:30:00",
            "18:00:00",
            "18:30:00",
            "19:00:00",
            "19:30:00",
            "20:00:00",
            "20:30:00",
            "21:00:00",
            "21:30:00",
            "22:00:00"});
            this.horaCB.Location = new System.Drawing.Point(522, 249);
            this.horaCB.Name = "horaCB";
            this.horaCB.Size = new System.Drawing.Size(220, 29);
            this.horaCB.TabIndex = 16;
            this.horaCB.Text = "Selecciona un horario";
            // 
            // RealizarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(900, 502);
            this.Controls.Add(this.horaCB);
            this.Controls.Add(this.diaDTP);
            this.Controls.Add(this.consultorioCB);
            this.Controls.Add(this.realizarCitaButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nssTB);
            this.Controls.Add(this.cedulaTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 502);
            this.Name = "RealizarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Cita";
            this.Load += new System.EventHandler(this.RealizarCita_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RealizarCita_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox cedulaTB;
        private System.Windows.Forms.TextBox nssTB;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button realizarCitaButton;
        private System.Windows.Forms.ComboBox consultorioCB;
        private System.Windows.Forms.DateTimePicker diaDTP;
        private System.Windows.Forms.ComboBox horaCB;
        }
    }