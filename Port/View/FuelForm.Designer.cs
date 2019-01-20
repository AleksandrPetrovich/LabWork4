namespace Port.View
{
    partial class FuelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.costFuelTextBox = new System.Windows.Forms.TextBox();
            this.createFuelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена:";
            // 
            // costFuelTextBox
            // 
            this.costFuelTextBox.Location = new System.Drawing.Point(87, 22);
            this.costFuelTextBox.Name = "costFuelTextBox";
            this.costFuelTextBox.Size = new System.Drawing.Size(100, 20);
            this.costFuelTextBox.TabIndex = 1;
            // 
            // createFuelButton
            // 
            this.createFuelButton.Location = new System.Drawing.Point(64, 62);
            this.createFuelButton.Name = "createFuelButton";
            this.createFuelButton.Size = new System.Drawing.Size(75, 23);
            this.createFuelButton.TabIndex = 2;
            this.createFuelButton.Text = "Создать";
            this.createFuelButton.UseVisualStyleBackColor = true;
            this.createFuelButton.Click += new System.EventHandler(this.createFuelButton_Click);
            // 
            // FuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 97);
            this.Controls.Add(this.createFuelButton);
            this.Controls.Add(this.costFuelTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuelForm";
            this.ShowIcon = false;
            this.Text = "Топливо";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costFuelTextBox;
        private System.Windows.Forms.Button createFuelButton;
    }
}