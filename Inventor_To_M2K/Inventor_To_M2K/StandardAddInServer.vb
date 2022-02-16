Imports Inventor
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Drawing
Imports System.Windows.Forms

Namespace Inventor_To_M2K
    <ProgIdAttribute("Inventor_To_M2K.StandardAddInServer"),
    GuidAttribute("f04fd474-ff28-4163-8f5d-6f62ccccc9d2")>
    Public Class StandardAddInServer
        Implements ApplicationAddInServer

        ' Private ActiveDocument As Document
        ' Private WithEvents docEvents As DocumentEvents

        ' Creating button for ribbon panels
        Private WithEvents impPInfo_Button As ButtonDefinition
        Private WithEvents saveDWG_Button As ButtonDefinition
        Private WithEvents hardInsert_Button As ButtonDefinition
        Private WithEvents nate_button As ButtonDefinition
        Private WithEvents allInfo_Button As ButtonDefinition
        Private WithEvents createDXF_Button As ButtonDefinition
        Private WithEvents QuickNotes_Button As ButtonDefinition

        ' Constant String that is the GuidAttribute.
        Private Const strAddInGuid As String = "f04fd474-ff28-4163-8f5d-6f62ccccc9d2"

#Region "ApplicationAddInServer Members"

        ''' <summary>
        ''' Activates the specified add in site object. When the Add-In is activated this will run. 
        ''' This is where all new ribbon tabs, ribbon panels, and buttons will be added. This method is 
        ''' called by Inventor when it loads the AddIn.The AddInSiteObject provides access to the Inventor 
        ''' Application object.The FirstTime flag indicates if the AddIn is loaded for the first time.
        ''' 
        ''' Taken from Inventor Add-In Tutorial and then modified.
        ''' </summary>
        ''' <param name="addInSiteObject">The add in site object.</param>
        ''' <param name="firstTime">if set to <c>true</c> [first time].</param>
        Public Sub Activate(ByVal addInSiteObject As ApplicationAddInSite, ByVal firstTime As Boolean) Implements ApplicationAddInServer.Activate

            ' Initialize AddIn members. (Inventor Application)
            m_inventorApplication = addInSiteObject.Application
            ' appEvents = m_inventorApplication.ApplicationEvents

            Dim regDate As Date = Date.Now
            Dim strDate As String = regDate.ToString("MMMdd")

            ' Will run if this is the first time the plug in is loaded. 
            ' Creates all ribbon tabs into Part and assembly ribbons.
            ' Creating new User Interface Manager for inventor application
            Dim UIManager As UserInterfaceManager = m_inventorApplication.UserInterfaceManager

            ' Creating ribbon objects and set them to PartRibbon and AssemblyRibbon and DrawingRibbon
            Dim pInvToM2kRibbon As Ribbon
            Dim aInvToM2kRibbon As Ribbon
            Dim dInvToM2kRibbon As Ribbon
            pInvToM2kRibbon = m_inventorApplication.UserInterfaceManager.Ribbons.Item("Part")
            aInvToM2kRibbon = m_inventorApplication.UserInterfaceManager.Ribbons.Item("Assembly")
            dInvToM2kRibbon = m_inventorApplication.UserInterfaceManager.Ribbons.Item("Drawing")

            ' Creating new ribbon tabs
            Dim pInvToM2KRibbonTab As RibbonTab
            Dim aInvToM2KRibbonTab As RibbonTab
            Dim dInvToM2KRibbonTab As RibbonTab

            ' Setting new part ribbon tab called "DynaCon" and putting it in the Part Ribbon
            pInvToM2KRibbonTab = pInvToM2kRibbon.RibbonTabs.Add("DynaCon",
                                                              "id_invToM2kPTab",
                                                              strAddInGuid)

            ' Setting new assembly ribbon tab called "DynaCon" and putting it in the Assembly Ribbon
            aInvToM2KRibbonTab = aInvToM2kRibbon.RibbonTabs.Add("DynaCon",
                                                              "id_invToM2kATab",
                                                              strAddInGuid)

            ' Setting new assembly ribbon tab called "DynaCon" and putting it in the Drawing Ribbon
            dInvToM2KRibbonTab = dInvToM2kRibbon.RibbonTabs.Add("DynaCon",
                                                                "id_invToM2KDTab",
                                                                strAddInGuid)

            ' Creating new ribbon panel to be added to the "DynaCon" part ribbon tab in part ribbon
            Dim pInvM2kPanel As RibbonPanel = pInvToM2KRibbonTab.RibbonPanels.Add("Manage 2000",
                                                                                "id_invToM2kPanel",
                                                                                strAddInGuid)

            ' Creating new ribbon panel to be added to the "DynaCon" part ribbon tab in part ribbon
            Dim pDCToolsPanel As RibbonPanel = pInvToM2KRibbonTab.RibbonPanels.Add("Part Tools",
                                                                                "id_invPartToolsPanel",
                                                                                strAddInGuid)

            ' Creating new ribbon panel to be added to the "DynaCon"  Assembly ribbon tab in Assembly ribbon
            Dim aInvM2kPanel As RibbonPanel = aInvToM2KRibbonTab.RibbonPanels.Add("Manage 2000",
                                                                            "id_invToM2kAPanel",
                                                                            strAddInGuid)

            ' Creating new ribbon panel to be added to the "DynaCon"  Assembly ribbon tab in Assembly ribbon
            Dim aDCToolsPanel As RibbonPanel = aInvToM2KRibbonTab.RibbonPanels.Add("Assembly Tools",
                                                                            "id_invDCToolsAPanel",
                                                                            strAddInGuid)

            ' Creating new ribbon panel to be added to the "DynaCon"  Drawing ribbon tab in Drawing ribbon
            Dim dInvM2kPanel As RibbonPanel = dInvToM2KRibbonTab.RibbonPanels.Add("Save Funtions",
                                                                            "id_invToM2kDPanel",
                                                                            strAddInGuid)
