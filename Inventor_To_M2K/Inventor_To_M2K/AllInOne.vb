Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms
Imports Inventor

Public Class AllInOne

    Private m_doc As Document
    Dim partNum As String

    ' Item Master, BOM, Routing booleans checking
    ' SQL to see if they exist
    Dim sqlIMExists As Boolean
    Dim sqlBOMExists As Boolean
    Dim sqlRoutExists As Boolean

    ' Item Master value checkers
    Dim prtNumNull As Boolean
    Dim sDescNull As Boolean
    Dim invTypeNull As Boolean
    Dim engrStatNull As Boolean
    Dim umNull As Boolean
    Dim leadTimeNull As Boolean
    Dim engrNull As Boolean

    ' Boolean for m2k uploads
    Dim m2kPMExists As Boolean = False
    Dim m2kBOMExists As Boolean = False
    Dim m2kRoutExists As Boolean = False

    ''' <summary>
    ''' Handles the Load event of the PartInfoDialog control. Will run on load of dialog. Updates all information
    ''' in the form to previous save information. If these custom paramters do not exist. It will create them.
    ''' This is for older parts made before this add in.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AllInOne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Get the active edit document.
        m_doc = m_inventorApplication.ActiveEditDocument
        partNum = m_doc.PropertySets.Item("Design Tracking Properties").Item("Part Number").Value
        Me.partNumberText.Text = partNum

        ' loading menu items
        LoadMenus()

        ' Setting custom and standard property values
        CustomInventorProperties()

        ' loading bills of materials (Inventor and M2k)
        ' if document is an assembly document, activate assembly box,
        ' else activate part box.
        If m_doc.DocumentType = DocumentTypeEnum.kAssemblyDocumentObject Then

            Dim oBOM As BOM = m_doc.ComponentDefinition.BOM
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

                    Me.invBOMGrid.Rows.Add(cPrtNum, cPrtQty, True)

                Next

            Catch ex As Exception
                MsgBox("Error loading bill of materials: " & ex.ToString)
            End Try

            assemblyBox.Enabled = True
            partBox.Enabled = False
        Else

            assemblyBox.Enabled = False
            partBox.Enabled = True

        End If

        ' Loading bills and routings from SQL (M2k)
        M2kInfoLoad()

        ' If the leadtime code is set to P then the bill and rout boxes will be disabled.
        Dim leadTimeValue = m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value

        If leadTimeValue = "P" Then

            bomBox.Enabled = False
            routBox.Enabled = False

        End If

        Dim m2kPMQueryS As String = IMQuery(partNum, "PartNbr")

        If m2kPMQueryS.Length > 1 Then

            m2kPMExists = True


        End If

        If m2kPMExists = False Then

            bomBox.Enabled = False
            routBox.Enabled = False

        Else

            Dim m2kDescription As String = IMQuery(partNum, "Description")
            Dim m2kInventoryType As String = IMQuery(partNum, "InventoryType")
            Dim m2kExtDesc As String = IMQuery(partNum, "ExtDesc")
            Dim m2kUm As String = IMQuery(partNum, "Um")
            Dim m2kEngineeringStatus As String = IMQuery(partNum, "EngineeringStatus")
            Dim m2kSalesCode As String = IMQuery(partNum, "SalesCode")
            Dim m2kLeadTimeCode As String = IMQuery(partNum, "LeadTimeCode")
            Dim m2kEngrResp As String = IMQuery(partNum, "EngrResp")
            Dim m2kMfgName As String = IMQuery(partNum, "MfgName")
            Dim m2kMfgItemNbr As String = IMQuery(partNum, "MfgItemNbr")

            Dim sDescEqual As Boolean = Not m2kDescription.Equals(Me.sDescriptionText.Text)
            Dim invTypeEqual As Boolean = Not m2kInventoryType.Equals(Me.invTypeSelect.Text)
            Dim extDescEqual As Boolean = Not m2kExtDesc.Equals(Me.descriptionText.Text)
            Dim umEqual As Boolean = Not m2kUm.Equals(Me.uomSelect.Text)
            Dim engstatEqual As Boolean = Not m2kEngineeringStatus.Equals(Me.engStatusSelect.Text)
            Dim salesCodeEqual As Boolean = Not m2kSalesCode.Equals(Me.salesCodeSelect.Text)
            Dim ltCodeEqual As Boolean = Not m2kLeadTimeCode.Equals(Me.leadTimeSelect.Text)
            Dim egrNameEqual As Boolean = Not m2kEngrResp.Equals(Me.engineerText.Text)
            Dim mfgNameEqual As Boolean = Not m2kMfgName.Equals(Me.mfgNameText.Text)
            Dim mfgNumEqual As Boolean = Not m2kMfgItemNbr.Equals(Me.mfgPrtNumText.Text)

            If sDescEqual Or invTypeEqual Or extDescEqual Or umEqual Or engstatEqual Or
                salesCodeEqual Or ltCodeEqual Or egrNameEqual Or mfgNameEqual Or mfgNumEqual Then

                Dim updateInfoMessage As String = "There is part information in Manage 2000 for this part. Would you like to update the local Inventor information with this information?"
                Dim updateyesno As MsgBoxResult = MsgBox(updateInfoMessage, MsgBoxStyle.YesNo, "Update Local Info")

                If updateyesno = vbYes Then

                    ' PartNbr, Description, InventoryType, ExtDesc, Um, EngineeringStatus, SalesCode, LeadTimeCode, EngrResp, MfgName, MfgItemNbr


                    m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value = m2kDescription
                    m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value = m2kInventoryType
                    m_doc.PropertySets("Design Tracking Properties").Item("Description").Value = m2kExtDesc
                    m_doc.PropertySets("Inventor User Defined Properties").Item("unitOfMeasure").Value = m2kUm
                    m_doc.PropertySets("Inventor User Defined Properties").Item("engineerStatus").Value = m2kEngineeringStatus
                    m_doc.PropertySets("Inventor User Defined Properties").Item("salesCode").Value = m2kSalesCode
                    m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value = m2kLeadTimeCode
                    m_doc.PropertySets.Item("Design Tracking Properties").Item("Engineer").Value = m2kEngrResp
                    m_doc.PropertySets("Design Tracking Properties").Item("Manufacturer").Value = m2kMfgName
                    m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value = m2kMfgItemNbr

                    Me.sDescriptionText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value
                    Me.invTypeSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value
                    Me.descriptionText.Text = m_doc.PropertySets("Design Tracking Properties").Item("Description").Value
                    Me.uomSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("unitOfMeasure").Value
                    Me.engStatusSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("engineerStatus").Value
                    Me.salesCodeSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("salesCode").Value
                    Me.leadTimeSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value
                    Me.engineerText.Text = m_doc.PropertySets.Item("Design Tracking Properties").Item("Engineer").Value
                    Me.mfgNameText.Text = m_doc.PropertySets("Design Tracking Properties").Item("Manufacturer").Value
                    Me.mfgPrtNumText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value

                End If

            End If

        End If

        ' Checking values of required values to push
        ' If value is null, variable is true
        ' If value is not null, variable is false
        prtNumNull = Me.partNumberText.Text.Equals("")
        sDescNull = Me.sDescriptionText.Text.Equals("")
        invTypeNull = Me.invTypeSelect.Text.Equals("")
        engrStatNull = Me.engStatusSelect.Text.Equals("")
        umNull = Me.uomSelect.Text.Equals("")
        leadTimeNull = Me.leadTimeSelect.Text.Equals("")
        engrNull = Me.engineerText.Text.Equals("")

        ActivateIMUpload()
        ActivateMatUpload()

    End Sub

    'This area of code is where all the item master functions are.
