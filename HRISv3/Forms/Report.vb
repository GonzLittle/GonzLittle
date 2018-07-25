''    Private Property
'    Office of the Provincial Government
'    Human Resource management Division
'    Coded By : Jerald Sanchez
'    Job Order Employee
'    CopyRight © Series of 2017
Imports System.ComponentModel
Imports System.Data.OleDb
Imports MetroFramework
Imports Excel = Microsoft.Office.Interop.Excel
'----------------------------------------delete all blank lines in using control find-------------------------------------------------
'(?m)^[ \t]*[\r\n]+
Public Class Report
    'form load codes
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MetroLabel4.Text = "A"
        Me.StyleManager = msm2
        FillofficeREPORT()
        FillappstatusREPORT()
        'FillpositionsREPORT()
        check1.Checked = True
        'datagrid_formload()
        MetroTextBox1.Clear()
    End Sub
    'metro style manager---------------------------------------------------------------------------
    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        msm2.Theme = MetroFramework.MetroThemeStyle.Light
    End Sub
    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        msm2.Theme = MetroFramework.MetroThemeStyle.Dark
    End Sub
    '---------------------------------end----------------------------------------------------------
#Region "Functions"
    'datagrid formload
    Public Sub datagrid_formload()
        Try
            'Dim dba As New OleDbDataAdapter("SELECT dbo_personal.pers_id, dbo_personal.fullname, dbo_department.dept_name from dbo_personal inner join dbo_department on dbo_personal.dept_code=dbo_department.dept_code order by dbo_personal.Last_name asc", Myconnection)
            Dim dba As New OleDbDataAdapter("SELECT dbo_personal.pers_id, dbo_personal.full_name,dbo_personal.birthdate, dbo_personal.app_status from dbo_personal order by dbo_personal.full_name asc", Myconnection)

            Dim DtSet As New DataSet
            dba.Fill(DtSet)
            MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
            txtcount.Text = CType(MetroGrid1.Rows.Count, String)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'department selected index
    Private Sub repdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles repdept.SelectedIndexChanged
        Try
            MetroLabel6.Text = repdept.Text.Trim
            repapp.SelectedIndex = -1
            Dim _imaginary As String = check1.Text.Trim
            If _imaginary = "Active" Then
                _imaginary = "A"
            ElseIf _imaginary = "Inactive" Then
                _imaginary = "I"
            End If

            Dim office As String
            office = repdept.Text
            If office = "-All-" Then
                datagrid_formload()
            Else
                'Fill Data GridView
                Dim dba As New OleDbDataAdapter("SELECT dbo_personal.pers_id, dbo_personal.full_name, dbo_personal.birthdate, dbo_personal.app_status from dbo_personal inner join dbo_department on dbo_personal.dept_code=dbo_department.dept_code Where dbo_department.dept_name ='" & office & "' and dbo_personal.employment_status='" & _imaginary & "' order by dbo_personal.full_name asc", Myconnection)
                Dim DtSet As New DataSet
                dba.Fill(DtSet)
                MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
                txtcount.Text = CType(MetroGrid1.Rows.Count, String)

                'Dim chk As New DataGridViewCheckBoxColumn()
                'MetroGrid1.Columns.Add(chk)
                'chk.HeaderText = "Try"
                'chk.Name = "chk"
                'MetroGrid1.Rows(0).Cells(4).Value = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'app_status selected index
    Private Sub repapp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles repapp.SelectedIndexChanged
        Try
            'employment_status
            MetroLabel5.Text = repapp.Text.Trim
            Dim _empstats As String = MetroLabel4.Text.Trim
            ' office
            Dim office As String = repdept.Text.Trim
            'app_status
            Dim _appstatus As String = MetroLabel5.Text.Trim
            Select Case _appstatus
                Case "Permanent"
                    _appstatus = "P"
                Case "Casual"
                    _appstatus = "C"
                Case "Job Order"
                    _appstatus = "J"
                Case "Co-terminous"
                    _appstatus = "S"
                Case "Contractual"
                    _appstatus = "O"
                Case "Sef"
                    _appstatus = "E"
                Case "iTax"
                    _appstatus = "I"
                Case "Volunteer"
                    _appstatus = "L"
                Case "Consultant"
                    _appstatus = "N"
                Case "Temporary"
                    _appstatus = "T"
                Case "Elected"
                    _appstatus = "V"
                Case "OJT"
                    _appstatus = "W"
                Case "Day Care"
                    _appstatus = "R"
            End Select
            If office = "-All-" Or repdept.SelectedIndex = -1 Then
                Dim dba As New OleDbDataAdapter("SELECT dbo_personal.pers_id, dbo_personal.full_name, dbo_personal.birthdate, dbo_personal.app_status from dbo_personal Where dbo_personal.app_status='" & _appstatus & "' and dbo_personal.employment_status='" & _empstats & "' order by dbo_personal.full_name asc", Myconnection)
                Dim DtSet As New DataSet
                dba.Fill(DtSet)
                MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
                txtcount.Text = CType(MetroGrid1.Rows.Count, String)
            Else
                Dim dba2 As New OleDbDataAdapter("SELECT dbo_personal.pers_id, dbo_personal.full_name, dbo_personal.birthdate, dbo_personal.app_status from dbo_personal inner join dbo_department on dbo_department.dept_code=dbo_personal.dept_code where dbo_department.dept_name= '" & office & "' and dbo_personal.app_status='" & _appstatus & "' and dbo_personal.employment_status='" & _empstats & "' order by dbo_personal.full_name asc", Myconnection)
                Dim DtSet As New DataSet
                dba2.Fill(DtSet)
                MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
                txtcount.Text = CType(MetroGrid1.Rows.Count, String)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'FOR REPORT PICTURE
    Public Sub LoadpictureREPORT()
        Try
            Dim idno As String = lblid.Text.ToString
            Dim folder As String = "\\pmis_server\pictures"
            Dim filename As String = System.IO.Path.Combine(folder, idno & ".jpg")

            If Not System.IO.File.Exists(filename) Then
                ' file does not exist
                PictureBox1.Image = Nothing
            Else
                PictureBox1.Image = Image.FromFile(filename)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = Image.FromFile(filename)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
        End Try
    End Sub
    'for styletransitions
    Private Sub MetroComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles MetroComboBox3.SelectedIndexChanged
        Styletransition()
    End Sub
    'style transitions metro UI
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
    'radio button employment status
    Private Sub check1_CheckedChanged(sender As Object, e As EventArgs) Handles check1.CheckedChanged
        Try
            clearcontrols()
            Dim _A As String = "A"
            Dim _I As String = "I"
            If check1.Checked = True Then
                check1.Text = "Active"
                MetroLabel4.Text = _A
            Else
                check1.Text = "Inactive"
                MetroLabel4.Text = _I
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
    'çlear comboboxes
    Public Sub clearcontrols()
        repdept.SelectedIndex = -1
        repapp.SelectedIndex = -1
    End Sub
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        clearcontrols()
        check1.Checked = True
        datagrid_formload()
    End Sub
    'for excel export function
    Public Sub GridToExcel(ByVal dgvw As DataGridView)
        Try
            Dim Appli As New Microsoft.Office.Interop.Excel.Application
            Dim book As Microsoft.Office.Interop.Excel.Workbook
            Dim exsheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim Col As Integer = dgvw.ColumnCount
            Dim Row As Integer = dgvw.RowCount
            book = Appli.Workbooks.Add
            'exsheet = Appli.Worksheets.Add()
            exsheet = CType(Appli.Worksheets.Add(), Excel.Worksheet)
            For i As Integer = 1 To Col
                exsheet.Cells.Item(1, i) = dgvw.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To Row - 1
                For e As Integer = 0 To Col - 1
                    exsheet.Cells.Item(Fila + 2, e + 1) = dgvw.Rows(Fila).Cells(e).Value
                Next
            Next
            exsheet.Rows.Item(1).Font.Bold = 1
            exsheet.Rows.Item(1).HorizontalAlignment = 3
            exsheet.Columns.AutoFit()
            Appli.Application.Visible = True
            Appli.Application.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
            exsheet = Nothing
            book = Nothing
            Appli = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mtmedical_Click(sender As Object, e As EventArgs)
        Form1.Dispose()
        Form1.ShowDialog()
    End Sub
    'SHOW RECORD FOR LIVE SEARCH
    Public Sub Showrecord()
        Try
            Dim searchname As String = MetroTextBox1.Text.Trim
            If searchname = "" Then
                MetroTile1.PerformClick()
            Else
                Dim dba As New OleDbDataAdapter("SELECT dbo_personal.pers_id, dbo_personal.full_name, dbo_personal.birthdate, dbo_personal.app_status from dbo_personal where pers_id Like '%" & searchname & "%' or full_name Like '%" & searchname & "%' order by dbo_personal.full_name asc", Myconnection)
                ' pers_id='" & searchname & "' 
                Dim DtSet As New DataSet
                dba.Fill(DtSet)
                MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
                txtcount.Text = CType(MetroGrid1.Rows.Count, String)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "metrogrid"
    'for search textbox enter key
    Public Sub MetroTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Showrecord()
                Dim arg = New DataGridViewCellEventArgs(3, 2)
                MetroGrid1_CellClick(Me.MetroGrid1, arg)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    'grid click id and picture
    Private Sub MetroGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellClick
        'get row id for comparison in picturebox
        lblid.Text = MetroGrid1.CurrentRow.Cells(0).Value.ToString
        LoadpictureREPORT()
    End Sub
    'data transfer to form edit employee
    Public Sub reporttoedit()
        Editemployee.txt1.Text = MetroGrid1.CurrentRow.Cells(0).Value.ToString
        'Editemployee.Label23.Text = MetroGrid1.CurrentRow.Cells(4).Value.ToString
        'lblname.Text = MetroGrid1.CurrentRow.Cells(1).Value.ToString
        'Editemployee
    End Sub
    'report form close
    Private Sub Report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MainForm.Show()
    End Sub
    ''context menu grid to excel
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        GridToExcel(MetroGrid1)
    End Sub
    'form1
    Private Sub AllEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllEmployeeToolStripMenuItem.Click
        'Form1.Dispose()
        'Form1.Show()
    End Sub
    'add new record
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        FillappstatusADD()
        FillofficeADD()
        AddNewRecord.Show()
    End Sub
    'edit record
    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        Try
            LoadpictureREPORT()
            Editemployee.StyleManager = Me.StyleManager
            FillappstatusEDIT()
            FillofficeEDIT()
            reporttoedit()
            Editemployee.ShowDialog()
            Editemployee.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'çontext menu strip
    Private Sub MetroGrid1_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroGrid1.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                ctxmenu.Show(MetroGrid1, e.Location)
            End If
            lblid.Text = MetroGrid1.CurrentRow.Cells(0).Value.ToString
            LoadpictureREPORT()
        Catch ex As Exception
        End Try
    End Sub
    'search button
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Showrecord()
    End Sub

    Private Sub mtbcollect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mtbcollect.SelectedIndexChanged
        Dim _office As String = repdept.Text.Trim
        Dim _appstats As String = repapp.Text.Trim

        If _office = "" Or _appstats = "" Then
            MetroMessageBox.Show(Me, vbCrLf & "No Parameter is selected." & vbCrLf & "Select Department and Application Status" & vbCrLf & vbCrLf & "(PGLU-HRMD Series of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mtbcollect.Text = ""
        Else

        End If
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick

    End Sub
#End Region
End Class