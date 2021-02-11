namespace Hotel.UI {
    partial class RealizarConsulta {
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
            this.findButton = new System.Windows.Forms.Button();
            this.horaCB = new System.Windows.Forms.ComboBox();
            this.diaDTP = new System.Windows.Forms.DateTimePicker();
            this.apellidoPacienteTB = new System.Windows.Forms.TextBox();
            this.nombrePacienteTB = new System.Windows.Forms.TextBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pacienteLabel = new System.Windows.Forms.Label();
            this.medicoLabel = new System.Windows.Forms.Label();
            this.apellidoMedicoTB = new System.Windows.Forms.TextBox();
            this.nombreMedicoTB = new System.Windows.Forms.TextBox();
            this.recetaLabel = new System.Windows.Forms.Label();
            this.recetaRTB = new System.Windows.Forms.RichTextBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findButton
            // 
            this.findButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.findButton.ForeColor = System.Drawing.Color.DimGray;
            this.findButton.Location = new System.Drawing.Point(340, 47);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(134, 32);
            this.findButton.TabIndex = 12;
            this.findButton.Text = "Buscar";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // horaCB
            // 
            this.horaCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.horaCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.horaCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horaCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaCB.ForeColor = System.Drawing.Color.Gray;
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
            this.horaCB.Location = new System.Drawing.Point(42, 33);
            this.horaCB.Name = "horaCB";
            this.horaCB.Size = new System.Drawing.Size(220, 29);
            this.horaCB.TabIndex = 18;
            this.horaCB.Text = "Selecciona un horario";
            // 
            // diaDTP
            // 
            this.diaDTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diaDTP.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaDTP.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.diaDTP.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.diaDTP.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.diaDTP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaDTP.Location = new System.Drawing.Point(42, 68);
            this.diaDTP.Name = "diaDTP";
            this.diaDTP.Size = new System.Drawing.Size(220, 21);
            this.diaDTP.TabIndex = 17;
            // 
            // apellidoPacienteTB
            // 
            this.apellidoPacienteTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apellidoPacienteTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.apellidoPacienteTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apellidoPacienteTB.Enabled = false;
            this.apellidoPacienteTB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.apellidoPacienteTB.ForeColor = System.Drawing.Color.DimGray;
            this.apellidoPacienteTB.Location = new System.Drawing.Point(42, 181);
            this.apellidoPacienteTB.Name = "apellidoPacienteTB";
            this.apellidoPacienteTB.Size = new System.Drawing.Size(273, 20);
            this.apellidoPacienteTB.TabIndex = 20;
            this.apellidoPacienteTB.Text = "Apellido";
            this.apellidoPacienteTB.Visible = false;
            // 
            // nombrePacienteTB
            // 
            this.nombrePacienteTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombrePacienteTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nombrePacienteTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombrePacienteTB.Enabled = false;
            this.nombrePacienteTB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nombrePacienteTB.ForeColor = System.Drawing.Color.DimGray;
            this.nombrePacienteTB.Location = new System.Drawing.Point(41, 144);
            this.nombrePacienteTB.Name = "nombrePacienteTB";
            this.nombrePacienteTB.Size = new System.Drawing.Size(273, 20);
            this.nombrePacienteTB.TabIndex = 19;
            this.nombrePacienteTB.Text = "Nombre";
            this.nombrePacienteTB.Visible = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.Visible = false;
            this.lineShape2.X1 = 42;
            this.lineShape2.X2 = 314;
            this.lineShape2.Y1 = 202;
            this.lineShape2.Y2 = 202;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.Visible = false;
            this.lineShape1.X1 = 41;
            this.lineShape1.X2 = 313;
            this.lineShape1.Y1 = 165;
            this.lineShape1.Y2 = 165;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(884, 463);
            this.shapeContainer1.TabIndex = 21;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.Visible = false;
            this.lineShape4.X1 = 339;
            this.lineShape4.X2 = 611;
            this.lineShape4.Y1 = 202;
            this.lineShape4.Y2 = 202;
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.Visible = false;
            this.lineShape3.X1 = 338;
            this.lineShape3.X2 = 610;
            this.lineShape3.Y1 = 165;
            this.lineShape3.Y2 = 165;
            // 
            // pacienteLabel
            // 
            this.pacienteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pacienteLabel.AutoSize = true;
            this.pacienteLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacienteLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.pacienteLabel.Location = new System.Drawing.Point(38, 112);
            this.pacienteLabel.Name = "pacienteLabel";
            this.pacienteLabel.Size = new System.Drawing.Size(92, 22);
            this.pacienteLabel.TabIndex = 22;
            this.pacienteLabel.Text = "Paciente";
            this.pacienteLabel.Visible = false;
            // 
            // medicoLabel
            // 
            this.medicoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.medicoLabel.AutoSize = true;
            this.medicoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.medicoLabel.Location = new System.Drawing.Point(336, 112);
            this.medicoLabel.Name = "medicoLabel";
            this.medicoLabel.Size = new System.Drawing.Size(79, 22);
            this.medicoLabel.TabIndex = 23;
            this.medicoLabel.Text = "Medico";
            this.medicoLabel.Visible = false;
            // 
            // apellidoMedicoTB
            // 
            this.apellidoMedicoTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apellidoMedicoTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.apellidoMedicoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apellidoMedicoTB.Enabled = false;
            this.apellidoMedicoTB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.apellidoMedicoTB.ForeColor = System.Drawing.Color.DimGray;
            this.apellidoMedicoTB.Location = new System.Drawing.Point(339, 181);
            this.apellidoMedicoTB.Name = "apellidoMedicoTB";
            this.apellidoMedicoTB.Size = new System.Drawing.Size(273, 20);
            this.apellidoMedicoTB.TabIndex = 25;
            this.apellidoMedicoTB.Text = "Apellido";
            this.apellidoMedicoTB.Visible = false;
            // 
            // nombreMedicoTB
            // 
            this.nombreMedicoTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombreMedicoTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nombreMedicoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreMedicoTB.Enabled = false;
            this.nombreMedicoTB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nombreMedicoTB.ForeColor = System.Drawing.Color.DimGray;
            this.nombreMedicoTB.Location = new System.Drawing.Point(338, 144);
            this.nombreMedicoTB.Name = "nombreMedicoTB";
            this.nombreMedicoTB.Size = new System.Drawing.Size(273, 20);
            this.nombreMedicoTB.TabIndex = 24;
            this.nombreMedicoTB.Text = "Nombre";
            this.nombreMedicoTB.Visible = false;
            // 
            // recetaLabel
            // 
            this.recetaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recetaLabel.AutoSize = true;
            this.recetaLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recetaLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.recetaLabel.Location = new System.Drawing.Point(688, 71);
            this.recetaLabel.Name = "recetaLabel";
            this.recetaLabel.Size = new System.Drawing.Size(102, 22);
            this.recetaLabel.TabIndex = 26;
            this.recetaLabel.Text = "Receta # ";
            this.recetaLabel.Visible = false;
            // 
            // recetaRTB
            // 
            this.recetaRTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recetaRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.recetaRTB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recetaRTB.ForeColor = System.Drawing.Color.DimGray;
            this.recetaRTB.Location = new System.Drawing.Point(42, 221);
            this.recetaRTB.Name = "recetaRTB";
            this.recetaRTB.Size = new System.Drawing.Size(570, 209);
            this.recetaRTB.TabIndex = 27;
            this.recetaRTB.Text = "";
            this.recetaRTB.Visible = false;
            // 
            // guardarButton
            // 
            this.guardarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.guardarButton.ForeColor = System.Drawing.Color.DimGray;
            this.guardarButton.Location = new System.Drawing.Point(669, 330);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(181, 56);
            this.guardarButton.TabIndex = 28;
            this.guardarButton.Text = "GUARDAR";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Visible = false;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // RealizarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(884, 463);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.recetaRTB);
            this.Controls.Add(this.recetaLabel);
            this.Controls.Add(this.apellidoMedicoTB);
            this.Controls.Add(this.nombreMedicoTB);
            this.Controls.Add(this.medicoLabel);
            this.Controls.Add(this.pacienteLabel);
            this.Controls.Add(this.apellidoPacienteTB);
            this.Controls.Add(this.nombrePacienteTB);
            this.Controls.Add(this.horaCB);
            this.Controls.Add(this.diaDTP);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(900, 502);
            this.Name = "RealizarConsulta";
            this.Text = "RealizarConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ComboBox horaCB;
        private System.Windows.Forms.DateTimePicker diaDTP;
        private System.Windows.Forms.TextBox apellidoPacienteTB;
        private System.Windows.Forms.TextBox nombrePacienteTB;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label pacienteLabel;
        private System.Windows.Forms.Label medicoLabel;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TextBox apellidoMedicoTB;
        private System.Windows.Forms.TextBox nombreMedicoTB;
        private System.Windows.Forms.Label recetaLabel;
        private System.Windows.Forms.RichTextBox recetaRTB;
        private System.Windows.Forms.Button guardarButton;
        }
    }