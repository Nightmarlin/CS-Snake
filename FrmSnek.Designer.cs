namespace Snek {
    partial class FrmSnek {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSnek));
			this.tblPnlGame = new System.Windows.Forms.TableLayoutPanel();
			this.snekPanel = new Snek.SnekPanel();
			this.PnlControl = new System.Windows.Forms.Panel();
			this.LblScoreCount = new System.Windows.Forms.Label();
			this.LblTickSpeed = new System.Windows.Forms.Label();
			this.TbarTickRate = new System.Windows.Forms.TrackBar();
			this.BtnStartStop = new System.Windows.Forms.Button();
			this.TmrFrameTick = new System.Windows.Forms.Timer(this.components);
			this.TmrMakeFud = new System.Windows.Forms.Timer(this.components);
			this.tblPnlGame.SuspendLayout();
			this.PnlControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TbarTickRate)).BeginInit();
			this.SuspendLayout();
			// 
			// tblPnlGame
			// 
			this.tblPnlGame.BackColor = System.Drawing.Color.Black;
			this.tblPnlGame.ColumnCount = 2;
			this.tblPnlGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tblPnlGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tblPnlGame.Controls.Add(this.snekPanel, 0, 0);
			this.tblPnlGame.Controls.Add(this.PnlControl, 1, 0);
			this.tblPnlGame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblPnlGame.Location = new System.Drawing.Point(0, 0);
			this.tblPnlGame.Name = "tblPnlGame";
			this.tblPnlGame.RowCount = 1;
			this.tblPnlGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblPnlGame.Size = new System.Drawing.Size(784, 411);
			this.tblPnlGame.TabIndex = 1;
			// 
			// snekPanel
			// 
			this.snekPanel.BackColor = System.Drawing.Color.Black;
			this.snekPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.snekPanel.Location = new System.Drawing.Point(3, 3);
			this.snekPanel.Name = "snekPanel";
			this.snekPanel.Size = new System.Drawing.Size(582, 405);
			this.snekPanel.TabIndex = 0;
			// 
			// PnlControl
			// 
			this.PnlControl.BackColor = System.Drawing.Color.Black;
			this.PnlControl.Controls.Add(this.LblScoreCount);
			this.PnlControl.Controls.Add(this.LblTickSpeed);
			this.PnlControl.Controls.Add(this.TbarTickRate);
			this.PnlControl.Controls.Add(this.BtnStartStop);
			this.PnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlControl.Location = new System.Drawing.Point(591, 3);
			this.PnlControl.Name = "PnlControl";
			this.PnlControl.Size = new System.Drawing.Size(190, 405);
			this.PnlControl.TabIndex = 1;
			// 
			// LblScoreCount
			// 
			this.LblScoreCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LblScoreCount.ForeColor = System.Drawing.Color.Lime;
			this.LblScoreCount.Location = new System.Drawing.Point(3, 116);
			this.LblScoreCount.Name = "LblScoreCount";
			this.LblScoreCount.Size = new System.Drawing.Size(184, 23);
			this.LblScoreCount.TabIndex = 3;
			this.LblScoreCount.Text = "Score: 0";
			this.LblScoreCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblTickSpeed
			// 
			this.LblTickSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LblTickSpeed.ForeColor = System.Drawing.Color.Lime;
			this.LblTickSpeed.Location = new System.Drawing.Point(3, 42);
			this.LblTickSpeed.Name = "LblTickSpeed";
			this.LblTickSpeed.Size = new System.Drawing.Size(184, 23);
			this.LblTickSpeed.TabIndex = 2;
			this.LblTickSpeed.Text = "Frame Rate: X FPS";
			this.LblTickSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TbarTickRate
			// 
			this.TbarTickRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbarTickRate.LargeChange = 1;
			this.TbarTickRate.Location = new System.Drawing.Point(3, 68);
			this.TbarTickRate.Maximum = 7;
			this.TbarTickRate.Minimum = 1;
			this.TbarTickRate.Name = "TbarTickRate";
			this.TbarTickRate.Size = new System.Drawing.Size(184, 45);
			this.TbarTickRate.TabIndex = 1;
			this.TbarTickRate.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.TbarTickRate.Value = 4;
			this.TbarTickRate.MouseLeave += new System.EventHandler(this.TBarTickRate_MouseLeave);
			// 
			// BtnStartStop
			// 
			this.BtnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnStartStop.BackColor = System.Drawing.Color.Black;
			this.BtnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnStartStop.ForeColor = System.Drawing.Color.Lime;
			this.BtnStartStop.Location = new System.Drawing.Point(3, 3);
			this.BtnStartStop.Name = "BtnStartStop";
			this.BtnStartStop.Size = new System.Drawing.Size(184, 36);
			this.BtnStartStop.TabIndex = 0;
			this.BtnStartStop.Text = "Start";
			this.BtnStartStop.UseVisualStyleBackColor = false;
			// 
			// TmrFrameTick
			// 
			this.TmrFrameTick.Enabled = true;
			this.TmrFrameTick.Interval = 33;
			// 
			// TmrMakeFud
			// 
			this.TmrMakeFud.Interval = 5000;
			// 
			// FrmSnek
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 411);
			this.Controls.Add(this.tblPnlGame);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "FrmSnek";
			this.Text = "Snekkysnek McSneksnekface";
			this.tblPnlGame.ResumeLayout(false);
			this.PnlControl.ResumeLayout(false);
			this.PnlControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TbarTickRate)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private SnekPanel snekPanel;
        private System.Windows.Forms.TableLayoutPanel tblPnlGame;
        private System.Windows.Forms.Panel PnlControl;
        private System.Windows.Forms.Timer TmrFrameTick;
        private System.Windows.Forms.Button BtnStartStop;
		private System.Windows.Forms.Timer TmrMakeFud;
		private System.Windows.Forms.Label LblTickSpeed;
		private System.Windows.Forms.TrackBar TbarTickRate;
		private System.Windows.Forms.Label LblScoreCount;
	}
}

