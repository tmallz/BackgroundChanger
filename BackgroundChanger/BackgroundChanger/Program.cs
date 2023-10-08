//Program to change the desktop background on specific key press
//  Steps that need to happen:
//    - Read in all potential backgournds from - check
//    - Pick a random one from the unpicked files
//    - Set the desktop background to the picture

using BackgroundChanger.Desktop;
using BackgroundChanger.Files;
using System.Drawing;

FileReader fileReader = new FileReader();
string filePAth = fileReader.GetRandomImageFilepath();

DesktopChanger desktopChanger = new DesktopChanger(filePAth);
desktopChanger.ChangeBackground();

