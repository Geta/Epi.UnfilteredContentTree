# Epi.UnfilteredContentTree

* Master<br>
![](http://tc.geta.no/app/rest/builds/buildType:(id:GetaPackages_EPiUnfilteredContentTree_00ci),branch:master/statusIcon)

Have you ever wanted to browse all content in your Episerver site? Now you can. This component plugs into the navigation and/or assets panel and shows an unfiltered list of all content in your database. The logged in user must be a member of either "Administrators" or "CmsAdmins" group to be able to use the component.

![ScreenShot](/docs/unfiltered-content-tree.jpg)

## How to install
Install NuGet package from Episerver NuGet Feed:

	Install-Package Geta.Epi.UnfilteredContentTree

## Add widget in Episerver
You need to add the widget in either navigation and/or assets panel. The widget is called "All content" and is located in the "Content" category.

![ScreenShot](/docs/add-gadget.jpg)
