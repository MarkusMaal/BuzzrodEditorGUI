# BuzzrodEditorGUI
This is a new version of BuzzrodSaveEditor with a graphical user interface.

# Features

## Profile list
After opening a save file, you can see a list of profiles, each profile having basic info displayed for identification purposes, including:
* ID
* Last modified date/time
* Total fish weight
* Last explored area
* Active lure
* Offset in the save file.
* Post-credits marking

## Export/Import profiles
This save editor allows you to also move profiles between save files in addition to deleting each profile. This allows allows you to for example duplicate a save file, so you can experiment around with stuff or whatever other purpose you can think of.

## Item management
In the "Items" tab you can set the number of items you have, view the Wiki page for each item, convert items to be consumptive/non-consumptive and more! This allows you to beat the game and play post-credits by giving yourself an additional Mysterious Lithograph 3!

## Lure management
The "Lures" tab basically allows you to put ANY item to any of the 4 slots no matter how many slots a lure is supposed to have. You can also lock/unlock/select any of the lures!

## The map
This feature allows you to see a map of the current area and the current position on that map. You can even replace the current position of the character!

# Importing a save from a memory card
To access the game save, you need to use uLaunchElf on a softmodded PlayStation 2 console or dump the data using a PlayStation 3 memory card adapter. In the memory card file structure, you'll see all of the IDs for games you have saved. For the PAL version of "Fishing Fantasy: BuzzRod", the game ID should be "BESLES-53236", but it may be different for you. You can check the game ID by checking the spine or inserting the game disc to your PC and opening SYSTEM.CNF file using a notepad and seeing what file it points to. That is the ID for your version of the game. Inside that folder is a file that is about 11kB and which has the game ID as the file name. That is your game save file, which you can edit using this program! The icon files cannot be edited using this program.
