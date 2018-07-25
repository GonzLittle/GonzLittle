Imports System.Data.OleDb
Module loadcomboboxes
    'fill office ADDEMPLOYEE
    Public Sub FillofficeADD()

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
                AddNewRecord.txt7.Items.Add(reader("dept_name"))
            End While
        End If
        Myconnection.Close()
    End Sub

    'fill app status ADDEMPLOYEE
    Public Sub FillappstatusADD()
        Try
            'Dim myconnection As New OleDbConnection
            Myconnection = New OleDbConnection
            Myconnection.ConnectionString = connString

            Dim query As String
            Dim command As OleDbCommand
            Dim reader As OleDbDataReader
            Myconnection.Close()
            Myconnection.Open()
            query = "select Distinct description from dbo_appstatus Order by description Asc"
            command = New OleDbCommand(query, Myconnection)
            reader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    AddNewRecord.txt8.Items.Add(reader("description"))
                End While
            End If
            Myconnection.Close()
        Catch ex As Exception
        End Try
    End Sub

    'fill office REPORT
    Public Sub FillofficeREPORT()
        Try
            'Dim myconnection As New OleDbConnection
            Myconnection = New OleDbConnection
            Myconnection.ConnectionString = connString
            query = "select Distinct dept_name from dbo_department Order by dept_name Asc"
            command = New OleDbCommand(query, Myconnection)
            Myconnection.Close()
            Myconnection.Open()
            reader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Report.repdept.Items.Add(reader("dept_name"))
                End While
            End If
            Myconnection.Close()
        Catch ex As Exception
        End Try
    End Sub
    'fill app status Report
    Public Sub FillappstatusREPORT()
        Try
            'Dim myconnection As New OleDbConnection
            Myconnection = New OleDbConnection
            Myconnection.ConnectionString = connString
            Myconnection.Open()
            Dim query As String
            Dim command As OleDbCommand
            Dim reader As OleDbDataReader
            Myconnection.Close()
            Myconnection.Open()
            query = "select Distinct description from dbo_appstatus Order by description Asc"
            command = New OleDbCommand(query, Myconnection)
            reader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Report.repapp.Items.Add(reader("description"))
                End While
            End If
            Myconnection.Close()
        Catch ex As Exception
        End Try
    End Sub
    'fill office EDITEMPLOYEE
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
                Editemployee.txt7.Items.Add(reader("dept_name"))
            End While
        End If
        Myconnection.Close()
    End Sub
    'fill app status EDITEMPLOYEE
    Public Sub FillappstatusEDIT()
        Try
            'Dim myconnection As New OleDbConnection
            Myconnection = New OleDbConnection
            Myconnection.ConnectionString = connString
            Dim query As String
            Dim command As OleDbCommand
            Dim reader As OleDbDataReader
            Myconnection.Close()
            Myconnection.Open()
            query = "select Distinct description from dbo_appstatus Order by description Asc"
            command = New OleDbCommand(query, Myconnection)
            reader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Editemployee.txt8.Items.Add(reader("description"))
                End While
            End If
            Myconnection.Close()
        Catch ex As Exception
        End Try
    End Sub
    'Permanent
    'Casual
    'Job Order
    'Co-terminous
    'Contractual
    'Sef
    'iTax
    'Volunteer
    'Consultant
    'Temporary
    'Elected
    'OJT
    'Day Care
End Module
