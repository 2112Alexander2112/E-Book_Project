using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace EBookClient.Controls
{
    public class RoundBtm : Control
    {
        public int Radius { get; set; } = 30;
        public Image ButtonImage { get; set; }
        public Color PenColor { get; set; } = Color.FromArgb(255, 77, 77, 77);
        public Color FillColor { get; set; } = Color.FromArgb(255, 122, 204, 255);


        private bool MouseEntered = false;
        private bool MousePressed = false;   

        private StringFormat SF;

        public RoundBtm()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint, 
                true 
                );
            SF = new StringFormat();


            DoubleBuffered = true;
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Parent.BackColor);

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            if (Radius <= 0) Radius = 1;
            var rectGp = RoundedRectangle(rect, Radius);

            using (SolidBrush fillBrush = new SolidBrush(FillColor))
            {
                g.FillPath(fillBrush, rectGp);
            }

            using (Pen pen = new Pen(PenColor))
            {
                g.DrawPath(pen, rectGp);
            }

            if (ButtonImage != null)
            {
                int imageWidth = ButtonImage.Width;
                int imageHeight = ButtonImage.Height;
                int x = 10; 
                int y = (Height - imageHeight) / 2; 
                g.DrawImage(ButtonImage, x, y, imageWidth, imageHeight);
            }

            if (!string.IsNullOrEmpty(Text))
            {
                SizeF textSize = g.MeasureString(Text, Font);
                int textX = (int)((Width - textSize.Width) / 2); 
                int textY = (int)((Height - textSize.Height) / 2); 
                g.DrawString(Text, Font, new SolidBrush(ForeColor), textX, textY);
            }

            if (MouseEntered)
            {
                g.FillPath(new SolidBrush(Color.FromArgb(50, Color.Black)), rectGp);
            }
            if (MousePressed)
            {
                g.FillPath(new SolidBrush(Color.FromArgb(70, Color.Black)), rectGp);
            }
        }

        GraphicsPath RoundedRectangle(Rectangle rect, int Radius)
        {
            var gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, Radius, Radius, 180, 90);
            gp.AddArc(rect.X + rect.Width - Radius, rect.Y, Radius, Radius, 270, 90);
            gp.AddArc(rect.X + rect.Width - Radius, rect.Y + rect.Height - Radius, Radius, Radius, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - Radius, Radius, Radius, 90, 90);

            gp.CloseFigure();
            return gp;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            

            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            MousePressed = false;

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = true;

            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = false;

            Invalidate();
        }
    }
}
