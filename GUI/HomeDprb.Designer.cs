namespace GUI
{
    partial class HomeDprb
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDprb));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lnkForgotPassword = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnRegisterSubmit = new MaterialSkin.Controls.MaterialButton();
            this.btnLoginSubmit = new MaterialSkin.Controls.MaterialButton();
            this.txtPasswordField = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUsernameField = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblLoginTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageLogin);
            this.materialTabControl1.Controls.Add(this.tabPageSettings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(894, 533);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.Color.White;
            this.tabPageLogin.Controls.Add(this.materialCard2);
            this.tabPageLogin.Controls.Add(this.materialCard1);
            this.tabPageLogin.ImageKey = "icons8-login-50.png";
            this.tabPageLogin.Location = new System.Drawing.Point(4, 31);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(886, 498);
            this.tabPageLogin.TabIndex = 1;
            this.tabPageLogin.Text = "Login";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lnkForgotPassword);
            this.materialCard2.Controls.Add(this.materialDivider1);
            this.materialCard2.Controls.Add(this.btnRegisterSubmit);
            this.materialCard2.Controls.Add(this.btnLoginSubmit);
            this.materialCard2.Controls.Add(this.txtPasswordField);
            this.materialCard2.Controls.Add(this.txtUsernameField);
            this.materialCard2.Controls.Add(this.lblLoginTitle);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(442, 17);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(430, 469);
            this.materialCard2.TabIndex = 7;
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Depth = 0;
            this.lnkForgotPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lnkForgotPassword.Location = new System.Drawing.Point(17, 321);
            this.lnkForgotPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(184, 19);
            this.lnkForgotPassword.TabIndex = 10;
            this.lnkForgotPassword.Text = "¿Olvidaste tu contraseña?";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(17, 300);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(396, 10);
            this.materialDivider1.TabIndex = 8;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnRegisterSubmit
            // 
            this.btnRegisterSubmit.AutoSize = false;
            this.btnRegisterSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegisterSubmit.Depth = 0;
            this.btnRegisterSubmit.HighEmphasis = true;
            this.btnRegisterSubmit.Icon = null;
            this.btnRegisterSubmit.Location = new System.Drawing.Point(253, 240);
            this.btnRegisterSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegisterSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegisterSubmit.Name = "btnRegisterSubmit";
            this.btnRegisterSubmit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegisterSubmit.Size = new System.Drawing.Size(159, 28);
            this.btnRegisterSubmit.TabIndex = 4;
            this.btnRegisterSubmit.Text = "REGISTRARSE";
            this.btnRegisterSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnRegisterSubmit.UseAccentColor = true;
            this.btnRegisterSubmit.UseVisualStyleBackColor = true;
            // 
            // btnLoginSubmit
            // 
            this.btnLoginSubmit.AutoSize = false;
            this.btnLoginSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoginSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoginSubmit.Depth = 0;
            this.btnLoginSubmit.HighEmphasis = true;
            this.btnLoginSubmit.Icon = null;
            this.btnLoginSubmit.Location = new System.Drawing.Point(17, 240);
            this.btnLoginSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoginSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoginSubmit.Name = "btnLoginSubmit";
            this.btnLoginSubmit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoginSubmit.Size = new System.Drawing.Size(172, 28);
            this.btnLoginSubmit.TabIndex = 3;
            this.btnLoginSubmit.Text = "INICIAR SESIÓN";
            this.btnLoginSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoginSubmit.UseAccentColor = true;
            this.btnLoginSubmit.UseVisualStyleBackColor = true;
            // 
            // txtPasswordField
            // 
            this.txtPasswordField.AnimateReadOnly = false;
            this.txtPasswordField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPasswordField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPasswordField.Depth = 0;
            this.txtPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasswordField.HideSelection = true;
            this.txtPasswordField.Hint = "Contraseña";
            this.txtPasswordField.LeadingIcon = null;
            this.txtPasswordField.Location = new System.Drawing.Point(17, 167);
            this.txtPasswordField.MaxLength = 32767;
            this.txtPasswordField.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPasswordField.Name = "txtPasswordField";
            this.txtPasswordField.PasswordChar = '●';
            this.txtPasswordField.PrefixSuffixText = null;
            this.txtPasswordField.ReadOnly = false;
            this.txtPasswordField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPasswordField.SelectedText = "";
            this.txtPasswordField.SelectionLength = 0;
            this.txtPasswordField.SelectionStart = 0;
            this.txtPasswordField.ShortcutsEnabled = true;
            this.txtPasswordField.Size = new System.Drawing.Size(396, 48);
            this.txtPasswordField.TabIndex = 2;
            this.txtPasswordField.TabStop = false;
            this.txtPasswordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswordField.TrailingIcon = null;
            this.txtPasswordField.UseSystemPasswordChar = true;
            // 
            // txtUsernameField
            // 
            this.txtUsernameField.AnimateReadOnly = false;
            this.txtUsernameField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsernameField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsernameField.Depth = 0;
            this.txtUsernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsernameField.HideSelection = true;
            this.txtUsernameField.Hint = "Nombre de usuario";
            this.txtUsernameField.LeadingIcon = null;
            this.txtUsernameField.Location = new System.Drawing.Point(17, 95);
            this.txtUsernameField.MaxLength = 32767;
            this.txtUsernameField.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsernameField.Name = "txtUsernameField";
            this.txtUsernameField.PasswordChar = '\0';
            this.txtUsernameField.PrefixSuffixText = null;
            this.txtUsernameField.ReadOnly = false;
            this.txtUsernameField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsernameField.SelectedText = "";
            this.txtUsernameField.SelectionLength = 0;
            this.txtUsernameField.SelectionStart = 0;
            this.txtUsernameField.ShortcutsEnabled = true;
            this.txtUsernameField.Size = new System.Drawing.Size(396, 48);
            this.txtUsernameField.TabIndex = 1;
            this.txtUsernameField.TabStop = false;
            this.txtUsernameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsernameField.TrailingIcon = null;
            this.txtUsernameField.UseSystemPasswordChar = false;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Depth = 0;
            this.lblLoginTitle.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoginTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblLoginTitle.Location = new System.Drawing.Point(17, 14);
            this.lblLoginTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(204, 41);
            this.lblLoginTitle.TabIndex = 7;
            this.lblLoginTitle.Text = "Iniciar Sesión";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 20);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(406, 464);
            this.materialCard1.TabIndex = 6;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.ImageKey = "icons8-settings-32.png";
            this.tabPageSettings.Location = new System.Drawing.Point(4, 31);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(886, 498);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Settings";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-faq-52.png");
            this.imageList1.Images.SetKeyName(1, "icons8-home-52.png");
            this.imageList1.Images.SetKeyName(2, "icons8-settings-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-login-50.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogoHdAPp_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomeDprb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "HomeDprb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heroes del Aprendizaje";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblLoginTitle;
        private MaterialSkin.Controls.MaterialTextBox2 txtUsernameField;
        private MaterialSkin.Controls.MaterialTextBox2 txtPasswordField;
        private MaterialSkin.Controls.MaterialButton btnRegisterSubmit;
        private MaterialSkin.Controls.MaterialButton btnLoginSubmit;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lnkForgotPassword;
    }
}

