﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.42000
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funzionalità di salvataggio automatico My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property cart_lav() As String
            Get
                Return CType(Me("cart_lav"),String)
            End Get
            Set
                Me("cart_lav") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property viewer_set() As String
            Get
                Return CType(Me("viewer_set"),String)
            End Get
            Set
                Me("viewer_set") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property cart_dest_vid() As String
            Get
                Return CType(Me("cart_dest_vid"),String)
            End Get
            Set
                Me("cart_dest_vid") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("25")>  _
        Public Property FTP_1() As Integer
            Get
                Return CType(Me("FTP_1"),Integer)
            End Get
            Set
                Me("FTP_1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("25")>  _
        Public Property FTP_2() As Integer
            Get
                Return CType(Me("FTP_2"),Integer)
            End Get
            Set
                Me("FTP_2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("25")>  _
        Public Property FTP_3() As Integer
            Get
                Return CType(Me("FTP_3"),Integer)
            End Get
            Set
                Me("FTP_3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Default")>  _
        Public Property QUA_1() As String
            Get
                Return CType(Me("QUA_1"),String)
            End Get
            Set
                Me("QUA_1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Default")>  _
        Public Property QUA_2() As String
            Get
                Return CType(Me("QUA_2"),String)
            End Get
            Set
                Me("QUA_2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Default")>  _
        Public Property QUA_3() As String
            Get
                Return CType(Me("QUA_3"),String)
            End Get
            Set
                Me("QUA_3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4000")>  _
        Public Property BTR_1() As Integer
            Get
                Return CType(Me("BTR_1"),Integer)
            End Get
            Set
                Me("BTR_1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4000")>  _
        Public Property BTR_2() As Integer
            Get
                Return CType(Me("BTR_2"),Integer)
            End Get
            Set
                Me("BTR_2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4000")>  _
        Public Property BTR_3() As Integer
            Get
                Return CType(Me("BTR_3"),Integer)
            End Get
            Set
                Me("BTR_3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Original")>  _
        Public Property RES_1() As String
            Get
                Return CType(Me("RES_1"),String)
            End Get
            Set
                Me("RES_1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Original")>  _
        Public Property RES_2() As String
            Get
                Return CType(Me("RES_2"),String)
            End Get
            Set
                Me("RES_2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Original")>  _
        Public Property RES_3() As String
            Get
                Return CType(Me("RES_3"),String)
            End Get
            Set
                Me("RES_3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property PRE_VID() As String
            Get
                Return CType(Me("PRE_VID"),String)
            End Get
            Set
                Me("PRE_VID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property xclick() As String
            Get
                Return CType(Me("xclick"),String)
            End Get
            Set
                Me("xclick") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property yclick() As String
            Get
                Return CType(Me("yclick"),String)
            End Get
            Set
                Me("yclick") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2048")>  _
        Public Property M1_SGM() As String
            Get
                Return CType(Me("M1_SGM"),String)
            End Get
            Set
                Me("M1_SGM") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2355")>  _
        Public Property M1_SGB() As String
            Get
                Return CType(Me("M1_SGB"),String)
            End Get
            Set
                Me("M1_SGB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("64")>  _
        Public Property M1_DINFU() As String
            Get
                Return CType(Me("M1_DINFU"),String)
            End Get
            Set
                Me("M1_DINFU") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property M1_SPEED() As String
            Get
                Return CType(Me("M1_SPEED"),String)
            End Get
            Set
                Me("M1_SPEED") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property M1_DIR() As String
            Get
                Return CType(Me("M1_DIR"),String)
            End Get
            Set
                Me("M1_DIR") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("48")>  _
        Public Property M2_SGM() As String
            Get
                Return CType(Me("M2_SGM"),String)
            End Get
            Set
                Me("M2_SGM") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
        Public Property M2_SS8() As String
            Get
                Return CType(Me("M2_SS8"),String)
            End Get
            Set
                Me("M2_SS8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("18")>  _
        Public Property M2_SN8() As String
            Get
                Return CType(Me("M2_SN8"),String)
            End Get
            Set
                Me("M2_SN8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1000")>  _
        Public Property M2_PAUSE() As String
            Get
                Return CType(Me("M2_PAUSE"),String)
            End Get
            Set
                Me("M2_PAUSE") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property M2_DIR() As String
            Get
                Return CType(Me("M2_DIR"),String)
            End Get
            Set
                Me("M2_DIR") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property AR_LED() As String
            Get
                Return CType(Me("AR_LED"),String)
            End Get
            Set
                Me("AR_LED") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("11")>  _
        Public Property AR_DC() As String
            Get
                Return CType(Me("AR_DC"),String)
            End Get
            Set
                Me("AR_DC") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("6")>  _
        Public Property AR_M1_1() As String
            Get
                Return CType(Me("AR_M1_1"),String)
            End Get
            Set
                Me("AR_M1_1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("7")>  _
        Public Property AR_M1_2() As String
            Get
                Return CType(Me("AR_M1_2"),String)
            End Get
            Set
                Me("AR_M1_2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("8")>  _
        Public Property AR_M1_3() As String
            Get
                Return CType(Me("AR_M1_3"),String)
            End Get
            Set
                Me("AR_M1_3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("9")>  _
        Public Property AR_M1_4() As String
            Get
                Return CType(Me("AR_M1_4"),String)
            End Get
            Set
                Me("AR_M1_4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4")>  _
        Public Property AR_M2_1() As String
            Get
                Return CType(Me("AR_M2_1"),String)
            End Get
            Set
                Me("AR_M2_1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property AR_M2_2() As String
            Get
                Return CType(Me("AR_M2_2"),String)
            End Get
            Set
                Me("AR_M2_2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property AR_M2_3() As String
            Get
                Return CType(Me("AR_M2_3"),String)
            End Get
            Set
                Me("AR_M2_3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property cart_ardu() As String
            Get
                Return CType(Me("cart_ardu"),String)
            End Get
            Set
                Me("cart_ardu") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property cam_on() As Boolean
            Get
                Return CType(Me("cam_on"),Boolean)
            End Get
            Set
                Me("cam_on") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SaveTitle21() As Boolean
            Get
                Return CType(Me("SaveTitle21"),Boolean)
            End Get
            Set
                Me("SaveTitle21") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property foto_in() As Boolean
            Get
                Return CType(Me("foto_in"),Boolean)
            End Get
            Set
                Me("foto_in") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property foto_in2() As Boolean
            Get
                Return CType(Me("foto_in2"),Boolean)
            End Get
            Set
                Me("foto_in2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property solo_file() As String
            Get
                Return CType(Me("solo_file"),String)
            End Get
            Set
                Me("solo_file") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property nome() As String
            Get
                Return CType(Me("nome"),String)
            End Get
            Set
                Me("nome") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property inizio() As String
            Get
                Return CType(Me("inizio"),String)
            End Get
            Set
                Me("inizio") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property FERMA() As Boolean
            Get
                Return CType(Me("FERMA"),Boolean)
            End Get
            Set
                Me("FERMA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property cart_dest_pic() As String
            Get
                Return CType(Me("cart_dest_pic"),String)
            End Get
            Set
                Me("cart_dest_pic") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("jpg")>  _
        Public Property file_ext() As String
            Get
                Return CType(Me("file_ext"),String)
            End Get
            Set
                Me("file_ext") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property def_cam() As String
            Get
                Return CType(Me("def_cam"),String)
            End Get
            Set
                Me("def_cam") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property def_res() As String
            Get
                Return CType(Me("def_res"),String)
            End Get
            Set
                Me("def_res") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property set_com() As String
            Get
                Return CType(Me("set_com"),String)
            End Get
            Set
                Me("set_com") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property wait_pic() As Integer
            Get
                Return CType(Me("wait_pic"),Integer)
            End Get
            Set
                Me("wait_pic") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property wait_motor() As Integer
            Get
                Return CType(Me("wait_motor"),Integer)
            End Get
            Set
                Me("wait_motor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property wait_step() As Integer
            Get
                Return CType(Me("wait_step"),Integer)
            End Get
            Set
                Me("wait_step") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property wait_microstep() As Integer
            Get
                Return CType(Me("wait_microstep"),Integer)
            End Get
            Set
                Me("wait_microstep") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property val_led() As Integer
            Get
                Return CType(Me("val_led"),Integer)
            End Get
            Set
                Me("val_led") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property val_motor() As Integer
            Get
                Return CType(Me("val_motor"),Integer)
            End Get
            Set
                Me("val_motor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property click_x() As Integer
            Get
                Return CType(Me("click_x"),Integer)
            End Get
            Set
                Me("click_x") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property click_y() As Integer
            Get
                Return CType(Me("click_y"),Integer)
            End Get
            Set
                Me("click_y") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.TELECINE.My.MySettings
            Get
                Return Global.TELECINE.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
