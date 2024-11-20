using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class VistaUserPersonajes : MaterialForm
    {
        public VistaUserPersonajes()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Yellow800,
                MaterialSkin.Primary.Yellow900,
                MaterialSkin.Primary.Green600,
                MaterialSkin.Accent.LightGreen200,
                MaterialSkin.TextShade.WHITE
            );

            materialTxtUser.Text = "Pepe";
            materialTxtRol.Text = "Estudihambre";
        }

        private void materialBtnPrgRp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaConsulPrgRp().ShowDialog();
            this.Close();
        }

        private void materialBtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
            this.Close();
        }

        private void materialBtnConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FUNCIONES EN DASARROLLO");
        }
    }
}
