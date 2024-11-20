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
    public partial class VistaConsulPrgRp : MaterialForm
    {
        public VistaConsulPrgRp()
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
        }

        private void materialBtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes().ShowDialog();
            this.Close();
        }

        private void materialBtnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaRegistrarPrgRp().ShowDialog();
            this.Close();
        }
    }
}
