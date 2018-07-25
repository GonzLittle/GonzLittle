Imports MetroFramework
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rpt As New Employee
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class