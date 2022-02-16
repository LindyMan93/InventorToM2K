Imports System.Windows.Forms
Imports Inventor

''' <summary>
''' Simple windows form that prompts the user to select file formats to save 
''' a copy of the current active document. Also allows user to select a location.
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class saveForm

    ''' <summary>
    ''' Handles the Click event of the OK_Button control. Opens a folder selection dialog.
    ''' Then it will check which boxes were check and will save a copy of the file, in chosen
    ''' format(s) to selected folder.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        folderSelect.ShowDialog()
        Dim path As String = folderSelect.SelectedPath.ToString & "\"
        Dim fileName As String = m_inventorApplication.ActiveDocument.DisplayName.ToString
        Dim saveFile As Document = m_inventorApplication.ActiveDocument

        ' If yes, saves as AutoCad Lite .dwg
        If aclCB.Checked Then

            saveFile.SaveAs(path & fileName & ".dwg", True)

        End If

        ' If yes, saves as PDF
        If pdfCB.Checked Then

            saveFile.SaveAs(path & fileName & ".pdf", True)

        End If

        ' If yes, saves as .STEP file (3D)
        If stepCB.Checked Then

            saveFile.SaveAs(path & fileName & ".step", True)

        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles the Click event of the Cancel_Button control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
