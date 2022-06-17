using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDSACourseWork.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            QueenBtn.Checked = false;
        }

        private void QueenBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            Panel panel = (Panel)mainForm.Controls["ScreenPanel"];
            panel.Controls.Clear();

            var chessBoardForm = new ChessBoardForm
            {
                TopLevel = false
            };

            panel.Controls.Add(chessBoardForm);
            chessBoardForm.Show();
        }

        private void ShortPathBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            Panel panel = (Panel)mainForm.Controls["ScreenPanel"];
            panel.Controls.Clear();

            var shortPathForm = new ShortestPathForm
            {
                TopLevel = false
            };

            panel.Controls.Add(shortPathForm);
            shortPathForm.Show();
        }

        private void ConnectorBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            Panel panel = (Panel)mainForm.Controls["ScreenPanel"];
            panel.Controls.Clear();

            var minConnectorForm = new MinConnectorForm
            {
                TopLevel = false
            };

            panel.Controls.Add(minConnectorForm);
            minConnectorForm.Show();
        }

        private void ShortPathBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
