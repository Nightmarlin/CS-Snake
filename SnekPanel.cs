using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek {
    class SnekPanel : System.Windows.Forms.Panel {
        public SnekPanel() : base() {
            this.SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer | System.Windows.Forms.ControlStyles.ResizeRedraw, true);
        }
    }
}
