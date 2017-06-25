using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoverhuur
{
    public partial class Autoverhuur : Form
    {
        public Autoverhuur()
        {
            InitializeComponent();
        }

        private void defaultState()
        {
            foreach (var cb in Controls.OfType<ComboBox>())
            {
                cb.SelectedIndex = 0;
            }

            textBoxTotaalPrijs.Text = "";
            textBoxKilometerInput.Text = "";
            textBoxFout.Text = "";
            textBoxFoutStartDatum.Text = "";
            textBoxFoutEindDatum.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Autoverhuur_Load(object sender, EventArgs e)
        {
            defaultState();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            defaultState();
        }
    }    
}
