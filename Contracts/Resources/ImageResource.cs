using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Contracts.Resources
{
    public class ImageResource : IResource
    {
        public string RelativePath { get; private set; }
        public string FullPath { get; private set; }
        public long FileSize { get; private set; }
        public Image Image { get; private set; }
        public SizeF Size => Image.Size;

        public ImageResource(string mapPath, string fullPath)
        {
            RelativePath = Path.GetRelativePath(mapPath, fullPath);
            FullPath = fullPath;

            if (File.Exists(FullPath))
            {
                FileSize = new FileInfo(FullPath).Length;
                //copy construct so the file isn't getting locked
                using (var img = Image.FromFile(FullPath))
                {
                    Image = new Bitmap(img);
                }
            }
        }
    }
}
