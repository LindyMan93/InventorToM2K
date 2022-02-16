Imports System.Windows.Forms
Imports Inventor

''' <summary>
''' This Dialog will show when called by the assembly ribbon.
''' It will allow the user to insert hardware multiple times with
''' only a few button clicks
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class hardInsert

    Private WithEvents oInteraction As InteractionEvents
    Private WithEvents oSelect As SelectEvents
    Dim hwPart As ComponentOccurrence
    Dim hwDef As ComponentDefinition
    Dim hwPartDoc As PartDocument
    Dim hwEdge As Edge
    Dim hwEdgeTransKey As Integer
    Dim asmDoc As AssemblyDocument = m_inventorApplication.ActiveDocument
    Dim interKeyBoard As KeyboardEvents
    Dim userOffsetInput As Double

    ''' <summary>
    ''' Handles the Click event of the Select_Button control. This starts the interaction of choosing holes
    ''' to insert the hardware into.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Select_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectEdgesB.Click

        Me.selectHwEdge.Enabled = False
        Me.OK_Button.Enabled = True
        Me.offsetText.Enabled = True
        oInteraction.Start()

    End Sub

    ''' <summary>
    ''' Handles the Click event of the SelectHW_Button control. Allows the user to select the desired
    ''' edge of the piece of hardware that they want copied and inserted.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub SelectHW_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectHwEdge.Click

        Me.hwEdgesT.Text = "0"
        hwEdge = m_inventorApplication.CommandManager.Pick(SelectionFilterEnum.kPartEdgeCircularFilter, "Select hardware edge.")

        hwPart = hwEdge.Parent.Parent
        hwDef = hwPart.Definition
        hwPartDoc = hwDef.Document

        hwEdgeTransKey = hwEdge.TransientKey

        Me.hwEdgesT.Text = "1"
        Me.selectEdgesB.Enabled = True

    End Sub

    ''' <summary>
    ''' Handles the Click event of the OK_Button control. Finalizes the executiong of insert constraints desired.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If hwEdge Is Nothing Or oSelect.SelectedEntities.Count = 0 Then

            MsgBox("Must select hardware edge and 1 or more holes.")

        Else

            Dim addingMatrix As Matrix = m_inventorApplication.TransientGeometry.CreateMatrix

            For Each hole In oSelect.SelectedEntities
                Try

                    Dim addBoltOcc As ComponentOccurrence = asmDoc.ComponentDefinition.Occurrences.AddByComponentDefinition(hwDef, addingMatrix)
                    Dim boltEdge As Edge

                    Dim boltEdges As Edges = addBoltOcc.SurfaceBodies.Item(1).Edges

                    For Each edge As Edge In boltEdges

                        If edge.TransientKey.Equals(hwEdgeTransKey) Then

                            boltEdge = edge

                            ' here i can update the "True" to change the direction of the insert constraint.
                            asmDoc.ComponentDefinition.Constraints.AddInsertConstraint(hole, boltEdge, True, userOffsetInput.ToString)


                        End If

                    Next

                Catch ex As Exception

                    MsgBox("SHOW NATE THIS ERROR: " & ex.ToString)

                End Try

            Next

            hwPart.Delete()
            oInteraction.Stop()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        oInteraction.Stop()

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' When the user selectes a circular edge it will be added to the collection and the count will increment.
    ''' </summary>
    ''' <param name="JustSelectedEntities">The just selected entities.</param>
    ''' <param name="SelectionDevice">The selection device.</param>
    ''' <param name="ModelPosition">The model position.</param>
    ''' <param name="ViewPosition">The view position.</param>
    ''' <param name="View">The view.</param>
    Private Sub oSelectEvents_OnSelect(ByVal JustSelectedEntities As ObjectsEnumerator, ByVal SelectionDevice As SelectionDeviceEnum,
                                       ByVal ModelPosition As Point, ByVal ViewPosition As Point2d, ByVal View As Inventor.View) Handles oSelect.OnSelect

        oSelect.AddToSelectedEntities(JustSelectedEntities.Item(1))
        Me.holeEdgesT.Text = oSelect.SelectedEntities.Count

    End Sub

    Private Sub offsetText_OnChange() Handles offsetText.TextChanged

        Try

            userOffsetInput = Convert.ToDecimal(offsetText.Text)
            OK_Button.Enabled = True

        Catch ex As Exception

            OK_Button.Enabled = False

        End Try


    End Sub

    Private Sub offsetText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles offsetText.KeyDown

        If Not IsNumeric(Chr(e.KeyCode)) _
            And Not e.KeyCode = Keys.Back _
            And Not e.KeyCode = Keys.Delete _
            And Not e.KeyCode = Keys.OemPeriod _
            And Not e.KeyCode = Keys.Decimal _
            And Not e.KeyCode = Keys.Subtract _
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
    ''' Handles the hardInsert event of the Load control. Creates selection events to allow user to pick circular edges.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Load_hardInsert(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        offsetText.Text = 0.00
        oInteraction = m_inventorApplication.CommandManager.CreateInteractionEvents
        oInteraction.InteractionDisabled = False
        interKeyBoard = oInteraction.KeyboardEvents()

        oSelect = oInteraction.SelectEvents
        oSelect.AddSelectionFilter(SelectionFilterEnum.kPartEdgeCircularFilter)
        oSelect.SingleSelectEnabled = False
        oSelect.WindowSelectEnabled = True

        Me.offsetText.Enabled = False
        Me.selectEdgesB.Enabled = False
        Me.OK_Button.Enabled = False

    End Sub

End Class
