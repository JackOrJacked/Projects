using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Mtg
{
    public class ResizablePictureBox : PictureBox
    {
        private const int GripSize = 20;
        private bool isResizing = false;
        private Point resizeStartPosition;
        

        public ResizablePictureBox()
        {
            // Enable resizing by capturing mouse events
            this.MouseDown += ResizablePictureBox_MouseDown;
            this.MouseUp += ResizablePictureBox_MouseUp;
            this.MouseMove += ResizablePictureBox_MouseMove;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            base.MinimumSize= new Size(240, 300);
            // Draw resizing grips
            DrawGrip(pe.Graphics, new Point(0, 0));
            DrawGrip(pe.Graphics, new Point(this.Width - GripSize, 0));
            DrawGrip(pe.Graphics, new Point(0, this.Height - GripSize));
            DrawGrip(pe.Graphics, new Point(this.Width - GripSize, this.Height - GripSize));
        }

        private void DrawGrip(Graphics g, Point gripLocation)
        {
            Rectangle gripRect = new Rectangle(gripLocation, new Size(GripSize, GripSize));
            ControlPaint.DrawSizeGrip(g, this.BackColor, gripRect);
        }

        private void ResizablePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the mouse is on a grip for resizing
            if (e.Button == MouseButtons.Left && IsOnGrip(e.Location))
            {
                isResizing = true;
                resizeStartPosition = e.Location;
            }
        }

        private void ResizablePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop resizing
            isResizing = false;
        }

        private void ResizablePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                // Calculate the new size based on the mouse movement
                int dx = e.X - resizeStartPosition.X;
                int dy = e.Y - resizeStartPosition.Y;

                this.Width += dx;
                this.Height += dy;

                // Update the grip location for the next resize
                resizeStartPosition = e.Location;

                // Force a redraw
                this.Invalidate();
            }
        }

        private bool IsOnGrip(Point location)
        {
            // Check if the given location is within any of the resizing grips
            Rectangle gripRectTopLeft = new Rectangle(0, 0, GripSize, GripSize);
            Rectangle gripRectTopRight = new Rectangle(this.Width - GripSize, 0, GripSize, GripSize);
            Rectangle gripRectBottomLeft = new Rectangle(0, this.Height - GripSize, GripSize, GripSize);
            Rectangle gripRectBottomRight = new Rectangle(this.Width - GripSize, this.Height - GripSize, GripSize, GripSize);

            return gripRectTopLeft.Contains(location) ||
                   gripRectTopRight.Contains(location) ||
                   gripRectBottomLeft.Contains(location) ||
                   gripRectBottomRight.Contains(location);
        }
    }
}
