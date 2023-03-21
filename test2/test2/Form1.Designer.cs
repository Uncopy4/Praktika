namespace test2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSort = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.sortedTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.bubbleSortRadioButton = new System.Windows.Forms.RadioButton();
            this.insertionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.gnomeSortRadioButton = new System.Windows.Forms.RadioButton();
            this.selectionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSort.Location = new System.Drawing.Point(219, 26);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 43);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inputTextBox.Location = new System.Drawing.Point(32, 26);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(181, 84);
            this.inputTextBox.TabIndex = 1;
            // 
            // sortedTextBox
            // 
            this.sortedTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sortedTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sortedTextBox.Location = new System.Drawing.Point(300, 26);
            this.sortedTextBox.Multiline = true;
            this.sortedTextBox.Name = "sortedTextBox";
            this.sortedTextBox.Size = new System.Drawing.Size(181, 84);
            this.sortedTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output number";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeLabel.Location = new System.Drawing.Point(300, 113);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(31, 15);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "time";
            // 
            // bubbleSortRadioButton
            // 
            this.bubbleSortRadioButton.AutoSize = true;
            this.bubbleSortRadioButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bubbleSortRadioButton.Location = new System.Drawing.Point(92, 166);
            this.bubbleSortRadioButton.Name = "bubbleSortRadioButton";
            this.bubbleSortRadioButton.Size = new System.Drawing.Size(83, 19);
            this.bubbleSortRadioButton.TabIndex = 8;
            this.bubbleSortRadioButton.TabStop = true;
            this.bubbleSortRadioButton.Text = "bubbleSort";
            this.bubbleSortRadioButton.UseVisualStyleBackColor = false;
            // 
            // insertionSortRadioButton
            // 
            this.insertionSortRadioButton.AutoSize = true;
            this.insertionSortRadioButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.insertionSortRadioButton.Location = new System.Drawing.Point(92, 191);
            this.insertionSortRadioButton.Name = "insertionSortRadioButton";
            this.insertionSortRadioButton.Size = new System.Drawing.Size(92, 19);
            this.insertionSortRadioButton.TabIndex = 9;
            this.insertionSortRadioButton.TabStop = true;
            this.insertionSortRadioButton.Text = "insertionSort";
            this.insertionSortRadioButton.UseVisualStyleBackColor = false;
            // 
            // gnomeSortRadioButton
            // 
            this.gnomeSortRadioButton.AutoSize = true;
            this.gnomeSortRadioButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gnomeSortRadioButton.Location = new System.Drawing.Point(92, 116);
            this.gnomeSortRadioButton.Name = "gnomeSortRadioButton";
            this.gnomeSortRadioButton.Size = new System.Drawing.Size(84, 19);
            this.gnomeSortRadioButton.TabIndex = 10;
            this.gnomeSortRadioButton.TabStop = true;
            this.gnomeSortRadioButton.Text = "gnomeSort";
            this.gnomeSortRadioButton.UseVisualStyleBackColor = false;
            // 
            // selectionSortRadioButton
            // 
            this.selectionSortRadioButton.AutoSize = true;
            this.selectionSortRadioButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.selectionSortRadioButton.Location = new System.Drawing.Point(92, 141);
            this.selectionSortRadioButton.Name = "selectionSortRadioButton";
            this.selectionSortRadioButton.Size = new System.Drawing.Size(93, 19);
            this.selectionSortRadioButton.TabIndex = 11;
            this.selectionSortRadioButton.TabStop = true;
            this.selectionSortRadioButton.Text = "selectionSort";
            this.selectionSortRadioButton.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Menu;
            this.btnReset.Location = new System.Drawing.Point(219, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(496, 224);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.selectionSortRadioButton);
            this.Controls.Add(this.gnomeSortRadioButton);
            this.Controls.Add(this.insertionSortRadioButton);
            this.Controls.Add(this.bubbleSortRadioButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortedTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.btnSort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LNNX_Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSort;
        private TextBox inputTextBox;
        private TextBox sortedTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Label timeLabel;
        private RadioButton bubbleSortRadioButton;
        private RadioButton insertionSortRadioButton;
        private RadioButton gnomeSortRadioButton;
        private RadioButton selectionSortRadioButton;
        private Button btnReset;
    }
}