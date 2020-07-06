using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Contracts;
using Contracts.Resources;

namespace MapReader
{
    public class ResourceReader
    {
        private string MapPath { get; set; }
        public ResourceReader(string mapPath)
        {
            MapPath = mapPath;
        }

        public ImageResource GetImageResource(string FilePath)
        {
            try
            {
                return new ImageResource(MapPath, FilePath);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IResource GetResource(string FilePath)
        {
            if (IsProbablyAnImage(FilePath))
            {
                return GetImageResource(FilePath);
            }

            return null;
        }

        private List<string> imgExtensions = new List<string>() { ".jpg", ".jpeg", ".png",};

        private bool IsProbablyAnImage(string FilePath)
        {
            if (imgExtensions.Contains(Path.GetExtension(FilePath).ToLower()))
                return true;
            return false;
        }
    }
}
