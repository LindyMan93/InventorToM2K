﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartMaterialDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartMaterialDialog))
        Me.materialLogo = New System.Windows.Forms.PictureBox()
        Me.partNumberText = New System.Windows.Forms.TextBox()
        Me.ePrtNumLabel = New System.Windows.Forms.Label()
        Me.buttonLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.upload_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Calc_Button = New System.Windows.Forms.Button()
        Me.matSelect = New System.Windows.Forms.ComboBox()
        Me.matNumLabel = New System.Windows.Forms.Label()
        Me.amountText = New System.Windows.Forms.TextBox()
        Me.amountLabel = New System.Windows.Forms.Label()
        Me.customButton = New System.Windows.Forms.Button()
        CType(Me.materialLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.buttonLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'materialLogo
        '
        Me.materialLogo.Location = New System.Drawing.Point(12, 12)
        Me.materialLogo.Name = "materialLogo"
        Me.materialLogo.Size = New System.Drawing.Size(64, 64)
        Me.materialLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.materialLogo.TabIndex = 1
        Me.materialLogo.TabStop = False
        '
        'partNumberText
        '
        Me.partNumberText.BackColor = System.Drawing.SystemColors.Control
        Me.partNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.partNumberText.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.partNumberText.ForeColor = System.Drawing.Color.Red
        Me.partNumberText.Location = New System.Drawing.Point(122, 42)
        Me.partNumberText.Name = "partNumberText"
        Me.partNumberText.ReadOnly = True
        Me.partNumberText.Size = New System.Drawing.Size(189, 22)
        Me.partNumberText.TabIndex = 0
        Me.partNumberText.TabStop = False
        Me.partNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ePrtNumLabel
        '
        Me.ePrtNumLabel.AutoSize = True
        Me.ePrtNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ePrtNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ePrtNumLabel.Location = New System.Drawing.Point(159, 12)
        Me.ePrtNumLabel.Name = "ePrtNumLabel"
        Me.ePrtNumLabel.Size = New System.Drawing.Size(116, 27)
        Me.ePrtNumLabel.TabIndex = 3
        Me.ePrtNumLabel.Text = "Part Number"
        Me.ePrtNumLabel.UseCompatibleTextRendering = True
        '
        'buttonLayoutPanel
        '
        Me.buttonLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonLayoutPanel.ColumnCount = 3
        Me.buttonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.42719!))
        Me.buttonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.57281!))
        Me.buttonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.buttonLayoutPanel.Controls.Add(Me.upload_Button, 0, 0)
        Me.buttonLayoutPanel.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.buttonLayoutPanel.Controls.Add(Me.Calc_Button, 1, 0)
        Me.buttonLayoutPanel.Location = New System.Drawing.Point(14, 150)
        Me.buttonLayoutPanel.Name = "buttonLayoutPanel"
        Me.buttonLayoutPanel.RowCount = 1
        Me.buttonLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.buttonLayoutPanel.Size = New System.Drawing.Size(325, 31)
        Me.buttonLayoutPanel.TabIndex = 5
        '
        'upload_Button
        '
        Me.upload_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.upload_Button.BackColor = System.Drawing.Color.LightGreen
        Me.upload_Button.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen
        Me.upload_Button.FlatAppearance.BorderSize = 0
        Me.upload_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.upload_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.upload_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.upload_Button.Location = New System.Drawing.Point(6, 3)
        Me.upload_Button.Name = "upload_Button"
        Me.upload_Button.Size = New System.Drawing.Size(99, 25)
        Me.upload_Button.TabIndex = 3
        Me.upload_Button.Text = "Upload"
        Me.upload_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.MistyRose
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Cancel_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cancel_Button.Location = New System.Drawing.Point(219, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(99, 25)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Calc_Button
        '
        Me.Calc_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Calc_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Calc_Button.FlatAppearance.BorderSize = 0
        Me.Calc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Calc_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Calc_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Calc_Button.Location = New System.Drawing.Point(117, 3)
        Me.Calc_Button.Name = "Calc_Button"
        Me.Calc_Button.Size = New System.Drawing.Size(91, 25)
        Me.Calc_Button.TabIndex = 4
        Me.Calc_Button.Text = "Calculate"
        Me.Calc_Button.UseVisualStyleBackColor = False
        '
        'matSelect
        '
        Me.matSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.matSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.matSelect.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.matSelect.FormattingEnabled = True
        Me.matSelect.Items.AddRange(New Object() {"MTL0100", "MTL0101", "MTL0102", "MTL0103", "MTL0104", "MTL0105", "MTL0110", "MTL0120", "MTL0130", "MTL0200", "MTL0201", "MTL0220", "MTL0300", "MTL0400", "MTL0420", "MTL0500", "MTL0700", "MTL0710", "MTL0720", "MTL0800"})
        Me.matSelect.Location = New System.Drawing.Point(138, 81)
        Me.matSelect.Name = "matSelect"
        Me.matSelect.Size = New System.Drawing.Size(153, 29)
        Me.matSelect.TabIndex = 1
        '
        'matNumLabel
        '
        Me.matNumLabel.AutoSize = True
        Me.matNumLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.matNumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.matNumLabel.Location = New System.Drawing.Point(8, 84)
        Me.matNumLabel.Name = "matNumLabel"
        Me.matNumLabel.Size = New System.Drawing.Size(124, 21)
        Me.matNumLabel.TabIndex = 32
        Me.matNumLabel.Text = "Material Number"
        '
        'amountText
        '
        Me.amountText.AllowDrop = True
        Me.amountText.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.amountText.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.amountText.Location = New System.Drawing.Point(77, 116)
        Me.amountText.MaxLength = 5
        Me.amountText.Name = "amountText"
        Me.amountText.Size = New System.Drawing.Size(264, 26)
        Me.amountText.TabIndex = 2
        '
        'amountLabel
        '
        Me.amountLabel.AutoSize = True
        Me.amountLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.amountLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.amountLabel.Location = New System.Drawing.Point(8, 119)
        Me.amountLabel.Name = "amountLabel"
        Me.amountLabel.Size = New System.Drawing.Size(63, 21)
        Me.amountLabel.TabIndex = 31
        Me.amountLabel.Text = "Amount"
        '
        'customButton
        '
        Me.customButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.customButton.BackColor = System.Drawing.SystemColors.Control
        Me.customButton.FlatAppearance.BorderSize = 0
        Me.customButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.customButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.customButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.customButton.Location = New System.Drawing.Point(297, 83)
        Me.customButton.Name = "customButton"
        Me.customButton.Size = New System.Drawing.Size(44, 25)
        Me.customButton.TabIndex = 33
        Me.customButton.Text = "Add"
        Me.customButton.UseVisualStyleBackColor = False
        '
        'PartMaterialDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 193)
        Me.Controls.Add(Me.customButton)
        Me.Controls.Add(Me.matSelect)
        Me.Controls.Add(Me.matNumLabel)
        Me.Controls.Add(Me.amountText)
        Me.Controls.Add(Me.amountLabel)
        Me.Controls.Add(Me.buttonLayoutPanel)
        Me.Controls.Add(Me.partNumberText)
        Me.Controls.Add(Me.ePrtNumLabel)
        Me.Controls.Add(Me.materialLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PartMaterialDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Part Material"
        Me.TopMost = True
        CType(Me.materialLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.buttonLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents materialLogo As Windows.Forms.PictureBox
    Friend WithEvents partNumberText As Windows.Forms.TextBox
    Friend WithEvents ePrtNumLabel As Windows.Forms.Label
    Friend WithEvents buttonLayoutPanel As Windows.Forms.TableLayoutPanel
    Friend WithEvents upload_Button As Windows.Forms.Button
    Friend WithEvents Cancel_Button As Windows.Forms.Button
    Friend WithEvents Calc_Button As Windows.Forms.Button
    Friend WithEvents matSelect As Windows.Forms.ComboBox
    Friend WithEvents matNumLabel As Windows.Forms.Label
    Friend WithEvents amountText As Windows.Forms.TextBox
    Friend WithEvents amountLabel As Windows.Forms.Label
    Friend WithEvents customButton As Windows.Forms.Button
End Class
