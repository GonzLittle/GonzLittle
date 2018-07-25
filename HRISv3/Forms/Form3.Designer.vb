<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.HIS2DataSet = New HRISv3.HIS2DataSet()
        Me.Copy_Of_dbo_pmis_users_fileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Copy_Of_dbo_pmis_users_fileTableAdapter = New HRISv3.HIS2DataSetTableAdapters.Copy_Of_dbo_pmis_users_fileTableAdapter()
        Me.TableAdapterManager = New HRISv3.HIS2DataSetTableAdapters.TableAdapterManager()
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Copy_Of_dbo_pmis_users_fileDataGridView = New System.Windows.Forms.DataGridView()
        Me.pers_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        CType(Me.HIS2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copy_Of_dbo_pmis_users_fileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copy_Of_dbo_pmis_users_fileBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.SuspendLayout()
        CType(Me.Copy_Of_dbo_pmis_users_fileDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HIS2DataSet
        '
        Me.HIS2DataSet.DataSetName = "HIS2DataSet"
        Me.HIS2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Copy_Of_dbo_pmis_users_fileBindingSource
        '
        Me.Copy_Of_dbo_pmis_users_fileBindingSource.DataMember = "Copy Of dbo_pmis_users_file"
        Me.Copy_Of_dbo_pmis_users_fileBindingSource.DataSource = Me.HIS2DataSet
        '
        'Copy_Of_dbo_pmis_users_fileTableAdapter
        '
        Me.Copy_Of_dbo_pmis_users_fileTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.A_tableprelimTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Copy_Of_dbo_pmis_users_fileTableAdapter = Me.Copy_Of_dbo_pmis_users_fileTableAdapter
        Me.TableAdapterManager.dbo_appstatusTableAdapter = Nothing
        Me.TableAdapterManager.dbo_barangayTableAdapter = Nothing
        Me.TableAdapterManager.dbo_coursesTableAdapter = Nothing
        Me.TableAdapterManager.dbo_departmentTableAdapter = Nothing
        Me.TableAdapterManager.dbo_educational_levelTableAdapter = Nothing
        Me.TableAdapterManager.dbo_eligibilityTableAdapter = Nothing
        Me.TableAdapterManager.dbo_employee_educational_backgrndTableAdapter = Nothing
        Me.TableAdapterManager.dbo_employee_eligibilityTableAdapter = Nothing
        Me.TableAdapterManager.dbo_municipalityTableAdapter = Nothing
        Me.TableAdapterManager.dbo_personalTableAdapter = Nothing
        Me.TableAdapterManager.dbo_pmis_users_fileTableAdapter = Nothing
        Me.TableAdapterManager.dbo_positionTableAdapter = Nothing
        Me.TableAdapterManager.dbo_provinceTableAdapter = Nothing
        Me.TableAdapterManager.dbo_schoolsTableAdapter = Nothing
        Me.TableAdapterManager.previous_deptTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HRISv3.HIS2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Copy_Of_dbo_pmis_users_fileBindingNavigator
        '
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.BindingSource = Me.Copy_Of_dbo_pmis_users_fileBindingSource
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem})
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.Location = New System.Drawing.Point(20, 60)
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.Name = "Copy_Of_dbo_pmis_users_fileBindingNavigator"
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.Size = New System.Drawing.Size(523, 25)
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.TabIndex = 0
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem
        '
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem.Image = CType(resources.GetObject("Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem.Name = "Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem"
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem.Text = "Save Data"
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem.Visible = False
        '
        'Copy_Of_dbo_pmis_users_fileDataGridView
        '
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.AllowUserToAddRows = False
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.AllowUserToDeleteRows = False
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.AutoGenerateColumns = False
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pers_id, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.DataSource = Me.Copy_Of_dbo_pmis_users_fileBindingSource
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.Location = New System.Drawing.Point(20, 85)
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.Name = "Copy_Of_dbo_pmis_users_fileDataGridView"
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.Size = New System.Drawing.Size(523, 367)
        Me.Copy_Of_dbo_pmis_users_fileDataGridView.TabIndex = 1
        '
        'pers_id
        '
        Me.pers_id.DataPropertyName = "pers_id"
        Me.pers_id.HeaderText = "pers_id"
        Me.pers_id.Name = "pers_id"
        Me.pers_id.Width = 66
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fullname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fullname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 71
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Save"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(115, 16)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(45, 40)
        Me.BunifuThinButton21.TabIndex = 2
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Delete"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(166, 16)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(45, 40)
        Me.BunifuThinButton22.TabIndex = 2
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(267, 19)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "SFSADF"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 472)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Copy_Of_dbo_pmis_users_fileDataGridView)
        Me.Controls.Add(Me.Copy_Of_dbo_pmis_users_fileBindingNavigator)
        Me.Name = "Form3"
        Me.Text = "Edit"
        CType(Me.HIS2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copy_Of_dbo_pmis_users_fileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copy_Of_dbo_pmis_users_fileBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.ResumeLayout(False)
        Me.Copy_Of_dbo_pmis_users_fileBindingNavigator.PerformLayout()
        CType(Me.Copy_Of_dbo_pmis_users_fileDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HIS2DataSet As HIS2DataSet
    Friend WithEvents Copy_Of_dbo_pmis_users_fileBindingSource As BindingSource
    Friend WithEvents Copy_Of_dbo_pmis_users_fileTableAdapter As HIS2DataSetTableAdapters.Copy_Of_dbo_pmis_users_fileTableAdapter
    Friend WithEvents TableAdapterManager As HIS2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Copy_Of_dbo_pmis_users_fileBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Copy_Of_dbo_pmis_users_fileBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Copy_Of_dbo_pmis_users_fileDataGridView As DataGridView
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pers_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
