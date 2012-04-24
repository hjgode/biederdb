using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ImageTransitions
{
    /// <summary>
    /// Summary description for ImageTransitionControl.
    /// </summary>
    public class ImageTransitionControl : PictureBox
    {
        System.Threading.Timer t;

        public enum TransitionTypes
        {
            Fade,
            BarnDoor,
            Slide,
            Spin,
            Checker,
            Blinds,
            Iris,
            Spiral
        }
        TransitionTypes _transitionType = TransitionTypes.Fade;
        public TransitionTypes TransitionType
        {
            get { return _transitionType; }
            set
            {
                _transitionType = value;
            }
        }


        Image _imageA;
        public Image ImageA
        {
            get { return _imageA; }
            set
            {
                _imageA = value;
                if (value != null)
                    scaleImage(this, _imageA);
            }
        }

        //Generate new image dimensions
        private Size GenerateImageDimensions(int currW, int currH, int destW, int destH)
        {
            //double to hold the final multiplier to use when scaling the image
            double multiplier = 0;

            //string for holding layout
            string layout;

            //determine if it's Portrait or Landscape
            if (currH > currW) layout = "portrait";
            else layout = "landscape";

            switch (layout.ToLower())
            {
                case "portrait":
                    //calculate multiplier on heights
                    if (destH > destW)
                    {
                        multiplier = (double)destW / (double)currW;
                    }

                    else
                    {
                        multiplier = (double)destH / (double)currH;
                    }
                    break;
                case "landscape":
                    //calculate multiplier on widths
                    if (destH > destW)
                    {
                        multiplier = (double)destW / (double)currW;
                    }

                    else
                    {
                        multiplier = (double)destH / (double)currH;
                    }
                    break;
            }

            //return the new image dimensions
            return new Size((int)(currW * multiplier), (int)(currH * multiplier));
        }
        // see http://www.dreamincode.net/code/snippet2376.htm
        //Resize the image
        private Image scaleImage(Control pb, Image imgOrg)
        {
            //create a temp image
            Image img = imgOrg;
            Bitmap finalImg = null;
            try
            {
                //calculate the size of the image
                Size imgSize = GenerateImageDimensions(img.Width, img.Height,
                               pb.Width, pb.Height);

                //create a new Bitmap with the proper dimensions
                finalImg = new Bitmap(img, imgSize.Width, imgSize.Height);

                //create a new Graphics object from the image
                Graphics gfx = Graphics.FromImage(img);

                //clean up the image (take care of any image loss from resizing)
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return finalImg;
        }

        //Sample usage
        //	private void Form1_Load(object sender, EventArgs e)
        //	{
        //	    SetImage(pictureBox1);
        //	}
        Image _imageB;
        public Image ImageB
        {
            get { return _imageB; }
            set
            {
                _imageB = value;
                if (value != null)
                    _imageB = scaleImage(this, _imageB);
            }
        }

        public ImageTransitionControl()
        {
            this.Width = 160;
            this.Height = 160;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
        }

        //Variables used in the timing system
        TimeSpan _transitionTime = new TimeSpan(0, 0, 0, 1, 0);
        float _currentPercentage = 0;
        bool _running = false;

        /// <summary>
        /// transition time in seconds
        /// </summary>
        public float TransitionTime
        {
            get { return (float)_transitionTime.TotalSeconds; }
            set { _transitionTime = new TimeSpan(0, 0, 0, 0, (int)(1000 * value)); }
        }

        //The moment at which the transition begins
        DateTime _startTime;

        //Called to start the transition off
        public void Go()
        {
            if (_running)
                return;
            t = new System.Threading.Timer(new TimerCallback(Tick), null, 40, 40);
            this._currentPercentage = 0;
            _running = true;
            _startTime = DateTime.Now;
            Invalidate();
        }

        //Services the tick event and re-calculates the percentage done
        void Tick(object state)
        {
            TimeSpan ts = DateTime.Now - this._startTime;
            _currentPercentage = (float)(100f / this._transitionTime.TotalSeconds * ts.TotalSeconds);
            if (_currentPercentage > 100)
            {
                _currentPercentage = 100;
                _running = false;
                t.Change(40, Timeout.Infinite);//stop timer
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_imageA == null || _imageB == null)
                return;
            int _nHDivs = 10;
            int _nVDivs = 10;
            e.Graphics.DrawImage(_imageA, new Rectangle(0, 0, (int)(this.Width), this.Height),
                                  0, 0, _imageA.Width, _imageB.Height, GraphicsUnit.Pixel);

            switch (this.TransitionType)
            {
                case TransitionTypes.BarnDoor:
                    //has the effect of a barn door closing over the image
                    //First, the left-side is drawn
                    //then the right side
                    e.Graphics.DrawImage(_imageB,
                        new Rectangle(0, 0,
                        (int)(this.Width * _currentPercentage / 200), this.Height),
                        0, 0, _imageB.Width / 2, _imageB.Height,
                        GraphicsUnit.Pixel);
                    //then the right side
                    e.Graphics.DrawImage(_imageB,
                        new Rectangle(
                        (int)(this.Width - (this.Width * _currentPercentage / 200)), 0,
                        (int)(this.Width * _currentPercentage / 200), this.Height),
                        _imageB.Width / 2, 0,
                        _imageB.Width / 2, _imageB.Height,
                        GraphicsUnit.Pixel);
                    break;
                case TransitionTypes.Checker:
                    GraphicsPath pth = new GraphicsPath();
                    int cw = (int)(this.Width * _currentPercentage / 100) / _nHDivs;
                    int ch = this.Height / _nVDivs;
                    int row = 0;
                    for (int y = 0; y < this.Height; y += ch)
                    {
                        for (int x = 0; x < this.Width; x += this.Width / _nHDivs)
                        {
                            Rectangle rc = new Rectangle(x, y, cw, ch);
                            if ((row & 1) == 1)
                                rc.Offset(this.Width / (2 * _nVDivs), 0);
                            pth.AddRectangle(rc);
                            if (_currentPercentage >= 50 && (row & 1) == 1 && x == 0)
                            {
                                rc.Offset(-(this.Width / _nHDivs), 0);
                                pth.AddRectangle(rc);
                            }
                        }
                        row++;
                    }

                    Region r = new Region(pth);
                    e.Graphics.SetClip(r, CombineMode.Replace);
                    e.Graphics.DrawImage(_imageB, ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);
                    r.Dispose();
                    pth.Dispose();
                    break;
                case TransitionTypes.Spiral:
                    if (_currentPercentage < 100)
                    {
                        double percentageAngle = _nHDivs * (Math.PI * 2) / 100;
                        double percentageDistance = Math.Max(Width, Height) / 100;

                        pth = new GraphicsPath(FillMode.Winding);
                        float cx = Width / 2;
                        float cy = Height / 2;

                        double pc1 = _currentPercentage - 100;
                        double pc2 = _currentPercentage;
                        if (pc1 < 0)
                            pc1 = 0;
                        double a = percentageAngle * pc2;

                        PointF last = new PointF((float)(cx + (pc1 * percentageDistance * Math.Cos(a))), (float)(cy + (pc1 * percentageDistance * Math.Sin(a))));
                        for (a = percentageAngle * pc1; pc1 <= pc2; pc1 += 0.1, a += percentageAngle / 10)
                        {
                            PointF thisPoint = new PointF((float)(cx + (pc1 * percentageDistance * Math.Cos(a))), (float)(cy + (pc1 * percentageDistance * Math.Sin(a))));
                            pth.AddLine(last, thisPoint);
                            last = thisPoint;
                        }
                        pth.CloseFigure();

                        e.Graphics.SetClip(pth, CombineMode.Replace);
                        pth.Dispose();
                    }
                    e.Graphics.DrawImage(_imageB, ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);

                    break;
                //The fade transition is presented for completeness
                case TransitionTypes.Fade:
                    {
                        //This transition fades one image over the other
                        ImageAttributes ia = new ImageAttributes();
                        ColorMatrix cm = new ColorMatrix();
                        cm.Matrix33 = 1f / 255 * (255 * _currentPercentage / 100);
                        ia.SetColorMatrix(cm);
                        e.Graphics.DrawImage(_imageB, this.ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel, ia);
                        ia.Dispose();
                    }

                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.Iris:
                    // use a path
                    pth = new GraphicsPath();
                    // calculate the width and height of the ellipse
                    int w = (int)((this.Width * 1.414f) * _currentPercentage / 200);
                    int h = (int)((this.Height * 1.414f) * _currentPercentage / 200);
                    pth.AddEllipse(this.Width / 2 - w, this.Height / 2 - h, 2 * w, 2 * h);
                    // set the clipping region
                    e.Graphics.SetClip(pth, CombineMode.Replace);
                    //paint the image
                    e.Graphics.DrawImage(_imageB, ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);
                    pth.Dispose();
                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.Slide:
                    // a matrix is used to set the offset of the image
                    Matrix mx = new Matrix(1, 0, 0, 1, (this.Width * _currentPercentage / 100) - this.Width, 0);
                    // the matrix modifies the Graphics object
                    e.Graphics.Transform = mx;
                    // the image is drawn
                    e.Graphics.DrawImage(_imageB, ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);
                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.Spin:
                    // calculate the degrees of spin
                    float degrees = 360 * _currentPercentage / 100;
                    //and the origin (center of the client area
                    float ofsX = this.Width / 2;
                    float ofsY = this.Height / 2;
                    //calculate the scale at which the image will be drawn
                    float Scale = 1 * _currentPercentage / 100;
                    //catering for zero's which will cause an exception
                    if (Scale == 0)
                        Scale = 0.0001f;
                    //create a matrix with the scale and origin
                    Matrix rm = new Matrix(Scale, 0, 0, Scale, ofsX, ofsY);
                    //do the spin
                    rm.Rotate(degrees, MatrixOrder.Prepend);
                    //use the matrix
                    e.Graphics.Transform = rm;
                    //draw the image
                    e.Graphics.DrawImage(_imageB, new Rectangle(-Width / 2, -Height / 2, Width, Height), 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);
                    rm.Dispose();
                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.Blinds:
                    // blinds divide the image into n horizontal stripes
                    for (int y = 0; y < _nHDivs; y++)
                    {
                        //for each stripe, find the source in the overlay image
                        Rectangle src = new Rectangle(0, y * (_imageB.Height / _nHDivs), _imageB.Width, _imageB.Height / _nHDivs);
                        //calculate the destination
                        Rectangle drc = new Rectangle(0, y * (Height / _nHDivs), Width, (int)((Height / _nHDivs) * _currentPercentage / 100));
                        drc.Offset(0, (Height / (_nHDivs * 2)) - drc.Height / 2);
                        //draw the slice
                        e.Graphics.DrawImage(_imageB, drc, src, GraphicsUnit.Pixel);
                    }

                    break;
            }

            if (_currentPercentage == 100)
            {
                _running = false;
                if (t != null)
                    t.Dispose();
                t = null;
            }
            base.OnPaint(e);
        }

    }
}
