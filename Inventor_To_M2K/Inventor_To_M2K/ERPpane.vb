Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms
Imports Inventor

Public Class ERPpane

    ' These variables will refer to the Inventor Variables for each
    ' part or assembly.

    ' Inventor Active Document
    Dim m_doc As Document

    ' Inventor Property Sets
    Dim invDesignProp As PropertySet
    Dim invUserProp As PropertySet

    ' Inventor Custom and Standard Properties
    Dim invPartNumberProp As [Property]
    Dim invDescriptionProp As [Property]
    Dim invMfgNameProp As [Property]
    Dim invEngineerProp As [Property]
    Dim invStockNumberProp As [Property]
    Dim invEngStatusProp As [Property]
    Dim invInvTypeProp As [Property]
    Dim invTimeCodeProp As [Property]
    Dim invExtDesc1Prop As [Property]
    Dim invExtDesc2Prop As [Property]
    Dim invExtDesc3Prop As [Property]
    Dim invExtDesc4Prop As [Property]
    Dim invExtDesc5Prop As [Property]
    Dim invSalesCodeProp As [Property]
    Dim invUnitOfMeasProp As [Property]
    Dim invMfgPartNumberProp As [Property]

    ' SQL (Manage 2000) Variables. These variables will coincide with the
    ' Inventor variables with the same naming scheme, just m2k as the prefix

    Dim m2kPartNumber As String
    Dim m2kDescription As String
    Dim m2kMfgName As String
    Dim m2kEngineer As String
    Dim m2kStockNumber As String
    Dim m2kEngStatus As String
    Dim m2kInvType As String
    Dim m2kTimeCode As String
    Dim m2kExtDesc1 As String
    Dim m2kExtDesc2 As String
    Dim m2kExtDesc3 As String
    Dim m2kExtDesc4 As String
    Dim m2kExtDesc5 As String
    Dim m2kSalesCode As String
    Dim m2kUnitOfMeas As String
    Dim m2kMfgPartNumber As String

    ' Window textbox field null value booleans for IM Data
    Dim prtNumNull As Boolean
    Dim sDescNull As Boolean
    Dim invTypeNull As Boolean
    Dim engrStatNull As Boolean
    Dim umNull As Boolean
    Dim leadTimeNull As Boolean
    Dim engrNull As Boolean

    ' Window textbox field null value booleans for Rout Data
    Dim seqNumNull As Boolean
    Dim wcNumNull As Boolean
    Dim laborNull As Boolean
    Dim crewSizeNull As Boolean

    ''' <summary>
    ''' Loading of the ERP (PLM) interface. Reads all relevant data from local Inventor file and SQL Database.
    ''' </summary>
    Private Sub ERPpane_Load() Handles Me.Load

        m_doc = m_inventorApplication.ActiveEditDocument
        invDesignProp = m_doc.PropertySets.Item("Design Tracking Properties")
        invUserProp = m_doc.PropertySets.Item("Inventor User Defined Properties")
        bomBox.Enabled = False
        routBox.Enabled = False
        ManufacturedStandard.Enabled = True
        PurchasedStandard.Enabled = True

        LoadMenus()
        InventorPropertyCheck()
        ItemMasterExist(invPartNumberProp.Value)
        DisplayProperties()
        DocumentTypeCheckLoad()
        M2kInfoLoad()

        prtNumNull = Me.partNumberText.Text.Equals("")
        sDescNull = Me.descriptionText.Text.Equals("")
        invTypeNull = Me.invTypeSelect.Text.Equals("")
        engrStatNull = Me.engStatusSelect.Text.Equals("")
        umNull = Me.uomSelect.Text.Equals("")
        leadTimeNull = Me.leadTimeSelect.Text.Equals("")
        engrNull = Me.engineerText.Text.Equals("")

        ActivateIMUpload()

    End Sub

#Region "Item Master Functions"

    ''' <summary>
    ''' Checking SQL database if there is part information associated with opened inventor part.
    ''' </summary>
    ''' <param name="PartNumber">The part number.</param>
    Private Sub ItemMasterExist(PartNumber As String)

        If IMQuery2(PartNumber, "PartNbr").Length > 1 Then

            m2kDescription = IMQuery2(PartNumber, "Description")
            'm2kMfgName = IMQuery2(PartNumber, "MfgName")
            m2kEngineer = IMQuery2(PartNumber, "EngrResp")
            'm2kStockNumber = IMQuery2(PartNumber, "Customer")
            m2kEngStatus = IMQuery2(PartNumber, "EngineeringStatus")
            m2kInvType = IMQuery2(PartNumber, "InventoryType")
            m2kTimeCode = IMQuery2(PartNumber, "LeadTimeCode")
            m2kExtDesc1 = ExtDescQuery(PartNumber, "1")
            m2kExtDesc2 = ExtDescQuery(PartNumber, "2")
            m2kExtDesc3 = ExtDescQuery(PartNumber, "3")
            m2kExtDesc4 = ExtDescQuery(PartNumber, "4")
            m2kExtDesc5 = ExtDescQuery(PartNumber, "5")
            m2kSalesCode = IMQuery2(PartNumber, "SalesCode")
            m2kUnitOfMeas = IMQuery2(PartNumber, "Um")
            'm2kMfgPartNumber = IMQuery2(PartNumber, "MfgItemNbr")

            ' If the values between Inventor and SQL (M2k) are different
            ' then the corresponding boolean will be true.
            Dim DescriptionDiff = Not m2kDescription.Equals(invDescriptionProp.Value)
            'Dim MfgNameDiff = Not m2kMfgName.Equals(invMfgNameProp.Value)
            Dim EngineerDiff = Not m2kEngineer.Equals(invEngineerProp.Value)
            'Dim StockNumberDiff = Not m2kStockNumber.Equals(invStockNumberProp.Value)
            Dim EngStatusDiff = Not m2kEngStatus.Equals(invEngStatusProp.Value)
            Dim InvTypeDiff = Not m2kInvType.Equals(invInvTypeProp.Value)
            Dim TimeCodeDiff = Not m2kTimeCode.Equals(invTimeCodeProp.Value)
            Dim ExtDesc1Diff = Not m2kExtDesc1.Equals(invExtDesc1Prop.Value)
            Dim ExtDesc2Diff = Not m2kExtDesc2.Equals(invExtDesc2Prop.Value)
            Dim ExtDesc3Diff = Not m2kExtDesc3.Equals(invExtDesc3Prop.Value)
            Dim ExtDesc4Diff = Not m2kExtDesc4.Equals(invExtDesc4Prop.Value)
            Dim ExtDesc5Diff = Not m2kExtDesc5.Equals(invExtDesc5Prop.Value)
            Dim SalesCodeDiff = Not m2kSalesCode.Equals(invSalesCodeProp.Value)
            Dim UnitOfMeasDiff = Not m2kUnitOfMeas.Equals(invUnitOfMeasProp.Value)
            'Dim MfgPartNumberDiff = Not m2kMfgPartNumber.Equals(invMfgPartNumberProp.Value)

            If DescriptionDiff Or
                EngineerDiff Or
                EngStatusDiff Or
                InvTypeDiff Or
                TimeCodeDiff Or
                ExtDesc1Diff Or
                ExtDesc2Diff Or
                ExtDesc3Diff Or
                ExtDesc4Diff Or
                ExtDesc5Diff Or
                SalesCodeDiff Or
                UnitOfMeasDiff Then

                Dim updateInfoMessage As String = "The following information is different than Manage 2000:" & vbCrLf
                If DescriptionDiff Then updateInfoMessage = updateInfoMessage & "- Short Description" & vbCrLf
                'If MfgNameDiff Then updateInfoMessage = updateInfoMessage & "- Manufacture Name" & vbCrLf
                If EngineerDiff Then updateInfoMessage = updateInfoMessage & "- Engineer" & vbCrLf
                'If StockNumberDiff Then updateInfoMessage = updateInfoMessage & "- Sales Order Information" & vbCrLf
                If EngStatusDiff Then updateInfoMessage = updateInfoMessage & "- Engineering Status" & vbCrLf
                If InvTypeDiff Then updateInfoMessage = updateInfoMessage & "- Inventory Type" & vbCrLf
                If TimeCodeDiff Then updateInfoMessage = updateInfoMessage & "- Lead Time Code" & vbCrLf
                If ExtDesc1Diff Then updateInfoMessage = updateInfoMessage & "- Extended Description 1" & vbCrLf
                If ExtDesc2Diff Then updateInfoMessage = updateInfoMessage & "- Extended Description 2" & vbCrLf
                If ExtDesc3Diff Then updateInfoMessage = updateInfoMessage & "- Extended Description 3" & vbCrLf
                If ExtDesc4Diff Then updateInfoMessage = updateInfoMessage & "- Extended Description 4" & vbCrLf
                If ExtDesc5Diff Then updateInfoMessage = updateInfoMessage & "- Extended Description 5" & vbCrLf
                If SalesCodeDiff Then updateInfoMessage = updateInfoMessage & "- Sales Code" & vbCrLf
                If UnitOfMeasDiff Then updateInfoMessage = updateInfoMessage & "- Unit Of Measure" & vbCrLf
                'If MfgPartNumberDiff Then updateInfoMessage = updateInfoMessage & "- Manufacture Part Number" & vbCrLf

                updateInfoMessage = updateInfoMessage & "Would you like to update Inventor's Information?"

                Dim updateyesno As MsgBoxResult = MsgBox(updateInfoMessage, MsgBoxStyle.YesNo, "Update Local Info")

                If updateyesno = vbYes Then

                    LoadInfoFromSQL()

                Else

                    MsgBox("Inventor's Information will not be updated to match Manage 2000.")

                End If

            End If

            If invTimeCodeProp.Value = "M" Then

                bomBox.Enabled = True
                routBox.Enabled = True

            End If

        End If

    End Sub

#Region "Changes In text fields"

    Private Sub PartNumberChange(sender As Object, e As EventArgs) Handles partNumberText.TextChanged

        If partNumberText.Text = "" Then

            prtNumNull = True

        Else

            prtNumNull = False

        End If

        ActivateIMUpload()

    End Sub

    Private Sub ShortDescChange(sender As Object, e As EventArgs) Handles descriptionText.TextChanged

        If descriptionText.Text = "" Then

            sDescNull = True

        Else

            sDescNull = False

        End If

        ActivateIMUpload()

    End Sub

    Private Sub InvTypeChange(sender As Object, e As EventArgs) Handles invTypeSelect.SelectedValueChanged

        If invTypeSelect.Text = "" Then

            invTypeNull = True

        Else

            invTypeNull = False

        End If

        ActivateIMUpload()

    End Sub

    Private Sub EngrStatChange(sender As Object, e As EventArgs) Handles engStatusSelect.SelectedValueChanged

        If engStatusSelect.Text = "" Then

            engrStatNull = True

        Else

            engrStatNull = False

        End If

        ActivateIMUpload()

    End Sub

    Private Sub UnitOfMeasureChange(sender As Object, e As EventArgs) Handles uomSelect.SelectedValueChanged

        If uomSelect.Text = "" Then

            umNull = True

        Else

            umNull = False

        End If

        ActivateIMUpload()

    End Sub

    Private Sub LeadTimeCodeChange(sender As Object, e As EventArgs) Handles leadTimeSelect.SelectedValueChanged

        If leadTimeSelect.Text = "" Then

            leadTimeNull = True

        Else

            leadTimeNull = False

        End If

        If leadTimeSelect.Text = "P" Then

            routBox.Enabled = False
            bomBox.Enabled = False

        Else



            If IMQuery2(invPartNumberProp.Value, "PartNbr").Length > 1 Then

                routBox.Enabled = True
                bomBox.Enabled = True

            Else

                bomBox.Enabled = False
                routBox.Enabled = False

            End If

        End If

        ActivateIMUpload()

    End Sub

    Private Sub EngineerChange(sender As Object, e As EventArgs) Handles engineerText.SelectedValueChanged

        If engineerText.Text = "" Then

            engrNull = True

        Else

            engrNull = False

        End If

        ActivateIMUpload()

    End Sub

#End Region

    ''' <summary>
    ''' Will enabled upload Item Master Button in Finalize box if all values 
    ''' have information. Otherwise they will still be disabled. Uses the 
    ''' "Change in text Fields" methods to do this.
    ''' </summary>
    Private Sub ActivateIMUpload()

        If prtNumNull Or sDescNull Or invTypeNull Or engrStatNull Or umNull Or leadTimeNull Or engrNull Then

            uploadIMButton.Enabled = False

        Else

            uploadIMButton.Enabled = True

        End If

    End Sub

    ''' <summary>
    ''' Saves whats in the IM texts fields to the local Inventor custom variables.
    ''' </summary>
    Private Sub SaveLocal()

        invDescriptionProp.Value = descriptionText.Text
        invMfgNameProp.Value = mfgNameText.Text
        invEngineerProp.Value = engineerText.SelectedValue
        invStockNumberProp.Value = salesOrT.Text
        invEngStatusProp.Value = engStatusSelect.SelectedValue
        invInvTypeProp.Value = invTypeSelect.SelectedValue
        invTimeCodeProp.Value = leadTimeSelect.Text
        invExtDesc1Prop.Value = extDesc1.Text
        invExtDesc2Prop.Value = extDesc2.Text
        invExtDesc3Prop.Value = extDesc3.Text
        invExtDesc4Prop.Value = extDesc4.Text
        invExtDesc5Prop.Value = extDesc5.Text
        invSalesCodeProp.Value = salesCodeSelect.SelectedValue
        invUnitOfMeasProp.Value = uomSelect.SelectedValue
        invMfgPartNumberProp.Value = mfgPrtNumText.Text

        m_doc.Save()

    End Sub

    ''' <summary>
    ''' Calls the SaveLocal method, handles interface button click.
    ''' </summary>
    Private Sub Save_Local_Button_Click() Handles saveLocalButton.Click

        SaveLocal()
        MsgBox("The local information has been updated.")

    End Sub

    ''' <summary>
    ''' Uploads the inventor data to SQL by using the Inserts in sqlServ.
    ''' </summary>
    Private Sub Upload_IM_Button() Handles uploadIMButton.Click

        SaveLocal()

        ' Inserting IM data
        InsertIM(invPartNumberProp.Value,
                 invDescriptionProp.Value,
                 invInvTypeProp.Value,
                 invUnitOfMeasProp.Value,
                 invEngStatusProp.Value,
                 invSalesCodeProp.Value,
                 invTimeCodeProp.Value,
                 invEngineerProp.Value)

        'Inserting ExtDesc to seperate tables using a list.
        Dim ExtDescList As List(Of String) = New List(Of String) From {
        invExtDesc1Prop.Value,
        invExtDesc2Prop.Value,
        invExtDesc3Prop.Value,
        invExtDesc4Prop.Value,
        invExtDesc5Prop.Value}

        InsertExtDesc(invPartNumberProp.Value, ExtDescList)

        MsgBox("The part information has been uploaded to Manage 2000 and saved locally.")
        itemMasterBox.Enabled = False
        uploadIMButton.Enabled = False

        If invTimeCodeProp.Value = "M" Then
            routBox.Enabled = True
            bomBox.Enabled = True
        Else
            routBox.Enabled = False
            bomBox.Enabled = False
        End If

    End Sub

    ''' <summary>
    ''' Handles the Click event of the Manufactured control. This is a group of preset values used often.
    ''' It will set the values of the drop down menus to a standard "Manufactured" part.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub Manufactured_Click(sender As Object, e As EventArgs) Handles ManufacturedStandard.Click

        Me.uomSelect.Text = "Each"
        Me.engStatusSelect.Text = "NOT FOR SALE"
        Me.invTypeSelect.Text = "Raw"
        Me.leadTimeSelect.Text = "M"

        invEngStatusProp.Value = Me.engStatusSelect.SelectedValue
        invInvTypeProp.Value = Me.invTypeSelect.SelectedValue
        invTimeCodeProp.Value = Me.leadTimeSelect.SelectedValue
        invUnitOfMeasProp.Value = Me.uomSelect.SelectedValue

    End Sub

    ''' <summary>
    ''' Handles the Click event of the Purchased control. This is a group of preset values used often.
    ''' It will set the values of the drop down menus to a standard "Purchased" part.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub Purchased_Click(sender As Object, e As EventArgs) Handles PurchasedStandard.Click

        Me.uomSelect.Text = "Each"
        Me.engStatusSelect.Text = "NOT FOR SALE"
        Me.invTypeSelect.Text = "Raw"
        Me.leadTimeSelect.Text = "P"

        invEngStatusProp.Value = Me.engStatusSelect.SelectedValue
        invInvTypeProp.Value = Me.invTypeSelect.SelectedValue
        invTimeCodeProp.Value = Me.leadTimeSelect.SelectedValue
        invUnitOfMeasProp.Value = Me.uomSelect.SelectedValue

    End Sub

#End Region

#Region "Inventor And Display Functions"

    ''' <summary>
    ''' Checking the size of custom inventor variables
    ''' .Step files typically are imported with 2 custom 
    ''' variables. So, this will add the necessary ones if
    ''' they do not exist.
    ''' Creating new properties and assigning them to these variables.
    ''' if they do not exist already.
    ''' </summary>
    Private Sub InventorPropertyCheck()

        Try
            invEngStatusProp = invUserProp.Item("engineerStatus")
        Catch ex As Exception
            invEngStatusProp = invUserProp.Add("", "engineerStatus")
        End Try

        Try
            invInvTypeProp = invUserProp.Item("inventoryType")
        Catch ex As Exception
            invInvTypeProp = invUserProp.Add("", "inventoryType")
        End Try

        Try
            invTimeCodeProp = invUserProp.Item("leadTimeCode")
        Catch ex As Exception
            invTimeCodeProp = invUserProp.Add("", "leadTimeCode")
        End Try

        Try
            invMfgPartNumberProp = invUserProp.Item("mfgPartNumber")
        Catch ex As Exception
            invMfgPartNumberProp = invUserProp.Add("", "mfgPartNumber")
        End Try

        Try
            invExtDesc1Prop = invUserProp.Item("extDesc1")
        Catch ex As Exception
            invExtDesc1Prop = invUserProp.Add("", "extDesc1")
        End Try

        Try
            invExtDesc2Prop = invUserProp.Item("extDesc2")
        Catch ex As Exception
            invExtDesc2Prop = invUserProp.Add("", "extDesc2")
        End Try

        Try
            invExtDesc3Prop = invUserProp.Item("extDesc3")
        Catch ex As Exception
            invExtDesc3Prop = invUserProp.Add("", "extDesc3")
        End Try

        Try
            invExtDesc4Prop = invUserProp.Item("extDesc4")
        Catch ex As Exception
            invExtDesc4Prop = invUserProp.Add("", "extDesc4")
        End Try

        Try
            invExtDesc5Prop = invUserProp.Item("extDesc5")
        Catch ex As Exception
            invExtDesc5Prop = invUserProp.Add("", "extDesc5")
        End Try

        Try
            invSalesCodeProp = invUserProp.Item("salesCode")
        Catch ex As Exception
            invSalesCodeProp = invUserProp.Add("", "salesCode")
        End Try

        Try
            invUnitOfMeasProp = invUserProp.Item("unitOfMeasure")
        Catch ex As Exception
            invUnitOfMeasProp = invUserProp.Add("", "unitOfMeasure")
        End Try


        invPartNumberProp = invDesignProp.Item("Part Number")
        invDescriptionProp = invDesignProp.Item("Description")
        invMfgNameProp = invDesignProp.Item("Manufacturer")
        invEngineerProp = invDesignProp.Item("Engineer")
        invStockNumberProp = invDesignProp.Item("Stock Number")

    End Sub

    ''' <summary>
    ''' Checking what type of inventor document is open (Part or Assembly).
    ''' </summary>
    Private Sub DocumentTypeCheckLoad()

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

    End Sub

    ''' <summary>
    ''' Displays the inventor standard and interface defined variable in the text fields.
    ''' </summary>
    Private Sub DisplayProperties()

        partNumberText.Text = invPartNumberProp.Value
        descriptionText.Text = invDescriptionProp.Value
        mfgNameText.Text = invMfgNameProp.Value
        engineerText.SelectedValue = invEngineerProp.Value
        salesOrT.Text = invStockNumberProp.Value
        engStatusSelect.SelectedValue = invEngStatusProp.Value
        invTypeSelect.SelectedValue = invInvTypeProp.Value
        leadTimeSelect.Text = invTimeCodeProp.Value
        extDesc1.Text = invExtDesc1Prop.Value
        extDesc2.Text = invExtDesc2Prop.Value
        extDesc3.Text = invExtDesc3Prop.Value
        extDesc4.Text = invExtDesc4Prop.Value
        extDesc5.Text = invExtDesc5Prop.Value
        salesCodeSelect.SelectedValue = invSalesCodeProp.Value
        uomSelect.SelectedValue = invUnitOfMeasProp.Value
        mfgPrtNumText.Text = invMfgPartNumberProp.Value

    End Sub

    ''' <summary>
    ''' Refreshes (reloads) bill and routing information.
    ''' </summary>
    Private Sub RefreshM2KInfo() Handles pullsqlButton.Click

        M2kInfoLoad()

    End Sub

