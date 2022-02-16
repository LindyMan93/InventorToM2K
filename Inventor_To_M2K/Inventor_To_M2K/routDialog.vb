Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Data

''' <summary>
''' Opens a windows form to allow the user to enter routing information on the part or assembly.
''' This form has presets for the user to choose. None of the data that is created in this form
''' will be stored in the actual .ipt or .iam file. After the data has been created it must be 
''' uploaded to be saved. 
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class RoutDialog

    ' Get the active edit document. 
    Private m_doc As Inventor.Document = m_inventorApplication.ActiveEditDocument
    Dim prtNum As String

    Dim prtNumNull As Boolean
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
    Private Sub Add_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Button.Click

        Dim seqS As String = Me.seqSelect.Text
        Dim workC As String = Me.wsSelect.Text
        Dim crewS As String = Me.crewText.Text
        Dim laborS As String = Me.laborText.Text
        Dim descS As String = Me.descriptionText.Text

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

            Me.routTable.Rows.Add(seqS, workC, crewS, laborS, descS)

        End If

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
    ''' Handles the Click event of the Upload_Button control. This will push the user defined routing information
    ''' to the SQL database in the loop. Error checking is done in the sqlServ.vb
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Upload_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upload_Button.Click

        Dim seqNum As String
        Dim wcNum As String
        Dim laborTime As String
        Dim rDesc As String
        Dim crewS As String

        ' Runs through each row in the View and will get its value at each column
        ' Then it will push the information to SQL
        Dim row As Integer
        For row = 0 To Me.routTable.Rows.Count - 1

            seqNum = routTable.Item(0, row).Value
            wcNum = routTable.Item(1, row).Value
            crewS = routTable.Item(2, row).Value
            laborTime = routTable.Item(3, row).Value
            rDesc = routTable.Item(4, row).Value
            InsertRout(prtNum, seqNum, wcNum, laborTime, rDesc, crewS)

        Next

        ' Flips Boolean for routing pushed
        m_doc.PropertySets.Item("Inventor User Defined Properties").Item("routPushed").Value = True

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    ' Preset Buttons for highly used routing sequences
#Region "Presets"

    ''' <summary>
    ''' Handles the Click event of the crtButton control. This button is the "Cut", "Router", "Tap" button. 
    ''' It is adds predifined values to the routing to table, but still needs to be uploaded.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub crtButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crtButton.Click

        Me.routTable.Rows.Add("10", "150", "1", ".04", "Router Table")
        Me.routTable.Rows.Add("20", "150", "1", ".04", "Router Edges")
        Me.routTable.Rows.Add("30", "150", "1", ".04", "Tap Holes")

    End Sub

    ''' <summary>
    ''' Handles the Click event of the ccButton control. This button is the "Cut", "Router" 
    ''' (AKA Clear Cover Button) button. It is adds predifined values to the routing to table, but 
    ''' still needs to be uploaded.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ccButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ccButton.Click

        Me.routTable.Rows.Add("10", "150", "1", ".04", "Router Table")
        Me.routTable.Rows.Add("20", "150", "1", ".04", "Router Edges")

    End Sub

    ''' <summary>
    ''' Handles the Click event of the crbButton control. This button is the "Cut", "Router", "Bend" button. 
    ''' It is adds predifined values to the routing to table, but still needs to be uploaded.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub crbButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crbButton.Click

        Me.routTable.Rows.Add("10", "150", "1", ".04", "Router Table")
        Me.routTable.Rows.Add("20", "150", "1", ".04", "Router Edges")
        Me.routTable.Rows.Add("30", "70", "1", ".1", "Heat and Bend")

    End Sub

    ''' <summary>
    ''' Handles the Click event of the atpButton control. This button is a preset button that will create
    ''' a routing to assemble the part/assembly to the drawing specs.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub atpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atpButton.Click

        Me.routTable.Rows.Add("10", "70", "1", "1", "Assemble to print. Refer to drawing.")

    End Sub

#End Region

    ''' <summary>
    ''' Handles the Load event of the routDialog control. Loades the part number of active document.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub routDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim wcNums As List(Of String) = MenuItemQuery("WC")

            Me.wsSelect.DataSource = wcNums

            ' Initialize the values on the dialog using the current property values.
            Me.partNumberText.Text = m_doc.PropertySets.Item("Design Tracking Properties").Item("Part Number").Value
            prtNum = partNumberText.Text

            prtNumNull = partNumberText.Text.Equals("")
            seqNumNull = seqSelect.Text.Equals("")
            wcNumNull = wsSelect.Text.Equals("")
            laborNull = laborText.Text.Equals("")
            crewSizeNull = crewText.Text.Equals("")

            Me.Add_Button.Enabled = False
            Me.upload_Button.Enabled = False

        Catch ex As Exception
            MsgBox("Error Loading iProperties Information...")

        End Try

    End Sub

    ''' <summary>
    ''' Sends part number to sqlServ module to query SQL for information associated with this part.
    ''' It will then add this information to the table to show the user.
    ''' </summary>
    Private Sub UpdateButton_Click() Handles UpdateButton.Click

        Dim routData As DataSet = RoutQuery(prtNum)
        For Each row As DataRow In routData.Tables(0).Rows

            routTable.Rows.Add(row(0), row(1), row(2), row(3), row(4))

        Next

    End Sub

    ''' <summary>
    ''' These subs will fire when text has changed in the field associated with it.
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

        ActivateAdd()

    End Sub

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

#End Region

    ''' <summary>
    ''' Activates the add button if all fields have a valid input.
    ''' </summary>
    Private Sub ActivateAdd()

        If prtNumNull Or seqNumNull Or wcNumNull Or laborNull Or crewSizeNull Then

            Me.Add_Button.Enabled = False

        Else

            Me.Add_Button.Enabled = True

        End If

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

            Me.upload_Button.Enabled = True
            Me.ccButton.Enabled = False
            Me.crtButton.Enabled = False
            Me.crbButton.Enabled = False
            Me.UpdateButton.Enabled = False
            Me.atpButton.Enabled = False

        Else

            Me.upload_Button.Enabled = False
            Me.ccButton.Enabled = True
            Me.crtButton.Enabled = True
            Me.crbButton.Enabled = True
            Me.UpdateButton.Enabled = True
            Me.atpButton.Enabled = True

        End If

        ' Making sure the part has been saved and has information associated with it.
        If Me.partNumberText.Text = "" Then upload_Button.Enabled = False

    End Sub

    ''' <summary>
    ''' This sub will fire when a row is added. Runs Similar to DataTableRemoved
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DataTableAdded(sender As Object, e As EventArgs) Handles routTable.RowsAdded

        If routTable.Rows.Count > 0 Then

            Me.upload_Button.Enabled = True
            Me.ccButton.Enabled = False
            Me.crtButton.Enabled = False
            Me.crbButton.Enabled = False
            Me.UpdateButton.Enabled = False
            Me.atpButton.Enabled = False

        Else

            Me.upload_Button.Enabled = False
            Me.ccButton.Enabled = True
            Me.crtButton.Enabled = True
            Me.crbButton.Enabled = True
            Me.UpdateButton.Enabled = True
            Me.atpButton.Enabled = True

        End If

        ' Making sure the part has been save and ahs information associated with it.
        If Me.partNumberText.Text = "" Then upload_Button.Enabled = False

    End Sub

End Class
