﻿#Installation Instructions

**Requirements**
This package requires Sass (Compass is optional).  
For Compass and Sass support in Visual Studio see: http://www.mindscapehq.com/products/web-workbench

##1. Configure your project

Foundation can be used either with Sass or Sass with compass. The Foundation Nuget package installs Foundation to the `~/sass` folder by default.

1a. Configure your Sass output folder
Open up the Web Workbench Settings for your project (select the project and use the right click context menu, or the Mindscape menu) 
you can set the Output Folder for your SCSS file and specify where the .css and/or .min.css will be generated.

1b. Create a Compass project
(Instructions using Web Workbench) http://www.mindscapehq.com/blog/index.php/2012/10/04/working-with-compass-web-workbench-to-create-button-sprites-within-visual-studio/
**If you are using Web Workbench, you must create a Compass project, otherwise Web Workbench will not save the compiled CSS to the correct location.**

Open the `/config.rb` and change the output directory from `stylesheets` to `Content`
`#Match MVC conventions`
`css_dir = "Content"`

If desired remove Compass default files `ie.scss, screen.scss, print.scss`


##2. Update the Layout

Open the `/Views/_ViewStart.cshtml`
Change the Layout to `_Foundation.cshtml` like the example below:

    @{
        //This is the default MVC template
        //Layout = "~/Views/Shared/_Layout.cshtml";
        
        //This is the Foundation MVC template
        Layout = "~/Views/Shared/_Foundation.cshtml";
    }

##3. Replace the default theme

3a. Once the ViewStart has been updated. Replace the default `Index.cshtml`:

Rename `~/Views/Home/Index.cshtml to Index.cshtml.exclude` **or delete the file**  
Rename `~/Views/Home/Foundation_Index.cshtml` to `Index.cshtml`

3b. Next, remove the default Bootstrap style:

From the package manager console run **`PM> Uninstall-Package Bootstrap`**

Sass will replace the default style `~/Content/Site.css` This **WILL BE OVERWRITTEN** each time Sass compiles

Open and save `~/sass/Site.scss` (SASS) to generate `~/Content/Site.css` (CSS)

##4. Automatic Bundling and Minification

Open the `/App_Start/BundleConfig.cs`
Add the following bundles:

    #region Foundation Bundles

            bundles.Add(new ScriptBundle("~/bundles/foundation").Include(
                      "~/Scripts/foundation/foundation.js",
                      "~/Scripts/foundation/foundation.*",
                      "~/Scripts/foundation/app.js"));
    #endregion
##5. You are now ready to begin building your MVC project using Foundation.

####Related Nuget packages
Want to rapid prototype and wire frame directly from code using Html Helpers? 
Try the prototyping package on nuget. It works great with Foundation.
http://www.nuget.org/packages/Prototyping_MVC

Having trouble with media queries? Debug them with this simple CSS file.
http://nuget.org/packages/CSS_Media_Query_Debugger

####Documentation
Docs http://foundation.zurb.com/docs/  
Demo http://edcharbeneau.github.com/FoundationSinglePageRWD/

Resources: http://www.responsiveMVC.net/

Follow us:  
Ed Charbeneau http://twitter.com/#!/edcharbeneau  
Foundation Zurb http://twitter.com/#!/foundationzurb

#####Change Log:

Version 1.0.502
	- Initial NuGet Release

Note: version scheme `<major>.<minor>.<foundation version>`
foundation version represents the foundation version less the "." for example 4.1.4 would be #.#.414

Foundation Framework Support:
http://foundation.zurb.com/docs