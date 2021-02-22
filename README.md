# Blankity

This is a simple Windows program to blank out connected displays by drawing a black window over the entire screen.  Perhaps you're playing a game on one screen and don't want to be distracted by having extra displays on.  Sure, you could just turn each display off, but maybe it has a built-in USB hub you're using, or the power button is hard to reach....

## Usage

On startup, the program lists the displays reported by Windows.  By default, all displays except the primary display are checked.  The buttons operate as follows:

- Select All: select all screens in the list to be blanked.  Perhaps you want to compare black levels in a darkened room...
- Select None: unselect all screens in the list.
- Select Current: select the screen the Blankity window is on (determined by the upper left corner of the window).
- Identify: shows a small window with a number on each screen so you know which is which (similar to Windows' "Identify" button on its own display settings dialog).
- Blank Selected: blank out the selected screens.
- Unblank All: close all blanking windows.

## Notes

- Clicking on any blank screen will cause all blanking windows to close.
- Exiting the program will cause all blanking windows to close.
- If you have an OLED screen, this should actually reduce power consumption and may preserve the life of your display.
