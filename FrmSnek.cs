using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snek {
	public partial class FrmSnek : Form {
		Snook TheSnek;
		List<Fud> FudList;
		int Score = 0;
		
		public FrmSnek() {
			InitializeComponent();
			this.Load += new EventHandler(FrmSnek_Load);
			snekPanel.Paint += new PaintEventHandler(SnekPanel_Paint);
			this.KeyDown += new KeyEventHandler(OnKeyPress);
			TmrFrameTick.Tick += new EventHandler(FrameTmrTick);
			TmrMakeFud.Tick += new EventHandler(FoodTimerTick);
			BtnStartStop.Click += new EventHandler(BtnStartStop_Click);
			TbarTickRate.ValueChanged += new EventHandler(TBarTickRate_ValueChanged);
			TBarTickRate_ValueChanged(null, null);
		}
		
		private void BtnStartStop_Click(object sender, EventArgs e) {
			Score = 0;
			LblScoreCount.Text = "Score: 0";
			FudList = new List<Fud>();
			MakeFud();
			NewSnek();
			TmrMakeFud.Enabled = true;
			TheSnek.DoMove = true;
		}

		private void MakeFud() {
			Random RandyRandom = new Random();
			Fud MaFud = new Fud(new Point(RandyRandom.Next(11, snekPanel.Width - 11), RandyRandom.Next(11, snekPanel.Height - 11)), Color.Red);
			FudList.Add(MaFud);
		}

		private void FrmSnek_Load(object sender, EventArgs e) {
			NewSnek();
			FudList = new List<Fud>();
		}

		private void NewSnek() {
			Rectangle tRect = new Rectangle((int)Math.Ceiling((decimal)(snekPanel.Width / 2)) - 5,
				(int)Math.Ceiling((decimal)(snekPanel.Height / 2) - 5),
				10, 10);
			TheSnek = new Snook(tRect, Color.Lime) {
				DoMove = false
			};

		}

		private void SnekPanel_Paint(object sender, PaintEventArgs e) {
			using (Pen P = new Pen(Color.Lime, 3)) {
				e.Graphics.DrawRectangle(P, e.ClipRectangle);
			}
			using (SolidBrush B = new SolidBrush(Color.Red)) {
				foreach (Fud item in FudList) {
					item.Draw(e.Graphics, B);
				}
			}
			TheSnek.Draw(e.Graphics);
		}

		private void OnKeyPress(object sender, KeyEventArgs e) {
			switch (e.KeyCode) {
				case Keys.W:
					Console.WriteLine("W");
					if (TheSnek.YDir == 0) {
						TheSnek.YDir = -10;
						TheSnek.XDir = 0;
					}
					break;
				case Keys.A:
					Console.WriteLine("A");
					if (TheSnek.XDir == 0) {
						TheSnek.XDir = -10;
						TheSnek.YDir = 0;
					}
					break;
				case Keys.S:
					Console.WriteLine("S");
					if (TheSnek.YDir == 0) {
						TheSnek.YDir = 10;
						TheSnek.XDir = 0;
					}
					break;
				case Keys.D:
					Console.WriteLine("D");
					if (TheSnek.XDir == 0) {
						TheSnek.XDir = 10;
						TheSnek.YDir = 0;
					}
					break;
				case Keys.Escape:
					Console.WriteLine("Esc");
					Application.Exit();
					break;
				default:
					break;
			}
		}

		private void FrameTmrTick(object sender, EventArgs e) {
			TheSnek.Move();
			CheckHit();
			CheckBounds();
			snekPanel.Refresh();
			LblScoreCount.Text = "Score: " + Score;
		}

		private void FoodTimerTick(object sender, EventArgs e) {
			MakeFud();
			Random RND = new Random();
			TmrMakeFud.Interval = RND.Next(500, 5000);
		}


		private void CheckHit() {
			Fud Ref = new Fud();
			foreach (Fud fud in FudList) {
				if (!Rectangle.Intersect(fud.Rect, TheSnek.HeadBlok.Rect).IsEmpty) {
					TheSnek.DidNomFud();
					fud.GotEat = true;
					Score += 1;
					Ref = fud;
				}
			}
			if (Ref.Rect.Height != 0) {
				FudList.Remove(Ref);
			}
		}

		private void TBarTickRate_ValueChanged(object sender, EventArgs e) {
			TmrFrameTick.Interval = TbarTickRate.Value * 25;
			LblTickSpeed.Text = "Frame Rate: " + (1000 / TmrFrameTick.Interval) + " FPS";
		}

		private void CheckBounds() {
			if (Rectangle.Intersect(TheSnek.HeadBlok.Rect, snekPanel.ClientRectangle).IsEmpty) {
				//	Snek is ded
				BtnStartStop_Click(null, null);
			}
		}

		private void TBarTickRate_MouseLeave(object sender, EventArgs e) {
			BtnStartStop.Focus();
		}

	}
}