#End Region

#Region "Bill Of Materials Functions"

    ''' <summary>
    ''' Inserts each element of the Inventor BOM that has been selected by the user.
    ''' </summary>
    Private Sub BOMInsert() Handles addBillButton.Click

        Dim partNumC As String
        Dim partCqty As String

        Dim row As Integer
        ' Iterating through each item in the DataGridView
        For row = 0 To Me.invBOMGrid.Rows.Count - 1

            If Me.invBOMGrid.Item(2, row).Value = True Then

                partNumC = invBOMGrid.Item(0, row).Value
                partCqty = invBOMGrid.Item(1, row).Value

                If partNumC Is Nothing Then

                    MsgBox("You must enter a valid part number.")

                Else

                    If Not IsNumeric(partCqty) Then

                        MsgBox("You must enter a valid quantity.")

                    End If

                    If IsNumeric(partCqty) Then

                        If partCqty = 0 Then

                            MsgBox("You must enter a quantity greater than 0.")

                        Else

                            ' Importing the information to SQL
                            InsertBOM2(invPartNumberProp.Value, partNumC, partCqty)

                        End If

                    End If

                End If

            End If

        Next

        M2kInfoLoad()

    End Sub

    Private Sub BillRemove()

        Dim partNumC As String
        Dim partCqty As String

        Dim row As Integer
        ' Iterating through each item in the DataGridView
        For row = 0 To Me.m2kBOMGrid.Rows.Count - 1

            If Me.m2kBOMGrid.Item(2, row).Value = True Then

                partNumC = m2kBOMGrid.Item(0, row).Value
                partCqty = m2kBOMGrid.Item(1, row).Value

                ' Importing the information to SQL
                RemoveSelectedBill(invPartNumberProp.Value, partNumC)

            End If

        Next

        M2kInfoLoad()

    End Sub

    ''' <summary>
    ''' Removes each item selected by the user in the M2k BOM table.
    ''' The sqlServ module will really on make the value associated with
    ''' the component part equal to 0.
    ''' </summary>
    Private Sub BOMRemove() Handles removeBillButton.Click

        BillRemove()

    End Sub

    ''' <summary>
    ''' Adds the material number selected by the user to SQL table.
    ''' 
    ''' UPDATE: Allow users to add multiple materials for Part doc.
    ''' </summary>
    Private Sub AddMaterial() Handles addMatButton.Click

        Dim material As String = Me.matSelect.SelectedValue
        Dim squInch As String = Me.amountText.Text

        ' Checks to make sure that values are numbers. Not letters
        If Not IsNumeric(squInch) Then

            MsgBox("Amount must be a numeric value")

        Else

            If squInch = 0 Then

                MsgBox("Enter a value greater than 0.")

            Else

                ' Push information to SQL
                InsertBOM2(invPartNumberProp.Value, material, squInch)

            End If

            M2kInfoLoad()

        End If

    End Sub

    ''' <summary>
    ''' Removes material from SQL bom table. Similar to RemoveBOM, this process
    ''' really only makes the value of the component part equal to 0.
    ''' </summary>
    Private Sub RemoveMaterial() Handles removeMatButton.Click

        BillRemove()

    End Sub

    'Private Sub CalculateArea() Handles matAreaButton.Click

    '    ' NEED TO UPDATE FOR ACCURACY!
    '    Dim oFace As Face = m_inventorApplication.CommandManager.Pick(SelectionFilterEnum.kPartFaceFilter, "Select Cut Face")
    '    Me.BringToFront()
    '    Dim area As Double = Math.Round((oFace.Evaluator.Area * 0.155) + (oFace.Evaluator.Area * 0.1), 0)
    '    Me.amountText.Text = area.ToString

    'End Sub

    ''' <summary>
    ''' Adds a custom material to the list of materials that can be chosen.
    ''' </summary>
    Private Sub CustomMaterialAdd() Handles customButton.Click

        Dim customMaterial = InputBox("Add Custom Material", "Custom Material")

        If customMaterial.Length = 0 Or customMaterial.Length > 20 Then

            MsgBox("The material name has not been entered or is greater than 20 characters.")

        Else

            Dim matDropDown As DataTable = matSelect.DataSource.toTable()
            Dim newRow As DataRow = matDropDown.NewRow()
            newRow(0) = customMaterial
            newRow(1) = customMaterial
            matDropDown.Rows.Add(newRow)

            Dim matView As DataView = New DataView(matDropDown)
            Me.matSelect.DataSource = matView
            Me.matSelect.DisplayMember = "Description"
            Me.matSelect.ValueMember = "PartNbr"

        End If

    End Sub