#Region "Image Conversions"

            ' Creating Icon Files
            ' Making Streams for 16pixel and 32pixel Part info button Icons
            Dim streamInfo16 As System.IO.Stream =
                Me.GetType().Assembly.GetManifestResourceStream("Inventor_To_M2K.import_ipt_16.ico")

            Dim streamInfo32 As System.IO.Stream =
            Me.GetType().Assembly.GetManifestResourceStream("Inventor_To_M2K.import_ipt_32.ico")

            ' Making Streams for 16pixel and 32pixel Drawing Save button Icons
            Dim streamSave16 As System.IO.Stream =
            Me.GetType().Assembly.GetManifestResourceStream("Inventor_To_M2K.save_16.ico")

            Dim streamSave32 As System.IO.Stream =
            Me.GetType().Assembly.GetManifestResourceStream("Inventor_To_M2K.save_32.ico")

            ' Making Streams for 16pixel and 32pixel hardInsert button Icons
            Dim streamInsert16 As System.IO.Stream =
            Me.GetType().Assembly.GetManifestResourceStream("Inventor_To_M2K.insert_Icon_16.ico")

            Dim streamInsert32 As System.IO.Stream =
            Me.GetType().Assembly.GetManifestResourceStream("Inventor_To_M2K.insert_Icon_32.ico")

            ' Making Streams for 16pixel and 32pixel AllInfo button Icons
            Dim allInfoPic As System.IO.Stream =
            Me.GetType().Assembly.GetManifestResourceStream("Inventor_To_M2K.allInfo_Icon.ico")

            Dim nrlPic As System.IO.Stream =
            Me.GetType().Assembly.GetManifestResourceStream("Inventor_To_M2K.sNRL.ico")

            ' Making Streams for 16pixel and 32pixel AllInfo button Icons
            Dim routerPic16 As System.IO.Stream =
            Me.GetType().Assembly.GetManifestResourceStream("Inventor_To_M2K.routerIcon_16.ico")

            Dim routerPic32 As System.IO.Stream =
            Me.GetType().Assembly.GetManifestResourceStream("Inventor_To_M2K.routerIcon_32.ico")

            ' Making new icons for Button images from resource stream
            Dim iptInfoIcon16 As Icon = New Icon(streamInfo16)
            Dim iptInfoIcon32 As Icon = New Icon(streamInfo32)
            Dim saveIcon16 As Icon = New Icon(streamSave16)
            Dim saveIcon32 As Icon = New Icon(streamSave32)
            Dim insertIcon16 As Icon = New Icon(streamInsert16)
            Dim insertIcon32 As Icon = New Icon(streamInsert32)
            Dim allInfoIcon As Icon = New Icon(allInfoPic)
            Dim nrlIcon As Icon = New Icon(nrlPic)
            Dim routerIcon16 As Icon = New Icon(routerPic16)
            Dim routerIcon32 As Icon = New Icon(routerPic32)

            ' Setting new IPictureDisplay objects to AxHostConverter
            ' New way of importing icons
            Dim iInfoIcon16 As Object = AxHostConverter.ImageToPictureDisp(iptInfoIcon16.ToBitmap())
            Dim iInfoIcon32 As Object = AxHostConverter.ImageToPictureDisp(iptInfoIcon32.ToBitmap())
            Dim iSaveIcon16 As Object = AxHostConverter.ImageToPictureDisp(saveIcon16.ToBitmap())
            Dim iSaveIcon32 As Object = AxHostConverter.ImageToPictureDisp(saveIcon32.ToBitmap())
            Dim iInsertIcon16 As Object = AxHostConverter.ImageToPictureDisp(insertIcon16.ToBitmap())
            Dim iInsertIcon32 As Object = AxHostConverter.ImageToPictureDisp(insertIcon32.ToBitmap())
            Dim iAllInfoIcon As Object = AxHostConverter.ImageToPictureDisp(allInfoIcon.ToBitmap())
            Dim iNRLIcon As Object = AxHostConverter.ImageToPictureDisp(nrlIcon.ToBitmap())
            Dim iRouter16Icon As Object = AxHostConverter.ImageToPictureDisp(routerIcon16.ToBitmap())
            Dim iRouter32Icon As Object = AxHostConverter.ImageToPictureDisp(routerIcon32.ToBitmap())

