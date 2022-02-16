Imports System.Windows.Forms
Imports Inventor


''' <summary>
''' Similar to the AsmBOMDialog, This form allows the user to calculate the square inches of a part
''' to be cut on the CNC router. You can pick a material and its square inches and push it to the 
''' SQL database.
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class PartMaterialDialog

    ' The active document where this form has been opened.
    Dim oDoc As Document = m_inventorApplication.ActiveDocument
    Dim prtNumNull As Boolean
    Dim materialNull As Boolean
    Dim areaNull As Boolean

    ''' <summary>
    ''' Handles the Click event of the Upload_Button control. This pushes the information to the 
    ''' SQL database.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Upload_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upload_Button.Click

        Dim prtNum As String = Me.partNumberText.Text
        Dim material As String = Me.matSelect.Text
        Dim squInch As String = Me.amountText.Text

        ' Checks to make sure that values are numbers. Not letters
        If Not IsNumeric(squInch) Then

            MsgBox("Amount must be a numeric value")

        Else

            ' Push information to SQL
            InsertBOM(prtNum, material, squInch)

            oDoc.PropertySets.Item("Inventor User Defined Properties").Item("bomPushed").Value = True

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If


    End Sub

    ''' <summary>
    ''' Handles the Click event of the Calculate_Button control. Calculates the area of a the cut surface that the user
    ''' chooses.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Calculate_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calc_Button.Click

        ' NEED TO UPDATE FOR ACCURACY!
        Dim oFace As Face = m_inventorApplication.CommandManager.Pick(SelectionFilterEnum.kPartDefaultFilter, "Select Cut Face")

        Dim area As Double = Math.Round((oFace.Evaluator.Area * 0.155) + (oFace.Evaluator.Area * 0.1), 0)
        Me.amountText.Text = area.ToString

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
    ''' Handles the Load event of the PartMaterialDialog control. Loads the part number into the form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub PartMaterialDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.partNumberText.Text = oDoc.PropertySets.Item("Design Tracking Properties").Item("Part Number").Value
        prtNumNull = Me.partNumberText.Equals("")
        materialNull = Me.matSelect.Text.Equals("")
        areaNull = Me.amountText.Text.Equals("")

        Try
            Dim docPurchS As String = oDoc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value
            Dim docPurchBool As Boolean = docPurchS = "P"
            If docPurchBool Then

                MsgBox("This is a Purchased Part. You cannot have a bill of materials.")
                Me.Close()

            End If

        Catch ex As Exception

        End Try

        ActivateUpload()

    End Sub

    ''' <summary>
    ''' Events will be fired if the values are changed. Checks for Null values (Empty Strings)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
#Region "Text Changes"

    Private Sub PartNumberChange(sender As Object, e As EventArgs) Handles partNumberText.TextChanged

        If Me.partNumberText.Text = "" Then

            prtNumNull = True

        Else

            prtNumNull = False

        End If
        ActivateUpload()

    End Sub

    Private Sub MaterialChange(sender As Object, e As EventArgs) Handles matSelect.SelectedValueChanged

        If Me.matSelect.Text = "" Then

            materialNull = True

        Else

            materialNull = False

        End If

        ActivateUpload()

    End Sub

    Private Sub AreaChange(sender As Object, e As EventArgs) Handles amountText.TextChanged

        If Me.amountText.Text = "" Then

            areaNull = True

        Else

            areaNull = False

        End If

        ActivateUpload()

    End Sub

#End Region

    Private Sub ActivateUpload()

        If prtNumNull Or materialNull Or areaNull Then

            Me.upload_Button.Enabled = False

        Else

            Me.upload_Button.Enabled = True

        End If

    End Sub

    Private Sub customButton_Click(sender As Object, e As EventArgs) Handles customButton.Click

        Dim customMaterial = InputBox("Add Custom Material", "Custom Material")

        If customMaterial.Length = 0 Or customMaterial.Length > 20 Then

            MsgBox("The material name has not been entered or is greater than 20 characters.")

        Else

            Me.matSelect.Items.Add(customMaterial)

        End If

    End Sub

End Class
