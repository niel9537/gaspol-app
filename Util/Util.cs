using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIR.Util
{
    public class Util
    {
        public Bitmap ApplyBlurEffect(Bitmap image, int blurAmount)
        {
            // Apply the Gaussian blur effect to the given image
            if (blurAmount < 1) blurAmount = 1;
            else if (blurAmount > 20) blurAmount = 20;

            Bitmap blurredImage = new Bitmap(image.Width, image.Height);

            using (Graphics graphics = Graphics.FromImage(blurredImage))
            {
                Rectangle rectangle = new Rectangle(0, 0, image.Width, image.Height);
                ImageAttributes imageAttributes = new ImageAttributes();

                ColorMatrix colorMatrix = new ColorMatrix();
                colorMatrix.Matrix33 = blurAmount / 20.0f;

                imageAttributes.SetColorMatrix(colorMatrix);

                graphics.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            return blurredImage;
        }
    }
}
