# Inventor_2_M2K
## Autodesk Inventor Add-In
### Developer: Nathan Lindenbaum
### Date: 5/3/2017 Updated: 6/16/2017

*This Add In application will work for Autodesk Inventor 2016 and newer.* 

#### What it does:

  1. Creates user a new ribbon tab on Assembly, Drawing, and Part Ribbons called Manage 2000 or DynaCon
  2. Creates buttons to use forms
      - **Part Info Form**
        * Creates User Defined Properties to track units of measure, descriptions, etc.
        * Allows for user to push all inputed information into a SQL database.
      - **Assembly BOM Form**
        * Gathers all parts that are used in the assembly and their quantities.
        * Allows user to create custom parts, change quanities and exclude parts.
        * Allows user to push information into SQL database.
      - **Part BOM Form**
        * User selects material used and can use calculate button to find the surface area of part.
        * Allows user to push information into SQL database.
      - **Routing Form**
        * User creates defines process to make part or assembly.
        * Allows user to push information into SQL database.
      - **DynaCon Save Form**
        * User selects which file formats to SaveCopyAs into desired folder.
      - **Hardware Insert Tool**
        * User selects edge of hardware (bolt).
        * Then they will select every hole where they need one placed.
        * User will select enter and a copy of the bolt will be placed in each hole with an insert contraint.
      - **Check All Imports**
        * Will iterate through assembly bill of materials to see if all information has been pushed.
	  - **All Information Form**
	    * Will query SQL to get all information associated with the open part.
	  - **Create .DXF Form**
	    * Will take a custom made part and create the .DXF file to be used on a CNC Router
3. It will remove unecessary or redundant work from designing new parts with inventor.

#### What it will do in the future (Hopefully):

  1. ~~Check all parts and assemblies to make sure information has been pushed.~~
  2. ~~Insert button for inserting hardware into holes of the same size.~~
  3. ~~Have install wizard to do installation automatically.~~
  
#### Automatic Installation
  
  1. Run AddInInstaller.msi. This will put all files and documentation into correct folders.

#### Manual Installation
  
  1. Copy Inventor_To_M2K.dll and Inventor_To_M2K.addin to desktop.
  2. Put Inventor_To_M2K.dll into C:\Program Files\Autodesk\Inventor 20XX\Bin
  3. Put Inventor_To_M2K.addin into C:\ProgramData\Autodesk\Inventor 20XX\Addins
  4. Restart Inventor and open a part, assembly or drawing.
  
#### Help
  1. Documentation to use can be found in Install folder. (Install Guide)
