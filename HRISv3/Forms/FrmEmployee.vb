Imports System.Data.OleDb
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports MetroFramework
Public Class FrmEmployee
    'Form load click functions
    Private Sub FrmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleManager = Msm


        MetroTabControl1.SelectedTab = MetroTabPage1
        'InitializeDataGridView()
        Filloffice()
        Fillappstatus()
        Fillempstatus()
        Fillposition()
        Filldtg()
        'loadmedical()


    End Sub

#Region "Functions"
    'fill office
    Public Sub Filloffice()
        Try
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
                    'cboffice.Items.Add(reader("Office"))
                    Txt7.Items.Add(reader("Office"))
                    'Addemployee.txtoffice.Items.Add(reader("Office"))
                End While
            End If
            Myconnection.Close()

        Catch ex As Exception

        End Try


    End Sub

    'fill app status
    Public Sub Fillappstatus()
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
                'cbappstatus.Items.Add(reader("App_status"))
                Txt8.Items.Add(reader("App_status"))
            End While
        End If
        Myconnection.Close()


    End Sub
    'fill employment status
    Public Sub Fillempstatus()
        'Dim myconnection As New OleDbConnection
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        Dim query As String
        Dim command As OleDbCommand
        Dim reader As OleDbDataReader

        query = "select Distinct Emp_status from Employee Order by Emp_status Asc"
        command = New OleDbCommand(query, Myconnection)
        Myconnection.Close()
        Myconnection.Open()
        reader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()

                Txt9.Items.Add(reader("Emp_status"))
                'Addemployee.txtoffice.Items.Add(reader("Office"))
            End While
        End If
        Myconnection.Close()

    End Sub
    'Fill Position
    Public Sub Fillposition()
        'Dim myconnection As New OleDbConnection
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        Myconnection.Open()

        Try
            Dim query As String
            Dim command As OleDbCommand
            Dim reader As OleDbDataReader
            Myconnection.Close()
            Myconnection.Open()
            query = "select Distinct Position from Employee Order by Position Asc"
            command = New OleDbCommand(query, Myconnection)
            reader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    MetroComboBox1.Items.Add(reader("Position"))
                End While
            End If
            Myconnection.Close()
        Catch ex As Exception


        End Try





    End Sub

    'initialize datagrid
    Public Sub InitializeDataGridView()

        ' Initialize basic DataGridView properties.
        MetroGrid1.Dock = DockStyle.Fill
        MetroGrid1.BackgroundColor = Color.LightGray

        MetroGrid1.AutoSizeRowsMode =
        DataGridViewAutoSizeRowsMode.AllCells

        ' Resize the master DataGridView columns to fit the newly loaded data.
        MetroGrid1.AutoResizeRows()

        ' Set property values appropriate for read-only display and 
        ' limited interactivity. 
        MetroGrid1.AllowUserToAddRows = False
        MetroGrid1.AllowUserToDeleteRows = False
        MetroGrid1.AllowUserToOrderColumns = False
        MetroGrid1.ReadOnly = True
        MetroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        MetroGrid1.MultiSelect = True
        MetroGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells

        'MetroGrid1.AllowUserToResizeColumns = False

        'MetroGrid1.ColumnHeadersHeightSizeMode =
        'DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        'MetroGrid1.AllowUserToResizeRows = False
        'MetroGrid1.RowHeadersWidthSizeMode =
        'DataGridViewRowHeadersWidthSizeMode.DisableResizing

        ' Set the selection background color for all the cells.
        'MetroGrid1.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue
        'DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black

        ' Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
        ' value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
        'DataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty

        '' Set the background color for all rows and for alternating rows. 
        '' The value for alternating rows overrides the value for all rows. 
        'DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray
        MetroGrid1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        ' Set the row and column header styles.
        'DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        'DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        'DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black

        ' Set the Format property on the "Last Prepared" column to cause
        ' the DateTime to be formatted as "Month, Year".
        'dataGridView1.Columns("Last Prepared").DefaultCellStyle.Format = "y"

        ' Specify a larger font for the "Ratings" column. 
        'Dim font As New Font(
        'DataGridView1.DefaultCellStyle.Font.FontFamily, 10, FontStyle.Bold)
        'Try
        '    DataGridView1.Columns("ID").DefaultCellStyle.Font = font
        'Finally
        '    font.Dispose()
        'End Try

    End Sub


    'SHOW RECORD FOR LIVE SEARCH
    Public Sub Showrecord()
        Dim searchname As String = MetroTextBox1.Text.Trim
        'Dim dba As New OleDbDataAdapter("SELECT employee.idnumber, employee.fullname, emp_education.eligibility, emp_education.highesteducation FROM employee INNER JOIN emp_education ON employee.idnumber=emp_education.idnum Where employee.IDNumber Like '%" & searchname & "%' or employee.FullName Like '%" & searchname & "%' or employee.Address Like '%" & searchname & "%' order by employee.FullName asc", Myconnection)
        'Dim dba As New OleDbDataAdapter("SELECT employee.IDNumber, employee.Fullname, Employee.Gender, employee.Birthdate, employee.Address, employee.Position, employee.Office, employee.App_status, employee.Emp_status emp_education.Datehired FROM employee INNER JOIN emp_education ON employee.idnumber=emp_education.idnum Where employee.IDNumber Like '%" & searchname & "%' or employee.FullName Like '%" & searchname & "%' or employee.Address Like '%" & searchname & "%' order by employee.FullName asc", Myconnection)

        Dim dba As New OleDbDataAdapter("SELECT * FROM employee Where employee.IDNumber Like '%" & searchname & "%' or employee.FullName Like '%" & searchname & "%'  order by employee.FullName asc", Myconnection)

        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.MetroGrid1.DataSource = dbset.Tables(0).DefaultView



        'Label20.Text = DataGridView1.Rows.Count
        txtcount.Text = CType(MetroGrid1.Rows.Count, String)


    End Sub

    Public Sub Filldtg()
        Try
            'Fill Data GridView Form load
            Dim Dgv As New OleDbDataAdapter("SELECT distinct employee.*, emp_education.DateHired, emp_education.Eligibility, emp_education.HighestEducation FROM employee INNER JOIN emp_education ON employee.idnumber=emp_education.idnum order by employee.fullname asc", Myconnection)

            Dim DtSet As New DataSet
            Dgv.Fill(DtSet)
            MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
            txtcount.Text = CType(MetroGrid1.Rows.Count, String)

        Catch ex As Exception

        End Try

    End Sub


