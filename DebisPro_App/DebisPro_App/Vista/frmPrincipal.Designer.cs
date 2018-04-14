namespace DebisPro_App.Vista
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.Barra_titulo = new System.Windows.Forms.Panel();
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.btn_materiales = new System.Windows.Forms.Button();
            this.icon_minimizar = new System.Windows.Forms.PictureBox();
            this.icon_restaurar = new System.Windows.Forms.PictureBox();
            this.icon_maximizar = new System.Windows.Forms.PictureBox();
            this.icon_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.Barra_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btn_login);
            this.MenuVertical.Controls.Add(this.btn_materiales);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // Barra_titulo
            // 
            this.Barra_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Barra_titulo.Controls.Add(this.icon_minimizar);
            this.Barra_titulo.Controls.Add(this.icon_restaurar);
            this.Barra_titulo.Controls.Add(this.icon_maximizar);
            this.Barra_titulo.Controls.Add(this.icon_cerrar);
            this.Barra_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_titulo.Location = new System.Drawing.Point(250, 0);
            this.Barra_titulo.Name = "Barra_titulo";
            this.Barra_titulo.Size = new System.Drawing.Size(1050, 50);
            this.Barra_titulo.TabIndex = 1;
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor.Location = new System.Drawing.Point(250, 50);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(1050, 600);
            this.Panel_Contenedor.TabIndex = 2;
            // 
            // btn_materiales
            // 
            this.btn_materiales.FlatAppearance.BorderSize = 0;
            this.btn_materiales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_materiales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_materiales.ForeColor = System.Drawing.Color.White;
            this.btn_materiales.Location = new System.Drawing.Point(0, 132);
            this.btn_materiales.Name = "btn_materiales";
            this.btn_materiales.Size = new System.Drawing.Size(250, 40);
            this.btn_materiales.TabIndex = 1;
            this.btn_materiales.Text = "Materiales";
            this.btn_materiales.UseVisualStyleBackColor = true;
            // 
            // icon_minimizar
            // 
            this.icon_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_minimizar.Image = global::DebisPro_App.Properties.Resources.icono_mini;
            this.icon_minimizar.Location = new System.Drawing.Point(951, 12);
            this.icon_minimizar.Name = "icon_minimizar";
            this.icon_minimizar.Size = new System.Drawing.Size(25, 25);
            this.icon_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_minimizar.TabIndex = 3;
            this.icon_minimizar.TabStop = false;
            this.icon_minimizar.Click += new System.EventHandler(this.icon_minimizar_Click);
            // 
            // icon_restaurar
            // 
            this.icon_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_restaurar.Image = global::DebisPro_App.Properties.Resources.icon_minimizar;
            this.icon_restaurar.Location = new System.Drawing.Point(982, 12);
            this.icon_restaurar.Name = "icon_restaurar";
            this.icon_restaurar.Size = new System.Drawing.Size(25, 25);
            this.icon_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_restaurar.TabIndex = 2;
            this.icon_restaurar.TabStop = false;
            this.icon_restaurar.Visible = false;
            this.icon_restaurar.Click += new System.EventHandler(this.icon_restaurar_Click);
            // 
            // icon_maximizar
            // 
            this.icon_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_maximizar.Image = global::DebisPro_App.Properties.Resources.icono_maximizar;
            this.icon_maximizar.Location = new System.Drawing.Point(982, 12);
            this.icon_maximizar.Name = "icon_maximizar";
            this.icon_maximizar.Size = new System.Drawing.Size(25, 25);
            this.icon_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_maximizar.TabIndex = 1;
            this.icon_maximizar.TabStop = false;
            this.icon_maximizar.Click += new System.EventHandler(this.icon_maximizar_Click);
            // 
            // icon_cerrar
            // 
            this.icon_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_cerrar.Image = global::DebisPro_App.Properties.Resources.icon_cerrar;
            this.icon_cerrar.Location = new System.Drawing.Point(1013, 12);
            this.icon_cerrar.Name = "icon_cerrar";
            this.icon_cerrar.Size = new System.Drawing.Size(25, 25);
            this.icon_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_cerrar.TabIndex = 0;
            this.icon_cerrar.TabStop = false;
            this.icon_cerrar.Click += new System.EventHandler(this.icon_cerrar_Click);
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = global::DebisPro_App.Properties.Resources.login1;
            this.btn_login.Location = new System.Drawing.Point(3, 598);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(250, 40);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DebisPro_App.Properties.Resources.LogoDevis_pro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Panel_Contenedor);
            this.Controls.Add(this.Barra_titulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.MenuVertical.ResumeLayout(false);
            this.Barra_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel Barra_titulo;
        private System.Windows.Forms.PictureBox icon_cerrar;
        private System.Windows.Forms.Panel Panel_Contenedor;
        private System.Windows.Forms.PictureBox icon_maximizar;
        private System.Windows.Forms.PictureBox icon_restaurar;
        private System.Windows.Forms.PictureBox icon_minimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_materiales;
        private System.Windows.Forms.Button btn_login;
    }
}