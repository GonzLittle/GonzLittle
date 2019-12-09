Imports System.ComponentModel
Imports MetroFramework

Public Class MainForm
    'form load
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleManager = MetroStyleManager1
    End Sub

    'light theme
    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Try
            MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light
        Catch ex As Exception
        End Try
    End Sub
    'dark theme
    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Try
            MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        Catch ex As Exception
        End Try
    End Sub

    'style
    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        Styletransition()
    End Sub
#Region "Functions"
    ''for style
    Public Sub Styletransition()
        Try
            Dim _color As String = MetroComboBox1.Text.Trim
            If CStr(_color) = "Black" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Black
            ElseIf CStr(_color) = "White" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.White
            ElseIf CStr(_color) = "Silver" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver
            ElseIf CStr(_color) = "Blue" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue
            ElseIf CStr(_color) = "Green" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
            ElseIf CStr(_color) = "Lime" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Lime
            ElseIf CStr(_color) = "Teal" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal
            ElseIf CStr(_color) = "Orange" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange
            ElseIf CStr(_color) = "Brown" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Brown
            ElseIf CStr(_color) = "Pink" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink
            ElseIf CStr(_color) = "Magenta" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta
            ElseIf CStr(_color) = "Purple" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple
            ElseIf CStr(_color) = "Red" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Red
            ElseIf CStr(_color) = "Yellow" Then
                MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow
            End If
        Catch ex As Exception
        End Try
    End Sub
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

            'Dim _Report As New Report
            '_Report.StyleManager = Me.StyleManager
            '_Report.ShowDialog()
            '_Report.Dispose()

            ''Report.ShowDialog()
            Report.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mtmaintenance_Click(sender As Object, e As EventArgs) Handles mtmaintenance.Click
        Maintenance.Show()
        Me.Hide()
    End Sub

    Private Sub mtuser_Click(sender As Object, e As EventArgs) Handles mtuser.Click
        Process.Start("C:\Users\User\Documents\Visual Studio 2017\Projects\Driver Exam\Driver Exam\bin\Debug\Driver Exam.exe")

    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        Process.Start("C:\Users\User\Documents\Visual Studio 2017\Projects\HRdoCtraCk\HRdoCtraCk\bin\x86\Debug\HRdoCtraCk.exe")
    End Sub


    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        Process.Start("C:\Users\User\Documents\PMIS2010\pmispglu.exe")
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Process.Start("C:\SQL ADv\sqladv.exe")
    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        Process.Start("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2016\Access 2016.lnk")
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        Process.Start("C:\Program Files\Adobe\Adobe Photoshop CS6 (64 Bit)\photoshop.exe")

    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        Process.Start("C:\Program Files (x86)\Photodex\ProShow Producer\proshow.exe")


    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Form3.Show()
    End Sub

    Private Sub FileArchiver_Click(sender As Object, e As EventArgs) Handles FileArchiver.Click
        Dim url As String = "https://forms.gle/X83c1dqE73JRG4Vf7"
        Process.Start(url)
    End Sub
End Class
