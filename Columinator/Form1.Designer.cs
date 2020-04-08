namespace Columinator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.numericUpDownValCol = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColIgnore = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStrIgnore = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxSplitter = new System.Windows.Forms.GroupBox();
            this.textBoxChars = new System.Windows.Forms.TextBox();
            this.checkBoxOther = new System.Windows.Forms.CheckBox();
            this.checkBoxTab = new System.Windows.Forms.CheckBox();
            this.checkBoxSpace = new System.Windows.Forms.CheckBox();
            this.buttonInBrowse = new System.Windows.Forms.Button();
            this.textBoxInPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.groupBoxOutSplitter = new System.Windows.Forms.GroupBox();
            this.radioButtonOutOther = new System.Windows.Forms.RadioButton();
            this.radioButtonOutTab = new System.Windows.Forms.RadioButton();
            this.radioButtonOutSpace = new System.Windows.Forms.RadioButton();
            this.textBoxOutSplitter = new System.Windows.Forms.TextBox();
            this.buttonExe = new System.Windows.Forms.Button();
            this.numericUpDownCol = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxOutName = new System.Windows.Forms.GroupBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.radioButtonNewName = new System.Windows.Forms.RadioButton();
            this.radioButtonOldName = new System.Windows.Forms.RadioButton();
            this.groupBoxOutDirectory = new System.Windows.Forms.GroupBox();
            this.buttonSelDir = new System.Windows.Forms.Button();
            this.textBoxselDir = new System.Windows.Forms.TextBox();
            this.radioButtonSelDir = new System.Windows.Forms.RadioButton();
            this.radioButtonAppDir = new System.Windows.Forms.RadioButton();
            this.radioButtonInFileDir = new System.Windows.Forms.RadioButton();
            this.openFileDialogIn = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogOut = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColIgnore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrIgnore)).BeginInit();
            this.groupBoxSplitter.SuspendLayout();
            this.groupBoxOut.SuspendLayout();
            this.groupBoxOutSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCol)).BeginInit();
            this.groupBoxOutName.SuspendLayout();
            this.groupBoxOutDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Controls.Add(this.numericUpDownValCol);
            this.groupBoxIn.Controls.Add(this.numericUpDownColIgnore);
            this.groupBoxIn.Controls.Add(this.numericUpDownStrIgnore);
            this.groupBoxIn.Controls.Add(this.label5);
            this.groupBoxIn.Controls.Add(this.label4);
            this.groupBoxIn.Controls.Add(this.label3);
            this.groupBoxIn.Controls.Add(this.groupBoxSplitter);
            this.groupBoxIn.Controls.Add(this.buttonInBrowse);
            this.groupBoxIn.Controls.Add(this.textBoxInPath);
            this.groupBoxIn.Controls.Add(this.label1);
            this.groupBoxIn.Location = new System.Drawing.Point(13, 13);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(275, 437);
            this.groupBoxIn.TabIndex = 0;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "Input";
            // 
            // numericUpDownValCol
            // 
            this.numericUpDownValCol.Location = new System.Drawing.Point(119, 265);
            this.numericUpDownValCol.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownValCol.Name = "numericUpDownValCol";
            this.numericUpDownValCol.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownValCol.TabIndex = 9;
            this.numericUpDownValCol.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDownColIgnore
            // 
            this.numericUpDownColIgnore.Location = new System.Drawing.Point(119, 239);
            this.numericUpDownColIgnore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColIgnore.Name = "numericUpDownColIgnore";
            this.numericUpDownColIgnore.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownColIgnore.TabIndex = 8;
            this.numericUpDownColIgnore.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownStrIgnore
            // 
            this.numericUpDownStrIgnore.Location = new System.Drawing.Point(119, 213);
            this.numericUpDownStrIgnore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStrIgnore.Name = "numericUpDownStrIgnore";
            this.numericUpDownStrIgnore.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownStrIgnore.TabIndex = 7;
            this.numericUpDownStrIgnore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Value columns:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Columns to ignore:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "String to ignore:";
            // 
            // groupBoxSplitter
            // 
            this.groupBoxSplitter.Controls.Add(this.textBoxChars);
            this.groupBoxSplitter.Controls.Add(this.checkBoxOther);
            this.groupBoxSplitter.Controls.Add(this.checkBoxTab);
            this.groupBoxSplitter.Controls.Add(this.checkBoxSpace);
            this.groupBoxSplitter.Location = new System.Drawing.Point(10, 79);
            this.groupBoxSplitter.Name = "groupBoxSplitter";
            this.groupBoxSplitter.Size = new System.Drawing.Size(258, 122);
            this.groupBoxSplitter.TabIndex = 3;
            this.groupBoxSplitter.TabStop = false;
            this.groupBoxSplitter.Text = "Splitter";
            // 
            // textBoxChars
            // 
            this.textBoxChars.Enabled = false;
            this.textBoxChars.Location = new System.Drawing.Point(7, 92);
            this.textBoxChars.Name = "textBoxChars";
            this.textBoxChars.Size = new System.Drawing.Size(170, 20);
            this.textBoxChars.TabIndex = 3;
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.AutoSize = true;
            this.checkBoxOther.Enabled = false;
            this.checkBoxOther.Location = new System.Drawing.Point(7, 68);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.Size = new System.Drawing.Size(194, 17);
            this.checkBoxOther.TabIndex = 2;
            this.checkBoxOther.Text = "Other (insert space between chars):";
            this.checkBoxOther.UseVisualStyleBackColor = true;
            this.checkBoxOther.CheckedChanged += new System.EventHandler(this.checkBoxOther_CheckedChanged);
            // 
            // checkBoxTab
            // 
            this.checkBoxTab.AutoSize = true;
            this.checkBoxTab.Checked = true;
            this.checkBoxTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTab.Location = new System.Drawing.Point(7, 44);
            this.checkBoxTab.Name = "checkBoxTab";
            this.checkBoxTab.Size = new System.Drawing.Size(45, 17);
            this.checkBoxTab.TabIndex = 1;
            this.checkBoxTab.Text = "Tab";
            this.checkBoxTab.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpace
            // 
            this.checkBoxSpace.AutoSize = true;
            this.checkBoxSpace.Location = new System.Drawing.Point(7, 20);
            this.checkBoxSpace.Name = "checkBoxSpace";
            this.checkBoxSpace.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSpace.TabIndex = 0;
            this.checkBoxSpace.Text = "Space";
            this.checkBoxSpace.UseVisualStyleBackColor = true;
            // 
            // buttonInBrowse
            // 
            this.buttonInBrowse.Location = new System.Drawing.Point(193, 36);
            this.buttonInBrowse.Name = "buttonInBrowse";
            this.buttonInBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonInBrowse.TabIndex = 2;
            this.buttonInBrowse.Text = "Browse";
            this.buttonInBrowse.UseVisualStyleBackColor = true;
            this.buttonInBrowse.Click += new System.EventHandler(this.buttonInBrowse_Click);
            // 
            // textBoxInPath
            // 
            this.textBoxInPath.Location = new System.Drawing.Point(10, 37);
            this.textBoxInPath.Name = "textBoxInPath";
            this.textBoxInPath.Size = new System.Drawing.Size(177, 20);
            this.textBoxInPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filepath:";
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Controls.Add(this.groupBoxOutSplitter);
            this.groupBoxOut.Controls.Add(this.buttonExe);
            this.groupBoxOut.Controls.Add(this.numericUpDownCol);
            this.groupBoxOut.Controls.Add(this.label2);
            this.groupBoxOut.Controls.Add(this.groupBoxOutName);
            this.groupBoxOut.Controls.Add(this.groupBoxOutDirectory);
            this.groupBoxOut.Location = new System.Drawing.Point(297, 13);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(275, 437);
            this.groupBoxOut.TabIndex = 1;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Output";
            // 
            // groupBoxOutSplitter
            // 
            this.groupBoxOutSplitter.Controls.Add(this.radioButtonOutOther);
            this.groupBoxOutSplitter.Controls.Add(this.radioButtonOutTab);
            this.groupBoxOutSplitter.Controls.Add(this.radioButtonOutSpace);
            this.groupBoxOutSplitter.Controls.Add(this.textBoxOutSplitter);
            this.groupBoxOutSplitter.Location = new System.Drawing.Point(7, 280);
            this.groupBoxOutSplitter.Name = "groupBoxOutSplitter";
            this.groupBoxOutSplitter.Size = new System.Drawing.Size(258, 122);
            this.groupBoxOutSplitter.TabIndex = 5;
            this.groupBoxOutSplitter.TabStop = false;
            this.groupBoxOutSplitter.Text = "Splitter";
            // 
            // radioButtonOutOther
            // 
            this.radioButtonOutOther.AutoSize = true;
            this.radioButtonOutOther.Enabled = false;
            this.radioButtonOutOther.Location = new System.Drawing.Point(7, 68);
            this.radioButtonOutOther.Name = "radioButtonOutOther";
            this.radioButtonOutOther.Size = new System.Drawing.Size(90, 17);
            this.radioButtonOutOther.TabIndex = 6;
            this.radioButtonOutOther.Text = "Other (1 char)";
            this.radioButtonOutOther.UseVisualStyleBackColor = true;
            this.radioButtonOutOther.CheckedChanged += new System.EventHandler(this.radioButtonOutOther_CheckedChanged);
            // 
            // radioButtonOutTab
            // 
            this.radioButtonOutTab.AutoSize = true;
            this.radioButtonOutTab.Checked = true;
            this.radioButtonOutTab.Location = new System.Drawing.Point(7, 44);
            this.radioButtonOutTab.Name = "radioButtonOutTab";
            this.radioButtonOutTab.Size = new System.Drawing.Size(44, 17);
            this.radioButtonOutTab.TabIndex = 5;
            this.radioButtonOutTab.TabStop = true;
            this.radioButtonOutTab.Text = "Tab";
            this.radioButtonOutTab.UseVisualStyleBackColor = true;
            // 
            // radioButtonOutSpace
            // 
            this.radioButtonOutSpace.AutoSize = true;
            this.radioButtonOutSpace.Location = new System.Drawing.Point(7, 20);
            this.radioButtonOutSpace.Name = "radioButtonOutSpace";
            this.radioButtonOutSpace.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOutSpace.TabIndex = 4;
            this.radioButtonOutSpace.Text = "Space";
            this.radioButtonOutSpace.UseVisualStyleBackColor = true;
            // 
            // textBoxOutSplitter
            // 
            this.textBoxOutSplitter.Enabled = false;
            this.textBoxOutSplitter.Location = new System.Drawing.Point(7, 92);
            this.textBoxOutSplitter.Name = "textBoxOutSplitter";
            this.textBoxOutSplitter.Size = new System.Drawing.Size(170, 20);
            this.textBoxOutSplitter.TabIndex = 3;
            // 
            // buttonExe
            // 
            this.buttonExe.Location = new System.Drawing.Point(188, 408);
            this.buttonExe.Name = "buttonExe";
            this.buttonExe.Size = new System.Drawing.Size(75, 23);
            this.buttonExe.TabIndex = 4;
            this.buttonExe.Text = "Execute";
            this.buttonExe.UseVisualStyleBackColor = true;
            this.buttonExe.Click += new System.EventHandler(this.buttonExe_Click);
            // 
            // numericUpDownCol
            // 
            this.numericUpDownCol.Location = new System.Drawing.Point(114, 252);
            this.numericUpDownCol.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCol.Name = "numericUpDownCol";
            this.numericUpDownCol.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownCol.TabIndex = 3;
            this.numericUpDownCol.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of columns:";
            // 
            // groupBoxOutName
            // 
            this.groupBoxOutName.Controls.Add(this.textBoxNewName);
            this.groupBoxOutName.Controls.Add(this.radioButtonNewName);
            this.groupBoxOutName.Controls.Add(this.radioButtonOldName);
            this.groupBoxOutName.Location = new System.Drawing.Point(7, 147);
            this.groupBoxOutName.Name = "groupBoxOutName";
            this.groupBoxOutName.Size = new System.Drawing.Size(262, 100);
            this.groupBoxOutName.TabIndex = 1;
            this.groupBoxOutName.TabStop = false;
            this.groupBoxOutName.Text = "Output file name";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Enabled = false;
            this.textBoxNewName.Location = new System.Drawing.Point(7, 68);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(168, 20);
            this.textBoxNewName.TabIndex = 2;
            // 
            // radioButtonNewName
            // 
            this.radioButtonNewName.AutoSize = true;
            this.radioButtonNewName.Location = new System.Drawing.Point(7, 44);
            this.radioButtonNewName.Name = "radioButtonNewName";
            this.radioButtonNewName.Size = new System.Drawing.Size(76, 17);
            this.radioButtonNewName.TabIndex = 1;
            this.radioButtonNewName.Text = "New name";
            this.radioButtonNewName.UseVisualStyleBackColor = true;
            this.radioButtonNewName.CheckedChanged += new System.EventHandler(this.radioButtonNewName_CheckedChanged);
            // 
            // radioButtonOldName
            // 
            this.radioButtonOldName.AutoSize = true;
            this.radioButtonOldName.Checked = true;
            this.radioButtonOldName.Location = new System.Drawing.Point(7, 20);
            this.radioButtonOldName.Name = "radioButtonOldName";
            this.radioButtonOldName.Size = new System.Drawing.Size(94, 17);
            this.radioButtonOldName.TabIndex = 0;
            this.radioButtonOldName.TabStop = true;
            this.radioButtonOldName.Text = "Input file name";
            this.radioButtonOldName.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutDirectory
            // 
            this.groupBoxOutDirectory.Controls.Add(this.buttonSelDir);
            this.groupBoxOutDirectory.Controls.Add(this.textBoxselDir);
            this.groupBoxOutDirectory.Controls.Add(this.radioButtonSelDir);
            this.groupBoxOutDirectory.Controls.Add(this.radioButtonAppDir);
            this.groupBoxOutDirectory.Controls.Add(this.radioButtonInFileDir);
            this.groupBoxOutDirectory.Location = new System.Drawing.Point(7, 20);
            this.groupBoxOutDirectory.Name = "groupBoxOutDirectory";
            this.groupBoxOutDirectory.Size = new System.Drawing.Size(262, 120);
            this.groupBoxOutDirectory.TabIndex = 0;
            this.groupBoxOutDirectory.TabStop = false;
            this.groupBoxOutDirectory.Text = "Destination directory";
            // 
            // buttonSelDir
            // 
            this.buttonSelDir.Enabled = false;
            this.buttonSelDir.Location = new System.Drawing.Point(181, 91);
            this.buttonSelDir.Name = "buttonSelDir";
            this.buttonSelDir.Size = new System.Drawing.Size(75, 23);
            this.buttonSelDir.TabIndex = 4;
            this.buttonSelDir.Text = "Browse";
            this.buttonSelDir.UseVisualStyleBackColor = true;
            this.buttonSelDir.Click += new System.EventHandler(this.buttonSelDir_Click);
            // 
            // textBoxselDir
            // 
            this.textBoxselDir.Enabled = false;
            this.textBoxselDir.Location = new System.Drawing.Point(7, 93);
            this.textBoxselDir.Name = "textBoxselDir";
            this.textBoxselDir.Size = new System.Drawing.Size(168, 20);
            this.textBoxselDir.TabIndex = 3;
            // 
            // radioButtonSelDir
            // 
            this.radioButtonSelDir.AutoSize = true;
            this.radioButtonSelDir.Location = new System.Drawing.Point(7, 69);
            this.radioButtonSelDir.Name = "radioButtonSelDir";
            this.radioButtonSelDir.Size = new System.Drawing.Size(98, 17);
            this.radioButtonSelDir.TabIndex = 2;
            this.radioButtonSelDir.Text = "Select directory";
            this.radioButtonSelDir.UseVisualStyleBackColor = true;
            this.radioButtonSelDir.CheckedChanged += new System.EventHandler(this.radioButtonSelDir_CheckedChanged);
            // 
            // radioButtonAppDir
            // 
            this.radioButtonAppDir.AutoSize = true;
            this.radioButtonAppDir.Location = new System.Drawing.Point(7, 45);
            this.radioButtonAppDir.Name = "radioButtonAppDir";
            this.radioButtonAppDir.Size = new System.Drawing.Size(120, 17);
            this.radioButtonAppDir.TabIndex = 1;
            this.radioButtonAppDir.Text = "Application directory";
            this.radioButtonAppDir.UseVisualStyleBackColor = true;
            // 
            // radioButtonInFileDir
            // 
            this.radioButtonInFileDir.AutoSize = true;
            this.radioButtonInFileDir.Checked = true;
            this.radioButtonInFileDir.Location = new System.Drawing.Point(7, 21);
            this.radioButtonInFileDir.Name = "radioButtonInFileDir";
            this.radioButtonInFileDir.Size = new System.Drawing.Size(108, 17);
            this.radioButtonInFileDir.TabIndex = 0;
            this.radioButtonInFileDir.TabStop = true;
            this.radioButtonInFileDir.Text = "Input file directory";
            this.radioButtonInFileDir.UseVisualStyleBackColor = true;
            // 
            // openFileDialogIn
            // 
            this.openFileDialogIn.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.groupBoxOut);
            this.Controls.Add(this.groupBoxIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Columinator 0.9beta";
            this.groupBoxIn.ResumeLayout(false);
            this.groupBoxIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColIgnore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrIgnore)).EndInit();
            this.groupBoxSplitter.ResumeLayout(false);
            this.groupBoxSplitter.PerformLayout();
            this.groupBoxOut.ResumeLayout(false);
            this.groupBoxOut.PerformLayout();
            this.groupBoxOutSplitter.ResumeLayout(false);
            this.groupBoxOutSplitter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCol)).EndInit();
            this.groupBoxOutName.ResumeLayout(false);
            this.groupBoxOutName.PerformLayout();
            this.groupBoxOutDirectory.ResumeLayout(false);
            this.groupBoxOutDirectory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.GroupBox groupBoxSplitter;
        private System.Windows.Forms.TextBox textBoxChars;
        private System.Windows.Forms.CheckBox checkBoxOther;
        private System.Windows.Forms.CheckBox checkBoxTab;
        private System.Windows.Forms.CheckBox checkBoxSpace;
        private System.Windows.Forms.Button buttonInBrowse;
        private System.Windows.Forms.TextBox textBoxInPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxOut;
        private System.Windows.Forms.Button buttonExe;
        private System.Windows.Forms.NumericUpDown numericUpDownCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxOutName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.RadioButton radioButtonNewName;
        private System.Windows.Forms.RadioButton radioButtonOldName;
        private System.Windows.Forms.GroupBox groupBoxOutDirectory;
        private System.Windows.Forms.Button buttonSelDir;
        private System.Windows.Forms.TextBox textBoxselDir;
        private System.Windows.Forms.RadioButton radioButtonSelDir;
        private System.Windows.Forms.RadioButton radioButtonAppDir;
        private System.Windows.Forms.RadioButton radioButtonInFileDir;
        private System.Windows.Forms.GroupBox groupBoxOutSplitter;
        private System.Windows.Forms.RadioButton radioButtonOutOther;
        private System.Windows.Forms.RadioButton radioButtonOutTab;
        private System.Windows.Forms.RadioButton radioButtonOutSpace;
        private System.Windows.Forms.TextBox textBoxOutSplitter;
        private System.Windows.Forms.NumericUpDown numericUpDownValCol;
        private System.Windows.Forms.NumericUpDown numericUpDownColIgnore;
        private System.Windows.Forms.NumericUpDown numericUpDownStrIgnore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialogIn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOut;
    }
}

