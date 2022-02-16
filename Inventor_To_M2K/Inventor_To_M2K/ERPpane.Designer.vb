<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERPpane
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ERPpane))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.itemMasterBox = New System.Windows.Forms.GroupBox()
        Me.PurchasedStandard = New System.Windows.Forms.Button()
        Me.ManufacturedStandard = New System.Windows.Forms.Button()
        Me.extDesc5 = New System.Windows.Forms.TextBox()
        Me.extDesc4 = New System.Windows.Forms.TextBox()
        Me.extDesc3 = New System.Windows.Forms.TextBox()
        Me.uploadIMButton = New System.Windows.Forms.Button()
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
        Me.leadTimeLabel = New System.Windows.Forms.Label()
        Me.mfgPrtNumText = New System.Windows.Forms.TextBox()
        Me.leadTimeSelect = New System.Windows.Forms.ComboBox()
        Me.salesCodeSelect = New System.Windows.Forms.ComboBox()
        Me.engStatusSelect = New System.Windows.Forms.ComboBox()
        Me.invTypeSelect = New System.Windows.Forms.ComboBox()
        Me.partNumberText = New System.Windows.Forms.TextBox()
        Me.ePrtNumLabel = New System.Windows.Forms.Label()
        Me.bomBox = New System.Windows.Forms.GroupBox()
        Me.partBox = New System.Windows.Forms.GroupBox()
        Me.removeMatButton = New System.Windows.Forms.Button()
        Me.addMatButton = New System.Windows.Forms.Button()
        Me.customButton = New System.Windows.Forms.Button()
        Me.matSelect = New System.Windows.Forms.ComboBox()
        Me.matNumLabel = New System.Windows.Forms.Label()
        Me.amountText = New System.Windows.Forms.TextBox()
        Me.amountLabel = New System.Windows.Forms.Label()
        Me.assemblyBox = New System.Windows.Forms.GroupBox()
        Me.removeBillButton = New System.Windows.Forms.Button()
        Me.addBillButton = New System.Windows.Forms.Button()
        Me.invBOMGrid = New System.Windows.Forms.DataGridView()
        Me.prtNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invBillSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InvGridViewSelects = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InvSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvDeselectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.m2kBillLabel = New System.Windows.Forms.Label()
        Me.m2kBOMGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m2kBillSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.M2kGridViewSelects = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.M2kSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2kDeselectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.routBox = New System.Windows.Forms.GroupBox()
        Me.removeRoutButton = New System.Windows.Forms.Button()
        Me.PresetBox = New System.Windows.Forms.GroupBox()
        Me.TapButton = New System.Windows.Forms.Button()
        Me.CutButton = New System.Windows.Forms.Button()
        Me.RoundButton = New System.Windows.Forms.Button()
        Me.AssembleButton = New System.Windows.Forms.Button()
        Me.addRoutButton = New System.Windows.Forms.Button()
        Me.routTable = New System.Windows.Forms.DataGridView()
        Me.seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wCenter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m2kRoutSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.wsSelect = New System.Windows.Forms.ComboBox()
        Me.wCLabel = New System.Windows.Forms.Label()
        Me.crewText = New System.Windows.Forms.TextBox()
        Me.laborText = New System.Windows.Forms.TextBox()
        Me.lHourLabel = New System.Windows.Forms.Label()
        Me.seqSelect = New System.Windows.Forms.ComboBox()
        Me.routDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.seqLabel = New System.Windows.Forms.Label()
        Me.crewLabel = New System.Windows.Forms.Label()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.pullsqlButton = New System.Windows.Forms.Button()
        Me.saveLocalButton = New System.Windows.Forms.Button()
        Me.SaveLocalTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.UploadItemMasterTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.RefreshInfoTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.RemoveTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.itemMasterBox.SuspendLayout()
        Me.bomBox.SuspendLayout()
        Me.partBox.SuspendLayout()
        Me.assemblyBox.SuspendLayout()
        CType(Me.invBOMGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvGridViewSelects.SuspendLayout()
        CType(Me.m2kBOMGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.M2kGridViewSelects.SuspendLayout()
        Me.routBox.SuspendLayout()
        Me.PresetBox.SuspendLayout()
        CType(Me.routTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'itemMasterBox
        '
        Me.itemMasterBox.BackColor = System.Drawing.SystemColors.Control
        Me.itemMasterBox.Controls.Add(Me.PurchasedStandard)
        Me.itemMasterBox.Controls.Add(Me.ManufacturedStandard)
        Me.itemMasterBox.Controls.Add(Me.extDesc5)
        Me.itemMasterBox.Controls.Add(Me.extDesc4)
        Me.itemMasterBox.Controls.Add(Me.extDesc3)
        Me.itemMasterBox.Controls.Add(Me.uploadIMButton)
        Me.itemMasterBox.Controls.Add(Me.uomSelect)
        Me.itemMasterBox.Controls.Add(Me.extDesc2)
        Me.itemMasterBox.Controls.Add(Me.sDescriptionLabel)
        Me.itemMasterBox.Controls.Add(Me.UoMLabel)
        Me.itemMasterBox.Controls.Add(Me.descriptionText)
        Me.itemMasterBox.Controls.Add(Me.engineerText)
        Me.itemMasterBox.Controls.Add(Me.eDescripLabel)
        Me.itemMasterBox.Controls.Add(Me.extDesc1)
        Me.itemMasterBox.Controls.Add(Me.mfgNameText)
        Me.itemMasterBox.Controls.Add(Me.saleCodeLabel)
        Me.itemMasterBox.Controls.Add(Me.salesOrT)
        Me.itemMasterBox.Controls.Add(Me.engrStatusLabel)
        Me.itemMasterBox.Controls.Add(Me.mfgNameLabel)
        Me.itemMasterBox.Controls.Add(Me.invTypeLabel)
        Me.itemMasterBox.Controls.Add(Me.mfgPartNumLabel)
        Me.itemMasterBox.Controls.Add(Me.engrLabel)
        Me.itemMasterBox.Controls.Add(Me.salesONum)
        Me.itemMasterBox.Controls.Add(Me.leadTimeLabel)
        Me.itemMasterBox.Controls.Add(Me.mfgPrtNumText)
        Me.itemMasterBox.Controls.Add(Me.leadTimeSelect)
        Me.itemMasterBox.Controls.Add(Me.salesCodeSelect)
        Me.itemMasterBox.Controls.Add(Me.engStatusSelect)
        Me.itemMasterBox.Controls.Add(Me.invTypeSelect)
        Me.itemMasterBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemMasterBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemMasterBox.Location = New System.Drawing.Point(12, 43)
        Me.itemMasterBox.Name = "itemMasterBox"
        Me.itemMasterBox.Size = New System.Drawing.Size(377, 392)
        Me.itemMasterBox.TabIndex = 67
        Me.itemMasterBox.TabStop = False
        Me.itemMasterBox.Text = "1 - Item Master"
        '
        'PurchasedStandard
        '
        Me.PurchasedStandard.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PurchasedStandard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PurchasedStandard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.PurchasedStandard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PurchasedStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PurchasedStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchasedStandard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PurchasedStandard.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PurchasedStandard.Location = New System.Drawing.Point(263, 363)
        Me.PurchasedStandard.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.PurchasedStandard.Name = "PurchasedStandard"
        Me.PurchasedStandard.Size = New System.Drawing.Size(107, 22)
        Me.PurchasedStandard.TabIndex = 18
        Me.PurchasedStandard.Text = "Purchased"
        Me.PurchasedStandard.UseVisualStyleBackColor = False
        '
        'ManufacturedStandard
        '
        Me.ManufacturedStandard.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ManufacturedStandard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ManufacturedStandard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ManufacturedStandard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ManufacturedStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManufacturedStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturedStandard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ManufacturedStandard.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ManufacturedStandard.Location = New System.Drawing.Point(151, 363)
        Me.ManufacturedStandard.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.ManufacturedStandard.Name = "ManufacturedStandard"
        Me.ManufacturedStandard.Size = New System.Drawing.Size(104, 22)
        Me.ManufacturedStandard.TabIndex = 17
        Me.ManufacturedStandard.Text = "Manufactured"
        Me.ManufacturedStandard.UseVisualStyleBackColor = False
        '
        'extDesc5
        '
        Me.extDesc5.AllowDrop = True
        Me.extDesc5.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extDesc5.Location = New System.Drawing.Point(7, 333)
        Me.extDesc5.Margin = New System.Windows.Forms.Padding(3, 0, 5, 5)
        Me.extDesc5.MaxLength = 65
        Me.extDesc5.Name = "extDesc5"
        Me.extDesc5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.extDesc5.Size = New System.Drawing.Size(363, 22)
        Me.extDesc5.TabIndex = 16
        '
        'extDesc4
        '
        Me.extDesc4.AllowDrop = True
        Me.extDesc4.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extDesc4.Location = New System.Drawing.Point(7, 311)
        Me.extDesc4.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.extDesc4.MaxLength = 65
        Me.extDesc4.Name = "extDesc4"
        Me.extDesc4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.extDesc4.Size = New System.Drawing.Size(363, 22)
        Me.extDesc4.TabIndex = 15
        '
        'extDesc3
        '
        Me.extDesc3.AllowDrop = True
        Me.extDesc3.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extDesc3.Location = New System.Drawing.Point(7, 289)
        Me.extDesc3.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.extDesc3.MaxLength = 65
        Me.extDesc3.Name = "extDesc3"
        Me.extDesc3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.extDesc3.Size = New System.Drawing.Size(363, 22)
        Me.extDesc3.TabIndex = 14
        '
        'uploadIMButton
        '
        Me.uploadIMButton.BackColor = System.Drawing.Color.LightGreen
        Me.uploadIMButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen
        Me.uploadIMButton.FlatAppearance.BorderSize = 0
        Me.uploadIMButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.uploadIMButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadIMButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.uploadIMButton.Location = New System.Drawing.Point(9, 363)
        Me.uploadIMButton.Name = "uploadIMButton"
        Me.uploadIMButton.Size = New System.Drawing.Size(136, 22)
        Me.uploadIMButton.TabIndex = 18
        Me.uploadIMButton.Text = "Upload Item Master"
        Me.UploadItemMasterTT.SetToolTip(Me.uploadIMButton, "By clicking this button you will be sending the current formation to Manage 2000." &
        "")
        Me.uploadIMButton.UseVisualStyleBackColor = False
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
        Me.uomSelect.Location = New System.Drawing.Point(77, 37)
        Me.uomSelect.Name = "uomSelect"
        Me.uomSelect.Size = New System.Drawing.Size(126, 23)
        Me.uomSelect.TabIndex = 1
        '
        'extDesc2
        '
        Me.extDesc2.AllowDrop = True
        Me.extDesc2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extDesc2.Location = New System.Drawing.Point(7, 267)
        Me.extDesc2.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.extDesc2.MaxLength = 65
        Me.extDesc2.Name = "extDesc2"
        Me.extDesc2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.extDesc2.Size = New System.Drawing.Size(363, 22)
        Me.extDesc2.TabIndex = 13
        '
        'sDescriptionLabel
        '
        Me.sDescriptionLabel.AutoSize = True
        Me.sDescriptionLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sDescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sDescriptionLabel.Location = New System.Drawing.Point(209, 40)
        Me.sDescriptionLabel.Name = "sDescriptionLabel"
        Me.sDescriptionLabel.Size = New System.Drawing.Size(106, 17)
        Me.sDescriptionLabel.TabIndex = 39
        Me.sDescriptionLabel.Text = "Item Description*"
        '
        'UoMLabel
        '
        Me.UoMLabel.AutoSize = True
        Me.UoMLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UoMLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UoMLabel.Location = New System.Drawing.Point(6, 40)
        Me.UoMLabel.Name = "UoMLabel"
        Me.UoMLabel.Size = New System.Drawing.Size(65, 17)
        Me.UoMLabel.TabIndex = 36
        Me.UoMLabel.Text = "Measure*"
        '
        'descriptionText
        '
        Me.descriptionText.AllowDrop = True
        Me.descriptionText.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.descriptionText.Location = New System.Drawing.Point(212, 60)
        Me.descriptionText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.descriptionText.MaxLength = 25
        Me.descriptionText.Name = "descriptionText"
        Me.descriptionText.Size = New System.Drawing.Size(157, 22)
        Me.descriptionText.TabIndex = 7
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
        Me.engineerText.Location = New System.Drawing.Point(76, 161)
        Me.engineerText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.engineerText.Name = "engineerText"
        Me.engineerText.Size = New System.Drawing.Size(128, 23)
        Me.engineerText.TabIndex = 5
        '
        'eDescripLabel
        '
        Me.eDescripLabel.AutoSize = True
        Me.eDescripLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eDescripLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.eDescripLabel.Location = New System.Drawing.Point(6, 225)
        Me.eDescripLabel.Name = "eDescripLabel"
        Me.eDescripLabel.Size = New System.Drawing.Size(125, 17)
        Me.eDescripLabel.TabIndex = 42
        Me.eDescripLabel.Text = "Extended Description"
        '
        'extDesc1
        '
        Me.extDesc1.AllowDrop = True
        Me.extDesc1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extDesc1.Location = New System.Drawing.Point(7, 245)
        Me.extDesc1.Margin = New System.Windows.Forms.Padding(3, 3, 5, 0)
        Me.extDesc1.MaxLength = 65
        Me.extDesc1.Name = "extDesc1"
        Me.extDesc1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.extDesc1.Size = New System.Drawing.Size(363, 22)
        Me.extDesc1.TabIndex = 12
        '
        'mfgNameText
        '
        Me.mfgNameText.AllowDrop = True
        Me.mfgNameText.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfgNameText.Location = New System.Drawing.Point(212, 150)
        Me.mfgNameText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.mfgNameText.MaxLength = 25
        Me.mfgNameText.Name = "mfgNameText"
        Me.mfgNameText.Size = New System.Drawing.Size(158, 22)
        Me.mfgNameText.TabIndex = 10
        '
        'saleCodeLabel
        '
        Me.saleCodeLabel.AutoSize = True
        Me.saleCodeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saleCodeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.saleCodeLabel.Location = New System.Drawing.Point(6, 195)
        Me.saleCodeLabel.Name = "saleCodeLabel"
        Me.saleCodeLabel.Size = New System.Drawing.Size(70, 17)
        Me.saleCodeLabel.TabIndex = 45
        Me.saleCodeLabel.Text = "Sales Code"
        '
        'salesOrT
        '
        Me.salesOrT.AllowDrop = True
        Me.salesOrT.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesOrT.Location = New System.Drawing.Point(212, 105)
        Me.salesOrT.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.salesOrT.MaxLength = 6
        Me.salesOrT.Name = "salesOrT"
        Me.salesOrT.Size = New System.Drawing.Size(158, 22)
        Me.salesOrT.TabIndex = 9
        '
        'engrStatusLabel
        '
        Me.engrStatusLabel.AutoSize = True
        Me.engrStatusLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.engrStatusLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.engrStatusLabel.Location = New System.Drawing.Point(6, 133)
        Me.engrStatusLabel.Name = "engrStatusLabel"
        Me.engrStatusLabel.Size = New System.Drawing.Size(51, 17)
        Me.engrStatusLabel.TabIndex = 47
        Me.engrStatusLabel.Text = "Status*"
        '
        'mfgNameLabel
        '
        Me.mfgNameLabel.AutoSize = True
        Me.mfgNameLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfgNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mfgNameLabel.Location = New System.Drawing.Point(209, 130)
        Me.mfgNameLabel.Name = "mfgNameLabel"
        Me.mfgNameLabel.Size = New System.Drawing.Size(69, 17)
        Me.mfgNameLabel.TabIndex = 51
        Me.mfgNameLabel.Text = "Mfg. Name"
        '
        'invTypeLabel
        '
        Me.invTypeLabel.AutoSize = True
        Me.invTypeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invTypeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.invTypeLabel.Location = New System.Drawing.Point(6, 102)
        Me.invTypeLabel.Name = "invTypeLabel"
        Me.invTypeLabel.Size = New System.Drawing.Size(41, 17)
        Me.invTypeLabel.TabIndex = 48
        Me.invTypeLabel.Text = "Type*"
        '
        'mfgPartNumLabel
        '
        Me.mfgPartNumLabel.AutoSize = True
        Me.mfgPartNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfgPartNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mfgPartNumLabel.Location = New System.Drawing.Point(209, 175)
        Me.mfgPartNumLabel.Name = "mfgPartNumLabel"
        Me.mfgPartNumLabel.Size = New System.Drawing.Size(105, 17)
        Me.mfgPartNumLabel.TabIndex = 52
        Me.mfgPartNumLabel.Text = "Mfg. Part Number"
        '
        'engrLabel
        '
        Me.engrLabel.AutoSize = True
        Me.engrLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.engrLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.engrLabel.Location = New System.Drawing.Point(6, 164)
        Me.engrLabel.Name = "engrLabel"
        Me.engrLabel.Size = New System.Drawing.Size(64, 17)
        Me.engrLabel.TabIndex = 49
        Me.engrLabel.Text = "Engineer*"
        '
        'salesONum
        '
        Me.salesONum.AutoSize = True
        Me.salesONum.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesONum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.salesONum.Location = New System.Drawing.Point(209, 85)
        Me.salesONum.Name = "salesONum"
        Me.salesONum.Size = New System.Drawing.Size(137, 17)
        Me.salesONum.TabIndex = 54
        Me.salesONum.Text = "Sales Order / Customer"
        '
        'leadTimeLabel
        '
        Me.leadTimeLabel.AutoSize = True
        Me.leadTimeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leadTimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.leadTimeLabel.Location = New System.Drawing.Point(6, 71)
        Me.leadTimeLabel.Name = "leadTimeLabel"
        Me.leadTimeLabel.Size = New System.Drawing.Size(75, 17)
        Me.leadTimeLabel.TabIndex = 50
        Me.leadTimeLabel.Text = "Time Code*"
        '
        'mfgPrtNumText
        '
        Me.mfgPrtNumText.AllowDrop = True
        Me.mfgPrtNumText.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfgPrtNumText.Location = New System.Drawing.Point(212, 195)
        Me.mfgPrtNumText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.mfgPrtNumText.MaxLength = 25
        Me.mfgPrtNumText.Name = "mfgPrtNumText"
        Me.mfgPrtNumText.Size = New System.Drawing.Size(158, 22)
        Me.mfgPrtNumText.TabIndex = 11
        '
        'leadTimeSelect
        '
        Me.leadTimeSelect.BackColor = System.Drawing.SystemColors.Window
        Me.leadTimeSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.leadTimeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.leadTimeSelect.DropDownWidth = 200
        Me.leadTimeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.leadTimeSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leadTimeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.leadTimeSelect.FormattingEnabled = True
        Me.leadTimeSelect.Location = New System.Drawing.Point(87, 68)
        Me.leadTimeSelect.Name = "leadTimeSelect"
        Me.leadTimeSelect.Size = New System.Drawing.Size(117, 23)
        Me.leadTimeSelect.TabIndex = 2
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
        Me.salesCodeSelect.Location = New System.Drawing.Point(82, 192)
        Me.salesCodeSelect.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.salesCodeSelect.Name = "salesCodeSelect"
        Me.salesCodeSelect.Size = New System.Drawing.Size(122, 23)
        Me.salesCodeSelect.TabIndex = 6
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
        Me.engStatusSelect.Location = New System.Drawing.Point(63, 130)
        Me.engStatusSelect.Name = "engStatusSelect"
        Me.engStatusSelect.Size = New System.Drawing.Size(141, 23)
        Me.engStatusSelect.TabIndex = 4
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
        Me.invTypeSelect.Location = New System.Drawing.Point(53, 99)
        Me.invTypeSelect.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.invTypeSelect.Name = "invTypeSelect"
        Me.invTypeSelect.Size = New System.Drawing.Size(151, 23)
        Me.invTypeSelect.TabIndex = 3
        '
        'partNumberText
        '
        Me.partNumberText.BackColor = System.Drawing.SystemColors.Control
        Me.partNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.partNumberText.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.partNumberText.ForeColor = System.Drawing.Color.Red
        Me.partNumberText.Location = New System.Drawing.Point(180, 14)
        Me.partNumberText.Name = "partNumberText"
        Me.partNumberText.ReadOnly = True
        Me.partNumberText.Size = New System.Drawing.Size(175, 22)
        Me.partNumberText.TabIndex = 69
        Me.partNumberText.TabStop = False
        Me.partNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ePrtNumLabel
        '
        Me.ePrtNumLabel.AutoSize = True
        Me.ePrtNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ePrtNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ePrtNumLabel.Location = New System.Drawing.Point(58, 12)
        Me.ePrtNumLabel.Name = "ePrtNumLabel"
        Me.ePrtNumLabel.Size = New System.Drawing.Size(116, 27)
        Me.ePrtNumLabel.TabIndex = 68
        Me.ePrtNumLabel.Text = "Part Number"
        Me.ePrtNumLabel.UseCompatibleTextRendering = True
        '
        'bomBox
        '
        Me.bomBox.BackColor = System.Drawing.SystemColors.Control
        Me.bomBox.Controls.Add(Me.partBox)
        Me.bomBox.Controls.Add(Me.assemblyBox)
        Me.bomBox.Controls.Add(Me.m2kBillLabel)
        Me.bomBox.Controls.Add(Me.m2kBOMGrid)
        Me.bomBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bomBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bomBox.Location = New System.Drawing.Point(395, 12)
        Me.bomBox.Name = "bomBox"
        Me.bomBox.Size = New System.Drawing.Size(662, 423)
        Me.bomBox.TabIndex = 70
        Me.bomBox.TabStop = False
        Me.bomBox.Text = "2 - Bill Of Materials"
        '
        'partBox
        '
        Me.partBox.Controls.Add(Me.removeMatButton)
        Me.partBox.Controls.Add(Me.addMatButton)
        Me.partBox.Controls.Add(Me.customButton)
        Me.partBox.Controls.Add(Me.matSelect)
        Me.partBox.Controls.Add(Me.matNumLabel)
        Me.partBox.Controls.Add(Me.amountText)
        Me.partBox.Controls.Add(Me.amountLabel)
        Me.partBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partBox.Location = New System.Drawing.Point(6, 355)
        Me.partBox.Name = "partBox"
        Me.partBox.Size = New System.Drawing.Size(647, 61)
        Me.partBox.TabIndex = 66
        Me.partBox.TabStop = False
        Me.partBox.Text = "Part"
        '
        'removeMatButton
        '
        Me.removeMatButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeMatButton.Image = CType(resources.GetObject("removeMatButton.Image"), System.Drawing.Image)
        Me.removeMatButton.Location = New System.Drawing.Point(532, 21)
        Me.removeMatButton.Name = "removeMatButton"
        Me.removeMatButton.Size = New System.Drawing.Size(24, 23)
        Me.removeMatButton.TabIndex = 28
        Me.RemoveTT.SetToolTip(Me.removeMatButton, "This will instantly remove the selected parts from the Inventor bill of materials" &
        " to Manage 2000.")
        Me.removeMatButton.UseVisualStyleBackColor = True
        '
        'addMatButton
        '
        Me.addMatButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMatButton.Image = CType(resources.GetObject("addMatButton.Image"), System.Drawing.Image)
        Me.addMatButton.Location = New System.Drawing.Point(501, 21)
        Me.addMatButton.Name = "addMatButton"
        Me.addMatButton.Size = New System.Drawing.Size(25, 23)
        Me.addMatButton.TabIndex = 27
        Me.AddTT.SetToolTip(Me.addMatButton, "This will instantly add the selected parts from the Inventor bill of materials to" &
        " Manage 2000.")
        Me.addMatButton.UseVisualStyleBackColor = True
        '
        'customButton
        '
        Me.customButton.BackColor = System.Drawing.SystemColors.Control
        Me.customButton.FlatAppearance.BorderSize = 0
        Me.customButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.customButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.customButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.customButton.Location = New System.Drawing.Point(248, 21)
        Me.customButton.Name = "customButton"
        Me.customButton.Size = New System.Drawing.Size(67, 25)
        Me.customButton.TabIndex = 30
        Me.customButton.Text = "Custom"
        Me.customButton.UseVisualStyleBackColor = False
        '
        'matSelect
        '
        Me.matSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.matSelect.DropDownWidth = 200
        Me.matSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.matSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matSelect.FormattingEnabled = True
        Me.matSelect.Items.AddRange(New Object() {"MTL0100", "MTL0101", "MTL0102", "MTL0103", "MTL0104", "MTL0105", "MTL0110", "MTL0120", "MTL0130", "MTL0200", "MTL0201", "MTL0220", "MTL0300", "MTL0400", "MTL0420", "MTL0500", "MTL0700", "MTL0710", "MTL0720", "MTL0800"})
        Me.matSelect.Location = New System.Drawing.Point(66, 21)
        Me.matSelect.Name = "matSelect"
        Me.matSelect.Size = New System.Drawing.Size(176, 25)
        Me.matSelect.TabIndex = 25
        '
        'matNumLabel
        '
        Me.matNumLabel.AutoSize = True
        Me.matNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.matNumLabel.Location = New System.Drawing.Point(6, 25)
        Me.matNumLabel.Name = "matNumLabel"
        Me.matNumLabel.Size = New System.Drawing.Size(54, 17)
        Me.matNumLabel.TabIndex = 44
        Me.matNumLabel.Text = "Material"
        '
        'amountText
        '
        Me.amountText.AllowDrop = True
        Me.amountText.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.amountText.Location = New System.Drawing.Point(413, 22)
        Me.amountText.MaxLength = 5
        Me.amountText.Name = "amountText"
        Me.amountText.Size = New System.Drawing.Size(82, 22)
        Me.amountText.TabIndex = 26
        '
        'amountLabel
        '
        Me.amountLabel.AutoSize = True
        Me.amountLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.amountLabel.Location = New System.Drawing.Point(356, 25)
        Me.amountLabel.Name = "amountLabel"
        Me.amountLabel.Size = New System.Drawing.Size(51, 17)
        Me.amountLabel.TabIndex = 43
        Me.amountLabel.Text = "Amount"
        '
        'assemblyBox
        '
        Me.assemblyBox.Controls.Add(Me.removeBillButton)
        Me.assemblyBox.Controls.Add(Me.addBillButton)
        Me.assemblyBox.Controls.Add(Me.invBOMGrid)
        Me.assemblyBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assemblyBox.Location = New System.Drawing.Point(6, 21)
        Me.assemblyBox.Name = "assemblyBox"
        Me.assemblyBox.Size = New System.Drawing.Size(353, 328)
        Me.assemblyBox.TabIndex = 65
        Me.assemblyBox.TabStop = False
        Me.assemblyBox.Text = "Assembly"
        '
        'removeBillButton
        '
        Me.removeBillButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeBillButton.Image = CType(resources.GetObject("removeBillButton.Image"), System.Drawing.Image)
        Me.removeBillButton.Location = New System.Drawing.Point(321, 174)
        Me.removeBillButton.Name = "removeBillButton"
        Me.removeBillButton.Size = New System.Drawing.Size(24, 23)
        Me.removeBillButton.TabIndex = 23
        Me.RemoveTT.SetToolTip(Me.removeBillButton, "This will instantly remove the selected parts from the Inventor bill of materials" &
        " to Manage 2000.")
        Me.removeBillButton.UseVisualStyleBackColor = True
        '
        'addBillButton
        '
        Me.addBillButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBillButton.Image = CType(resources.GetObject("addBillButton.Image"), System.Drawing.Image)
        Me.addBillButton.Location = New System.Drawing.Point(321, 145)
        Me.addBillButton.Name = "addBillButton"
        Me.addBillButton.Size = New System.Drawing.Size(24, 23)
        Me.addBillButton.TabIndex = 22
        Me.AddTT.SetToolTip(Me.addBillButton, "This will instantly add the selected parts from the Inventor bill of materials to" &
        " Manage 2000.")
        Me.addBillButton.UseVisualStyleBackColor = True
        '
        'invBOMGrid
        '
        Me.invBOMGrid.AllowUserToDeleteRows = False
        Me.invBOMGrid.AllowUserToResizeRows = False
        Me.invBOMGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.invBOMGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.invBOMGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.invBOMGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prtNum, Me.qty, Me.invBillSelect})
        Me.invBOMGrid.ContextMenuStrip = Me.InvGridViewSelects
        Me.invBOMGrid.Location = New System.Drawing.Point(6, 21)
        Me.invBOMGrid.Name = "invBOMGrid"
        Me.invBOMGrid.Size = New System.Drawing.Size(309, 300)
        Me.invBOMGrid.TabIndex = 46
        '
        'prtNum
        '
        Me.prtNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prtNum.FillWeight = 15.87302!
        Me.prtNum.HeaderText = "Part Number"
        Me.prtNum.Name = "prtNum"
        '
        'qty
        '
        Me.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.qty.HeaderText = "Quantity"
        Me.qty.Name = "qty"
        Me.qty.Width = 78
        '
        'invBillSelect
        '
        Me.invBillSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invBillSelect.HeaderText = ""
        Me.invBillSelect.Name = "invBillSelect"
        Me.invBillSelect.Width = 21
        '
        'InvGridViewSelects
        '
        Me.InvGridViewSelects.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvSelectAll, Me.InvDeselectAll})
        Me.InvGridViewSelects.Name = "InvGridViewSelects"
        Me.InvGridViewSelects.Size = New System.Drawing.Size(136, 48)
        '
        'InvSelectAll
        '
        Me.InvSelectAll.Name = "InvSelectAll"
        Me.InvSelectAll.Size = New System.Drawing.Size(135, 22)
        Me.InvSelectAll.Text = "Select All"
        '
        'InvDeselectAll
        '
        Me.InvDeselectAll.Name = "InvDeselectAll"
        Me.InvDeselectAll.Size = New System.Drawing.Size(135, 22)
        Me.InvDeselectAll.Text = "Deselect All"
        '
        'm2kBillLabel
        '
        Me.m2kBillLabel.AutoSize = True
        Me.m2kBillLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.m2kBillLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.m2kBillLabel.Location = New System.Drawing.Point(437, 18)
        Me.m2kBillLabel.Name = "m2kBillLabel"
        Me.m2kBillLabel.Size = New System.Drawing.Size(149, 21)
        Me.m2kBillLabel.TabIndex = 49
        Me.m2kBillLabel.Text = "M2k Bill of Materials"
        '
        'm2kBOMGrid
        '
        Me.m2kBOMGrid.AllowUserToAddRows = False
        Me.m2kBOMGrid.AllowUserToDeleteRows = False
        Me.m2kBOMGrid.AllowUserToResizeRows = False
        Me.m2kBOMGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.m2kBOMGrid.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.m2kBOMGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.m2kBOMGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.m2kBOMGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.m2kBillSelect})
        Me.m2kBOMGrid.ContextMenuStrip = Me.M2kGridViewSelects
        Me.m2kBOMGrid.Location = New System.Drawing.Point(365, 42)
        Me.m2kBOMGrid.Name = "m2kBOMGrid"
        Me.m2kBOMGrid.Size = New System.Drawing.Size(288, 300)
        Me.m2kBOMGrid.TabIndex = 47
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.FillWeight = 15.87302!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Part Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 78
        '
        'm2kBillSelect
        '
        Me.m2kBillSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.m2kBillSelect.HeaderText = ""
        Me.m2kBillSelect.Name = "m2kBillSelect"
        Me.m2kBillSelect.Width = 5
        '
        'M2kGridViewSelects
        '
        Me.M2kGridViewSelects.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M2kSelectAll, Me.M2kDeselectAll})
        Me.M2kGridViewSelects.Name = "GridViewSelects"
        Me.M2kGridViewSelects.Size = New System.Drawing.Size(136, 48)
        '
        'M2kSelectAll
        '
        Me.M2kSelectAll.Name = "M2kSelectAll"
        Me.M2kSelectAll.Size = New System.Drawing.Size(135, 22)
        Me.M2kSelectAll.Text = "Select All"
        '
        'M2kDeselectAll
        '
        Me.M2kDeselectAll.Name = "M2kDeselectAll"
        Me.M2kDeselectAll.Size = New System.Drawing.Size(135, 22)
        Me.M2kDeselectAll.Text = "Deselect All"
        '
        'routBox
        '
        Me.routBox.BackColor = System.Drawing.SystemColors.Control
        Me.routBox.Controls.Add(Me.removeRoutButton)
        Me.routBox.Controls.Add(Me.PresetBox)
        Me.routBox.Controls.Add(Me.addRoutButton)
        Me.routBox.Controls.Add(Me.routTable)
        Me.routBox.Controls.Add(Me.wsSelect)
        Me.routBox.Controls.Add(Me.wCLabel)
        Me.routBox.Controls.Add(Me.crewText)
        Me.routBox.Controls.Add(Me.laborText)
        Me.routBox.Controls.Add(Me.lHourLabel)
        Me.routBox.Controls.Add(Me.seqSelect)
        Me.routBox.Controls.Add(Me.routDesc)
        Me.routBox.Controls.Add(Me.Label1)
        Me.routBox.Controls.Add(Me.seqLabel)
        Me.routBox.Controls.Add(Me.crewLabel)
        Me.routBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.routBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.routBox.Location = New System.Drawing.Point(12, 441)
        Me.routBox.Name = "routBox"
        Me.routBox.Size = New System.Drawing.Size(1045, 150)
        Me.routBox.TabIndex = 71
        Me.routBox.TabStop = False
        Me.routBox.Text = "3 - Routings"
        '
        'removeRoutButton
        '
        Me.removeRoutButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeRoutButton.Image = CType(resources.GetObject("removeRoutButton.Image"), System.Drawing.Image)
        Me.removeRoutButton.Location = New System.Drawing.Point(407, 85)
        Me.removeRoutButton.Name = "removeRoutButton"
        Me.removeRoutButton.Size = New System.Drawing.Size(26, 23)
        Me.removeRoutButton.TabIndex = 37
        Me.RemoveTT.SetToolTip(Me.removeRoutButton, "This will instantly remove the selected routing from Manage 2000.")
        Me.removeRoutButton.UseVisualStyleBackColor = True
        '
        'PresetBox
        '
        Me.PresetBox.Controls.Add(Me.TapButton)
        Me.PresetBox.Controls.Add(Me.CutButton)
        Me.PresetBox.Controls.Add(Me.RoundButton)
        Me.PresetBox.Controls.Add(Me.AssembleButton)
        Me.PresetBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresetBox.Location = New System.Drawing.Point(8, 16)
        Me.PresetBox.Name = "PresetBox"
        Me.PresetBox.Size = New System.Drawing.Size(101, 128)
        Me.PresetBox.TabIndex = 42
        Me.PresetBox.TabStop = False
        Me.PresetBox.Text = "Presets"
        '
        'TapButton
        '
        Me.TapButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TapButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TapButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.TapButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TapButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TapButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TapButton.Location = New System.Drawing.Point(6, 72)
        Me.TapButton.Name = "TapButton"
        Me.TapButton.Size = New System.Drawing.Size(87, 22)
        Me.TapButton.TabIndex = 41
        Me.TapButton.Text = "Tap"
        Me.TapButton.UseVisualStyleBackColor = False
        '
        'CutButton
        '
        Me.CutButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CutButton.Location = New System.Drawing.Point(6, 19)
        Me.CutButton.Name = "CutButton"
        Me.CutButton.Size = New System.Drawing.Size(87, 22)
        Me.CutButton.TabIndex = 39
        Me.CutButton.Text = "Cut"
        Me.CutButton.UseVisualStyleBackColor = False
        '
        'RoundButton
        '
        Me.RoundButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RoundButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RoundButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.RoundButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RoundButton.Location = New System.Drawing.Point(6, 47)
        Me.RoundButton.Name = "RoundButton"
        Me.RoundButton.Size = New System.Drawing.Size(87, 22)
        Me.RoundButton.TabIndex = 40
        Me.RoundButton.Text = "Round"
        Me.RoundButton.UseVisualStyleBackColor = False
        '
        'AssembleButton
        '
        Me.AssembleButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AssembleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AssembleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.AssembleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AssembleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssembleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssembleButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AssembleButton.Location = New System.Drawing.Point(6, 100)
        Me.AssembleButton.Name = "AssembleButton"
        Me.AssembleButton.Size = New System.Drawing.Size(87, 22)
        Me.AssembleButton.TabIndex = 42
        Me.AssembleButton.Text = "Assemble"
        Me.AssembleButton.UseVisualStyleBackColor = False
        '
        'addRoutButton
        '
        Me.addRoutButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addRoutButton.Image = CType(resources.GetObject("addRoutButton.Image"), System.Drawing.Image)
        Me.addRoutButton.Location = New System.Drawing.Point(407, 57)
        Me.addRoutButton.Name = "addRoutButton"
        Me.addRoutButton.Size = New System.Drawing.Size(26, 23)
        Me.addRoutButton.TabIndex = 36
        Me.AddTT.SetToolTip(Me.addRoutButton, "This will instantly add the created routing to Manage 2000.")
        Me.addRoutButton.UseVisualStyleBackColor = True
        '
        'routTable
        '
        Me.routTable.AllowUserToAddRows = False
        Me.routTable.AllowUserToResizeRows = False
        Me.routTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.routTable.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.routTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.routTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.routTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seq, Me.wCenter, Me.crew, Me.hours, Me.rDesc, Me.m2kRoutSelect})
        Me.routTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.routTable.Location = New System.Drawing.Point(439, 21)
        Me.routTable.Name = "routTable"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.routTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.routTable.Size = New System.Drawing.Size(597, 119)
        Me.routTable.TabIndex = 39
        '
        'seq
        '
        Me.seq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.seq.FillWeight = 163.5402!
        Me.seq.HeaderText = "Seq"
        Me.seq.MinimumWidth = 50
        Me.seq.Name = "seq"
        Me.seq.ReadOnly = True
        Me.seq.Width = 54
        '
        'wCenter
        '
        Me.wCenter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.wCenter.HeaderText = "WC"
        Me.wCenter.MinimumWidth = 50
        Me.wCenter.Name = "wCenter"
        Me.wCenter.ReadOnly = True
        Me.wCenter.Width = 52
        '
        'crew
        '
        Me.crew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.crew.HeaderText = "Crew"
        Me.crew.MinimumWidth = 50
        Me.crew.Name = "crew"
        Me.crew.ReadOnly = True
        Me.crew.Width = 61
        '
        'hours
        '
        Me.hours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.hours.FillWeight = 26.16643!
        Me.hours.HeaderText = "Hours"
        Me.hours.MinimumWidth = 50
        Me.hours.Name = "hours"
        Me.hours.ReadOnly = True
        Me.hours.Width = 65
        '
        'rDesc
        '
        Me.rDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.rDesc.FillWeight = 26.16643!
        Me.rDesc.HeaderText = "Description"
        Me.rDesc.MinimumWidth = 50
        Me.rDesc.Name = "rDesc"
        Me.rDesc.ReadOnly = True
        '
        'm2kRoutSelect
        '
        Me.m2kRoutSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.m2kRoutSelect.HeaderText = ""
        Me.m2kRoutSelect.Name = "m2kRoutSelect"
        Me.m2kRoutSelect.Width = 5
        '
        'wsSelect
        '
        Me.wsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.wsSelect.DropDownWidth = 125
        Me.wsSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.wsSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wsSelect.FormattingEnabled = True
        Me.wsSelect.Location = New System.Drawing.Point(202, 54)
        Me.wsSelect.Name = "wsSelect"
        Me.wsSelect.Size = New System.Drawing.Size(80, 25)
        Me.wsSelect.TabIndex = 32
        '
        'wCLabel
        '
        Me.wCLabel.AutoSize = True
        Me.wCLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wCLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.wCLabel.Location = New System.Drawing.Point(115, 57)
        Me.wCLabel.Name = "wCLabel"
        Me.wCLabel.Size = New System.Drawing.Size(77, 17)
        Me.wCLabel.TabIndex = 38
        Me.wCLabel.Text = "Work Center"
        '
        'crewText
        '
        Me.crewText.AllowDrop = True
        Me.crewText.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crewText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.crewText.Location = New System.Drawing.Point(334, 21)
        Me.crewText.MaxLength = 2
        Me.crewText.Name = "crewText"
        Me.crewText.Size = New System.Drawing.Size(67, 22)
        Me.crewText.TabIndex = 33
        '
        'laborText
        '
        Me.laborText.AllowDrop = True
        Me.laborText.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laborText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.laborText.Location = New System.Drawing.Point(334, 54)
        Me.laborText.MaxLength = 10
        Me.laborText.Name = "laborText"
        Me.laborText.Size = New System.Drawing.Size(67, 22)
        Me.laborText.TabIndex = 34
        '
        'lHourLabel
        '
        Me.lHourLabel.AutoSize = True
        Me.lHourLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lHourLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lHourLabel.Location = New System.Drawing.Point(288, 57)
        Me.lHourLabel.Name = "lHourLabel"
        Me.lHourLabel.Size = New System.Drawing.Size(40, 17)
        Me.lHourLabel.TabIndex = 37
        Me.lHourLabel.Text = "Hours"
        '
        'seqSelect
        '
        Me.seqSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seqSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seqSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seqSelect.FormattingEnabled = True
        Me.seqSelect.Items.AddRange(New Object() {"10", "20", "30", "40", "5", "50", "60", "70"})
        Me.seqSelect.Location = New System.Drawing.Point(202, 21)
        Me.seqSelect.Name = "seqSelect"
        Me.seqSelect.Size = New System.Drawing.Size(80, 25)
        Me.seqSelect.Sorted = True
        Me.seqSelect.TabIndex = 31
        '
        'routDesc
        '
        Me.routDesc.AllowDrop = True
        Me.routDesc.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.routDesc.Location = New System.Drawing.Point(118, 115)
        Me.routDesc.MaxLength = 50
        Me.routDesc.Name = "routDesc"
        Me.routDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.routDesc.Size = New System.Drawing.Size(283, 22)
        Me.routDesc.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(115, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Routing Description"
        '
        'seqLabel
        '
        Me.seqLabel.AutoSize = True
        Me.seqLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seqLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.seqLabel.Location = New System.Drawing.Point(115, 24)
        Me.seqLabel.Name = "seqLabel"
        Me.seqLabel.Size = New System.Drawing.Size(63, 17)
        Me.seqLabel.TabIndex = 35
        Me.seqLabel.Text = "Sequence"
        '
        'crewLabel
        '
        Me.crewLabel.AutoSize = True
        Me.crewLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crewLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.crewLabel.Location = New System.Drawing.Point(288, 24)
        Me.crewLabel.Name = "crewLabel"
        Me.crewLabel.Size = New System.Drawing.Size(36, 17)
        Me.crewLabel.TabIndex = 34
        Me.crewLabel.Text = "Crew"
        '
        'Close_Button
        '
        Me.Close_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Close_Button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose
        Me.Close_Button.FlatAppearance.BorderSize = 0
        Me.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Close_Button.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Close_Button.Location = New System.Drawing.Point(921, 597)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(136, 22)
        Me.Close_Button.TabIndex = 21
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = False
        '
        'pullsqlButton
        '
        Me.pullsqlButton.BackColor = System.Drawing.SystemColors.Control
        Me.pullsqlButton.FlatAppearance.BorderSize = 0
        Me.pullsqlButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.pullsqlButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pullsqlButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pullsqlButton.Location = New System.Drawing.Point(779, 597)
        Me.pullsqlButton.Name = "pullsqlButton"
        Me.pullsqlButton.Size = New System.Drawing.Size(136, 22)
        Me.pullsqlButton.TabIndex = 20
        Me.pullsqlButton.Text = "Refresh Info"
        Me.RefreshInfoTT.SetToolTip(Me.pullsqlButton, "This will reload the most recent data from Manage 2000 into the BOM and ROUT.")
        Me.pullsqlButton.UseVisualStyleBackColor = False
        '
        'saveLocalButton
        '
        Me.saveLocalButton.BackColor = System.Drawing.SystemColors.Control
        Me.saveLocalButton.FlatAppearance.BorderSize = 0
        Me.saveLocalButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.saveLocalButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveLocalButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.saveLocalButton.Location = New System.Drawing.Point(637, 597)
        Me.saveLocalButton.Name = "saveLocalButton"
        Me.saveLocalButton.Size = New System.Drawing.Size(136, 22)
        Me.saveLocalButton.TabIndex = 19
        Me.saveLocalButton.Text = "Save Local"
        Me.SaveLocalTT.SetToolTip(Me.saveLocalButton, "This will save all Item Master information locally.")
        Me.saveLocalButton.UseVisualStyleBackColor = False
        '
        'SaveLocalTT
        '
        Me.SaveLocalTT.ToolTipTitle = "Save Local"
        '
        'UploadItemMasterTT
        '
        Me.UploadItemMasterTT.ToolTipTitle = "Upload"
        '
        'RefreshInfoTT
        '
        Me.RefreshInfoTT.ToolTipTitle = "Refresh Info"
        '
        'AddTT
        '
        Me.AddTT.ToolTipTitle = "Add Info"
        '
        'RemoveTT
        '
        Me.RemoveTT.ToolTipTitle = "Remove Info"
        '
        'ERPpane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1065, 625)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.routBox)
        Me.Controls.Add(Me.saveLocalButton)
        Me.Controls.Add(Me.pullsqlButton)
        Me.Controls.Add(Me.bomBox)
        Me.Controls.Add(Me.partNumberText)
        Me.Controls.Add(Me.ePrtNumLabel)
        Me.Controls.Add(Me.itemMasterBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ERPpane"
        Me.Text = "Inventor's Manage 2000"
        Me.itemMasterBox.ResumeLayout(False)
        Me.itemMasterBox.PerformLayout()
        Me.bomBox.ResumeLayout(False)
        Me.bomBox.PerformLayout()
        Me.partBox.ResumeLayout(False)
        Me.partBox.PerformLayout()
        Me.assemblyBox.ResumeLayout(False)
        CType(Me.invBOMGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvGridViewSelects.ResumeLayout(False)
        CType(Me.m2kBOMGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.M2kGridViewSelects.ResumeLayout(False)
        Me.routBox.ResumeLayout(False)
        Me.routBox.PerformLayout()
        Me.PresetBox.ResumeLayout(False)
        CType(Me.routTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents itemMasterBox As Windows.Forms.GroupBox
    Friend WithEvents sDescriptionLabel As Windows.Forms.Label
    Friend WithEvents UoMLabel As Windows.Forms.Label
    Friend WithEvents descriptionText As Windows.Forms.TextBox
    Friend WithEvents engineerText As Windows.Forms.ComboBox
    Friend WithEvents eDescripLabel As Windows.Forms.Label
    Friend WithEvents salesOrT As Windows.Forms.TextBox
    Friend WithEvents extDesc1 As Windows.Forms.TextBox
    Friend WithEvents salesONum As Windows.Forms.Label
    Friend WithEvents saleCodeLabel As Windows.Forms.Label
    Friend WithEvents engrStatusLabel As Windows.Forms.Label
    Friend WithEvents invTypeLabel As Windows.Forms.Label
    Friend WithEvents mfgPrtNumText As Windows.Forms.TextBox
    Friend WithEvents engrLabel As Windows.Forms.Label
    Friend WithEvents mfgPartNumLabel As Windows.Forms.Label
    Friend WithEvents leadTimeLabel As Windows.Forms.Label
    Friend WithEvents leadTimeSelect As Windows.Forms.ComboBox
    Friend WithEvents mfgNameLabel As Windows.Forms.Label
    Friend WithEvents salesCodeSelect As Windows.Forms.ComboBox
    Friend WithEvents mfgNameText As Windows.Forms.TextBox
    Friend WithEvents engStatusSelect As Windows.Forms.ComboBox
    Friend WithEvents uomSelect As Windows.Forms.ComboBox
    Friend WithEvents invTypeSelect As Windows.Forms.ComboBox
    Friend WithEvents extDesc5 As Windows.Forms.TextBox
    Friend WithEvents extDesc4 As Windows.Forms.TextBox
    Friend WithEvents extDesc3 As Windows.Forms.TextBox
    Friend WithEvents extDesc2 As Windows.Forms.TextBox
    Friend WithEvents partNumberText As Windows.Forms.TextBox
    Friend WithEvents ePrtNumLabel As Windows.Forms.Label
    Friend WithEvents PurchasedStandard As Windows.Forms.Button
    Friend WithEvents ManufacturedStandard As Windows.Forms.Button
    Friend WithEvents bomBox As Windows.Forms.GroupBox
    Friend WithEvents partBox As Windows.Forms.GroupBox
    Friend WithEvents removeMatButton As Windows.Forms.Button
    Friend WithEvents addMatButton As Windows.Forms.Button
    Friend WithEvents customButton As Windows.Forms.Button
    Friend WithEvents matSelect As Windows.Forms.ComboBox
    Friend WithEvents matNumLabel As Windows.Forms.Label
    Friend WithEvents amountText As Windows.Forms.TextBox
    Friend WithEvents amountLabel As Windows.Forms.Label
    Friend WithEvents assemblyBox As Windows.Forms.GroupBox
    Friend WithEvents removeBillButton As Windows.Forms.Button
    Friend WithEvents addBillButton As Windows.Forms.Button
    Friend WithEvents invBOMGrid As Windows.Forms.DataGridView
    Friend WithEvents prtNum As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invBillSelect As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents m2kBillLabel As Windows.Forms.Label
    Friend WithEvents m2kBOMGrid As Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents m2kBillSelect As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents routBox As Windows.Forms.GroupBox
    Friend WithEvents removeRoutButton As Windows.Forms.Button
    Friend WithEvents addRoutButton As Windows.Forms.Button
    Friend WithEvents routTable As Windows.Forms.DataGridView
    Friend WithEvents seq As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wCenter As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crew As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hours As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rDesc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents m2kRoutSelect As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents wsSelect As Windows.Forms.ComboBox
    Friend WithEvents wCLabel As Windows.Forms.Label
    Friend WithEvents crewText As Windows.Forms.TextBox
    Friend WithEvents laborText As Windows.Forms.TextBox
    Friend WithEvents lHourLabel As Windows.Forms.Label
    Friend WithEvents seqSelect As Windows.Forms.ComboBox
    Friend WithEvents routDesc As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents seqLabel As Windows.Forms.Label
    Friend WithEvents crewLabel As Windows.Forms.Label
    Friend WithEvents Close_Button As Windows.Forms.Button
    Friend WithEvents pullsqlButton As Windows.Forms.Button
    Friend WithEvents uploadIMButton As Windows.Forms.Button
    Friend WithEvents saveLocalButton As Windows.Forms.Button
    Friend WithEvents PresetBox As Windows.Forms.GroupBox
    Friend WithEvents TapButton As Windows.Forms.Button
    Friend WithEvents CutButton As Windows.Forms.Button
    Friend WithEvents RoundButton As Windows.Forms.Button
    Friend WithEvents AssembleButton As Windows.Forms.Button
    Friend WithEvents UploadItemMasterTT As Windows.Forms.ToolTip
    Friend WithEvents RemoveTT As Windows.Forms.ToolTip
    Friend WithEvents AddTT As Windows.Forms.ToolTip
    Friend WithEvents RefreshInfoTT As Windows.Forms.ToolTip
    Friend WithEvents SaveLocalTT As Windows.Forms.ToolTip
    Friend WithEvents InvGridViewSelects As Windows.Forms.ContextMenuStrip
    Friend WithEvents InvSelectAll As Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvDeselectAll As Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2kGridViewSelects As Windows.Forms.ContextMenuStrip
    Friend WithEvents M2kSelectAll As Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2kDeselectAll As Windows.Forms.ToolStripMenuItem
End Class
