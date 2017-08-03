<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Medical
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medical))
        Me.lblname = New MetroFramework.Controls.MetroLabel()
        Me.lblid = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.gbrecord = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Txt5 = New MetroFramework.Controls.MetroTextBox()
        Me.Txt4 = New MetroFramework.Controls.MetroTextBox()
        Me.Txt1 = New MetroFramework.Controls.MetroTextBox()
        Me.Txt2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.Txt3 = New MetroFramework.Controls.MetroTextBox()
        Me.gbcontact = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt9 = New MetroFramework.Controls.MetroTextBox()
        Me.txt8 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.txt10 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txt6 = New MetroFramework.Controls.MetroTextBox()
        Me.gbmedical = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txt7 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.gbrecord.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.gbcontact.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbmedical.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblname.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblname.Location = New System.Drawing.Point(113, 61)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(119, 25)
        Me.lblname.TabIndex = 32
        Me.lblname.Text = "MetroLabel2"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblid.Location = New System.Drawing.Point(25, 61)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(0, 0)
        Me.lblid.TabIndex = 31
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(88, 61)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(19, 25)
        Me.MetroLabel3.TabIndex = 31
        Me.MetroLabel3.Text = "-"
        '
        'gbrecord
        '
        Me.gbrecord.BackColor = System.Drawing.Color.Transparent
        Me.gbrecord.Controls.Add(Me.TableLayoutPanel3)
        Me.gbrecord.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.gbrecord.ForeColor = System.Drawing.Color.DimGray
        Me.gbrecord.Location = New System.Drawing.Point(5, 89)
        Me.gbrecord.Name = "gbrecord"
        Me.gbrecord.Size = New System.Drawing.Size(292, 210)
        Me.gbrecord.TabIndex = 33
        Me.gbrecord.TabStop = False
        Me.gbrecord.Text = "Record"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Txt5, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Txt4, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Txt1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Txt2, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.MetroLabel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.MetroLabel5, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.MetroLabel6, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.MetroLabel7, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.MetroLabel12, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Txt3, 1, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(286, 189)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Txt5
        '
        Me.Txt5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt5.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Txt5.Lines = New String(-1) {}
        Me.Txt5.Location = New System.Drawing.Point(88, 151)
        Me.Txt5.MaxLength = 32767
        Me.Txt5.Name = "Txt5"
        Me.Txt5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt5.SelectedText = ""
        Me.Txt5.Size = New System.Drawing.Size(195, 35)
        Me.Txt5.TabIndex = 5
        Me.Txt5.UseSelectable = True
        '
        'Txt4
        '
        Me.Txt4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt4.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Txt4.Lines = New String(-1) {}
        Me.Txt4.Location = New System.Drawing.Point(88, 114)
        Me.Txt4.MaxLength = 32767
        Me.Txt4.Name = "Txt4"
        Me.Txt4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt4.SelectedText = ""
        Me.Txt4.Size = New System.Drawing.Size(195, 31)
        Me.Txt4.TabIndex = 4
        Me.Txt4.UseSelectable = True
        '
        'Txt1
        '
        Me.Txt1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Txt1.Lines = New String(-1) {}
        Me.Txt1.Location = New System.Drawing.Point(88, 3)
        Me.Txt1.MaxLength = 32767
        Me.Txt1.Name = "Txt1"
        Me.Txt1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt1.SelectedText = ""
        Me.Txt1.Size = New System.Drawing.Size(195, 31)
        Me.Txt1.TabIndex = 1
        Me.Txt1.UseSelectable = True
        '
        'Txt2
        '
        Me.Txt2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Txt2.Lines = New String(-1) {}
        Me.Txt2.Location = New System.Drawing.Point(88, 40)
        Me.Txt2.MaxLength = 32767
        Me.Txt2.Name = "Txt2"
        Me.Txt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt2.SelectedText = ""
        Me.Txt2.Size = New System.Drawing.Size(195, 31)
        Me.Txt2.TabIndex = 2
        Me.Txt2.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 18)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel4.TabIndex = 32
        Me.MetroLabel4.Text = "TIN :"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 55)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel5.TabIndex = 32
        Me.MetroLabel5.Text = "UMID No :"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 92)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel6.TabIndex = 32
        Me.MetroLabel6.Text = "GSIS ID :"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 129)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel7.TabIndex = 32
        Me.MetroLabel7.Text = "Pag-ibig :"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(3, 170)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel12.TabIndex = 32
        Me.MetroLabel12.Text = "Philhealth :"
        '
        'Txt3
        '
        Me.Txt3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt3.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Txt3.Lines = New String(-1) {}
        Me.Txt3.Location = New System.Drawing.Point(88, 77)
        Me.Txt3.MaxLength = 32767
        Me.Txt3.Name = "Txt3"
        Me.Txt3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt3.SelectedText = ""
        Me.Txt3.Size = New System.Drawing.Size(195, 31)
        Me.Txt3.TabIndex = 3
        Me.Txt3.UseSelectable = True
        '
        'gbcontact
        '
        Me.gbcontact.BackColor = System.Drawing.Color.Transparent
        Me.gbcontact.Controls.Add(Me.TableLayoutPanel1)
        Me.gbcontact.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.gbcontact.ForeColor = System.Drawing.Color.DimGray
        Me.gbcontact.Location = New System.Drawing.Point(300, 181)
        Me.gbcontact.Name = "gbcontact"
        Me.gbcontact.Size = New System.Drawing.Size(367, 118)
        Me.gbcontact.TabIndex = 33
        Me.gbcontact.TabStop = False
        Me.gbcontact.Text = "Person to Contact in Case of Emergency"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt9, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt8, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel9, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel10, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt10, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(361, 97)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txt9
        '
        Me.txt9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt9.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt9.Lines = New String(-1) {}
        Me.txt9.Location = New System.Drawing.Point(111, 35)
        Me.txt9.MaxLength = 32767
        Me.txt9.Name = "txt9"
        Me.txt9.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt9.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt9.SelectedText = ""
        Me.txt9.Size = New System.Drawing.Size(247, 26)
        Me.txt9.TabIndex = 8
        Me.txt9.UseSelectable = True
        '
        'txt8
        '
        Me.txt8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt8.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt8.Lines = New String(-1) {}
        Me.txt8.Location = New System.Drawing.Point(111, 3)
        Me.txt8.MaxLength = 32767
        Me.txt8.Name = "txt8"
        Me.txt8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt8.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt8.SelectedText = ""
        Me.txt8.Size = New System.Drawing.Size(247, 26)
        Me.txt8.TabIndex = 7
        Me.txt8.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(3, 13)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel8.TabIndex = 32
        Me.MetroLabel8.Text = "PERSON :"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(3, 45)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel9.TabIndex = 32
        Me.MetroLabel9.Text = "ADDRESS :"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(3, 78)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel10.TabIndex = 32
        Me.MetroLabel10.Text = "CONTACT :"
        '
        'txt10
        '
        Me.txt10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt10.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt10.Lines = New String(-1) {}
        Me.txt10.Location = New System.Drawing.Point(111, 67)
        Me.txt10.MaxLength = 32767
        Me.txt10.Name = "txt10"
        Me.txt10.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt10.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt10.SelectedText = ""
        Me.txt10.Size = New System.Drawing.Size(247, 27)
        Me.txt10.TabIndex = 9
        Me.txt10.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(3, 15)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel14.TabIndex = 33
        Me.MetroLabel14.Text = "Allergy :"
        '
        'txt6
        '
        Me.txt6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt6.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt6.Lines = New String(-1) {}
        Me.txt6.Location = New System.Drawing.Point(111, 3)
        Me.txt6.MaxLength = 32767
        Me.txt6.Name = "txt6"
        Me.txt6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt6.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt6.SelectedText = ""
        Me.txt6.Size = New System.Drawing.Size(247, 28)
        Me.txt6.TabIndex = 6
        Me.txt6.UseSelectable = True
        '
        'gbmedical
        '
        Me.gbmedical.BackColor = System.Drawing.Color.Transparent
        Me.gbmedical.Controls.Add(Me.TableLayoutPanel2)
        Me.gbmedical.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.gbmedical.ForeColor = System.Drawing.Color.DimGray
        Me.gbmedical.Location = New System.Drawing.Point(300, 89)
        Me.gbmedical.Name = "gbmedical"
        Me.gbmedical.Size = New System.Drawing.Size(367, 89)
        Me.gbmedical.TabIndex = 34
        Me.gbmedical.TabStop = False
        Me.gbmedical.Text = "Medical Condition (e.g. Epiliptic, Diabetic, Hypertensive etc."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel11, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt7, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel14, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt6, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(361, 68)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'MetroLabel11
        '
        Me.MetroLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(3, 49)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel11.TabIndex = 35
        Me.MetroLabel11.Text = "Condition :"
        '
        'txt7
        '
        Me.txt7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt7.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt7.Lines = New String(-1) {}
        Me.txt7.Location = New System.Drawing.Point(111, 37)
        Me.txt7.MaxLength = 32767
        Me.txt7.Name = "txt7"
        Me.txt7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt7.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt7.SelectedText = ""
        Me.txt7.Size = New System.Drawing.Size(247, 28)
        Me.txt7.TabIndex = 34
        Me.txt7.UseSelectable = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.Color.Transparent
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile2.Enabled = False
        Me.MetroTile2.Location = New System.Drawing.Point(627, 46)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(40, 40)
        Me.MetroTile2.TabIndex = 37
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile2.TileImage = Global.HRISv3.My.Resources.Resources.Update_30px
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        Me.MetroTile2.Visible = False
        '
        'Medical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 312)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.gbmedical)
        Me.Controls.Add(Me.gbcontact)
        Me.Controls.Add(Me.gbrecord)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lblid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Medical"
        Me.Text = "Medical Record"
        Me.gbrecord.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.gbcontact.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gbmedical.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblid As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents gbrecord As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Txt5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Txt4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Txt2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Txt3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents gbcontact As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txt9 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt8 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt10 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt6 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents gbmedical As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt7 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Public WithEvents Txt1 As MetroFramework.Controls.MetroTextBox
End Class
