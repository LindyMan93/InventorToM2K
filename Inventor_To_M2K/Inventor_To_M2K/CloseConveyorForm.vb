Imports System.Windows.Forms
Imports Inventor

''' <summary>
''' This Class/Form will run nearly all parts of the Add-In to close out a total conveyor.
''' It is currently still being worked on as of 6/16/2017. All Buttons and interface options
''' are available. Just not shown in the UI.
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class CloseConveyorForm

    Dim partDocNames As New ArrayList

    ''' <summary>
    ''' Handles the Click event of the OK_Button control. Will get all the selected parts and run the
    ''' CloseConveyor Sub in CloseConveyorMod.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim row As Integer
        For row = 0 To Me.selectParts.Rows.Count - 1

            If Me.selectParts.Item(1, row).Value = True Then

                Dim selectedComp As Document = Me.selectParts.Item(2, row).Value
                Dim scFullDocName As String = selectedComp.FullFileName.ToString

                partDocNames.Add(scFullDocName)

            End If

        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

        For Each file In partDocNames

            CloseConveyor(file)

        Next

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Load_Form() Handles Me.Load

        ' Tries to read the bill of materials for the Assembly document
        Dim oDoc As AssemblyDocument = m_inventorApplication.ActiveDocument
        Dim oBOM As BOM = oDoc.ComponentDefinition.BOM

        Try

            ' If the Structured BOM view is not enabled then it will enable it for the document
            If (Not oBOM.PartsOnlyViewEnabled) Then

                oBOM.PartsOnlyViewEnabled = True

            End If
            Dim oBOMView As BOMView = oBOM.BOMViews.Item("Parts Only")

            ' Loop to get all the materials used in the assembly. 
            Dim i As Long
            For i = 1 To oBOMView.BOMRows.Count
                Dim oRow As BOMRow
                oRow = oBOMView.BOMRows.Item(i)
                Dim oCompDef As ComponentDefinition = oRow.ComponentDefinitions.Item(1)
                Dim oCompDoc As Document = oCompDef.Document
                Dim oPropSet As PropertySet = oCompDef.Document.PropertySets.Item("Design Tracking Properties")
                Dim cPrtNum As String = oPropSet.Item("Part Number").Value

                Me.selectParts.Rows.Add(cPrtNum, False, oCompDoc)

            Next

        Catch ex As Exception
            MsgBox("The Error is: " & ex.ToString)
        End Try

    End Sub

End Class
