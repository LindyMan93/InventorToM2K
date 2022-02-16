Imports System.Windows.Forms
Imports Inventor

''' <summary>
''' Form to check to see if all information for every part in assembly has been
''' uploaded. 
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class CheckAllDialog

    ''' <summary>
    ''' Handles the Load event of the CheckAllDialog control. Will load all parts like the 
    ''' bill of material. But it will check each part to see if the boolean flags for pmPushed
    ''' bomPushed and routPushed have been flipped to true. If not all of them have been added,
    ''' it will add it to the list. If the part does not have any "Inventor User Defined Properties"
    ''' then it wont look at the information.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CheckAllDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            Dim oDoc As AssemblyDocument = m_inventorApplication.ActiveDocument
            Dim oBOM As BOM = oDoc.ComponentDefinition.BOM

            ' If the Structured BOM view is not enabled then it will enable it for the document
            If (Not oBOM.StructuredViewEnabled) Then

                oBOM.StructuredViewEnabled = True

            End If
            Dim oBOMView As BOMView = oBOM.BOMViews.Item("Structured")

            ' Loop to get all the materials used in the assembly. 
            Dim i As Long
            For i = 1 To oBOMView.BOMRows.Count
                Dim oRow As BOMRow
                oRow = oBOMView.BOMRows.Item(i)
                Dim oCompDef As ComponentDefinition = oRow.ComponentDefinitions.Item(1)
                Dim oPropSet As PropertySet = oCompDef.Document.PropertySets.Item("Design Tracking Properties")
                Dim cPrtNum As String = oPropSet.Item("Part Number").Value

                ' Trying to get custom properties. If it has them it will check the values. If not, 
                ' it will end that iteration of the loop.
                Try

                    Dim oCustPropSet As PropertySet = oCompDef.Document.PropertySets.Item("Inventor User Defined Properties")
                    Dim cPrtPmPush As Boolean = oCustPropSet.Item("imPushed").Value
                    Dim cPrtBomPush As Boolean = oCustPropSet.Item("bomPushed").Value
                    Dim cPrtRoutPush As Boolean = oCustPropSet.Item("routPushed").Value

                    If (Not cPrtPmPush Or Not cPrtBomPush Or Not cPrtRoutPush) Then

                        Me.checkAllTable.Rows.Add(cPrtNum, cPrtPmPush, cPrtBomPush, cPrtRoutPush)

                    End If

                Catch ex As Exception

                    Me.checkAllTable.Rows.Add(cPrtNum, False, False, False)

                End Try

            Next

        Catch ex As Exception
            MsgBox("The Error is: " & ex.ToString)
        End Try

    End Sub

End Class
