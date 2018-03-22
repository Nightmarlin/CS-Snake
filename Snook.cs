using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snek {
    class Snook {
        public SnekBlok HeadBlok;
        public int XDir = 0;
        public int YDir = 0;
		public bool DoMove;
		public Color Colour = Color.Lime;

        public void DidNomFud() { // TODO: Add a tail blok each time we nom fud
								  // System.Windows.Forms.MessageBox.Show("Nom");
			HeadBlok.AddBlok();
        }

        public Snook(Rectangle StartRect, Color StartColor) {
            HeadBlok = new SnekBlok(StartRect);
			DoMove = false;
        }

        public void Draw(Graphics GFX) {
			using (SolidBrush B = new SolidBrush(Colour)) {
				HeadBlok.Draw(GFX, B);
			}
        }

        public void Move() {
			if (DoMove) {
				Rectangle TRect = new Rectangle(HeadBlok.Rect.X + XDir, HeadBlok.Rect.Y + YDir, 10, 10);
				HeadBlok.Move(TRect);
			}
        }

		
    }
}
