using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Carriculums.MainWork;
using Carriculums.MainWork.PlanData;

namespace Carriculums.Forms
{
    public partial class MainForm
    {
        private WorkExcel workExcel;
        
        private Color darkBackground = Color.FromArgb(60, 65, 70);
        private Color lightBackground = Color.FromArgb(199, 208, 209);
        private Color darkPanel = Color.FromArgb(45, 50, 55);
        private Color lightPanel = Color.FromArgb(226, 230, 230);
        private Color darkSubPanel = Color.FromArgb(30, 35, 40);
        private Color lightSubPanel = Color.FromArgb(241, 241, 241);
        private Color defaultStatus = Color.DarkSlateBlue;
        
        public MainForm()
        {
            InitializeComponent();
            
            workExcel = new WorkExcel();
            
            MainMenu.Renderer = new MaterialDarkRenderer();
            statusColor.Renderer = new MaterialDesign();
            
            mainStatus.Items.Add(Kernel.Progress);
        }

        private void OpenMainEvent(object sender, EventArgs e)
        {
            statusLabel.Text = @"Открытие главной книги";
            
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                workExcel.FileMainName = openDialog.SafeFileName;
                workExcel.OpenMain(openDialog.FileName);
            }

            UpdateListMain();
            mainStatus.Items[0].Text = @"Готово";
        }

        private void OpenEvent(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                mainStatus.Items[0].Text = @"Загрузка данных...";
                
                workExcel.Open(openDialog.FileNames);

                UpdateListFiles();
                Kernel.WaitEnd();
                mainStatus.Items[0].Text = @"Готово";
            }
        }

        //private void SaveEvent(object sender, EventArgs e)
        //{
        //    workExcel.Save(listFiles.SelectedIndex);
        //}

        //private void SaveAsEvent(object sender, EventArgs e)
        //{
        //    if(listFiles.SelectedItem != null) workExcel.SaveAs(listFiles.SelectedIndex);
        //}

        private void CloseEvent(object sender, EventArgs e)
        {
            if (listFiles.SelectedItem != null)
            {
                if (MessageBox.Show("Sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    workExcel.Close(listFiles.SelectedIndex);
                }
            }
            
            MainTable.Items.Clear();
            UpdateListFiles();
        }

        private void CloseAllEvent(object sender, EventArgs e)
        {
            workExcel.CloseAll();
            UpdateListFiles();
        }

        private void ExitEvent(object sender, EventArgs e)
        {
            Close();
        }

        private void EditEvent(object sender, EventArgs e)
        {
            mainStatus.BackColor = Color.Chocolate;
            statusLabel.Text = @"Редактирование данных...";
            
            if(listFiles.SelectedItem != null) workExcel.Edit(listFiles.SelectedIndex);
            else
            {
                MessageBox.Show("Выберите план для редактирования");
            }

            UpdateEvent(sender, e);
            
            statusLabel.Text = @"Готово";
            mainStatus.BackColor = defaultStatus;
        }

        private void ImportEvent(object sender, EventArgs e)
        {
            Kernel.WaitStart(10);
            workExcel.Import(listFiles.SelectedIndex);
            Kernel.WaitEnd();
        }

        private void ImportToEvent(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                Kernel.WaitStart(10);
                workExcel.Import(listFiles.SelectedIndex, openDialog.FileName);
                Kernel.WaitEnd();   
            }
        }

        private void UpdateEvent(object sender, EventArgs e)
        {
            if (listFiles.SelectedItem != null)
            {
                MainTable.Items.Clear();
                workExcel.LoadToListView(MainTable, listFiles.SelectedIndex);
            }
        }

        private void UpdateListFiles()
        {
            listFiles.Items.Clear();
            foreach (Plan plan in workExcel.Plans)
            {
                listFiles.Items.Add(plan.FileName);
            }
        }

        private void UpdateListMain()
        {
            listMain.Items.Clear();
            if(workExcel.XlWorkbook != null) listMain.Items.Add(workExcel.FileMainName);
        }

        private void ShowTermsInfo(object sender, EventArgs e)
        {
            if(listFiles.SelectedItem != null)
                workExcel.ShowTermsInfo(listFiles.SelectedIndex);
        }

        private void lightColors_Click(object sender, EventArgs e)
        {
            mainSplitContainer.BackColor = lightBackground;
            tablePanelFiles.BackColor = lightPanel;
            filesButtonPanel.BackColor = lightSubPanel;
            mainBookPanel.BackColor = lightSubPanel;
            listFiles.BackColor = lightSubPanel;
            listFiles.ForeColor = darkSubPanel;
            statusFiles.BackColor = Color.FromArgb(0, 160, 100);
            statusFiles.BackColor = Color.FromArgb(0, 160, 100);
            statusStrip1.BackColor = Color.FromArgb(190, 215, 223);
            toolStripStatusLabel3.ForeColor = darkPanel;
            statusStrip2.BackColor = Color.FromArgb(190, 215, 223);
            toolStripStatusLabel4.ForeColor = darkPanel;
            foreach (Button btn in filesButtonPanel.Controls.OfType<Button>())
            {
                btn.ForeColor = darkPanel;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 164, 172);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 189, 198);
                btn.FlatAppearance.CheckedBackColor = Color.FromArgb(181, 203, 210);
            }
        }

        

        private void darkColors_Click(object sender, EventArgs e)
        {
            mainSplitContainer.BackColor = darkBackground;
            tablePanelFiles.BackColor = darkPanel;
            filesButtonPanel.BackColor = darkSubPanel;
            mainBookPanel.BackColor = darkSubPanel;
            listFiles.BackColor = darkSubPanel;
            listFiles.ForeColor = lightSubPanel;
            statusFiles.BackColor = SystemColors.Highlight;
            statusEdit.BackColor = SystemColors.Highlight;
            statusStrip1.BackColor = Color.FromArgb(60, 65, 70);
            toolStripStatusLabel3.ForeColor = lightPanel;
            statusStrip2.BackColor = Color.FromArgb(60, 65, 70);
            toolStripStatusLabel4.ForeColor = lightPanel;
            foreach (Button btn in filesButtonPanel.Controls.OfType<Button>())
            {
                btn.ForeColor = lightPanel;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
                btn.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
                btn.FlatAppearance.CheckedBackColor = Color.FromArgb(21, 74, 91);
            }
        }

        private void lightTable_Click(object sender, EventArgs e)
        {
            MainTable.BackColor = SystemColors.MenuBar;
            MainTable.ForeColor = SystemColors.WindowText;
            tablePanelEdit.BackColor = SystemColors.MenuBar;
        }

        private void darkTable_Click(object sender, EventArgs e)
        {
            MainTable.BackColor = darkPanel;
            MainTable.ForeColor = lightBackground;
            tablePanelEdit.BackColor = darkPanel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            workExcel.Exit();
        }
    }
}