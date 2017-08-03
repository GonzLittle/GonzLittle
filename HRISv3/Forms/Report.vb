''    Private Property
'    Office of the Provincial Government
'    Human Resource management Division
'    Coded By : Jerald Sanchez
'    Job Order Employee
'    CopyRight © Series of 2017
Imports System.Data.OleDb
Imports MetroFramework

Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = msm2
        FillofficeREPORT()
        FillappstatusREPORT()
        check1.Checked = True
        datagrid_formload()

    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        msm2.Theme = MetroFramework.MetroThemeStyle.Light
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        msm2.Theme = MetroFramework.MetroThemeStyle.Dark
    End Sub


#Region "Functions"

    Public Sub datagrid_formload()


        'Fill Data GridView Form load
        Dim Dgv As New OleDbDataAdapter("SELECT distinct employee.*, emp_education.DateHired, emp_education.Eligibility, emp_education.HighestEducation FROM employee INNER JOIN emp_education ON employee.idnumber=emp_education.idnum order by employee.fullname asc", Myconnection)

        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
        txtcount.Text = CType(MetroGrid1.Rows.Count, String)
    End Sub

    'fill office REPORT
    Public Sub FillofficeREPORT()

        'Dim myconnection As New OleDbConnection
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString

        query = "select Distinct Office from Employee Order by Office Asc"
        command = New OleDbCommand(query, Myconnection)
        Myconnection.Close()
        Myconnection.Open()
        reader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                repdept.Items.Add(reader("Office"))
            End While
        End If
        Myconnection.Close()
    End Sub


    'fill app status
    Public Sub FillappstatusREPORT()

        'Dim myconnection As New OleDbConnection
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        Myconnection.Open()


        Dim query As String
        Dim command As OleDbCommand
        Dim reader As OleDbDataReader
        Myconnection.Close()
        Myconnection.Open()
        query = "select Distinct app_status from Employee Order by App_status Asc"
        command = New OleDbCommand(query, Myconnection)
        reader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                repapp.Items.Add(reader("App_status"))
            End While
        End If
        Myconnection.Close()


    End Sub
    'fill office EDITEMPLOYEE
    Public Sub FillofficeEDIT()

        'Dim myconnection As New OleDbConnection
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        Dim query As String
        Dim command As OleDbCommand
        Dim reader As OleDbDataReader

        query = "select Distinct Office from Employee Order by Office Asc"
        command = New OleDbCommand(query, Myconnection)
        Myconnection.Close()
        Myconnection.Open()
        reader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                Editemployee.txt7.Items.Add(reader("Office"))
            End While
        End If
        Myconnection.Close()
    End Sub

    'fill app status EDITEMPLOYEE
    Public Sub FillappstatusEDIT()
        'Dim myconnection As New OleDbConnection
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        Myconnection.Open()


        Dim query As String
        Dim command As OleDbCommand
        Dim reader As OleDbDataReader
        Myconnection.Close()
        Myconnection.Open()
        query = "select Distinct app_status from Employee Order by App_status Asc"
        command = New OleDbCommand(query, Myconnection)
        reader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                Editemployee.txt8.Items.Add(reader("app_status"))
            End While
        End If
        Myconnection.Close()


    End Sub

    Private Sub repdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles repdept.SelectedIndexChanged


        Dim office As String
        office = repdept.Text
        Dim _empstatus As String = check1.Text.Trim
        'Fill Data GridView
        'Dim Dgv As New OleDbDataAdapter("Select * From Employee  Where Office='" & office & "' Order by FullName Asc", Myconnection)
        Dim Dgv As New OleDbDataAdapter("SELECT distinct employee.*, emp_education.DateHired, emp_education.Eligibility, emp_education.HighestEducation FROM employee INNER JOIN emp_education ON employee.idnumber=emp_education.idnum Where Office='" & office & "' AND emp_status='" & _empstatus & "' order by employee.fullname asc", Myconnection)

        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
        txtcount.Text = CType(MetroGrid1.Rows.Count, String)
    End Sub


    Private Sub repapp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles repapp.SelectedIndexChanged

        Dim office As String = repdept.Text
        Dim appstats As String = repapp.Text

        If repdept.Text = "" Then

            'Fill Data GridView
            Dim Dgv As New OleDbDataAdapter("SELECT distinct employee.*, emp_education.DateHired, emp_education.Eligibility, emp_education.HighestEducation FROM employee INNER JOIN emp_education ON employee.idnumber=emp_education.idnum  Where App_status='" & appstats & "'", Myconnection)
            Dim DtSet As New DataSet
            Dgv.Fill(DtSet)
            MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
            txtcount.Text = CType(MetroGrid1.Rows.Count, String)
        Else
            'Fill Data GridView
            Dim Dgv As New OleDbDataAdapter("SELECT distinct employee.*, emp_education.DateHired, emp_education.Eligibility, emp_education.HighestEducation FROM employee INNER JOIN emp_education ON employee.idnumber=emp_education.idnum  Where App_status='" & appstats & "' and Office='" & office & "' Order by FullName Asc", Myconnection)
            Dim DtSet As New DataSet
            Dgv.Fill(DtSet)
            MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
            txtcount.Text = CType(MetroGrid1.Rows.Count, String)
        End If
    End Sub
    'datagrid doubleclick to editemployee txtboxes
    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick

        Try

            Editemployee.StyleManager = Me.StyleManager
            FillappstatusEDIT()
            FillofficeEDIT()
            datatodatagrid()

            Editemployee.ShowDialog()
            Editemployee.Dispose()

        Catch ex As Exception

        End Try

    End Sub



    Public Sub datatodatagrid()
        Editemployee.lblid.Text = MetroGrid1.CurrentRow.Cells(0).Value.ToString
        'lblname.Text = MetroGrid1.CurrentRow.Cells(1).Value.ToString

        'Profile
        Editemployee.txt1.Text = MetroGrid1.CurrentRow.Cells(0).Value.ToString
        Editemployee.txt2.Text = MetroGrid1.CurrentRow.Cells(1).Value.ToString
        Editemployee.Txt3.Text = MetroGrid1.CurrentRow.Cells(2).Value.ToString
        Editemployee.txt4.Text = MetroGrid1.CurrentRow.Cells(3).Value.ToString
        Editemployee.txt5.Text = MetroGrid1.CurrentRow.Cells(4).Value.ToString
        Editemployee.txt6.Text = MetroGrid1.CurrentRow.Cells(5).Value.ToString
        Editemployee.txt7.Text = MetroGrid1.CurrentRow.Cells(6).Value.ToString
        Editemployee.txt8.Text = MetroGrid1.CurrentRow.Cells(7).Value.ToString
        Editemployee.txt9.Text = MetroGrid1.CurrentRow.Cells(8).Value.ToString

        Loadpicture()

    End Sub
    Public Sub Loadpicture()
        Try
            Dim idno As String = Editemployee.lblid.Text.ToString
            Dim folder As String = "\\pmis_server\pictures"
            Dim filename As String = System.IO.Path.Combine(folder, idno & ".jpg")
            Dim folder1 As String = "C:\Users\User\Desktop\HRIS\Displaydata\Resources"
            Dim filename1 As String = System.IO.Path.Combine(folder, "error image.jpg")
            If Not System.IO.File.Exists(filename) Then
                ' file does not exist
                Editemployee.PictureBox1.Image = Nothing


            Else
                Editemployee.PictureBox1.Image = Image.FromFile(filename)
                Editemployee.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            End If

        Catch ex As Exception

        End Try
    End Sub
    'for styletransitions
    Private Sub MetroComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles MetroComboBox3.SelectedIndexChanged
        Styletransition()
    End Sub
    Public Sub Styletransition()
        Dim _color As String = MetroComboBox3.Text.Trim
        If CStr(_color) = "Black" Then
            msm2.Style = MetroFramework.MetroColorStyle.Black
        ElseIf CStr(_color) = "White" Then
            msm2.Style = MetroFramework.MetroColorStyle.White
        ElseIf CStr(_color) = "Silver" Then
            msm2.Style = MetroFramework.MetroColorStyle.Silver
        ElseIf CStr(_color) = "Blue" Then
            msm2.Style = MetroFramework.MetroColorStyle.Blue
        ElseIf CStr(_color) = "Green" Then
            msm2.Style = MetroFramework.MetroColorStyle.Green
        ElseIf CStr(_color) = "Lime" Then
            msm2.Style = MetroFramework.MetroColorStyle.Lime
        ElseIf CStr(_color) = "Teal" Then
            msm2.Style = MetroFramework.MetroColorStyle.Teal
        ElseIf CStr(_color) = "Orange" Then
            msm2.Style = MetroFramework.MetroColorStyle.Orange
        ElseIf CStr(_color) = "Brown" Then
            msm2.Style = MetroFramework.MetroColorStyle.Brown
        ElseIf CStr(_color) = "Pink" Then
            msm2.Style = MetroFramework.MetroColorStyle.Pink
        ElseIf CStr(_color) = "Magenta" Then
            msm2.Style = MetroFramework.MetroColorStyle.Magenta
        ElseIf CStr(_color) = "Purple" Then
            msm2.Style = MetroFramework.MetroColorStyle.Purple
        ElseIf CStr(_color) = "Red" Then
            msm2.Style = MetroFramework.MetroColorStyle.Red
        ElseIf CStr(_color) = "Yellow" Then
            msm2.Style = MetroFramework.MetroColorStyle.Yellow
        End If
    End Sub

    Private Sub check1_CheckedChanged(sender As Object, e As EventArgs) Handles check1.CheckedChanged
        Try
            clearcontrols()
            Dim empstring As String = "Active"
            Dim _empstring As String = "Inactive"
            If check1.Checked = True Then
                check1.Text = empstring
            Else
                check1.Text = _empstring
            End If
        Catch ex As Exception

        End Try

    End Sub



#End Region
    Public Sub clearcontrols()
        repdept.SelectedIndex = -1
        repapp.SelectedIndex = -1

    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        clearcontrols()
        check1.Checked = True
        datagrid_formload()
    End Sub
End Class