using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

// see http://imagination.svn.sourceforge.net/viewvc/imagination/trunk/transitions/

namespace ImageTransitions
{
    class ImageTransitionsClass
    {
        public class barn_door : IImageTransition
        {
            string _name = "bar_wipe";
            public override string transitionName
            {
                get { return _name; }
            }

            public override void transitionRender(ref System.Windows.Forms.PictureBox pb, Image image_from, Image image_to, double progress, int type, int direction)
            {
 	            int width, height;
                double dim;
	            double diag;

                width = image_from.Width;
                height = image_from.Height;
                Bitmap bmpPicture = new Bitmap(image_from); //an empty bitmap
                Image imgPicture = image_to;
                                
                //cairo_set_source_surface(cr, image_to, 0, 0);
                System.Drawing.Graphics gfxPicture = Graphics.FromImage(bmpPicture);// pb.CreateGraphics();
            	
	            diag = System.Math.Sqrt( ( width * width ) + ( height * height ) );
	            //cairo_move_to( cr, width / 2 , height / 2 );
                
	            switch( type )
	            {
	                case 1:
	                dim = width;
	                break;
	                case 2:
	                dim = height;
	                    //cairo_rotate( cr, G_PI / 2 );
                        gfxPicture.RotateTransform((float)(System.Math.PI / 2));
	                    break;
	                case 3:
	                    dim = diag;
	                    //cairo_rotate( cr, atan2( width, height ) );
                        gfxPicture.RotateTransform((float)(System.Math.Atan2(width,height)));
	                    break;
	                case 4:
	                    dim = diag;
	                    //cairo_rotate( cr, atan2( width, -height ) );
                        gfxPicture.RotateTransform((float)(System.Math.Atan2(width,-height)));
	                break;
	            }
                gfxPicture.RotateTransform(0, MatrixOrder.Append);
                
                //cairo_rel_move_to( cr, ( dim * progress ) / 2, 0 );
                //cairo_rel_line_to( cr, 0, - diag / 2 );
                //cairo_rel_line_to( cr, - dim * progress, 0 );
                //cairo_rel_line_to( cr, 0, diag );
                //cairo_rel_line_to( cr, dim * progress, 0 );
                //cairo_close_path( cr );
                //cairo_clip( cr );
                //cairo_paint(cr);

                pb.Image = bmpPicture;
            }
        }

        public class bar_wipe : IImageTransition
        {
            string _name = "bar_wipe";
            public override string transitionName
            {
                get { return _name; }
            }
            public void img_left(ref System.Windows.Forms.PictureBox pb, Image image_from, Image image_to, double progress)
            {
                transitionRender(ref pb, image_from, image_to, progress, 0, 1);
            }
            public void img_top(ref System.Windows.Forms.PictureBox pb, Image image_from, Image image_to, double progress)
            {
                transitionRender(ref pb, image_from, image_to, progress, 0, 2);
            }
            public void img_right(ref System.Windows.Forms.PictureBox pb, Image image_from, Image image_to, double progress)
            {
                transitionRender(ref pb, image_from, image_to, progress, 0, 3);
            }
            public void img_bottom(ref System.Windows.Forms.PictureBox pb, Image image_from, Image image_to, double progress)
            {
                transitionRender(ref pb, image_from, image_to, progress, 0, 4);
            }
            public override void transitionRender(ref System.Windows.Forms.PictureBox pb, Image image_from, Image image_to, double progress, int type, int direction)
            {
	            int width, height;
            	
	            width = image_from.Width;
	            height = image_from.Height;
                Bitmap bmpPicture = new Bitmap(image_from); //an empty bitmap
                Image imgPicture = image_to;

                System.Drawing.Graphics gfxPicture = Graphics.FromImage(bmpPicture);// pb.CreateGraphics();
	            //cairo_set_source_surface( cr, image_from, 0, 0 );
	            //cairo_paint( cr );

                progress = progress / 100;
	            //cairo_set_source_surface( cr, image_to, 0, 0 );
            	
	            switch( direction )
	            {
	                case 1: /* left */
	                    //cairo_rectangle( cr, 0, 0, width * progress, height );
                        //gfxPicture.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, 0, (int)(width * progress), height));
                        gfxPicture.DrawImage(imgPicture, 
                            new Rectangle(0, 0, (int)(width * progress), height));
	                    break;
	                case 2: /* top */
	                    //cairo_rectangle( cr, 0, 0, width, height * progress );
                        gfxPicture.DrawImage(imgPicture, 
                            new Rectangle(0, 0, width, (int)(height * progress)));
	                    break;
	                case 3: /* right */
	                    //cairo_rectangle( cr, width * ( 1 - progress ), 0, width, height );
                        gfxPicture.DrawImage(imgPicture,
                            new Rectangle((int)(width*(1-progress)), 0, width, height));
	                    break;
	                case 4: /* bottom */
	                    //cairo_rectangle( cr, 0, height * ( 1 - progress ), width, height );
                        gfxPicture.DrawImage(imgPicture,
                            new Rectangle(0, (int)(height * (1 - progress)), width, height));
	                    break;
	            }
	            //cairo_fill( cr );
                
                pb.Image = bmpPicture;                
            }
        }

