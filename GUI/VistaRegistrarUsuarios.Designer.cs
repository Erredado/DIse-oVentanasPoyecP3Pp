namespace GUI
{
    partial class VistaRegistrarUsuarios
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
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtcontra = new MaterialSkin.Controls.MaterialTextBox();
            this.BtRegistar = new MaterialSkin.Controls.MaterialButton();
            this.btestudiante = new MaterialSkin.Controls.MaterialRadioButton();
            this.btprofe = new MaterialSkin.Controls.MaterialRadioButton();
            this.BtCancelar = new MaterialSkin.Controls.MaterialButton();
            this.lblLoginTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.Hint = "Username";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(325, 204);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(256, 50);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = null;
            // 
            // txtcontra
            // 
            this.txtcontra.AnimateReadOnly = false;
            this.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontra.Depth = 0;
            this.txtcontra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcontra.Hint = "Password";
            this.txtcontra.LeadingIcon = null;
            this.txtcontra.Location = new System.Drawing.Point(325, 260);
            this.txtcontra.MaxLength = 50;
            this.txtcontra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcontra.Multiline = false;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(255, 50);
            this.txtcontra.TabIndex = 0;
            this.txtcontra.Text = "";
            this.txtcontra.TrailingIcon = null;
            // 
            // BtRegistar
            // 
            this.BtRegistar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtRegistar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtRegistar.Depth = 0;
            this.BtRegistar.HighEmphasis = true;
            this.BtRegistar.Icon = null;
            this.BtRegistar.Location = new System.Drawing.Point(349, 397);
            this.BtRegistar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtRegistar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtRegistar.Name = "BtRegistar";
            this.BtRegistar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtRegistar.Size = new System.Drawing.Size(99, 36);
            this.BtRegistar.TabIndex = 1;
            this.BtRegistar.Text = "Registrar";
            this.BtRegistar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtRegistar.UseAccentColor = false;
            this.BtRegistar.UseVisualStyleBackColor = true;
            this.BtRegistar.Click += new System.EventHandler(this.materialBtnRegistrar_Click);
            // 
            // btestudiante
            // 
            this.btestudiante.AutoSize = true;
            this.btestudiante.Depth = 0;
            this.btestudiante.Location = new System.Drawing.Point(338, 354);
            this.btestudiante.Margin = new System.Windows.Forms.Padding(0);
            this.btestudiante.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btestudiante.MouseState = MaterialSkin.MouseState.HOVER;
            this.btestudiante.Name = "btestudiante";
            this.btestudiante.Ripple = true;
            this.btestudiante.Size = new System.Drawing.Size(110, 37);
            this.btestudiante.TabIndex = 2;
            this.btestudiante.TabStop = true;
            this.btestudiante.Text = "Estudiante";
            this.btestudiante.UseVisualStyleBackColor = true;
            // 
            // btprofe
            // 
            this.btprofe.AutoSize = true;
            this.btprofe.Depth = 0;
            this.btprofe.Location = new System.Drawing.Point(463, 354);
            this.btprofe.Margin = new System.Windows.Forms.Padding(0);
            this.btprofe.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btprofe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btprofe.Name = "btprofe";
            this.btprofe.Ripple = true;
            this.btprofe.Size = new System.Drawing.Size(95, 37);
            this.btprofe.TabIndex = 3;
            this.btprofe.TabStop = true;
            this.btprofe.Text = "Profesor";
            this.btprofe.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtCancelar.Depth = 0;
            this.BtCancelar.HighEmphasis = true;
            this.BtCancelar.Icon = null;
            this.BtCancelar.Location = new System.Drawing.Point(462, 397);
            this.BtCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtCancelar.Size = new System.Drawing.Size(96, 36);
            this.BtCancelar.TabIndex = 5;
            this.BtCancelar.Text = "CANCELAR";
            this.BtCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtCancelar.UseAccentColor = false;
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.materialBtnCancelar_Click);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Depth = 0;
            this.lblLoginTitle.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoginTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblLoginTitle.Location = new System.Drawing.Point(384, 150);
            this.lblLoginTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(127, 41);
            this.lblLoginTitle.TabIndex = 8;
            this.lblLoginTitle.Text = "Registro";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(421, 313);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 41);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Rol";
            // 
            // VistaRegistrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblLoginTitle);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.btprofe);
            this.Controls.Add(this.btestudiante);
            this.Controls.Add(this.BtRegistar);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtnombre);
            this.Name = "VistaRegistrarUsuarios";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialTextBox txtcontra;
        private MaterialSkin.Controls.MaterialButton BtRegistar;
        private MaterialSkin.Controls.MaterialRadioButton btestudiante;
        private MaterialSkin.Controls.MaterialRadioButton btprofe;
        private MaterialSkin.Controls.MaterialButton BtCancelar;
        private MaterialSkin.Controls.MaterialLabel lblLoginTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}