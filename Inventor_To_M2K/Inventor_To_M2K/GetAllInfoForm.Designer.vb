<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetAllInfoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GetAllInfoForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.updateB = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.imTable = New System.Windows.Forms.DataGridView()
        Me.routTable = New System.Windows.Forms.DataGridView()
        Me.bomTable = New System.Windows.Forms.DataGridView()
        Me.imLabel = New System.Windows.Forms.Label()
        Me.bomLabel = New System.Windows.Forms.Label()
        Me.routLabel = New System.Windows.Forms.Label()
        Me.topLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.imTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.routTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bomTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.updateB, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(708, 549)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(237, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'updateB
        '
        Me.updateB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.updateB.Location = New System.Drawing.Point(83, 3)
        Me.updateB.Name = "updateB"
        Me.updateB.Size = New System.Drawing.Size(67, 23)
        Me.updateB.TabIndex = 2
        Me.updateB.Text = "Update"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(5, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(163, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'imTable
        '
        Me.imTable.AllowUserToAddRows = False
        Me.imTable.AllowUserToDeleteRows = False
        Me.imTable.AllowUserToResizeRows = False
        Me.imTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.imTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.imTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.imTable.Location = New System.Drawing.Point(12, 105)
        Me.imTable.Name = "imTable"
        Me.imTable.ReadOnly = True
        Me.imTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.imTable.Size = New System.Drawing.Size(933, 189)
        Me.imTable.TabIndex = 6
        '
        'routTable
        '
        Me.routTable.AllowUserToAddRows = False
        Me.routTable.AllowUserToDeleteRows = False
        Me.routTable.AllowUserToResizeRows = False
        Me.routTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.routTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.routTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.routTable.Location = New System.Drawing.Point(385, 356)
        Me.routTable.Name = "routTable"
        Me.routTable.ReadOnly = True
        Me.routTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.routTable.Size = New System.Drawing.Size(560, 187)
        Me.routTable.TabIndex = 7
        '
        'bomTable
        '
        Me.bomTable.AllowUserToAddRows = False
        Me.bomTable.AllowUserToDeleteRows = False
        Me.bomTable.AllowUserToResizeRows = False
        Me.bomTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.bomTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bomTable.Location = New System.Drawing.Point(12, 356)
        Me.bomTable.Name = "bomTable"
        Me.bomTable.ReadOnly = True
        Me.bomTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.bomTable.Size = New System.Drawing.Size(367, 187)
        Me.bomTable.TabIndex = 8
        '
        'imLabel
        '
        Me.imLabel.AutoSize = True
        Me.imLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imLabel.Location = New System.Drawing.Point(380, 66)
        Me.imLabel.Name = "imLabel"
        Me.imLabel.Size = New System.Drawing.Size(188, 26)
        Me.imLabel.TabIndex = 9
        Me.imLabel.Text = "Item Master Table"
        '
        'bomLabel
        '
        Me.bomLabel.AutoSize = True
        Me.bomLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bomLabel.Location = New System.Drawing.Point(112, 314)
        Me.bomLabel.Name = "bomLabel"
        Me.bomLabel.Size = New System.Drawing.Size(169, 26)
        Me.bomLabel.TabIndex = 10
        Me.bomLabel.Text = "Bill Of Materials"
        '
        'routLabel
        '
        Me.routLabel.AutoSize = True
        Me.routLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.routLabel.Location = New System.Drawing.Point(596, 314)
        Me.routLabel.Name = "routLabel"
        Me.routLabel.Size = New System.Drawing.Size(145, 26)
        Me.routLabel.TabIndex = 11
        Me.routLabel.Text = "Routing Table"
        '
        'topLabel
        '
        Me.topLabel.AutoSize = True
        Me.topLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.topLabel.Location = New System.Drawing.Point(279, 9)
        Me.topLabel.Name = "topLabel"
        Me.topLabel.Size = New System.Drawing.Size(400, 37)
        Me.topLabel.TabIndex = 12
        Me.topLabel.Text = "Current Values In SQL Server"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Inventor_To_M2K.My.Resources.Resources.NRL_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(78, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'GetAllInfoForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(957, 590)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.topLabel)
        Me.Controls.Add(Me.routLabel)
        Me.Controls.Add(Me.bomLabel)
        Me.Controls.Add(Me.imLabel)
        Me.Controls.Add(Me.bomTable)
        Me.Controls.Add(Me.routTable)
        Me.Controls.Add(Me.imTable)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GetAllInfoForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SQL Information"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.imTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.routTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bomTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents updateB As Windows.Forms.Button
    Friend WithEvents imTable As Windows.Forms.DataGridView
    Friend WithEvents routTable As Windows.Forms.DataGridView
    Friend WithEvents bomTable As Windows.Forms.DataGridView
    Friend WithEvents imLabel As Windows.Forms.Label
    Friend WithEvents bomLabel As Windows.Forms.Label
    Friend WithEvents routLabel As Windows.Forms.Label
    Friend WithEvents topLabel As Windows.Forms.Label
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
