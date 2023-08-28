using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplication_FinalProject_Giang.Controls
{
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Image != null)
            {
                // Calculate the aspect ratio of the image
                float aspectRatio = (float)Image.Width / Image.Height;

                // Calculate the dimensions of the zoomed-out image that fits in the control
                int targetWidth = Width;
                int targetHeight = (int)(Width / aspectRatio);

                // If the height exceeds the control's height, recalculate based on height
                if (targetHeight > Height)
                {
                    targetHeight = Height;
                    targetWidth = (int)(Height * aspectRatio);
                }

                // Calculate the position to center the image
                int x = (Width - targetWidth) / 2;
                int y = (Height - targetHeight) / 2;

                using (Bitmap zoomedOutImage = new Bitmap(Image, targetWidth, targetHeight))
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddEllipse(0, 0, Width - 1, Height - 1);
                        Region = new Region(path);
                    }

                    e.Graphics.DrawImage(zoomedOutImage, x, y, targetWidth, targetHeight);
                }
            }

            base.OnPaint(e);
        }
    }
}
