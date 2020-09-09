using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace Question_01
{
    class preprocessing
    {

        IplImage srcImage, srcImage2;

        public void LoadOriginalImage(string fname)
        {
            srcImage = Cv.LoadImage("1b.png", LoadMode.Color);
            Cv.SaveImage("1bSave.png", srcImage);
            srcImage2 = Cv.LoadImage("1c.png", LoadMode.Color);
            Cv.SaveImage("1cSave.png", srcImage2);
        }

        public Image RotationOfTheImage(Image Image1, int AngleImage1)
        {
            //create an empty Bitmap image
            Bitmap ShipBitmapImage = new Bitmap(Image1.Width, Image1.Height);

            //turn the Bitmap into a Graphics object
            Graphics graphics = Graphics.FromImage(ShipBitmapImage);

            //now we set the rotation point to the center of our image
            graphics.TranslateTransform(ShipBitmapImage.Width / 2, ShipBitmapImage.Height / 2);

            //now rotate the image
            graphics.RotateTransform(AngleImage1);

            graphics.TranslateTransform(-ShipBitmapImage.Width / 2, -ShipBitmapImage.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            graphics.DrawImage(Image1, new Point(0, 0));

            //dispose of our Graphics object
            graphics.Dispose();

           
            return ShipBitmapImage;
        }


        public void Correction20degrees()
        {
            Image image = RotationOfTheImage(Image.FromFile("1b.png"), 20);
            image.Save("20DegreeOutput.png");

        }

        public void Correction90degrees()
        {
            Image image = RotationOfTheImage(Image.FromFile("1c.png"), 90);
            image.Save("90DegreeOutput.png");
        }
    }
}