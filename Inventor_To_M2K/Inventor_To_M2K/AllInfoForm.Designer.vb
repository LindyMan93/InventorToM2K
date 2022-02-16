<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllInfoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllInfoForm))
        Me.mfgPartNumLabel = New System.Windows.Forms.Label()
        Me.mfgNameLabel = New System.Windows.Forms.Label()
        Me.leadTimeLabel = New System.Windows.Forms.Label()
        Me.engrLabel = New System.Windows.Forms.Label()
        Me.invTypeLabel = New System.Windows.Forms.Label()
        Me.engrStatusLabel = New System.Windows.Forms.Label()
        Me.saleCodeLabel = New System.Windows.Forms.Label()
        Me.eDescripLabel = New System.Windows.Forms.Label()
        Me.sDescriptionLabel = New System.Windows.Forms.Label()
        Me.UoMLabel = New System.Windows.Forms.Label()
        Me.partNumberText = New System.Windows.Forms.TextBox()
        Me.ePrtNumLabel = New System.Windows.Forms.Label()
        Me.mfgPrtNumText = New System.Windows.Forms.TextBox()
        Me.mfgNameText = New System.Windows.Forms.TextBox()
        Me.descriptionText = New System.Windows.Forms.TextBox()
        Me.sDescriptionText = New System.Windows.Forms.TextBox()
        Me.uomText = New System.Windows.Forms.TextBox()
        Me.invTypeText = New System.Windows.Forms.TextBox()
        Me.engStatText = New System.Windows.Forms.TextBox()
        Me.salesCodeText = New System.Windows.Forms.TextBox()
        Me.ltCodeText = New System.Windows.Forms.TextBox()
        Me.engText = New System.Windows.Forms.TextBox()
        Me.bomTable = New System.Windows.Forms.DataGridView()
        Me.routTable = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bomBox = New System.Windows.Forms.GroupBox()
        Me.routBox = New System.Windows.Forms.GroupBox()
        CType(Me.bomTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.routTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bomBox.SuspendLayout()
        Me.routBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'mfgPartNumLabel
        '
        Me.mfgPartNumLabel.AutoSize = True
        Me.mfgPartNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.mfgPartNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mfgPartNumLabel.Location = New System.Drawing.Point(8, 259)
        Me.mfgPartNumLabel.Name = "mfgPartNumLabel"
        Me.mfgPartNumLabel.Size = New System.Drawing.Size(130, 21)
        Me.mfgPartNumLabel.TabIndex = 42
        Me.mfgPartNumLabel.Text = "Mfg. Part Number"
        '
        'mfgNameLabel
        '
        Me.mfgNameLabel.AutoSize = True
        Me.mfgNameLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.mfgNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mfgNameLabel.Location = New System.Drawing.Point(8, 227)
        Me.mfgNameLabel.Name = "mfgNameLabel"
        Me.mfgNameLabel.Size = New System.Drawing.Size(84, 21)
        Me.mfgNameLabel.TabIndex = 41
        Me.mfgNameLabel.Text = "Mfg. Name"
        '
        'leadTimeLabel
        '
        Me.leadTimeLabel.AutoSize = True
        Me.leadTimeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.leadTimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.leadTimeLabel.Location = New System.Drawing.Point(369, 227)
        Me.leadTimeLabel.Name = "leadTimeLabel"
        Me.leadTimeLabel.Size = New System.Drawing.Size(118, 21)
        Me.leadTimeLabel.TabIndex = 40
        Me.leadTimeLabel.Text = "Lead Time Code"
        '
        'engrLabel
        '
        Me.engrLabel.AutoSize = True
        Me.engrLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.engrLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.engrLabel.Location = New System.Drawing.Point(369, 259)
        Me.engrLabel.Name = "engrLabel"
        Me.engrLabel.Size = New System.Drawing.Size(70, 21)
        Me.engrLabel.TabIndex = 39
        Me.engrLabel.Text = "Engineer"
        '
        'invTypeLabel
        '
        Me.invTypeLabel.AutoSize = True
        Me.invTypeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.invTypeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.invTypeLabel.Location = New System.Drawing.Point(369, 165)
        Me.invTypeLabel.Name = "invTypeLabel"
        Me.invTypeLabel.Size = New System.Drawing.Size(108, 21)
        Me.invTypeLabel.TabIndex = 38
        Me.invTypeLabel.Text = "Inventory Type"
        '
        'engrStatusLabel
        '
        Me.engrStatusLabel.AutoSize = True
        Me.engrStatusLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.engrStatusLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.engrStatusLabel.Location = New System.Drawing.Point(369, 101)
        Me.engrStatusLabel.Name = "engrStatusLabel"
        Me.engrStatusLabel.Size = New System.Drawing.Size(88, 21)
        Me.engrStatusLabel.TabIndex = 37
        Me.engrStatusLabel.Text = "Engr Status"
        '
        'saleCodeLabel
        '
        Me.saleCodeLabel.AutoSize = True
        Me.saleCodeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.saleCodeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.saleCodeLabel.Location = New System.Drawing.Point(369, 197)
        Me.saleCodeLabel.Name = "saleCodeLabel"
        Me.saleCodeLabel.Size = New System.Drawing.Size(84, 21)
        Me.saleCodeLabel.TabIndex = 36
        Me.saleCodeLabel.Text = "Sales Code"
        '
        'eDescripLabel
        '
        Me.eDescripLabel.AutoSize = True
        Me.eDescripLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.eDescripLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.eDescripLabel.Location = New System.Drawing.Point(8, 125)
        Me.eDescripLabel.Name = "eDescripLabel"
        Me.eDescripLabel.Size = New System.Drawing.Size(154, 21)
        Me.eDescripLabel.TabIndex = 35
        Me.eDescripLabel.Text = "Extended Description"
        '
        'sDescriptionLabel
        '
        Me.sDescriptionLabel.AutoSize = True
        Me.sDescriptionLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.sDescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sDescriptionLabel.Location = New System.Drawing.Point(8, 97)
        Me.sDescriptionLabel.Name = "sDescriptionLabel"
        Me.sDescriptionLabel.Size = New System.Drawing.Size(120, 21)
        Me.sDescriptionLabel.TabIndex = 34
        Me.sDescriptionLabel.Text = "Item Description"
        '
        'UoMLabel
        '
        Me.UoMLabel.AutoSize = True
        Me.UoMLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.UoMLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UoMLabel.Location = New System.Drawing.Point(369, 133)
        Me.UoMLabel.Name = "UoMLabel"
        Me.UoMLabel.Size = New System.Drawing.Size(119, 21)
        Me.UoMLabel.TabIndex = 33
        Me.UoMLabel.Text = "Unit Of Measure"
        '
        'partNumberText
        '
        Me.partNumberText.BackColor = System.Drawing.SystemColors.Control
        Me.partNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.partNumberText.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.partNumberText.ForeColor = System.Drawing.Color.Red
        Me.partNumberText.Location = New System.Drawing.Point(303, 34)
        Me.partNumberText.Name = "partNumberText"
        Me.partNumberText.ReadOnly = True
        Me.partNumberText.Size = New System.Drawing.Size(208, 22)
        Me.partNumberText.TabIndex = 32
        Me.partNumberText.TabStop = False
        '
        'ePrtNumLabel
        '
        Me.ePrtNumLabel.AutoSize = True
        Me.ePrtNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ePrtNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ePrtNumLabel.Location = New System.Drawing.Point(181, 34)
        Me.ePrtNumLabel.Name = "ePrtNumLabel"
        Me.ePrtNumLabel.Size = New System.Drawing.Size(116, 27)
        Me.ePrtNumLabel.TabIndex = 31
        Me.ePrtNumLabel.Text = "Part Number"
        Me.ePrtNumLabel.UseCompatibleTextRendering = True
        '
        'mfgPrtNumText
        '
        Me.mfgPrtNumText.AllowDrop = True
        Me.mfgPrtNumText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.mfgPrtNumText.Location = New System.Drawing.Point(144, 256)
        Me.mfgPrtNumText.MaxLength = 25
        Me.mfgPrtNumText.Name = "mfgPrtNumText"
        Me.mfgPrtNumText.ReadOnly = True
        Me.mfgPrtNumText.Size = New System.Drawing.Size(219, 26)
        Me.mfgPrtNumText.TabIndex = 50
        '
        'mfgNameText
        '
        Me.mfgNameText.AllowDrop = True
        Me.mfgNameText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.mfgNameText.Location = New System.Drawing.Point(98, 224)
        Me.mfgNameText.MaxLength = 25
        Me.mfgNameText.Name = "mfgNameText"
        Me.mfgNameText.ReadOnly = True
        Me.mfgNameText.Size = New System.Drawing.Size(265, 26)
        Me.mfgNameText.TabIndex = 49
        '
        'descriptionText
        '
        Me.descriptionText.AllowDrop = True
        Me.descriptionText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.descriptionText.Location = New System.Drawing.Point(12, 149)
        Me.descriptionText.Multiline = True
        Me.descriptionText.Name = "descriptionText"
        Me.descriptionText.ReadOnly = True
        Me.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.descriptionText.Size = New System.Drawing.Size(351, 69)
        Me.descriptionText.TabIndex = 46
        '
        'sDescriptionText
        '
        Me.sDescriptionText.AllowDrop = True
        Me.sDescriptionText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.sDescriptionText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.sDescriptionText.Location = New System.Drawing.Point(130, 96)
        Me.sDescriptionText.MaxLength = 25
        Me.sDescriptionText.Name = "sDescriptionText"
        Me.sDescriptionText.ReadOnly = True
        Me.sDescriptionText.Size = New System.Drawing.Size(228, 26)
        Me.sDescriptionText.TabIndex = 45
        '
        'uomText
        '
        Me.uomText.AllowDrop = True
        Me.uomText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.uomText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.uomText.Location = New System.Drawing.Point(494, 130)
        Me.uomText.MaxLength = 25
        Me.uomText.Name = "uomText"
        Me.uomText.ReadOnly = True
        Me.uomText.Size = New System.Drawing.Size(41, 26)
        Me.uomText.TabIndex = 51
        '
        'invTypeText
        '
        Me.invTypeText.AllowDrop = True
        Me.invTypeText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.invTypeText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.invTypeText.Location = New System.Drawing.Point(483, 162)
        Me.invTypeText.MaxLength = 25
        Me.invTypeText.Name = "invTypeText"
        Me.invTypeText.ReadOnly = True
        Me.invTypeText.Size = New System.Drawing.Size(52, 26)
        Me.invTypeText.TabIndex = 52
        '
        'engStatText
        '
        Me.engStatText.AllowDrop = True
        Me.engStatText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.engStatText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.engStatText.Location = New System.Drawing.Point(463, 98)
        Me.engStatText.MaxLength = 25
        Me.engStatText.Name = "engStatText"
        Me.engStatText.ReadOnly = True
        Me.engStatText.Size = New System.Drawing.Size(72, 26)
        Me.engStatText.TabIndex = 53
        '
        'salesCodeText
        '
        Me.salesCodeText.AllowDrop = True
        Me.salesCodeText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.salesCodeText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.salesCodeText.Location = New System.Drawing.Point(459, 192)
        Me.salesCodeText.MaxLength = 25
        Me.salesCodeText.Name = "salesCodeText"
        Me.salesCodeText.ReadOnly = True
        Me.salesCodeText.Size = New System.Drawing.Size(76, 26)
        Me.salesCodeText.TabIndex = 54
        '
        'ltCodeText
        '
        Me.ltCodeText.AllowDrop = True
        Me.ltCodeText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.ltCodeText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.ltCodeText.Location = New System.Drawing.Point(493, 224)
        Me.ltCodeText.MaxLength = 25
        Me.ltCodeText.Name = "ltCodeText"
        Me.ltCodeText.ReadOnly = True
        Me.ltCodeText.Size = New System.Drawing.Size(42, 26)
        Me.ltCodeText.TabIndex = 55
        '
        'engText
        '
        Me.engText.AllowDrop = True
        Me.engText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.engText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.engText.Location = New System.Drawing.Point(445, 256)
        Me.engText.MaxLength = 25
        Me.engText.Name = "engText"
        Me.engText.ReadOnly = True
        Me.engText.Size = New System.Drawing.Size(90, 26)
        Me.engText.TabIndex = 56
        '
        'bomTable
        '
        Me.bomTable.AllowUserToAddRows = False
        Me.bomTable.AllowUserToDeleteRows = False
        Me.bomTable.AllowUserToResizeRows = False
        Me.bomTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.bomTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bomTable.Location = New System.Drawing.Point(6, 19)
        Me.bomTable.Name = "bomTable"
        Me.bomTable.ReadOnly = True
        Me.bomTable.RowHeadersVisible = False
        Me.bomTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.bomTable.Size = New System.Drawing.Size(173, 122)
        Me.bomTable.TabIndex = 57
        '
        'routTable
        '
        Me.routTable.AllowUserToAddRows = False
        Me.routTable.AllowUserToDeleteRows = False
        Me.routTable.AllowUserToResizeRows = False
        Me.routTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.routTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.routTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.routTable.Location = New System.Drawing.Point(11, 19)
        Me.routTable.Name = "routTable"
        Me.routTable.ReadOnly = True
        Me.routTable.RowHeadersVisible = False
        Me.routTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.routTable.Size = New System.Drawing.Size(315, 122)
        Me.routTable.TabIndex = 59
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'bomBox
        '
        Me.bomBox.Controls.Add(Me.bomTable)
        Me.bomBox.Location = New System.Drawing.Point(12, 298)
        Me.bomBox.Name = "bomBox"
        Me.bomBox.Size = New System.Drawing.Size(185, 152)
        Me.bomBox.TabIndex = 62
        Me.bomBox.TabStop = False
        Me.bomBox.Text = "Bill Of Materials"
        '
        'routBox
        '
        Me.routBox.Controls.Add(Me.routTable)
        Me.routBox.Location = New System.Drawing.Point(203, 298)
        Me.routBox.Name = "routBox"
        Me.routBox.Size = New System.Drawing.Size(332, 152)
        Me.routBox.TabIndex = 63
        Me.routBox.TabStop = False
        Me.routBox.Text = "Routings"
        '
        'AllInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 459)
        Me.Controls.Add(Me.routBox)
        Me.Controls.Add(Me.bomBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.engText)
        Me.Controls.Add(Me.ltCodeText)
        Me.Controls.Add(Me.salesCodeText)
        Me.Controls.Add(Me.engStatText)
        Me.Controls.Add(Me.invTypeText)
        Me.Controls.Add(Me.uomText)
        Me.Controls.Add(Me.mfgPrtNumText)
        Me.Controls.Add(Me.mfgNameText)
        Me.Controls.Add(Me.descriptionText)
        Me.Controls.Add(Me.sDescriptionText)
        Me.Controls.Add(Me.mfgPartNumLabel)
        Me.Controls.Add(Me.mfgNameLabel)
        Me.Controls.Add(Me.leadTimeLabel)
        Me.Controls.Add(Me.engrLabel)
        Me.Controls.Add(Me.invTypeLabel)
        Me.Controls.Add(Me.engrStatusLabel)
        Me.Controls.Add(Me.saleCodeLabel)
        Me.Controls.Add(Me.eDescripLabel)
        Me.Controls.Add(Me.sDescriptionLabel)
        Me.Controls.Add(Me.UoMLabel)
        Me.Controls.Add(Me.partNumberText)
        Me.Controls.Add(Me.ePrtNumLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AllInfoForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "All Pushed Information"
        CType(Me.bomTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.routTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bomBox.ResumeLayout(False)
        Me.routBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mfgPartNumLabel As Windows.Forms.Label
    Friend WithEvents mfgNameLabel As Windows.Forms.Label
    Friend WithEvents leadTimeLabel As Windows.Forms.Label
    Friend WithEvents engrLabel As Windows.Forms.Label
    Friend WithEvents invTypeLabel As Windows.Forms.Label
    Friend WithEvents engrStatusLabel As Windows.Forms.Label
    Friend WithEvents saleCodeLabel As Windows.Forms.Label
    Friend WithEvents eDescripLabel As Windows.Forms.Label
    Friend WithEvents sDescriptionLabel As Windows.Forms.Label
    Friend WithEvents UoMLabel As Windows.Forms.Label
    Friend WithEvents partNumberText As Windows.Forms.TextBox
    Friend WithEvents ePrtNumLabel As Windows.Forms.Label
    Friend WithEvents mfgPrtNumText As Windows.Forms.TextBox
    Friend WithEvents mfgNameText As Windows.Forms.TextBox
    Friend WithEvents descriptionText As Windows.Forms.TextBox
    Friend WithEvents sDescriptionText As Windows.Forms.TextBox
    Friend WithEvents uomText As Windows.Forms.TextBox
    Friend WithEvents invTypeText As Windows.Forms.TextBox
    Friend WithEvents engStatText As Windows.Forms.TextBox
    Friend WithEvents salesCodeText As Windows.Forms.TextBox
    Friend WithEvents ltCodeText As Windows.Forms.TextBox
    Friend WithEvents engText As Windows.Forms.TextBox
    Friend WithEvents bomTable As Windows.Forms.DataGridView
    Friend WithEvents routTable As Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents bomBox As Windows.Forms.GroupBox
    Friend WithEvents routBox As Windows.Forms.GroupBox
End Class
