using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommProtocolApp.Forms.Settings
{
    public partial class Google : Form
    {
        public Google()
        {
            InitializeComponent();
        }

        private void Google_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com");
        }
    }
}
