Imports System.Data.OleDb
Imports System.Data
Imports MetroFramework

Public Class AddNewRecord

    Private Sub txt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
            MetroMessageBox.Show(Me, vbCrLf & "ID must be numerical.!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt1.Focus()
        End If
    End Sub

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

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Myconnection = New OleDbConnection(connString)
            Dim InsertQuery As String
            If Myconnection.State = ConnectionState.Open Then
                Myconnection.Close()
            Else
                Myconnection.Open()
                'InsertQuery = ("insert into employee (idnumber, fullname, gender, birthdate, address, [position], office, app_status, emp_status) values (@t1, @t2, @t3, @t1, @t4, @t5, @t6, @t7, @t8, @t9")
                InsertQuery = ("insert into employee (idnumber, fullname, gender, birthdate, address, [position], office, app_status, emp_status) values (@t1, @t2, @t3, @t4, @t5, @t6, @t7, @t8, @t9)")
                Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, Myconnection)
                cmd.Parameters.Add(New OleDbParameter("@t1", OleDbType.VarChar, 10, "idnumber"))
                cmd.Parameters.Add(New OleDbParameter("@t2", OleDbType.VarChar, 100, "fullname"))
                cmd.Parameters.Add(New OleDbParameter("@t3", OleDbType.VarChar, 10, "gender"))
                cmd.Parameters.Add(New OleDbParameter("@t4", OleDbType.VarChar, 50, "birthdate"))
                cmd.Parameters.Add(New OleDbParameter("@t5", OleDbType.VarChar, 100, "address"))
                cmd.Parameters.Add(New OleDbParameter("@t6", OleDbType.VarChar, 50, "[position]"))
                cmd.Parameters.Add(New OleDbParameter("@t7", OleDbType.VarChar, 100, "office"))
                cmd.Parameters.Add(New OleDbParameter("@t8", OleDbType.VarChar, 20, "app_status"))
                cmd.Parameters.Add(New OleDbParameter("@t9", OleDbType.VarChar, 20, "emp_status"))


                cmd.Parameters("@t1").Value = txt1.Text.Trim
                cmd.Parameters("@t2").Value = txt2.Text.Trim
                cmd.Parameters("@t3").Value = Txt3.Text.Trim
                cmd.Parameters("@t4").Value = txt4.Text.Trim
                cmd.Parameters("@t5").Value = txt5.Text.Trim
                cmd.Parameters("@t6").Value = txt6.Text.Trim
                cmd.Parameters("@t7").Value = txt7.Text.Trim
                cmd.Parameters("@t8").Value = txt8.Text.Trim
                cmd.Parameters("@t9").Value = txt9.Text.Trim

                cmd.ExecuteReader()
                MetroMessageBox.Show(Me, vbCrLf & "Record Saved." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Me.Close()
                Report.Show()

            End If
            Myconnection.Close()
        Catch ex As Exception
            MetroMessageBox.Show(Me, vbCrLf & "Error inserting record!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try
    End Sub
End Class