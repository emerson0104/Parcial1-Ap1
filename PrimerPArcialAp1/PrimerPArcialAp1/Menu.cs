using PrimerPArcialAp1.UI.Consultas;
using PrimerPArcialAp1.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerPArcialAp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void EvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEvaluacion r = new rEvaluacion();
            r.Show();
        }

        private void ConsultaEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEvaluacion c = new cEvaluacion();
            c.Show();
        }
    }
}
