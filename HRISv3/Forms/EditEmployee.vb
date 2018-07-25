Imports System.Data.OleDb
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports MetroFramework
Public Class Editemployee
    Dim dr As OleDbDataReader
    'form load
    Private Sub Editemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MetroTabControl1.SelectedTab = MetroTabPage1
        disablecontrols()
        Displayprofile()
        'Displayprofile()
        'displayedu()
        'displaypayroll()
        'displaymedical()
    End Sub

    'display records
    Public Sub Displayprofile()
        Try
            Dim _persid As String = txt1.Text.Trim
            Dim sd As New OleDbDataAdapter("Select full_name, sex, birthdate, employment_status, app_status from dbo_personal where pers_id = '" & _persid & "'", connString)
            Dim dt As New DataTable
            sd.Fill(dt)
            If dt.Rows.Count > 0 Then
                txt2.Text = dt.Rows(0).Item("full_name").ToString()
                Dim _sex As String = dt.Rows(0).Item("Sex").ToString()
                If _sex = "1" Then
                    Txt3.Text = "MALE"
                Else
                    Txt3.Text = "FEMALE"
                End If
                txt4.Text = dt.Rows(0).Item("Birthdate").ToString()

                'txt5.Text = dt.Rows(0).Item("Address").ToString()
                'txt6.Text = dt.Rows(0).Item("Position").ToString()
                'txt7.Text = dt.Rows(0).Item("Office").ToString()
                txt8.Text = dt.Rows(0).Item("App_Status").ToString()
                txt9.Text = dt.Rows(0).Item("Employment_Status").ToString()


            End If
            dt.Dispose()

        Catch ex As Exception
            'MetroMessageBox.Show(Report, vbCrLf & "Record Failed To initialize." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series Of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub

    Public Sub displayedu()
        Try
            Dim _persid As String = txt1.Text.Trim
            Dim sdedu As New OleDbDataAdapter("Select * from emp_education where IDNum = '" & _persid & "'", connString)
            Dim dtedu As New DataTable
            sdedu.Fill(dtedu)
            If dtedu.Rows.Count > 0 Then
                edu1.Text = dtedu.Rows(0).Item("Eligibility").ToString()
                edu2.Text = dtedu.Rows(0).Item("HighestEducation").ToString()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub displaypayroll()
        Try
            Dim _persid As String = txt1.Text.Trim
            Dim _appstatus As String = Label23.Text.Trim
            If _appstatus = "CASUAL" Then
                pay1.Text = "9,980.96"
                pay2.Text = "119,771.52"
                pay3.Text = "1"
                pay4.Text = "1"
            ElseIf _appstatus = "PERMANENT" Then
                Dim sdpayroll As New OleDbDataAdapter("Select * from Emp_Salary where IDNo = '" & _persid & "'", connString)
                Dim dtpayroll As New DataTable
                sdpayroll.Fill(dtpayroll)
                If dtpayroll.Rows.Count > 0 Then
                    pay1.Text = dtpayroll.Rows(0).Item("monthly_salary").ToString()
                    pay2.Text = dtpayroll.Rows(0).Item("annual_salary").ToString()
                    pay3.Text = dtpayroll.Rows(0).Item("salary_grade").ToString()
                    pay4.Text = dtpayroll.Rows(0).Item("step").ToString()
                End If
            Else
                pay1.Text = "7,700.00"
                pay2.Text = "92,400.00"
                pay3.Text = "n/a"
                pay4.Text = "n/a"

            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub displaymedical()
        Try

            Dim _persid As String = txt1.Text.Trim
            Dim cnString As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\pmis_server\IDPGLUdb2013\id_pglu.mdb")
            cnString.Open()
            Dim sqlcmd As New OleDbCommand("SELECT * FROM dbo_idpers WHERE pers_id = '" & _persid & "'", cnString)
            dr = sqlcmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                med1.Text = dr.Item("blood").ToString
                med2.Text = dr.Item("allergies").ToString
                med3.Text = dr.Item("medical_condition").ToString
                med4.Text = dr.Item("person").ToString
                med5.Text = dr.Item("address").ToString
                med6.Text = dr.Item("c_telno").ToString
            End If
            cnString.Close()
        Catch ex As Exception
        End Try
    End Sub

    'edit
    Private Sub MetroTabPage1_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroTabPage1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ctxmenu.Show(Me, e.Location)
        End If
    End Sub
    Private Sub MetroTabPage3_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroTabPage3.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ctxmenu.Show(Me, e.Location)
        End If
    End Sub
    Private Sub MetroTabPage4_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroTabPage4.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ctxmenu.Show(Me, e.Location)
        End If
    End Sub
    Private Sub MetroTabPage2_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroTabPage2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ctxmenu.Show(Me, e.Location)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim _edittoolstrip As String = EditToolStripMenuItem.Text.Trim
        If _edittoolstrip = "Edit" Then
            enablecontrols()
            EditToolStripMenuItem.Text = "Lock Controls"
        Else
            disablecontrols()
            EditToolStripMenuItem.Text = "Edit"
        End If

    End Sub

    'úpdate
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Try
            Dim InsertQuery As String
            If Myconnection.State = ConnectionState.Open Then
                Myconnection.Close()
            Else
                Myconnection.Open()
                InsertQuery = ("UPDATE employee set fullname = @t2, gender = @t3, birthdate = @t4, address = @t5, [position] = @t6, office = @t7, app_status = @t8, emp_status = @t9 where idnumber= '" & txt1.Text & "' ")
                Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, Myconnection)
                cmd.Parameters.AddWithValue("@t2", txt2.Text)
                cmd.Parameters.AddWithValue("@t3", Txt3.Text)
                cmd.Parameters.AddWithValue("@t4", txt4.Text)
                cmd.Parameters.AddWithValue("@t5", txt5.Text)
                cmd.Parameters.AddWithValue("@t6", txt6.Text)
                cmd.Parameters.AddWithValue("@t7", txt7.Text)
                cmd.Parameters.AddWithValue("@t8", txt8.Text)
                cmd.Parameters.AddWithValue("@t9", txt9.Text)

                cmd.ExecuteNonQuery()
                MetroMessageBox.Show(Me, vbCrLf & "Record Successfully Updated." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Me.Close()
            End If
            Myconnection.Close()
        Catch EX As Exception
            MetroMessageBox.Show(Me, vbCrLf & "Error Update. " & EX.ToString & vbCrLf & vbCrLf & vbCrLf, "Data Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        Label22.Text = MetroTabControl1.SelectedTab.Text.Trim
    End Sub

    Public Sub datarebind()
        Try
            Dim searchname As String = txt1.Text.Trim
            'Dim dba As New OleDbDataAdapter("SELECT employee.idnumber, employee.fullname, emp_education.eligibility, emp_education.highesteducation FROM employee INNER JOIN emp_education ON employee.idnumber=emp_education.idnum Where employee.IDNumber Like '%" & searchname & "%' or employee.FullName Like '%" & searchname & "%' or employee.Address Like '%" & searchname & "%' order by employee.FullName asc", Myconnection)
            'Dim dba As New OleDbDataAdapter("SELECT employee.IDNumber, employee.Fullname, Employee.Gender, employee.Birthdate, employee.Address, employee.Position, employee.Office, employee.App_status, employee.Emp_status emp_education.Datehired FROM employee INNER JOIN emp_education ON employee.idnumber=emp_education.idnum Where employee.IDNumber Like '%" & searchname & "%' or employee.FullName Like '%" & searchname & "%' or employee.Address Like '%" & searchname & "%' order by employee.FullName asc", Myconnection)
            Dim dba As New OleDbDataAdapter("SELECT IDNumbe, FullName, Address, [Position], App_status from employee Where IDNumber = '" & searchname & "' order by FullName asc", Myconnection)
            Dim dbset As New DataSet
            dba.Fill(dbset)
            Report.MetroGrid1.DataSource = dbset.Tables(0).DefaultView
            'Label20.Text = DataGridView1.Rows.Count
            Report.txtcount.Text = CType(Report.MetroGrid1.Rows.Count, String)
        Catch ex As Exception
            MetroMessageBox.Show(Me, vbCrLf & "Error Retrieve. " & ex.ToString & vbCrLf & vbCrLf & vbCrLf, "Human Resource Information System" & vbCrLf & "No Data retrieved", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub mcb1_CheckedChanged(sender As Object, e As EventArgs) Handles mcb1.CheckedChanged
        If mcb1.Checked = True Then
            Displayprofile()
        Else
            txt2.Clear()
            Txt3.SelectedIndex = -1
            txt4.ShowCheckBox = False
            txt5.Clear()
            txt6.Clear()
            txt7.SelectedIndex = -1
            txt8.SelectedIndex = -1
            txt9.SelectedIndex = -1
        End If
    End Sub

    Private Sub mcb2_CheckedChanged(sender As Object, e As EventArgs) Handles mcb2.CheckedChanged
        If mcb2.Checked = True Then
            displayedu()
        Else
            edu1.Clear()
            edu2.Clear()
        End If
    End Sub

    Private Sub mcb3_CheckedChanged(sender As Object, e As EventArgs) Handles mcb3.CheckedChanged
        If mcb3.Checked = True Then
            displaypayroll()
        Else
            pay1.Clear()
            pay2.Clear()
            pay3.Clear()
            pay4.Clear()
        End If
    End Sub

    Private Sub mcb4_CheckedChanged(sender As Object, e As EventArgs) Handles mcb4.CheckedChanged
        If mcb4.Checked = True Then
            displaymedical()
        Else
            med1.Clear()
            med2.Clear()
            med3.Clear()
            med4.Clear()
            med5.Clear()
            med6.Clear()
        End If
    End Sub

End Class


