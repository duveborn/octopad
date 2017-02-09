using System.Drawing;
using System.Windows.Forms;

namespace OctoPad.WinForms.Controls
{
    public class DoubleBufferedTreeView : TreeView
    {
        public DoubleBufferedTreeView()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
    }
}
