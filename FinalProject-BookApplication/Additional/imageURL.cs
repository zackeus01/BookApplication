using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_BookApplication.Additional
{
    public class imageURL
    {
        public Image getImage(string url)
        {
            using (var httpClient = new WebClient())
            {
                try
                {
                    byte[] imageData = httpClient.DownloadData(url);
                    using (var stream = new System.IO.MemoryStream(imageData))
                    {
                        // Create a Bitmap from the image data.
                        return new Bitmap(stream);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during image loading.
                    MessageBox.Show("Error loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
}
