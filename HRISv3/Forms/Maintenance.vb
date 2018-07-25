Imports System.Data.OleDb
Imports MetroFramework
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Maintenance
    Private Sub Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillofficeEDIT()
        loadgrid()
    End Sub
    Public Sub FillofficeEDIT()
        'Dim myconnection As New OleDbConnection
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        Dim query As String
        Dim command As OleDbCommand
        Dim reader As OleDbDataReader
        query = "select Distinct dept_name from dbo_department Order by dept_name Asc"
        command = New OleDbCommand(query, Myconnection)
        Myconnection.Close()
        Myconnection.Open()
        reader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                mtndept.Items.Add(reader("dept_name"))
                mtndeptupdate.Items.Add(reader("dept_name"))
            End While
        End If
        Myconnection.Close()
    End Sub

    Private Sub mtndept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mtndept.SelectedIndexChanged
        MetroLabel3.Text = mtndept.Text.Trim
        displaydeptcode2()
    End Sub

    Private Sub mtndeptupdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mtndeptupdate.SelectedIndexChanged
        mtnupdate.Text = mtndeptupdate.Text.Trim
        displaydeptcode()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim InsertQuery As String
            If Myconnection.State = ConnectionState.Open Then
                Myconnection.Close()
            Else
                Myconnection.Open()
                'InsertQuery = ("UPDATE dbo_department set dept_code = @t2 where dept_name= '" & mtnupdate.Text & "' ")
                InsertQuery = ("Update dbo_personal Set dbo_personal.dept_code=@t1 WHERE dbo_personal.dept_code = @t2")
                Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, Myconnection)
                cmd.Parameters.AddWithValue("@t1", txtdeptcode.Text.Trim)
                cmd.Parameters.AddWithValue("@t2", txtdeptcode2.Text.Trim)

                cmd.ExecuteNonQuery()
                MetroMessageBox.Show(Me, vbCrLf & "Record Successfully Updated." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Question)
                loadgrid()

            End If
            Myconnection.Close()
        Catch EX As Exception
            MetroMessageBox.Show(Me, vbCrLf & "Error Update. " & EX.ToString & vbCrLf & vbCrLf & vbCrLf, "Data Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Sub displaydeptcode()
        Try
            Dim _deptname As String = mtndeptupdate.Text.Trim
            Dim sd As New OleDbDataAdapter("Select dept_code from dbo_department where dept_name = '" & _deptname & "'", connString)
            Dim dt As New DataTable
            sd.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtdeptcode.Text = dt.Rows(0).Item("dept_code").ToString()

            End If
            dt.Dispose()

        Catch ex As Exception
            'MetroMessageBox.Show(Report, vbCrLf & "Record Failed to initialize." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub
    Public Sub displaydeptcode2()
        Try
            Dim _deptname As String = mtndept.Text.Trim
            Dim sd As New OleDbDataAdapter("Select dept_code from dbo_department where dept_name = '" & _deptname & "'", connString)
            Dim dt As New DataTable
            sd.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtdeptcode2.Text = dt.Rows(0).Item("dept_code").ToString()

            End If
            dt.Dispose()

        Catch ex As Exception
            'MetroMessageBox.Show(Report, vbCrLf & "Record Failed to initialize." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub
    Public Sub loadgrid()
        Try
            Dim dba As New OleDbDataAdapter("SELECT Distinct dbo_department.dept_code, dbo_department.dept_name from dbo_department inner join dbo_personal on dbo_department.dept_code=dbo_personal.dept_code order by dbo_department.dept_name asc", Myconnection)
            Dim DtSet As New DataSet
            dba.Fill(DtSet)
            MetroGrid1.DataSource = DtSet.Tables(0).DefaultView
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Maintenance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MainForm.Show()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
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
End Class