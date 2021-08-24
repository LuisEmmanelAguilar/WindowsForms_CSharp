using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeerXML Child
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }
    }
}
