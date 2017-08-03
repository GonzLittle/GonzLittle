Imports System.ComponentModel
Imports MetroFramework

Public Class MainForm
    'form load
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'StyleManager = Msm
    End Sub
    'from employee same theme to mdiparent
    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        Try
            Dim _frmemployee As New FrmEmployee
            _frmemployee.StyleManager = Me.StyleManager
            _frmemployee.ShowDialog()
            _frmemployee.Dispose()
        Catch ex As Exception
        End Try
    End Sub
    'light theme
    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        'Try
        '    Msm.Theme = MetroFramework.MetroThemeStyle.Light
        'Catch ex As Exception
        'End Try
    End Sub
    'dark theme
    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        'Try
        '    Msm.Theme = MetroFramework.MetroThemeStyle.Dark
        'Catch ex As Exception
        'End Try
    End Sub

    'style
    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        'Styletransition()
    End Sub
#Region "Functions"
    ''for style
    'Public Sub Styletransition()
    '    Try
    '        Dim _color As String = MetroComboBox1.Text.Trim
    '        If CStr(_color) = "Black" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Black
    '        ElseIf CStr(_color) = "White" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.White
    '        ElseIf CStr(_color) = "Silver" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Silver
    '        ElseIf CStr(_color) = "Blue" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Blue
    '        ElseIf CStr(_color) = "Green" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Green
    '        ElseIf CStr(_color) = "Lime" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Lime
    '        ElseIf CStr(_color) = "Teal" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Teal
    '        ElseIf CStr(_color) = "Orange" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Orange
    '        ElseIf CStr(_color) = "Brown" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Brown
    '        ElseIf CStr(_color) = "Pink" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Pink
    '        ElseIf CStr(_color) = "Magenta" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Magenta
    '        ElseIf CStr(_color) = "Purple" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Purple
    '        ElseIf CStr(_color) = "Red" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Red
    '        ElseIf CStr(_color) = "Yellow" Then
    '            Msm.Style = MetroFramework.MetroColorStyle.Yellow
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
#End Region
    'form close
    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            MetroMessageBox.Show(Me, vbCrLf & "Coded by :" & vbCrLf & vbCrLf & "Jerald G. Sanchez" & vbCrLf & "(PGLU-HRMD Series of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub mtreport_Click(sender As Object, e As EventArgs) Handles mtreport.Click
        Try
            Dim _Report As New Report
            _Report.StyleManager = Me.StyleManager
            _Report.ShowDialog()
            _Report.Dispose()
        Catch ex As Exception
        End Try
    End Sub
End Class
