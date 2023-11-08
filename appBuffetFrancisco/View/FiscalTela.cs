using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBuffetFrancisco.View
{
    public partial class FiscalTela : Form
    {
        private int totalfinal = 0;
        public FiscalTela(int totalfinal)
        {
            this.totalfinal = totalfinal;
            InitializeComponent();
        }

        private void FiscalTela_Load(object sender, EventArgs e)
        {
            txt_total.Text = totalfinal.ToString();
        }
    }
}
