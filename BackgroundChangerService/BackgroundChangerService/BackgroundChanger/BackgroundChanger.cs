using BackgroundChangerService.Desktop;
using BackgroundChangerService.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundChangerService.BackgroundChangers
{
    public class BackgroundChanger : IBackgroundChanger
    {
        private readonly DesktopChanger desktopChanger;
        private readonly FileReader fileReader;
        public BackgroundChanger()
        {
            fileReader = new FileReader();
            desktopChanger = new DesktopChanger();
        }

        public void ChangeBackground()
        {
            string filePath = fileReader.GetRandomImageFilepath();
            desktopChanger.ChangeBackground(filePath);
        }
    }
}
