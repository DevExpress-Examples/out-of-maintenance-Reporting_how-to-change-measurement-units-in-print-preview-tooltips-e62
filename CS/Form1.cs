using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace ChangeMeasureUnits {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            printTool.Report.CreateDocument(false);
        }

        ReportPrintTool printTool = new ReportPrintTool(new XtraReport1());

        private void button1_Click(object sender, EventArgs e) {
            printTool.PreviewForm.PrintControl.IsMetric = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            printTool.PreviewForm.PrintControl.IsMetric = false;
        }

        private void button3_Click(object sender, EventArgs e) {
            printTool.PreviewForm.Show();
        }

    }
}