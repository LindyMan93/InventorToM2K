Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic

''' <summary>
''' All SQL information and methods are within this Module.
''' Centralizes all methods that use the SQL database. 
''' </summary>
Module sqlServ

    ' SQL server connection.
    Dim myConn As New SqlConnection("Server=DCC-VSSQL01;Database=InventorToM2K;Trusted_connection=yes;")

    ' Generic SqlCommand for queries
    Dim myCmd As SqlCommand

    ' Each SqlCommand is made to insert, remove, or update
    ' Added these to stop SQL injection and handle quotes
    Dim IMCmd As SqlCommand
    Dim ExtCmd As SqlCommand
    Dim BOMCmd As SqlCommand
    Dim RemoveBOMCmd As SqlCommand
    Dim RoutCmd As SqlCommand
    Dim RemoveRoutCmd As SqlCommand

    Dim myReader As SqlDataReader
    Dim results As String

#Region "Old Database communcations"

#Region "IM"

    ''' <summary>
    ''' The values passed to this will but put into a SQL Insert statement. Tries to insert part.
    ''' If the database shoots back a "Primary Key Violation" (Number 2627), then it will prompt the user
    ''' yes or no on whether they want to update this information. If yes, it will delete the record from 
    ''' the database and insert the updated information recursively.
    ''' </summary>
    ''' <param name="prtNum">The part number.</param>
    ''' <param name="sDesc">The short description.</param>
    ''' <param name="invType">Inventory type.</param>
    ''' <param name="lDesc">The long description (Extended).</param>
    ''' <param name="unOfMeas">The unit of measure.</param>
    ''' <param name="engStat">The engineering status.</param>
    ''' <param name="salesC">The sales code.</param>
    ''' <param name="lTime">The lead time code.</param>
    ''' <param name="engr">The engineer/designer.</param>
    ''' <param name="mfgName">Name of the manufacturer.</param>
    ''' <param name="mfgNum">The manufacturer number.</param>
    Public Sub InsertPM(prtNum As String, sDesc As String, invType As String, lDesc As String, unOfMeas As String,
                        engStat As String, salesC As String, lTime As String, engr As String, mfgName As String, mfgNum As String)

        ' Trying to push information
        Try

            myCmd = New SqlCommand("INSERT INTO IM (PartNbr, Description, InventoryType, ExtDesc, Um, EngineeringStatus, SalesCode, LeadTimeCode, EngrResp, MfgName, MfgItemNbr) VALUES ('" _
                & prtNum & "', '" _
                & sDesc & "', '" _
                & invType & "', '" _
                & lDesc & "', '" _
                & unOfMeas & "', '" _
                & engStat & "', '" _
                & salesC & "', '" _
                & lTime & "', '" _
                & engr & "', '" _
                & mfgName & "', '" _
                & mfgNum & "')", myConn)

            myConn.Open()
            myCmd.ExecuteNonQuery()
            myConn.Close()

        Catch ex As SqlException

            myConn.Close()

            If ex.Number = 2627 Then

                Dim update As MsgBoxResult = MsgBox("Would you like to update this part information?", MsgBoxStyle.YesNo, "Update Info?")

                If update = vbYes Then
                    myCmd = New SqlCommand("UPDATE IM SET Description = " & "'" & sDesc & "', " _
                        & "InventoryType = '" & invType & "', " _
                        & "ExtDesc = '" & lDesc & "', " _
                        & "Um = '" & unOfMeas & "', " _
                        & "EngineeringStatus = '" & engStat & "', " _
                        & "SalesCode = '" & salesC & "', " _
                        & "LeadTimeCode = '" & lTime & "', " _
                        & "EngrResp = '" & engr & "', " _
                        & "MfgName = '" & mfgName & "', " _
                        & "MfgItemNbr = '" & mfgNum & "' " _
                        & "WHERE PartNbr = '" & prtNum & "';", myConn)

                    myConn.Open()
                    myCmd.ExecuteNonQuery()
                    myConn.Close()

                    ' InsertPM(prtNum, sDesc, invType, lDesc, unOfMeas, engStat, salesC, lTime, engr, mfgName, mfgNum)

                End If

            Else

                MsgBox("Unable to push part information into SQL database. Error: " & ex.ToString)

            End If

            myConn.Close()

        End Try

        myConn.Close()

    End Sub

    Public Function IMQuery(partNbr As String, field As String) As String

        Dim result As String = ""
        If myConn.State = ConnectionState.Open Then

            myConn.Close()

        End If

        Try

            myCmd = New SqlCommand("SELECT " & field & " FROM IM WHERE PartNbr = '" & partNbr & "'", myConn)
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            While myReader.Read

                result = myReader(0).ToString

            End While

            myReader.Close()
            myConn.Close()

        Catch ex As SqlException

            myConn.Close()
            MsgBox("Collecting Information Error: " & ex.ToString)

        End Try

        Return result

    End Function

#End Region

#Region "BOM"

    ''' <summary>
    ''' The values passed into this will be put into a SQL insert statement and added to the SQL
    ''' database.
    ''' </summary>
    ''' <param name="prtNumP">The parent part number.</param>
    ''' <param name="prtNumC">The child part number.</param>
    ''' <param name="prtCqty">The child part quantity.</param>
    Public Sub InsertBOM(prtNumP As String, prtNumC As String, prtCqty As String)

        Try

            myCmd = New SqlCommand("INSERT INTO BOM (ParentPart, ComponentPart, QtyPerAssy) VALUES ('" _
                    & prtNumP & "', '" _
                    & prtNumC & "', '" _
                    & prtCqty & "')", myConn)

            myConn.Open()
            myCmd.ExecuteNonQuery()
            myConn.Close()

        Catch ex As SqlException

            myConn.Close()

            If ex.Number = 2627 Then

                Dim updateAllS As String = "There is already information associated with Part Number: " _
                    & prtNumP & ". Would you like to remove all information and add new information?"
                Dim updateAll As MsgBoxResult = MsgBox(updateAllS, MsgBoxStyle.YesNo, "Update All Info?")

                If updateAll = vbYes Then

                    myCmd = New SqlCommand("DELETE FROM BOM WHERE ParentPart = '" & prtNumP & "'", myConn)

                    myConn.Open()
                    myCmd.ExecuteNonQuery()
                    myConn.Close()

                    InsertBOM(prtNumP, prtNumC, prtCqty)
                    MsgBox("Information for this part's complete BOM has been deleted and resubmitted.")

                Else

                    Dim upString As String = "Part Number: " & prtNumP & " already has Component Part Number: " _
                    & prtNumC & " in its bill of materials. Would you like to update this information?"

                    Dim update As MsgBoxResult = MsgBox(upString, MsgBoxStyle.YesNo, "Update Info?")

                    If update = vbYes Then

                        myCmd = New SqlCommand("DELETE FROM BOM WHERE ParentPart = '" & prtNumP & "' " _
                                               & "AND ComponentPart = '" & prtNumC & "'", myConn)

                        myConn.Open()
                        myCmd.ExecuteNonQuery()
                        myConn.Close()

                        InsertBOM(prtNumP, prtNumC, prtCqty)
                        MsgBox("Information for individual part in assembly was deleted, then resubmitted.")

                    Else

                        MsgBox("Information was not updated. Please inform Nathan Lindenbaum of this error.")

                    End If

                End If



            Else

                MsgBox("Unable to push part information into SQL database. Error: " & ex.ToString)

            End If

            myConn.Close()

        End Try

        myConn.Close()

    End Sub

    ''' <summary>
    ''' Doesnt really remove the material. It actually puts in a 
    ''' zero value for comp part in parent part the material.
    ''' </summary>
    ''' <param name="prtNumP">The PRT number p.</param>
    Public Sub RemoveMaterial(prtNumP As String)

        Dim tDate As String = Today.ToString("MM-dd-yy")
        myCmd = New SqlCommand("DELETE FROM BOM WHERE ParentPart = '" & prtNumP & "'", myConn)
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()

    End Sub

    Public Function BOMQuery(partNbr As String) As DataSet

        Dim resultTable As DataSet = New DataSet

        Try

            Dim queryCom As String = "SELECT ComponentPart, QtyPerAssy FROM BOM WHERE ParentPart = '" & partNbr & "'"

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryCom, myConn)

            adapter.Fill(resultTable, "BOM")

            myConn.Close()

        Catch ex As Exception

            myConn.Close()
            MsgBox(ex.ToString)

        End Try

        Return resultTable

    End Function

#End Region

#Region "ROUT"

    ''' <summary>
    ''' The values passed in will be sent to the SQL database via a SQL insert statement.
    ''' </summary>
    ''' <param name="prtNum">The PRT number.</param>
    ''' <param name="seqNum">The seq number.</param>
    ''' <param name="wcNum">The wc number.</param>
    ''' <param name="laborTime">The labor time.</param>
    ''' <param name="rDesc">The r desc.</param>
    ''' <param name="crewS">The crew s.</param>
    Public Sub InsertRout(prtNum As String, seqNum As String, wcNum As String, laborTime As String, rDesc As String, crewS As String)

        Try

            myCmd = New SqlCommand("INSERT INTO ROUTING (PartNbr, SeqNbr, Wc_Nbr, PlanRunLbrTime, Remarks, CrewSize) VALUES ('" _
                    & prtNum & "', '" _
                    & seqNum & "', '" _
                    & wcNum & "', '" _
                    & laborTime & "', '" _
                    & rDesc & "', '" _
                    & crewS & "')", myConn)

            myConn.Open()
            myCmd.ExecuteNonQuery()
            myConn.Close()

        Catch ex As SqlException

            myConn.Close()

            If ex.Number = 2627 Then

                Dim updateAllS As String = "There is already information associated with Part Number: " _
                    & prtNum & ". Would you like to remove all information and add new information?"
                Dim updateAll As MsgBoxResult = MsgBox(updateAllS, MsgBoxStyle.YesNo, "Update All Info?")

                If updateAll = vbYes Then

                    myCmd = New SqlCommand("DELETE FROM ROUTING WHERE PartNbr = '" & prtNum & "'", myConn)

                    myConn.Open()
                    myCmd.ExecuteNonQuery()
                    myConn.Close()

                    InsertRout(prtNum, seqNum, wcNum, laborTime, rDesc, crewS)
                    MsgBox("Information for this part's routing has been deleted and resubmitted.")

                Else

                    Dim upString As String = "Part Number: " & prtNum & " already has sequence Number: " _
                    & seqNum & " in its routing. Would you like to update this information?"

                    Dim update As MsgBoxResult = MsgBox(upString, MsgBoxStyle.YesNo, "Update Info?")

                    If update = vbYes Then

                        myCmd = New SqlCommand("DELETE FROM ROUTING WHERE PartNbr = '" & prtNum & "' " _
                                               & "AND SeqNbr = '" & seqNum & "'", myConn)

                        myConn.Open()
                        myCmd.ExecuteNonQuery()
                        myConn.Close()

                        InsertRout(prtNum, seqNum, wcNum, laborTime, rDesc, crewS)
                        MsgBox("Information was deleted, then resubmitted.")

                    Else

                        MsgBox("Information was not updated. Please inform Nathan Lindenbaum of this error.")

                    End If

                End If

            Else

                MsgBox("Unable to push part information into SQL database. Error: " & ex.ToString)

            End If

            myConn.Close()

        End Try

        myConn.Close()

    End Sub

    Public Sub RemoveSelectedRout(prtNum As String, seq As String)

        myCmd = New SqlCommand("DELETE FROM ROUTING WHERE PartNbr = '" & prtNum & "' " & "AND SeqNbr = '" & seq & "'", myConn)
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()

    End Sub

    Public Function RoutQuery(partNbr As String) As DataSet

        Dim resultTable As DataSet = New DataSet

        Try

            Dim queryCom As String = "SELECT SeqNbr, Wc_Nbr, CrewSize, PlanRunLbrTime, Remarks FROM ROUTING WHERE PartNbr = '" & partNbr & "'"

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryCom, myConn)

            adapter.Fill(resultTable, "ROUTING")

            myConn.Close()

        Catch ex As Exception

            myConn.Close()
            MsgBox(ex.ToString)

        End Try

        Return resultTable

    End Function

