<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hardInsert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hardInsert))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.selectEdgesB = New System.Windows.Forms.Button()
        Me.holeEdgesT = New System.Windows.Forms.TextBox()
        Me.selectHwEdge = New System.Windows.Forms.Button()
        Me.hwEdgesT = New System.Windows.Forms.TextBox()
        Me.insertLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.offsetText = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.insertLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(143, 98)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'selectEdgesB
        '
        Me.selectEdgesB.Location = New System.Drawing.Point(159, 41)
        Me.selectEdgesB.Name = "selectEdgesB"
        Me.selectEdgesB.Size = New System.Drawing.Size(133, 23)
        Me.selectEdgesB.TabIndex = 1
        Me.selectEdgesB.Text = "Select Edge(s)"
        Me.selectEdgesB.UseVisualStyleBackColor = True
        '
        'holeEdgesT
        '
        Me.holeEdgesT.Location = New System.Drawing.Point(126, 41)
        Me.holeEdgesT.Name = "holeEdgesT"
        Me.holeEdgesT.ReadOnly = True
        Me.holeEdgesT.Size = New System.Drawing.Size(27, 20)
        Me.holeEdgesT.TabIndex = 2
        '
        'selectHwEdge
        '
        Me.selectHwEdge.Location = New System.Drawing.Point(159, 12)
        Me.selectHwEdge.Name = "selectHwEdge"
        Me.selectHwEdge.Size = New System.Drawing.Size(133, 23)
        Me.selectHwEdge.TabIndex = 3
        Me.selectHwEdge.Text = "Select Hardware Edge"
        Me.selectHwEdge.UseVisualStyleBackColor = True
        '
        'hwEdgesT
        '
        Me.hwEdgesT.Location = New System.Drawing.Point(126, 15)
        Me.hwEdgesT.Name = "hwEdgesT"
        Me.hwEdgesT.ReadOnly = True
        Me.hwEdgesT.Size = New System.Drawing.Size(27, 20)
        Me.hwEdgesT.TabIndex = 4
        '
        'insertLogo
        '
        Me.insertLogo.Image = Global.Inventor_To_M2K.My.Resources.Resources.insert_Icon
        Me.insertLogo.Location = New System.Drawing.Point(12, 12)
        Me.insertLogo.Name = "insertLogo"
        Me.insertLogo.Size = New System.Drawing.Size(108, 114)
        Me.insertLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.insertLogo.TabIndex = 5
        Me.insertLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Offset: "
        '
        'offsetText
        '
        Me.offsetText.BackColor = System.Drawing.SystemColors.Window
        Me.offsetText.Location = New System.Drawing.Point(173, 71)
        Me.offsetText.MaxLength = 6
        Me.offsetText.Name = "offsetText"
        Me.offsetText.Size = New System.Drawing.Size(119, 20)
        Me.offsetText.TabIndex = 8
        '
        'hardInsert
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(301, 139)
        Me.Controls.Add(Me.offsetText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.insertLogo)
        Me.Controls.Add(Me.hwEdgesT)
        Me.Controls.Add(Me.selectHwEdge)
        Me.Controls.Add(Me.holeEdgesT)
        Me.Controls.Add(Me.selectEdgesB)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "hardInsert"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Hardware Insert"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.insertLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents selectEdgesB As Windows.Forms.Button
    Friend WithEvents holeEdgesT As Windows.Forms.TextBox
    Friend WithEvents selectHwEdge As Windows.Forms.Button
    Friend WithEvents hwEdgesT As Windows.Forms.TextBox
    Friend WithEvents insertLogo As Windows.Forms.PictureBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents offsetText As Windows.Forms.TextBox
End Class
