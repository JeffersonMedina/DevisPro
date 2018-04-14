namespace DebisPro_App.Vista
{
    partial class FLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLog));
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.icon_cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(197, 82);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(144, 20);
            this.txt_Usuario.TabIndex = 4;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(197, 135);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(144, 20);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(278, 173);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Ingresar";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // pb_login
            // 
            this.pb_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_login.Image = global::DebisPro_App.Properties.Resources.sesion;
            this.pb_login.Location = new System.Drawing.Point(0, 0);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(451, 251);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_login.TabIndex = 0;
            this.pb_login.TabStop = false;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Location = new System.Drawing.Point(197, 173);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 8;
            this.btn_registrar.Text = "Registrarse";
            this.btn_registrar.UseVisualStyleBackColor = false;
            // 
            // icon_cerrar
            // 
            this.icon_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_cerrar.Image = global::DebisPro_App.Properties.Resources.icon_cerrar;
            this.icon_cerrar.Location = new System.Drawing.Point(362, 1);
            this.icon_cerrar.Name = "icon_cerrar";
            this.icon_cerrar.Size = new System.Drawing.Size(25, 21);
            this.icon_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_cerrar.TabIndex = 9;
            this.icon_cerrar.TabStop = false;
            this.icon_cerrar.Click += new System.EventHandler(this.icon_cerrar_Click);
            // 
            // FLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 251);
            this.Controls.Add(this.icon_cerrar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.pb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devis-Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.PictureBox icon_cerrar;
    }
}