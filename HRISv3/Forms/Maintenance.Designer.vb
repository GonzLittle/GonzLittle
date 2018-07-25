<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mtndept = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mtndeptupdate = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mtnupdate = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtdeptcode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtdeptcode2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtndept
        '
        Me.mtndept.DropDownHeight = 400
        Me.mtndept.DropDownWidth = 400
        Me.mtndept.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mtndept.FormattingEnabled = True
        Me.mtndept.IntegralHeight = False
        Me.mtndept.ItemHeight = 19
        Me.mtndept.Location = New System.Drawing.Point(141, 89)
        Me.mtndept.Name = "mtndept"
        Me.mtndept.Size = New System.Drawing.Size(316, 25)
        Me.mtndept.TabIndex = 1
        Me.mtndept.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(47, 95)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Department : "
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(473, 95)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Update to : "
        '
        'mtndeptupdate
        '
        Me.mtndeptupdate.DropDownHeight = 400
        Me.mtndeptupdate.DropDownWidth = 500
        Me.mtndeptupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.mtndeptupdate.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mtndeptupdate.FormattingEnabled = True
        Me.mtndeptupdate.IntegralHeight = False
        Me.mtndeptupdate.ItemHeight = 19
        Me.mtndeptupdate.Location = New System.Drawing.Point(558, 89)
        Me.mtndeptupdate.Name = "mtndeptupdate"
        Me.mtndeptupdate.Size = New System.Drawing.Size(316, 25)
        Me.mtndeptupdate.TabIndex = 3
        Me.mtndeptupdate.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(141, 126)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "MetroLabel3"
        '
        'mtnupdate
        '
        Me.mtnupdate.AutoSize = True
        Me.mtnupdate.Location = New System.Drawing.Point(558, 126)
        Me.mtnupdate.Name = "mtnupdate"
        Me.mtnupdate.Size = New System.Drawing.Size(83, 19)
        Me.mtnupdate.TabIndex = 6
        Me.mtnupdate.Text = "MetroLabel4"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(738, 165)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(62, 36)
        Me.MetroButton1.TabIndex = 8
        Me.MetroButton1.Text = "Update"
        Me.MetroButton1.UseSelectable = True
        '
        'txtdeptcode
        '
        Me.txtdeptcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdeptcode.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtdeptcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdeptcode.HintForeColor = System.Drawing.Color.Empty
        Me.txtdeptcode.HintText = ""
        Me.txtdeptcode.isPassword = False
        Me.txtdeptcode.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtdeptcode.LineIdleColor = System.Drawing.Color.Gray
        Me.txtdeptcode.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtdeptcode.LineThickness = 3
        Me.txtdeptcode.Location = New System.Drawing.Point(558, 149)
        Me.txtdeptcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdeptcode.Name = "txtdeptcode"
        Me.txtdeptcode.Size = New System.Drawing.Size(104, 33)
        Me.txtdeptcode.TabIndex = 9
        Me.txtdeptcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtdeptcode2
        '
        Me.txtdeptcode2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdeptcode2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtdeptcode2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdeptcode2.HintForeColor = System.Drawing.Color.Empty
        Me.txtdeptcode2.HintText = ""
        Me.txtdeptcode2.isPassword = False
        Me.txtdeptcode2.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtdeptcode2.LineIdleColor = System.Drawing.Color.Gray
        Me.txtdeptcode2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtdeptcode2.LineThickness = 3
        Me.txtdeptcode2.Location = New System.Drawing.Point(141, 149)
        Me.txtdeptcode2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdeptcode2.Name = "txtdeptcode2"
        Me.txtdeptcode2.Size = New System.Drawing.Size(104, 33)
        Me.txtdeptcode2.TabIndex = 10
        Me.txtdeptcode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeColumns = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver
        Me.MetroGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.MetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MetroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle15
        Me.MetroGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(20, 202)
        Me.MetroGrid1.MultiSelect = False
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(854, 503)
        Me.MetroGrid1.TabIndex = 11
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(806, 165)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(62, 36)
        Me.MetroButton2.TabIndex = 12
        Me.MetroButton2.Text = "To Excel"
        Me.MetroButton2.UseSelectable = True
        '
        'Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 728)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.txtdeptcode2)
        Me.Controls.Add(Me.txtdeptcode)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.mtnupdate)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.mtndeptupdate)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.mtndept)
        Me.Name = "Maintenance"
        Me.Text = "Maintenance"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtndept As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtndeptupdate As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtnupdate As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtdeptcode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtdeptcode2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
