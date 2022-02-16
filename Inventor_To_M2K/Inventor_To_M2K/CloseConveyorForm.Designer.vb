<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloseConveyorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CloseConveyorForm))
        Me.buttonLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DCCLogo = New System.Windows.Forms.PictureBox()
        Me.selectParts = New System.Windows.Forms.DataGridView()
        Me.prtNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updateInfo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.compDef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonLayoutPanel.SuspendLayout()
        CType(Me.DCCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.selectParts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonLayoutPanel
        '
        Me.buttonLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonLayoutPanel.ColumnCount = 2
        Me.buttonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.buttonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.buttonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.buttonLayoutPanel.Controls.Add(Me.OK_Button, 0, 0)
        Me.buttonLayoutPanel.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.buttonLayoutPanel.Location = New System.Drawing.Point(12, 338)
        Me.buttonLayoutPanel.Name = "buttonLayoutPanel"
        Me.buttonLayoutPanel.RowCount = 1
        Me.buttonLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.buttonLayoutPanel.Size = New System.Drawing.Size(214, 31)
        Me.buttonLayoutPanel.TabIndex = 1
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.LightGreen
        Me.OK_Button.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.OK_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(98, 25)
        Me.OK_Button.TabIndex = 13
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
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
        Me.Cancel_Button.Location = New System.Drawing.Point(109, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(99, 25)
        Me.Cancel_Button.TabIndex = 15
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'DCCLogo
        '
        Me.DCCLogo.Location = New System.Drawing.Point(95, 13)
        Me.DCCLogo.Name = "DCCLogo"
        Me.DCCLogo.Size = New System.Drawing.Size(45, 45)
        Me.DCCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DCCLogo.TabIndex = 2
        Me.DCCLogo.TabStop = False
        '
        'selectParts
        '
        Me.selectParts.AllowUserToAddRows = False
        Me.selectParts.AllowUserToDeleteRows = False
        Me.selectParts.AllowUserToResizeRows = False
        Me.selectParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.selectParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.selectParts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prtNum, Me.updateInfo, Me.compDef})
        Me.selectParts.Location = New System.Drawing.Point(12, 64)
        Me.selectParts.Name = "selectParts"
        Me.selectParts.RowHeadersVisible = False
        Me.selectParts.Size = New System.Drawing.Size(214, 265)
        Me.selectParts.TabIndex = 3
        '
        'prtNum
        '
        Me.prtNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prtNum.FillWeight = 15.87302!
        Me.prtNum.HeaderText = "Part Number"
        Me.prtNum.Name = "prtNum"
        Me.prtNum.ReadOnly = True
        '
        'updateInfo
        '
        Me.updateInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.updateInfo.FillWeight = 184.127!
        Me.updateInfo.HeaderText = "Update Info?"
        Me.updateInfo.Name = "updateInfo"
        Me.updateInfo.Width = 75
        '
        'compDef
        '
        Me.compDef.HeaderText = "docInfo"
        Me.compDef.Name = "compDef"
        Me.compDef.ReadOnly = True
        Me.compDef.Visible = False
        '
        'CloseConveyorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 381)
        Me.Controls.Add(Me.selectParts)
        Me.Controls.Add(Me.DCCLogo)
        Me.Controls.Add(Me.buttonLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CloseConveyorForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Selection"
        Me.buttonLayoutPanel.ResumeLayout(False)
        CType(Me.DCCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.selectParts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonLayoutPanel As Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As Windows.Forms.Button
    Friend WithEvents Cancel_Button As Windows.Forms.Button
    Friend WithEvents DCCLogo As Windows.Forms.PictureBox
    Friend WithEvents selectParts As Windows.Forms.DataGridView
    Friend WithEvents prtNum As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents updateInfo As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents compDef As Windows.Forms.DataGridViewTextBoxColumn
End Class
