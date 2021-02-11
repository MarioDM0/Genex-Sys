namespace Hotel.UI {
    partial class Administrador {
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
            this.TablasMenuStrip = new System.Windows.Forms.MenuStrip();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosTablaDGV = new System.Windows.Forms.DataGridView();
            this.indicacionLabel = new System.Windows.Forms.Label();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.TablasMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TablasMenuStrip
            // 
            this.TablasMenuStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.TablasMenuStrip.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablasMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicosToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.consultoriosToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.recetasToolStripMenuItem});
            this.TablasMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TablasMenuStrip.Name = "TablasMenuStrip";
            this.TablasMenuStrip.Size = new System.Drawing.Size(884, 31);
            this.TablasMenuStrip.TabIndex = 0;
            this.TablasMenuStrip.Text = "menuStrip1";
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.medicosToolStripMenuItem.Text = "Medicos";
            this.medicosToolStripMenuItem.Click += new System.EventHandler(this.medicosToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // consultoriosToolStripMenuItem
            // 
            this.consultoriosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.consultoriosToolStripMenuItem.Name = "consultoriosToolStripMenuItem";
            this.consultoriosToolStripMenuItem.Size = new System.Drawing.Size(138, 27);
            this.consultoriosToolStripMenuItem.Text = "Consultorios";
            this.consultoriosToolStripMenuItem.Click += new System.EventHandler(this.consultoriosToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.citasToolStripMenuItem.Text = "Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.recetasToolStripMenuItem.Text = "Recetas";
            this.recetasToolStripMenuItem.Click += new System.EventHandler(this.recetasToolStripMenuItem_Click);
            // 
            // datosTablaDGV
            // 
            this.datosTablaDGV.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.datosTablaDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datosTablaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosTablaDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datosTablaDGV.Location = new System.Drawing.Point(0, 76);
            this.datosTablaDGV.Name = "datosTablaDGV";
            this.datosTablaDGV.Size = new System.Drawing.Size(884, 387);
            this.datosTablaDGV.TabIndex = 1;
            // 
            // indicacionLabel
            // 
            this.indicacionLabel.AutoSize = true;
            this.indicacionLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicacionLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.indicacionLabel.Location = new System.Drawing.Point(2, 31);
            this.indicacionLabel.Name = "indicacionLabel";
            this.indicacionLabel.Size = new System.Drawing.Size(384, 42);
            this.indicacionLabel.TabIndex = 2;
            this.indicacionLabel.Text = "Selecciona una tabla";
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(884, 463);
            this.Controls.Add(this.indicacionLabel);
            this.Controls.Add(this.datosTablaDGV);
            this.Controls.Add(this.TablasMenuStrip);
            this.MainMenuStrip = this.TablasMenuStrip;
            this.MinimumSize = new System.Drawing.Size(900, 502);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.TablasMenuStrip.ResumeLayout(false);
            this.TablasMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.MenuStrip TablasMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.DataGridView datosTablaDGV;
        private System.Windows.Forms.Label indicacionLabel;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
        }
    }