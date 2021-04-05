using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelhasznaloKezeles
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnLottok_Click(object sender, EventArgs e)
        {
            Otoslotto frmOtoslotto = new Otoslotto();
            frmOtoslotto.ShowDialog();
            this.Dispose();
            GC.Collect();
        }
    }
}
