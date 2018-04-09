using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebisPro_App
{
    public partial class DevisPro : Form
    {
        public DevisPro()
        {
            InitializeComponent();
            tiempo.Enabled = true;
            tiempo.Interval = 5000;
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
