Imports System.Data
Imports System.Windows.Forms

''' <summary>
''' For Developer only...
''' 
''' It will get all data currently stored in the SQL database if the password has been entered correctly.
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class GetAllInfoForm

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    ''' <summary>
    ''' Prompts user for password, if correct will update the tables with the current information.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub updateB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateB.Click

        Dim password As String = InputBox("Enter Password", "Password Check", "")

        If password = "NRLboss1" Then

            Dim imData As DataSet = CollectData("IM")
            Dim bomData As DataSet = CollectData("BOM")
            Dim routData As DataSet = CollectData("ROUTING")

            Me.imTable.DataSource = imData.Tables("IM").DefaultView
            Me.bomTable.DataSource = bomData.Tables("BOM").DefaultView
            Me.routTable.DataSource = routData.Tables("ROUTING").DefaultView

        Else

            MsgBox("You didn't say the magic word... Ahh... ahh... ahhh")

        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
