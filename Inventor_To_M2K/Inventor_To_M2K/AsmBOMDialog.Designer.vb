<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AsmBOMDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsmBOMDialog))
        Me.billOfMaterials = New System.Windows.Forms.DataGridView()
        Me.prtNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.included = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.bomInstructions = New System.Windows.Forms.TextBox()
        Me.buttonLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.upload_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        CType(Me.billOfMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.buttonLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'billOfMaterials
        '
        Me.billOfMaterials.AllowUserToDeleteRows = False
        Me.billOfMaterials.AllowUserToResizeRows = False
        Me.billOfMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.billOfMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billOfMaterials.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prtNum, Me.qty, Me.included})
        Me.billOfMaterials.Location = New System.Drawing.Point(12, 164)
        Me.billOfMaterials.Name = "billOfMaterials"
        Me.billOfMaterials.RowHeadersVisible = False
        Me.billOfMaterials.Size = New System.Drawing.Size(366, 261)
        Me.billOfMaterials.TabIndex = 1
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
        Me.qty.Width = 71
        '
        'included
        '
        Me.included.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.included.FillWeight = 184.127!
        Me.included.HeaderText = "Included?"
        Me.included.Name = "included"
        Me.included.Width = 75
        '
        'logo
        '
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(64, 64)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 3
        Me.logo.TabStop = False
        '
        'bomInstructions
        '
        Me.bomInstructions.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bomInstructions.Location = New System.Drawing.Point(87, 12)
        Me.bomInstructions.Multiline = True
        Me.bomInstructions.Name = "bomInstructions"
        Me.bomInstructions.ReadOnly = True
        Me.bomInstructions.Size = New System.Drawing.Size(291, 146)
        Me.bomInstructions.TabIndex = 4
        Me.bomInstructions.Text = resources.GetString("bomInstructions.Text")
        Me.bomInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'buttonLayoutPanel
        '
        Me.buttonLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonLayoutPanel.ColumnCount = 2
        Me.buttonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.buttonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.buttonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.buttonLayoutPanel.Controls.Add(Me.upload_Button, 0, 0)
        Me.buttonLayoutPanel.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.buttonLayoutPanel.Location = New System.Drawing.Point(151, 433)
        Me.buttonLayoutPanel.Name = "buttonLayoutPanel"
        Me.buttonLayoutPanel.RowCount = 1
        Me.buttonLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.buttonLayoutPanel.Size = New System.Drawing.Size(227, 31)
        Me.buttonLayoutPanel.TabIndex = 6
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
        Me.upload_Button.Location = New System.Drawing.Point(5, 3)
        Me.upload_Button.Name = "upload_Button"
        Me.upload_Button.Size = New System.Drawing.Size(100, 25)
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
        Me.Cancel_Button.Location = New System.Drawing.Point(118, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 25)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'AsmBOMDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(390, 476)
        Me.Controls.Add(Me.buttonLayoutPanel)
        Me.Controls.Add(Me.bomInstructions)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.billOfMaterials)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AsmBOMDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bill Of Materials"
        CType(Me.billOfMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.buttonLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents billOfMaterials As Windows.Forms.DataGridView
    Friend WithEvents logo As Windows.Forms.PictureBox
    Friend WithEvents bomInstructions As Windows.Forms.TextBox
    Friend WithEvents buttonLayoutPanel As Windows.Forms.TableLayoutPanel
    Friend WithEvents upload_Button As Windows.Forms.Button
    Friend WithEvents Cancel_Button As Windows.Forms.Button
    Friend WithEvents prtNum As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents included As Windows.Forms.DataGridViewCheckBoxColumn
End Class
