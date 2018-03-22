using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek {
    class SnekBlok {

        public Rectangle Rect;
		public SnekBlok ChildBlok;
        
        public SnekBlok(Rectangle Recta) {
            this.Rect = Recta;
			ChildBlok = null;
        }

		public void Draw(Graphics GFX, SolidBrush B) {
			GFX.FillRectangle(B, Rect);
			if (!(ChildBlok is null)) {
				ChildBlok.Draw(GFX, B);
			}
		}

		public void AddBlok() {
			if (!(ChildBlok is null)) {
				ChildBlok.AddBlok();
			} else {
				ChildBlok = new SnekBlok(Rect);
			}
		}

		public void Move(Rectangle ParentRect) {
			if (!(ChildBlok is null)) {
				ChildBlok.Move(Rect);
			}
			Rect = ParentRect;
		}
    }
}
