using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriculums
{
    class MaterialDarkRenderer : System.Windows.Forms.ToolStripRenderer
    {
        private Color darkPanel = Color.FromArgb(45, 50, 55);
        private Color lightPanel = SystemColors.ScrollBar;

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            e.ToolStrip.ForeColor = lightPanel;
            e.ToolStrip.BackColor = darkPanel;
            base.OnRenderToolStripBackground(e);
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Item.ForeColor = lightPanel;
                e.Graphics.Clear(Color.DarkSlateBlue);
            }
            else
            {
                e.Item.ForeColor = lightPanel;
            }
            base.OnRenderMenuItemBackground(e);
        }

        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Item.ForeColor = lightPanel;
                e.Graphics.Clear(Color.DarkSlateBlue);
            }
            base.OnRenderDropDownButtonBackground(e);
        }



        protected override void OnRenderItemBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderItemBackground(e);
        }
    }
}
