<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllInOne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllInOne))
        Me.purchasedStandard = New System.Windows.Forms.Button()
        Me.manufacturedStandard = New System.Windows.Forms.Button()
        Me.impLogo = New System.Windows.Forms.PictureBox()
        Me.partNumberText = New System.Windows.Forms.TextBox()
        Me.ePrtNumLabel = New System.Windows.Forms.Label()
        Me.engineerText = New System.Windows.Forms.ComboBox()
        Me.salesOrT = New System.Windows.Forms.TextBox()
        Me.salesONum = New System.Windows.Forms.Label()
        Me.companyT = New System.Windows.Forms.TextBox()
        Me.customerL = New System.Windows.Forms.Label()
        Me.mfgPrtNumText = New System.Windows.Forms.TextBox()
        Me.mfgPartNumLabel = New System.Windows.Forms.Label()
        Me.leadTimeSelect = New System.Windows.Forms.ComboBox()
        Me.salesCodeSelect = New System.Windows.Forms.ComboBox()
        Me.engStatusSelect = New System.Windows.Forms.ComboBox()
        Me.invTypeSelect = New System.Windows.Forms.ComboBox()
        Me.uomSelect = New System.Windows.Forms.ComboBox()
        Me.mfgNameText = New System.Windows.Forms.TextBox()
        Me.mfgNameLabel = New System.Windows.Forms.Label()
        Me.leadTimeLabel = New System.Windows.Forms.Label()
        Me.engrLabel = New System.Windows.Forms.Label()
        Me.invTypeLabel = New System.Windows.Forms.Label()
        Me.engrStatusLabel = New System.Windows.Forms.Label()
        Me.saleCodeLabel = New System.Windows.Forms.Label()
        Me.descriptionText = New System.Windows.Forms.TextBox()
        Me.eDescripLabel = New System.Windows.Forms.Label()
        Me.sDescriptionText = New System.Windows.Forms.TextBox()
        Me.sDescriptionLabel = New System.Windows.Forms.Label()
        Me.UoMLabel = New System.Windows.Forms.Label()
        Me.routBox = New System.Windows.Forms.GroupBox()
        Me.ActionBox = New System.Windows.Forms.GroupBox()
        Me.refreshRoutButton = New System.Windows.Forms.Button()
        Me.removeRoutButton = New System.Windows.Forms.Button()
        Me.addRoutButton = New System.Windows.Forms.Button()
        Me.PresetBox = New System.Windows.Forms.GroupBox()
        Me.atpButton = New System.Windows.Forms.Button()
        Me.crtButton = New System.Windows.Forms.Button()
        Me.ccButton = New System.Windows.Forms.Button()
        Me.crbButton = New System.Windows.Forms.Button()
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
        Me.bomBox = New System.Windows.Forms.GroupBox()
        Me.partBox = New System.Windows.Forms.GroupBox()
        Me.refreshMatButton = New System.Windows.Forms.Button()
        Me.removeMatButton = New System.Windows.Forms.Button()
        Me.addMatButton = New System.Windows.Forms.Button()
        Me.customButton = New System.Windows.Forms.Button()
        Me.matSelect = New System.Windows.Forms.ComboBox()
        Me.matNumLabel = New System.Windows.Forms.Label()
        Me.amountText = New System.Windows.Forms.TextBox()
        Me.amountLabel = New System.Windows.Forms.Label()
        Me.assemblyBox = New System.Windows.Forms.GroupBox()
        Me.refreshBillButton = New System.Windows.Forms.Button()
        Me.removeBillButton = New System.Windows.Forms.Button()
        Me.addBillButton = New System.Windows.Forms.Button()
        Me.invBillLabel = New System.Windows.Forms.Label()
        Me.invBOMGrid = New System.Windows.Forms.DataGridView()
        Me.prtNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invBillSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.m2kBillLabel = New System.Windows.Forms.Label()
        Me.m2kBOMGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m2kBillSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.itemMasterBox = New System.Windows.Forms.GroupBox()
        Me.finalBox = New System.Windows.Forms.GroupBox()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.pullIMsqlButton = New System.Windows.Forms.Button()
        Me.uploadIMButton = New System.Windows.Forms.Button()
        Me.saveLocalButton = New System.Windows.Forms.Button()
        Me.uploadAllButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusLable = New System.Windows.Forms.ToolStripStatusLabel()
        Me.infoProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        CType(Me.impLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.routBox.SuspendLayout()
        Me.ActionBox.SuspendLayout()
        Me.PresetBox.SuspendLayout()
        CType(Me.routTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bomBox.SuspendLayout()
        Me.partBox.SuspendLayout()
        Me.assemblyBox.SuspendLayout()
        CType(Me.invBOMGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m2kBOMGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.itemMasterBox.SuspendLayout()
        Me.finalBox.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'purchasedStandard
        '
        Me.purchasedStandard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.purchasedStandard.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.purchasedStandard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.purchasedStandard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.purchasedStandard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.purchasedStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.purchasedStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchasedStandard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.purchasedStandard.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.purchasedStandard.Location = New System.Drawing.Point(271, 14)
        Me.purchasedStandard.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.purchasedStandard.Name = "purchasedStandard"
        Me.purchasedStandard.Size = New System.Drawing.Size(101, 22)
        Me.purchasedStandard.TabIndex = 25
        Me.purchasedStandard.Text = "Purchased"
        Me.purchasedStandard.UseVisualStyleBackColor = False
        '
        'manufacturedStandard
        '
        Me.manufacturedStandard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.manufacturedStandard.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.manufacturedStandard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.manufacturedStandard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.manufacturedStandard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.manufacturedStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manufacturedStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manufacturedStandard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.manufacturedStandard.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.manufacturedStandard.Location = New System.Drawing.Point(164, 14)
        Me.manufacturedStandard.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.manufacturedStandard.Name = "manufacturedStandard"
        Me.manufacturedStandard.Size = New System.Drawing.Size(101, 22)
        Me.manufacturedStandard.TabIndex = 26
        Me.manufacturedStandard.Text = "Manufactured"
        Me.manufacturedStandard.UseVisualStyleBackColor = False
        '
        'impLogo
        '
        Me.impLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.impLogo.Location = New System.Drawing.Point(12, 12)
        Me.impLogo.Name = "impLogo"
        Me.impLogo.Size = New System.Drawing.Size(64, 64)
        Me.impLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.impLogo.TabIndex = 27
        Me.impLogo.TabStop = False
        '
        'partNumberText
        '
        Me.partNumberText.BackColor = System.Drawing.SystemColors.Control
        Me.partNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.partNumberText.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.partNumberText.ForeColor = System.Drawing.Color.Red
        Me.partNumberText.Location = New System.Drawing.Point(204, 33)
        Me.partNumberText.Name = "partNumberText"
        Me.partNumberText.ReadOnly = True
        Me.partNumberText.Size = New System.Drawing.Size(175, 22)
        Me.partNumberText.TabIndex = 24
        Me.partNumberText.TabStop = False
        Me.partNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ePrtNumLabel
        '
        Me.ePrtNumLabel.AutoSize = True
        Me.ePrtNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ePrtNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ePrtNumLabel.Location = New System.Drawing.Point(82, 33)
        Me.ePrtNumLabel.Name = "ePrtNumLabel"
        Me.ePrtNumLabel.Size = New System.Drawing.Size(116, 27)
        Me.ePrtNumLabel.TabIndex = 23
        Me.ePrtNumLabel.Text = "Part Number"
        Me.ePrtNumLabel.UseCompatibleTextRendering = True
        '
        'engineerText
        '
        Me.engineerText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.engineerText.BackColor = System.Drawing.SystemColors.Window
        Me.engineerText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.engineerText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.engineerText.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.engineerText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.engineerText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.engineerText.FormattingEnabled = True
        Me.engineerText.Location = New System.Drawing.Point(285, 144)
        Me.engineerText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.engineerText.Name = "engineerText"
        Me.engineerText.Size = New System.Drawing.Size(87, 29)
        Me.engineerText.TabIndex = 43
        '
        'salesOrT
        '
        Me.salesOrT.AllowDrop = True
        Me.salesOrT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.salesOrT.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.salesOrT.Location = New System.Drawing.Point(294, 179)
        Me.salesOrT.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.salesOrT.MaxLength = 6
        Me.salesOrT.Name = "salesOrT"
        Me.salesOrT.Size = New System.Drawing.Size(78, 26)
        Me.salesOrT.TabIndex = 41
        '
        'salesONum
        '
        Me.salesONum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.salesONum.AutoSize = True
        Me.salesONum.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.salesONum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.salesONum.Location = New System.Drawing.Point(250, 182)
        Me.salesONum.Name = "salesONum"
        Me.salesONum.Size = New System.Drawing.Size(38, 21)
        Me.salesONum.TabIndex = 54
        Me.salesONum.Text = "SO#"
        '
        'companyT
        '
        Me.companyT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.companyT.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.companyT.Location = New System.Drawing.Point(84, 179)
        Me.companyT.Name = "companyT"
        Me.companyT.Size = New System.Drawing.Size(162, 26)
        Me.companyT.TabIndex = 40
        '
        'customerL
        '
        Me.customerL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.customerL.AutoSize = True
        Me.customerL.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.customerL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.customerL.Location = New System.Drawing.Point(4, 182)
        Me.customerL.Name = "customerL"
        Me.customerL.Size = New System.Drawing.Size(74, 21)
        Me.customerL.TabIndex = 53
        Me.customerL.Text = "Customer"
        '
        'mfgPrtNumText
        '
        Me.mfgPrtNumText.AllowDrop = True
        Me.mfgPrtNumText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mfgPrtNumText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.mfgPrtNumText.Location = New System.Drawing.Point(140, 243)
        Me.mfgPrtNumText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.mfgPrtNumText.MaxLength = 25
        Me.mfgPrtNumText.Name = "mfgPrtNumText"
        Me.mfgPrtNumText.Size = New System.Drawing.Size(232, 26)
        Me.mfgPrtNumText.TabIndex = 46
        '
        'mfgPartNumLabel
        '
        Me.mfgPartNumLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mfgPartNumLabel.AutoSize = True
        Me.mfgPartNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.mfgPartNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mfgPartNumLabel.Location = New System.Drawing.Point(4, 246)
        Me.mfgPartNumLabel.Name = "mfgPartNumLabel"
        Me.mfgPartNumLabel.Size = New System.Drawing.Size(130, 21)
        Me.mfgPartNumLabel.TabIndex = 52
        Me.mfgPartNumLabel.Text = "Mfg. Part Number"
        '
        'leadTimeSelect
        '
        Me.leadTimeSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.leadTimeSelect.BackColor = System.Drawing.SystemColors.Window
        Me.leadTimeSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.leadTimeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.leadTimeSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.leadTimeSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.leadTimeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.leadTimeSelect.FormattingEnabled = True
        Me.leadTimeSelect.Location = New System.Drawing.Point(137, 144)
        Me.leadTimeSelect.Name = "leadTimeSelect"
        Me.leadTimeSelect.Size = New System.Drawing.Size(57, 29)
        Me.leadTimeSelect.TabIndex = 38
        '
        'salesCodeSelect
        '
        Me.salesCodeSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.salesCodeSelect.BackColor = System.Drawing.SystemColors.Window
        Me.salesCodeSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.salesCodeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.salesCodeSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.salesCodeSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.salesCodeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.salesCodeSelect.FormattingEnabled = True
        Me.salesCodeSelect.Location = New System.Drawing.Point(290, 109)
        Me.salesCodeSelect.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.salesCodeSelect.Name = "salesCodeSelect"
        Me.salesCodeSelect.Size = New System.Drawing.Size(82, 29)
        Me.salesCodeSelect.TabIndex = 37
        '
        'engStatusSelect
        '
        Me.engStatusSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.engStatusSelect.BackColor = System.Drawing.SystemColors.Window
        Me.engStatusSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.engStatusSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.engStatusSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.engStatusSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.engStatusSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.engStatusSelect.FormattingEnabled = True
        Me.engStatusSelect.Location = New System.Drawing.Point(107, 109)
        Me.engStatusSelect.Name = "engStatusSelect"
        Me.engStatusSelect.Size = New System.Drawing.Size(87, 29)
        Me.engStatusSelect.TabIndex = 35
        '
        'invTypeSelect
        '
        Me.invTypeSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.invTypeSelect.BackColor = System.Drawing.SystemColors.Window
        Me.invTypeSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.invTypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.invTypeSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.invTypeSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.invTypeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.invTypeSelect.FormattingEnabled = True
        Me.invTypeSelect.Location = New System.Drawing.Point(323, 74)
        Me.invTypeSelect.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.invTypeSelect.Name = "invTypeSelect"
        Me.invTypeSelect.Size = New System.Drawing.Size(49, 29)
        Me.invTypeSelect.TabIndex = 34
        '
        'uomSelect
        '
        Me.uomSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uomSelect.BackColor = System.Drawing.SystemColors.Window
        Me.uomSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uomSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uomSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.uomSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.uomSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.uomSelect.FormattingEnabled = True
        Me.uomSelect.Location = New System.Drawing.Point(138, 74)
        Me.uomSelect.Name = "uomSelect"
        Me.uomSelect.Size = New System.Drawing.Size(56, 29)
        Me.uomSelect.TabIndex = 32
        '
        'mfgNameText
        '
        Me.mfgNameText.AllowDrop = True
        Me.mfgNameText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mfgNameText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.mfgNameText.Location = New System.Drawing.Point(93, 211)
        Me.mfgNameText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.mfgNameText.MaxLength = 25
        Me.mfgNameText.Name = "mfgNameText"
        Me.mfgNameText.Size = New System.Drawing.Size(279, 26)
        Me.mfgNameText.TabIndex = 44
        '
        'mfgNameLabel
        '
        Me.mfgNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mfgNameLabel.AutoSize = True
        Me.mfgNameLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.mfgNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mfgNameLabel.Location = New System.Drawing.Point(4, 214)
        Me.mfgNameLabel.Name = "mfgNameLabel"
        Me.mfgNameLabel.Size = New System.Drawing.Size(84, 21)
        Me.mfgNameLabel.TabIndex = 51
        Me.mfgNameLabel.Text = "Mfg. Name"
        '
        'leadTimeLabel
        '
        Me.leadTimeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.leadTimeLabel.AutoSize = True
        Me.leadTimeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.leadTimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.leadTimeLabel.Location = New System.Drawing.Point(4, 147)
        Me.leadTimeLabel.Name = "leadTimeLabel"
        Me.leadTimeLabel.Size = New System.Drawing.Size(127, 21)
        Me.leadTimeLabel.TabIndex = 50
        Me.leadTimeLabel.Text = "Lead Time Code*"
        '
        'engrLabel
        '
        Me.engrLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.engrLabel.AutoSize = True
        Me.engrLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.engrLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.engrLabel.Location = New System.Drawing.Point(200, 147)
        Me.engrLabel.Name = "engrLabel"
        Me.engrLabel.Size = New System.Drawing.Size(79, 21)
        Me.engrLabel.TabIndex = 49
        Me.engrLabel.Text = "Engineer*"
        '
        'invTypeLabel
        '
        Me.invTypeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.invTypeLabel.AutoSize = True
        Me.invTypeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.invTypeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.invTypeLabel.Location = New System.Drawing.Point(200, 77)
        Me.invTypeLabel.Name = "invTypeLabel"
        Me.invTypeLabel.Size = New System.Drawing.Size(117, 21)
        Me.invTypeLabel.TabIndex = 48
        Me.invTypeLabel.Text = "Inventory Type*"
        '
        'engrStatusLabel
        '
        Me.engrStatusLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.engrStatusLabel.AutoSize = True
        Me.engrStatusLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.engrStatusLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.engrStatusLabel.Location = New System.Drawing.Point(4, 112)
        Me.engrStatusLabel.Name = "engrStatusLabel"
        Me.engrStatusLabel.Size = New System.Drawing.Size(97, 21)
        Me.engrStatusLabel.TabIndex = 47
        Me.engrStatusLabel.Text = "Engr Status*"
        '
        'saleCodeLabel
        '
        Me.saleCodeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saleCodeLabel.AutoSize = True
        Me.saleCodeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.saleCodeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.saleCodeLabel.Location = New System.Drawing.Point(200, 112)
        Me.saleCodeLabel.Name = "saleCodeLabel"
        Me.saleCodeLabel.Size = New System.Drawing.Size(84, 21)
        Me.saleCodeLabel.TabIndex = 45
        Me.saleCodeLabel.Text = "Sales Code"
        '
        'descriptionText
        '
        Me.descriptionText.AllowDrop = True
        Me.descriptionText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.descriptionText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.descriptionText.Location = New System.Drawing.Point(8, 296)
        Me.descriptionText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 5)
        Me.descriptionText.Multiline = True
        Me.descriptionText.Name = "descriptionText"
        Me.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.descriptionText.Size = New System.Drawing.Size(367, 86)
        Me.descriptionText.TabIndex = 33
        '
        'eDescripLabel
        '
        Me.eDescripLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.eDescripLabel.AutoSize = True
        Me.eDescripLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.eDescripLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.eDescripLabel.Location = New System.Drawing.Point(116, 272)
        Me.eDescripLabel.Name = "eDescripLabel"
        Me.eDescripLabel.Size = New System.Drawing.Size(154, 21)
        Me.eDescripLabel.TabIndex = 42
        Me.eDescripLabel.Text = "Extended Description"
        '
        'sDescriptionText
        '
        Me.sDescriptionText.AllowDrop = True
        Me.sDescriptionText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sDescriptionText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.sDescriptionText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.sDescriptionText.Location = New System.Drawing.Point(139, 42)
        Me.sDescriptionText.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.sDescriptionText.MaxLength = 25
        Me.sDescriptionText.Name = "sDescriptionText"
        Me.sDescriptionText.Size = New System.Drawing.Size(233, 26)
        Me.sDescriptionText.TabIndex = 31
        '
        'sDescriptionLabel
        '
        Me.sDescriptionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sDescriptionLabel.AutoSize = True
        Me.sDescriptionLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.sDescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sDescriptionLabel.Location = New System.Drawing.Point(4, 45)
        Me.sDescriptionLabel.Name = "sDescriptionLabel"
        Me.sDescriptionLabel.Size = New System.Drawing.Size(129, 21)
        Me.sDescriptionLabel.TabIndex = 39
        Me.sDescriptionLabel.Text = "Item Description*"
        '
        'UoMLabel
        '
        Me.UoMLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UoMLabel.AutoSize = True
        Me.UoMLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.UoMLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UoMLabel.Location = New System.Drawing.Point(4, 77)
        Me.UoMLabel.Name = "UoMLabel"
        Me.UoMLabel.Size = New System.Drawing.Size(128, 21)
        Me.UoMLabel.TabIndex = 36
        Me.UoMLabel.Text = "Unit Of Measure*"
        '
        'routBox
        '
        Me.routBox.BackColor = System.Drawing.SystemColors.Control
        Me.routBox.Controls.Add(Me.ActionBox)
        Me.routBox.Controls.Add(Me.PresetBox)
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
        Me.routBox.Location = New System.Drawing.Point(12, 478)
        Me.routBox.Name = "routBox"
        Me.routBox.Size = New System.Drawing.Size(828, 194)
        Me.routBox.TabIndex = 65
        Me.routBox.TabStop = False
        Me.routBox.Text = "Routings"
        '
        'ActionBox
        '
        Me.ActionBox.Controls.Add(Me.refreshRoutButton)
        Me.ActionBox.Controls.Add(Me.removeRoutButton)
        Me.ActionBox.Controls.Add(Me.addRoutButton)
        Me.ActionBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionBox.Location = New System.Drawing.Point(551, 110)
        Me.ActionBox.Name = "ActionBox"
        Me.ActionBox.Size = New System.Drawing.Size(211, 55)
        Me.ActionBox.TabIndex = 41
        Me.ActionBox.TabStop = False
        Me.ActionBox.Text = "Actions"
        '
        'refreshRoutButton
        '
        Me.refreshRoutButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshRoutButton.Location = New System.Drawing.Point(142, 21)
        Me.refreshRoutButton.Name = "refreshRoutButton"
        Me.refreshRoutButton.Size = New System.Drawing.Size(62, 23)
        Me.refreshRoutButton.TabIndex = 58
        Me.refreshRoutButton.Text = "Refresh"
        Me.refreshRoutButton.UseVisualStyleBackColor = True
        '
        'removeRoutButton
        '
        Me.removeRoutButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeRoutButton.Location = New System.Drawing.Point(74, 21)
        Me.removeRoutButton.Name = "removeRoutButton"
        Me.removeRoutButton.Size = New System.Drawing.Size(62, 23)
        Me.removeRoutButton.TabIndex = 57
        Me.removeRoutButton.Text = "Remove"
        Me.removeRoutButton.UseVisualStyleBackColor = True
        '
        'addRoutButton
        '
        Me.addRoutButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addRoutButton.Location = New System.Drawing.Point(6, 21)
        Me.addRoutButton.Name = "addRoutButton"
        Me.addRoutButton.Size = New System.Drawing.Size(62, 23)
        Me.addRoutButton.TabIndex = 56
        Me.addRoutButton.Text = "Add"
        Me.addRoutButton.UseVisualStyleBackColor = True
        '
        'PresetBox
        '
        Me.PresetBox.Controls.Add(Me.atpButton)
        Me.PresetBox.Controls.Add(Me.crtButton)
        Me.PresetBox.Controls.Add(Me.ccButton)
        Me.PresetBox.Controls.Add(Me.crbButton)
        Me.PresetBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresetBox.Location = New System.Drawing.Point(315, 110)
        Me.PresetBox.Name = "PresetBox"
        Me.PresetBox.Size = New System.Drawing.Size(230, 77)
        Me.PresetBox.TabIndex = 40
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
        Me.atpButton.Location = New System.Drawing.Point(120, 19)
        Me.atpButton.Name = "atpButton"
        Me.atpButton.Size = New System.Drawing.Size(104, 22)
        Me.atpButton.TabIndex = 9
        Me.atpButton.Text = "Assemble"
        Me.atpButton.UseVisualStyleBackColor = False
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
        Me.crtButton.Location = New System.Drawing.Point(6, 19)
        Me.crtButton.Name = "crtButton"
        Me.crtButton.Size = New System.Drawing.Size(104, 22)
        Me.crtButton.TabIndex = 6
        Me.crtButton.Text = "Cut,Round,Tap"
        Me.crtButton.UseVisualStyleBackColor = False
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
        Me.ccButton.Location = New System.Drawing.Point(6, 47)
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
        Me.crbButton.Location = New System.Drawing.Point(120, 46)
        Me.crbButton.Name = "crbButton"
        Me.crbButton.Size = New System.Drawing.Size(104, 22)
        Me.crbButton.TabIndex = 8
        Me.crbButton.Text = "Cut, Round, Bend"
        Me.crbButton.UseVisualStyleBackColor = False
        '
        'routTable
        '
        Me.routTable.AllowUserToAddRows = False
        Me.routTable.AllowUserToResizeRows = False
        Me.routTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.routTable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.routTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.routTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seq, Me.wCenter, Me.crew, Me.hours, Me.rDesc, Me.m2kRoutSelect})
        Me.routTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.routTable.Location = New System.Drawing.Point(316, 13)
        Me.routTable.Name = "routTable"
        Me.routTable.Size = New System.Drawing.Size(506, 91)
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
        Me.seq.Width = 57
        '
        'wCenter
        '
        Me.wCenter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.wCenter.HeaderText = "WC"
        Me.wCenter.MinimumWidth = 50
        Me.wCenter.Name = "wCenter"
        Me.wCenter.ReadOnly = True
        Me.wCenter.Width = 54
        '
        'crew
        '
        Me.crew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.crew.HeaderText = "Crew"
        Me.crew.MinimumWidth = 50
        Me.crew.Name = "crew"
        Me.crew.ReadOnly = True
        Me.crew.Width = 65
        '
        'hours
        '
        Me.hours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.hours.FillWeight = 26.16643!
        Me.hours.HeaderText = "Hours"
        Me.hours.MinimumWidth = 50
        Me.hours.Name = "hours"
        Me.hours.ReadOnly = True
        Me.hours.Width = 70
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
        Me.wsSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.wsSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.wsSelect.FormattingEnabled = True
        Me.wsSelect.Location = New System.Drawing.Point(248, 19)
        Me.wsSelect.Name = "wsSelect"
        Me.wsSelect.Size = New System.Drawing.Size(60, 29)
        Me.wsSelect.TabIndex = 30
        '
        'wCLabel
        '
        Me.wCLabel.AutoSize = True
        Me.wCLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.wCLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.wCLabel.Location = New System.Drawing.Point(154, 22)
        Me.wCLabel.Name = "wCLabel"
        Me.wCLabel.Size = New System.Drawing.Size(92, 21)
        Me.wCLabel.TabIndex = 38
        Me.wCLabel.Text = "Work Center"
        '
        'crewText
        '
        Me.crewText.AllowDrop = True
        Me.crewText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.crewText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.crewText.Location = New System.Drawing.Point(120, 54)
        Me.crewText.MaxLength = 2
        Me.crewText.Name = "crewText"
        Me.crewText.Size = New System.Drawing.Size(60, 26)
        Me.crewText.TabIndex = 31
        '
        'laborText
        '
        Me.laborText.AllowDrop = True
        Me.laborText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.laborText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.laborText.Location = New System.Drawing.Point(241, 54)
        Me.laborText.MaxLength = 10
        Me.laborText.Name = "laborText"
        Me.laborText.Size = New System.Drawing.Size(67, 26)
        Me.laborText.TabIndex = 32
        '
        'lHourLabel
        '
        Me.lHourLabel.AutoSize = True
        Me.lHourLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.lHourLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lHourLabel.Location = New System.Drawing.Point(187, 57)
        Me.lHourLabel.Name = "lHourLabel"
        Me.lHourLabel.Size = New System.Drawing.Size(49, 21)
        Me.lHourLabel.TabIndex = 37
        Me.lHourLabel.Text = "Hours"
        '
        'seqSelect
        '
        Me.seqSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seqSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.seqSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.seqSelect.FormattingEnabled = True
        Me.seqSelect.Items.AddRange(New Object() {"10", "20", "30", "40", "5", "50", "60", "70"})
        Me.seqSelect.Location = New System.Drawing.Point(88, 19)
        Me.seqSelect.Name = "seqSelect"
        Me.seqSelect.Size = New System.Drawing.Size(60, 29)
        Me.seqSelect.Sorted = True
        Me.seqSelect.TabIndex = 29
        '
        'routDesc
        '
        Me.routDesc.AllowDrop = True
        Me.routDesc.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.routDesc.Location = New System.Drawing.Point(10, 110)
        Me.routDesc.MaxLength = 50
        Me.routDesc.Multiline = True
        Me.routDesc.Name = "routDesc"
        Me.routDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.routDesc.Size = New System.Drawing.Size(299, 77)
        Me.routDesc.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(85, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Routing Description"
        '
        'seqLabel
        '
        Me.seqLabel.AutoSize = True
        Me.seqLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.seqLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.seqLabel.Location = New System.Drawing.Point(5, 22)
        Me.seqLabel.Name = "seqLabel"
        Me.seqLabel.Size = New System.Drawing.Size(77, 21)
        Me.seqLabel.TabIndex = 35
        Me.seqLabel.Text = "Sequence"
        '
        'crewLabel
        '
        Me.crewLabel.AutoSize = True
        Me.crewLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.crewLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.crewLabel.Location = New System.Drawing.Point(5, 57)
        Me.crewLabel.Name = "crewLabel"
        Me.crewLabel.Size = New System.Drawing.Size(109, 21)
        Me.crewLabel.TabIndex = 34
        Me.crewLabel.Text = "Crew Required"
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
        Me.bomBox.Location = New System.Drawing.Point(401, 12)
        Me.bomBox.Name = "bomBox"
        Me.bomBox.Size = New System.Drawing.Size(750, 460)
        Me.bomBox.TabIndex = 64
        Me.bomBox.TabStop = False
        Me.bomBox.Text = "Bill Of Materials"
        '
        'partBox
        '
        Me.partBox.Controls.Add(Me.refreshMatButton)
        Me.partBox.Controls.Add(Me.removeMatButton)
        Me.partBox.Controls.Add(Me.addMatButton)
        Me.partBox.Controls.Add(Me.customButton)
        Me.partBox.Controls.Add(Me.matSelect)
        Me.partBox.Controls.Add(Me.matNumLabel)
        Me.partBox.Controls.Add(Me.amountText)
        Me.partBox.Controls.Add(Me.amountLabel)
        Me.partBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partBox.Location = New System.Drawing.Point(6, 341)
        Me.partBox.Name = "partBox"
        Me.partBox.Size = New System.Drawing.Size(405, 113)
        Me.partBox.TabIndex = 66
        Me.partBox.TabStop = False
        Me.partBox.Text = "Part"
        '
        'refreshMatButton
        '
        Me.refreshMatButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshMatButton.Location = New System.Drawing.Point(337, 80)
        Me.refreshMatButton.Name = "refreshMatButton"
        Me.refreshMatButton.Size = New System.Drawing.Size(62, 23)
        Me.refreshMatButton.TabIndex = 55
        Me.refreshMatButton.Text = "Refresh"
        Me.refreshMatButton.UseVisualStyleBackColor = True
        '
        'removeMatButton
        '
        Me.removeMatButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeMatButton.Location = New System.Drawing.Point(337, 51)
        Me.removeMatButton.Name = "removeMatButton"
        Me.removeMatButton.Size = New System.Drawing.Size(62, 23)
        Me.removeMatButton.TabIndex = 54
        Me.removeMatButton.Text = "Remove"
        Me.removeMatButton.UseVisualStyleBackColor = True
        '
        'addMatButton
        '
        Me.addMatButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMatButton.Location = New System.Drawing.Point(337, 22)
        Me.addMatButton.Name = "addMatButton"
        Me.addMatButton.Size = New System.Drawing.Size(62, 23)
        Me.addMatButton.TabIndex = 53
        Me.addMatButton.Text = "Add"
        Me.addMatButton.UseVisualStyleBackColor = True
        '
        'customButton
        '
        Me.customButton.BackColor = System.Drawing.SystemColors.Control
        Me.customButton.FlatAppearance.BorderSize = 0
        Me.customButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.customButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.customButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.customButton.Location = New System.Drawing.Point(240, 50)
        Me.customButton.Name = "customButton"
        Me.customButton.Size = New System.Drawing.Size(91, 25)
        Me.customButton.TabIndex = 45
        Me.customButton.Text = "Custom"
        Me.customButton.UseVisualStyleBackColor = False
        '
        'matSelect
        '
        Me.matSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.matSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.matSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.matSelect.FormattingEnabled = True
        Me.matSelect.Items.AddRange(New Object() {"MTL0100", "MTL0101", "MTL0102", "MTL0103", "MTL0104", "MTL0105", "MTL0110", "MTL0120", "MTL0130", "MTL0200", "MTL0201", "MTL0220", "MTL0300", "MTL0400", "MTL0420", "MTL0500", "MTL0700", "MTL0710", "MTL0720", "MTL0800"})
        Me.matSelect.Location = New System.Drawing.Point(75, 31)
        Me.matSelect.Name = "matSelect"
        Me.matSelect.Size = New System.Drawing.Size(159, 29)
        Me.matSelect.TabIndex = 41
        '
        'matNumLabel
        '
        Me.matNumLabel.AutoSize = True
        Me.matNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.matNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.matNumLabel.Location = New System.Drawing.Point(6, 34)
        Me.matNumLabel.Name = "matNumLabel"
        Me.matNumLabel.Size = New System.Drawing.Size(65, 21)
        Me.matNumLabel.TabIndex = 44
        Me.matNumLabel.Text = "Material"
        '
        'amountText
        '
        Me.amountText.AllowDrop = True
        Me.amountText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.amountText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.amountText.Location = New System.Drawing.Point(75, 65)
        Me.amountText.MaxLength = 5
        Me.amountText.Name = "amountText"
        Me.amountText.Size = New System.Drawing.Size(159, 26)
        Me.amountText.TabIndex = 42
        '
        'amountLabel
        '
        Me.amountLabel.AutoSize = True
        Me.amountLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.amountLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.amountLabel.Location = New System.Drawing.Point(6, 68)
        Me.amountLabel.Name = "amountLabel"
        Me.amountLabel.Size = New System.Drawing.Size(63, 21)
        Me.amountLabel.TabIndex = 43
        Me.amountLabel.Text = "Amount"
        '
        'assemblyBox
        '
        Me.assemblyBox.Controls.Add(Me.refreshBillButton)
        Me.assemblyBox.Controls.Add(Me.removeBillButton)
        Me.assemblyBox.Controls.Add(Me.addBillButton)
        Me.assemblyBox.Controls.Add(Me.invBillLabel)
        Me.assemblyBox.Controls.Add(Me.invBOMGrid)
        Me.assemblyBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assemblyBox.Location = New System.Drawing.Point(6, 21)
        Me.assemblyBox.Name = "assemblyBox"
        Me.assemblyBox.Size = New System.Drawing.Size(405, 314)
        Me.assemblyBox.TabIndex = 65
        Me.assemblyBox.TabStop = False
        Me.assemblyBox.Text = "Assembly"
        '
        'refreshBillButton
        '
        Me.refreshBillButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshBillButton.Location = New System.Drawing.Point(338, 196)
        Me.refreshBillButton.Name = "refreshBillButton"
        Me.refreshBillButton.Size = New System.Drawing.Size(62, 23)
        Me.refreshBillButton.TabIndex = 52
        Me.refreshBillButton.Text = "Refresh"
        Me.refreshBillButton.UseVisualStyleBackColor = True
        '
        'removeBillButton
        '
        Me.removeBillButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeBillButton.Location = New System.Drawing.Point(338, 167)
        Me.removeBillButton.Name = "removeBillButton"
        Me.removeBillButton.Size = New System.Drawing.Size(62, 23)
        Me.removeBillButton.TabIndex = 51
        Me.removeBillButton.Text = "Remove"
        Me.removeBillButton.UseVisualStyleBackColor = True
        '
        'addBillButton
        '
        Me.addBillButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBillButton.Location = New System.Drawing.Point(338, 138)
        Me.addBillButton.Name = "addBillButton"
        Me.addBillButton.Size = New System.Drawing.Size(62, 23)
        Me.addBillButton.TabIndex = 50
        Me.addBillButton.Text = "Add"
        Me.addBillButton.UseVisualStyleBackColor = True
        '
        'invBillLabel
        '
        Me.invBillLabel.AutoSize = True
        Me.invBillLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.invBillLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.invBillLabel.Location = New System.Drawing.Point(79, 18)
        Me.invBillLabel.Name = "invBillLabel"
        Me.invBillLabel.Size = New System.Drawing.Size(174, 21)
        Me.invBillLabel.TabIndex = 48
        Me.invBillLabel.Text = "Inventor Bill of Materials"
        '
        'invBOMGrid
        '
        Me.invBOMGrid.AllowUserToDeleteRows = False
        Me.invBOMGrid.AllowUserToResizeRows = False
        Me.invBOMGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.invBOMGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.invBOMGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.invBOMGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prtNum, Me.qty, Me.invBillSelect})
        Me.invBOMGrid.Location = New System.Drawing.Point(7, 42)
        Me.invBOMGrid.Name = "invBOMGrid"
        Me.invBOMGrid.Size = New System.Drawing.Size(325, 266)
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
        'm2kBillLabel
        '
        Me.m2kBillLabel.AutoSize = True
        Me.m2kBillLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.m2kBillLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.m2kBillLabel.Location = New System.Drawing.Point(519, 39)
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
        Me.m2kBOMGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.m2kBOMGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.m2kBillSelect})
        Me.m2kBOMGrid.Location = New System.Drawing.Point(417, 63)
        Me.m2kBOMGrid.Name = "m2kBOMGrid"
        Me.m2kBOMGrid.Size = New System.Drawing.Size(325, 389)
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
        Me.DataGridViewTextBoxColumn2.Width = 86
        '
        'm2kBillSelect
        '
        Me.m2kBillSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.m2kBillSelect.HeaderText = ""
        Me.m2kBillSelect.Name = "m2kBillSelect"
        Me.m2kBillSelect.Width = 5
        '
        'itemMasterBox
        '
        Me.itemMasterBox.BackColor = System.Drawing.SystemColors.Control
        Me.itemMasterBox.Controls.Add(Me.sDescriptionLabel)
        Me.itemMasterBox.Controls.Add(Me.UoMLabel)
        Me.itemMasterBox.Controls.Add(Me.sDescriptionText)
        Me.itemMasterBox.Controls.Add(Me.purchasedStandard)
        Me.itemMasterBox.Controls.Add(Me.engineerText)
        Me.itemMasterBox.Controls.Add(Me.manufacturedStandard)
        Me.itemMasterBox.Controls.Add(Me.eDescripLabel)
        Me.itemMasterBox.Controls.Add(Me.salesOrT)
        Me.itemMasterBox.Controls.Add(Me.descriptionText)
        Me.itemMasterBox.Controls.Add(Me.salesONum)
        Me.itemMasterBox.Controls.Add(Me.saleCodeLabel)
        Me.itemMasterBox.Controls.Add(Me.companyT)
        Me.itemMasterBox.Controls.Add(Me.engrStatusLabel)
        Me.itemMasterBox.Controls.Add(Me.customerL)
        Me.itemMasterBox.Controls.Add(Me.invTypeLabel)
        Me.itemMasterBox.Controls.Add(Me.mfgPrtNumText)
        Me.itemMasterBox.Controls.Add(Me.engrLabel)
        Me.itemMasterBox.Controls.Add(Me.mfgPartNumLabel)
        Me.itemMasterBox.Controls.Add(Me.leadTimeLabel)
        Me.itemMasterBox.Controls.Add(Me.leadTimeSelect)
        Me.itemMasterBox.Controls.Add(Me.mfgNameLabel)
        Me.itemMasterBox.Controls.Add(Me.salesCodeSelect)
        Me.itemMasterBox.Controls.Add(Me.mfgNameText)
        Me.itemMasterBox.Controls.Add(Me.engStatusSelect)
        Me.itemMasterBox.Controls.Add(Me.uomSelect)
        Me.itemMasterBox.Controls.Add(Me.invTypeSelect)
        Me.itemMasterBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemMasterBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemMasterBox.Location = New System.Drawing.Point(12, 82)
        Me.itemMasterBox.Name = "itemMasterBox"
        Me.itemMasterBox.Size = New System.Drawing.Size(383, 390)
        Me.itemMasterBox.TabIndex = 66
        Me.itemMasterBox.TabStop = False
        Me.itemMasterBox.Text = "Item Master"
        '
        'finalBox
        '
        Me.finalBox.BackColor = System.Drawing.SystemColors.Control
        Me.finalBox.Controls.Add(Me.Cancel_Button)
        Me.finalBox.Controls.Add(Me.pullIMsqlButton)
        Me.finalBox.Controls.Add(Me.uploadIMButton)
        Me.finalBox.Controls.Add(Me.saveLocalButton)
        Me.finalBox.Controls.Add(Me.uploadAllButton)
        Me.finalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.finalBox.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalBox.Location = New System.Drawing.Point(945, 497)
        Me.finalBox.Name = "finalBox"
        Me.finalBox.Size = New System.Drawing.Size(149, 165)
        Me.finalBox.TabIndex = 67
        Me.finalBox.TabStop = False
        Me.finalBox.Text = "Finalize"
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
        Me.Cancel_Button.Location = New System.Drawing.Point(6, 133)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(136, 22)
        Me.Cancel_Button.TabIndex = 31
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'pullIMsqlButton
        '
        Me.pullIMsqlButton.BackColor = System.Drawing.SystemColors.Control
        Me.pullIMsqlButton.FlatAppearance.BorderSize = 0
        Me.pullIMsqlButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pullIMsqlButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pullIMsqlButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pullIMsqlButton.Location = New System.Drawing.Point(6, 77)
        Me.pullIMsqlButton.Name = "pullIMsqlButton"
        Me.pullIMsqlButton.Size = New System.Drawing.Size(136, 22)
        Me.pullIMsqlButton.TabIndex = 30
        Me.pullIMsqlButton.Text = "Update IM"
        Me.pullIMsqlButton.UseVisualStyleBackColor = False
        '
        'uploadIMButton
        '
        Me.uploadIMButton.BackColor = System.Drawing.Color.LightGreen
        Me.uploadIMButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen
        Me.uploadIMButton.FlatAppearance.BorderSize = 0
        Me.uploadIMButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uploadIMButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uploadIMButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.uploadIMButton.Location = New System.Drawing.Point(6, 21)
        Me.uploadIMButton.Name = "uploadIMButton"
        Me.uploadIMButton.Size = New System.Drawing.Size(136, 22)
        Me.uploadIMButton.TabIndex = 12
        Me.uploadIMButton.Text = "Upload Item Master"
        Me.uploadIMButton.UseVisualStyleBackColor = False
        '
        'saveLocalButton
        '
        Me.saveLocalButton.BackColor = System.Drawing.SystemColors.Control
        Me.saveLocalButton.FlatAppearance.BorderSize = 0
        Me.saveLocalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveLocalButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.saveLocalButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.saveLocalButton.Location = New System.Drawing.Point(6, 105)
        Me.saveLocalButton.Name = "saveLocalButton"
        Me.saveLocalButton.Size = New System.Drawing.Size(136, 22)
        Me.saveLocalButton.TabIndex = 11
        Me.saveLocalButton.Text = "Save Local"
        Me.saveLocalButton.UseVisualStyleBackColor = False
        '
        'uploadAllButton
        '
        Me.uploadAllButton.BackColor = System.Drawing.Color.LightGreen
        Me.uploadAllButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen
        Me.uploadAllButton.FlatAppearance.BorderSize = 0
        Me.uploadAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uploadAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uploadAllButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.uploadAllButton.Location = New System.Drawing.Point(6, 49)
        Me.uploadAllButton.Name = "uploadAllButton"
        Me.uploadAllButton.Size = New System.Drawing.Size(136, 22)
        Me.uploadAllButton.TabIndex = 10
        Me.uploadAllButton.Text = "Upload All"
        Me.uploadAllButton.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLable, Me.infoProgressBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 679)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1163, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 68
        Me.StatusStrip1.Text = "Status Strip"
        '
        'statusLable
        '
        Me.statusLable.Name = "statusLable"
        Me.statusLable.Size = New System.Drawing.Size(156, 17)
        Me.statusLable.Text = "Part Information Completed"
        '
        'infoProgressBar
        '
        Me.infoProgressBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.infoProgressBar.Maximum = 7
        Me.infoProgressBar.Name = "infoProgressBar"
        Me.infoProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'AllInOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1163, 701)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.finalBox)
        Me.Controls.Add(Me.itemMasterBox)
        Me.Controls.Add(Me.routBox)
        Me.Controls.Add(Me.bomBox)
        Me.Controls.Add(Me.impLogo)
        Me.Controls.Add(Me.partNumberText)
        Me.Controls.Add(Me.ePrtNumLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "AllInOne"
        Me.Text = "Part Information"
        CType(Me.impLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.routBox.ResumeLayout(False)
        Me.routBox.PerformLayout()
        Me.ActionBox.ResumeLayout(False)
        Me.PresetBox.ResumeLayout(False)
        CType(Me.routTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bomBox.ResumeLayout(False)
        Me.bomBox.PerformLayout()
        Me.partBox.ResumeLayout(False)
        Me.partBox.PerformLayout()
        Me.assemblyBox.ResumeLayout(False)
        Me.assemblyBox.PerformLayout()
        CType(Me.invBOMGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m2kBOMGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.itemMasterBox.ResumeLayout(False)
        Me.itemMasterBox.PerformLayout()
        Me.finalBox.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents purchasedStandard As Windows.Forms.Button
    Friend WithEvents manufacturedStandard As Windows.Forms.Button
    Friend WithEvents impLogo As Windows.Forms.PictureBox
    Friend WithEvents partNumberText As Windows.Forms.TextBox
    Friend WithEvents ePrtNumLabel As Windows.Forms.Label
    Friend WithEvents engineerText As Windows.Forms.ComboBox
    Friend WithEvents salesOrT As Windows.Forms.TextBox
    Friend WithEvents salesONum As Windows.Forms.Label
    Friend WithEvents companyT As Windows.Forms.TextBox
    Friend WithEvents customerL As Windows.Forms.Label
    Friend WithEvents mfgPrtNumText As Windows.Forms.TextBox
    Friend WithEvents mfgPartNumLabel As Windows.Forms.Label
    Friend WithEvents leadTimeSelect As Windows.Forms.ComboBox
    Friend WithEvents salesCodeSelect As Windows.Forms.ComboBox
    Friend WithEvents engStatusSelect As Windows.Forms.ComboBox
    Friend WithEvents invTypeSelect As Windows.Forms.ComboBox
    Friend WithEvents uomSelect As Windows.Forms.ComboBox
    Friend WithEvents mfgNameText As Windows.Forms.TextBox
    Friend WithEvents mfgNameLabel As Windows.Forms.Label
    Friend WithEvents leadTimeLabel As Windows.Forms.Label
    Friend WithEvents engrLabel As Windows.Forms.Label
    Friend WithEvents invTypeLabel As Windows.Forms.Label
    Friend WithEvents engrStatusLabel As Windows.Forms.Label
    Friend WithEvents saleCodeLabel As Windows.Forms.Label
    Friend WithEvents descriptionText As Windows.Forms.TextBox
    Friend WithEvents eDescripLabel As Windows.Forms.Label
    Friend WithEvents sDescriptionText As Windows.Forms.TextBox
    Friend WithEvents sDescriptionLabel As Windows.Forms.Label
    Friend WithEvents UoMLabel As Windows.Forms.Label
    Friend WithEvents routBox As Windows.Forms.GroupBox
    Friend WithEvents bomBox As Windows.Forms.GroupBox
    Friend WithEvents itemMasterBox As Windows.Forms.GroupBox
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
    Friend WithEvents routTable As Windows.Forms.DataGridView
    Friend WithEvents ActionBox As Windows.Forms.GroupBox
    Friend WithEvents PresetBox As Windows.Forms.GroupBox
    Friend WithEvents atpButton As Windows.Forms.Button
    Friend WithEvents crtButton As Windows.Forms.Button
    Friend WithEvents ccButton As Windows.Forms.Button
    Friend WithEvents crbButton As Windows.Forms.Button
    Friend WithEvents partBox As Windows.Forms.GroupBox
    Friend WithEvents refreshMatButton As Windows.Forms.Button
    Friend WithEvents removeMatButton As Windows.Forms.Button
    Friend WithEvents addMatButton As Windows.Forms.Button
    Friend WithEvents customButton As Windows.Forms.Button
    Friend WithEvents matSelect As Windows.Forms.ComboBox
    Friend WithEvents matNumLabel As Windows.Forms.Label
    Friend WithEvents amountText As Windows.Forms.TextBox
    Friend WithEvents amountLabel As Windows.Forms.Label
    Friend WithEvents assemblyBox As Windows.Forms.GroupBox
    Friend WithEvents refreshBillButton As Windows.Forms.Button
    Friend WithEvents removeBillButton As Windows.Forms.Button
    Friend WithEvents addBillButton As Windows.Forms.Button
    Friend WithEvents invBillLabel As Windows.Forms.Label
    Friend WithEvents invBOMGrid As Windows.Forms.DataGridView
    Friend WithEvents m2kBillLabel As Windows.Forms.Label
    Friend WithEvents m2kBOMGrid As Windows.Forms.DataGridView
    Friend WithEvents finalBox As Windows.Forms.GroupBox
    Friend WithEvents pullIMsqlButton As Windows.Forms.Button
    Friend WithEvents uploadIMButton As Windows.Forms.Button
    Friend WithEvents saveLocalButton As Windows.Forms.Button
    Friend WithEvents uploadAllButton As Windows.Forms.Button
    Friend WithEvents refreshRoutButton As Windows.Forms.Button
    Friend WithEvents removeRoutButton As Windows.Forms.Button
    Friend WithEvents addRoutButton As Windows.Forms.Button
    Friend WithEvents prtNum As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invBillSelect As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents m2kBillSelect As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents statusLable As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents infoProgressBar As Windows.Forms.ToolStripProgressBar
    Friend WithEvents Cancel_Button As Windows.Forms.Button
    Friend WithEvents seq As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wCenter As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crew As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hours As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rDesc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents m2kRoutSelect As Windows.Forms.DataGridViewCheckBoxColumn
End Class