#End Region

#Region "Button Definitions"


            ' Creating control definition to add buttons.
            Dim oCtrlDef As ControlDefinitions = m_inventorApplication.CommandManager.ControlDefinitions

            ' Defining import part information button
            impPInfo_Button = oCtrlDef.AddButtonDefinition("Import Info",
                                                    "_idImpPInfo",
                                                    CommandTypesEnum.kQueryOnlyCmdType,
                                                    strAddInGuid,
                                                    "Opens a form to fill in correct item information.",
                                                    "Imports all information associated with a part to Manage 2000.",
                                                    iInfoIcon16,
                                                    iInfoIcon32,
                                                    ButtonDisplayEnum.kDisplayTextInLearningMode)

            ' Defining save formats button
            saveDWG_Button = oCtrlDef.AddButtonDefinition("Save Formats",
                                                    "_idDCsave",
                                                    CommandTypesEnum.kQueryOnlyCmdType,
                                                    strAddInGuid,
                                                    "Opens form to custom save options.",
                                                    "Custom save options.",
                                                    iSaveIcon16,
                                                    iSaveIcon32,
                                                    ButtonDisplayEnum.kDisplayTextInLearningMode)

            ' Defining hardware insert button
            hardInsert_Button = oCtrlDef.AddButtonDefinition("Hardware Insert",
                                                    "_idhrdInsert",
                                                    CommandTypesEnum.kQueryOnlyCmdType,
                                                    strAddInGuid,
                                                    "Opens a form to do multiple inserts.",
                                                    "Inserts hardware multiple times. Told you I could do it Caris.",
                                                    iInsertIcon16,
                                                    iInsertIcon32,
                                                    ButtonDisplayEnum.kDisplayTextInLearningMode)

            ' Defining developer button
            nate_button = oCtrlDef.AddButtonDefinition("Developer",
                                                    "_idCheckSQL",
                                                    CommandTypesEnum.kQueryOnlyCmdType,
                                                    strAddInGuid,
                                                    "Current actions that are being worked on, may not work correctly.",
                                                    "Current actions that are being worked on, may not work correctly.",
                                                    iNRLIcon,
                                                    iNRLIcon,
                                                    ButtonDisplayEnum.kDisplayTextInLearningMode)

            ' Defining query button for all part information
            allInfo_Button = oCtrlDef.AddButtonDefinition("All Info",
                                                    "_idInfoPaste",
                                                    CommandTypesEnum.kQueryOnlyCmdType,
                                                    strAddInGuid,
                                                    "Use this to copy and paste all information into M2K.",
                                                    "Use this to copy and paste all information into M2K.",
                                                    iAllInfoIcon,
                                                    iAllInfoIcon,
                                                    ButtonDisplayEnum.kDisplayTextInLearningMode)

            ' Defining create dxf button
            createDXF_Button = oCtrlDef.AddButtonDefinition("Quick DXF",
                                                    "_idCreateDXF",
                                                    CommandTypesEnum.kQueryOnlyCmdType,
                                                    strAddInGuid,
                                                    "Creates a .DXF file of current part.",
                                                    "Creates a .DXF file of current part.",
                                                    iRouter16Icon,
                                                    iRouter32Icon,
                                                    ButtonDisplayEnum.kDisplayTextInLearningMode)

            ' Defining query button for all part information
            QuickNotes_Button = oCtrlDef.AddButtonDefinition("Quick Notes",
                                                    "_idQuickNotes",
                                                    CommandTypesEnum.kQueryOnlyCmdType,
                                                    strAddInGuid,
                                                    "Use this to Create quick formatted notes during the project design phase.",
                                                    "Use this to Create quick formatted notes during the project design phase.",
                                                    iAllInfoIcon,
                                                    iAllInfoIcon,
                                                    ButtonDisplayEnum.kDisplayTextInLearningMode)

