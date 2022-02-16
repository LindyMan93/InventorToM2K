Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms
Imports Inventor

Public Class QuickNotes

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

    Private Sub QuickNotes_Load() Handles Me.Load
        m_doc = m_inventorApplication.ActiveEditDocument
        invDesignProp = m_doc.PropertySets.Item("Design Tracking Properties")
        invUserProp = m_doc.PropertySets.Item("Inventor User Defined Properties")
        StandardButton.Enabled = True

        LoadMenus()
        InventorPropertyCheck()
        DisplayProperties()

    End Sub

    Private Sub LoadMenus()

        Try

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

            Me.engineerText.DataSource = MenuValueQuery("EGR")
            Me.engineerText.DisplayMember = "Description"
            Me.engineerText.ValueMember = "ID"

        Catch ex As Exception

            MsgBox("Unable to load menus. Error: " + ex.ToString)

        End Try

    End Sub

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

    Private Sub DisplayProperties()

        partNumberText.Text = invPartNumberProp.Value
        descriptionText.Text = invDescriptionProp.Value
        mfgNameText.Text = invMfgNameProp.Value
        engineerText.SelectedValue = invEngineerProp.Value
        salesOrT.Text = invStockNumberProp.Value
        engStatusSelect.SelectedValue = invEngStatusProp.Value
        invTypeSelect.SelectedValue = invInvTypeProp.Value
        extDesc1.Text = invExtDesc1Prop.Value
        extDesc2.Text = invExtDesc2Prop.Value
        extDesc3.Text = invExtDesc3Prop.Value
        extDesc4.Text = invExtDesc4Prop.Value
        extDesc5.Text = invExtDesc5Prop.Value
        salesCodeSelect.SelectedValue = invSalesCodeProp.Value
        uomSelect.SelectedValue = invUnitOfMeasProp.Value
        mfgPrtNumText.Text = invMfgPartNumberProp.Value

    End Sub

    Private Sub SaveLocalButton_Click() Handles SaveLocalButton.Click

        invDescriptionProp.Value = descriptionText.Text
        invMfgNameProp.Value = mfgNameText.Text
        invEngineerProp.Value = engineerText.SelectedValue
        invStockNumberProp.Value = salesOrT.Text
        invEngStatusProp.Value = engStatusSelect.SelectedValue
        invInvTypeProp.Value = invTypeSelect.SelectedValue
        invExtDesc1Prop.Value = extDesc1.Text
        invExtDesc2Prop.Value = extDesc2.Text
        invExtDesc3Prop.Value = extDesc3.Text
        invExtDesc4Prop.Value = extDesc4.Text
        invExtDesc5Prop.Value = extDesc5.Text
        invSalesCodeProp.Value = salesCodeSelect.SelectedValue
        invUnitOfMeasProp.Value = uomSelect.SelectedValue
        invMfgPartNumberProp.Value = mfgPrtNumText.Text

        m_doc.Save()
        Me.Close()

    End Sub

    Private Sub Manufactured_Click(sender As Object, e As EventArgs) Handles StandardButton.Click

        Me.uomSelect.SelectedValue = "EA"
        Me.engStatusSelect.SelectedValue = "S"
        Me.invTypeSelect.SelectedValue = "RA"

        invEngStatusProp.Value = Me.engStatusSelect.SelectedValue
        invInvTypeProp.Value = Me.invTypeSelect.SelectedValue
        invUnitOfMeasProp.Value = Me.uomSelect.SelectedValue

    End Sub

    Private Sub cButton_Click() Handles cButton.Click

        Me.Close()

    End Sub

End Class