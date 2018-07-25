Imports System.Data.OleDb
Imports MetroFramework
Public Class Form3
    Private Sub Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Copy_Of_dbo_pmis_users_fileBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HIS2DataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HIS2DataSet.Copy_Of_dbo_pmis_users_file' table. You can move, or remove it, as needed.
        Me.Copy_Of_dbo_pmis_users_fileTableAdapter.Fill(Me.HIS2DataSet.Copy_Of_dbo_pmis_users_file)
        'Copy_Of_dbo_pmis_users_fileBindingNavigator.Hide()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem.PerformClick()
        MsgBox("Updated")
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        BindingNavigatorDeleteItem.PerformClick()
        MsgBox("Deleted")
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MainForm.Show()
    End Sub

    Private Sub Copy_Of_dbo_pmis_users_fileDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Copy_Of_dbo_pmis_users_fileDataGridView.CellClick
        MetroLabel1.Text = Copy_Of_dbo_pmis_users_fileDataGridView.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        MetroLabel1.Text = Copy_Of_dbo_pmis_users_fileDataGridView.CurrentRow.Cells(0).Value.ToString
    End Sub
End Class