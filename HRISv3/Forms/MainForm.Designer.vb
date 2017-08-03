<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Msm As MetroFramework.Components.MetroStyleManager
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.mtreport = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Msm = New MetroFramework.Components.MetroStyleManager(Me.components)
        CType(Msm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Msm
        '
        Msm.Owner = Nothing
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.MetroPanel1)
        Me.GroupBox9.Controls.Add(Me.MetroLabel14)
        Me.GroupBox9.Controls.Add(Me.MetroLabel13)
        Me.GroupBox9.Controls.Add(Me.MetroComboBox1)
        Me.GroupBox9.Controls.Add(Me.Button4)
        Me.GroupBox9.Controls.Add(Me.Button5)
        Me.GroupBox9.Controls.Add(Me.Button6)
        Me.GroupBox9.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(542, 38)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(71, 332)
        Me.GroupBox9.TabIndex = 38
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Visible = False
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.TableLayoutPanel7)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(8, 215)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(57, 41)
        Me.MetroPanel1.TabIndex = 32
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.MetroButton4, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.MetroButton5, 0, 1)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(1, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(56, 39)
        Me.TableLayoutPanel7.TabIndex = 32
        '
        'MetroButton4
        '
        Me.MetroButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroButton4.Location = New System.Drawing.Point(3, 3)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(50, 13)
        Me.MetroButton4.TabIndex = 31
        Me.MetroButton4.Text = "Light"
        Me.MetroButton4.UseSelectable = True
        '
        'MetroButton5
        '
        Me.MetroButton5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroButton5.Location = New System.Drawing.Point(3, 22)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(50, 14)
        Me.MetroButton5.TabIndex = 32
        Me.MetroButton5.Text = "Dark"
        Me.MetroButton5.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(8, 279)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel14.TabIndex = 32
        Me.MetroLabel14.Text = "Styles :"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(5, 157)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(56, 57)
        Me.MetroLabel13.TabIndex = 32
        Me.MetroLabel13.Text = "Choose" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Theme :"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.MetroComboBox1.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 19
        Me.MetroComboBox1.Items.AddRange(New Object() {"Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(7, 299)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(56, 25)
        Me.MetroComboBox1.TabIndex = 31
        Me.MetroComboBox1.UseSelectable = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(643, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 35)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "&Update"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(721, 225)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 35)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "&Update"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(799, 225)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(58, 35)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "&Add"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'mtreport
        '
        Me.mtreport.ActiveControl = Nothing
        Me.mtreport.BackColor = System.Drawing.Color.Teal
        Me.mtreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtreport.Location = New System.Drawing.Point(77, 94)
        Me.mtreport.Name = "mtreport"
        Me.mtreport.Size = New System.Drawing.Size(403, 89)
        Me.mtreport.TabIndex = 37
        Me.mtreport.Text = "Reports"
        Me.mtreport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtreport.TileImage = Global.HRISv3.My.Resources.Resources.report_30px
        Me.mtreport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtreport.UseCustomBackColor = True
        Me.mtreport.UseSelectable = True
        Me.mtreport.UseTileImage = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.Color.Green
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile2.Location = New System.Drawing.Point(212, 185)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(133, 124)
        Me.MetroTile2.TabIndex = 36
        Me.MetroTile2.Text = "User"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile2.TileImage = Global.HRISv3.My.Resources.Resources.user
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile1.Location = New System.Drawing.Point(347, 185)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(133, 124)
        Me.MetroTile1.TabIndex = 35
        Me.MetroTile1.Text = "Maintenance"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile1.TileImage = Global.HRISv3.My.Resources.Resources.Maintenance_30px
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MetroTile4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile4.Location = New System.Drawing.Point(77, 185)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(133, 124)
        Me.MetroTile4.TabIndex = 34
        Me.MetroTile4.Text = "Employee"
        Me.MetroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile4.TileImage = Global.HRISv3.My.Resources.Resources.User_Groups_30px
        Me.MetroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile4.UseCustomBackColor = True
        Me.MetroTile4.UseSelectable = True
        Me.MetroTile4.UseTileImage = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImagePadding = New System.Windows.Forms.Padding(420, 0, 0, 0)
        Me.BackMaxSize = 60
        Me.ClientSize = New System.Drawing.Size(547, 374)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.mtreport)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MetroTile4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Human Resource Information System"
        CType(Msm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents mtreport As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