#End Region

            ' Displays a picture on a certain day.
            ' Just for fun.
            If strDate = "Aug23" Then

                funButtons()

            End If

#Region "Ribbon Creation"

            ' Only runs if this is the first time be open, maybe?
            If firstTime Then

                ' REMOVING BILL, ROUTING, AND ALL INFO BUTTON FROM MANAGE 2000 PANEL.
                ' ALL FUNCTIONALITY OF THESE HAVE BEEN MOVED TO ONE FORM "ERPPane".

                ' Adding buttons to the Manage 2000 Panel in the DynaCon Tab in the Part Ribbon
                pInvM2kPanel.CommandControls.AddButton(impPInfo_Button, True)
                pInvM2kPanel.CommandControls.AddButton(QuickNotes_Button, False)

                ' Adding buttons to the Part Tools Panel in the DynaCon Tab in the Part Ribbon
                pDCToolsPanel.CommandControls.AddButton(nate_button, False)
                pDCToolsPanel.CommandControls.AddButton(saveDWG_Button, False)
                pDCToolsPanel.CommandControls.AddButton(createDXF_Button, False)

                ' Adding buttons to the Assembly Tools Panel in the DynaCon Tab in the Assembly Ribbon

                aDCToolsPanel.CommandControls.AddButton(hardInsert_Button, True)
                aDCToolsPanel.CommandControls.AddButton(nate_button, False)
                aDCToolsPanel.CommandControls.AddButton(saveDWG_Button, False)

                ' Adding buttons to the Manage 2000 Panel in the DynaCon Tab in the Assembly Ribbon
                aInvM2kPanel.CommandControls.AddButton(impPInfo_Button, True)
                aInvM2kPanel.CommandControls.AddButton(QuickNotes_Button, False)

                ' Adding buttons to the Save Functions Panel in the DynaCon Tab in the Drawing Ribbon
                dInvM2kPanel.CommandControls.AddButton(saveDWG_Button, True)


                ' Making all ribbon tabs visible and disabling correct buttons
                pInvToM2KRibbonTab.Visible = True
                aInvToM2KRibbonTab.Visible = True
                dInvToM2KRibbonTab.Visible = True

            End If

#End Region

        End Sub

