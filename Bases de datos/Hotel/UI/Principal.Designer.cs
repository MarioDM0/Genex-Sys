namespace Hotel.UI {
    partial class Principal {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.verDatosButton = new System.Windows.Forms.Button();
            this.pacientePanel = new System.Windows.Forms.Panel();
            this.eliminarPacienteButton = new System.Windows.Forms.Button();
            this.modificarPacienteButton = new System.Windows.Forms.Button();
            this.añadirPacienteButton = new System.Windows.Forms.Button();
            this.pacienteButton = new System.Windows.Forms.Button();
            this.empleadosPanel = new System.Windows.Forms.Panel();
            this.eliminarEmpleadoButon = new System.Windows.Forms.Button();
            this.modificarEmpleadoButton = new System.Windows.Forms.Button();
            this.añadirEmpleadoButton = new System.Windows.Forms.Button();
            this.employersButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.maximizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.homeLabel = new System.Windows.Forms.Label();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.pacientePanel.SuspendLayout();
            this.empleadosPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.menuPanel.Controls.Add(this.verDatosButton);
            this.menuPanel.Controls.Add(this.pacientePanel);
            this.menuPanel.Controls.Add(this.pacienteButton);
            this.menuPanel.Controls.Add(this.empleadosPanel);
            this.menuPanel.Controls.Add(this.employersButton);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(220, 582);
            this.menuPanel.TabIndex = 1;
            // 
            // verDatosButton
            // 
            this.verDatosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verDatosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.verDatosButton.FlatAppearance.BorderSize = 0;
            this.verDatosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verDatosButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verDatosButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.verDatosButton.Image = ((System.Drawing.Image)(resources.GetObject("verDatosButton.Image")));
            this.verDatosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verDatosButton.Location = new System.Drawing.Point(0, 430);
            this.verDatosButton.Name = "verDatosButton";
            this.verDatosButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.verDatosButton.Size = new System.Drawing.Size(220, 55);
            this.verDatosButton.TabIndex = 5;
            this.verDatosButton.Text = "    Ver Datos";
            this.verDatosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verDatosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.verDatosButton.UseVisualStyleBackColor = true;
            this.verDatosButton.Click += new System.EventHandler(this.verDatosButton_Click);
            // 
            // pacientePanel
            // 
            this.pacientePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(100)))));
            this.pacientePanel.Controls.Add(this.eliminarPacienteButton);
            this.pacientePanel.Controls.Add(this.modificarPacienteButton);
            this.pacientePanel.Controls.Add(this.añadirPacienteButton);
            this.pacientePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pacientePanel.Location = new System.Drawing.Point(0, 310);
            this.pacientePanel.Name = "pacientePanel";
            this.pacientePanel.Size = new System.Drawing.Size(220, 120);
            this.pacientePanel.TabIndex = 4;
            this.pacientePanel.Visible = false;
            // 
            // eliminarPacienteButton
            // 
            this.eliminarPacienteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.eliminarPacienteButton.FlatAppearance.BorderSize = 0;
            this.eliminarPacienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarPacienteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.eliminarPacienteButton.Location = new System.Drawing.Point(0, 80);
            this.eliminarPacienteButton.Name = "eliminarPacienteButton";
            this.eliminarPacienteButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.eliminarPacienteButton.Size = new System.Drawing.Size(220, 40);
            this.eliminarPacienteButton.TabIndex = 2;
            this.eliminarPacienteButton.Text = "    Eliminar";
            this.eliminarPacienteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarPacienteButton.UseVisualStyleBackColor = true;
            this.eliminarPacienteButton.Click += new System.EventHandler(this.eliminarPacienteButton_Click);
            // 
            // modificarPacienteButton
            // 
            this.modificarPacienteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.modificarPacienteButton.FlatAppearance.BorderSize = 0;
            this.modificarPacienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarPacienteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.modificarPacienteButton.Location = new System.Drawing.Point(0, 40);
            this.modificarPacienteButton.Name = "modificarPacienteButton";
            this.modificarPacienteButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.modificarPacienteButton.Size = new System.Drawing.Size(220, 40);
            this.modificarPacienteButton.TabIndex = 1;
            this.modificarPacienteButton.Text = "    Modificar";
            this.modificarPacienteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarPacienteButton.UseVisualStyleBackColor = true;
            this.modificarPacienteButton.Click += new System.EventHandler(this.modificarPacienteButton_Click);
            // 
            // añadirPacienteButton
            // 
            this.añadirPacienteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.añadirPacienteButton.FlatAppearance.BorderSize = 0;
            this.añadirPacienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadirPacienteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.añadirPacienteButton.Location = new System.Drawing.Point(0, 0);
            this.añadirPacienteButton.Name = "añadirPacienteButton";
            this.añadirPacienteButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.añadirPacienteButton.Size = new System.Drawing.Size(220, 40);
            this.añadirPacienteButton.TabIndex = 0;
            this.añadirPacienteButton.Text = "    Añadir";
            this.añadirPacienteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.añadirPacienteButton.UseVisualStyleBackColor = true;
            this.añadirPacienteButton.Click += new System.EventHandler(this.añadirPacienteButton_Click);
            // 
            // pacienteButton
            // 
            this.pacienteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pacienteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pacienteButton.FlatAppearance.BorderSize = 0;
            this.pacienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacienteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacienteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.pacienteButton.Image = ((System.Drawing.Image)(resources.GetObject("pacienteButton.Image")));
            this.pacienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pacienteButton.Location = new System.Drawing.Point(0, 255);
            this.pacienteButton.Name = "pacienteButton";
            this.pacienteButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.pacienteButton.Size = new System.Drawing.Size(220, 55);
            this.pacienteButton.TabIndex = 3;
            this.pacienteButton.Text = "    Paciente";
            this.pacienteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pacienteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pacienteButton.UseVisualStyleBackColor = true;
            this.pacienteButton.Click += new System.EventHandler(this.pacienteButton_Click);
            // 
            // empleadosPanel
            // 
            this.empleadosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(100)))));
            this.empleadosPanel.Controls.Add(this.eliminarEmpleadoButon);
            this.empleadosPanel.Controls.Add(this.modificarEmpleadoButton);
            this.empleadosPanel.Controls.Add(this.añadirEmpleadoButton);
            this.empleadosPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.empleadosPanel.Location = new System.Drawing.Point(0, 135);
            this.empleadosPanel.Name = "empleadosPanel";
            this.empleadosPanel.Size = new System.Drawing.Size(220, 120);
            this.empleadosPanel.TabIndex = 2;
            this.empleadosPanel.Visible = false;
            // 
            // eliminarEmpleadoButon
            // 
            this.eliminarEmpleadoButon.Dock = System.Windows.Forms.DockStyle.Top;
            this.eliminarEmpleadoButon.FlatAppearance.BorderSize = 0;
            this.eliminarEmpleadoButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarEmpleadoButon.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.eliminarEmpleadoButon.Location = new System.Drawing.Point(0, 80);
            this.eliminarEmpleadoButon.Name = "eliminarEmpleadoButon";
            this.eliminarEmpleadoButon.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.eliminarEmpleadoButon.Size = new System.Drawing.Size(220, 40);
            this.eliminarEmpleadoButon.TabIndex = 2;
            this.eliminarEmpleadoButon.Text = "    Eliminar";
            this.eliminarEmpleadoButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarEmpleadoButon.UseVisualStyleBackColor = true;
            this.eliminarEmpleadoButon.Click += new System.EventHandler(this.eliminarEmpleadoButon_Click);
            // 
            // modificarEmpleadoButton
            // 
            this.modificarEmpleadoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.modificarEmpleadoButton.FlatAppearance.BorderSize = 0;
            this.modificarEmpleadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarEmpleadoButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.modificarEmpleadoButton.Location = new System.Drawing.Point(0, 40);
            this.modificarEmpleadoButton.Name = "modificarEmpleadoButton";
            this.modificarEmpleadoButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.modificarEmpleadoButton.Size = new System.Drawing.Size(220, 40);
            this.modificarEmpleadoButton.TabIndex = 1;
            this.modificarEmpleadoButton.Text = "    Modificar";
            this.modificarEmpleadoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarEmpleadoButton.UseVisualStyleBackColor = true;
            this.modificarEmpleadoButton.Click += new System.EventHandler(this.modificarEmpleadoButton_Click);
            // 
            // añadirEmpleadoButton
            // 
            this.añadirEmpleadoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.añadirEmpleadoButton.FlatAppearance.BorderSize = 0;
            this.añadirEmpleadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadirEmpleadoButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.añadirEmpleadoButton.Location = new System.Drawing.Point(0, 0);
            this.añadirEmpleadoButton.Name = "añadirEmpleadoButton";
            this.añadirEmpleadoButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.añadirEmpleadoButton.Size = new System.Drawing.Size(220, 40);
            this.añadirEmpleadoButton.TabIndex = 0;
            this.añadirEmpleadoButton.Text = "    Añadir";
            this.añadirEmpleadoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.añadirEmpleadoButton.UseVisualStyleBackColor = true;
            this.añadirEmpleadoButton.Click += new System.EventHandler(this.añadirEmpleadoButton_Click);
            // 
            // employersButton
            // 
            this.employersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.employersButton.FlatAppearance.BorderSize = 0;
            this.employersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employersButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employersButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.employersButton.Image = ((System.Drawing.Image)(resources.GetObject("employersButton.Image")));
            this.employersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employersButton.Location = new System.Drawing.Point(0, 80);
            this.employersButton.Name = "employersButton";
            this.employersButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.employersButton.Size = new System.Drawing.Size(220, 55);
            this.employersButton.TabIndex = 1;
            this.employersButton.Text = "    Empleados";
            this.employersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employersButton.UseVisualStyleBackColor = true;
            this.employersButton.Click += new System.EventHandler(this.employersButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Controls.Add(this.homeButton);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(220, 80);
            this.logoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(54, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(110, 75);
            this.homeButton.TabIndex = 0;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(217)))), ((int)(((byte)(206)))));
            this.homePanel.Controls.Add(this.maximizeButton);
            this.homePanel.Controls.Add(this.closeButton);
            this.homePanel.Controls.Add(this.minimizeButton);
            this.homePanel.Controls.Add(this.homeLabel);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePanel.Location = new System.Drawing.Point(220, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(900, 80);
            this.homePanel.TabIndex = 2;
            this.homePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.homePanel_MouseDown);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.Location = new System.Drawing.Point(833, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(35, 32);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeButton.TabIndex = 11;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(865, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 32);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 10;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(801, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 32);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 9;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.Color.White;
            this.homeLabel.Location = new System.Drawing.Point(422, 28);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(78, 30);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "Inicio";
            // 
            // desktopPanel
            // 
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(220, 80);
            this.desktopPanel.MinimumSize = new System.Drawing.Size(900, 502);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(900, 502);
            this.desktopPanel.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 582);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(1136, 621);
            this.Name = "Principal";
            this.Opacity = 0.9D;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuPanel.ResumeLayout(false);
            this.pacientePanel.ResumeLayout(false);
            this.empleadosPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button employersButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox maximizeButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button verDatosButton;
        private System.Windows.Forms.Panel pacientePanel;
        private System.Windows.Forms.Button eliminarPacienteButton;
        private System.Windows.Forms.Button modificarPacienteButton;
        private System.Windows.Forms.Button añadirPacienteButton;
        private System.Windows.Forms.Button pacienteButton;
        private System.Windows.Forms.Panel empleadosPanel;
        private System.Windows.Forms.Button eliminarEmpleadoButon;
        private System.Windows.Forms.Button modificarEmpleadoButton;
        private System.Windows.Forms.Button añadirEmpleadoButton;
        }
    }