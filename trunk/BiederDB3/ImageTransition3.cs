using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BiederDB3
{
    public partial class ImageTransitionControl : UserControl
    {
        System.Threading.Timer t;
        //Variables used in the timing system
        TimeSpan _transitionTime = new TimeSpan(0, 0, 0, 1, 0);
        float _currentPercentage = 0;
        bool _running = false;
        //The moment at which the transition begins
        DateTime _startTime;
        /// <summary>
        /// number of horiz. tiles
        /// </summary>
        public int _nHDivs = 4;
        /// <summary>
        /// number of vert. tiles
        /// </summary>
        public int _nVDivs = 4;

        /// <summary>
        /// transition time in seconds
        /// </summary>
        public float TransitionTime
        {
            get { return (float)_transitionTime.TotalSeconds; }
            set { _transitionTime = new TimeSpan(0, 0, 0, 0, (int)(1000 * value)); }
        }
        //Called to start the transition off
        public void Go()
        {
            if (_running)
                return;
            t.Change(40, 40);
            System.Diagnostics.Debug.WriteLine("Transformation started");
            this._currentPercentage = 0;
            _running = true;
            _startTime = DateTime.Now;
            this.Invalidate();
        }
        public void stop()
        {
            try
            {
                t.Change(0, Timeout.Infinite);
            }
            catch (Exception)
            {
            }
            //t.Dispose();
            _running = false;
        }
        //Services the tick event and re-calculates the percentage done
        void Tick(object state)
        {
            TimeSpan ts = DateTime.Now - this._startTime;
            _currentPercentage = (float)(100f / this._transitionTime.TotalSeconds * ts.TotalSeconds);
            if (_currentPercentage >= 100 || _running == false)
            {
                _currentPercentage = 100;
                _running = false;
                t.Change(0, Timeout.Infinite);//stop timer
                System.Diagnostics.Debug.WriteLine("Transformation stopped");
                OnRaiseTransitionDone(new TransitionEventArgs(this.TransitionType.ToString(), _currentPercentage));
            }
            else
                OnRaiseTransitionDone(new TransitionEventArgs(this.TransitionType.ToString(), _currentPercentage));
            this.Invalidate();
        }

        public enum TransitionTypes
        {
            Fade,
            BarnDoor,
            SlideLeft,
            SlideDown,
            SlideUp,
            SlideRight,
            Spin,
            Checker,
            BlindsVertical,
            BlindsHorizontal,
            Iris,
            Spiral,
            ZoomTopLeft,
            ZoomCenter
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
                    this.BackgroundImage = ImageA;

                //    scaleImage(this, _imageA);
            }
        }

        Image _imageB;
        public Image ImageB
        {
            get { return _imageB; }
            set
            {
                _imageB = value;
                //if (value != null)
                //    _imageB = scaleImage(this, _imageB);
            }
        }

        public ImageTransitionControl()
        {
            InitializeComponent();
            this.Width = 160;
            this.Height = 160;
            t = new System.Threading.Timer(new TimerCallback(Tick), null, 40, Timeout.Infinite);
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            //pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
        }

        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (_imageA == null || _imageB == null)
            {
                //base.OnPaint(e);
                return;
            }
            //if(_currentPercentage>=100)
            //    e.Graphics.DrawImage(_imageA, new Rectangle(0, 0, (int)(this.Width), this.Height),
            //                      0, 0, _imageA.Width, _imageB.Height, GraphicsUnit.Pixel);
            Matrix mx;
            int w;
            int h;
            GraphicsPath pth;
            int cw, ch, row;
            Region r;
            Rectangle rc;
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
                    pth = new GraphicsPath();
                    cw = (int)(this.Width * _currentPercentage / 100) / _nHDivs;
                    ch = this.Height / _nVDivs;
                    row = 0;
                    for (int y = 0; y < this.Height; y += ch)
                    {
                        for (int x = 0; x < this.Width; x += this.Width / _nHDivs)
                        {
                            rc = new Rectangle(x, y, cw, ch);
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

                    r = new Region(pth);
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
                    w = (int)((this.Width * 1.414f) * _currentPercentage / 200);
                    h = (int)((this.Height * 1.414f) * _currentPercentage / 200);
                    pth.AddEllipse(this.Width / 2 - w, this.Height / 2 - h, 2 * w, 2 * h);
                    // set the clipping region
                    e.Graphics.SetClip(pth, CombineMode.Replace);
                    //paint the image
                    e.Graphics.DrawImage(_imageB, ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);
                    pth.Dispose();
                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.ZoomTopLeft:
                    /*A composite transformation is made up of the product of two or more matrices. Take for example, a scaling matrix with factor 2 in x-axis and 3 in y-axis.
                     * [ 2 0 ]
                     * [ 0 3 ]
                     * [ 0 0 ]
                     */
                    // a matrix is used to set the offset of the image
                    mx = new Matrix(
                        _currentPercentage / 100 + 0.1f, 0,
                        0, _currentPercentage / 100 + 0.1f,
                        0, 0);// (this.Width * _currentPercentage / 100) - this.Width
                    // the matrix modifies the Graphics object
                    e.Graphics.Transform = mx;
                    // the image is drawn
                    e.Graphics.DrawImage(_imageB, ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);
                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.ZoomCenter:
                    /*A composite transformation is made up of the product of two or more matrices. Take for example, a scaling matrix with factor 2 in x-axis and 3 in y-axis.
                     * [ 2 0 ]
                     * [ 0 3 ]
                     * [ 0 0 ]  //move
                     */
                    // a matrix is used to set the offset of the image
                    mx = new Matrix(
                        _currentPercentage / 100 + 0.1f, 0,
                        0, _currentPercentage / 100 + 0.1f,
                        (this.Width / 2) - (this.Width / 2 * (_currentPercentage / 100)),
                        (this.Height / 2) - (this.Height / 2 * (_currentPercentage / 100))
                        );// (this.Width * _currentPercentage / 100) - this.Width
                    // the matrix modifies the Graphics object
                    e.Graphics.Transform = mx;
                    // the image is drawn
                    e.Graphics.DrawImage(_imageB, ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);
                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.SlideLeft:
                    // a matrix is used to set the offset of the image
                    mx = new Matrix(1, 0, 0, 1, (this.Width * _currentPercentage / 100) - this.Width, 0);
                    // the matrix modifies the Graphics object
                    e.Graphics.Transform = mx;
                    // the image is drawn
                    e.Graphics.DrawImage(_imageB, ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);
                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.SlideRight:
                    /*a translation transformation of movement of 3 in x-axis and 2 in the y-axis would be represented as:
                     * [ 1 0 ]
                     * [ 0 1 ]
                     * [ 3 2 ]
                    */
                    mx = new Matrix(1, 0, 0, 1, this.Width - (this.Width * _currentPercentage / 100), 0); //(this.Width * _currentPercentage / 100) - 
                    // the matrix modifies the Graphics object
                    e.Graphics.Transform = mx;
                    // the image is drawn
                    e.Graphics.DrawImage(_imageB, ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);
                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.SlideDown:
                    /*a translation transformation of movement of 3 in x-axis and 2 in the y-axis would be represented as:
                     * [ 1 0 ]
                     * [ 0 1 ]
                     * [ 3 2 ]
                    */
                    //start at top and go down to bottom
                    mx = new Matrix(1, 0, 0, 1, 0, (this.Height * _currentPercentage / 100) - this.Height);
                    // the matrix modifies the Graphics object
                    e.Graphics.Transform = mx;
                    // the image is drawn
                    e.Graphics.DrawImage(_imageB, ClientRectangle, 0, 0, _imageB.Width, _imageB.Height, GraphicsUnit.Pixel);
                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.SlideUp:
                    /*a translation transformation of movement of 3 in x-axis and 2 in the y-axis would be represented as:
                     * [ 1 0 ]
                     * [ 0 1 ]
                     * [ 3 2 ]
                    */
                    //start at bottom and go up to top
                    mx = new Matrix(1, 0, 0, 1, 0, this.Height - (this.Height * _currentPercentage / 100));
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
                case TransitionTypes.BlindsHorizontal:
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
                /////////////////////////////////////////////////////////////////////////////////
                case TransitionTypes.BlindsVertical:
                    // blinds divide the image into n horizontal stripes
                    for (int y = 0; y < _nVDivs; y++)
                    {
                        //for each stripe, find the source in the overlay image
                        Rectangle src = new Rectangle(
                            y * (_imageB.Width / _nVDivs), 0,
                            _imageB.Width / _nVDivs, _imageB.Height);
                        //calculate the destination
                        Rectangle drc = new Rectangle(
                            y * (Width / _nVDivs), 0,
                            (int)((Width / _nVDivs) * _currentPercentage / 100), Height);

                        drc.Offset((Width / (_nVDivs * 2)) - drc.Width / 2, 0);
                        //draw the slice
                        e.Graphics.DrawImage(_imageB, drc, src, GraphicsUnit.Pixel);
                    }

                    break;
            }

            //if (_currentPercentage == 100)
            //{
            //    _running = false;
            //    if (t != null)
            //        t.Dispose();
            //    t = null;
            //}
            //base.OnPaint(e);
        }
        //event stuff
        public class TransitionEventArgs : EventArgs
        {
            public TransitionEventArgs(string s, float percentDone)
            {
                _msg = s;
                _percentDone = percentDone;
            }
            private string _msg;
            private float _percentDone;
            public string Message
            {
                get { return _msg; }
                set { _msg = value; }
            }
            public float percentDone
            {
                get { return _percentDone; }
                set { _percentDone = value; }
            }
        }
        public delegate void transistionDone(object sender, TransitionEventArgs e);
        public event EventHandler<TransitionEventArgs> onTransitionDone;
        protected virtual void OnRaiseTransitionDone(TransitionEventArgs e)
        {
            EventHandler<TransitionEventArgs> handler = onTransitionDone;
            if (handler != null)
            {
                e.Message = this.TransitionType.ToString();
                e.percentDone = this._currentPercentage;
                handler(this, e);
            }
        }

        //private void InitializeComponent()
        //{
        //    this.pictureBox1 = new System.Windows.Forms.PictureBox();
        //    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // pictureBox1
        //    // 
        //    this.pictureBox1.Location = new System.Drawing.Point(0, 0);
        //    this.pictureBox1.Name = "pictureBox1";
        //    this.pictureBox1.Size = new System.Drawing.Size(100, 50);
        //    this.pictureBox1.TabIndex = 0;
        //    this.pictureBox1.TabStop = false;
        //    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        //    this.ResumeLayout(false);

        //}
    }
}
