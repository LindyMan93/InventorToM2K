Imports System.Windows.Forms
Imports Inventor

''' <summary>
''' Runs Import Part, Import BOM, and Import Rout for a part that has been selected.
''' Has some error checking, but I'm not sure I want to use this. It is currently not
''' being used in the software. (6/16/2017)
''' </summary>
Module CloseConveyorMod

    ''' <summary>
    ''' Runs through each form to make sure the user has entered the information regarding
    ''' the custom part.
    ''' </summary>
    ''' <param name="fullPartName">Full name of the part.</param>
    Public Sub CloseConveyor(fullPartName As String)

        m_inventorApplication.Documents.Open(fullPartName)
        Dim currentDoc As Document = m_inventorApplication.ActiveDocument

        Dim partInfo As PartInfoDialog
        partInfo = New PartInfoDialog

        Dim bomInfo As PartMaterialDialog
        bomInfo = New PartMaterialDialog

        Dim routInfo As RoutDialog
        routInfo = New RoutDialog

        ' Checks to see if there has been information pushed into SQL for IM
        If Not currentDoc.PropertySets("Inventor User Defined Properties").Item("imPushed").Value Then

            partInfo.Cancel_Button.Enabled = False
            partInfo.Save_Button.Enabled = False
            partInfo.ControlBox = False
            partInfo.ShowDialog()

            While Not partInfo.DialogResult = DialogResult.OK

            End While

        Else

            Dim updateIM = MsgBox("Would you like to update the Part Master information?", MsgBoxStyle.YesNo, "Update?")

            If updateIM = MsgBoxResult.Yes Then



                partInfo.Cancel_Button.Enabled = False
                partInfo.Save_Button.Enabled = False
                partInfo.ControlBox = False
                partInfo.ShowDialog()

                While Not partInfo.DialogResult = DialogResult.OK

                End While

            End If

        End If

        If Not currentDoc.PropertySets("Inventor User Defined Properties").Item("leadTimeCode").Value = "P" Then

            If Not currentDoc.PropertySets("Inventor User Defined Properties").Item("bomPushed").Value Then



                bomInfo.Cancel_Button.Enabled = False
                bomInfo.ControlBox = False
                bomInfo.ShowDialog()

                While Not bomInfo.DialogResult = DialogResult.OK

                End While

            Else

                Dim updateBOM = MsgBox("Would you like to update the BOM information?", MsgBoxStyle.YesNo, "Update?")

                If updateBOM = MsgBoxResult.Yes Then



                    bomInfo.Cancel_Button.Enabled = False
                    bomInfo.ControlBox = False
                    bomInfo.ShowDialog()

                    While Not bomInfo.DialogResult = DialogResult.OK

                    End While
                    bomInfo.Close()

                End If

            End If

            If Not currentDoc.PropertySets("Inventor User Defined Properties").Item("routPushed").Value Then



                routInfo.Cancel_Button.Enabled = False
                routInfo.ControlBox = False
                routInfo.ShowDialog()

                While Not routInfo.DialogResult = DialogResult.OK

                End While

            Else

                Dim updateROUT = MsgBox("Would you like to update the Routing information?", MsgBoxStyle.YesNo, "Update?")

                If updateROUT = MsgBoxResult.Yes Then



                    routInfo.Cancel_Button.Enabled = False
                    routInfo.ControlBox = False
                    routInfo.ShowDialog()

                    While Not routInfo.DialogResult = DialogResult.OK

                    End While

                End If

            End If

        End If

        currentDoc.Save()
        currentDoc.Close()

    End Sub

End Module
