using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_BookApplication
{
    public partial class listItem : UserControl
    {
        public listItem()
        {
            InitializeComponent();
        }

        #region Properties

        private String _title;
        private String _author;
        private DateTime _dateCreated;
        private DateTime _dateUpdated;
        private String _desc;
        private Image _cover;

        [Category("Custom Props")]
        public String PropTitle
        {
            get { return _title; }
            set
            {
                _title = value;
                if (value != null)
                {
                    lblTitle.Text = value.ToUpper();
                }
                else
                {
                    lblTitle.Text = "Unknown Title";
                }
            }
        }

        [Category("Custom Props")]
        public String PropAuthor
        {
            get { return _author; }
            set
            {
                _author = value;
                if (value != null)
                {
                    lblAuthor.Text = value;
                }
                else
                {
                    lblAuthor.Text = "UnknownAuthor";
                }
            }
        }

        [Category("Custom Props")]
        public DateTime PropDateCreated
        {
            get { return _dateCreated; }
            set
            {
                _dateCreated = value;
                if (value != null)
                {
                    lblDateCreated.Text = value.ToString("dd/MM/yyyy");
                }
                else { lblDateCreated.Text = "Unknown Date"; }
            }
        }

        [Category("Custom Props")]
        public DateTime PropDateUpdated
        {
            get { return _dateUpdated; }
            set
            {
                _dateUpdated = value;
                if (value != null)
                {
                    lblDateUpdated.Text = value.ToString("dd/MM/yyyy");
                }
                else { lblDateUpdated.Text = "Unknown Date"; }
            }
        }

        [Category("Custom Props")]
        public String PropDesc
        {
            get { return _desc; }
            set
            {
                _desc = value;
                if (value != null)
                {
                    lblDesc.Text = value;
                }
                else
                {
                    lblDesc.Text = "Empty Desc";
                }
            }
        }

        [Category("Custom Props")]
        public Image PropCover
        {
            get { return _cover; }
            set
            {

                _cover = value;

                if (value != null)
                {
                    // Create a new bitmap with the desired size (123x172)
                    Bitmap resizedImage = new Bitmap(123, 172);

                    // Create a Graphics object to draw the resized image
                    using (Graphics graphics = Graphics.FromImage(resizedImage))
                    {
                        // Set the interpolation mode to high quality for better resizing
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                        // Use PictureBoxSizeMode.Zoom to preserve the aspect ratio and fill the control
                        graphics.DrawImage(value, new Rectangle(0, 0, 123, 172));
                    }

                    // Set the resized image as the Image property of imgCover
                    imgCover.Image = resizedImage;
                }
                else
                {
                    // If the value is null, clear the image
                    imgCover.Image = null;
                }

            }
        }

        #endregion
    }
}
