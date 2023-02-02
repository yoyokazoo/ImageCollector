

namespace ImageCollector
{
    public class ImageCollectionProfile : SaveableProfile<ImageCollectionProfile>
    {
        static ImageCollectionProfile()
        {
            ProfileName = "ImageCollectionProfile";
            ProfileFileExtension = "icp";
        }

        public string ProcessName { get; set; }
        public int ProcessNum { get; set; }

        public int WindowOffsetX { get; set; }
        public int WindowOffsetY { get; set; }

        public int WindowWidth { get; set; }
        public int WindowHeight { get; set; }

        public const int DEFAULT_MS_BETWEEN_SCREENSHOTS = 1000;
        public int MSBetweenScreenshots { get; set; }

        public ImageCollectionProfile()
        {
            ProcessName = string.Empty;
            ProcessNum = 0;

            WindowOffsetX = 0;
            WindowOffsetY = 0;

            WindowWidth = 0;
            WindowHeight = 0;

            MSBetweenScreenshots = DEFAULT_MS_BETWEEN_SCREENSHOTS;
        }

        public override ImageCollectionProfile Clone()
        {
            ImageCollectionProfile newProfile = new ImageCollectionProfile();

            newProfile.ProcessName = this.ProcessName;
            newProfile.ProcessNum = this.ProcessNum;
            
            newProfile.WindowOffsetX = this.WindowOffsetX;
            newProfile.WindowOffsetY = this.WindowOffsetY;

            newProfile.WindowWidth = this.WindowWidth;
            newProfile.WindowHeight = this.WindowHeight;

            newProfile.MSBetweenScreenshots = this.MSBetweenScreenshots;

            return newProfile;
        }

        public override bool Equals(object otherObj)
        {
            var otherProfile = (ImageCollectionProfile)otherObj ?? new ImageCollectionProfile();

            if (!string.Equals(this.ProcessName, otherProfile.ProcessName) ||
                this.ProcessNum != otherProfile.ProcessNum ||
                this.WindowOffsetX != otherProfile.WindowOffsetX ||
                this.WindowOffsetY != otherProfile.WindowOffsetY ||
                this.WindowWidth != otherProfile.WindowWidth ||
                this.WindowHeight != otherProfile.WindowHeight || 
                this.MSBetweenScreenshots != otherProfile.MSBetweenScreenshots)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
