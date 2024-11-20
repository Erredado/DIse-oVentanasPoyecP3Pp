namespace GUI
{
    partial class VistaConsulPrgRp
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialBtnCategoria = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnVolver = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de Preguntas y Respuestas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 359);
            this.dataGridView1.TabIndex = 2;
            // 
            // materialBtnCategoria
            // 
            this.materialBtnCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnCategoria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnCategoria.Depth = 0;
            this.materialBtnCategoria.HighEmphasis = true;
            this.materialBtnCategoria.Icon = null;
            this.materialBtnCategoria.Location = new System.Drawing.Point(102, 536);
            this.materialBtnCategoria.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnCategoria.Name = "materialBtnCategoria";
            this.materialBtnCategoria.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnCategoria.Size = new System.Drawing.Size(206, 36);
            this.materialBtnCategoria.TabIndex = 3;
            this.materialBtnCategoria.Text = "MOSTRAR POR CATEGORIA";
            this.materialBtnCategoria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnCategoria.UseAccentColor = false;
            this.materialBtnCategoria.UseVisualStyleBackColor = true;
            // 
            // materialBtnAgregar
            // 
            this.materialBtnAgregar.AutoSize = false;
            this.materialBtnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnAgregar.Depth = 0;
            this.materialBtnAgregar.HighEmphasis = true;
            this.materialBtnAgregar.Icon = null;
            this.materialBtnAgregar.Location = new System.Drawing.Point(351, 536);
            this.materialBtnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnAgregar.Name = "materialBtnAgregar";
            this.materialBtnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnAgregar.Size = new System.Drawing.Size(206, 36);
            this.materialBtnAgregar.TabIndex = 3;
            this.materialBtnAgregar.Text = "Agregar";
            this.materialBtnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnAgregar.UseAccentColor = false;
            this.materialBtnAgregar.UseVisualStyleBackColor = true;
            this.materialBtnAgregar.Click += new System.EventHandler(this.materialBtnAgregar_Click);
            // 
            // materialBtnVolver
            // 
            this.materialBtnVolver.AutoSize = false;
            this.materialBtnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnVolver.Depth = 0;
            this.materialBtnVolver.HighEmphasis = true;
            this.materialBtnVolver.Icon = null;
            this.materialBtnVolver.Location = new System.Drawing.Point(589, 536);
            this.materialBtnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnVolver.Name = "materialBtnVolver";
            this.materialBtnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnVolver.Size = new System.Drawing.Size(206, 36);
            this.materialBtnVolver.TabIndex = 3;
            this.materialBtnVolver.Text = "VOLVER";
            this.materialBtnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnVolver.UseAccentColor = false;
            this.materialBtnVolver.UseVisualStyleBackColor = true;
            this.materialBtnVolver.Click += new System.EventHandler(this.materialBtnVolver_Click);
            // 
            // VistaConsulPrgRp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialBtnVolver);
            this.Controls.Add(this.materialBtnAgregar);
            this.Controls.Add(this.materialBtnCategoria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "VistaConsulPrgRp";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas y Respuestas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton materialBtnCategoria;
        private MaterialSkin.Controls.MaterialButton materialBtnAgregar;
        private MaterialSkin.Controls.MaterialButton materialBtnVolver;
    }
}