#Region "Item Master Code"
    ' Committing changes in fields to text 
    Private Sub Save_IM_Data_Local()

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

    End Sub

    ''' <summary>
    ''' Handles the Click event of the Save_Button control. Saves user input to the correct customer user
    ''' properties in the .ipt or .iam files.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Save_Local_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveLocalButton.Click

        Save_IM_Data_Local()
        MsgBox("Part master information has been saved.")

    End Sub

    ''' <summary>
    ''' Handles the Click event of the Upload_Button control. This will save the information the user inputs,
    ''' then it will upload the information to the SQL server. Error checking done in sqlServ.vb
    ''' <see cref="sqlServ"/>
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Upload_IM_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uploadIMButton.Click

        'Dim trans As Inventor.Transaction = Nothing

        Try

            ' Saving local changes to document
            Save_IM_Data_Local()

            ' Creating ease of use strings to send to SQL server
            Dim prtNum As String = m_doc.PropertySets.Item("Design Tracking Properties").Item("Part Number").Value
            Dim sDesc As String = m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value
            Dim invType As String = m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value
            Dim lDesc As String = m_doc.PropertySets("Design Tracking Properties").Item("Description").Value
            Dim unOfMeas As String = m_doc.PropertySets("Inventor User Defined Properties").Item("unitOfMeasure").Value
            Dim engStat As String = m_doc.PropertySets("Inventor User Defined Properties").Item("engineerStatus").Value
            Dim salesC As String = m_doc.PropertySets("Inventor User Defined Properties").Item("salesCode").Value
            Dim lTime As String = m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value
            Dim engr As String = m_doc.PropertySets("Design Tracking Properties").Item("Engineer").Value
            Dim mfgNum As String = m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value
            Dim mfgName As String = m_doc.PropertySets("Design Tracking Properties").Item("Manufacturer").Value

            ' Pushing information to SQL server
            InsertPM(prtNum, sDesc, invType, lDesc, unOfMeas, engStat, salesC, lTime, engr, mfgName, mfgNum)
            m_doc.PropertySets("Inventor User Defined Properties").Item("imPushed").Value = True

            ' Shutting down areas that cannot be changed anymore.
            itemMasterBox.Enabled = False
            uploadIMButton.Enabled = False
            routBox.Enabled = True
            bomBox.Enabled = True

        Catch ex As Exception

            MsgBox("Error importing properties to SQL. Error: " & ex.ToString)

        End Try

        MsgBox("Part master information has been saved and pushed to SQL.")

    End Sub

    ''' <summary>
    ''' Handles the Click event of the Cancel_Button control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Dim sDescChange As Boolean = Not m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value = Me.sDescriptionText.Text
        Dim invTypeChange As Boolean = Not m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value = Me.invTypeSelect.Text
        Dim lDescChange As Boolean = Not m_doc.PropertySets("Design Tracking Properties").Item("Description").Value = Me.descriptionText.Text
        Dim unOfMeasChange As Boolean = Not m_doc.PropertySets("Inventor User Defined Properties").Item("unitOfMeasure").Value = Me.uomSelect.Text
        Dim engStatChange As Boolean = Not m_doc.PropertySets("Inventor User Defined Properties").Item("engineerStatus").Value = Me.engStatusSelect.Text
        Dim salesCChange As Boolean = Not m_doc.PropertySets("Inventor User Defined Properties").Item("salesCode").Value = Me.salesCodeSelect.Text
        Dim lTimeChange As Boolean = Not m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value = Me.leadTimeSelect.Text
        Dim engrChange As Boolean = Not m_doc.PropertySets("Design Tracking Properties").Item("Engineer").Value = Me.engineerText.Text
        Dim mfgNumChange As Boolean = Not m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value = Me.mfgPrtNumText.Text
        Dim mfgNameChange As Boolean = Not m_doc.PropertySets("Design Tracking Properties").Item("Manufacturer").Value = Me.mfgNameText.Text

        If sDescChange _
            Or invTypeChange _
            Or lDescChange _
            Or unOfMeasChange _
            Or engStatChange _
            Or salesCChange _
            Or lTimeChange _
            Or engrChange _
            Or mfgNumChange _
            Or mfgNameChange Then

            Dim savedChangeStr As String = "You have changed some of the item master information, would you like to save your changes?"
            Dim saveChanges As MsgBoxResult = MsgBox(savedChangeStr, MsgBoxStyle.YesNo, "Save Changes")

            If saveChanges = MsgBoxResult.Yes Then

                If IMQuery(partNum, "PartNbr").Length > 1 Then

                    MsgBox("Part information already exists within Manage 2000. Information will be updated.")
                    uploadIMButton.PerformClick()

                Else

                    Save_IM_Data_Local()

                End If

            Else

                MsgBox("Changes will not be saved.")

            End If

        End If

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
    Private Sub h_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim helpBoxWindow As helpBox
        helpBoxWindow = New helpBox
        helpBoxWindow.Show()
        helpBoxWindow = Nothing

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
    ''' These subs will fire when text has changed in the texts fields.
    ''' Used to make sure null information will not be sent to SQL
    ''' 
    ''' UPDATE -- PROGRESS BAR TO SHOW GOALS
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

        ActivateIMUpload()

    End Sub

    Private Sub ShortDescChange(sender As Object, e As EventArgs) Handles sDescriptionText.TextChanged

        If Me.sDescriptionText.Text = "" Then

            sDescNull = True

        Else

            sDescNull = False

        End If

        ActivateIMUpload()

    End Sub

    Private Sub InvTypeChange(sender As Object, e As EventArgs) Handles invTypeSelect.SelectedValueChanged

        If Me.invTypeSelect.Text = "" Then

            invTypeNull = True

        Else

            invTypeNull = False

        End If

        ActivateIMUpload()

    End Sub

    Private Sub EngrStatChange(sender As Object, e As EventArgs) Handles engStatusSelect.SelectedValueChanged

        If Me.engStatusSelect.Text = "" Then

            engrStatNull = True

        Else

            engrStatNull = False

        End If

        ActivateIMUpload()

    End Sub

    Private Sub UnitOfMeasureChange(sender As Object, e As EventArgs) Handles uomSelect.SelectedValueChanged

        If Me.uomSelect.Text = "" Then

            umNull = True

        Else

            umNull = False

        End If

        ActivateIMUpload()

    End Sub

    Private Sub LeadTimeCodeChange(sender As Object, e As EventArgs) Handles leadTimeSelect.SelectedValueChanged

        If Me.leadTimeSelect.Text = "" Then

            leadTimeNull = True

        Else

            leadTimeNull = False

        End If

        If Me.leadTimeSelect.Text = "P" Then

            routBox.Enabled = False
            bomBox.Enabled = False

        Else



            If IMQuery(partNum, "PartNbr").Length > 1 Then

                m2kPMExists = True

            End If

            If m2kPMExists = False Then

                bomBox.Enabled = False
                routBox.Enabled = False

            Else

                routBox.Enabled = True
                bomBox.Enabled = True

            End If


        End If

        ActivateIMUpload()

    End Sub

    Private Sub EngineerChange(sender As Object, e As EventArgs) Handles engineerText.SelectedValueChanged

        If Me.engineerText.Text = "" Then

            engrNull = True

        Else

            engrNull = False

        End If

        ActivateIMUpload()

    End Sub

#End Region

    ''' <summary>
    ''' Will enabled upload Item Master Button in Finalize box if all values 
    ''' have information. Otherwise they will still be disabled.
    ''' </summary>
    Private Sub ActivateIMUpload()

        If prtNumNull Or sDescNull Or invTypeNull Or engrStatNull Or umNull Or leadTimeNull Or engrNull Then

            Me.uploadIMButton.Enabled = False

        Else

            Me.uploadIMButton.Enabled = True

        End If

    End Sub

#End Region

    'This area of code is where all the bill of materials functions are.
#Region "Bill of Materials Code"

#Region "Assembly Bills"

    Private Sub AddBillButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addBillButton.Click

        Dim partNumC As String
        Dim partCqty As String

        Dim row As Integer
        ' Iterating through each item in the DataGridView
        For row = 0 To Me.invBOMGrid.Rows.Count - 1

            If Me.invBOMGrid.Item(2, row).Value = True Then

                partNumC = invBOMGrid.Item(0, row).Value
                partCqty = invBOMGrid.Item(1, row).Value

                ' Importing the information to SQL
                InsertBOM(partNum, partNumC, partCqty)

            End If

        Next

        M2kInfoLoad()

        ' Flipping boolean to true.
        If m2kBOMGrid.Rows.Count > 0 Then

            m_doc.PropertySets.Item("Inventor User Defined Properties").Item("bomPushed").Value = True

        Else

            m_doc.PropertySets.Item("Inventor User Defined Properties").Item("bomPushed").Value = False

        End If


    End Sub

    Private Sub RemoveBillButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeBillButton.Click

        Dim partNumC As String
        Dim partCqty As String

        Dim row As Integer
        ' Iterating through each item in the DataGridView
        For row = 0 To Me.m2kBOMGrid.Rows.Count - 1

            If Me.m2kBOMGrid.Item(2, row).Value = True Then

                partNumC = m2kBOMGrid.Item(0, row).Value
                partCqty = m2kBOMGrid.Item(1, row).Value

                ' Importing the information to SQL
                RemoveSelectedBill(partNum, partNumC)

            End If

        Next

        M2kInfoLoad()

        If m2kBOMGrid.Rows.Count > 0 Then

            m_doc.PropertySets.Item("Inventor User Defined Properties").Item("bomPushed").Value = True

        Else

            m_doc.PropertySets.Item("Inventor User Defined Properties").Item("bomPushed").Value = False

        End If

    End Sub

#End Region

#Region "Part Bills"

    Dim materialNull As Boolean
    Dim areaNull As Boolean

    ''' <summary>
    ''' Handles the Click event of the AddMatButton control. Will push information to SQL if correct.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddMatButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addMatButton.Click

        Dim material As String = Me.matSelect.Text
        Dim squInch As String = Me.amountText.Text

        ' Checks to make sure that values are numbers. Not letters
        If Not IsNumeric(squInch) Then

            MsgBox("Amount must be a numeric value")

        Else

            ' Push information to SQL
            InsertBOM(partNum, material, squInch)

            m_doc.PropertySets.Item("Inventor User Defined Properties").Item("bomPushed").Value = True
            Me.addMatButton.Enabled = False

            M2kInfoLoad()

        End If


    End Sub

    Private Sub RemoveMatButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeMatButton.Click

        Dim delMatWarning As MsgBoxResult = MsgBox("Are you sure you would like to remove this material?", MsgBoxStyle.YesNo, "Warning")

        If delMatWarning = vbYes Then

            RemoveMaterial(partNum)
            M2kInfoLoad()
            m_doc.PropertySets.Item("Inventor User Defined Properties").Item("bomPushed").Value = False

        Else

            MsgBox("Operation cancelled. Did not remove material.")

        End If

    End Sub

    Private Sub RefreshMatButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshMatButton.Click

        M2kInfoLoad()

    End Sub

    ''' <summary>
    ''' Handles the Click event of the CustomButton control. Adding a custom material
    ''' to the menu if it is not in the menu now.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub CustomButton_Click(sender As Object, e As EventArgs) Handles customButton.Click

        Dim customMaterial = InputBox("Add Custom Material", "Custom Material")

        If customMaterial.Length = 0 Or customMaterial.Length > 20 Then

            MsgBox("The material name has not been entered or is greater than 20 characters.")

        Else

            Me.matSelect.Items.Add(customMaterial)

        End If

    End Sub

    ''' <summary>
    ''' Handles the KeyDown event of the AmountText control. Formatting the input the user can put into
    ''' amount text box. will only be numeric.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
    Private Sub AmountText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles amountText.KeyDown

        If Not IsNumeric(Chr(e.KeyCode)) _
            And Not e.KeyCode = Keys.Back _
            And Not e.KeyCode = Keys.Delete _
            And Not e.KeyCode = Keys.OemPeriod _
            And Not e.KeyCode = Keys.Decimal _
            And Not e.KeyCode = Keys.NumPad0 _
            And Not e.KeyCode = Keys.NumPad1 _
            And Not e.KeyCode = Keys.NumPad2 _
            And Not e.KeyCode = Keys.NumPad3 _
            And Not e.KeyCode = Keys.NumPad4 _
            And Not e.KeyCode = Keys.NumPad5 _
            And Not e.KeyCode = Keys.NumPad5 _
            And Not e.KeyCode = Keys.NumPad6 _
            And Not e.KeyCode = Keys.NumPad7 _
            And Not e.KeyCode = Keys.NumPad8 _
            And Not e.KeyCode = Keys.NumPad9 Then

            e.SuppressKeyPress = True

        End If

    End Sub

    ''' <summary>
    ''' Handles the Click event of the Calculate_Button control.
    ''' 
    ''' MIGHT NOT BE USING THIS, CANNOT CHANGE FOCUS TO NEW FORM.
    ''' 
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Calculate_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' NEED TO UPDATE FOR ACCURACY!
        Dim oFace As Face = m_inventorApplication.CommandManager.Pick(SelectionFilterEnum.kPartDefaultFilter, "Select Cut Face")

        Dim area As Double = Math.Round((oFace.Evaluator.Area * 0.155) + (oFace.Evaluator.Area * 0.1), 0)
        Me.amountText.Text = area.ToString

    End Sub


