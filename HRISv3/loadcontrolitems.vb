Imports System.Data.OleDb

Module loadcontrolitems
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\User\Desktop\HRIS\HRIS\bin\Debug\hris.accdb"
    Public Myconnection As OleDbConnection
    Public dbda As OleDbDataAdapter
    Public dbds As DataSet
    Public tables As DataTableCollection
    Public source As New BindingSource
    Public command As OleDbCommand
    Public reader As OleDbDataReader
    Public result As Integer
    Public query As String

    'REPORT
#Region "Form Report"
    'initialize datagrid
    Public Sub InitializeDataGridView()

        ' Initialize basic DataGridView properties.
        Report.MetroGrid1.Dock = DockStyle.Fill
        Report.MetroGrid1.BackgroundColor = Color.LightGray

        Report.MetroGrid1.AutoSizeRowsMode =
        DataGridViewAutoSizeRowsMode.AllCells

        ' Resize the master DataGridView columns to fit the newly loaded data.
        Report.MetroGrid1.AutoResizeRows()

        ' Set property values appropriate for read-only display and 
        ' limited interactivity. 
        Report.MetroGrid1.AllowUserToAddRows = False
        Report.MetroGrid1.AllowUserToDeleteRows = False
        Report.MetroGrid1.AllowUserToOrderColumns = False

        Report.MetroGrid1.ReadOnly = True
        Report.MetroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Report.MetroGrid1.MultiSelect = True
        Report.MetroGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells

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
        Report.MetroGrid1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

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
#End Region
    'EDITEMPLOYEE
#Region "Form EditEmployee"


#End Region

End Module
