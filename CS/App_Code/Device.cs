using DevExpress.Web.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Device {
    private static BrowserPlatform platform {
        get { return RenderUtils.Browser.Platform; }
    }

    public static bool IsPhone {
        get {
            return platform.IsTouchUI 
                && (platform.IsAndroidMobile || 
                    platform.IsMacOSMobile || 
                    platform.IsWebKitTouchUI || 
                    platform.IsWindowsPhone
                );
        }
    }

    public static bool IsTablet {
        get {
            return IsPhone;
        }
    }

    public static bool IsDesktop {
        get {
            return platform.IsWindows || 
                platform.IsMacOS || 
                platform.IsMSTouchUI;
        }
    }

    private Device() {
    }
}