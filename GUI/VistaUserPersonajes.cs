using MaterialSkin;
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

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void materialBtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeDprb().ShowDialog();
            this.Close();
        }

        private void materialBtnConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FUNCIONES EN DASARROLLO");
        }

        private void VistaUserPersonajes_Load(object sender, EventArgs e)
        {
            tablapuntaje.ForeColor = Color.Black;
        }
    }
}
