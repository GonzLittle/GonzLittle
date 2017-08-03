Imports System.Data.OleDb
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports MetroFramework
Public Class Editemployee

    'Change C: to the location of your database file.
    'connection With databasepassword
    'Dim connectwithpwd As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\myFolder\myAccess2007file.accdb;Jet OLEDB:Database Password = MyDbPassword"
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\User\Desktop\HRIS\HRIS\bin\Debug\hris.accdb"
    Dim Myconnection As OleDbConnection
    Dim dbda As OleDbDataAdapter
    Dim dbds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Public dbcmd As New OleDb.OleDbCommand
    Dim dr As OleDbDataReader
    Public result As Integer
    Public Sql As String


    Public Sub enablecontrols()

        'For Each ctrl As Control In TableLayoutPanel2.Controls
        '    If TypeOf ctrl Is ComboBox Then
        '        CType(ctrl, ComboBox).Enabled = True
        '    End If
        'Next
        txt1.Enabled = True
        txt2.Enabled = True
        Txt3.Enabled = True
        txt4.Enabled = True
        txt5.Enabled = True
        txt6.Enabled = True
        txt7.Enabled = True
        txt8.Enabled = True
        txt9.Enabled = True

    End Sub
    Public Sub disablecontrols()

        txt1.Enabled = False
        txt2.Enabled = False
        Txt3.Enabled = False
        txt4.Enabled = False
        txt5.Enabled = False
        txt6.Enabled = False
        txt7.Enabled = False
        txt8.Enabled = False
        txt9.Enabled = False
    End Sub


    Private Sub edit1_Click(sender As Object, e As EventArgs) Handles edit1.Click
        enablecontrols()
    End Sub

    Private Sub Editemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disablecontrols()

    End Sub
End Class


