# How to redirect a user to a mobile version of a site based on the user's device type


<p>In this example, you will see how to redirect a user to a mobile or desktop version of a site. To determine the device type, you can use the <em>RenderUtils.Browser.Platform</em> property. To encapsulate the process of determining the device type, create a <em>Device</em> class with static fields that will represent the device type, for example, <em>isPhone</em>, <em>isTablet</em> and <em>isDesktop</em>. Please note that in the <em>BrowserPlatform</em> class there is no difference between tablets and phones, so for most complex scenarios you might want to parse a user agent and make a custom determination mechanism.</p>
<p>The <em>BrowserPlatform</em> class provides you with a set of properties, which will help you determine the user’s device type:</p>
<p>- IsAndroidMobile - Android phones and tablets</p>
<p>- IsMacOS – Apple PC</p>
<p>- IsMacOSMobile – Apple iPhones and iPads</p>
<p>- IsMSTouchUI – Microsoft surface and touch monitors</p>
<p>- IsTouchUI – Devices with a touch interface</p>
<p>- IsWebKitTouchUI – Mobile browsers</p>
<p>- IsWindows – Microsoft Windows PC</p>
<p>- IsWindowsPhone – Microsoft Windows Phone OS</p>
<p> </p>

<br/>


