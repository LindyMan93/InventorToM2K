<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickNotes
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuickNotes))
        Me.ePrtNumLabel = New System.Windows.Forms.Label()
        Me.partNumberText = New System.Windows.Forms.TextBox()
        Me.cButton = New System.Windows.Forms.Button()
        Me.StandardButton = New System.Windows.Forms.Button()
        Me.extDesc5 = New System.Windows.Forms.TextBox()
        Me.extDesc4 = New System.Windows.Forms.TextBox()
        Me.extDesc3 = New System.Windows.Forms.TextBox()
        Me.SaveLocalButton = New System.Windows.Forms.Button()
        Me.uomSelect = New System.Windows.Forms.ComboBox()
        Me.extDesc2 = New System.Windows.Forms.TextBox()
        Me.sDescriptionLabel = New System.Windows.Forms.Label()
        Me.UoMLabel = New System.Windows.Forms.Label()
        Me.descriptionText = New System.Windows.Forms.TextBox()
        Me.engineerText = New System.Windows.Forms.ComboBox()
        Me.eDescripLabel = New System.Windows.Forms.Label()
        Me.extDesc1 = New System.Windows.Forms.TextBox()
        Me.mfgNameText = New System.Windows.Forms.TextBox()
        Me.saleCodeLabel = New System.Windows.Forms.Label()
        Me.salesOrT = New System.Windows.Forms.TextBox()
        Me.engrStatusLabel = New System.Windows.Forms.Label()
        Me.mfgNameLabel = New System.Windows.Forms.Label()
        Me.invTypeLabel = New System.Windows.Forms.Label()
        Me.mfgPartNumLabel = New System.Windows.Forms.Label()
        Me.engrLabel = New System.Windows.Forms.Label()
        Me.salesONum = New System.Windows.Forms.Label()
        Me.mfgPrtNumText = New System.Windows.Forms.TextBox()
        Me.salesCodeSelect = New System.Windows.Forms.ComboBox()
        Me.engStatusSelect = New System.Windows.Forms.ComboBox()
        Me.invTypeSelect = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ePrtNumLabel
        '
        Me.ePrtNumLabel.AutoSize = True
        Me.ePrtNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ePrtNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ePrtNumLabel.Location = New System.Drawing.Point(59, 9)
        Me.ePrtNumLabel.Name = "ePrtNumLabel"
        Me.ePrtNumLabel.Size = New System.Drawing.Size(116, 27)
        Me.ePrtNumLabel.TabIndex = 71
        Me.ePrtNumLabel.Text = "Part Number"
        Me.ePrtNumLabel.UseCompatibleTextRendering = True
        '
        'partNumberText
        '
        Me.partNumberText.BackColor = System.Drawing.SystemColors.Control
        Me.partNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.partNumberText.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.partNumberText.ForeColor = System.Drawing.Color.Red
        Me.partNumberText.Location = New System.Drawing.Point(181, 11)
        Me.partNumberText.Name = "partNumberText"
        Me.partNumberText.ReadOnly = True
        Me.partNumberText.Size = New System.Drawing.Size(175, 22)
        Me.partNumberText.TabIndex = 72
        Me.partNumberText.TabStop = False
        Me.partNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cButton
        '
        Me.cButton.BackColor = System.Drawing.Color.LightGreen
        Me.cButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen
        Me.cButton.FlatAppearance.BorderSize = 0
        Me.cButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cButton.Location = New System.Drawing.Point(208, 347)
        Me.cButton.Name = "cButton"
        Me.cButton.Size = New System.Drawing.Size(81, 22)
        Me.cButton.TabIndex = 99
        Me.cButton.Text = "Cancel"
        Me.cButton.UseVisualStyleBackColor = False
        '
        'StandardButton
        '
        Me.StandardButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StandardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StandardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.StandardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StandardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StandardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StandardButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StandardButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StandardButton.Location = New System.Drawing.Point(13, 347)
        Me.StandardButton.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.StandardButton.Name = "StandardButton"
        Me.StandardButton.Size = New System.Drawing.Size(68, 22)
        Me.StandardButton.TabIndex = 87
        Me.StandardButton.Text = "Standard"
        Me.StandardButton.UseVisualStyleBackColor = False
        '
        'extDesc5
        '
        Me.extDesc5.AllowDrop = True
        Me.extDesc5.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extDesc5.Location = New System.Drawing.Point(13, 317)
        Me.extDesc5.Margin = New System.Windows.Forms.Padding(3, 0, 5, 5)
        Me.extDesc5.MaxLength = 65
        Me.extDesc5.Name = "extDesc5"
        Me.extDesc5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.extDesc5.Size = New System.Drawing.Size(363, 22)
        Me.extDesc5.TabIndex = 86
        '
        'extDesc4
        '
        Me.extDesc4.AllowDrop = True
        Me.extDesc4.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extDesc4.Location = New System.Drawing.Point(13, 295)
        Me.extDesc4.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.extDesc4.MaxLength = 65
        Me.extDesc4.Name = "extDesc4"
        Me.extDesc4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.extDesc4.Size = New System.Drawing.Size(363, 22)
        Me.extDesc4.TabIndex = 85
        '
        'extDesc3
        '
        Me.extDesc3.AllowDrop = True
        Me.extDesc3.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extDesc3.Location = New System.Drawing.Point(13, 273)
        Me.extDesc3.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.extDesc3.MaxLength = 65
        Me.extDesc3.Name = "extDesc3"
        Me.extDesc3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.extDesc3.Size = New System.Drawing.Size(363, 22)
        Me.extDesc3.TabIndex = 84
        '
        'SaveLocalButton
        '
        Me.SaveLocalButton.BackColor = System.Drawing.Color.LightGreen
        Me.SaveLocalButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen
        Me.SaveLocalButton.FlatAppearance.BorderSize = 0
        Me.SaveLocalButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SaveLocalButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveLocalButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SaveLocalButton.Location = New System.Drawing.Point(295, 347)
        Me.SaveLocalButton.Name = "SaveLocalButton"
        Me.SaveLocalButton.Size = New System.Drawing.Size(81, 22)
        Me.SaveLocalButton.TabIndex = 88
        Me.SaveLocalButton.Text = "Save"
        Me.SaveLocalButton.UseVisualStyleBackColor = False
        '
        'uomSelect
        '
        Me.uomSelect.BackColor = System.Drawing.SystemColors.Window
        Me.uomSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uomSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uomSelect.DropDownWidth = 200
        Me.uomSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uomSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uomSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.uomSelect.FormattingEnabled = True
        Me.uomSelect.Location = New System.Drawing.Point(83, 46)
        Me.uomSelect.Name = "uomSelect"
        Me.uomSelect.Size = New System.Drawing.Size(126, 23)
        Me.uomSelect.TabIndex = 73
        '
        'extDesc2
        '
        Me.extDesc2.AllowDrop = True
        Me.extDesc2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extDesc2.Location = New System.Drawing.Point(13, 251)
        Me.extDesc2.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.extDesc2.MaxLength = 65
        Me.extDesc2.Name = "extDesc2"
        Me.extDesc2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.extDesc2.Size = New System.Drawing.Size(363, 22)
        Me.extDesc2.TabIndex = 83
        '
        'sDescriptionLabel
        '
        Me.sDescriptionLabel.AutoSize = True
        Me.sDescriptionLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sDescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sDescriptionLabel.Location = New System.Drawing.Point(215, 46)
        Me.sDescriptionLabel.Name = "sDescriptionLabel"
        Me.sDescriptionLabel.Size = New System.Drawing.Size(106, 17)
        Me.sDescriptionLabel.TabIndex = 90
        Me.sDescriptionLabel.Text = "Item Description*"
        '
        'UoMLabel
        '
        Me.UoMLabel.AutoSize = True
        Me.UoMLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UoMLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UoMLabel.Location = New System.Drawing.Point(12, 49)
        Me.UoMLabel.Name = "UoMLabel"
        Me.UoMLabel.Size = New System.Drawing.Size(65, 17)
        Me.UoMLabel.TabIndex = 89
        Me.UoMLabel.Text = "Measure*"
        '
        'descriptionText
        '
        Me.descriptionText.AllowDrop = True
        Me.descriptionText.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.descriptionText.Location = New System.Drawing.Point(218, 66)
        Me.descriptionText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.descriptionText.MaxLength = 25
        Me.descriptionText.Name = "descriptionText"
        Me.descriptionText.Size = New System.Drawing.Size(157, 22)
        Me.descriptionText.TabIndex = 78
        '
        'engineerText
        '
        Me.engineerText.BackColor = System.Drawing.SystemColors.Window
        Me.engineerText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.engineerText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.engineerText.DropDownWidth = 200
        Me.engineerText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.engineerText.Font = New System.Drawing.Font("Franklin Gothic Book", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.engineerText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.engineerText.FormattingEnabled = True
        Me.engineerText.Location = New System.Drawing.Point(83, 135)
        Me.engineerText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.engineerText.Name = "engineerText"
        Me.engineerText.Size = New System.Drawing.Size(128, 23)
        Me.engineerText.TabIndex = 76
        '
        'eDescripLabel
        '
        Me.eDescripLabel.AutoSize = True
        Me.eDescripLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eDescripLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.eDescripLabel.Location = New System.Drawing.Point(12, 209)
        Me.eDescripLabel.Name = "eDescripLabel"
        Me.eDescripLabel.Size = New System.Drawing.Size(125, 17)
        Me.eDescripLabel.TabIndex = 91
        Me.eDescripLabel.Text = "Extended Description"
        '
        'extDesc1
        '
        Me.extDesc1.AllowDrop = True
        Me.extDesc1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extDesc1.Location = New System.Drawing.Point(13, 229)
        Me.extDesc1.Margin = New System.Windows.Forms.Padding(3, 3, 5, 0)
        Me.extDesc1.MaxLength = 65
        Me.extDesc1.Name = "extDesc1"
        Me.extDesc1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.extDesc1.Size = New System.Drawing.Size(363, 22)
        Me.extDesc1.TabIndex = 82
        '
        'mfgNameText
        '
        Me.mfgNameText.AllowDrop = True
        Me.mfgNameText.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfgNameText.Location = New System.Drawing.Point(218, 156)
        Me.mfgNameText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.mfgNameText.MaxLength = 25
        Me.mfgNameText.Name = "mfgNameText"
        Me.mfgNameText.Size = New System.Drawing.Size(158, 22)
        Me.mfgNameText.TabIndex = 80
        '
        'saleCodeLabel
        '
        Me.saleCodeLabel.AutoSize = True
        Me.saleCodeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saleCodeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.saleCodeLabel.Location = New System.Drawing.Point(13, 169)
        Me.saleCodeLabel.Name = "saleCodeLabel"
        Me.saleCodeLabel.Size = New System.Drawing.Size(70, 17)
        Me.saleCodeLabel.TabIndex = 92
        Me.saleCodeLabel.Text = "Sales Code"
        '
        'salesOrT
        '
        Me.salesOrT.AllowDrop = True
        Me.salesOrT.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesOrT.Location = New System.Drawing.Point(218, 111)
        Me.salesOrT.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.salesOrT.MaxLength = 6
        Me.salesOrT.Name = "salesOrT"
        Me.salesOrT.Size = New System.Drawing.Size(158, 22)
        Me.salesOrT.TabIndex = 79
        '
        'engrStatusLabel
        '
        Me.engrStatusLabel.AutoSize = True
        Me.engrStatusLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.engrStatusLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.engrStatusLabel.Location = New System.Drawing.Point(13, 107)
        Me.engrStatusLabel.Name = "engrStatusLabel"
        Me.engrStatusLabel.Size = New System.Drawing.Size(51, 17)
        Me.engrStatusLabel.TabIndex = 93
        Me.engrStatusLabel.Text = "Status*"
        '
        'mfgNameLabel
        '
        Me.mfgNameLabel.AutoSize = True
        Me.mfgNameLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfgNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mfgNameLabel.Location = New System.Drawing.Point(215, 136)
        Me.mfgNameLabel.Name = "mfgNameLabel"
        Me.mfgNameLabel.Size = New System.Drawing.Size(69, 17)
        Me.mfgNameLabel.TabIndex = 96
        Me.mfgNameLabel.Text = "Mfg. Name"
        '
        'invTypeLabel
        '
        Me.invTypeLabel.AutoSize = True
        Me.invTypeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invTypeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.invTypeLabel.Location = New System.Drawing.Point(13, 78)
        Me.invTypeLabel.Name = "invTypeLabel"
        Me.invTypeLabel.Size = New System.Drawing.Size(41, 17)
        Me.invTypeLabel.TabIndex = 94
        Me.invTypeLabel.Text = "Type*"
        '
        'mfgPartNumLabel
        '
        Me.mfgPartNumLabel.AutoSize = True
        Me.mfgPartNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfgPartNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mfgPartNumLabel.Location = New System.Drawing.Point(215, 181)
        Me.mfgPartNumLabel.Name = "mfgPartNumLabel"
        Me.mfgPartNumLabel.Size = New System.Drawing.Size(105, 17)
        Me.mfgPartNumLabel.TabIndex = 97
        Me.mfgPartNumLabel.Text = "Mfg. Part Number"
        '
        'engrLabel
        '
        Me.engrLabel.AutoSize = True
        Me.engrLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.engrLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.engrLabel.Location = New System.Drawing.Point(13, 138)
        Me.engrLabel.Name = "engrLabel"
        Me.engrLabel.Size = New System.Drawing.Size(64, 17)
        Me.engrLabel.TabIndex = 95
        Me.engrLabel.Text = "Engineer*"
        '
        'salesONum
        '
        Me.salesONum.AutoSize = True
        Me.salesONum.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesONum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.salesONum.Location = New System.Drawing.Point(215, 91)
        Me.salesONum.Name = "salesONum"
        Me.salesONum.Size = New System.Drawing.Size(137, 17)
        Me.salesONum.TabIndex = 98
        Me.salesONum.Text = "Sales Order / Customer"
        '
        'mfgPrtNumText
        '
        Me.mfgPrtNumText.AllowDrop = True
        Me.mfgPrtNumText.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfgPrtNumText.Location = New System.Drawing.Point(218, 201)
        Me.mfgPrtNumText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.mfgPrtNumText.MaxLength = 25
        Me.mfgPrtNumText.Name = "mfgPrtNumText"
        Me.mfgPrtNumText.Size = New System.Drawing.Size(158, 22)
        Me.mfgPrtNumText.TabIndex = 81
        '
        'salesCodeSelect
        '
        Me.salesCodeSelect.BackColor = System.Drawing.SystemColors.Window
        Me.salesCodeSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.salesCodeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.salesCodeSelect.DropDownWidth = 200
        Me.salesCodeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.salesCodeSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesCodeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.salesCodeSelect.FormattingEnabled = True
        Me.salesCodeSelect.Location = New System.Drawing.Point(89, 166)
        Me.salesCodeSelect.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.salesCodeSelect.Name = "salesCodeSelect"
        Me.salesCodeSelect.Size = New System.Drawing.Size(122, 23)
        Me.salesCodeSelect.TabIndex = 77
        '
        'engStatusSelect
        '
        Me.engStatusSelect.BackColor = System.Drawing.SystemColors.Window
        Me.engStatusSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.engStatusSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.engStatusSelect.DropDownWidth = 200
        Me.engStatusSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.engStatusSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.engStatusSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.engStatusSelect.FormattingEnabled = True
        Me.engStatusSelect.Location = New System.Drawing.Point(70, 104)
        Me.engStatusSelect.Name = "engStatusSelect"
        Me.engStatusSelect.Size = New System.Drawing.Size(141, 23)
        Me.engStatusSelect.TabIndex = 75
        '
        'invTypeSelect
        '
        Me.invTypeSelect.BackColor = System.Drawing.SystemColors.Window
        Me.invTypeSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.invTypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.invTypeSelect.DropDownWidth = 200
        Me.invTypeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.invTypeSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invTypeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.invTypeSelect.FormattingEnabled = True
        Me.invTypeSelect.Location = New System.Drawing.Point(60, 75)
        Me.invTypeSelect.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.invTypeSelect.Name = "invTypeSelect"
        Me.invTypeSelect.Size = New System.Drawing.Size(151, 23)
        Me.invTypeSelect.TabIndex = 74
        '
        'QuickNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 378)
        Me.Controls.Add(Me.cButton)
        Me.Controls.Add(Me.StandardButton)
        Me.Controls.Add(Me.extDesc5)
        Me.Controls.Add(Me.extDesc4)
        Me.Controls.Add(Me.extDesc3)
        Me.Controls.Add(Me.SaveLocalButton)
        Me.Controls.Add(Me.uomSelect)
        Me.Controls.Add(Me.extDesc2)
        Me.Controls.Add(Me.sDescriptionLabel)
        Me.Controls.Add(Me.UoMLabel)
        Me.Controls.Add(Me.descriptionText)
        Me.Controls.Add(Me.engineerText)
        Me.Controls.Add(Me.eDescripLabel)
        Me.Controls.Add(Me.extDesc1)
        Me.Controls.Add(Me.mfgNameText)
        Me.Controls.Add(Me.saleCodeLabel)
        Me.Controls.Add(Me.salesOrT)
        Me.Controls.Add(Me.engrStatusLabel)
        Me.Controls.Add(Me.mfgNameLabel)
        Me.Controls.Add(Me.invTypeLabel)
        Me.Controls.Add(Me.mfgPartNumLabel)
        Me.Controls.Add(Me.engrLabel)
        Me.Controls.Add(Me.salesONum)
        Me.Controls.Add(Me.mfgPrtNumText)
        Me.Controls.Add(Me.salesCodeSelect)
        Me.Controls.Add(Me.engStatusSelect)
        Me.Controls.Add(Me.invTypeSelect)
        Me.Controls.Add(Me.ePrtNumLabel)
        Me.Controls.Add(Me.partNumberText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuickNotes"
        Me.Text = "Quick Notes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ePrtNumLabel As Windows.Forms.Label
    Friend WithEvents partNumberText As Windows.Forms.TextBox
    Friend WithEvents cButton As Windows.Forms.Button
    Friend WithEvents StandardButton As Windows.Forms.Button
    Friend WithEvents extDesc5 As Windows.Forms.TextBox
    Friend WithEvents extDesc4 As Windows.Forms.TextBox
    Friend WithEvents extDesc3 As Windows.Forms.TextBox
    Friend WithEvents SaveLocalButton As Windows.Forms.Button
    Friend WithEvents uomSelect As Windows.Forms.ComboBox
    Friend WithEvents extDesc2 As Windows.Forms.TextBox
    Friend WithEvents sDescriptionLabel As Windows.Forms.Label
    Friend WithEvents UoMLabel As Windows.Forms.Label
    Friend WithEvents descriptionText As Windows.Forms.TextBox
    Friend WithEvents engineerText As Windows.Forms.ComboBox
    Friend WithEvents eDescripLabel As Windows.Forms.Label
    Friend WithEvents extDesc1 As Windows.Forms.TextBox
    Friend WithEvents mfgNameText As Windows.Forms.TextBox
    Friend WithEvents saleCodeLabel As Windows.Forms.Label
    Friend WithEvents salesOrT As Windows.Forms.TextBox
    Friend WithEvents engrStatusLabel As Windows.Forms.Label
    Friend WithEvents mfgNameLabel As Windows.Forms.Label
    Friend WithEvents invTypeLabel As Windows.Forms.Label
    Friend WithEvents mfgPartNumLabel As Windows.Forms.Label
    Friend WithEvents engrLabel As Windows.Forms.Label
    Friend WithEvents salesONum As Windows.Forms.Label
    Friend WithEvents mfgPrtNumText As Windows.Forms.TextBox
    Friend WithEvents salesCodeSelect As Windows.Forms.ComboBox
    Friend WithEvents engStatusSelect As Windows.Forms.ComboBox
    Friend WithEvents invTypeSelect As Windows.Forms.ComboBox
End Class
