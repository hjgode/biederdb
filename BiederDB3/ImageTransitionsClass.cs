using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace BiederDB3
{
    class ImageTransitionsClass
    {
        class blend:IImageTransition{
            string _name = "blend";
            public override string transitionName
            { 
                get { return _name; } 
            }
            public override void transitionRender(System.Drawing.Graphics g, System.Drawing.Image image_from, System.Drawing.Image image_to, double progress, int type, bool direction)
            {
                // Get the picture box's Graphics object, and clear the box
                System.Drawing.Graphics gra = g;
                gra.Clear(Color.Transparent); // no need - just to make the box neat 'n tidy
                gra.DrawImage(image_to,new Point(0,0));

                // Create a new color matrix with the alpha value set to the opacity specified in the slider
                ColorMatrix cm = new ColorMatrix();
                cm.Matrix00 = cm.Matrix11 = cm.Matrix22 = cm.Matrix44 = 1;
                cm.Matrix33 = (float)progress / 100;	// the matrix is of the form RGBA, where the (4,4)th element rep alpha

                // Create a new image attribute object and set the color matrix to the one you just created
                ImageAttributes ia = new ImageAttributes();
                ia.SetColorMatrix(cm);

                // Draw the original image with the image attributes specified
                gra.DrawImage(image_from, new Rectangle(0, 0, image_from.Width, image_from.Height), 0, 0, image_from.Width, image_from.Height, 
                    GraphicsUnit.Pixel, ia);

            }
        }
    }

    abstract class IImageTransition
    {
        public abstract string transitionName{get;}
        //System.Drawing.Graphics g;
        public abstract void transitionRender(System.Drawing.Graphics g, System.Drawing.Image image_from, System.Drawing.Image image_to, double progress, int type, bool direction);
    }
}
