﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helpBox
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(helpBox))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.dMenuInfo = New System.Windows.Forms.TextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.Inventor_To_M2K.My.Resources.Resources.NRL_Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(63, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(134, 80)
        Me.LogoPictureBox.TabIndex = 1
        Me.LogoPictureBox.TabStop = False
        '
        'dMenuInfo
        '
        Me.dMenuInfo.Location = New System.Drawing.Point(12, 98)
        Me.dMenuInfo.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.dMenuInfo.MaxLength = 500000
        Me.dMenuInfo.Multiline = True
        Me.dMenuInfo.Name = "dMenuInfo"
        Me.dMenuInfo.ReadOnly = True
        Me.dMenuInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dMenuInfo.Size = New System.Drawing.Size(233, 292)
        Me.dMenuInfo.TabIndex = 2
        Me.dMenuInfo.TabStop = False
        Me.dMenuInfo.Text = resources.GetString("dMenuInfo.Text")
        '
        'helpBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 402)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.dMenuInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "helpBox"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Help"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoPictureBox As Windows.Forms.PictureBox
    Friend WithEvents dMenuInfo As Windows.Forms.TextBox
End Class
