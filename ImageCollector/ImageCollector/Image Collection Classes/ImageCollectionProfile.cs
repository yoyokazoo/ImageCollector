

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

        public ImageCollectionProfile()
        {
            ProcessName = string.Empty;
            ProcessNum = 0;

            WindowOffsetX = 0;
            WindowOffsetY = 0;

            WindowWidth = 0;
            WindowHeight = 0;
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
                this.WindowHeight != otherProfile.WindowHeight)
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
