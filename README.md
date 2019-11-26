# QuickEditor.Toolkit


## Installation
Unity can not install dependent packages automatically at present, you have to install them manually:
https://github.com/henry-yuxi/QuickEditor.Common

Find Packages/manifest.json in your project and edit it to look like this:
{
  "dependencies": {
    "com.sourcemuch.quickeditor.toolkit": "https://github.com/henry-yuxi/QuickEditor.Toolkit.git#0.0.1",
    ...
  },
}

Or open the package manager window (menu: Window > Package Manager), select "Add package from git URL...", fill in this in the pop-up textbox: https://github.com/henry-yuxi/QuickEditor.Toolkit.git#0.0.1.

## Requirement
Unity 2018.3 or later
<br/>
Git (executable on command-line)
