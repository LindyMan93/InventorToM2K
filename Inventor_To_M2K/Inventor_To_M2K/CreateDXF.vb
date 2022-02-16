Imports Inventor

''' <summary>
''' This stores the CreateDXF sub.
''' </summary>
Module CreateDXF

    ''' <summary>
    ''' Found in the Part Tools Ribbon Panel of Parts. It will open the template .dxf of "zBlank.dwg"
    ''' From here it will as if the part in question is a sheet metal part. If yes, it will create a view
    ''' with the flat pattern of the part. If not, it will create a view with the front enabled.
    ''' </summary>
    ''' <param name="docName">Name of the document.</param>
    Public Sub CreateDXFFile(docName As String)

        Dim zBlankTemp As String = "H:\Engineering Drawings\Templates\zBlank.idw"
        Dim newDXF As DrawingDocument = m_inventorApplication.Documents.Add(DocumentTypeEnum.kDrawingDocumentObject, zBlankTemp)
        Dim newDXFSheet As Sheet = newDXF.Sheets.Item(1)

        Dim point1 As Point2d = m_inventorApplication.TransientGeometry.CreatePoint2d(8.5, 11.0)
        Dim vScale As Double = 0.1

        Dim baseViewOptions As NameValueMap = m_inventorApplication.TransientObjects.CreateNameValueMap

        Dim vOrientation As ViewOrientationTypeEnum = ViewOrientationTypeEnum.kFrontViewOrientation
        Dim partDoc As PartDocument = m_inventorApplication.Documents.Open(docName, False)
        Dim oView As DrawingView

        Dim sheetMetal = MsgBox("Is this a sheet metal part?", MsgBoxStyle.YesNo, "Cover?")

        If sheetMetal = MsgBoxResult.Yes Then

            baseViewOptions.Add("SheetMetalFoldedModel", False)
            oView = newDXFSheet.DrawingViews.AddBaseView(partDoc, point1, vScale,
                                                         ViewOrientationTypeEnum.kDefaultViewOrientation,
                                                         DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle,,,
                                                         baseViewOptions)

        Else

            oView = newDXFSheet.DrawingViews.AddBaseView(partDoc, point1, vScale, vOrientation,
                                                     DrawingViewStyleEnum.kHiddenLineDrawingViewStyle)

        End If

    End Sub

End Module
