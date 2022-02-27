namespace Project_3___Section_1
{
    partial class startupForm
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
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exportDelimButton = new System.Windows.Forms.Button();
            this.exportFixedWidthButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.letterComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Location = new System.Drawing.Point(46, 49);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(148, 186);
            this.locationListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CDC Locations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter List Using Letter";
            // 
            // exportDelimButton
            // 
            this.exportDelimButton.Location = new System.Drawing.Point(255, 133);
            this.exportDelimButton.Name = "exportDelimButton";
            this.exportDelimButton.Size = new System.Drawing.Size(172, 23);
            this.exportDelimButton.TabIndex = 3;
            this.exportDelimButton.Text = "Export to &Delimited File (.csv)";
            this.exportDelimButton.UseVisualStyleBackColor = true;
            this.exportDelimButton.Click += new System.EventHandler(this.exportDelimButton_Click);
            // 
            // exportFixedWidthButton
            // 
            this.exportFixedWidthButton.Location = new System.Drawing.Point(255, 171);
            this.exportFixedWidthButton.Name = "exportFixedWidthButton";
            this.exportFixedWidthButton.Size = new System.Drawing.Size(172, 23);
            this.exportFixedWidthButton.TabIndex = 4;
            this.exportFixedWidthButton.Text = "Export to &Fixed Width File (.txt)";
            this.exportFixedWidthButton.UseVisualStyleBackColor = true;
            this.exportFixedWidthButton.Click += new System.EventHandler(this.exportFixedWidthButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(352, 212);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // letterComboBox
            // 
            this.letterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.letterComboBox.FormattingEnabled = true;
            this.letterComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.letterComboBox.Location = new System.Drawing.Point(226, 49);
            this.letterComboBox.Name = "letterComboBox";
            this.letterComboBox.Size = new System.Drawing.Size(57, 21);
            this.letterComboBox.TabIndex = 6;
            this.letterComboBox.SelectedIndexChanged += new System.EventHandler(this.letterComboBox_SelectedIndexChanged);
            // 
            // startupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 271);
            this.Controls.Add(this.letterComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.exportFixedWidthButton);
            this.Controls.Add(this.exportDelimButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "startupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P3S1 Data File Tasks";
            this.Load += new System.EventHandler(this.startupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exportDelimButton;
        private System.Windows.Forms.Button exportFixedWidthButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox letterComboBox;
    }
}

