namespace InicioSesion
{
    partial class InicioSesionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesionForm));
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_loginAyuda = new System.Windows.Forms.Button();
            this.Lbl_loginPass = new System.Windows.Forms.Label();
            this.Lbl_loginUser = new System.Windows.Forms.Label();
            this.Txt_loginPass = new System.Windows.Forms.TextBox();
            this.Txt_loginUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Aceptar.Image")));
            this.Btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aceptar.Location = new System.Drawing.Point(518, 187);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(92, 44);
            this.Btn_Aceptar.TabIndex = 55;
            this.Btn_Aceptar.Text = "LOGIN";
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_loginAyuda
            // 
            this.Btn_loginAyuda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_loginAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_loginAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_loginAyuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_loginAyuda.Image")));
            this.Btn_loginAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_loginAyuda.Location = new System.Drawing.Point(509, 12);
            this.Btn_loginAyuda.Name = "Btn_loginAyuda";
            this.Btn_loginAyuda.Size = new System.Drawing.Size(101, 43);
            this.Btn_loginAyuda.TabIndex = 54;
            this.Btn_loginAyuda.Text = "AYUDA";
            this.Btn_loginAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_loginAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_loginAyuda.UseVisualStyleBackColor = false;
            // 
            // Lbl_loginPass
            // 
            this.Lbl_loginPass.AutoSize = true;
            this.Lbl_loginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginPass.Location = new System.Drawing.Point(38, 138);
            this.Lbl_loginPass.Name = "Lbl_loginPass";
            this.Lbl_loginPass.Size = new System.Drawing.Size(87, 16);
            this.Lbl_loginPass.TabIndex = 53;
            this.Lbl_loginPass.Text = "Contraseña";
            // 
            // Lbl_loginUser
            // 
            this.Lbl_loginUser.AutoSize = true;
            this.Lbl_loginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginUser.Location = new System.Drawing.Point(38, 98);
            this.Lbl_loginUser.Name = "Lbl_loginUser";
            this.Lbl_loginUser.Size = new System.Drawing.Size(62, 16);
            this.Lbl_loginUser.TabIndex = 52;
            this.Lbl_loginUser.Text = "Usuario";
            // 
            // Txt_loginPass
            // 
            this.Txt_loginPass.Location = new System.Drawing.Point(196, 134);
            this.Txt_loginPass.MaxLength = 30;
            this.Txt_loginPass.Name = "Txt_loginPass";
            this.Txt_loginPass.Size = new System.Drawing.Size(320, 20);
            this.Txt_loginPass.TabIndex = 51;
            this.Txt_loginPass.UseSystemPasswordChar = true;
            // 
            // Txt_loginUser
            // 
            this.Txt_loginUser.Location = new System.Drawing.Point(196, 97);
            this.Txt_loginUser.MaxLength = 30;
            this.Txt_loginUser.Name = "Txt_loginUser";
            this.Txt_loginUser.Size = new System.Drawing.Size(320, 20);
            this.Txt_loginUser.TabIndex = 50;
            // 
            // InicioSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 269);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_loginAyuda);
            this.Controls.Add(this.Lbl_loginPass);
            this.Controls.Add(this.Lbl_loginUser);
            this.Controls.Add(this.Txt_loginPass);
            this.Controls.Add(this.Txt_loginUser);
            this.Name = "InicioSesionForm";
            this.Text = "Inicio de Sesion";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.InicioSesionForm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_loginAyuda;
        private System.Windows.Forms.Label Lbl_loginPass;
        private System.Windows.Forms.Label Lbl_loginUser;
        private System.Windows.Forms.TextBox Txt_loginPass;
        private System.Windows.Forms.TextBox Txt_loginUser;
    }
}