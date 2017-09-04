# Differences to the original EdgeDeflector

I just wanted to add the ability to change the search machine with a simple additional text file that is placed in the same folder where the `EdgeDeflector.exe` file is: `C:\Program Files (x86)\EdgeDeflector`.

Just add a file with the name `ChangeUrl.txt` and enter in it the name of your desired Search Machine.

For example this is [my file](ChangeUrl.txt):

`C:\Program Files (x86)\EdgeDeflector\EdgeDeflector.exe`:

```
duckduckgo.com
```

This is all, now every search machine question will be instantly forwarded from `bing.com` to `duckduckgo.com`.

if no file was found nothing additional happens.

Thanks to the cool and great original EdgeDeflector program and their MIT license I could create this file in two hours with no C# knowledge because the `.nsi` script and project file worked perfectly.

A big thanks to [the cool authors](AUTHORS), I use the program since I discovered it!

---

# EdgeDeflector

*EdgeDeflector* is  a small helper application that intercepts URIs that force-open web links in Microsoft Edge and redirects it to the system’s default web browser. This allows you to use Windows features like the Cortana assistant and built-in help links with the browser of your choice instead of being forced to use Microsoft Edge. With EdgeDefelctor, you’re free to use Firefox, Google Chrome, or whatever your favorite web browser might be!

You’ll never see EdgeDeflector ever again after installing it. It does its thing transparently in the background and only runs when a link needs to be deflected away from Microsoft Edge.

System requirements: Windows 10, and your favorite web browser.

Read more about [how EdgeDeflector works](https://ctrl.blog/entry/edgedeflector-default-browser) and why it was created.

# Installation

    1. **Download** the latest version of EdgeDeflector from [GitHub releases](https://github.com/da2x/EdgeDeflector/releases)
    2. Run the installer once to configure your system

You may need to **repeat the above steps after installing major feature updates to Windows** through Windows Update. You can subscribe to the [AppCast feed](https://github.com/da2x/EdgeDeflector/releases.atom) to be notified of any new releases.

If you dismiss the initial dialog to choose to use EdgeDeflector, or choose the wrong app; you can apply the change  in the Windows Settings app: Apps: Default apps: Choose default apps by protocol: microsoft-edge.

If EdgeDeflector isn’t listed in either locations, try running it one more time; or lastly restarting your PC before you try again. (This last option actually helps if the System Registry is locked up or Windows is being stubborn.)

You don’t need to specify your browser of choice in EdgeDeflector. It will pick up on the system configured default from Windows Settings app: Apps: Default apps: Web browser.

# FAQ

## Will searches inside Cortana still use Bing?

Yes. EdgeDeflector doesn’t interfere with either Cortana or the Windows shell in any way. All that EdgeDeflector does is intercept links as you open them in order to rewrite them to open with your preferred web browser.

## “Intercepting links” sounds like it would affect my privacy?

Yes it does, but no. Everything is done on your local computer. EdgeDeflector rewrites links which are forced by the Windows shell to open inside Microsoft Edge to open using your default web browser instead. No data is collected about you nor even stored on your local computer.

## Will EdgeDeflector redirect Bing searches to Google?

[No.](https://github.com/da2x/EdgeDeflector/wiki/Not-replacing-your-search-engine) You can use an extension in your favorite web browser to achieve this.

## How do I uninstall EdgeDeflector?

By following [these instructions](https://github.com/da2x/EdgeDeflector/wiki/Uninstall).
