using System;
using System.Windows.Forms;
// ...

namespace ChangeMeasureUnits {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            report.CreateDocument();
        }

        XtraReport1 report = new XtraReport1();

        private void button1_Click(object sender, EventArgs e) {
            report.PrintingSystem.PreviewFormEx.PrintControl.IsMetric = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            report.PrintingSystem.PreviewFormEx.PrintControl.IsMetric = false;
        }

        private void button3_Click(object sender, EventArgs e) {
            report.PrintingSystem.PreviewFormEx.Show();
        }

    }
}