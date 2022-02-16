<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoutDialog
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoutDialog))
        Me.routLogo = New System.Windows.Forms.PictureBox()
        Me.descriptionText = New System.Windows.Forms.TextBox()
        Me.eDescripLabel = New System.Windows.Forms.Label()
        Me.seqLabel = New System.Windows.Forms.Label()
        Me.crewLabel = New System.Windows.Forms.Label()
        Me.partNumberText = New System.Windows.Forms.TextBox()
        Me.ePrtNumLabel = New System.Windows.Forms.Label()
        Me.seqSelect = New System.Windows.Forms.ComboBox()
        Me.lHourLabel = New System.Windows.Forms.Label()
        Me.laborText = New System.Windows.Forms.TextBox()
        Me.crtButton = New System.Windows.Forms.Button()
        Me.upload_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.routTable = New System.Windows.Forms.DataGridView()
        Me.seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wCenter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crewText = New System.Windows.Forms.TextBox()
        Me.wsSelect = New System.Windows.Forms.ComboBox()
        Me.wCLabel = New System.Windows.Forms.Label()
        Me.ccButton = New System.Windows.Forms.Button()
        Me.crbButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.PresetBox = New System.Windows.Forms.GroupBox()
        Me.atpButton = New System.Windows.Forms.Button()
        Me.ActionBox = New System.Windows.Forms.GroupBox()
        CType(Me.routLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.routTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PresetBox.SuspendLayout()
        Me.ActionBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'routLogo
        '
        Me.routLogo.Location = New System.Drawing.Point(12, 12)
        Me.routLogo.Name = "routLogo"
        Me.routLogo.Size = New System.Drawing.Size(64, 64)
        Me.routLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.routLogo.TabIndex = 1
        Me.routLogo.TabStop = False
        '
        'descriptionText
        '
        Me.descriptionText.AllowDrop = True
        Me.descriptionText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.descriptionText.Location = New System.Drawing.Point(12, 236)
        Me.descriptionText.MaxLength = 50
        Me.descriptionText.Multiline = True
        Me.descriptionText.Name = "descriptionText"
        Me.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.descriptionText.Size = New System.Drawing.Size(324, 54)
        Me.descriptionText.TabIndex = 5
        '
        'eDescripLabel
        '
        Me.eDescripLabel.AutoSize = True
        Me.eDescripLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.eDescripLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.eDescripLabel.Location = New System.Drawing.Point(100, 212)
        Me.eDescripLabel.Name = "eDescripLabel"
        Me.eDescripLabel.Size = New System.Drawing.Size(154, 21)
        Me.eDescripLabel.TabIndex = 17
        Me.eDescripLabel.Text = "Extended Description"
        '
        'seqLabel
        '
        Me.seqLabel.AutoSize = True
        Me.seqLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.seqLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.seqLabel.Location = New System.Drawing.Point(12, 84)
        Me.seqLabel.Name = "seqLabel"
        Me.seqLabel.Size = New System.Drawing.Size(77, 21)
        Me.seqLabel.TabIndex = 16
        Me.seqLabel.Text = "Sequence"
        '
        'crewLabel
        '
        Me.crewLabel.AutoSize = True
        Me.crewLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.crewLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.crewLabel.Location = New System.Drawing.Point(12, 154)
        Me.crewLabel.Name = "crewLabel"
        Me.crewLabel.Size = New System.Drawing.Size(109, 21)
        Me.crewLabel.TabIndex = 15
        Me.crewLabel.Text = "Crew Required"
        '
        'partNumberText
        '
        Me.partNumberText.BackColor = System.Drawing.SystemColors.Control
        Me.partNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.partNumberText.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.partNumberText.ForeColor = System.Drawing.Color.Red
        Me.partNumberText.Location = New System.Drawing.Point(95, 42)
        Me.partNumberText.Name = "partNumberText"
        Me.partNumberText.ReadOnly = True
        Me.partNumberText.Size = New System.Drawing.Size(240, 22)
        Me.partNumberText.TabIndex = 13
        Me.partNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ePrtNumLabel
        '
        Me.ePrtNumLabel.AutoSize = True
        Me.ePrtNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ePrtNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ePrtNumLabel.Location = New System.Drawing.Point(150, 12)
        Me.ePrtNumLabel.Name = "ePrtNumLabel"
        Me.ePrtNumLabel.Size = New System.Drawing.Size(116, 27)
        Me.ePrtNumLabel.TabIndex = 11
        Me.ePrtNumLabel.Text = "Part Number"
        Me.ePrtNumLabel.UseCompatibleTextRendering = True
        '
        'seqSelect
        '
        Me.seqSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seqSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.seqSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.seqSelect.FormattingEnabled = True
        Me.seqSelect.Items.AddRange(New Object() {"10", "20", "30", "40", "5", "50", "60", "70"})
        Me.seqSelect.Location = New System.Drawing.Point(95, 81)
        Me.seqSelect.Name = "seqSelect"
        Me.seqSelect.Size = New System.Drawing.Size(241, 29)
        Me.seqSelect.Sorted = True
        Me.seqSelect.TabIndex = 1
        '
        'lHourLabel
        '
        Me.lHourLabel.AutoSize = True
        Me.lHourLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.lHourLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lHourLabel.Location = New System.Drawing.Point(12, 186)
        Me.lHourLabel.Name = "lHourLabel"
        Me.lHourLabel.Size = New System.Drawing.Size(91, 21)
        Me.lHourLabel.TabIndex = 21
        Me.lHourLabel.Text = "Labor Hours"
        '
        'laborText
        '
        Me.laborText.AllowDrop = True
        Me.laborText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.laborText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.laborText.Location = New System.Drawing.Point(109, 183)
        Me.laborText.MaxLength = 10
        Me.laborText.Name = "laborText"
        Me.laborText.Size = New System.Drawing.Size(226, 26)
        Me.laborText.TabIndex = 4
        '
        'crtButton
        '
        Me.crtButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.crtButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.crtButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.crtButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.crtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crtButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crtButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.crtButton.Location = New System.Drawing.Point(6, 17)
        Me.crtButton.Name = "crtButton"
        Me.crtButton.Size = New System.Drawing.Size(104, 22)
        Me.crtButton.TabIndex = 6
        Me.crtButton.Text = "Cut,Round,Tap"
        Me.crtButton.UseVisualStyleBackColor = False
        '
        'upload_Button
        '
        Me.upload_Button.BackColor = System.Drawing.Color.LightGreen
        Me.upload_Button.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen
        Me.upload_Button.FlatAppearance.BorderSize = 0
        Me.upload_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.upload_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.upload_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.upload_Button.Location = New System.Drawing.Point(12, 17)
        Me.upload_Button.Name = "upload_Button"
        Me.upload_Button.Size = New System.Drawing.Size(92, 22)
        Me.upload_Button.TabIndex = 9
        Me.upload_Button.Text = "Upload"
        Me.upload_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.MistyRose
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Cancel_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cancel_Button.Location = New System.Drawing.Point(12, 72)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(92, 22)
        Me.Cancel_Button.TabIndex = 11
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Add_Button
        '
        Me.Add_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Add_Button.FlatAppearance.BorderSize = 0
        Me.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Add_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Add_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Add_Button.Location = New System.Drawing.Point(12, 45)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(92, 21)
        Me.Add_Button.TabIndex = 10
        Me.Add_Button.Text = "Add"
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'routTable
        '
        Me.routTable.AllowUserToAddRows = False
        Me.routTable.AllowUserToResizeRows = False
        Me.routTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.routTable.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.routTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.routTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.routTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seq, Me.wCenter, Me.crew, Me.hours, Me.rDesc})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.routTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.routTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.routTable.Location = New System.Drawing.Point(344, 12)
        Me.routTable.Name = "routTable"
        Me.routTable.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.routTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.routTable.Size = New System.Drawing.Size(429, 165)
        Me.routTable.TabIndex = 25
        '
        'seq
        '
        Me.seq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.seq.FillWeight = 163.5402!
        Me.seq.HeaderText = "Seq"
        Me.seq.MinimumWidth = 50
        Me.seq.Name = "seq"
        Me.seq.ReadOnly = True
        Me.seq.Width = 51
        '
        'wCenter
        '
        Me.wCenter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.wCenter.HeaderText = "WC"
        Me.wCenter.MinimumWidth = 50
        Me.wCenter.Name = "wCenter"
        Me.wCenter.ReadOnly = True
        Me.wCenter.Width = 50
        '
        'crew
        '
        Me.crew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.crew.HeaderText = "Crew"
        Me.crew.MinimumWidth = 50
        Me.crew.Name = "crew"
        Me.crew.ReadOnly = True
        Me.crew.Width = 56
        '
        'hours
        '
        Me.hours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.hours.FillWeight = 26.16643!
        Me.hours.HeaderText = "Hours"
        Me.hours.MinimumWidth = 50
        Me.hours.Name = "hours"
        Me.hours.ReadOnly = True
        Me.hours.Width = 60
        '
        'rDesc
        '
        Me.rDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.rDesc.FillWeight = 26.16643!
        Me.rDesc.HeaderText = "Desc."
        Me.rDesc.MinimumWidth = 50
        Me.rDesc.Name = "rDesc"
        Me.rDesc.ReadOnly = True
        '
        'crewText
        '
        Me.crewText.AllowDrop = True
        Me.crewText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.crewText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.crewText.Location = New System.Drawing.Point(127, 151)
        Me.crewText.MaxLength = 2
        Me.crewText.Name = "crewText"
        Me.crewText.Size = New System.Drawing.Size(209, 26)
        Me.crewText.TabIndex = 3
        '
        'wsSelect
        '
        Me.wsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.wsSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.wsSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.wsSelect.FormattingEnabled = True
        Me.wsSelect.Location = New System.Drawing.Point(110, 116)
        Me.wsSelect.Name = "wsSelect"
        Me.wsSelect.Size = New System.Drawing.Size(225, 29)
        Me.wsSelect.TabIndex = 2
        '
        'wCLabel
        '
        Me.wCLabel.AutoSize = True
        Me.wCLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.wCLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.wCLabel.Location = New System.Drawing.Point(12, 119)
        Me.wCLabel.Name = "wCLabel"
        Me.wCLabel.Size = New System.Drawing.Size(92, 21)
        Me.wCLabel.TabIndex = 28
        Me.wCLabel.Text = "Work Center"
        '
        'ccButton
        '
        Me.ccButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ccButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ccButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ccButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ccButton.Location = New System.Drawing.Point(6, 45)
        Me.ccButton.Name = "ccButton"
        Me.ccButton.Size = New System.Drawing.Size(104, 22)
        Me.ccButton.TabIndex = 7
        Me.ccButton.Text = "Cover"
        Me.ccButton.UseVisualStyleBackColor = False
        '
        'crbButton
        '
        Me.crbButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.crbButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.crbButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.crbButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.crbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crbButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crbButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.crbButton.Location = New System.Drawing.Point(6, 72)
        Me.crbButton.Name = "crbButton"
        Me.crbButton.Size = New System.Drawing.Size(104, 22)
        Me.crbButton.TabIndex = 8
        Me.crbButton.Text = "Cut, Round, Bend"
        Me.crbButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.Control
        Me.UpdateButton.FlatAppearance.BorderSize = 0
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UpdateButton.Location = New System.Drawing.Point(110, 17)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(74, 77)
        Me.UpdateButton.TabIndex = 29
        Me.UpdateButton.Text = "Get Current Information"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'PresetBox
        '
        Me.PresetBox.Controls.Add(Me.atpButton)
        Me.PresetBox.Controls.Add(Me.crtButton)
        Me.PresetBox.Controls.Add(Me.ccButton)
        Me.PresetBox.Controls.Add(Me.crbButton)
        Me.PresetBox.Location = New System.Drawing.Point(344, 190)
        Me.PresetBox.Name = "PresetBox"
        Me.PresetBox.Size = New System.Drawing.Size(230, 100)
        Me.PresetBox.TabIndex = 30
        Me.PresetBox.TabStop = False
        Me.PresetBox.Text = "Presets"
        '
        'atpButton
        '
        Me.atpButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.atpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.atpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.atpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.atpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.atpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atpButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.atpButton.Location = New System.Drawing.Point(120, 17)
        Me.atpButton.Name = "atpButton"
        Me.atpButton.Size = New System.Drawing.Size(104, 22)
        Me.atpButton.TabIndex = 9
        Me.atpButton.Text = "Assemble"
        Me.atpButton.UseVisualStyleBackColor = False
        '
        'ActionBox
        '
        Me.ActionBox.Controls.Add(Me.upload_Button)
        Me.ActionBox.Controls.Add(Me.UpdateButton)
        Me.ActionBox.Controls.Add(Me.Cancel_Button)
        Me.ActionBox.Controls.Add(Me.Add_Button)
        Me.ActionBox.Location = New System.Drawing.Point(580, 190)
        Me.ActionBox.Name = "ActionBox"
        Me.ActionBox.Size = New System.Drawing.Size(193, 100)
        Me.ActionBox.TabIndex = 31
        Me.ActionBox.TabStop = False
        Me.ActionBox.Text = "Actions"
        '
        'RoutDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 303)
        Me.Controls.Add(Me.ActionBox)
        Me.Controls.Add(Me.PresetBox)
        Me.Controls.Add(Me.wsSelect)
        Me.Controls.Add(Me.wCLabel)
        Me.Controls.Add(Me.crewText)
        Me.Controls.Add(Me.routTable)
        Me.Controls.Add(Me.laborText)
        Me.Controls.Add(Me.lHourLabel)
        Me.Controls.Add(Me.seqSelect)
        Me.Controls.Add(Me.descriptionText)
        Me.Controls.Add(Me.eDescripLabel)
        Me.Controls.Add(Me.seqLabel)
        Me.Controls.Add(Me.crewLabel)
        Me.Controls.Add(Me.partNumberText)
        Me.Controls.Add(Me.ePrtNumLabel)
        Me.Controls.Add(Me.routLogo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RoutDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Routing"
        CType(Me.routLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.routTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PresetBox.ResumeLayout(False)
        Me.ActionBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents routLogo As Windows.Forms.PictureBox
    Friend WithEvents descriptionText As Windows.Forms.TextBox
    Friend WithEvents eDescripLabel As Windows.Forms.Label
    Friend WithEvents seqLabel As Windows.Forms.Label
    Friend WithEvents crewLabel As Windows.Forms.Label
    Friend WithEvents partNumberText As Windows.Forms.TextBox
    Friend WithEvents ePrtNumLabel As Windows.Forms.Label
    Friend WithEvents seqSelect As Windows.Forms.ComboBox
    Friend WithEvents lHourLabel As Windows.Forms.Label
    Friend WithEvents laborText As Windows.Forms.TextBox
    Friend WithEvents crtButton As Windows.Forms.Button
    Friend WithEvents upload_Button As Windows.Forms.Button
    Friend WithEvents Cancel_Button As Windows.Forms.Button
    Friend WithEvents Add_Button As Windows.Forms.Button
    Friend WithEvents routTable As Windows.Forms.DataGridView
    Friend WithEvents crewText As Windows.Forms.TextBox
    Friend WithEvents wsSelect As Windows.Forms.ComboBox
    Friend WithEvents wCLabel As Windows.Forms.Label
    Friend WithEvents ccButton As Windows.Forms.Button
    Friend WithEvents crbButton As Windows.Forms.Button
    Friend WithEvents seq As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wCenter As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crew As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hours As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rDesc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdateButton As Windows.Forms.Button
    Friend WithEvents PresetBox As Windows.Forms.GroupBox
    Friend WithEvents ActionBox As Windows.Forms.GroupBox
    Friend WithEvents atpButton As Windows.Forms.Button
End Class