#End Region


#End Region

#Region "Current Database Communications"

#Region "IM"

    ''' <summary>
    ''' Inserts the IM Data into Table IM3 of Inventor To M2k Database.
    ''' 
    ''' UPDATE: changing SQL commands to stop SQL injection and 
    ''' hopefully handling " and ' within text.
    ''' </summary>
    ''' <param name="PartNumber">The part number.</param>
    ''' <param name="Description">The description.</param>
    ''' <param name="InventoryType">Type of the inventory.</param>
    ''' <param name="Um">The um.</param>
    ''' <param name="EngineeringStatus">The engineering status.</param>
    ''' <param name="SalesCode">The sales code.</param>
    ''' <param name="LeadTimeCode">The lead time code.</param>
    ''' <param name="EngrResp">The engr resp.</param>
    Public Sub InsertIM(PartNumber As String, Description As String,
                        InventoryType As String, Um As String,
                        EngineeringStatus As String, SalesCode As String,
                        LeadTimeCode As String, EngrResp As String)

        Dim sqlCols As String
        sqlCols = "(PartNbr, Description, InventoryType, Um, EngineeringStatus, SalesCode, LeadTimeCode, EngrResp)"
        IMCmd = New SqlCommand()

        Try

            ' Replace single quotes with double just for MSSQL
            ' Description = Description.Replace("'", "''")

            myConn.Open()
            IMCmd.Connection = myConn
            IMCmd.CommandText = "INSERT INTO ItemMaster" & sqlCols & " VALUES (@Part_Number, 
                                                                               @Short_Description, 
                                                                               @Inventory_Type,
                                                                               @Unit_Of_Measure, 
                                                                               @Engineering_Status, 
                                                                               @Sales_Code, 
                                                                               @Lead_Time_Code, 
                                                                               @Engineer_Responsible)"

            IMCmd.Parameters.Add("@Part_Number", SqlDbType.VarChar, 19).Value = PartNumber
            IMCmd.Parameters.Add("@Short_Description", SqlDbType.VarChar, 25).Value = Description
            IMCmd.Parameters.Add("@Inventory_Type", SqlDbType.VarChar, 2).Value = InventoryType
            IMCmd.Parameters.Add("@Unit_Of_Measure", SqlDbType.VarChar, 2).Value = Um
            IMCmd.Parameters.Add("@Engineering_Status", SqlDbType.VarChar, 1).Value = EngineeringStatus
            IMCmd.Parameters.Add("@Sales_Code", SqlDbType.VarChar, 8).Value = SalesCode
            IMCmd.Parameters.Add("@Lead_Time_Code", SqlDbType.VarChar, 2).Value = LeadTimeCode
            IMCmd.Parameters.Add("@Engineer_Responsible", SqlDbType.VarChar, 5).Value = EngrResp

            IMCmd.ExecuteNonQuery()

        Catch ex As SqlException

            ' Primary Key exception
            If ex.Number = 2627 Then

                Dim update As MsgBoxResult = MsgBox("Would you like to update this part information?", MsgBoxStyle.YesNo, "Update Info?")

                If update = vbYes Then
                    IMCmd.CommandText = "UPDATE ItemMaster SET Description = @Short_Description, 
                                                               InventoryType = @Inventory_Type, 
                                                               Um = @Unit_Of_Measure, 
                                                               EngineeringStatus = @Engineering_Status,
                                                               SalesCode = @Sales_Code, 
                                                               LeadTimeCode = @Lead_Time_Code, 
                                                               EngrResp = @Engineer_Responsible
                                                               WHERE PartNbr = @Part_Number;"

                    IMCmd.ExecuteNonQuery()

                End If

            Else

                MsgBox("Unable to push part information into SQL database. Error: " & ex.ToString)

            End If

        Finally

            myConn.Close()

        End Try

    End Sub


    ''' <summary>
    ''' Inserts the ext desc.
    ''' 
    ''' 
    ''' </summary>
    ''' <param name="PartNumber">The part number.</param>
    ''' <param name="ExtDesc">The ext desc.</param>
    Public Sub InsertExtDesc(PartNumber As String, ExtDesc As List(Of String))

        Dim update As MsgBoxResult
        Dim sqlCols As String
        sqlCols = "(PartNbr, DesPos, ExtDesc)"
        Dim DesPos As Integer = 0
        Dim CurrentExtDesc As String = ""

        For Each line In ExtDesc

            ExtCmd = New SqlCommand()

            Try

                myConn.Open()
                ExtCmd.Connection = myConn
                CurrentExtDesc = line
                DesPos = DesPos + 1

                ' Checking if there is a value there.
                If Not line.Equals("") Then

                    ExtCmd.CommandText = "INSERT INTO ExtDesc " & sqlCols & " VALUES (@Part_Number, 
                                                                                      @Description_Position, 
                                                                                      @Line)"

                    ExtCmd.Parameters.Add("@Part_Number", SqlDbType.VarChar, 19).Value = PartNumber
                    ExtCmd.Parameters.Add("@Description_Position", SqlDbType.VarChar, 65).Value = DesPos
                    ExtCmd.Parameters.Add("@Line", SqlDbType.VarChar, 65).Value = line

                    ExtCmd.ExecuteNonQuery()

                End If

            Catch ex As SqlException

                ' Primary Key exception
                If ex.Number = 2627 Then
                    If DesPos = 1 Then

                        update = MsgBox("Would you like to update this part description?", MsgBoxStyle.YesNo, "Update Info?")

                    End If

                    If update = vbYes Then

                        ExtCmd.CommandText = "UPDATE ExtDesc SET ExtDesc = @Line WHERE PartNbr = @Part_Number AND DesPos = @Description_Position;"
                        ExtCmd.ExecuteNonQuery()

                    End If

                Else

                    MsgBox("Unable to push part information into SQL database. Error: " & ex.ToString)

                End If

            Finally
                myConn.Close()
            End Try

        Next

    End Sub

    ''' <summary>
    ''' Selects and returns the information requested by field and part number.
    ''' </summary>
    ''' <param name="partNbr">The part NBR.</param>
    ''' <param name="field">The field.</param>
    ''' <returns></returns>
    Public Function IMQuery2(partNbr As String, field As String) As String

        Dim result As String = ""
        If myConn.State = ConnectionState.Open Then

            myConn.Close()

        End If

        Try

            myCmd = New SqlCommand("SELECT " & field & " FROM ItemMaster WHERE PartNbr = '" & partNbr & "'", myConn)
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            While myReader.Read

                result = myReader(0).ToString

            End While

            myReader.Close()
            myConn.Close()

        Catch ex As SqlException

            myConn.Close()
            MsgBox(partNbr & " " & field & " " & ex.ToString)

        End Try

        Return result

    End Function

    Public Function ExtDescQuery(partNbr As String, DesPos As String) As String

        Dim result As String = ""
        If myConn.State = ConnectionState.Open Then

            myConn.Close()

        End If

        Try

            myCmd = New SqlCommand("SELECT ExtDesc FROM ExtDesc WHERE PartNbr = '" & partNbr & "' AND DesPos = '" & DesPos & "'", myConn)
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            While myReader.Read

                result = myReader(0).ToString

            End While

            myReader.Close()
            myConn.Close()

        Catch ex As SqlException

            myConn.Close()
            MsgBox("Collecting Information Error: " & ex.ToString)

        End Try

        Return result

    End Function

#End Region

#Region "BOM"

    ''' <summary>
    ''' The values passed into this will be put into a SQL insert statement and added to the SQL
    ''' database.
    ''' </summary>
    ''' <param name="prtNumP">The parent part number.</param>
    ''' <param name="prtNumC">The child part number.</param>
    ''' <param name="prtCqty">The child part quantity.</param>
    Public Sub InsertBOM2(prtNumP As String, prtNumC As String, prtCqty As String)

        Dim tDate As String = Today.ToString("MM-dd-yy")
        BOMCmd = New SqlCommand()

        Try

            myConn.Open()
            BOMCmd.Connection = myConn
            BOMCmd.CommandText = "INSERT INTO BOM2 (ParentPart, ComponentPart, QtyPerAssy, DateEffective) VALUES (@Parent_Part,
                                                                                                                  @Component_Part, 
                                                                                                                  @Quantity, 
                                                                                                                  @Date_Effective)"

            BOMCmd.Parameters.Add("@Parent_Part", SqlDbType.VarChar, 19).Value = prtNumP
            BOMCmd.Parameters.Add("@Component_Part", SqlDbType.VarChar, 19).Value = prtNumC
            BOMCmd.Parameters.Add("@Quantity", SqlDbType.VarChar, 8).Value = prtCqty
            BOMCmd.Parameters.Add("@Date_Effective", SqlDbType.VarChar, 12).Value = tDate

            BOMCmd.ExecuteNonQuery()

        Catch ex As SqlException

            If ex.Number = 547 Then

                MsgBox(prtNumC & " does not exist in Manage 2000, Please check the name and make sure it has been created.")

            ElseIf ex.Number = 2627 Then

                Dim updateAllS As String = prtNumP & " already has " & prtNumC & " in its bill. " _
                    & "Would you like to update its quantity?"
                Dim updateAll As MsgBoxResult = MsgBox(updateAllS, MsgBoxStyle.YesNo, "Update All Info?")

                If updateAll = vbYes Then

                    BOMCmd.CommandText = "UPDATE BOM2 SET QtyPerAssy = @Quantity,
                                                          DateEffective = @Date_Effective
                                                          WHERE ParentPart = @Parent_Part AND ComponentPart = @Component_Part;"

                    BOMCmd.ExecuteNonQuery()

                Else
                    MsgBox("Information was not updated. Please inform Nathan Lindenbaum of this error.")
                End If
            Else
                MsgBox("Unable to push part information into SQL database. Error: " & ex.ToString)
            End If

        Finally
            myConn.Close()
        End Try

    End Sub

    ''' <summary>
    ''' Removes the selected bill from BOM2, by changing the component part qty to 0.
    ''' </summary>
    ''' <param name="prtNumP">The PRT number p.</param>
    ''' <param name="prtNumC">The PRT number c.</param>
    Public Sub RemoveSelectedBill(prtNumP As String, prtNumC As String)

        Dim tDate As String = Today.ToString("MM-dd-yy")
        RemoveBOMCmd = New SqlCommand()

        Try

            myConn.Open()
            RemoveBOMCmd.Connection = myConn
            RemoveBOMCmd.CommandText = "UPDATE BOM2 SET QtyPerAssy = '0', DateEffective = @Date_Effective
                                                                      WHERE ParentPart = @Parent_Part AND ComponentPart = @Component_Part;"

            RemoveBOMCmd.Parameters.Add("@Parent_Part", SqlDbType.VarChar, 19).Value = prtNumP
            RemoveBOMCmd.Parameters.Add("@Component_Part", SqlDbType.VarChar, 19).Value = prtNumC
            RemoveBOMCmd.Parameters.Add("@Date_Effective", SqlDbType.VarChar, 12).Value = tDate

            RemoveBOMCmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(ex.ToString)

        Finally
            myConn.Close()
        End Try

    End Sub

    ''' <summary>
    ''' Returns a table of all the parts within a bill of materials in the SQL database.
    ''' (BOM2 table)
    ''' </summary>
    ''' <param name="partNbr">The part NBR.</param>
    ''' <returns></returns>
    Public Function BOMQuery2(partNbr As String) As DataSet

        Dim resultTable As DataSet = New DataSet

        Try

            Dim queryCom As String = "SELECT ComponentPart, QtyPerAssy FROM BOM2 WHERE ParentPart = '" & partNbr & "'"

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryCom, myConn)

            adapter.Fill(resultTable, "BOM2")

            myConn.Close()

        Catch ex As Exception

            myConn.Close()
            MsgBox(ex.ToString)

        End Try

        Return resultTable

    End Function

#End Region

#Region "ROUT"

    ''' <summary>
    ''' The values passed in will be sent to the SQL database via a SQL insert statement.
    ''' </summary>
    ''' <param name="prtNum">The PRT number.</param>
    ''' <param name="seqNum">The seq number.</param>
    ''' <param name="wcNum">The wc number.</param>
    ''' <param name="laborTime">The labor time.</param>
    ''' <param name="rDesc">The r desc.</param>
    ''' <param name="crewS">The crew s.</param>
    Public Sub InsertRout2(prtNum As String, seqNum As String, wcNum As String, laborTime As String, rDesc As String, crewS As String)

        RoutCmd = New SqlCommand()

        Try

            myConn.Open()
            RoutCmd.Connection = myConn
            RoutCmd.CommandText = "INSERT INTO ROUTING2 (PartNbr, SeqNbr, WcNbr, PlanRunLbrTime, Remarks, CrewSize) VALUES (@Part_Number, 
                                                                                                                            @Sequence,
                                                                                                                            @Work_Center, 
                                                                                                                            @Labor_Time, 
                                                                                                                            @Remarks, 
                                                                                                                            @Crew_Size);"
            RoutCmd.Parameters.Add("@Part_Number", SqlDbType.VarChar, 19).Value = prtNum
            RoutCmd.Parameters.Add("@Sequence", SqlDbType.VarChar, 4).Value = seqNum
            RoutCmd.Parameters.Add("@Work_Center", SqlDbType.VarChar, 6).Value = wcNum
            RoutCmd.Parameters.Add("@Labor_Time", SqlDbType.NVarChar, 100).Value = laborTime
            RoutCmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = rDesc
            RoutCmd.Parameters.Add("@Crew_Size", SqlDbType.Int).Value = crewS


            RoutCmd.ExecuteNonQuery()


        Catch ex As SqlException

            MsgBox("Unable to push part information into SQL database. Error: " & ex.ToString)

        Finally

            myConn.Close()

        End Try

    End Sub

    Public Sub RemoveSelectedRout2(prtNum As String, seq As String)

        RemoveRoutCmd = New SqlCommand()

        Try
            myConn.Open()
            RemoveRoutCmd.Connection = myConn
            RemoveRoutCmd.CommandText = "UPDATE ROUTING2 SET PlanRunLbrTime = '0' WHERE PartNbr = @Part_Number AND SeqNbr = @Sequence;"
            RemoveRoutCmd.Parameters.Add("@Part_Number", SqlDbType.VarChar, 19).Value = prtNum
            RemoveRoutCmd.Parameters.Add("@Sequence", SqlDbType.VarChar, 4).Value = seq

            RemoveRoutCmd.ExecuteNonQuery()

        Catch ex As SqlException

            MsgBox("Unable to remove routing. Error: " & ex.ToString)

        Finally

            myConn.Close()

        End Try


    End Sub

    Public Function RoutQuery2(partNbr As String) As DataSet

        Dim resultTable As DataSet = New DataSet

        Try

            Dim queryCom As String = "SELECT SeqNbr, WcNbr, CrewSize, PlanRunLbrTime, Remarks FROM ROUTING2 WHERE PartNbr = '" & partNbr & "'"

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryCom, myConn)

            adapter.Fill(resultTable, "ROUTING2")

            myConn.Close()

        Catch ex As Exception

            myConn.Close()
            MsgBox(ex.ToString)

        End Try

        Return resultTable

    End Function

