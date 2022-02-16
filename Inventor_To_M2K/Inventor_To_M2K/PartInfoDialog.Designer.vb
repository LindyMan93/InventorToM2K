<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartInfoDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartInfoDialog))
        Me.buttonLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.upload_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.ePrtNumLabel = New System.Windows.Forms.Label()
        Me.partNumberText = New System.Windows.Forms.TextBox()
        Me.UoMLabel = New System.Windows.Forms.Label()
        Me.sDescriptionText = New System.Windows.Forms.TextBox()
        Me.sDescriptionLabel = New System.Windows.Forms.Label()
        Me.invTypeLabel = New System.Windows.Forms.Label()
        Me.engrStatusLabel = New System.Windows.Forms.Label()
        Me.saleCodeLabel = New System.Windows.Forms.Label()
        Me.descriptionText = New System.Windows.Forms.TextBox()
        Me.eDescripLabel = New System.Windows.Forms.Label()
        Me.leadTimeLabel = New System.Windows.Forms.Label()
        Me.engrLabel = New System.Windows.Forms.Label()
        Me.mfgNameText = New System.Windows.Forms.TextBox()
        Me.mfgNameLabel = New System.Windows.Forms.Label()
        Me.uomSelect = New System.Windows.Forms.ComboBox()
        Me.invTypeSelect = New System.Windows.Forms.ComboBox()
        Me.engStatusSelect = New System.Windows.Forms.ComboBox()
        Me.salesCodeSelect = New System.Windows.Forms.ComboBox()
        Me.leadTimeSelect = New System.Windows.Forms.ComboBox()
        Me.hButton = New System.Windows.Forms.Button()
        Me.impLogo = New System.Windows.Forms.PictureBox()
        Me.manufacturedStandard = New System.Windows.Forms.Button()
        Me.purchasedStandard = New System.Windows.Forms.Button()
        Me.mfgPrtNumText = New System.Windows.Forms.TextBox()
        Me.mfgPartNumLabel = New System.Windows.Forms.Label()
        Me.salesOrT = New System.Windows.Forms.TextBox()
        Me.salesONum = New System.Windows.Forms.Label()
        Me.companyT = New System.Windows.Forms.TextBox()
        Me.customerL = New System.Windows.Forms.Label()
        Me.engineerText = New System.Windows.Forms.ComboBox()
        Me.buttonLayoutPanel.SuspendLayout()
        CType(Me.impLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonLayoutPanel
        '
        resources.ApplyResources(Me.buttonLayoutPanel, "buttonLayoutPanel")
        Me.buttonLayoutPanel.Controls.Add(Me.upload_Button, 0, 0)
        Me.buttonLayoutPanel.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.buttonLayoutPanel.Controls.Add(Me.Save_Button, 1, 0)
        Me.buttonLayoutPanel.Name = "buttonLayoutPanel"
        '
        'upload_Button
        '
        resources.ApplyResources(Me.upload_Button, "upload_Button")
        Me.upload_Button.BackColor = System.Drawing.Color.LightGreen
        Me.upload_Button.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen
        Me.upload_Button.FlatAppearance.BorderSize = 0
        Me.upload_Button.Name = "upload_Button"
        Me.upload_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        resources.ApplyResources(Me.Cancel_Button, "Cancel_Button")
        Me.Cancel_Button.BackColor = System.Drawing.Color.MistyRose
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Save_Button
        '
        resources.ApplyResources(Me.Save_Button, "Save_Button")
        Me.Save_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Save_Button.FlatAppearance.BorderSize = 0
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.UseVisualStyleBackColor = False
        '
        'ePrtNumLabel
        '
        resources.ApplyResources(Me.ePrtNumLabel, "ePrtNumLabel")
        Me.ePrtNumLabel.Name = "ePrtNumLabel"
        Me.ePrtNumLabel.UseCompatibleTextRendering = True
        '
        'partNumberText
        '
        Me.partNumberText.BackColor = System.Drawing.SystemColors.Control
        Me.partNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.partNumberText, "partNumberText")
        Me.partNumberText.ForeColor = System.Drawing.Color.Red
        Me.partNumberText.Name = "partNumberText"
        Me.partNumberText.ReadOnly = True
        Me.partNumberText.TabStop = False
        '
        'UoMLabel
        '
        resources.ApplyResources(Me.UoMLabel, "UoMLabel")
        Me.UoMLabel.Name = "UoMLabel"
        '
        'sDescriptionText
        '
        Me.sDescriptionText.AllowDrop = True
        resources.ApplyResources(Me.sDescriptionText, "sDescriptionText")
        Me.sDescriptionText.Name = "sDescriptionText"
        '
        'sDescriptionLabel
        '
        resources.ApplyResources(Me.sDescriptionLabel, "sDescriptionLabel")
        Me.sDescriptionLabel.Name = "sDescriptionLabel"
        '
        'invTypeLabel
        '
        resources.ApplyResources(Me.invTypeLabel, "invTypeLabel")
        Me.invTypeLabel.Name = "invTypeLabel"
        '
        'engrStatusLabel
        '
        resources.ApplyResources(Me.engrStatusLabel, "engrStatusLabel")
        Me.engrStatusLabel.Name = "engrStatusLabel"
        '
        'saleCodeLabel
        '
        resources.ApplyResources(Me.saleCodeLabel, "saleCodeLabel")
        Me.saleCodeLabel.Name = "saleCodeLabel"
        '
        'descriptionText
        '
        Me.descriptionText.AllowDrop = True
        resources.ApplyResources(Me.descriptionText, "descriptionText")
        Me.descriptionText.Name = "descriptionText"
        '
        'eDescripLabel
        '
        resources.ApplyResources(Me.eDescripLabel, "eDescripLabel")
        Me.eDescripLabel.Name = "eDescripLabel"
        '
        'leadTimeLabel
        '
        resources.ApplyResources(Me.leadTimeLabel, "leadTimeLabel")
        Me.leadTimeLabel.Name = "leadTimeLabel"
        '
        'engrLabel
        '
        resources.ApplyResources(Me.engrLabel, "engrLabel")
        Me.engrLabel.Name = "engrLabel"
        '
        'mfgNameText
        '
        Me.mfgNameText.AllowDrop = True
        resources.ApplyResources(Me.mfgNameText, "mfgNameText")
        Me.mfgNameText.Name = "mfgNameText"
        '
        'mfgNameLabel
        '
        resources.ApplyResources(Me.mfgNameLabel, "mfgNameLabel")
        Me.mfgNameLabel.Name = "mfgNameLabel"
        '
        'uomSelect
        '
        Me.uomSelect.BackColor = System.Drawing.SystemColors.Window
        Me.uomSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uomSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.uomSelect, "uomSelect")
        Me.uomSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.uomSelect.FormattingEnabled = True
        Me.uomSelect.Name = "uomSelect"
        '
        'invTypeSelect
        '
        Me.invTypeSelect.BackColor = System.Drawing.SystemColors.Window
        Me.invTypeSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.invTypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.invTypeSelect, "invTypeSelect")
        Me.invTypeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.invTypeSelect.FormattingEnabled = True
        Me.invTypeSelect.Name = "invTypeSelect"
        '
        'engStatusSelect
        '
        Me.engStatusSelect.BackColor = System.Drawing.SystemColors.Window
        Me.engStatusSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.engStatusSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.engStatusSelect, "engStatusSelect")
        Me.engStatusSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.engStatusSelect.FormattingEnabled = True
        Me.engStatusSelect.Name = "engStatusSelect"
        '
        'salesCodeSelect
        '
        Me.salesCodeSelect.BackColor = System.Drawing.SystemColors.Window
        Me.salesCodeSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.salesCodeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.salesCodeSelect, "salesCodeSelect")
        Me.salesCodeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.salesCodeSelect.FormattingEnabled = True
        Me.salesCodeSelect.Name = "salesCodeSelect"
        '
        'leadTimeSelect
        '
        Me.leadTimeSelect.BackColor = System.Drawing.SystemColors.Window
        Me.leadTimeSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.leadTimeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.leadTimeSelect, "leadTimeSelect")
        Me.leadTimeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.leadTimeSelect.FormattingEnabled = True
        Me.leadTimeSelect.Name = "leadTimeSelect"
        '
        'hButton
        '
        Me.hButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.hButton.Cursor = System.Windows.Forms.Cursors.Help
        Me.hButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.hButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.hButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        resources.ApplyResources(Me.hButton, "hButton")
        Me.hButton.Name = "hButton"
        Me.hButton.UseVisualStyleBackColor = False
        '
        'impLogo
        '
        resources.ApplyResources(Me.impLogo, "impLogo")
        Me.impLogo.Name = "impLogo"
        Me.impLogo.TabStop = False
        '
        'manufacturedStandard
        '
        Me.manufacturedStandard.BackColor = System.Drawing.SystemColors.WindowText
        Me.manufacturedStandard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.manufacturedStandard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.manufacturedStandard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        resources.ApplyResources(Me.manufacturedStandard, "manufacturedStandard")
        Me.manufacturedStandard.ForeColor = System.Drawing.SystemColors.Control
        Me.manufacturedStandard.Name = "manufacturedStandard"
        Me.manufacturedStandard.UseVisualStyleBackColor = False
        '
        'purchasedStandard
        '
        Me.purchasedStandard.BackColor = System.Drawing.SystemColors.WindowText
        Me.purchasedStandard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.purchasedStandard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.purchasedStandard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        resources.ApplyResources(Me.purchasedStandard, "purchasedStandard")
        Me.purchasedStandard.ForeColor = System.Drawing.SystemColors.Control
        Me.purchasedStandard.Name = "purchasedStandard"
        Me.purchasedStandard.UseVisualStyleBackColor = False
        '
        'mfgPrtNumText
        '
        Me.mfgPrtNumText.AllowDrop = True
        resources.ApplyResources(Me.mfgPrtNumText, "mfgPrtNumText")
        Me.mfgPrtNumText.Name = "mfgPrtNumText"
        '
        'mfgPartNumLabel
        '
        resources.ApplyResources(Me.mfgPartNumLabel, "mfgPartNumLabel")
        Me.mfgPartNumLabel.Name = "mfgPartNumLabel"
        '
        'salesOrT
        '
        Me.salesOrT.AllowDrop = True
        resources.ApplyResources(Me.salesOrT, "salesOrT")
        Me.salesOrT.Name = "salesOrT"
        '
        'salesONum
        '
        resources.ApplyResources(Me.salesONum, "salesONum")
        Me.salesONum.Name = "salesONum"
        '
        'companyT
        '
        resources.ApplyResources(Me.companyT, "companyT")
        Me.companyT.Name = "companyT"
        '
        'customerL
        '
        resources.ApplyResources(Me.customerL, "customerL")
        Me.customerL.Name = "customerL"
        '
        'engineerText
        '
        Me.engineerText.BackColor = System.Drawing.SystemColors.Window
        Me.engineerText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.engineerText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.engineerText, "engineerText")
        Me.engineerText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.engineerText.FormattingEnabled = True
        Me.engineerText.Name = "engineerText"
        '
        'PartInfoDialog
        '
        Me.AcceptButton = Me.Save_Button
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Cancel_Button
        Me.Controls.Add(Me.engineerText)
        Me.Controls.Add(Me.salesOrT)
        Me.Controls.Add(Me.salesONum)
        Me.Controls.Add(Me.companyT)
        Me.Controls.Add(Me.customerL)
        Me.Controls.Add(Me.mfgPrtNumText)
        Me.Controls.Add(Me.mfgPartNumLabel)
        Me.Controls.Add(Me.purchasedStandard)
        Me.Controls.Add(Me.manufacturedStandard)
        Me.Controls.Add(Me.impLogo)
        Me.Controls.Add(Me.hButton)
        Me.Controls.Add(Me.leadTimeSelect)
        Me.Controls.Add(Me.salesCodeSelect)
        Me.Controls.Add(Me.engStatusSelect)
        Me.Controls.Add(Me.invTypeSelect)
        Me.Controls.Add(Me.uomSelect)
        Me.Controls.Add(Me.mfgNameText)
        Me.Controls.Add(Me.mfgNameLabel)
        Me.Controls.Add(Me.leadTimeLabel)
        Me.Controls.Add(Me.engrLabel)
        Me.Controls.Add(Me.invTypeLabel)
        Me.Controls.Add(Me.engrStatusLabel)
        Me.Controls.Add(Me.saleCodeLabel)
        Me.Controls.Add(Me.descriptionText)
        Me.Controls.Add(Me.eDescripLabel)
        Me.Controls.Add(Me.sDescriptionText)
        Me.Controls.Add(Me.sDescriptionLabel)
        Me.Controls.Add(Me.UoMLabel)
        Me.Controls.Add(Me.partNumberText)
        Me.Controls.Add(Me.ePrtNumLabel)
        Me.Controls.Add(Me.buttonLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PartInfoDialog"
        Me.ShowInTaskbar = False
        Me.buttonLayoutPanel.ResumeLayout(False)
        CType(Me.impLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Save_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ePrtNumLabel As Windows.Forms.Label
    Friend WithEvents partNumberText As Windows.Forms.TextBox
    Friend WithEvents UoMLabel As Windows.Forms.Label
    Friend WithEvents sDescriptionText As Windows.Forms.TextBox
    Friend WithEvents sDescriptionLabel As Windows.Forms.Label
    Friend WithEvents invTypeLabel As Windows.Forms.Label
    Friend WithEvents engrStatusLabel As Windows.Forms.Label
    Friend WithEvents saleCodeLabel As Windows.Forms.Label
    Friend WithEvents descriptionText As Windows.Forms.TextBox
    Friend WithEvents eDescripLabel As Windows.Forms.Label
    Friend WithEvents leadTimeLabel As Windows.Forms.Label
    Friend WithEvents engrLabel As Windows.Forms.Label
    Friend WithEvents mfgNameText As Windows.Forms.TextBox
    Friend WithEvents mfgNameLabel As Windows.Forms.Label
    Friend WithEvents uomSelect As Windows.Forms.ComboBox
    Friend WithEvents invTypeSelect As Windows.Forms.ComboBox
    Friend WithEvents engStatusSelect As Windows.Forms.ComboBox
    Friend WithEvents salesCodeSelect As Windows.Forms.ComboBox
    Friend WithEvents leadTimeSelect As Windows.Forms.ComboBox
    Friend WithEvents upload_Button As Windows.Forms.Button
    Friend WithEvents hButton As Windows.Forms.Button
    Friend WithEvents impLogo As Windows.Forms.PictureBox
    Friend WithEvents manufacturedStandard As Windows.Forms.Button
    Friend WithEvents purchasedStandard As Windows.Forms.Button
    Friend WithEvents mfgPrtNumText As Windows.Forms.TextBox
    Friend WithEvents mfgPartNumLabel As Windows.Forms.Label
    Friend WithEvents salesOrT As Windows.Forms.TextBox
    Friend WithEvents salesONum As Windows.Forms.Label
    Friend WithEvents companyT As Windows.Forms.TextBox
    Friend WithEvents customerL As Windows.Forms.Label
    Friend WithEvents engineerText As Windows.Forms.ComboBox
End Class