#Region "Button Push(es)"

        ''' <summary>
        ''' Handles the Part Information Buttons for both Ribbons. Opens the PartInfoDialog.
        ''' <see cref="PartInfoDialog"/>
        ''' </summary>
        ''' <param name="Context">The context.</param>
        Private Sub impPInfo_Button_OnExecute(ByVal Context As NameValueMap) Handles impPInfo_Button.OnExecute

            Dim erpPane As ERPpane
            erpPane = New ERPpane
            erpPane.ShowDialog()
            erpPane = Nothing

        End Sub

        ''' <summary>
        ''' Saves the DWG button on execute. Opens the saveForm to allow the user to SaveFileAs.
        ''' <see cref="saveForm"/>
        ''' </summary>
        ''' <param name="Context">The context.</param>
        Private Sub saveDWG_Button_OnExecute(ByVal Context As NameValueMap) Handles saveDWG_Button.OnExecute

            Dim saveFile As saveForm
            saveFile = New saveForm
            saveFile.ShowDialog()
            saveFile = Nothing

        End Sub

        ''' <summary>
        ''' Handles the hardInsert_Button. When it runs it will open the hardInsert form.
        ''' </summary>
        ''' <param name="Context">The context.</param>
        Private Sub hardInsert_Button_OnExecute(ByVal Context As NameValueMap) Handles hardInsert_Button.OnExecute

            Dim hardInsert As hardInsert
            hardInsert = New hardInsert
            hardInsert.Show()
            hardInsert = Nothing

        End Sub

        ''' <summary>
        ''' Opens a form to show all SQL information.
        ''' 
        ''' DISCONTINUED
        ''' 
        ''' THIS PROCESS IS NO LONGER USED.
        ''' 
        ''' </summary>
        ''' <param name="Context">The context.</param>
        Private Sub nate_Button_OnExecute(ByVal Context As NameValueMap) Handles nate_button.OnExecute

            'Dim newInfo As AllInOne
            'newInfo = New AllInOne
            'newInfo.ShowDialog()
            'newInfo = Nothing

        End Sub

        ''' <summary>
        ''' Opens a form that will display all the current part information.
        ''' </summary>
        ''' <param name="Context">The context.</param>
        Private Sub allInfo_Button_OnExecute(ByVal Context As NameValueMap) Handles allInfo_Button.OnExecute

            Dim allPartInfo As AllInfoForm
            allPartInfo = New AllInfoForm
            allPartInfo.ShowDialog()
            allPartInfo = Nothing

        End Sub

        ''' <summary>
        ''' Runs <see cref="CreateDXF.CreateDXFFile(String)"/>. 
        ''' Will create DXF file for user to send to CNC router.
        ''' </summary>
        ''' <param name="Context">The context.</param>
        Private Sub createDXF_Button_OnExecute(ByVal Context As NameValueMap) Handles createDXF_Button.OnExecute

            Dim currentDoc As Document = m_inventorApplication.ActiveDocument
            Dim docFP As String = currentDoc.FullFileName

            CreateDXFFile(docFP)

        End Sub

        Private Sub QuickNotes_Button_OnExecute(ByVal Context As NameValueMap) Handles QuickNotes_Button.OnExecute

            Dim QuickNotes As QuickNotes
            QuickNotes = New QuickNotes
            QuickNotes.ShowDialog()
            QuickNotes = Nothing

        End Sub