#Region "Text Changes Part Box"
    ''' <summary>
    ''' Materials text change.
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub MaterialChange(sender As Object, e As EventArgs) Handles matSelect.SelectedValueChanged

        If Me.matSelect.Text = "" Then

            materialNull = True

        Else

            materialNull = False

        End If

        ActivateMatUpload()

    End Sub

    ''' <summary>
    ''' Area text change.
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub AreaChange(sender As Object, e As EventArgs) Handles amountText.TextChanged

        If Me.amountText.Text = "" Then

            areaNull = True

        Else

            areaNull = False

        End If

        ActivateMatUpload()

    End Sub

#End Region

    ''' <summary>
    ''' Activates the add button for materials bill for part.
    ''' </summary>
    Private Sub ActivateMatUpload()

        If prtNumNull Or materialNull Or areaNull Or m2kBOMGrid.Rows.Count > 0 Then

            Me.addMatButton.Enabled = False

        Else

            Me.addMatButton.Enabled = True

        End If

    End Sub

#End Region

#End Region

    'This area of code is where all the routing functions are.
#Region "Routings Code"

    Dim seqNumNull As Boolean
    Dim wcNumNull As Boolean
    Dim laborNull As Boolean
    Dim crewSizeNull As Boolean

    ''' <summary>
    ''' Handles the Click event of the Add_Button control. Adds user define routing to the part information
    ''' to the table inside the form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddRoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addRoutButton.Click

        Dim seqS As String = Me.seqSelect.Text
        Dim workC As String = Me.wsSelect.Text
        Dim crewS As String = Me.crewText.Text
        Dim laborS As String = Me.laborText.Text
        Dim descS As String = Me.routDesc.Text

        Dim rowExists As Boolean = False

        ' Checks each row to see if this sequence exists
        For Each row As DataGridViewRow In routTable.Rows

            ' if it does the boolean will be flipped
            If row.Cells("seq").Value = seqS Then

                rowExists = True

            End If

        Next

        ' Will not allow it be added if it is already in the GridView
        ' Else it will add it to the GridView
        If rowExists Then

            MsgBox("Row(s) Already Exist. Unable to Add")

        Else

            InsertRout(partNum, seqS, workC, laborS, descS, crewS)
            M2kInfoLoad()

        End If

    End Sub

    Private Sub RemoveRoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeRoutButton.Click

        Dim seqS As String

        Dim row As Integer
        ' Iterating through each item in the DataGridView
        For row = 0 To Me.routTable.Rows.Count - 1

            If Me.routTable.Item(5, row).Value = True Then

                seqS = routTable.Item(0, row).Value

                ' removing the information to SQL
                RemoveSelectedRout(partNum, seqS)

            End If

        Next

        M2kInfoLoad()

        If routTable.Rows.Count > 0 Then

            m_doc.PropertySets.Item("Inventor User Defined Properties").Item("routPushed").Value = True

        Else

            m_doc.PropertySets.Item("Inventor User Defined Properties").Item("routPushed").Value = False

        End If

    End Sub

