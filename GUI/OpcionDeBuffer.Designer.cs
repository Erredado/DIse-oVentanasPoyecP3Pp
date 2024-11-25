namespace GUI
{
    partial class OpcionDeBuffer
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

        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblCancelar = new MaterialSkin.Controls.MaterialLabel();
            this.lblRecuperar = new MaterialSkin.Controls.MaterialLabel();
            this.lblAumentar = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnAumentar = new MaterialSkin.Controls.MaterialButton();
            this.btnRecuperar = new MaterialSkin.Controls.MaterialButton();
            this.labelcancelar = new System.Windows.Forms.Label();
            this.labelrecuperar = new System.Windows.Forms.Label();
            this.labelaumentar = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.labelcancelar);
            this.materialCard1.Controls.Add(this.labelrecuperar);
            this.materialCard1.Controls.Add(this.labelaumentar);
            this.materialCard1.Controls.Add(this.lblCancelar);
            this.materialCard1.Controls.Add(this.lblRecuperar);
            this.materialCard1.Controls.Add(this.lblAumentar);
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.btnAumentar);
            this.materialCard1.Controls.Add(this.btnRecuperar);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(16, 80);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(468, 300);
            this.materialCard1.TabIndex = 0;
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Depth = 0;
            this.lblCancelar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCancelar.Location = new System.Drawing.Point(240, 220);
            this.lblCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(1, 0);
            this.lblCancelar.TabIndex = 5;
            // 
            // lblRecuperar
            // 
            this.lblRecuperar.AutoSize = true;
            this.lblRecuperar.Depth = 0;
            this.lblRecuperar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRecuperar.Location = new System.Drawing.Point(240, 140);
            this.lblRecuperar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRecuperar.Name = "lblRecuperar";
            this.lblRecuperar.Size = new System.Drawing.Size(1, 0);
            this.lblRecuperar.TabIndex = 4;
            // 
            // lblAumentar
            // 
            this.lblAumentar.AutoSize = true;
            this.lblAumentar.Depth = 0;
            this.lblAumentar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAumentar.Location = new System.Drawing.Point(240, 60);
            this.lblAumentar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAumentar.Name = "lblAumentar";
            this.lblAumentar.Size = new System.Drawing.Size(1, 0);
            this.lblAumentar.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(14, 200);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(200, 60);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAumentar
            // 
            this.btnAumentar.AutoSize = false;
            this.btnAumentar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAumentar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAumentar.Depth = 0;
            this.btnAumentar.HighEmphasis = true;
            this.btnAumentar.Icon = null;
            this.btnAumentar.Location = new System.Drawing.Point(14, 40);
            this.btnAumentar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAumentar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAumentar.Size = new System.Drawing.Size(200, 60);
            this.btnAumentar.TabIndex = 1;
            this.btnAumentar.Text = "Aumentar daño";
            this.btnAumentar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAumentar.UseAccentColor = false;
            this.btnAumentar.UseVisualStyleBackColor = true;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.AutoSize = false;
            this.btnRecuperar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecuperar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRecuperar.Depth = 0;
            this.btnRecuperar.HighEmphasis = true;
            this.btnRecuperar.Icon = null;
            this.btnRecuperar.Location = new System.Drawing.Point(14, 120);
            this.btnRecuperar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRecuperar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRecuperar.Size = new System.Drawing.Size(200, 60);
            this.btnRecuperar.TabIndex = 0;
            this.btnRecuperar.Text = "Recuperar mana";
            this.btnRecuperar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRecuperar.UseAccentColor = false;
            this.btnRecuperar.UseVisualStyleBackColor = true;
            // 
            // labelcancelar
            // 
            this.labelcancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelcancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelcancelar.Location = new System.Drawing.Point(247, 199);
            this.labelcancelar.Name = "labelcancelar";
            this.labelcancelar.Size = new System.Drawing.Size(198, 61);
            this.labelcancelar.TabIndex = 18;
            this.labelcancelar.Text = "-";
            // 
            // labelrecuperar
            // 
            this.labelrecuperar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelrecuperar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelrecuperar.Location = new System.Drawing.Point(247, 120);
            this.labelrecuperar.Name = "labelrecuperar";
            this.labelrecuperar.Size = new System.Drawing.Size(197, 61);
            this.labelrecuperar.TabIndex = 17;
            this.labelrecuperar.Text = "-";
            // 
            // labelaumentar
            // 
            this.labelaumentar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelaumentar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelaumentar.Location = new System.Drawing.Point(247, 40);
            this.labelaumentar.Name = "labelaumentar";
            this.labelaumentar.Size = new System.Drawing.Size(197, 61);
            this.labelaumentar.TabIndex = 16;
            this.labelaumentar.Text = "-";
            // 
            // OpcionDeBuffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.materialCard1);
            this.Name = "OpcionDeBuffer";
            this.Text = "Opciones de Buffer";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblCancelar;
        private MaterialSkin.Controls.MaterialLabel lblRecuperar;
        private MaterialSkin.Controls.MaterialLabel lblAumentar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnAumentar;
        private MaterialSkin.Controls.MaterialButton btnRecuperar;
        private System.Windows.Forms.Label labelcancelar;
        private System.Windows.Forms.Label labelrecuperar;
        private System.Windows.Forms.Label labelaumentar;
    }
}

