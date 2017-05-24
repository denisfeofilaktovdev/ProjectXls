using System.Windows.Forms;

namespace Carriculums.MainWork
{
    public static class Kernel
    {
        //static WaitForm _wait = new WaitForm();

        public static ToolStripProgressBar Progress = new ToolStripProgressBar()
        {
            Alignment = ToolStripItemAlignment.Right,
            Margin = new Padding(1, 3, 50, 3),
            Name = "progress",
            Size = new System.Drawing.Size(117, 21),
            Visible = false
        };

        public static void WaitStart(int max)
        {
            if (max > 0)
            {
                Progress.Maximum = max;
                Progress.Visible = true;
            }
            else
            {
                Progress.Maximum = 0;
                Progress.Visible = true;
            }
        }

        public static void WaitPrint(string text)
        {
            if(Progress.Value != Progress.Maximum) Progress.Value += 1;
        }

        public static void WaitEnd()
        {
            Progress.Value = 0;
            Progress.Visible = false;
        }
    }
}
