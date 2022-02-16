Imports System.Windows.Forms
Imports Inventor

''' <summary>
''' Assembly Bill of Materials Dialog. Windows form that gathers all the parts used
''' in an assembly .iam file. Does not save any of the information to the .iam file, but
''' will push the information to <see cref="sqlServ"/> to be pushed into the SQL
''' database.
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class AsmBOMDialog

    Private m_doc As Inventor.Document = m_inventorApplication.ActiveEditDocument
    Dim partNumP As String = m_doc.PropertySets.Item("Design Tracking Properties").Item("Part Number").Value

    ''' <summary>
    ''' Handles the Click event of the Upload_Button control. This will run through each row of the bill of
    ''' materials table. If the "Included" checkbox is selected. It will push the required information
    ''' to <see cref="sqlServ"/> and into the SQL database. Error checkin is done in sqlServ.vb
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Upload_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upload_Button.Click

        Dim partNumC As String
        Dim partCqty As String

        Dim row As Integer
        ' Iterating through each item in the DataGridView
        For row = 0 To Me.billOfMaterials.Rows.Count - 1

            If Me.billOfMaterials.Item(2, row).Value = True Then

                partNumC = billOfMaterials.Item(0, row).Value
                partCqty = billOfMaterials.Item(1, row).Value

                ' Importing the information to SQL
                InsertBOM(partNumP, partNumC, partCqty)

            End If

        Next

        ' Flipping boolean to true.
        m_doc.PropertySets.Item("Inventor User Defined Properties").Item("bomPushed").Value = True

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

    ''' <summary>
    ''' Handles the Load event of the AsmBOMDialog control. Gathers all the parts used in the assembly
    ''' and their quantites. Then it will add them to a table where the user can select and or add 
    ''' custom parts.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AsmBOMDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Tries to read the bill of materials for the Assembly document
        Dim oDoc As AssemblyDocument = m_inventorApplication.ActiveDocument
        Dim oBOM As BOM = oDoc.ComponentDefinition.BOM

        ' Checks to see if this is a purchased part. Needs to try just incase
        ' this custom parameter is not available.
        Try
            Dim docPurchS As String = oDoc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value
            Dim docPurchBool As Boolean = docPurchS = "P"
            If docPurchBool Then

                MsgBox("This is a Purchased Part. You cannot have a bill of materials.")
                Me.Close()

            End If

        Catch ex As Exception

        End Try

        Try

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
                Dim cPrtQty As String = oRow.ItemQuantity.ToString

                Me.billOfMaterials.Rows.Add(cPrtNum, cPrtQty, True)

            Next

        Catch ex As Exception
            MsgBox("The Error is: " & ex.ToString)
        End Try

    End Sub

    Private Sub bomInstructions_TextChanged(sender As Object, e As EventArgs) Handles bomInstructions.TextChanged

    End Sub
End Class
