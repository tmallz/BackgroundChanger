namespace BackgroundChangerService.Files
{
    public class FileReader : IFileReader
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
