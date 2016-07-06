using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms
{
    public class CustomButton : Button
    {
        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(false);
        }

        public CustomButton()
            : base()
        {
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            
            Program.loginForm.DrawRect(this);

            //// We want to draw dotted border only when the button has focus, not otherwise 
            //if (base.ContainsFocus)
            //{
            //    // Draw inner dotted rectangle when button is on focus
            //    Brush b = new SolidBrush(Color.Transparent);
            //    Pen pen = new Pen(b, 8);
            //    Point p = base.Location;
            //    Rectangle rectangle = new Rectangle(0, 0, base.Width, base.Height);
            //    pevent.Graphics.DrawRectangle(pen, rectangle);
            //    pen.Dispose();
            //}
        }
    }
}