#End Region
#Region "Txtboxes and buttons for actions"
    'txtsearch
    Private Sub Txtsearch_TextChanged(sender As Object, e As EventArgs)


    End Sub
#End Region

#Region "Clear Controls"
    Public Sub ClearcboxGB2()
        'txtgender.SelectedIndex = -1
        'txtoffice.SelectedIndex = -1
        'txtappstatus.SelectedIndex = -1

        'txtempstatus.SelectedIndex = -1
    End Sub
    Public Sub CleartxtboxGB2()
        'txtid.Clear()
        'txtfname.Clear()
        'txtbdate.Clear()
        'txtaddress.Clear()
        'txtposition.Clear()
    End Sub


#End Region




    'fill picturebox
    Public Sub Loadpicture()
        Try
            Dim idno As String = lblid.Text.ToString
            Dim folder As String = "\\pmis_server\pictures"
            Dim filename As String = System.IO.Path.Combine(folder, idno & ".jpg")
            Dim folder1 As String = "C:\Users\User\Desktop\HRIS\Displaydata\Resources"
            Dim filename1 As String = System.IO.Path.Combine(folder, "error image.jpg")
            If Not System.IO.File.Exists(filename) Then
                ' file does not exist
                PictureBox1.Image = Nothing


            Else
                PictureBox1.Image = Image.FromFile(filename)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            End If

        Catch ex As Exception

        End Try


    End Sub

    'grid to txtbox
    Private Sub MetroGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        lblid.Text = MetroGrid1.CurrentRow.Cells(0).Value.ToString
        lblname.Text = MetroGrid1.CurrentRow.Cells(1).Value.ToString

        'Profile
        Txt1.Text = MetroGrid1.CurrentRow.Cells(0).Value.ToString
        Txt2.Text = MetroGrid1.CurrentRow.Cells(1).Value.ToString
        Txt3.Text = MetroGrid1.CurrentRow.Cells(2).Value.ToString
        Txt4.Text = MetroGrid1.CurrentRow.Cells(3).Value.ToString
        Txt5.Text = MetroGrid1.CurrentRow.Cells(4).Value.ToString
        Txt6.Text = MetroGrid1.CurrentRow.Cells(5).Value.ToString
        Txt7.Text = MetroGrid1.CurrentRow.Cells(6).Value.ToString
        Txt8.Text = MetroGrid1.CurrentRow.Cells(7).Value.ToString
        Txt9.Text = MetroGrid1.CurrentRow.Cells(8).Value.ToString

        'Medical
        Medical.lblid.Text = MetroGrid1.CurrentRow.Cells(0).Value.ToString
        Medical.lblid.Text = MetroGrid1.CurrentRow.Cells(1).Value.ToString



        Loadpicture()


    End Sub
    'txtsearch
    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged

        ClearcboxGB2()
        CleartxtboxGB2()
        Showrecord()
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Msm.Theme = MetroFramework.MetroThemeStyle.Light
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Msm.Theme = MetroFramework.MetroThemeStyle.Dark

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        Styletransition()
    End Sub
    Public Sub Styletransition()
        Dim _color As String = MetroComboBox1.Text.Trim
        If CStr(_color) = "Black" Then
            Msm.Style = MetroFramework.MetroColorStyle.Black
        ElseIf CStr(_color) = "White" Then
            Msm.Style = MetroFramework.MetroColorStyle.White
        ElseIf CStr(_color) = "Silver" Then
            Msm.Style = MetroFramework.MetroColorStyle.Silver
        ElseIf CStr(_color) = "Blue" Then
            Msm.Style = MetroFramework.MetroColorStyle.Blue
        ElseIf CStr(_color) = "Green" Then
            Msm.Style = MetroFramework.MetroColorStyle.Green
        ElseIf CStr(_color) = "Lime" Then
            Msm.Style = MetroFramework.MetroColorStyle.Lime
        ElseIf CStr(_color) = "Teal" Then
            Msm.Style = MetroFramework.MetroColorStyle.Teal
        ElseIf CStr(_color) = "Orange" Then
            Msm.Style = MetroFramework.MetroColorStyle.Orange
        ElseIf CStr(_color) = "Brown" Then
            Msm.Style = MetroFramework.MetroColorStyle.Brown
        ElseIf CStr(_color) = "Pink" Then
            Msm.Style = MetroFramework.MetroColorStyle.Pink
        ElseIf CStr(_color) = "Magenta" Then
            Msm.Style = MetroFramework.MetroColorStyle.Magenta
        ElseIf CStr(_color) = "Purple" Then
            Msm.Style = MetroFramework.MetroColorStyle.Purple
        ElseIf CStr(_color) = "Red" Then
            Msm.Style = MetroFramework.MetroColorStyle.Red
        ElseIf CStr(_color) = "Yellow" Then
            Msm.Style = MetroFramework.MetroColorStyle.Yellow
        End If
    End Sub



    'export to excel


    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Dim _id As String = lblid.Text.Trim
        Dim _name As String = lblname.Text.Trim
        If _id = "" Then
            MetroMessageBox.Show(Me, vbCrLf & "Select an Employee to view the Medical Record.", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try

                Dim _medical As New Medical

                _medical.lblid.Text = _id
                _medical.lblname.Text = _name
                _medical.ShowDialog()
                _medical.Dispose()
            Catch ex As Exception
            End Try
        End If


    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        GridToExcel(MetroGrid1)


    End Sub


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


    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        'suppose your *finance tab* instance is TabPageFinance 
        If MetroTabControl1.SelectedTab Is MetroTabPage2 Then
            edu1.Clear()
            edu2.Clear()
            edu3.Clear()
            Dim _idnumber As String = lblid.Text.Trim
            Dim cnString As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\hris.accdb")
            cnString.Open()
            Dim sqlcmd As New OleDbCommand("SELECT DateHired, Eligibility, HighestEducation FROM emp_education WHERE idnum = '" & _idnumber & "'", cnString)

            reader = sqlcmd.ExecuteReader()
            reader.Read()
            If reader.HasRows Then
                edu1.Text = reader.Item("DateHired").ToString
                edu2.Text = reader.Item("Eligibility").ToString
                edu3.Text = reader.Item("HighestEducation").ToString


            End If
            cnString.Close()
        End If

        'or suppose *finance tab* index is 0 
        'If TabControl1.selectedindex = 0 Then
        '    'do stuff
        'End If


    End Sub

End Class