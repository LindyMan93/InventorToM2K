<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saveForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.folderL = New System.Windows.Forms.Label()
        Me.aclCB = New System.Windows.Forms.CheckBox()
        Me.pdfCB = New System.Windows.Forms.CheckBox()
        Me.stepCB = New System.Windows.Forms.CheckBox()
        Me.folderSelect = New System.Windows.Forms.FolderBrowserDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(17, 136)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "Cancel"
        '
        'folderL
        '
        Me.folderL.AutoSize = True
        Me.folderL.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderL.Location = New System.Drawing.Point(27, 9)
        Me.folderL.Name = "folderL"
        Me.folderL.Size = New System.Drawing.Size(133, 21)
        Me.folderL.TabIndex = 1
        Me.folderL.Text = "Save As File Types"
        '
        'aclCB
        '
        Me.aclCB.AutoSize = True
        Me.aclCB.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aclCB.Location = New System.Drawing.Point(49, 48)
        Me.aclCB.Name = "aclCB"
        Me.aclCB.Size = New System.Drawing.Size(105, 21)
        Me.aclCB.TabIndex = 1
        Me.aclCB.Text = "AutoCAD DWG"
        Me.aclCB.UseVisualStyleBackColor = True
        '
        'pdfCB
        '
        Me.pdfCB.AutoSize = True
        Me.pdfCB.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdfCB.Location = New System.Drawing.Point(49, 71)
        Me.pdfCB.Name = "pdfCB"
        Me.pdfCB.Size = New System.Drawing.Size(49, 21)
        Me.pdfCB.TabIndex = 2
        Me.pdfCB.Text = "PDF"
        Me.pdfCB.UseVisualStyleBackColor = True
        '
        'stepCB
        '
        Me.stepCB.AutoSize = True
        Me.stepCB.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stepCB.Location = New System.Drawing.Point(49, 94)
        Me.stepCB.Name = "stepCB"
        Me.stepCB.Size = New System.Drawing.Size(54, 21)
        Me.stepCB.TabIndex = 3
        Me.stepCB.Text = "STEP"
        Me.stepCB.UseVisualStyleBackColor = True
        '
        'saveForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(181, 177)
        Me.Controls.Add(Me.stepCB)
        Me.Controls.Add(Me.pdfCB)
        Me.Controls.Add(Me.aclCB)
        Me.Controls.Add(Me.folderL)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "saveForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Save Form"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents folderL As Windows.Forms.Label
    Friend WithEvents aclCB As Windows.Forms.CheckBox
    Friend WithEvents pdfCB As Windows.Forms.CheckBox
    Friend WithEvents stepCB As Windows.Forms.CheckBox
    Friend WithEvents folderSelect As Windows.Forms.FolderBrowserDialog
End Class