#End Region

#End Region

#Region "Queries"

    ''' <summary>
    ''' Queries SQL for desired information. 
    ''' </summary>
    ''' <param name="table"></param>
    ''' <returns></returns>
    Public Function CollectData(table As String) As DataSet

        Dim resultTable As DataSet = New DataSet

        Try

            Dim queryCom As String = "SELECT * FROM " & table

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryCom, myConn)

            adapter.Fill(resultTable, table)

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

        Return resultTable

    End Function

    Public Function MenuItemQuery(table As String) As List(Of String)

        Dim dropDownIDs As New List(Of String)

        Try

            myCmd = New SqlCommand("Select ID FROM " & table, myConn)
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            While myReader.Read

                dropDownIDs.Add(myReader(0).ToString)

            End While

            myConn.Close()



        Catch ex As Exception

            myConn.Close()
            MsgBox(ex.ToString)
            dropDownIDs.Add("Unable to gather information.")

        End Try

        Return dropDownIDs

    End Function

    Public Function MenuValueQuery(table As String) As ICollection

        Dim dropDownTable As New DataTable()
        dropDownTable.Columns.Add(New DataColumn("ID", GetType(String)))
        dropDownTable.Columns.Add(New DataColumn("Description", GetType(String)))

        Dim ID As String
        Dim Description As String
        Dim dropDownView As DataView

        Try

            myCmd = New SqlCommand("Select ID, DESCR FROM " & table, myConn)
            myConn.Open()
            myReader = myCmd.ExecuteReader()

            While myReader.Read

                ID = myReader(0).ToString()
                Description = myReader(1).ToString()

                Dim newRow As DataRow = dropDownTable.NewRow()
                newRow(0) = ID
                newRow(1) = Description
                dropDownTable.Rows.Add(newRow)

                ID = ""
                Description = ""

            End While

            myConn.Close()

        Catch ex As Exception

            myConn.Close()
            MsgBox(ex.ToString)
            'dropDownIDs.Add("Unable to gather information.")

        End Try

        dropDownView = New DataView(dropDownTable)
        Return dropDownView

    End Function

    Public Function RouterMaterialSelect() As ICollection

        Dim matDropDownTable As New DataTable()
        matDropDownTable.Columns.Add(New DataColumn("PartNbr", GetType(String)))
        matDropDownTable.Columns.Add(New DataColumn("Description", GetType(String)))

        Dim PartNbr As String
        Dim Description As String
        Dim matDropDownView As DataView

        Try

            myCmd = New SqlCommand("Select PartNbr, Description FROM ItemMaster WHERE PartNbr like 'MTL%'", myConn)
            myConn.Open()
            myReader = myCmd.ExecuteReader()

            While myReader.Read

                PartNbr = myReader(0).ToString()
                Description = myReader(1).ToString()

                Dim newRow As DataRow = matDropDownTable.NewRow()
                newRow(0) = PartNbr
                newRow(1) = Description
                matDropDownTable.Rows.Add(newRow)

                PartNbr = ""
                Description = ""

            End While

            myConn.Close()

        Catch ex As Exception

            myConn.Close()
            MsgBox(ex.ToString)
            'dropDownIDs.Add("Unable to gather information.")

        End Try

        matDropDownView = New DataView(matDropDownTable)
        Return matDropDownView

    End Function




#End Region

End Module
