namespace Bases_de_datos {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent ( ) {
            this.inicioLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.inicioGB = new System.Windows.Forms.GroupBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.iniciarButton = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.userTB = new System.Windows.Forms.TextBox();
            this.inicioGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // inicioLabel
            // 
            this.inicioLabel.AutoSize = true;
            this.inicioLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioLabel.Location = new System.Drawing.Point(319, 68);
            this.inicioLabel.Name = "inicioLabel";
            this.inicioLabel.Size = new System.Drawing.Size(148, 23);
            this.inicioLabel.TabIndex = 0;
            this.inicioLabel.Text = "Inicio de Sesión";
            this.inicioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(6, 16);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(61, 17);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Usuario:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(6, 67);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(85, 17);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Contraseña:";
            // 
            // inicioGB
            // 
            this.inicioGB.Controls.Add(this.cancelarButton);
            this.inicioGB.Controls.Add(this.iniciarButton);
            this.inicioGB.Controls.Add(this.passwordTB);
            this.inicioGB.Controls.Add(this.userTB);
            this.inicioGB.Controls.Add(this.userLabel);
            this.inicioGB.Controls.Add(this.passwordLabel);
            this.inicioGB.Location = new System.Drawing.Point(207, 94);
            this.inicioGB.Name = "inicioGB";
            this.inicioGB.Size = new System.Drawing.Size(345, 177);
            this.inicioGB.TabIndex = 3;
            this.inicioGB.TabStop = false;            
            // 
            // cancelarButton
            // 
            this.cancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarButton.Location = new System.Drawing.Point(196, 120);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 6;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // iniciarButton
            // 
            this.iniciarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciarButton.Location = new System.Drawing.Point(92, 121);
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Size = new System.Drawing.Size(75, 23);
            this.iniciarButton.TabIndex = 5;
            this.iniciarButton.Text = "Iniciar";
            this.iniciarButton.UseVisualStyleBackColor = true;
            this.iniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(94, 67);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(232, 20);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(94, 16);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(232, 20);
            this.userTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.inicioGB);
            this.Controls.Add(this.inicioLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            this.inicioGB.ResumeLayout(false);
            this.inicioGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label inicioLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.GroupBox inicioGB;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button iniciarButton;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox userTB;
        }
    }

