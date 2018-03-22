using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snek {
    class Fud {
        public Point DrawPoin;
		public Rectangle Rect;
        Color DrawColour;
        public Fud(Point Punt, Color Col) {
            DrawPoin = Punt;
			Rect = new Rectangle(DrawPoin, new Size(7, 7));

			DrawColour = Col;
        }
		public Fud() {
			DrawPoin = new Point(0, 0);
			Rect = new Rectangle(DrawPoin, new Size(0, 0));
		}

		public void Draw(Graphics GFX, SolidBrush B) {
			if (!GotEat) {
				B.Color = DrawColour;
				GFX.FillRectangle(B, Rect);
			}
		}

		public bool GotEat = false;

    }
}
