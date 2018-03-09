using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MiniAccess
{
    /*About the project*/
    public partial class frmAbout : MetroForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            txtAbout.AppendText("Mini Access Database Creator");
            txtAbout.AppendText(Environment.NewLine);
            txtAbout.AppendText("Version 1.0");
            txtAbout.AppendText(Environment.NewLine);
            txtAbout.AppendText(Environment.NewLine);
            txtAbout.AppendText("Developed by: Walter Henrike");
            txtAbout.AppendText(Environment.NewLine);
            txtAbout.AppendText("LaSalle College - Winter 2018");
            txtAbout.AppendText(Environment.NewLine);
            txtAbout.AppendText("Teacher: Fodé Toure");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