#Region "Presets"

    ''' <summary>
    ''' Handles the Click event of the crtButton control. This button is the "Cut", "Router", "Tap" button. 
    ''' It is adds predifined values to the routing to table, but still needs to be uploaded.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub crtButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crtButton.Click

        InsertRout(partNum, "10", "150", ".04", "Router Table", "1")
        InsertRout(partNum, "20", "150", ".04", "Router Edges", "1")
        InsertRout(partNum, "30", "150", ".04", "Tap Holes", "1")

        M2kInfoLoad()

    End Sub

    ''' <summary>
    ''' Handles the Click event of the ccButton control. This button is the "Cut", "Router" 
    ''' (AKA Clear Cover Button) button. It is adds predifined values to the routing to table, but 
    ''' still needs to be uploaded.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ccButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ccButton.Click

        InsertRout(partNum, "10", "150", ".04", "Router Table", "1")
        InsertRout(partNum, "20", "150", ".04", "Router Edges", "1")

        M2kInfoLoad()

    End Sub

    ''' <summary>
    ''' Handles the Click event of the crbButton control. This button is the "Cut", "Router", "Bend" button. 
    ''' It is adds predifined values to the routing to table, but still needs to be uploaded.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub crbButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crbButton.Click

        InsertRout(partNum, "10", "150", ".04", "Router Table", "1")
        InsertRout(partNum, "20", "150", ".04", "Router Edges", "1")
        InsertRout(partNum, "30", "70", ".1", "Heat and Bend", "1")

        M2kInfoLoad()

    End Sub

    ''' <summary>
    ''' Handles the Click event of the atpButton control. This button is a preset button that will create
    ''' a routing to assemble the part/assembly to the drawing specs.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub atpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atpButton.Click

        InsertRout(partNum, "10", "70", "1", "Assemble to print. Refer to drawing.", "1")

        M2kInfoLoad()

    End Sub

#End Region

#Region "Text Changes"

    Private Sub SeqNumberChange(sender As Object, e As EventArgs) Handles seqSelect.SelectedValueChanged

        If Me.seqSelect.Text = "" Then

            seqNumNull = True

        Else

            seqNumNull = False

        End If

        ActivateAdd()

    End Sub

    Private Sub WcNumberChange(sender As Object, e As EventArgs) Handles wsSelect.SelectedValueChanged

        If Me.wsSelect.Text = "" Then

            wcNumNull = True

        Else

            wcNumNull = False

        End If

        ActivateAdd()

    End Sub

    Private Sub LaborChange(sender As Object, e As EventArgs) Handles laborText.TextChanged

        If Me.laborText.Text = "" Then

            laborNull = True

        Else

            laborNull = False

        End If

        ActivateAdd()

    End Sub

    Private Sub CrewSizeChange(sender As Object, e As EventArgs) Handles crewText.TextChanged

        If Me.crewText.Text = "" Then

            crewSizeNull = True

        Else

            crewSizeNull = False

        End If

        ActivateAdd()

    End Sub

    ''' <summary>
    ''' This event will be fired when the data table has had data removed from it.
    ''' If nothing is there the upload button will not be enabled. Else, the button is
    ''' disabled.
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DataTableRemove(sender As Object, e As EventArgs) Handles routTable.RowsRemoved

        If routTable.Rows.Count > 0 Then

            Me.addRoutButton.Enabled = True
            Me.ccButton.Enabled = False
            Me.crtButton.Enabled = False
            Me.crbButton.Enabled = False
            Me.atpButton.Enabled = False

        Else

            Me.addRoutButton.Enabled = False
            Me.ccButton.Enabled = True
            Me.crtButton.Enabled = True
            Me.crbButton.Enabled = True
            Me.atpButton.Enabled = True

        End If

        ' Making sure the part has been saved and has information associated with it.
        If Me.partNumberText.Text = "" Then addRoutButton.Enabled = False

    End Sub

    ''' <summary>
    ''' This sub will fire when a row is added. Runs Similar to DataTableRemoved
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DataTableAdded(sender As Object, e As EventArgs) Handles routTable.RowsAdded

        If routTable.Rows.Count > 0 Then

            Me.addRoutButton.Enabled = True
            Me.ccButton.Enabled = False
            Me.crtButton.Enabled = False
            Me.crbButton.Enabled = False
            Me.atpButton.Enabled = False

        Else

            Me.addRoutButton.Enabled = False
            Me.ccButton.Enabled = True
            Me.crtButton.Enabled = True
            Me.crbButton.Enabled = True
            Me.atpButton.Enabled = True

        End If

        ' Making sure the part has been save and ahs information associated with it.
        If Me.partNumberText.Text = "" Then addRoutButton.Enabled = False

    End Sub

#End Region

    ''' <summary>
    ''' Activates the add button if all fields have a valid input.
    ''' </summary>
    Private Sub ActivateAdd()

        If prtNumNull Or seqNumNull Or wcNumNull Or laborNull Or crewSizeNull Then

            Me.addRoutButton.Enabled = False

        Else

            Me.addRoutButton.Enabled = True

        End If

    End Sub




