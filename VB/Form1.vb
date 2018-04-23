Imports System
Imports System.Windows.Forms
' ...

Namespace ChangeMeasureUnits
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			report.CreateDocument()
		End Sub

		Private report As New XtraReport1()

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			report.PrintingSystem.PreviewFormEx.PrintControl.IsMetric = True
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			report.PrintingSystem.PreviewFormEx.PrintControl.IsMetric = False
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			report.PrintingSystem.PreviewFormEx.Show()
		End Sub

	End Class
End Namespace