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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mtreport = New MetroFramework.Controls.MetroTile()
        Me.mtuser = New MetroFramework.Controls.MetroTile()
        Me.mtmaintenance = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BunifuTileButton3 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton4 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton5 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton2 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Msm = New MetroFramework.Components.MetroStyleManager(Me.components)
        CType(Msm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.GroupBox9.Location = New System.Drawing.Point(5, 395)
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
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = Global.HRISv3.My.Resources.Resources.I_LOVE_LA_UNION_LOGO
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(5, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'mtreport
        '
        Me.mtreport.ActiveControl = Nothing
        Me.mtreport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtreport.BackColor = System.Drawing.Color.Teal
        Me.mtreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtreport.Location = New System.Drawing.Point(557, 316)
        Me.mtreport.Name = "mtreport"
        Me.mtreport.Size = New System.Drawing.Size(120, 120)
        Me.mtreport.TabIndex = 37
        Me.mtreport.Text = "HRIS"
        Me.mtreport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtreport.TileImage = CType(resources.GetObject("mtreport.TileImage"), System.Drawing.Image)
        Me.mtreport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtreport.UseCustomBackColor = True
        Me.mtreport.UseSelectable = True
        Me.mtreport.UseTileImage = True
        '
        'mtuser
        '
        Me.mtuser.ActiveControl = Nothing
        Me.mtuser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtuser.BackColor = System.Drawing.Color.SeaGreen
        Me.mtuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtuser.Location = New System.Drawing.Point(680, 316)
        Me.mtuser.Name = "mtuser"
        Me.mtuser.Size = New System.Drawing.Size(120, 120)
        Me.mtuser.TabIndex = 36
        Me.mtuser.Text = "ID Manager"
        Me.mtuser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtuser.TileImage = CType(resources.GetObject("mtuser.TileImage"), System.Drawing.Image)
        Me.mtuser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtuser.UseCustomBackColor = True
        Me.mtuser.UseSelectable = True
        Me.mtuser.UseTileImage = True
        '
        'mtmaintenance
        '
        Me.mtmaintenance.ActiveControl = Nothing
        Me.mtmaintenance.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtmaintenance.BackColor = System.Drawing.Color.DodgerBlue
        Me.mtmaintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtmaintenance.Location = New System.Drawing.Point(803, 316)
        Me.mtmaintenance.Name = "mtmaintenance"
        Me.mtmaintenance.Size = New System.Drawing.Size(120, 120)
        Me.mtmaintenance.TabIndex = 35
        Me.mtmaintenance.Text = "Maintenance"
        Me.mtmaintenance.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtmaintenance.TileImage = CType(resources.GetObject("mtmaintenance.TileImage"), System.Drawing.Image)
        Me.mtmaintenance.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtmaintenance.UseCustomBackColor = True
        Me.mtmaintenance.UseSelectable = True
        Me.mtmaintenance.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.MetroTile1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile1.Location = New System.Drawing.Point(434, 316)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(120, 120)
        Me.MetroTile1.TabIndex = 40
        Me.MetroTile1.Text = "HR DocTrack"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile1.TileImage = CType(resources.GetObject("MetroTile1.TileImage"), System.Drawing.Image)
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuTileButton3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuTileButton4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuTileButton5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuTileButton1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuTileButton2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1063, 658)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 68)
        Me.TableLayoutPanel1.TabIndex = 43
        '
        'BunifuTileButton3
        '
        Me.BunifuTileButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTileButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTileButton3.color = System.Drawing.Color.Transparent
        Me.BunifuTileButton3.colorActive = System.Drawing.Color.LightGray
        Me.BunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuTileButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BunifuTileButton3.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuTileButton3.Image = CType(resources.GetObject("BunifuTileButton3.Image"), System.Drawing.Image)
        Me.BunifuTileButton3.ImagePosition = 5
        Me.BunifuTileButton3.ImageZoom = 60
        Me.BunifuTileButton3.LabelPosition = 18
        Me.BunifuTileButton3.LabelText = "PS6"
        Me.BunifuTileButton3.Location = New System.Drawing.Point(124, 5)
        Me.BunifuTileButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuTileButton3.Name = "BunifuTileButton3"
        Me.BunifuTileButton3.Size = New System.Drawing.Size(52, 58)
        Me.BunifuTileButton3.TabIndex = 45
        '
        'BunifuTileButton4
        '
        Me.BunifuTileButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTileButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTileButton4.color = System.Drawing.Color.Transparent
        Me.BunifuTileButton4.colorActive = System.Drawing.Color.LightGray
        Me.BunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuTileButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BunifuTileButton4.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuTileButton4.Image = CType(resources.GetObject("BunifuTileButton4.Image"), System.Drawing.Image)
        Me.BunifuTileButton4.ImagePosition = 5
        Me.BunifuTileButton4.ImageZoom = 60
        Me.BunifuTileButton4.LabelPosition = 18
        Me.BunifuTileButton4.LabelText = "Video"
        Me.BunifuTileButton4.Location = New System.Drawing.Point(184, 5)
        Me.BunifuTileButton4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuTileButton4.Name = "BunifuTileButton4"
        Me.BunifuTileButton4.Size = New System.Drawing.Size(52, 58)
        Me.BunifuTileButton4.TabIndex = 46
        '
        'BunifuTileButton5
        '
        Me.BunifuTileButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTileButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTileButton5.color = System.Drawing.Color.Transparent
        Me.BunifuTileButton5.colorActive = System.Drawing.Color.LightGray
        Me.BunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuTileButton5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BunifuTileButton5.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuTileButton5.Image = CType(resources.GetObject("BunifuTileButton5.Image"), System.Drawing.Image)
        Me.BunifuTileButton5.ImagePosition = 5
        Me.BunifuTileButton5.ImageZoom = 60
        Me.BunifuTileButton5.LabelPosition = 18
        Me.BunifuTileButton5.LabelText = "Access"
        Me.BunifuTileButton5.Location = New System.Drawing.Point(244, 5)
        Me.BunifuTileButton5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuTileButton5.Name = "BunifuTileButton5"
        Me.BunifuTileButton5.Size = New System.Drawing.Size(52, 58)
        Me.BunifuTileButton5.TabIndex = 47
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTileButton1.color = System.Drawing.Color.Transparent
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.LightGray
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuTileButton1.Image = CType(resources.GetObject("BunifuTileButton1.Image"), System.Drawing.Image)
        Me.BunifuTileButton1.ImagePosition = 5
        Me.BunifuTileButton1.ImageZoom = 60
        Me.BunifuTileButton1.LabelPosition = 18
        Me.BunifuTileButton1.LabelText = "SQL"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(64, 5)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(52, 58)
        Me.BunifuTileButton1.TabIndex = 44
        '
        'BunifuTileButton2
        '
        Me.BunifuTileButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTileButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTileButton2.color = System.Drawing.Color.Transparent
        Me.BunifuTileButton2.colorActive = System.Drawing.Color.LightGray
        Me.BunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuTileButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BunifuTileButton2.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuTileButton2.Image = CType(resources.GetObject("BunifuTileButton2.Image"), System.Drawing.Image)
        Me.BunifuTileButton2.ImagePosition = 5
        Me.BunifuTileButton2.ImageZoom = 60
        Me.BunifuTileButton2.LabelPosition = 18
        Me.BunifuTileButton2.LabelText = "PMIS"
        Me.BunifuTileButton2.Location = New System.Drawing.Point(4, 5)
        Me.BunifuTileButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuTileButton2.Name = "BunifuTileButton2"
        Me.BunifuTileButton2.Size = New System.Drawing.Size(52, 58)
        Me.BunifuTileButton2.TabIndex = 45
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroTile2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile2.Location = New System.Drawing.Point(929, 316)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(120, 120)
        Me.MetroTile2.TabIndex = 44
        Me.MetroTile2.Text = "Maintenance"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile2.TileImage = CType(resources.GetObject("MetroTile2.TileImage"), System.Drawing.Image)
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BackImagePadding = New System.Windows.Forms.Padding(420, 0, 0, 0)
        Me.BackMaxSize = 60
        Me.ClientSize = New System.Drawing.Size(1366, 728)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.mtreport)
        Me.Controls.Add(Me.mtuser)
        Me.Controls.Add(Me.mtmaintenance)
        Me.Controls.Add(Me.MetroTile1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Brown
        Me.Text = "HRMD Integrated Systems"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Msm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mtreport As MetroFramework.Controls.MetroTile
    Friend WithEvents mtuser As MetroFramework.Controls.MetroTile
    Friend WithEvents mtmaintenance As MetroFramework.Controls.MetroTile
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton2 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton3 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton4 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton5 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
End Class
