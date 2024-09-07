namespace Azmoon_System
{
    partial class FrmBackup
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.GrpSelectAction = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.RdbBackup = new System.Windows.Forms.RadioButton();
            this.RdbRestore = new System.Windows.Forms.RadioButton();
            this.GrpReastor = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BtnSelectBackup = new DevComponents.DotNetBar.ButtonX();
            this.BtnRestore = new DevComponents.DotNetBar.ButtonX();
            this.txtSelectBackup = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.GrpBackup = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BtnCancelBackup = new DevComponents.DotNetBar.ButtonX();
            this.BtnBackup = new DevComponents.DotNetBar.ButtonX();
            this.BtnSelect = new DevComponents.DotNetBar.ButtonX();
            this.TxtBackupName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtSelectPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupPanel1.SuspendLayout();
            this.GrpSelectAction.SuspendLayout();
            this.GrpReastor.SuspendLayout();
            this.GrpBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.GrpSelectAction);
            this.groupPanel1.Controls.Add(this.GrpReastor);
            this.groupPanel1.Controls.Add(this.GrpBackup);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(766, 394);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // GrpSelectAction
            // 
            this.GrpSelectAction.BackColor = System.Drawing.Color.Transparent;
            this.GrpSelectAction.CanvasColor = System.Drawing.SystemColors.Control;
            this.GrpSelectAction.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GrpSelectAction.Controls.Add(this.RdbBackup);
            this.GrpSelectAction.Controls.Add(this.RdbRestore);
            this.GrpSelectAction.DisabledBackColor = System.Drawing.Color.Empty;
            this.GrpSelectAction.Location = new System.Drawing.Point(3, 3);
            this.GrpSelectAction.Name = "GrpSelectAction";
            this.GrpSelectAction.Size = new System.Drawing.Size(754, 62);
            // 
            // 
            // 
            this.GrpSelectAction.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GrpSelectAction.Style.BackColorGradientAngle = 90;
            this.GrpSelectAction.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GrpSelectAction.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpSelectAction.Style.BorderBottomWidth = 1;
            this.GrpSelectAction.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GrpSelectAction.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpSelectAction.Style.BorderLeftWidth = 1;
            this.GrpSelectAction.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpSelectAction.Style.BorderRightWidth = 1;
            this.GrpSelectAction.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpSelectAction.Style.BorderTopWidth = 1;
            this.GrpSelectAction.Style.CornerDiameter = 4;
            this.GrpSelectAction.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GrpSelectAction.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GrpSelectAction.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GrpSelectAction.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GrpSelectAction.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GrpSelectAction.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GrpSelectAction.TabIndex = 3;
            // 
            // RdbBackup
            // 
            this.RdbBackup.AutoSize = true;
            this.RdbBackup.Checked = true;
            this.RdbBackup.Location = new System.Drawing.Point(423, 16);
            this.RdbBackup.Name = "RdbBackup";
            this.RdbBackup.Size = new System.Drawing.Size(94, 18);
            this.RdbBackup.TabIndex = 0;
            this.RdbBackup.TabStop = true;
            this.RdbBackup.Text = "پشتیبان گیری";
            this.RdbBackup.UseVisualStyleBackColor = true;
            this.RdbBackup.CheckedChanged += new System.EventHandler(this.RdbBackup_CheckedChanged);
            // 
            // RdbRestore
            // 
            this.RdbRestore.AutoSize = true;
            this.RdbRestore.Location = new System.Drawing.Point(169, 16);
            this.RdbRestore.Name = "RdbRestore";
            this.RdbRestore.Size = new System.Drawing.Size(103, 18);
            this.RdbRestore.TabIndex = 1;
            this.RdbRestore.Text = "بازیابی اطلاعات";
            this.RdbRestore.UseVisualStyleBackColor = true;
            this.RdbRestore.CheckedChanged += new System.EventHandler(this.RdbRestore_CheckedChanged);
            // 
            // GrpReastor
            // 
            this.GrpReastor.BackColor = System.Drawing.Color.Transparent;
            this.GrpReastor.CanvasColor = System.Drawing.SystemColors.Control;
            this.GrpReastor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GrpReastor.Controls.Add(this.BtnSelectBackup);
            this.GrpReastor.Controls.Add(this.BtnRestore);
            this.GrpReastor.Controls.Add(this.txtSelectBackup);
            this.GrpReastor.Controls.Add(this.label3);
            this.GrpReastor.DisabledBackColor = System.Drawing.Color.Empty;
            this.GrpReastor.Location = new System.Drawing.Point(3, 228);
            this.GrpReastor.Name = "GrpReastor";
            this.GrpReastor.Size = new System.Drawing.Size(754, 157);
            // 
            // 
            // 
            this.GrpReastor.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GrpReastor.Style.BackColorGradientAngle = 90;
            this.GrpReastor.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GrpReastor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpReastor.Style.BorderBottomWidth = 1;
            this.GrpReastor.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GrpReastor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpReastor.Style.BorderLeftWidth = 1;
            this.GrpReastor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpReastor.Style.BorderRightWidth = 1;
            this.GrpReastor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpReastor.Style.BorderTopWidth = 1;
            this.GrpReastor.Style.CornerDiameter = 4;
            this.GrpReastor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GrpReastor.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GrpReastor.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GrpReastor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GrpReastor.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GrpReastor.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GrpReastor.TabIndex = 2;
            // 
            // BtnSelectBackup
            // 
            this.BtnSelectBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSelectBackup.Checked = true;
            this.BtnSelectBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSelectBackup.Location = new System.Drawing.Point(97, 39);
            this.BtnSelectBackup.Name = "BtnSelectBackup";
            this.BtnSelectBackup.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnSelectBackup.Size = new System.Drawing.Size(35, 23);
            this.BtnSelectBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSelectBackup.TabIndex = 7;
            this.BtnSelectBackup.Text = "...";
            this.BtnSelectBackup.Click += new System.EventHandler(this.BtnSelectBackup_Click);
            // 
            // BtnRestore
            // 
            this.BtnRestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnRestore.Checked = true;
            this.BtnRestore.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.BtnRestore.Location = new System.Drawing.Point(297, 95);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.BtnRestore.Size = new System.Drawing.Size(106, 28);
            this.BtnRestore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnRestore.TabIndex = 6;
            this.BtnRestore.Text = "بازیابی اطلاعات";
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // txtSelectBackup
            // 
            // 
            // 
            // 
            this.txtSelectBackup.Border.Class = "TextBoxBorder";
            this.txtSelectBackup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSelectBackup.Enabled = false;
            this.txtSelectBackup.Location = new System.Drawing.Point(151, 41);
            this.txtSelectBackup.Name = "txtSelectBackup";
            this.txtSelectBackup.PreventEnterBeep = true;
            this.txtSelectBackup.Size = new System.Drawing.Size(389, 22);
            this.txtSelectBackup.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "مسیر فایل پشتیبان :";
            // 
            // GrpBackup
            // 
            this.GrpBackup.BackColor = System.Drawing.Color.Transparent;
            this.GrpBackup.CanvasColor = System.Drawing.SystemColors.Control;
            this.GrpBackup.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GrpBackup.Controls.Add(this.BtnCancelBackup);
            this.GrpBackup.Controls.Add(this.BtnBackup);
            this.GrpBackup.Controls.Add(this.BtnSelect);
            this.GrpBackup.Controls.Add(this.TxtBackupName);
            this.GrpBackup.Controls.Add(this.TxtSelectPath);
            this.GrpBackup.Controls.Add(this.label2);
            this.GrpBackup.Controls.Add(this.label1);
            this.GrpBackup.DisabledBackColor = System.Drawing.Color.Empty;
            this.GrpBackup.Location = new System.Drawing.Point(3, 71);
            this.GrpBackup.Name = "GrpBackup";
            this.GrpBackup.Size = new System.Drawing.Size(754, 151);
            // 
            // 
            // 
            this.GrpBackup.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GrpBackup.Style.BackColorGradientAngle = 90;
            this.GrpBackup.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GrpBackup.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpBackup.Style.BorderBottomWidth = 1;
            this.GrpBackup.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GrpBackup.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpBackup.Style.BorderLeftWidth = 1;
            this.GrpBackup.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpBackup.Style.BorderRightWidth = 1;
            this.GrpBackup.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpBackup.Style.BorderTopWidth = 1;
            this.GrpBackup.Style.CornerDiameter = 4;
            this.GrpBackup.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GrpBackup.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GrpBackup.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GrpBackup.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GrpBackup.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GrpBackup.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GrpBackup.TabIndex = 1;
            // 
            // BtnCancelBackup
            // 
            this.BtnCancelBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnCancelBackup.Checked = true;
            this.BtnCancelBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.BtnCancelBackup.Location = new System.Drawing.Point(169, 100);
            this.BtnCancelBackup.Name = "BtnCancelBackup";
            this.BtnCancelBackup.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.BtnCancelBackup.Size = new System.Drawing.Size(106, 28);
            this.BtnCancelBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnCancelBackup.TabIndex = 6;
            this.BtnCancelBackup.Text = "توقف";
            this.BtnCancelBackup.Click += new System.EventHandler(this.BtnCancelBackup_Click);
            // 
            // BtnBackup
            // 
            this.BtnBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnBackup.Checked = true;
            this.BtnBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.BtnBackup.Location = new System.Drawing.Point(411, 100);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.BtnBackup.Size = new System.Drawing.Size(106, 28);
            this.BtnBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnBackup.TabIndex = 5;
            this.BtnBackup.Text = "پشتیبان گیری";
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSelect.Checked = true;
            this.BtnSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSelect.Location = new System.Drawing.Point(97, 17);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnSelect.Size = new System.Drawing.Size(35, 23);
            this.BtnSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSelect.TabIndex = 4;
            this.BtnSelect.Text = "...";
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // TxtBackupName
            // 
            // 
            // 
            // 
            this.TxtBackupName.Border.Class = "TextBoxBorder";
            this.TxtBackupName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtBackupName.Location = new System.Drawing.Point(151, 58);
            this.TxtBackupName.MaxLength = 40;
            this.TxtBackupName.Name = "TxtBackupName";
            this.TxtBackupName.PreventEnterBeep = true;
            this.TxtBackupName.Size = new System.Drawing.Size(389, 22);
            this.TxtBackupName.TabIndex = 3;
            // 
            // TxtSelectPath
            // 
            // 
            // 
            // 
            this.TxtSelectPath.Border.Class = "TextBoxBorder";
            this.TxtSelectPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtSelectPath.Enabled = false;
            this.TxtSelectPath.Location = new System.Drawing.Point(151, 18);
            this.TxtSelectPath.Name = "TxtSelectPath";
            this.TxtSelectPath.PreventEnterBeep = true;
            this.TxtSelectPath.Size = new System.Drawing.Size(389, 22);
            this.TxtSelectPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام فایل پشتیبان :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "مسیر ذخیره فایل پشتیبان :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 394);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پشتیبان گیری و بازیابی اطلاعات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBackup_FormClosing);
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.groupPanel1.ResumeLayout(false);
            this.GrpSelectAction.ResumeLayout(false);
            this.GrpSelectAction.PerformLayout();
            this.GrpReastor.ResumeLayout(false);
            this.GrpReastor.PerformLayout();
            this.GrpBackup.ResumeLayout(false);
            this.GrpBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel GrpSelectAction;
        private System.Windows.Forms.RadioButton RdbBackup;
        private System.Windows.Forms.RadioButton RdbRestore;
        private DevComponents.DotNetBar.Controls.GroupPanel GrpReastor;
        private DevComponents.DotNetBar.Controls.GroupPanel GrpBackup;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtBackupName;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtSelectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevComponents.DotNetBar.ButtonX BtnSelect;
        private DevComponents.DotNetBar.ButtonX BtnCancelBackup;
        private DevComponents.DotNetBar.ButtonX BtnBackup;
        private DevComponents.DotNetBar.ButtonX BtnSelectBackup;
        private DevComponents.DotNetBar.ButtonX BtnRestore;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSelectBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}