using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCollector
{
    public abstract class SaveableProfile<T> where T : SaveableProfile<T>, new()
    {
        [JsonIgnore]
        public T InitialProfile { get; set; }
        [JsonIgnore]
        public static string ProfileName { get; set; }
        [JsonIgnore]
        public static string ProfileFileExtension { get; set; }

        public abstract T Clone();
        public abstract override bool Equals(object otherObj);

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Save()
        {
            Stream fileStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = $"{ProfileName} files (*.{ProfileFileExtension})|*.{ProfileFileExtension}|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveFileDialog.OpenFile()) != null)
                {
                    JsonSerializer serializer = new JsonSerializer();

                    // TODO: This looks like it stinks!
                    using (var sw = new StreamWriter(fileStream))
                    {
                        using (var jsonTextWriter = new JsonTextWriter(sw))
                        {
                            serializer.Serialize(jsonTextWriter, this);
                        }
                    }
                }
            }

            // reset initial state so we can tell if we have unsaved changes
            InitialProfile = this.Clone();
        }

        public static T Open()
        {
            Stream fileStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = $"{ProfileName} files (*.{ProfileFileExtension})|*.{ProfileFileExtension}|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = openFileDialog.OpenFile()) != null)
                {
                    // TODO: this looks like it SUPER STINKS
                    using (StreamReader file = new StreamReader(fileStream))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        T newProfile = (T)serializer.Deserialize(file, typeof(T));
                        newProfile.InitialProfile = newProfile.Clone();

                        return newProfile;
                    }
                }
            }

            return new T();
        }

        public bool IsProfileUnsaved()
        {
            return !this.Equals(InitialProfile);
        }
    }
}
