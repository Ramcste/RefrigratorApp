namespace RefrigratorApp
{
    partial class RefrigratorUI
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
            this.saveWeightButton = new System.Windows.Forms.Button();
            this.enterWeightButton = new System.Windows.Forms.Button();
            this.maxWeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noofItemsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weightPerunitTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.remainingWeightTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveWeightButton
            // 
            this.saveWeightButton.Location = new System.Drawing.Point(440, 39);
            this.saveWeightButton.Name = "saveWeightButton";
            this.saveWeightButton.Size = new System.Drawing.Size(75, 23);
            this.saveWeightButton.TabIndex = 0;
            this.saveWeightButton.Text = "Save";
            this.saveWeightButton.UseVisualStyleBackColor = true;
            this.saveWeightButton.Click += new System.EventHandler(this.saveWeightButton_Click);
            // 
            // enterWeightButton
            // 
            this.enterWeightButton.Location = new System.Drawing.Point(591, 147);
            this.enterWeightButton.Name = "enterWeightButton";
            this.enterWeightButton.Size = new System.Drawing.Size(75, 23);
            this.enterWeightButton.TabIndex = 1;
            this.enterWeightButton.Text = "Enter";
            this.enterWeightButton.UseVisualStyleBackColor = true;
            this.enterWeightButton.Click += new System.EventHandler(this.enterWeightButton_Click);
            // 
            // maxWeightTextBox
            // 
            this.maxWeightTextBox.Location = new System.Drawing.Point(185, 44);
            this.maxWeightTextBox.Name = "maxWeightTextBox";
            this.maxWeightTextBox.Size = new System.Drawing.Size(165, 20);
            this.maxWeightTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maximum Weight it can take";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. of Items";
            // 
            // noofItemsTextBox
            // 
            this.noofItemsTextBox.Location = new System.Drawing.Point(185, 105);
            this.noofItemsTextBox.Name = "noofItemsTextBox";
            this.noofItemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.noofItemsTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weight(Kg)/unit";
            // 
            // weightPerunitTextBox
            // 
            this.weightPerunitTextBox.Location = new System.Drawing.Point(440, 109);
            this.weightPerunitTextBox.Name = "weightPerunitTextBox";
            this.weightPerunitTextBox.Size = new System.Drawing.Size(110, 20);
            this.weightPerunitTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Weight";
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Location = new System.Drawing.Point(185, 189);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.Size = new System.Drawing.Size(165, 20);
            this.currentWeightTextBox.TabIndex = 9;
            // 
            // remainingWeightTextBox
            // 
            this.remainingWeightTextBox.Location = new System.Drawing.Point(492, 189);
            this.remainingWeightTextBox.Name = "remainingWeightTextBox";
            this.remainingWeightTextBox.Size = new System.Drawing.Size(110, 20);
            this.remainingWeightTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Remaining (Weight)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 287);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remainingWeightTextBox);
            this.Controls.Add(this.currentWeightTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weightPerunitTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noofItemsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxWeightTextBox);
            this.Controls.Add(this.enterWeightButton);
            this.Controls.Add(this.saveWeightButton);
            this.Name = "Form1";
            this.Text = "Refrigrator UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveWeightButton;
        private System.Windows.Forms.Button enterWeightButton;
        private System.Windows.Forms.TextBox maxWeightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noofItemsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weightPerunitTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.TextBox remainingWeightTextBox;
        private System.Windows.Forms.Label label5;
    }
}

