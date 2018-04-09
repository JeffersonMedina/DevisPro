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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLlogUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLReg = new System.Windows.Forms.LinkLabel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DebisPro_App.Properties.Resources.LogoDevis_pro;
            this.pictureBox1.Location = new System.Drawing.Point(369, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 388);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LBLlogUsuario
            // 
            this.LBLlogUsuario.AutoSize = true;
            this.LBLlogUsuario.ForeColor = System.Drawing.Color.Red;
            this.LBLlogUsuario.Location = new System.Drawing.Point(137, 55);
            this.LBLlogUsuario.Name = "LBLlogUsuario";
            this.LBLlogUsuario.Size = new System.Drawing.Size(85, 13);
            this.LBLlogUsuario.TabIndex = 1;
            this.LBLlogUsuario.Text = "Usuario o correo";
            this.LBLlogUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(147, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // lblLReg
            // 
            this.lblLReg.AutoSize = true;
            this.lblLReg.Location = new System.Drawing.Point(153, 339);
            this.lblLReg.Name = "lblLReg";
            this.lblLReg.Size = new System.Drawing.Size(60, 13);
            this.lblLReg.TabIndex = 3;
            this.lblLReg.TabStop = true;
            this.lblLReg.Text = "Registrarse";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(103, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(156, 20);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(103, 136);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(156, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(93, 201);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Ingresar";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(180, 200);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(75, 23);
            this.btnCan.TabIndex = 7;
            this.btnCan.Text = "Cerrar";
            this.btnCan.UseVisualStyleBackColor = true;
            // 
            // FLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 407);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblLReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBLlogUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devis-Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBLlogUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblLReg;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCan;
    }
}