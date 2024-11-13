namespace InterfazdeUsuario.Formularios
{
    partial class FrmCambiarContra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNewContra = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNuevaContra = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 291);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazdeUsuario.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(-20, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.tbNuevaContra);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbNewContra);
            this.panel2.Location = new System.Drawing.Point(215, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 298);
            this.panel2.TabIndex = 2;
            // 
            // tbNewContra
            // 
            // 
            // 
            // 
            this.tbNewContra.CustomButton.Image = null;
            this.tbNewContra.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.tbNewContra.CustomButton.Name = "";
            this.tbNewContra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNewContra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNewContra.CustomButton.TabIndex = 1;
            this.tbNewContra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNewContra.CustomButton.UseSelectable = true;
            this.tbNewContra.CustomButton.Visible = false;
            this.tbNewContra.Lines = new string[0];
            this.tbNewContra.Location = new System.Drawing.Point(247, 72);
            this.tbNewContra.MaxLength = 32767;
            this.tbNewContra.Name = "tbNewContra";
            this.tbNewContra.PasswordChar = '\0';
            this.tbNewContra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNewContra.SelectedText = "";
            this.tbNewContra.SelectionLength = 0;
            this.tbNewContra.SelectionStart = 0;
            this.tbNewContra.ShortcutsEnabled = true;
            this.tbNewContra.Size = new System.Drawing.Size(229, 23);
            this.tbNewContra.TabIndex = 0;
            this.tbNewContra.UseSelectable = true;
            this.tbNewContra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNewContra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // tbNuevaContra
            // 
            // 
            // 
            // 
            this.tbNuevaContra.CustomButton.Image = null;
            this.tbNuevaContra.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.tbNuevaContra.CustomButton.Name = "";
            this.tbNuevaContra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNuevaContra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNuevaContra.CustomButton.TabIndex = 1;
            this.tbNuevaContra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNuevaContra.CustomButton.UseSelectable = true;
            this.tbNuevaContra.CustomButton.Visible = false;
            this.tbNuevaContra.Lines = new string[0];
            this.tbNuevaContra.Location = new System.Drawing.Point(247, 120);
            this.tbNuevaContra.MaxLength = 32767;
            this.tbNuevaContra.Name = "tbNuevaContra";
            this.tbNuevaContra.PasswordChar = '\0';
            this.tbNuevaContra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNuevaContra.SelectedText = "";
            this.tbNuevaContra.SelectionLength = 0;
            this.tbNuevaContra.SelectionStart = 0;
            this.tbNuevaContra.ShortcutsEnabled = true;
            this.tbNuevaContra.Size = new System.Drawing.Size(229, 23);
            this.tbNuevaContra.TabIndex = 3;
            this.tbNuevaContra.UseSelectable = true;
            this.tbNuevaContra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNuevaContra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancelar.IconColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 38;
            this.btnCancelar.Location = new System.Drawing.Point(210, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCancelar.Size = new System.Drawing.Size(183, 70);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 38;
            this.btnLogin.Location = new System.Drawing.Point(19, 191);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogin.Size = new System.Drawing.Size(168, 63);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // FrmCambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 318);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiarContra";
            this.Text = "FrmCambiarContra";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox tbNewContra;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox tbNuevaContra;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnLogin;
    }
}