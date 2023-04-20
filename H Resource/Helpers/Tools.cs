using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Helpers
{
    public class Tools
    {
        public static bool CompareImages(Bitmap image1, Bitmap image2)
        {
            if (image1.Size != image2.Size)
            {
                return false;
            }

            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    if (image1.GetPixel(x, y) != image2.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
