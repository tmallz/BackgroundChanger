using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BackgroundChanger.Files
{
    public class FileReader
    {
        private static string fileLocation = "C:\\Users\\Tim\\Pictures\\Saved Pictures";

        public string GetRandomImageFilepath()
        {
            List<string> files = Directory.GetFiles(fileLocation).ToList();

            Random random = new Random();
            return files[random.Next(0, files.Count)];
        }
    }
}
