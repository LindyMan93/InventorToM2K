Imports System.Data
Imports System.Windows.Forms

Public Class AllInfoForm

    ''' <summary>
    ''' Handles the Form event of the Load control. This will query the data from the SQL
    ''' Database. It provides the information that is currently in the SQL to the user.
    ''' Can be used as a check or a reference.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Load_Form(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim m_doc As Inventor.Document = m_inventorApplication.ActiveEditDocument
        Dim prtNum As String = m_doc.PropertySets.Item("Design Tracking Properties").Item("Part Number").Value
        Me.partNumberText.Text = prtNum

        Dim sDesc As String = IMQuery(prtNum, "Description")
        Dim invType As String = IMQuery(prtNum, "InventoryType")
        Dim extDesc As String = IMQuery(prtNum, "ExtDesc")
        Dim uom As String = IMQuery(prtNum, "Um")
        Dim engStat As String = IMQuery(prtNum, "EngineeringStatus")
        Dim salesCode As String = IMQuery(prtNum, "SalesCode")
        Dim ltCode As String = IMQuery(prtNum, "LeadTimeCode")
        Dim engr As String = IMQuery(prtNum, "EngrResp")
        Dim mfgName As String = IMQuery(prtNum, "MfgName")
        Dim mfgNum As String = IMQuery(prtNum, "MfgItemNbr")

        Me.sDescriptionText.Text = sDesc
        Me.invTypeText.Text = invType
        Me.descriptionText.Text = extDesc
        Me.uomText.Text = uom
        Me.engStatText.Text = engStat
        Me.salesCodeText.Text = salesCode
        Me.ltCodeText.Text = ltCode
        Me.engText.Text = engr
        Me.mfgNameText.Text = mfgName
        Me.mfgPrtNumText.Text = mfgNum


        Dim bomData As DataSet = BOMQuery(prtNum)
        Dim routData As DataSet = RoutQuery(prtNum)

        Me.bomTable.DataSource = bomData.Tables("BOM").DefaultView
        Me.routTable.DataSource = routData.Tables("ROUTING").DefaultView

    End Sub

End Class