#End Region

#Region "Menu Load Functions"

    ''' <summary>
    ''' Loads the dropdown menus.
    ''' </summary>
    Private Sub LoadMenus()

        Try
            ' Item Master Menus Query
            Dim uomItems As List(Of String) = MenuItemQuery("UOM")
            Dim invTypeItems As List(Of String) = MenuItemQuery("INVTYPE")
            Dim engrStatItems As List(Of String) = MenuItemQuery("ENGRSTAT")
            Dim salesCodeItems As List(Of String) = MenuItemQuery("SALESCODE")
            Dim lTimeCodeItems As List(Of String) = MenuItemQuery("LTCODE")
            Dim egrNames As List(Of String) = MenuItemQuery("EGR")

            ' Routing Menu Query
            Dim wcNums As List(Of String) = MenuItemQuery("WC")

            ' Item Master Menu Set
            Me.uomSelect.DataSource = uomItems
            Me.invTypeSelect.DataSource = invTypeItems
            Me.engStatusSelect.DataSource = engrStatItems
            Me.salesCodeSelect.DataSource = salesCodeItems
            Me.leadTimeSelect.DataSource = lTimeCodeItems
            Me.engineerText.DataSource = egrNames

            ' Routing Menu Set
            Me.wsSelect.DataSource = wcNums

            ' Catching error with loading menus    
        Catch ex As Exception

            MsgBox("Unable to load menus. Error: " + ex.ToString)

        End Try

    End Sub

    ''' <summary>
    ''' Creating and setting Inventor Properties and Customer Properties.
    ''' </summary>
    Private Sub CustomInventorProperties()

        Try

            ' Initialize the values on the dialog using the current property values.
            Me.partNumberText.Text = m_doc.PropertySets.Item("Design Tracking Properties").Item("Part Number").Value
            Me.engineerText.Text = m_doc.PropertySets.Item("Design Tracking Properties").Item("Engineer").Value
            Me.descriptionText.Text = m_doc.PropertySets("Design Tracking Properties").Item("Description").Value
            Me.mfgNameText.Text = m_doc.PropertySets("Design Tracking Properties").Item("Manufacturer").Value
            Me.companyT.Text = m_doc.PropertySets("Inventor Document Summary Information").Item("Company").Value
            Me.salesOrT.Text = m_doc.PropertySets.Item("Design Tracking Properties").Item("Stock Number").Value

            ' If there is not DynaCon values in doc, create them
            If (m_doc.PropertySets("Inventor User Defined Properties").Count = 0) Then

                ' DynaCon custom properties
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

                ' Setting Menus to be blank when they open, if they have to be created
                Me.engStatusSelect.SelectedIndex = -1
                Me.invTypeSelect.SelectedIndex = -1
                Me.leadTimeSelect.SelectedIndex = -1
                Me.sDescriptionText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value
                Me.salesCodeSelect.SelectedIndex = -1
                Me.uomSelect.SelectedIndex = -1
                Me.mfgPrtNumText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value

                ' If these parameters already exist, setting them to their current value
            Else

                If m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value = "" Then

                    Me.engStatusSelect.SelectedIndex = -1
                    Me.invTypeSelect.SelectedIndex = -1
                    Me.leadTimeSelect.SelectedIndex = -1
                    Me.sDescriptionText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value
                    Me.salesCodeSelect.SelectedIndex = -1
                    Me.uomSelect.SelectedIndex = -1
                    Me.mfgPrtNumText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value
                    Me.engineerText.SelectedIndex = -1

                Else

                    Me.engStatusSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("engineerStatus").Value
                    Me.invTypeSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("inventoryType").Value
                    Me.leadTimeSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value
                    Me.sDescriptionText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("sDescription").Value
                    Me.salesCodeSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("salesCode").Value
                    Me.uomSelect.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("unitOfMeasure").Value
                    Me.mfgPrtNumText.Text = m_doc.PropertySets("Inventor User Defined Properties").Item("mfgPartNumber").Value

                End If

            End If

            ' Catching the error loading values.
        Catch ex As Exception

            MsgBox("Error Loading iProperties Information...")

        End Try

    End Sub

    ''' <summary>
    ''' Loading information from SQL (M2k), If SQL has information associated with the part,
    ''' then it will make it a manufactured part and it will not be able to be changed inside
    ''' of Inventor.
    ''' </summary>
    Private Sub M2kInfoLoad()

        m2kBOMGrid.Rows.Clear()
        routTable.Rows.Clear()
        ' loading M2k BOM and Routing information into grids
        Dim bomData As DataSet = BOMQuery(partNum)
        Dim routData As DataSet = RoutQuery(partNum)

        For Each row As DataRow In routData.Tables(0).Rows

            routTable.Rows.Add(row(0), row(1), row(2), row(3), row(4))

        Next

        For Each row As DataRow In bomData.Tables(0).Rows

            m2kBOMGrid.Rows.Add(row(0), row(1))

        Next

        If bomData.Tables(0).Rows.Count > 0 Then

            m2kBOMExists = True
            leadTimeSelect.Text = "M"
            leadTimeSelect.Enabled = False
            manufacturedStandard.Enabled = False
            purchasedStandard.Enabled = False

        End If

        If routData.Tables(0).Rows.Count > 0 Then

            m2kRoutExists = True
            leadTimeSelect.Text = "M"
            leadTimeSelect.Enabled = False
            manufacturedStandard.Enabled = False
            purchasedStandard.Enabled = False

        End If

    End Sub

#End Region

End Class