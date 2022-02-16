Imports System.Collections.Generic

''' <summary>
''' Part Master Information form. Allows user to update part information during 
''' creation of the part.
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class PartInfoDialog

    Private m_doc As Inventor.Document
    Dim prtNumNull As Boolean
    Dim sDescNull As Boolean
    Dim invTypeNull As Boolean
    Dim engrStatNull As Boolean
    Dim umNull As Boolean
    Dim leadTimeNull As Boolean
    Dim engrNull As Boolean

    ''' <summary>
    ''' Handles the Click event of the Save_Button control. Saves user input to the correct customer user
    ''' properties in the .ipt or .iam files.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Save_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Button.Click

        Try
            m_doc.PropertySets("Design Tracking Properties").Item("Description").Value = Me.descriptionText.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("engineerStatus").Value = Me.engStatusSelect.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value = Me.invTypeSelect.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value = Me.leadTimeSelect.Text
            m_doc.PropertySets("Design Tracking Properties").Item("Manufacturer").Value = Me.mfgNameText.Text
            m_doc.PropertySets("Design Tracking Properties").Item("Engineer").Value = Me.engineerText.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value = Me.sDescriptionText.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("salesCode").Value = Me.salesCodeSelect.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("unitOfMeasure").Value = Me.uomSelect.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value = Me.mfgPrtNumText.Text
            m_doc.PropertySets("Inventor Document Summary Information").Item("Company").Value = Me.companyT.Text
            m_doc.PropertySets.Item("Design Tracking Properties").Item("Stock Number").Value = Me.salesOrT.Text

            m_doc.Save()

        Catch ex As Exception
            MsgBox("Error Changing iProperties...")
        End Try

        MsgBox("Information has been saved.")
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    ''' <summary>
    ''' Handles the Click event of the Upload_Button control. This will save the information the user inputs,
    ''' then it will upload the information to the SQL server. Error checking done in sqlServ.vb
    ''' <see cref="sqlServ"/>
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Upload_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upload_Button.Click

        'Dim trans As Inventor.Transaction = Nothing

        Try

            ' Setting properties to User Input
            'trans = m_inventorApplication.TransactionManager.StartTransaction(m_doc, "Part Information Update")
            m_doc.PropertySets("Design Tracking Properties").Item("Description").Value = Me.descriptionText.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("engineerStatus").Value = Me.engStatusSelect.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value = Me.invTypeSelect.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value = Me.leadTimeSelect.Text
            m_doc.PropertySets("Design Tracking Properties").Item("Manufacturer").Value = Me.mfgNameText.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value = Me.sDescriptionText.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("salesCode").Value = Me.salesCodeSelect.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("unitOfMeasure").Value = Me.uomSelect.Text
            m_doc.PropertySets("Design Tracking Properties").Item("Engineer").Value = Me.engineerText.Text
            m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value = Me.mfgPrtNumText.Text
            m_doc.PropertySets("Inventor Document Summary Information").Item("Company").Value = Me.companyT.Text
            m_doc.PropertySets.Item("Design Tracking Properties").Item("Stock Number").Value = Me.salesOrT.Text

            ' Creating ease of use strings to send to SQL server
            Dim prtNum As String = Me.partNumberText.Text
            Dim sDesc As String = Me.sDescriptionText.Text
            Dim invType As String = Me.invTypeSelect.Text
            Dim lDesc As String = Me.descriptionText.Text
            Dim unOfMeas As String = Me.uomSelect.Text
            Dim engStat As String = Me.engStatusSelect.Text
            Dim salesC As String = Me.salesCodeSelect.Text
            Dim lTime As String = Me.leadTimeSelect.Text
            Dim engr As String = Me.engineerText.Text
            Dim mfgNum As String = Me.mfgPrtNumText.Text
            Dim mfgName As String = Me.mfgNameText.Text

            ' Pushing information to SQL server
            InsertPM(prtNum, sDesc, invType, lDesc, unOfMeas, engStat, salesC, lTime, engr, mfgName, mfgNum)
            m_doc.PropertySets("Inventor User Defined Properties").Item("imPushed").Value = True
            ' trans.End()

        Catch ex As Exception

            MsgBox("Error importing properties to SQL. \n Error: " & ex.ToString)

        End Try

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
    ''' Handles the Click event of the h button. It will open the helpBox to show the user what each drop
    ''' down menu item means.
    ''' <see cref="helpBox"/>
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub h_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hButton.Click

        Dim helpBoxWindow As helpBox
        helpBoxWindow = New helpBox
        helpBoxWindow.Show()
        helpBoxWindow = Nothing

    End Sub

    ''' <summary>
    ''' Handles the Load event of the PartInfoDialog control. Will run on load of dialog. Updates all information
    ''' in the form to previous save information. If these custom paramters do not exist. It will create them.
    ''' This is for older parts made before this add in.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub PartInfoDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim uomItems As List(Of String) = MenuItemQuery("UOM")
            Dim invTypeItems As List(Of String) = MenuItemQuery("INVTYPE")
            Dim engrStatItems As List(Of String) = MenuItemQuery("ENGRSTAT")
            Dim salesCodeItems As List(Of String) = MenuItemQuery("SALESCODE")
            Dim lTimeCodeItems As List(Of String) = MenuItemQuery("LTCODE")
            Dim egrNames As List(Of String) = MenuItemQuery("EGR")

            Me.uomSelect.DataSource = uomItems
            Me.invTypeSelect.DataSource = invTypeItems
            Me.engStatusSelect.DataSource = engrStatItems
            Me.salesCodeSelect.DataSource = salesCodeItems
            Me.leadTimeSelect.DataSource = lTimeCodeItems
            Me.engineerText.DataSource = egrNames

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

        Try
            ' Get the active edit document.
            m_doc = m_inventorApplication.ActiveEditDocument

            ' Initialize the values on the dialog using the current property values.
            Me.partNumberText.Text = m_doc.PropertySets.Item("Design Tracking Properties").Item("Part Number").Value
            Me.engineerText.Text = m_doc.PropertySets.Item("Design Tracking Properties").Item("Engineer").Value
            Me.descriptionText.Text = m_doc.PropertySets("Design Tracking Properties").Item("Description").Value
            Me.mfgNameText.Text = m_doc.PropertySets("Design Tracking Properties").Item("Manufacturer").Value
            Me.companyT.Text = m_doc.PropertySets("Inventor Document Summary Information").Item("Company").Value
            Me.salesOrT.Text = m_doc.PropertySets.Item("Design Tracking Properties").Item("Stock Number").Value

            If (m_doc.PropertySets("Inventor User Defined Properties").Count = 0) Then

                m_doc.PropertySets("Inventor User Defined Properties").Add("", "engineerStatus")
                m_doc.PropertySets("Inventor User Defined Properties").Add("", "inventoryType")
                m_doc.PropertySets("Inventor User Defined Properties").Add("", "leadTimeCode")
                m_doc.PropertySets("Inventor User Defined Properties").Add("", "mfgPartNumber")
                m_doc.PropertySets("Inventor User Defined Properties").Add("", "sDescription")
                m_doc.PropertySets("Inventor User Defined Properties").Add("", "salesCode")
                m_doc.PropertySets("Inventor User Defined Properties").Add("", "unitOfMeasure")
                m_doc.PropertySets("Inventor User Defined Properties").Add(False, "imPushed")
                m_doc.PropertySets("Inventor User Defined Properties").Add(False, "bomPushed")
                m_doc.PropertySets("Inventor User Defined Properties").Add(False, "routPushed")

                Me.engStatusSelect.SelectedIndex = -1
                Me.invTypeSelect.SelectedIndex = -1
                Me.leadTimeSelect.SelectedIndex = -1
                Me.sDescriptionText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value
                Me.salesCodeSelect.SelectedIndex = -1
                Me.uomSelect.SelectedIndex = -1
                Me.mfgPrtNumText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value

            Else

                Me.engStatusSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("engineerStatus").Value
                Me.invTypeSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value
                Me.leadTimeSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value
                Me.sDescriptionText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value
                Me.salesCodeSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("salesCode").Value
                Me.uomSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("unitOfMeasure").Value
                Me.mfgPrtNumText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value

            End If

        Catch ex As Exception

            MsgBox("Error Loading iProperties Information...")

        End Try

        prtNumNull = Me.partNumberText.Text.Equals("")
        sDescNull = Me.sDescriptionText.Text.Equals("")
        invTypeNull = Me.invTypeSelect.Text.Equals("")
        engrStatNull = Me.engStatusSelect.Text.Equals("")
        umNull = Me.uomSelect.Text.Equals("")
        leadTimeNull = Me.leadTimeSelect.Text.Equals("")
        engrNull = Me.engineerText.Text.Equals("")

        ActivateUpload()

    End Sub

    ' Preset buttons for purchased and manufactured
#Region "Presets"

    ''' <summary>
    ''' Handles the Click event of the Manufactured control. This is a group of preset values used often.
    ''' It will set the values of the drop down menus to a standard "Manufactured" part.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub Manufactured_Click(sender As Object, e As EventArgs) Handles manufacturedStandard.Click

        Me.uomSelect.Text = "EA"
        Me.engStatusSelect.Text = "S"
        Me.invTypeSelect.Text = "RA"
        Me.leadTimeSelect.Text = "M"

        m_doc.PropertySets("Inventor User Defined Properties").Item("engineerStatus").Value = Me.engStatusSelect.Text
        m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value = Me.invTypeSelect.Text
        m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value = Me.leadTimeSelect.Text
        m_doc.PropertySets("Inventor User Defined Properties").Item("unitOfMeasure").Value = Me.uomSelect.Text

    End Sub

    ''' <summary>
    ''' Handles the Click event of the Purchased control. This is a group of preset values used often.
    ''' It will set the values of the drop down menus to a standard "Purchased" part.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub Purchased_Click(sender As Object, e As EventArgs) Handles purchasedStandard.Click

        Me.uomSelect.Text = "EA"
        Me.engStatusSelect.Text = "S"
        Me.invTypeSelect.Text = "RA"
        Me.leadTimeSelect.Text = "P"

        m_doc.PropertySets("Inventor User Defined Properties").Item("engineerStatus").Value = Me.engStatusSelect.Text
        m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value = Me.invTypeSelect.Text
        m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value = Me.leadTimeSelect.Text
        m_doc.PropertySets("Inventor User Defined Properties").Item("unitOfMeasure").Value = Me.uomSelect.Text

    End Sub

#End Region

    ''' <summary>
    ''' Antiquated Funciton. Used to check for null values. Now, upload button will not be enabled until all values have
    ''' information. 
    ''' </summary>
    ''' <returns></returns>
    Private Function NullValues() As Boolean

        Dim errors As String = ""
        Dim hasNulls As Boolean = False

        If Me.partNumberText.Text = "" Then
            errors = "**You must save the part first to give it a valid part number." & vbCrLf & vbTab
            hasNulls = True
        End If

        If Me.sDescriptionText.Text = "" Then
            errors = errors & "**You must enter a short description." & vbCrLf & vbTab
            hasNulls = True
        End If

        If Me.uomSelect.Text = "" Then
            errors = errors & "**You must select a unit of measure." & vbCrLf & vbTab
            hasNulls = True
        End If

        If Me.invTypeSelect.Text = "" Then
            errors = errors & "**You must select an inventory type." & vbCrLf & vbTab
            hasNulls = True
        End If

        If Me.engStatusSelect.Text = "" Then
            errors = errors & "**You must select an engineering status." & vbCrLf & vbTab
            hasNulls = True
        End If

        If Me.leadTimeSelect.Text = "" Then
            errors = errors & "**You must select an inventory type." & vbCrLf & vbTab
            hasNulls = True
        End If

        If Me.engineerText.Text = "" Then
            errors = errors & "**You must select an inventory type."
            hasNulls = True
        End If

        If hasNulls Then

            MsgBox("The information is not complete. You must do the following: " & vbCrLf & vbTab & errors, vbMsgBoxHelp, "Import Error")

        End If

        Return hasNulls

    End Function

    ''' <summary>
    ''' These subs will fire when text has changed in the texts fields.
    ''' Used to make sure null information will not be sent to SQL
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
#Region "Changes In text fields"

    Private Sub PartNumberChange(sender As Object, e As EventArgs) Handles partNumberText.TextChanged

        If Me.partNumberText.Text = "" Then

            prtNumNull = True

        Else

            prtNumNull = False

        End If

        ActivateUpload()

    End Sub

    Private Sub ShortDescChange(sender As Object, e As EventArgs) Handles sDescriptionText.TextChanged

        If Me.sDescriptionText.Text = "" Then

            sDescNull = True

        Else

            sDescNull = False

        End If

        ActivateUpload()

    End Sub

    Private Sub InvTypeChange(sender As Object, e As EventArgs) Handles invTypeSelect.SelectedValueChanged

        If Me.invTypeSelect.Text = "" Then

            invTypeNull = True

        Else

            invTypeNull = False

        End If

        ActivateUpload()

    End Sub

    Private Sub EngrStatChange(sender As Object, e As EventArgs) Handles engStatusSelect.SelectedValueChanged

        If Me.engStatusSelect.Text = "" Then

            engrStatNull = True

        Else

            engrStatNull = False

        End If

        ActivateUpload()

    End Sub

    Private Sub UnitOfMeasureChange(sender As Object, e As EventArgs) Handles uomSelect.SelectedValueChanged

        If Me.uomSelect.Text = "" Then

            umNull = True

        Else

            umNull = False

        End If

        ActivateUpload()

    End Sub

    Private Sub LeadTimeCodeChange(sender As Object, e As EventArgs) Handles leadTimeSelect.SelectedValueChanged

        If Me.leadTimeSelect.Text = "" Then

            leadTimeNull = True

        Else

            leadTimeNull = False

        End If

        ActivateUpload()

    End Sub

    Private Sub EngineerChange(sender As Object, e As EventArgs)

        If Me.engineerText.Text = "" Then

            engrNull = True

        Else

            engrNull = False

        End If

        ActivateUpload()

    End Sub

#End Region

    ''' <summary>
    ''' Will enabled upload button if all values have information. Otherwise they will still be disabled.
    ''' </summary>
    Private Sub ActivateUpload()

        If prtNumNull Or sDescNull Or invTypeNull Or engrStatNull Or umNull Or leadTimeNull Or engrNull Then

            Me.upload_Button.Enabled = False

        Else

            Me.upload_Button.Enabled = True

        End If

    End Sub

    Private Sub impLogo_Click(sender As Object, e As EventArgs) Handles impLogo.Click

    End Sub
End Class