#End Region

        ''' <summary>
        ''' This method is called by Inventor when the AddIn is unloaded.
        ''' The AddIn will be unloaded either manually by the user or
        ''' when the Inventor session is terminated.
        ''' </summary>
        Public Sub Deactivate() Implements ApplicationAddInServer.Deactivate

            ' TODO:  Add ApplicationAddInServer.Deactivate implementation

            ' Release objects.
            Marshal.ReleaseComObject(m_inventorApplication)
            m_inventorApplication = Nothing

            GC.WaitForPendingFinalizers()
            GC.Collect()

        End Sub

        Public ReadOnly Property Automation() As Object Implements ApplicationAddInServer.Automation

            ' This property is provided to allow the AddIn to expose an API 
            ' of its own to other programs. Typically, this  would be done by
            ' implementing the AddIn's API interface in a class and returning 
            ' that class object through this property.

            Get
                Return Nothing
            End Get

        End Property

        Public Sub ExecuteCommand(ByVal commandID As Integer) Implements ApplicationAddInServer.ExecuteCommand

            ' Note:this method is now obsolete, you should use the 
            ' ControlDefinition functionality for implementing commands.

        End Sub

        ''' <summary>
        ''' Called on a certain day. This form opens something fun as an easter egg.
        ''' <see cref="bDayForm"/>
        ''' </summary>
        Private Sub funButtons()

            Dim nrlBday As bDayForm
            nrlBday = New bDayForm
            nrlBday.Show()
            nrlBday = Nothing

        End Sub

#End Region

#Region "COM Registration"

        ''' <summary>
        ''' Registers this class as an AddIn for Inventor. This function is called when the assembly 
        ''' is registered for COM.
        ''' </summary>
        ''' <param name="t">The t.</param>
        <ComRegisterFunctionAttribute()>
        Public Shared Sub Register(ByVal t As Type)

            Dim clssRoot As RegistryKey = Registry.ClassesRoot
            Dim clsid As RegistryKey = Nothing
            Dim subKey As RegistryKey = Nothing

            Try
                clsid = clssRoot.CreateSubKey("CLSID\" + AddInGuid(t))
                clsid.SetValue(Nothing, "Inventor To M2K")
                subKey = clsid.CreateSubKey("Implemented Categories\{39AD2B5C-7A29-11D6-8E0A-0010B541CAA8}")
                subKey.Close()

                subKey = clsid.CreateSubKey("Settings")
                subKey.SetValue("AddInType", "Standard")
                subKey.SetValue("LoadOnStartUp", "1")

                ' Allows supported Inventor Software of 12 (2009)
                subKey.SetValue("SupportedSoftwareVersionGreaterThan", "12..")
                subKey.SetValue("Version", 0)
                subKey.Close()

                subKey = clsid.CreateSubKey("Description")
                subKey.SetValue(Nothing, "Inventor To M2K")

            Catch ex As Exception
                System.Diagnostics.Trace.Assert(False)
            Finally
                If Not subKey Is Nothing Then subKey.Close()
                If Not clsid Is Nothing Then clsid.Close()
                If Not clssRoot Is Nothing Then clssRoot.Close()
            End Try

        End Sub

        ' Unregisters this class as an AddIn for Inventor.
        ' This function is called when the assembly is unregistered.
        <ComUnregisterFunctionAttribute()>
        Public Shared Sub Unregister(ByVal t As Type)

            Dim clssRoot As RegistryKey = Registry.ClassesRoot
            Dim clsid As RegistryKey = Nothing

            Try
                clssRoot = Microsoft.Win32.Registry.ClassesRoot
                clsid = clssRoot.OpenSubKey("CLSID\" + AddInGuid(t), True)
                clsid.SetValue(Nothing, "")
                clsid.DeleteSubKeyTree("Implemented Categories\{39AD2B5C-7A29-11D6-8E0A-0010B541CAA8}")
                clsid.DeleteSubKeyTree("Settings")
                clsid.DeleteSubKeyTree("Description")
            Catch
            Finally
                If Not clsid Is Nothing Then clsid.Close()
                If Not clssRoot Is Nothing Then clssRoot.Close()
            End Try

        End Sub

        ' This property uses reflection to get the value for the GuidAttribute attached to the class.
        Public Shared ReadOnly Property AddInGuid(ByVal t As Type) As String
            Get
                Dim guid As String = ""
                Try
                    Dim customAttributes() As Object = t.GetCustomAttributes(GetType(GuidAttribute), False)
                    Dim guidAttribute As GuidAttribute = CType(customAttributes(0), GuidAttribute)
                    guid = "{" + guidAttribute.Value.ToString() + "}"
                Finally
                    AddInGuid = guid
                End Try
            End Get
        End Property

#End Region

    End Class

    ''' <summary>
    ''' Image converter used for AutoDesk Inventor.
    ''' </summary>
    Friend Class AxHostConverter
        Inherits AxHost

        Private Sub New()
            MyBase.New("")
        End Sub

        Public Shared Function ImageToPictureDisp(image As Image) As stdole.IPictureDisp

            Return DirectCast(GetIPictureDispFromPicture(image), stdole.IPictureDisp)

        End Function

        Public Shared Function PictureDispToImage(pictureDisp As stdole.IPictureDisp) As Image

            Return GetPictureFromIPicture(pictureDisp)

        End Function


    End Class

End Namespace

