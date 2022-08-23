using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabClass4
{
    public partial class test : Form
    {
        public test(int x)
        {
            InitializeComponent();
            MessageBox.Show(x.ToString());
        }

        private void test_Load(object sender, EventArgs e)
        {

        }
    }
}
