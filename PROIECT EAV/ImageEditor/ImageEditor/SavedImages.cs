﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditor
{
    public class SavedImages
    {
        public List<SavedImage> Images { get; set; }

        public SavedImages()
        {
            Images = new List<SavedImage>();
        }

        public void Add(SavedImage image)
        {
            Images.Add(image);
        }
    }
}
