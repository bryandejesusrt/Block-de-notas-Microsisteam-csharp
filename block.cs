using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block_de_Notas_MicrosisTeam_
{
    public partial class block : Form
    {
        public block()
        {
            InitializeComponent();
        }

        private void block_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.Start();
        }
    }
}
