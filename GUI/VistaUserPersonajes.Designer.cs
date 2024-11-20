namespace GUI
{
    partial class VistaUserPersonajes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaUserPersonajes));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialBtnSalir = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnPrgRp = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnConfig = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTxtRol = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtUser = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialBtnPerso3 = new MaterialSkin.Controls.MaterialButton();
            this.label6 = new System.Windows.Forms.Label();
            this.materialBtnPerso2 = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.materialBtnPerso1 = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.materialTxtRol);
            this.tabPage1.Controls.Add(this.materialTxtUser);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageKey = "icons8-contacts-32.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialBtnSalir);
            this.materialCard1.Controls.Add(this.materialBtnPrgRp);
            this.materialCard1.Controls.Add(this.materialBtnConfig);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(414, 34);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(328, 217);
            this.materialCard1.TabIndex = 3;
            // 
            // materialBtnSalir
            // 
            this.materialBtnSalir.AutoSize = false;
            this.materialBtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnSalir.Depth = 0;
            this.materialBtnSalir.HighEmphasis = true;
            this.materialBtnSalir.Icon = null;
            this.materialBtnSalir.Location = new System.Drawing.Point(63, 138);
            this.materialBtnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnSalir.Name = "materialBtnSalir";
            this.materialBtnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnSalir.Size = new System.Drawing.Size(212, 36);
            this.materialBtnSalir.TabIndex = 0;
            this.materialBtnSalir.Text = "SALIR";
            this.materialBtnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnSalir.UseAccentColor = false;
            this.materialBtnSalir.UseVisualStyleBackColor = true;
            this.materialBtnSalir.Click += new System.EventHandler(this.materialBtnSalir_Click);
            // 
            // materialBtnPrgRp
            // 
            this.materialBtnPrgRp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnPrgRp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnPrgRp.Depth = 0;
            this.materialBtnPrgRp.HighEmphasis = true;
            this.materialBtnPrgRp.Icon = null;
            this.materialBtnPrgRp.Location = new System.Drawing.Point(63, 35);
            this.materialBtnPrgRp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnPrgRp.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnPrgRp.Name = "materialBtnPrgRp";
            this.materialBtnPrgRp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnPrgRp.Size = new System.Drawing.Size(212, 36);
            this.materialBtnPrgRp.TabIndex = 0;
            this.materialBtnPrgRp.Text = "PREGUNTAS Y RESPUESTAS";
            this.materialBtnPrgRp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnPrgRp.UseAccentColor = false;
            this.materialBtnPrgRp.UseVisualStyleBackColor = true;
            this.materialBtnPrgRp.Click += new System.EventHandler(this.materialBtnPrgRp_Click);
            // 
            // materialBtnConfig
            // 
            this.materialBtnConfig.AutoSize = false;
            this.materialBtnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnConfig.Depth = 0;
            this.materialBtnConfig.HighEmphasis = true;
            this.materialBtnConfig.Icon = null;
            this.materialBtnConfig.Location = new System.Drawing.Point(63, 83);
            this.materialBtnConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnConfig.Name = "materialBtnConfig";
            this.materialBtnConfig.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnConfig.Size = new System.Drawing.Size(212, 36);
            this.materialBtnConfig.TabIndex = 0;
            this.materialBtnConfig.Text = "CONFIGURACION";
            this.materialBtnConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnConfig.UseAccentColor = false;
            this.materialBtnConfig.UseVisualStyleBackColor = true;
            this.materialBtnConfig.Click += new System.EventHandler(this.materialBtnConfig_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // materialTxtRol
            // 
            this.materialTxtRol.AnimateReadOnly = false;
            this.materialTxtRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtRol.Depth = 0;
            this.materialTxtRol.Enabled = false;
            this.materialTxtRol.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtRol.Hint = "Rol";
            this.materialTxtRol.LeadingIcon = null;
            this.materialTxtRol.Location = new System.Drawing.Point(53, 158);
            this.materialTxtRol.MaxLength = 50;
            this.materialTxtRol.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtRol.Multiline = false;
            this.materialTxtRol.Name = "materialTxtRol";
            this.materialTxtRol.Size = new System.Drawing.Size(236, 50);
            this.materialTxtRol.TabIndex = 1;
            this.materialTxtRol.Text = "";
            this.materialTxtRol.TrailingIcon = null;
            // 
            // materialTxtUser
            // 
            this.materialTxtUser.AnimateReadOnly = false;
            this.materialTxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtUser.Depth = 0;
            this.materialTxtUser.Enabled = false;
            this.materialTxtUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtUser.Hint = "Username";
            this.materialTxtUser.LeadingIcon = null;
            this.materialTxtUser.Location = new System.Drawing.Point(53, 77);
            this.materialTxtUser.MaxLength = 50;
            this.materialTxtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtUser.Multiline = false;
            this.materialTxtUser.Name = "materialTxtUser";
            this.materialTxtUser.Size = new System.Drawing.Size(236, 50);
            this.materialTxtUser.TabIndex = 1;
            this.materialTxtUser.Text = "";
            this.materialTxtUser.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puntaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion del Usuario";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.ImageKey = "icons8-character-animator-64.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personajes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialBtnPerso3);
            this.materialCard2.Controls.Add(this.label6);
            this.materialCard2.Controls.Add(this.materialBtnPerso2);
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Controls.Add(this.materialBtnPerso1);
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(140, 86);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(598, 334);
            this.materialCard2.TabIndex = 2;
            // 
            // materialBtnPerso3
            // 
            this.materialBtnPerso3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnPerso3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnPerso3.Depth = 0;
            this.materialBtnPerso3.HighEmphasis = true;
            this.materialBtnPerso3.Icon = null;
            this.materialBtnPerso3.Location = new System.Drawing.Point(268, 260);
            this.materialBtnPerso3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnPerso3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnPerso3.Name = "materialBtnPerso3";
            this.materialBtnPerso3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnPerso3.Size = new System.Drawing.Size(64, 36);
            this.materialBtnPerso3.TabIndex = 4;
            this.materialBtnPerso3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnPerso3.UseAccentColor = false;
            this.materialBtnPerso3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Personaje 3";
            // 
            // materialBtnPerso2
            // 
            this.materialBtnPerso2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnPerso2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnPerso2.Depth = 0;
            this.materialBtnPerso2.HighEmphasis = true;
            this.materialBtnPerso2.Icon = null;
            this.materialBtnPerso2.Location = new System.Drawing.Point(268, 153);
            this.materialBtnPerso2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnPerso2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnPerso2.Name = "materialBtnPerso2";
            this.materialBtnPerso2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnPerso2.Size = new System.Drawing.Size(64, 36);
            this.materialBtnPerso2.TabIndex = 4;
            this.materialBtnPerso2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnPerso2.UseAccentColor = false;
            this.materialBtnPerso2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Personaje 2";
            // 
            // materialBtnPerso1
            // 
            this.materialBtnPerso1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnPerso1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnPerso1.Depth = 0;
            this.materialBtnPerso1.HighEmphasis = true;
            this.materialBtnPerso1.Icon = null;
            this.materialBtnPerso1.Location = new System.Drawing.Point(268, 45);
            this.materialBtnPerso1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnPerso1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnPerso1.Name = "materialBtnPerso1";
            this.materialBtnPerso1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnPerso1.Size = new System.Drawing.Size(64, 36);
            this.materialBtnPerso1.TabIndex = 4;
            this.materialBtnPerso1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnPerso1.UseAccentColor = false;
            this.materialBtnPerso1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personaje 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personajes";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-character-animator-64.png");
            this.imageList1.Images.SetKeyName(1, "icons8-contacts-32.png");
            // 
            // VistaUserPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "VistaUserPersonajes";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios y Personajes";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox materialTxtUser;
        private MaterialSkin.Controls.MaterialTextBox materialTxtRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton materialBtnSalir;
        private MaterialSkin.Controls.MaterialButton materialBtnPrgRp;
        private MaterialSkin.Controls.MaterialButton materialBtnConfig;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton materialBtnPerso3;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialButton materialBtnPerso2;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton materialBtnPerso1;
    }
}