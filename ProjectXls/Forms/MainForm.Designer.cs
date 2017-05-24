using System.Windows.Forms;
using Carriculums.MainWork;

namespace Carriculums.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.saveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planEditStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlanStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveEditStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelEditStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.subjectStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSubjStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tablePanelFiles = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenMainBook = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFiles = new System.Windows.Forms.StatusStrip();
            this.lblCatalog = new System.Windows.Forms.ToolStripStatusLabel();
            this.filesButtonPanel = new System.Windows.Forms.Panel();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.mainBookPanel = new System.Windows.Forms.Panel();
            this.listMain = new System.Windows.Forms.ListBox();
            this.tablePanelEdit = new System.Windows.Forms.TableLayoutPanel();
            this.statusEdit = new System.Windows.Forms.StatusStrip();
            this.lblTable = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileNameStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.planNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTable = new System.Windows.Forms.ListView();
            this.FolderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specialty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specialization = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paragraph = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Exams = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Credits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CalcGraphicWorks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Homeworks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tests = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseWorks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseProjects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Module = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutTools = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutTableTools = new System.Windows.Forms.TableLayoutPanel();
            this.statusColor = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lightColors = new System.Windows.Forms.ToolStripMenuItem();
            this.darkColors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.розподілГодинЗаЕместрамиТаКурсамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнаІнформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniToolStrip = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainStatus.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.tablePanelFiles.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusFiles.SuspendLayout();
            this.filesButtonPanel.SuspendLayout();
            this.mainBookPanel.SuspendLayout();
            this.tablePanelEdit.SuspendLayout();
            this.statusEdit.SuspendLayout();
            this.tableLayoutTools.SuspendLayout();
            this.tableLayoutTableTools.SuspendLayout();
            this.statusColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDialog
            // 
            this.openDialog.FileName = "Excel документ";
            this.openDialog.Filter = "Excel документ|*.xls; *xlsx|All files|*.*";
            this.openDialog.Multiselect = true;
            // 
            // mainStatus
            // 
            this.mainStatus.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.mainStatus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainStatus.Location = new System.Drawing.Point(0, 466);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.mainStatus.Size = new System.Drawing.Size(892, 22);
            this.mainStatus.SizingGrip = false;
            this.mainStatus.TabIndex = 17;
            this.mainStatus.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(38, 17);
            this.statusLabel.Text = "Готов";
            // 
            // progress
            // 
            this.progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progress.Margin = new System.Windows.Forms.Padding(1, 3, 50, 3);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(117, 21);
            this.progress.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.AutoSize = true;
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.MainMenu, 0, 0);
            this.tableLayoutMain.Controls.Add(this.mainSplitContainer, 0, 3);
            this.tableLayoutMain.Controls.Add(this.tableLayoutTools, 0, 1);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 4;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutMain.Size = new System.Drawing.Size(892, 466);
            this.tableLayoutMain.TabIndex = 21;
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.editStripMenuItem,
            this.aboutStripMenuItem,
            this.toolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.MainMenu.Size = new System.Drawing.Size(892, 20);
            this.MainMenu.TabIndex = 21;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator8,
            this.saveStripMenuItem,
            this.saveAsStripMenuItem,
            this.updateStripMenuItem,
            this.toolStripSeparator2,
            this.closeStripMenuItem,
            this.closeAllStripMenuItem,
            this.toolStripSeparator3,
            this.exitStripMenuItem});
            this.fileStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenEvent);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(167, 6);
            // 
            // saveStripMenuItem
            // 
            this.saveStripMenuItem.Enabled = false;
            this.saveStripMenuItem.Name = "saveStripMenuItem";
            this.saveStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saveStripMenuItem.Text = "Сохранить";
            // 
            // saveAsStripMenuItem
            // 
            this.saveAsStripMenuItem.Enabled = false;
            this.saveAsStripMenuItem.Name = "saveAsStripMenuItem";
            this.saveAsStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saveAsStripMenuItem.Text = "Сохранить как...";
            // 
            // updateStripMenuItem
            // 
            this.updateStripMenuItem.Name = "updateStripMenuItem";
            this.updateStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.updateStripMenuItem.Text = "Обновить";
            this.updateStripMenuItem.Click += new System.EventHandler(this.UpdateEvent);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // closeStripMenuItem
            // 
            this.closeStripMenuItem.Name = "closeStripMenuItem";
            this.closeStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.closeStripMenuItem.Text = "Закрыть";
            this.closeStripMenuItem.Click += new System.EventHandler(this.CloseEvent);
            // 
            // closeAllStripMenuItem
            // 
            this.closeAllStripMenuItem.Name = "closeAllStripMenuItem";
            this.closeAllStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.closeAllStripMenuItem.Text = "Закрыть все";
            this.closeAllStripMenuItem.Click += new System.EventHandler(this.CloseAllEvent);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitStripMenuItem.Text = "Выйти";
            this.exitStripMenuItem.Click += new System.EventHandler(this.ExitEvent);
            // 
            // editStripMenuItem
            // 
            this.editStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planEditStripMenuItem,
            this.toolStripSeparator4,
            this.saveEditStripMenuItem,
            this.cancelEditStripMenuItem,
            this.toolStripSeparator5,
            this.subjectStripMenuItem});
            this.editStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStripMenuItem.Name = "editStripMenuItem";
            this.editStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.editStripMenuItem.Text = "Правка";
            // 
            // planEditStripMenuItem
            // 
            this.planEditStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPlanStripMenuItem});
            this.planEditStripMenuItem.Name = "planEditStripMenuItem";
            this.planEditStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.planEditStripMenuItem.Text = "Учебный план";
            // 
            // editPlanStripMenuItem
            // 
            this.editPlanStripMenuItem.Name = "editPlanStripMenuItem";
            this.editPlanStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.editPlanStripMenuItem.Text = "Редактировать";
            this.editPlanStripMenuItem.Click += new System.EventHandler(this.EditEvent);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(203, 6);
            // 
            // saveEditStripMenuItem
            // 
            this.saveEditStripMenuItem.Enabled = false;
            this.saveEditStripMenuItem.Name = "saveEditStripMenuItem";
            this.saveEditStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.saveEditStripMenuItem.Text = "Сохранить изменения";
            // 
            // cancelEditStripMenuItem
            // 
            this.cancelEditStripMenuItem.Enabled = false;
            this.cancelEditStripMenuItem.Name = "cancelEditStripMenuItem";
            this.cancelEditStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cancelEditStripMenuItem.Text = "Отменить";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(203, 6);
            // 
            // subjectStripMenuItem
            // 
            this.subjectStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStripMenuItem,
            this.deleteStripMenuItem,
            this.editSubjStripMenuItem});
            this.subjectStripMenuItem.Enabled = false;
            this.subjectStripMenuItem.Name = "subjectStripMenuItem";
            this.subjectStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.subjectStripMenuItem.Text = "Дисциплины";
            // 
            // addStripMenuItem
            // 
            this.addStripMenuItem.Enabled = false;
            this.addStripMenuItem.Name = "addStripMenuItem";
            this.addStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addStripMenuItem.Text = "Добавить...";
            // 
            // deleteStripMenuItem
            // 
            this.deleteStripMenuItem.Enabled = false;
            this.deleteStripMenuItem.Name = "deleteStripMenuItem";
            this.deleteStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteStripMenuItem.Text = "Удалить...";
            // 
            // editSubjStripMenuItem
            // 
            this.editSubjStripMenuItem.Enabled = false;
            this.editSubjStripMenuItem.Name = "editSubjStripMenuItem";
            this.editSubjStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.editSubjStripMenuItem.Text = "Редактировать";
            // 
            // aboutStripMenuItem
            // 
            this.aboutStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutStripMenuItem.Name = "aboutStripMenuItem";
            this.aboutStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutStripMenuItem.Text = "Помощь";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.toolStripMenuItem.Text = "Настройки";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 55);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.tablePanelFiles);
            this.mainSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(13, 13, 5, 18);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.tablePanelEdit);
            this.mainSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5, 13, 13, 18);
            this.mainSplitContainer.Size = new System.Drawing.Size(892, 411);
            this.mainSplitContainer.SplitterDistance = 262;
            this.mainSplitContainer.SplitterWidth = 7;
            this.mainSplitContainer.TabIndex = 19;
            // 
            // tablePanelFiles
            // 
            this.tablePanelFiles.AutoSize = true;
            this.tablePanelFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.tablePanelFiles.ColumnCount = 1;
            this.tablePanelFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelFiles.Controls.Add(this.btnOpenMainBook, 0, 5);
            this.tablePanelFiles.Controls.Add(this.statusStrip2, 0, 3);
            this.tablePanelFiles.Controls.Add(this.statusStrip1, 0, 1);
            this.tablePanelFiles.Controls.Add(this.statusFiles, 0, 0);
            this.tablePanelFiles.Controls.Add(this.filesButtonPanel, 0, 2);
            this.tablePanelFiles.Controls.Add(this.mainBookPanel, 0, 4);
            this.tablePanelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelFiles.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tablePanelFiles.Location = new System.Drawing.Point(13, 13);
            this.tablePanelFiles.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanelFiles.Name = "tablePanelFiles";
            this.tablePanelFiles.RowCount = 6;
            this.tablePanelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tablePanelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tablePanelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tablePanelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tablePanelFiles.Size = new System.Drawing.Size(244, 380);
            this.tablePanelFiles.TabIndex = 0;
            // 
            // btnOpenMainBook
            // 
            this.btnOpenMainBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenMainBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnOpenMainBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenMainBook.FlatAppearance.BorderSize = 0;
            this.btnOpenMainBook.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenMainBook.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenMainBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMainBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenMainBook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenMainBook.Location = new System.Drawing.Point(5, 343);
            this.btnOpenMainBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btnOpenMainBook.MaximumSize = new System.Drawing.Size(0, 32);
            this.btnOpenMainBook.Name = "btnOpenMainBook";
            this.btnOpenMainBook.Size = new System.Drawing.Size(234, 32);
            this.btnOpenMainBook.TabIndex = 5;
            this.btnOpenMainBook.Text = "Открыть";
            this.btnOpenMainBook.UseVisualStyleBackColor = false;
            this.btnOpenMainBook.Click += new System.EventHandler(this.OpenMainEvent);
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4});
            this.statusStrip2.Location = new System.Drawing.Point(5, 269);
            this.statusStrip2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(234, 21);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(85, 16);
            this.toolStripStatusLabel4.Text = "Главная книга";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(5, 30);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(234, 20);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(95, 15);
            this.toolStripStatusLabel3.Text = "Учебные планы";
            // 
            // statusFiles
            // 
            this.statusFiles.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCatalog});
            this.statusFiles.Location = new System.Drawing.Point(0, 0);
            this.statusFiles.Name = "statusFiles";
            this.statusFiles.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusFiles.Size = new System.Drawing.Size(244, 20);
            this.statusFiles.SizingGrip = false;
            this.statusFiles.TabIndex = 1;
            this.statusFiles.Text = "statusStrip1";
            // 
            // lblCatalog
            // 
            this.lblCatalog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCatalog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCatalog.Name = "lblCatalog";
            this.lblCatalog.Size = new System.Drawing.Size(95, 15);
            this.lblCatalog.Text = "Каталог файлов";
            // 
            // filesButtonPanel
            // 
            this.filesButtonPanel.AutoScroll = true;
            this.filesButtonPanel.AutoSize = true;
            this.filesButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filesButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.filesButtonPanel.Controls.Add(this.listFiles);
            this.filesButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesButtonPanel.Location = new System.Drawing.Point(5, 50);
            this.filesButtonPanel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.filesButtonPanel.Name = "filesButtonPanel";
            this.filesButtonPanel.Size = new System.Drawing.Size(234, 209);
            this.filesButtonPanel.TabIndex = 2;
            // 
            // listFiles
            // 
            this.listFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.listFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 15;
            this.listFiles.Location = new System.Drawing.Point(0, 0);
            this.listFiles.Margin = new System.Windows.Forms.Padding(0);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(234, 209);
            this.listFiles.TabIndex = 0;
            this.listFiles.DoubleClick += new System.EventHandler(this.UpdateEvent);
            // 
            // mainBookPanel
            // 
            this.mainBookPanel.AutoSize = true;
            this.mainBookPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainBookPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.mainBookPanel.Controls.Add(this.listMain);
            this.mainBookPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBookPanel.Location = new System.Drawing.Point(5, 290);
            this.mainBookPanel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mainBookPanel.MaximumSize = new System.Drawing.Size(0, 53);
            this.mainBookPanel.Name = "mainBookPanel";
            this.mainBookPanel.Size = new System.Drawing.Size(234, 53);
            this.mainBookPanel.TabIndex = 3;
            // 
            // listMain
            // 
            this.listMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.listMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listMain.ForeColor = System.Drawing.SystemColors.Control;
            this.listMain.FormattingEnabled = true;
            this.listMain.ItemHeight = 15;
            this.listMain.Location = new System.Drawing.Point(0, 0);
            this.listMain.Margin = new System.Windows.Forms.Padding(0);
            this.listMain.MaximumSize = new System.Drawing.Size(0, 53);
            this.listMain.Name = "listMain";
            this.listMain.Size = new System.Drawing.Size(234, 53);
            this.listMain.TabIndex = 1;
            // 
            // tablePanelEdit
            // 
            this.tablePanelEdit.AutoSize = true;
            this.tablePanelEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanelEdit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tablePanelEdit.ColumnCount = 1;
            this.tablePanelEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelEdit.Controls.Add(this.statusEdit, 0, 0);
            this.tablePanelEdit.Controls.Add(this.MainTable, 0, 1);
            this.tablePanelEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelEdit.Location = new System.Drawing.Point(5, 13);
            this.tablePanelEdit.Name = "tablePanelEdit";
            this.tablePanelEdit.RowCount = 2;
            this.tablePanelEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelEdit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelEdit.Size = new System.Drawing.Size(605, 380);
            this.tablePanelEdit.TabIndex = 13;
            // 
            // statusEdit
            // 
            this.statusEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTable,
            this.fileNameStrip,
            this.planNumber});
            this.statusEdit.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusEdit.Location = new System.Drawing.Point(0, 0);
            this.statusEdit.Name = "statusEdit";
            this.statusEdit.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusEdit.Size = new System.Drawing.Size(605, 20);
            this.statusEdit.SizingGrip = false;
            this.statusEdit.TabIndex = 12;
            this.statusEdit.Text = "statusStrip1";
            // 
            // lblTable
            // 
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(57, 15);
            this.lblTable.Text = "Таблица:";
            // 
            // fileNameStrip
            // 
            this.fileNameStrip.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameStrip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileNameStrip.Margin = new System.Windows.Forms.Padding(40, 3, 0, 2);
            this.fileNameStrip.Name = "fileNameStrip";
            this.fileNameStrip.Size = new System.Drawing.Size(0, 15);
            this.fileNameStrip.ToolTipText = "Имя файла";
            // 
            // planNumber
            // 
            this.planNumber.Name = "planNumber";
            this.planNumber.Size = new System.Drawing.Size(0, 15);
            this.planNumber.Visible = false;
            // 
            // MainTable
            // 
            this.MainTable.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.MainTable.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.MainTable.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MainTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FolderName,
            this.Specialty,
            this.Specialization,
            this.Number,
            this.Paragraph,
            this.SubjectName,
            this.Exams,
            this.Credits,
            this.CalcGraphicWorks,
            this.Homeworks,
            this.Tests,
            this.CourseWorks,
            this.CourseProjects,
            this.Module,
            this.Amount});
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MainTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MainTable.HideSelection = false;
            this.MainTable.LabelEdit = true;
            this.MainTable.Location = new System.Drawing.Point(10, 30);
            this.MainTable.Margin = new System.Windows.Forms.Padding(10);
            this.MainTable.MultiSelect = false;
            this.MainTable.Name = "MainTable";
            this.MainTable.Size = new System.Drawing.Size(585, 340);
            this.MainTable.TabIndex = 11;
            this.MainTable.UseCompatibleStateImageBehavior = false;
            this.MainTable.View = System.Windows.Forms.View.Details;
            this.MainTable.SelectedIndexChanged += new System.EventHandler(this.MainTable_SelectedIndexChanged);
            // 
            // FolderName
            // 
            this.FolderName.Text = "Имя папки";
            this.FolderName.Width = 71;
            // 
            // Specialty
            // 
            this.Specialty.Text = "Сеціальність";
            this.Specialty.Width = 79;
            // 
            // Specialization
            // 
            this.Specialization.Text = "Спеціалізація";
            this.Specialization.Width = 82;
            // 
            // Number
            // 
            this.Number.Text = "Номер";
            this.Number.Width = 55;
            // 
            // Paragraph
            // 
            this.Paragraph.Text = "Пункт";
            this.Paragraph.Width = 47;
            // 
            // SubjectName
            // 
            this.SubjectName.Text = "Назва дисципліни";
            this.SubjectName.Width = 106;
            // 
            // Exams
            // 
            this.Exams.Text = "Іспити";
            this.Exams.Width = 48;
            // 
            // Credits
            // 
            this.Credits.Text = "Заліки";
            this.Credits.Width = 50;
            // 
            // CalcGraphicWorks
            // 
            this.CalcGraphicWorks.Text = "Розрахунково-графічні роботи";
            // 
            // Homeworks
            // 
            this.Homeworks.Text = "Домашні роботи";
            // 
            // Tests
            // 
            this.Tests.Text = "Контрольні роботи";
            // 
            // CourseWorks
            // 
            this.CourseWorks.Text = "Курсові роботи";
            // 
            // CourseProjects
            // 
            this.CourseProjects.Text = "Курсові проекти";
            // 
            // Module
            // 
            this.Module.Text = "Модуль";
            // 
            // Amount
            // 
            this.Amount.Text = "Всього";
            // 
            // tableLayoutTools
            // 
            this.tableLayoutTools.AutoSize = true;
            this.tableLayoutTools.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.tableLayoutTools.ColumnCount = 7;
            this.tableLayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412F));
            this.tableLayoutTools.Controls.Add(this.btnOpen, 0, 0);
            this.tableLayoutTools.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutTools.Controls.Add(this.btnEdit, 3, 0);
            this.tableLayoutTools.Controls.Add(this.btnUpload, 4, 0);
            this.tableLayoutTools.Controls.Add(this.btnClear, 5, 0);
            this.tableLayoutTools.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutTools.Controls.Add(this.tableLayoutTableTools, 6, 0);
            this.tableLayoutTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTools.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutTools.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutTools.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutTools.Name = "tableLayoutTools";
            this.tableLayoutTools.RowCount = 1;
            this.tableLayoutTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTools.Size = new System.Drawing.Size(892, 35);
            this.tableLayoutTools.TabIndex = 20;
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = true;
            this.btnOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(60)))));
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(0, 0);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(80, 35);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.OpenEvent);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(160, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseEvent);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(60)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(240, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 35);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Правка";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.EditEvent);
            // 
            // btnUpload
            // 
            this.btnUpload.AutoSize = true;
            this.btnUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(60)))));
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpload.Location = new System.Drawing.Point(320, 0);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(80, 35);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Загрузить";
            this.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.ImportEvent);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(60)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(400, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 35);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Обновить";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.UpdateEvent);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(60)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(80, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // tableLayoutTableTools
            // 
            this.tableLayoutTableTools.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutTableTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.tableLayoutTableTools.ColumnCount = 2;
            this.tableLayoutTableTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.23301F));
            this.tableLayoutTableTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.76699F));
            this.tableLayoutTableTools.Controls.Add(this.statusColor, 1, 0);
            this.tableLayoutTableTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTableTools.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutTableTools.Location = new System.Drawing.Point(480, 0);
            this.tableLayoutTableTools.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutTableTools.Name = "tableLayoutTableTools";
            this.tableLayoutTableTools.RowCount = 1;
            this.tableLayoutTableTools.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTableTools.Size = new System.Drawing.Size(412, 35);
            this.tableLayoutTableTools.TabIndex = 1;
            // 
            // statusColor
            // 
            this.statusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.statusColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1});
            this.statusColor.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusColor.Location = new System.Drawing.Point(70, 0);
            this.statusColor.Name = "statusColor";
            this.statusColor.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusColor.Size = new System.Drawing.Size(342, 35);
            this.statusColor.SizingGrip = false;
            this.statusColor.TabIndex = 0;
            this.statusColor.Text = "statusStrip3";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightColors,
            this.darkColors});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(48, 35);
            this.toolStripDropDownButton1.Text = "color";
            this.toolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lightColors
            // 
            this.lightColors.Name = "lightColors";
            this.lightColors.Size = new System.Drawing.Size(103, 22);
            this.lightColors.Text = "Light";
            this.lightColors.Click += new System.EventHandler(this.lightColors_Click);
            // 
            // darkColors
            // 
            this.darkColors.Name = "darkColors";
            this.darkColors.Size = new System.Drawing.Size(103, 22);
            this.darkColors.Text = "Dark";
            this.darkColors.Click += new System.EventHandler(this.darkColors_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розподілГодинЗаЕместрамиТаКурсамиToolStripMenuItem,
            this.основнаІнформаціяToolStripMenuItem});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(74, 35);
            this.toolStripSplitButton1.Text = "additional";
            this.toolStripSplitButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // розподілГодинЗаЕместрамиТаКурсамиToolStripMenuItem
            // 
            this.розподілГодинЗаЕместрамиТаКурсамиToolStripMenuItem.Name = "розподілГодинЗаЕместрамиТаКурсамиToolStripMenuItem";
            this.розподілГодинЗаЕместрамиТаКурсамиToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.розподілГодинЗаЕместрамиТаКурсамиToolStripMenuItem.Text = "Розподіл годин за курсами та семестрами";
            this.розподілГодинЗаЕместрамиТаКурсамиToolStripMenuItem.Click += new System.EventHandler(this.ShowTermsInfo);
            // 
            // основнаІнформаціяToolStripMenuItem
            // 
            this.основнаІнформаціяToolStripMenuItem.Name = "основнаІнформаціяToolStripMenuItem";
            this.основнаІнформаціяToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.основнаІнформаціяToolStripMenuItem.Text = "Основна інформація";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.miniToolStrip.Size = new System.Drawing.Size(562, 20);
            this.miniToolStrip.SizingGrip = false;
            this.miniToolStrip.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(892, 488);
            this.Controls.Add(this.tableLayoutMain);
            this.Controls.Add(this.mainStatus);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ProjectXls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.tablePanelFiles.ResumeLayout(false);
            this.tablePanelFiles.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusFiles.ResumeLayout(false);
            this.statusFiles.PerformLayout();
            this.filesButtonPanel.ResumeLayout(false);
            this.mainBookPanel.ResumeLayout(false);
            this.tablePanelEdit.ResumeLayout(false);
            this.tablePanelEdit.PerformLayout();
            this.statusEdit.ResumeLayout(false);
            this.statusEdit.PerformLayout();
            this.tableLayoutTools.ResumeLayout(false);
            this.tableLayoutTools.PerformLayout();
            this.tableLayoutTableTools.ResumeLayout(false);
            this.tableLayoutTableTools.PerformLayout();
            this.statusColor.ResumeLayout(false);
            this.statusColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private Button button1;
        private TableLayoutPanel tableLayoutMain;
        private SplitContainer mainSplitContainer;
        private TableLayoutPanel tablePanelFiles;
        private Panel filesButtonPanel;
        private TableLayoutPanel tablePanelEdit;
        private StatusStrip statusEdit;
        private ToolStripStatusLabel lblTable;
        private ToolStripStatusLabel fileNameStrip;
        private ToolStripStatusLabel planNumber;
        private ListView MainTable;
        private ColumnHeader FolderName;
        private ColumnHeader Specialty;
        private ColumnHeader Specialization;
        private ColumnHeader Number;
        private ColumnHeader Paragraph;
        private ColumnHeader SubjectName;
        private StatusStrip miniToolStrip;
        private TableLayoutPanel tableLayoutTools;
        private Button btnOpen;
        private Button btnClose;
        private Button btnEdit;
        private Button btnUpload;
        private Button btnClear;
        private Button btnSave;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private StatusStrip statusFiles;
        private ToolStripStatusLabel lblCatalog;
        private Panel mainBookPanel;
        private TableLayoutPanel tableLayoutTableTools;
        private MenuStrip MainMenu;
        private ToolStripMenuItem fileStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem saveStripMenuItem;
        private ToolStripMenuItem saveAsStripMenuItem;
        private ToolStripMenuItem updateStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem closeStripMenuItem;
        private ToolStripMenuItem closeAllStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitStripMenuItem;
        private ToolStripMenuItem editStripMenuItem;
        private ToolStripMenuItem planEditStripMenuItem;
        private ToolStripMenuItem editPlanStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem saveEditStripMenuItem;
        private ToolStripMenuItem cancelEditStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem subjectStripMenuItem;
        private ToolStripMenuItem addStripMenuItem;
        private ToolStripMenuItem deleteStripMenuItem;
        private ToolStripMenuItem editSubjStripMenuItem;
        private ToolStripMenuItem aboutStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem;
        private StatusStrip statusColor;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem lightColors;
        private ToolStripMenuItem darkColors;
        private Timer timer1;
        private ListBox listFiles;
        private ColumnHeader Exams;
        private ColumnHeader Credits;
        private ColumnHeader CalcGraphicWorks;
        private ColumnHeader Homeworks;
        private ColumnHeader Tests;
        private ColumnHeader CourseWorks;
        private ColumnHeader CourseProjects;
        private ColumnHeader Module;
        private ColumnHeader Amount;
        private ToolStripDropDownButton toolStripSplitButton1;
        private ToolStripMenuItem розподілГодинЗаЕместрамиТаКурсамиToolStripMenuItem;
        private ToolStripMenuItem основнаІнформаціяToolStripMenuItem;
        private ListBox listMain;
        private Button btnOpenMainBook;
    }
}