#End Region

#Region "Routing Functions"

    ''' <summary>
    ''' Handles the Click event of the Add_Button control. Adds user define routing to the part information
    ''' to the table inside the form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddRoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addRoutButton.Click

        Dim seqS As String = Me.seqSelect.Text
        Dim workC As String = Me.wsSelect.SelectedValue
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
        ' Else it will add it to the GridView and update the gridview for
        ' for the user.
        If rowExists Then

            MsgBox("Row(s) Already Exist. Unable to Add.")

        ElseIf Not IsNumeric(crewS) Then

            MsgBox("You must enter an integer value for crew size.")

        ElseIf Not IsNumeric(laborS) Then

            MsgBox("You must enter an integer value for labor time.")

        ElseIf IsNumeric(laborS) Then

            If laborS <= 0 Then

                MsgBox("Labor time must be greater than 0.")

            Else

                InsertRout2(invPartNumberProp.Value, seqS, workC, laborS, descS, crewS)

            End If

            M2kInfoLoad()

        End If

    End Sub

    ''' <summary>
    ''' Handles the Click event of the RemoveRoutButton control. It really does not remove a 
    ''' routing from the table, instead it will change the labor hours to 0, so M2k can 
    ''' remove it after. 
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub RemoveRoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeRoutButton.Click

        Dim seqS As String

        Dim row As Integer
        ' Iterating through each item in the DataGridView
        For row = 0 To Me.routTable.Rows.Count - 1

            If Me.routTable.Item(5, row).Value = True Then

                seqS = routTable.Item(0, row).Value

                ' removing the information to SQL
                RemoveSelectedRout2(invPartNumberProp.Value, seqS)

            End If

        Next

        M2kInfoLoad()

        'If routTable.Rows.Count > 0 Then

        '    m_doc.PropertySets.Item("Inventor User Defined Properties").Item("routPushed").Value = True

        'Else

        '    m_doc.PropertySets.Item("Inventor User Defined Properties").Item("routPushed").Value = False

        'End If

    End Sub

#Region "Presets"

    ''' <summary>
    ''' Sets textboxes to standard process used alot (CNC Cut).
    ''' </summary>
    Private Sub CutPreset() Handles CutButton.Click

        seqSelect.Text = "10"
        wsSelect.SelectedValue = "150"
        crewText.Text = "1"
        laborText.Text = ".04"
        routDesc.Text = "CNC Router Program."

    End Sub

    ''' <summary>
    ''' Sets textboxes to standard process used alot (Table round).
    ''' </summary>
    Private Sub RoundPreset() Handles RoundButton.Click

        seqSelect.Text = "20"
        wsSelect.SelectedValue = "150"
        crewText.Text = "1"
        laborText.Text = ".04"
        routDesc.Text = "Round edges with table router."

    End Sub

    ''' <summary>
    ''' Sets textboxes to standard process used alot (Tap).
    ''' </summary>
    Private Sub TapPreset() Handles TapButton.Click

        seqSelect.Text = "30"
        wsSelect.SelectedValue = "150"
        crewText.Text = "1"
        laborText.Text = ".04"
        routDesc.Text = "Tap holes with 3/8-16."

    End Sub

    ''' <summary>
    ''' Sets textboxes to standard process used alot (Assemble).
    ''' </summary>
    Private Sub AssemblePreset() Handles AssembleButton.Click

        seqSelect.Text = "10"
        wsSelect.SelectedValue = "70"
        crewText.Text = "1"
        laborText.Text = ".5"
        routDesc.Text = "Assemble to print."

    End Sub


#End Region

#Region "Text Changes in ROUT"

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

        Else

            Me.addRoutButton.Enabled = False

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

        Else

            Me.addRoutButton.Enabled = False

        End If

        ' Making sure the part has been save and ahs information associated with it.
        If Me.partNumberText.Text = "" Then addRoutButton.Enabled = False

    End Sub

#End Region

    ''' <summary>
    ''' Activates the add button in Routings if all fields have a valid input.
    ''' Uses "Text Changes in Rout" methods.
    ''' </summary>
    Private Sub ActivateAdd()

        If prtNumNull Or seqNumNull Or wcNumNull Or laborNull Or crewSizeNull Then

            Me.addRoutButton.Enabled = False

        Else

            Me.addRoutButton.Enabled = True

        End If

    End Sub

#End Region

#Region "SQL Information Loading"

    ''' <summary>
    ''' Loads the information from SQL.
    ''' </summary>
    Private Sub LoadInfoFromSQL()

        invDescriptionProp.Value = m2kDescription
        'invMfgNameProp.Value = m2kMfgName
        invEngineerProp.Value = m2kEngineer
        'invStockNumberProp.Value = m2kStockNumber
        invEngStatusProp.Value = m2kEngStatus
        invInvTypeProp.Value = m2kInvType
        invTimeCodeProp.Value = m2kTimeCode
        invExtDesc1Prop.Value = m2kExtDesc1
        invExtDesc2Prop.Value = m2kExtDesc2
        invExtDesc3Prop.Value = m2kExtDesc3
        invExtDesc4Prop.Value = m2kExtDesc4
        invExtDesc5Prop.Value = m2kExtDesc5
        invSalesCodeProp.Value = m2kSalesCode
        invUnitOfMeasProp.Value = m2kUnitOfMeas
        'invMfgPartNumberProp.Value = m2kMfgPartNumber

    End Sub

    ''' <summary>
    ''' Loads the menu options from SQL (Drop down lists).
    ''' </summary>
    Sub LoadMenus()

        Try
            ' Item Master Menus Query
            'Dim uomItems As List(Of String) = MenuItemQuery("UOM")
            'Dim invTypeItems As SqlDataReader = MenuValueQuery("INVTYPE")
            'Dim engrStatItems As List(Of String) = MenuItemQuery("ENGRSTAT")
            'Dim salesCodeItems As List(Of String) = MenuItemQuery("SALESCODE")
            'Dim egrNames As List(Of String) = MenuItemQuery("EGR")

            ' Routing Menu Query
            'Dim wcNums As List(Of String) = MenuItemQuery("WC")

            ' Item Master Menu Set
            Me.uomSelect.DataSource = MenuValueQuery("UOM")
            Me.uomSelect.DisplayMember = "Description"
            Me.uomSelect.ValueMember = "ID"

            Me.invTypeSelect.DataSource = MenuValueQuery("INVTYPE")
            Me.invTypeSelect.DisplayMember = "Description"
            Me.invTypeSelect.ValueMember = "ID"

            Me.engStatusSelect.DataSource = MenuValueQuery("ENGRSTAT")
            Me.engStatusSelect.DisplayMember = "Description"
            Me.engStatusSelect.ValueMember = "ID"

            Me.salesCodeSelect.DataSource = MenuValueQuery("SALESCODE")
            Me.salesCodeSelect.DisplayMember = "Description"
            Me.salesCodeSelect.ValueMember = "ID"

            Dim lTimeCodeItems As List(Of String) = MenuItemQuery("LTCODE")
            Me.leadTimeSelect.DataSource = lTimeCodeItems

            Me.engineerText.DataSource = MenuValueQuery("EGR")
            Me.engineerText.DisplayMember = "Description"
            Me.engineerText.ValueMember = "ID"

            Me.matSelect.DataSource = RouterMaterialSelect()
            Me.matSelect.DisplayMember = "Description"
            Me.matSelect.ValueMember = "PartNbr"

            ' Routing Menu Set
            Me.wsSelect.DataSource = MenuValueQuery("WC")
            Me.wsSelect.DisplayMember = "Description"
            Me.wsSelect.ValueMember = "ID"

            ' Catching error with loading menus    
        Catch ex As Exception

            MsgBox("Unable to load menus. Error: " + ex.ToString)

        End Try

    End Sub

    ''' <summary>
    ''' Loading information using sqlServ queries. This only populates the grid
    ''' areas (BOM and ROUT).
    ''' </summary>
    Private Sub M2kInfoLoad()

        m2kBOMGrid.Rows.Clear()
        routTable.Rows.Clear()
        ' loading M2k BOM and Routing information into grids
        Dim bomData As DataSet = BOMQuery2(invPartNumberProp.Value)
        Dim routData As DataSet = RoutQuery2(invPartNumberProp.Value)

        For Each row As DataRow In routData.Tables(0).Rows

            routTable.Rows.Add(row(0), row(1), row(2), row(3), row(4))

        Next

        For Each row As DataRow In bomData.Tables(0).Rows

            m2kBOMGrid.Rows.Add(row(0), row(1))

        Next

        If bomData.Tables(0).Rows.Count > 0 Then

            invTimeCodeProp.Value = "M"
            leadTimeSelect.Enabled = False
            ManufacturedStandard.Enabled = False
            PurchasedStandard.Enabled = False

        End If

        If routData.Tables(0).Rows.Count > 0 Then

            invTimeCodeProp.Value = "M"
            leadTimeSelect.Enabled = False
            ManufacturedStandard.Enabled = False
            PurchasedStandard.Enabled = False

        End If

    End Sub

#End Region

    Private Sub InvSelectAll_Click() Handles InvSelectAll.Click
        Dim row As Integer
        ' Iterating through each item in the DataGridView
        ' and make it true
        For row = 0 To Me.invBOMGrid.Rows.Count - 1

            Me.invBOMGrid.Item(2, row).Value = True

        Next

    End Sub

    Private Sub InvUnselectAll_Click() Handles InvDeselectAll.Click
        Dim row As Integer
        ' Iterating through each item in the DataGridView
        ' and make it false
        For row = 0 To Me.invBOMGrid.Rows.Count - 1

            Me.invBOMGrid.Item(2, row).Value = False

        Next

    End Sub

    Private Sub M2kSelectAll_Click() Handles M2kSelectAll.Click
        Dim row As Integer
        ' Iterating through each item in the DataGridView
        ' and make it true
        For row = 0 To Me.m2kBOMGrid.Rows.Count - 1

            Me.m2kBOMGrid.Item(2, row).Value = True

        Next

    End Sub

    Private Sub M2kUnselectAll_Click() Handles M2kDeselectAll.Click
        Dim row As Integer
        ' Iterating through each item in the DataGridView
        ' and make it true
        For row = 0 To Me.m2kBOMGrid.Rows.Count - 1

            Me.m2kBOMGrid.Item(2, row).Value = False

        Next

    End Sub

    ''' <summary>
    ''' Closes the interface.
    ''' </summary>
    Private Sub CloseButtonClick() Handles Close_Button.Click

        Dim m2kDescriptionClose = IMQuery2(invPartNumberProp.Value, "Description")
        Dim m2kEngineerClose = IMQuery2(invPartNumberProp.Value, "EngrResp")
        Dim m2kEngStatusClose = IMQuery2(invPartNumberProp.Value, "EngineeringStatus")
        Dim m2kInvTypeClose = IMQuery2(invPartNumberProp.Value, "InventoryType")
        Dim m2kTimeCodeClose = IMQuery2(invPartNumberProp.Value, "LeadTimeCode")
        Dim m2kExtDesc1Close = ExtDescQuery(invPartNumberProp.Value, "1")
        Dim m2kExtDesc2Close = ExtDescQuery(invPartNumberProp.Value, "2")
        Dim m2kExtDesc3Close = ExtDescQuery(invPartNumberProp.Value, "3")
        Dim m2kExtDesc4Close = ExtDescQuery(invPartNumberProp.Value, "4")
        Dim m2kExtDesc5Close = ExtDescQuery(invPartNumberProp.Value, "5")
        Dim m2kSalesCodeClose = IMQuery2(invPartNumberProp.Value, "SalesCode")
        Dim m2kUnitOfMeasClose = IMQuery2(invPartNumberProp.Value, "Um")

        ' If the values between Inventor and SQL (M2k) are different
        ' then the corresponding boolean will be true.
        Dim DescriptionTextDiff = Not m2kDescriptionClose.Equals(descriptionText.Text)
        Dim EngineerTextDiff = Not m2kEngineerClose.Equals(engineerText.SelectedValue)
        Dim EngStatusTextDiff = Not m2kEngStatusClose.Equals(engStatusSelect.SelectedValue)
        Dim InvTypeTextDiff = Not m2kInvTypeClose.Equals(invTypeSelect.SelectedValue)
        Dim TimeCodeTextDiff = Not m2kTimeCodeClose.Equals(leadTimeSelect.Text)
        Dim ExtDesc1TextDiff = Not m2kExtDesc1Close.Equals(extDesc1.Text)
        Dim ExtDesc2TextDiff = Not m2kExtDesc2Close.Equals(extDesc2.Text)
        Dim ExtDesc3TextDiff = Not m2kExtDesc3Close.Equals(extDesc3.Text)
        Dim ExtDesc4TextDiff = Not m2kExtDesc4Close.Equals(extDesc4.Text)
        Dim ExtDesc5TextDiff = Not m2kExtDesc5Close.Equals(extDesc5.Text)
        Dim SalesCodeTextDiff = Not m2kSalesCodeClose.Equals(salesCodeSelect.SelectedValue)
        Dim UnitOfMeasTextDiff = Not m2kUnitOfMeasClose.Equals(uomSelect.SelectedValue)

        If DescriptionTextDiff Or
            EngineerTextDiff Or
            EngStatusTextDiff Or
            InvTypeTextDiff Or
            TimeCodeTextDiff Or
            ExtDesc1TextDiff Or
            ExtDesc2TextDiff Or
            ExtDesc3TextDiff Or
            ExtDesc4TextDiff Or
            ExtDesc5TextDiff Or
            SalesCodeTextDiff Or
            UnitOfMeasTextDiff Then

            Dim updateInfoMessage As String = "The following information is different than Manage 2000:" & vbCrLf
            If DescriptionTextDiff Then updateInfoMessage = updateInfoMessage & "- Short Description" & vbCrLf
            If EngineerTextDiff Then updateInfoMessage = updateInfoMessage & "- Engineer" & vbCrLf
            If EngStatusTextDiff Then updateInfoMessage = updateInfoMessage & "- Engineering Status" & vbCrLf
            If InvTypeTextDiff Then updateInfoMessage = updateInfoMessage & "- Inventory Type" & vbCrLf
            If TimeCodeTextDiff Then updateInfoMessage = updateInfoMessage & "- Lead Time Code" & vbCrLf
            If ExtDesc1TextDiff Then updateInfoMessage = updateInfoMessage & "- Extended Description 1" & vbCrLf
            If ExtDesc2TextDiff Then updateInfoMessage = updateInfoMessage & "- Extended Description 2" & vbCrLf
            If ExtDesc3TextDiff Then updateInfoMessage = updateInfoMessage & "- Extended Description 3" & vbCrLf
            If ExtDesc4TextDiff Then updateInfoMessage = updateInfoMessage & "- Extended Description 4" & vbCrLf
            If ExtDesc5TextDiff Then updateInfoMessage = updateInfoMessage & "- Extended Description 5" & vbCrLf
            If SalesCodeTextDiff Then updateInfoMessage = updateInfoMessage & "- Sales Code" & vbCrLf
            If UnitOfMeasTextDiff Then updateInfoMessage = updateInfoMessage & "- Unit Of Measure" & vbCrLf

            updateInfoMessage = updateInfoMessage & "You have made changes to part information. When you exit these changes will not be in Manage 2000." & vbCrLf

            updateInfoMessage = updateInfoMessage & "Are you sure you want to exit?"

            Dim closeyesno As MsgBoxResult = MsgBox(updateInfoMessage, MsgBoxStyle.YesNo, "Are you sure?")

            If closeyesno.Equals(vbYes) Then

                Me.Close()

            End If

        Else

            Me.Close()

        End If


    End Sub

End Class