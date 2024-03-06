﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
namespace QuanLyTraoDoiHang.RJControls
{
    class RoundButton : CheckBox
    {
        // Field
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;

        // constrcutor
        public RoundButton()
        {
            this.MinimumSize = new Size(45, 22);
        }
        // Method 
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2,0,arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 1);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if(this.Checked)//ON
            {
                // Draw the control surface
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                // Draw the toogle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
               
            }
            else // OFF
            {
                // Draw the control surface
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                // Draw the toogle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), 
                    new Rectangle(2,2, toggleSize, toggleSize));

            }
        }
    }
}
