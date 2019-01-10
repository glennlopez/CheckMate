# CheckMate

This is a very simple checksum tool I made for generating checksums and validating file integrity using SHA256 or MD5 calculations (uses math calculations on a file to check if a file is corrupt or has been modified in transit). 

#### What is a Checksum
Think of checksums as fingerprints for that particular file. When you edit a file, or parts of the file gets damaged, or unintentionally modified, its fingerprint will change (renaming a file will not change its fingerprint). 

We use checksums to validate if a file we transfered from colleague to colleague via USB drive or Email is exactly the same as the source. 

#### Why do a Checksum
Doing checksums become especially important when transfering firmware updates via usb, email, ftp, etc... If a firware is corrupt, you may not realize the damage you've done until its too late.

Damages can range from a **bricked EEPROM**, rendering your device forever-useless (due to a corrupt file)-- to unintentionally introducing **attack vectors** hackers can take advantage of (from unknowingly installing a firmware that was modified by a hacker during a man-in-the-middle attack).

So ya.. just do the damn checksum. The good news is, this tool aims to make it less painful for you to do that, and best of all... its open source!

<img src="https://github.com/glennlopez/Lakeside.CheckMate/blob/master/CheckMate/CheckMate/screenshots/3.PNG?raw=true" width="400" height="220" />

## Getting Started

Download the [latest release](https://github.com/glennlopez/Lakeside.CheckMate/releases), extract the .zip file and run **CheckMate.exe**

### Prerequisites

 - **Operating System:** Windows 10 , Windows 7 Service Pack 1, Windows 8, Windows 8.1, Windows Server 2008 R2 SP1, Windows Server 2012, Windows Server 2012 R2.
 - **.Net Framework:** [v4.6.1](https://www.microsoft.com/en-us/download/details.aspx?id=49981) or higher (Windows 10 or Windows 7 may already have this pre-installed in your system).

### Installing

This checksum utility is only 30kb at most so there are no installation/setup files available. Download the [latest release](https://github.com/glennlopez/Lakeside.CheckMate/releases), extract the .zip file and run **CheckMate.exe**

You can view the source code to check for mallicious code and compile it yourself or use an [anti-virus](https://www.virustotal.com/#/home/upload) to check for you. 

## How to use

#### Generating/Calculating Checksum
1. Click **[Get Hash]** button to open the File Dialog
2. Chose a file to calculate a checksum for
3. _optional_: Save the checksum to a file using the **[Save icon]** (its recomended you save it in the same folder/directory as the file)

#### Verify/Validate a File
Validation proccess assumes you already completed the steps above and have a Checksum string that you were given (by a colleague) to compare againts.
1. Look for **"Compare with"**, beside it is the textbox where you will paste the checksum your colleague gave you to compare againts the one that was generated for you during the **"Generating/Calculating Checksum"** step.
2. Click the **[Validate]** button. If it passes, it means the file is good. If it fails, it means it was either modified or it got corrupt in transit.

#### *Auto-validate after Calculating Checksum (new)
This feature is only available on v1.1.0 or higher. For this to work, you will need to have the .md5 or .sha2 in the same directory as the file you are validating. 

**For example:** If you have a file called firmware.zip you must have a firmware.sha2 or firmware.md5 in the same directory/folder as firmware.zip.

#####If you are sending a file to a colleague:
1. Click **[Get Hash]** to generate the checksum for the file
2. Click the **[Save icon]** and save the file in the same directory/folder as the file you calculated a checksum for.
3. Send both files ie: (**yourfile.zip** & **yourfile.sha2**) to your colleague.

#####If you are receving a file from a colleague:
1. Place both files ie: (**yourfile.zip** & **yourfile.sha2**) in the same folder/directory.
2. Run **CheckMate.exe** and click **[Get Hash]**
3. CheckMate will auto-validate your file for you if you've done everything correctly.

## License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/glennlopez/Lakeside.CheckMate/blob/master/LICENSE) file for details

## Acknowledgments

* Ngoc Pham (Instrumentation/Project Engineering)
   - Project scope definition
   - Testing

* [Lakeside Controls](http://Lakesidecontrols.ca) - The icon and logo used for CheckMate are trademark property of Lakeside Controls/Lakeside Processing. CheckMate source code is completely opensource. The Logo's and Images are NOT public domain. You are expected to change the logo and icons if you re-distribute, or fork this project. Again, although this project is opensource, the Logo and Icons are intelectual property of Lakeside Controls.