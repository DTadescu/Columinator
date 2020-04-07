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
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxSplitter = new System.Windows.Forms.GroupBox();
            this.checkBoxSpace = new System.Windows.Forms.CheckBox();
            this.checkBoxTab = new System.Windows.Forms.CheckBox();
            this.checkBoxOther = new System.Windows.Forms.CheckBox();
            this.textBoxChars = new System.Windows.Forms.TextBox();
            this.groupBoxOutDirectory = new System.Windows.Forms.GroupBox();
            this.radioButtonInFileDir = new System.Windows.Forms.RadioButton();
            this.radioButtonAppDir = new System.Windows.Forms.RadioButton();
            this.radioButtonSelDir = new System.Windows.Forms.RadioButton();
            this.textBoxselDir = new System.Windows.Forms.TextBox();
            this.buttonSelDir = new System.Windows.Forms.Button();
            this.groupBoxOutName = new System.Windows.Forms.GroupBox();
            this.radioButtonOldName = new System.Windows.Forms.RadioButton();
            this.radioButtonNewName = new System.Windows.Forms.RadioButton();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCol = new System.Windows.Forms.NumericUpDown();
            this.buttonExe = new System.Windows.Forms.Button();
            this.groupBoxIn.SuspendLayout();
            this.groupBoxOut.SuspendLayout();
            this.groupBoxSplitter.SuspendLayout();
            this.groupBoxOutDirectory.SuspendLayout();
            this.groupBoxOutName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCol)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Controls.Add(this.groupBoxSplitter);
            this.groupBoxIn.Controls.Add(this.button1);
            this.groupBoxIn.Controls.Add(this.textBoxInPath);
            this.groupBoxIn.Controls.Add(this.label1);
            this.groupBoxIn.Location = new System.Drawing.Point(13, 13);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(275, 337);
            this.groupBoxIn.TabIndex = 0;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "Input";
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Controls.Add(this.buttonExe);
            this.groupBoxOut.Controls.Add(this.numericUpDownCol);
            this.groupBoxOut.Controls.Add(this.label2);
            this.groupBoxOut.Controls.Add(this.groupBoxOutName);
            this.groupBoxOut.Controls.Add(this.groupBoxOutDirectory);
            this.groupBoxOut.Location = new System.Drawing.Point(297, 13);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(275, 337);
            this.groupBoxOut.TabIndex = 1;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Output";
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
            // textBoxInPath
            // 
            this.textBoxInPath.Location = new System.Drawing.Point(10, 37);
            this.textBoxInPath.Name = "textBoxInPath";
            this.textBoxInPath.Size = new System.Drawing.Size(177, 20);
            this.textBoxInPath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
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
            // checkBoxTab
            // 
            this.checkBoxTab.AutoSize = true;
            this.checkBoxTab.Location = new System.Drawing.Point(7, 44);
            this.checkBoxTab.Name = "checkBoxTab";
            this.checkBoxTab.Size = new System.Drawing.Size(45, 17);
            this.checkBoxTab.TabIndex = 1;
            this.checkBoxTab.Text = "Tab";
            this.checkBoxTab.UseVisualStyleBackColor = true;
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.AutoSize = true;
            this.checkBoxOther.Location = new System.Drawing.Point(7, 68);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.Size = new System.Drawing.Size(194, 17);
            this.checkBoxOther.TabIndex = 2;
            this.checkBoxOther.Text = "Other (insert space between chars):";
            this.checkBoxOther.UseVisualStyleBackColor = true;
            this.checkBoxOther.CheckedChanged += new System.EventHandler(this.checkBoxOther_CheckedChanged);
            // 
            // textBoxChars
            // 
            this.textBoxChars.Enabled = false;
            this.textBoxChars.Location = new System.Drawing.Point(7, 92);
            this.textBoxChars.Name = "textBoxChars";
            this.textBoxChars.Size = new System.Drawing.Size(170, 20);
            this.textBoxChars.TabIndex = 3;
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
            // textBoxselDir
            // 
            this.textBoxselDir.Enabled = false;
            this.textBoxselDir.Location = new System.Drawing.Point(7, 93);
            this.textBoxselDir.Name = "textBoxselDir";
            this.textBoxselDir.Size = new System.Drawing.Size(168, 20);
            this.textBoxselDir.TabIndex = 3;
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
            // textBoxNewName
            // 
            this.textBoxNewName.Enabled = false;
            this.textBoxNewName.Location = new System.Drawing.Point(7, 68);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(168, 20);
            this.textBoxNewName.TabIndex = 2;
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
            1,
            0,
            0,
            0});
            // 
            // buttonExe
            // 
            this.buttonExe.Location = new System.Drawing.Point(188, 308);
            this.buttonExe.Name = "buttonExe";
            this.buttonExe.Size = new System.Drawing.Size(75, 23);
            this.buttonExe.TabIndex = 4;
            this.buttonExe.Text = "Execute";
            this.buttonExe.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.groupBoxOut);
            this.Controls.Add(this.groupBoxIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Columinator";
            this.groupBoxIn.ResumeLayout(false);
            this.groupBoxIn.PerformLayout();
            this.groupBoxOut.ResumeLayout(false);
            this.groupBoxOut.PerformLayout();
            this.groupBoxSplitter.ResumeLayout(false);
            this.groupBoxSplitter.PerformLayout();
            this.groupBoxOutDirectory.ResumeLayout(false);
            this.groupBoxOutDirectory.PerformLayout();
            this.groupBoxOutName.ResumeLayout(false);
            this.groupBoxOutName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.GroupBox groupBoxSplitter;
        private System.Windows.Forms.TextBox textBoxChars;
        private System.Windows.Forms.CheckBox checkBoxOther;
        private System.Windows.Forms.CheckBox checkBoxTab;
        private System.Windows.Forms.CheckBox checkBoxSpace;
        private System.Windows.Forms.Button button1;
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
    }
}

