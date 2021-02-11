namespace Hotel.UI {
    partial class CitasPendientes {
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
            this.datosTablaDGV = new System.Windows.Forms.DataGridView();
            this.indicacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // datosTablaDGV
            // 
            this.datosTablaDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datosTablaDGV.BackgroundColor = System.Drawing.Color.LightGray;
            this.datosTablaDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datosTablaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosTablaDGV.Location = new System.Drawing.Point(0, 76);
            this.datosTablaDGV.Name = "datosTablaDGV";
            this.datosTablaDGV.Size = new System.Drawing.Size(884, 387);
            this.datosTablaDGV.TabIndex = 1;
            // 
            // indicacionLabel
            // 
            this.indicacionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indicacionLabel.AutoSize = true;
            this.indicacionLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicacionLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.indicacionLabel.Location = new System.Drawing.Point(253, 18);
            this.indicacionLabel.Name = "indicacionLabel";
            this.indicacionLabel.Size = new System.Drawing.Size(432, 42);
            this.indicacionLabel.TabIndex = 2;
            this.indicacionLabel.Text = "Citas pendientes del día";
            // 
            // CitasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(884, 463);
            this.Controls.Add(this.indicacionLabel);
            this.Controls.Add(this.datosTablaDGV);
            this.MinimumSize = new System.Drawing.Size(900, 502);
            this.Name = "CitasPendientes";
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.DataGridView datosTablaDGV;
        private System.Windows.Forms.Label indicacionLabel;
        }
    }