Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports MetroFramework

Public Class Medical
    'Change C: to the location of your database file.
    'connection With databasepassword
    'Dim connectwithpwd As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\myFolder\myAccess2007file.accdb;Jet OLEDB:Database Password = MyDbPassword"

    Public Myconnection As OleDbConnection
    Dim dbda As OleDbDataAdapter
    Dim dbds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource

    Dim dr As OleDbDataReader
    Public result As Integer
    Public Sql As String
    Private Sub Medical_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Showrecord()
        Txt1.Focus()

    End Sub

    Private Sub Medical_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Me.Dispose()
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Showrecord()

        Dim _idnumber As String = lblid.Text.Trim
        Dim cnString As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\pmis_server\IDPGLUdb2013\id_pglu.mdb")
        cnString.Open()
        Dim sqlcmd As New OleDbCommand("SELECT * FROM dbo_idpers WHERE pers_id = '" & _idnumber & "'", cnString)

        dr = sqlcmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            Txt1.Text = dr.Item("tin").ToString
            Txt2.Text = dr.Item("gsis_umid_crn").ToString
            Txt3.Text = dr.Item("gsis_id").ToString
            Txt4.Text = dr.Item("pagibig_rdn").ToString
            Txt5.Text = dr.Item("philhealth").ToString
            txt6.Text = dr.Item("allergies").ToString
            txt7.Text = dr.Item("medical_condition").ToString
            txt8.Text = dr.Item("person").ToString
            txt9.Text = dr.Item("address").ToString
            txt10.Text = dr.Item("c_telno").ToString


        End If
        cnString.Close()


    End Sub

End Class