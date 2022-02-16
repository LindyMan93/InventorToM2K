<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckAllDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckAllDialog))
        Me.checkAllLogo = New System.Windows.Forms.PictureBox()
        Me.bomInstructions = New System.Windows.Forms.TextBox()
        Me.checkAllTable = New System.Windows.Forms.DataGridView()
        Me.prtNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.partMasterPush = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bomPush = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.routPush = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.checkAllLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkAllTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkAllLogo
        '
        Me.checkAllLogo.Location = New System.Drawing.Point(12, 12)
        Me.checkAllLogo.Name = "checkAllLogo"
        Me.checkAllLogo.Size = New System.Drawing.Size(64, 64)
        Me.checkAllLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkAllLogo.TabIndex = 1
        Me.checkAllLogo.TabStop = False
        '
        'bomInstructions
        '
        Me.bomInstructions.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bomInstructions.Location = New System.Drawing.Point(82, 12)
        Me.bomInstructions.Multiline = True
        Me.bomInstructions.Name = "bomInstructions"
        Me.bomInstructions.ReadOnly = True
        Me.bomInstructions.Size = New System.Drawing.Size(247, 64)
        Me.bomInstructions.TabIndex = 6
        Me.bomInstructions.Text = "Output:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Part Numbers that have not pushed all information."
        Me.bomInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'checkAllTable
        '
        Me.checkAllTable.AllowUserToAddRows = False
        Me.checkAllTable.AllowUserToDeleteRows = False
        Me.checkAllTable.AllowUserToResizeRows = False
        Me.checkAllTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.checkAllTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.checkAllTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prtNum, Me.partMasterPush, Me.bomPush, Me.routPush})
        Me.checkAllTable.Location = New System.Drawing.Point(13, 82)
        Me.checkAllTable.Name = "checkAllTable"
        Me.checkAllTable.ReadOnly = True
        Me.checkAllTable.RowHeadersVisible = False
        Me.checkAllTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.checkAllTable.Size = New System.Drawing.Size(317, 206)
        Me.checkAllTable.TabIndex = 5
        '
        'prtNum
        '
        Me.prtNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prtNum.FillWeight = 15.87302!
        Me.prtNum.HeaderText = "Part Number"
        Me.prtNum.Name = "prtNum"
        Me.prtNum.ReadOnly = True
        '
        'partMasterPush
        '
        Me.partMasterPush.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.partMasterPush.HeaderText = "PM"
        Me.partMasterPush.Name = "partMasterPush"
        Me.partMasterPush.ReadOnly = True
        Me.partMasterPush.Width = 29
        '
        'bomPush
        '
        Me.bomPush.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.bomPush.HeaderText = "BOM"
        Me.bomPush.Name = "bomPush"
        Me.bomPush.ReadOnly = True
        Me.bomPush.Width = 37
        '
        'routPush
        '
        Me.routPush.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.routPush.HeaderText = "Rout"
        Me.routPush.Name = "routPush"
        Me.routPush.ReadOnly = True
        Me.routPush.Width = 36
        '
        'CheckAllDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 300)
        Me.Controls.Add(Me.bomInstructions)
        Me.Controls.Add(Me.checkAllTable)
        Me.Controls.Add(Me.checkAllLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CheckAllDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Check All Imports"
        CType(Me.checkAllLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkAllTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents checkAllLogo As Windows.Forms.PictureBox
    Friend WithEvents bomInstructions As Windows.Forms.TextBox
    Friend WithEvents checkAllTable As Windows.Forms.DataGridView
    Friend WithEvents prtNum As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents partMasterPush As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents bomPush As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents routPush As Windows.Forms.DataGridViewCheckBoxColumn
End Class
