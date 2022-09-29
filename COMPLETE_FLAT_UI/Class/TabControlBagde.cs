using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace ULTRAMAVERICK.Class
{
    class TabControlBagde
    {
        public static List<Control> controls = new List<Control>();

        static public bool AddBadgeTo(Control ctl, string Text, int y, int x)
        {
            if (controls.Contains(ctl)) return false;

            Badge badge = new Badge();
            // badge.AutoSize = true;
            badge.Size = new Size(20, 20);
            badge.Text = Text;
            badge.BackColor = Color.FromArgb(255, 128, 64);
            controls.Add(ctl);
            ctl.Controls.Add(badge);
            SetPosition(badge, ctl, x, y);

            return true;
        }
        static  void SetPosition(Badge badge, Control ctl, int x, int y)
        {
            badge.Location = new Point(x,
                                       y);
        }
        class Badge : Label
        {
            Color BackColor = Color.SkyBlue;
            Color ForeColor = Color.White;
            Font font = new Font("Sans Serif", 9f);

            public Action<Control> ClickEvent;

            public Badge() { }

            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(255, 0, 0)),
                    this.ClientRectangle);
                e.Graphics.DrawString(Text, font, new SolidBrush(ForeColor), 3, 1);
            }

            protected override void OnClick(EventArgs e)
            {
                ClickEvent(this);
            }
        }
    }
}
