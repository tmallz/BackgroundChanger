using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundChangerService.Desktop
{
    public class DesktopChanger : IDesktopChanger
    {
        const int SPI_SETDESKWALLPAPER = 0x0014;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDCHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public void ChangeBackground(string imagePath)
        {
            if (SetDesktopWallpaper(imagePath))
            {
                Console.WriteLine("Desktop wallpaper set successfully.");
            }
            else
            {
                Console.WriteLine("Failed to set desktop wallpaper.");
            }
        }

        private static bool SetDesktopWallpaper(string imagePath)
        {
            return SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imagePath, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE) != 0;
        }
    }
}