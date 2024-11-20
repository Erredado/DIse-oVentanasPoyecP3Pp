namespace GUI
{
    partial class VistaEscogerPersonajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaEscogerPersonajes));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialBtnSig = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnEscPer = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnAnt = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialTxtFuerza = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtDefensa = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtVida = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtMana = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtClase = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.labelhabi2 = new System.Windows.Forms.Label();
            this.labelhabi1 = new System.Windows.Forms.Label();
            this.labelbasico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.materialBtnSig);
            this.tabPage1.Controls.Add(this.materialBtnCancelar);
            this.tabPage1.Controls.Add(this.materialBtnEscPer);
            this.tabPage1.Controls.Add(this.materialBtnAnt);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageKey = "icons8-contact-details-52.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialBtnSig
            // 
            this.materialBtnSig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnSig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnSig.Depth = 0;
            this.materialBtnSig.HighEmphasis = true;
            this.materialBtnSig.Icon = null;
            this.materialBtnSig.Location = new System.Drawing.Point(389, 453);
            this.materialBtnSig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnSig.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnSig.Name = "materialBtnSig";
            this.materialBtnSig.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnSig.Size = new System.Drawing.Size(95, 36);
            this.materialBtnSig.TabIndex = 5;
            this.materialBtnSig.Text = "Siguiente";
            this.materialBtnSig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnSig.UseAccentColor = false;
            this.materialBtnSig.UseVisualStyleBackColor = true;
            // 
            // materialBtnCancelar
            // 
            this.materialBtnCancelar.AutoSize = false;
            this.materialBtnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnCancelar.Depth = 0;
            this.materialBtnCancelar.HighEmphasis = true;
            this.materialBtnCancelar.Icon = null;
            this.materialBtnCancelar.Location = new System.Drawing.Point(553, 208);
            this.materialBtnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnCancelar.Name = "materialBtnCancelar";
            this.materialBtnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnCancelar.Size = new System.Drawing.Size(173, 36);
            this.materialBtnCancelar.TabIndex = 5;
            this.materialBtnCancelar.Text = "CANCELAR";
            this.materialBtnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnCancelar.UseAccentColor = false;
            this.materialBtnCancelar.UseVisualStyleBackColor = true;
            // 
            // materialBtnEscPer
            // 
            this.materialBtnEscPer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnEscPer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnEscPer.Depth = 0;
            this.materialBtnEscPer.HighEmphasis = true;
            this.materialBtnEscPer.Icon = null;
            this.materialBtnEscPer.Location = new System.Drawing.Point(553, 141);
            this.materialBtnEscPer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnEscPer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnEscPer.Name = "materialBtnEscPer";
            this.materialBtnEscPer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnEscPer.Size = new System.Drawing.Size(173, 36);
            this.materialBtnEscPer.TabIndex = 5;
            this.materialBtnEscPer.Text = "ESCOGER PERSONAJE";
            this.materialBtnEscPer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnEscPer.UseAccentColor = false;
            this.materialBtnEscPer.UseVisualStyleBackColor = true;
            // 
            // materialBtnAnt
            // 
            this.materialBtnAnt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnAnt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnAnt.Depth = 0;
            this.materialBtnAnt.HighEmphasis = true;
            this.materialBtnAnt.Icon = null;
            this.materialBtnAnt.Location = new System.Drawing.Point(140, 453);
            this.materialBtnAnt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnAnt.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnAnt.Name = "materialBtnAnt";
            this.materialBtnAnt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnAnt.Size = new System.Drawing.Size(92, 36);
            this.materialBtnAnt.TabIndex = 5;
            this.materialBtnAnt.Text = "Anterior";
            this.materialBtnAnt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnAnt.UseAccentColor = false;
            this.materialBtnAnt.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialTxtFuerza);
            this.materialCard1.Controls.Add(this.materialTxtDefensa);
            this.materialCard1.Controls.Add(this.materialTxtVida);
            this.materialCard1.Controls.Add(this.materialTxtMana);
            this.materialCard1.Controls.Add(this.materialTxtNombre);
            this.materialCard1.Controls.Add(this.materialTxtClase);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(106, 60);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(410, 373);
            this.materialCard1.TabIndex = 4;
            // 
            // materialTxtFuerza
            // 
            this.materialTxtFuerza.AnimateReadOnly = false;
            this.materialTxtFuerza.BackColor = System.Drawing.SystemColors.Window;
            this.materialTxtFuerza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtFuerza.Depth = 0;
            this.materialTxtFuerza.Enabled = false;
            this.materialTxtFuerza.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtFuerza.Hint = "Fuerza";
            this.materialTxtFuerza.LeadingIcon = global::GUI.Properties.Resources.icons8_strength_50;
            this.materialTxtFuerza.Location = new System.Drawing.Point(34, 246);
            this.materialTxtFuerza.MaxLength = 50;
            this.materialTxtFuerza.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtFuerza.Multiline = false;
            this.materialTxtFuerza.Name = "materialTxtFuerza";
            this.materialTxtFuerza.Size = new System.Drawing.Size(344, 50);
            this.materialTxtFuerza.TabIndex = 0;
            this.materialTxtFuerza.Text = "";
            this.materialTxtFuerza.TrailingIcon = null;
            // 
            // materialTxtDefensa
            // 
            this.materialTxtDefensa.AnimateReadOnly = false;
            this.materialTxtDefensa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtDefensa.Depth = 0;
            this.materialTxtDefensa.Enabled = false;
            this.materialTxtDefensa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtDefensa.Hint = "Defensa";
            this.materialTxtDefensa.LeadingIcon = global::GUI.Properties.Resources.icons8_defense_32;
            this.materialTxtDefensa.Location = new System.Drawing.Point(34, 302);
            this.materialTxtDefensa.MaxLength = 50;
            this.materialTxtDefensa.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtDefensa.Multiline = false;
            this.materialTxtDefensa.Name = "materialTxtDefensa";
            this.materialTxtDefensa.Size = new System.Drawing.Size(344, 50);
            this.materialTxtDefensa.TabIndex = 0;
            this.materialTxtDefensa.Text = "";
            this.materialTxtDefensa.TrailingIcon = null;
            // 
            // materialTxtVida
            // 
            this.materialTxtVida.AnimateReadOnly = false;
            this.materialTxtVida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtVida.Depth = 0;
            this.materialTxtVida.Enabled = false;
            this.materialTxtVida.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtVida.Hint = "Vida";
            this.materialTxtVida.LeadingIcon = global::GUI.Properties.Resources.icons8_heart_50;
            this.materialTxtVida.Location = new System.Drawing.Point(34, 134);
            this.materialTxtVida.MaxLength = 50;
            this.materialTxtVida.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtVida.Multiline = false;
            this.materialTxtVida.Name = "materialTxtVida";
            this.materialTxtVida.Size = new System.Drawing.Size(344, 50);
            this.materialTxtVida.TabIndex = 0;
            this.materialTxtVida.Text = "";
            this.materialTxtVida.TrailingIcon = null;
            // 
            // materialTxtMana
            // 
            this.materialTxtMana.AnimateReadOnly = false;
            this.materialTxtMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtMana.Depth = 0;
            this.materialTxtMana.Enabled = false;
            this.materialTxtMana.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtMana.Hint = "Mana";
            this.materialTxtMana.LeadingIcon = global::GUI.Properties.Resources.icons8_mana_50;
            this.materialTxtMana.Location = new System.Drawing.Point(34, 190);
            this.materialTxtMana.MaxLength = 50;
            this.materialTxtMana.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtMana.Multiline = false;
            this.materialTxtMana.Name = "materialTxtMana";
            this.materialTxtMana.Size = new System.Drawing.Size(344, 50);
            this.materialTxtMana.TabIndex = 0;
            this.materialTxtMana.Text = "";
            this.materialTxtMana.TrailingIcon = null;
            // 
            // materialTxtNombre
            // 
            this.materialTxtNombre.AnimateReadOnly = false;
            this.materialTxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtNombre.Depth = 0;
            this.materialTxtNombre.Enabled = false;
            this.materialTxtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtNombre.Hint = "Nombre";
            this.materialTxtNombre.LeadingIcon = global::GUI.Properties.Resources.icons8_contacts_32;
            this.materialTxtNombre.Location = new System.Drawing.Point(34, 22);
            this.materialTxtNombre.MaxLength = 50;
            this.materialTxtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtNombre.Multiline = false;
            this.materialTxtNombre.Name = "materialTxtNombre";
            this.materialTxtNombre.Size = new System.Drawing.Size(344, 50);
            this.materialTxtNombre.TabIndex = 0;
            this.materialTxtNombre.Text = "";
            this.materialTxtNombre.TrailingIcon = null;
            // 
            // materialTxtClase
            // 
            this.materialTxtClase.AnimateReadOnly = false;
            this.materialTxtClase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtClase.Depth = 0;
            this.materialTxtClase.Enabled = false;
            this.materialTxtClase.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtClase.Hint = "Clase";
            this.materialTxtClase.LeadingIcon = global::GUI.Properties.Resources.icons8_gen_24;
            this.materialTxtClase.Location = new System.Drawing.Point(34, 78);
            this.materialTxtClase.MaxLength = 50;
            this.materialTxtClase.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtClase.Multiline = false;
            this.materialTxtClase.Name = "materialTxtClase";
            this.materialTxtClase.Size = new System.Drawing.Size(344, 50);
            this.materialTxtClase.TabIndex = 0;
            this.materialTxtClase.Text = "";
            this.materialTxtClase.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informacion del personaje";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.ImageKey = "icons8-mage-staff-64.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Habilidades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialButton2);
            this.materialCard2.Controls.Add(this.materialButton3);
            this.materialCard2.Controls.Add(this.materialButton1);
            this.materialCard2.Controls.Add(this.labelhabi2);
            this.materialCard2.Controls.Add(this.labelhabi1);
            this.materialCard2.Controls.Add(this.labelbasico);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(93, 81);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(693, 360);
            this.materialCard2.TabIndex = 5;
            // 
            // labelhabi2
            // 
            this.labelhabi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelhabi2.Location = new System.Drawing.Point(281, 242);
            this.labelhabi2.Name = "labelhabi2";
            this.labelhabi2.Size = new System.Drawing.Size(264, 54);
            this.labelhabi2.TabIndex = 12;
            // 
            // labelhabi1
            // 
            this.labelhabi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelhabi1.Location = new System.Drawing.Point(281, 151);
            this.labelhabi1.Name = "labelhabi1";
            this.labelhabi1.Size = new System.Drawing.Size(264, 54);
            this.labelhabi1.TabIndex = 10;
            // 
            // labelbasico
            // 
            this.labelbasico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbasico.Location = new System.Drawing.Point(281, 71);
            this.labelbasico.Name = "labelbasico";
            this.labelbasico.Size = new System.Drawing.Size(264, 54);
            this.labelbasico.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(698, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Habilidades";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-contact-details-52.png");
            this.imageList1.Images.SetKeyName(1, "icons8-mage-staff-64.png");
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Enabled = false;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(116, 157);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 13;
            this.materialButton1.Text = "HABILIDAD 1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Enabled = false;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(116, 77);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 13;
            this.materialButton2.Text = "GOLPE BASICO";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Enabled = false;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(116, 248);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(158, 36);
            this.materialButton3.TabIndex = 13;
            this.materialButton3.Text = "HABILIDAD 2";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // VistaEscogerPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "VistaEscogerPersonajes";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personajes";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton materialBtnSig;
        private MaterialSkin.Controls.MaterialButton materialBtnAnt;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton materialBtnCancelar;
        private MaterialSkin.Controls.MaterialButton materialBtnEscPer;
        private MaterialSkin.Controls.MaterialTextBox materialTxtClase;
        private MaterialSkin.Controls.MaterialTextBox materialTxtFuerza;
        private MaterialSkin.Controls.MaterialTextBox materialTxtDefensa;
        private MaterialSkin.Controls.MaterialTextBox materialTxtVida;
        private MaterialSkin.Controls.MaterialTextBox materialTxtMana;
        private MaterialSkin.Controls.MaterialTextBox materialTxtNombre;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label labelhabi2;
        private System.Windows.Forms.Label labelhabi1;
        private System.Windows.Forms.Label labelbasico;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}