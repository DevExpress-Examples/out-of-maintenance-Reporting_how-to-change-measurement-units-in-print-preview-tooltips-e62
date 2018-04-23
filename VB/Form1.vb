Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace ChangeMeasureUnits
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			printTool.Report.CreateDocument(False)
		End Sub

		Private printTool As New ReportPrintTool(New XtraReport1())

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			printTool.PreviewForm.PrintControl.IsMetric = True
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			printTool.PreviewForm.PrintControl.IsMetric = False
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			printTool.PreviewForm.Show()
		End Sub

	End Class
End Namespace