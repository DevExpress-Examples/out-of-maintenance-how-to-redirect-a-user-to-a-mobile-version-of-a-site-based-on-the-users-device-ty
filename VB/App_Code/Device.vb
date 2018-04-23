Imports DevExpress.Web.Internal
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public Class Device
    Private Shared ReadOnly Property platform() As BrowserPlatform
        Get
            Return RenderUtils.Browser.Platform
        End Get
    End Property

    Public Shared ReadOnly Property IsPhone() As Boolean
        Get
            Return platform.IsTouchUI AndAlso (platform.IsAndroidMobile OrElse platform.IsMacOSMobile OrElse platform.IsWebKitTouchUI OrElse platform.IsWindowsPhone)
        End Get
    End Property

    Public Shared ReadOnly Property IsTablet() As Boolean
        Get
            Return IsPhone
        End Get
    End Property

    Public Shared ReadOnly Property IsDesktop() As Boolean
        Get
            Return platform.IsWindows OrElse platform.IsMacOS OrElse platform.IsMSTouchUI
        End Get
    End Property

    Private Sub New()
    End Sub
End Class