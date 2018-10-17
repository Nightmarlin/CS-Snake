using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snek {
    class Snook : IEquatable<Snook> {
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

		public override bool Equals(object obj) {
			return Equals(obj as Snook);
		}

		public bool Equals(Snook other) {
			return (other != null &&
				   EqualityComparer<SnekBlok>.Default.Equals(this.HeadBlok, other.HeadBlok) &&
				   this.XDir == other.XDir &&
				   this.YDir == other.YDir &&
				   this.DoMove == other.DoMove &&
				   EqualityComparer<Color>.Default.Equals(this.Colour, other.Colour));
		}

		public override int GetHashCode() {
			var hashCode = -509089842;
			hashCode = hashCode * -1521134295 + EqualityComparer<SnekBlok>.Default.GetHashCode(this.HeadBlok);
			hashCode = hashCode * -1521134295 + this.XDir.GetHashCode();
			hashCode = hashCode * -1521134295 + this.YDir.GetHashCode();
			hashCode = hashCode * -1521134295 + this.DoMove.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(this.Colour);
			return hashCode;
		}

		public static bool operator ==(Snook snook1, Snook snook2) {
			return EqualityComparer<Snook>.Default.Equals(snook1, snook2);
		}

		public static bool operator !=(Snook snook1, Snook snook2) {
			return !(snook1 == snook2);
		}

	}
}