        public class blend:IImageTransition{
            string _name = "blend";
            public override string transitionName
            { 
                get { return _name; } 
            }
            public override void transitionRender(ref System.Windows.Forms.PictureBox pb, System.Drawing.Image image_from, System.Drawing.Image image_to, double progress, int type, int direction)
            {
                Bitmap bmpPicture = new Bitmap(image_from); //an empty bitmap
                Image imgPicture = image_to;

                System.Drawing.Graphics gfxPicture = Graphics.FromImage(bmpPicture);// pb.CreateGraphics();
                
                Rectangle rctPicture = new Rectangle(0, 0, imgPicture.Width, imgPicture.Height);

                // Create a new color matrix with the alpha value set to the opacity specified in the slider
                ColorMatrix cm = new ColorMatrix();
                cm.Matrix00 = cm.Matrix11 = cm.Matrix22 = cm.Matrix44 = 1;
                cm.Matrix33 = (float)progress / 100;	// the matrix is of the form RGBA, where the (4,4)th element rep alpha

                // Create a new image attribute object and set the color matrix to the one you just created
                ImageAttributes ia = new ImageAttributes();
                ia.SetColorMatrix(cm);

                // Draw the new image onto the old with the image attributes specified
                gfxPicture.DrawImage(imgPicture, rctPicture, 0, 0, imgPicture.Width, imgPicture.Height, GraphicsUnit.Pixel, ia);

                pb.Image = bmpPicture;
                //pb.Refresh();
            }
        }
        public class show1{
            string _name = "switch1";
            public  string transitionName
            { 
                get { return _name; } 
            }
            public  void transitionRender(ref System.Windows.Forms.PictureBox i, 
                System.Drawing.Image image_from, 
                System.Drawing.Image image_to, 
                double progress, 
                int type, 
                int direction)
            {
                Bitmap bmp = new Bitmap(image_to);
                // Get the picture box's Graphics object, and clear the box
                System.Drawing.Graphics g = i.CreateGraphics();
                //g.Clear(Color.Transparent); // no need - just to make the box neat 'n tidy
                g.DrawImage(bmp, new Point(0,0));
                i.Image = bmp;
                i.Refresh();
            }
        }

    }

    abstract class IImageTransition
    {
        public abstract string transitionName{get;}
        //System.Drawing.Graphics g;
        public abstract void transitionRender(
            ref System.Windows.Forms.PictureBox pb, 
            System.Drawing.Image image_from, 
            System.Drawing.Image image_to, 
            double progress, 
            int type, 
            int direction);
    }
}
