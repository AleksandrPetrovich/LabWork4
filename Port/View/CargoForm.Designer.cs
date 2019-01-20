namespace Port.View
{
    partial class CargoForm
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
            this.costCargoTextBox = new System.Windows.Forms.TextBox();
            this.createCargoButton = new System.Windows.Forms.Button();
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
            // costCargoTextBox
            // 
            this.costCargoTextBox.Location = new System.Drawing.Point(87, 22);
            this.costCargoTextBox.Name = "costCargoTextBox";
            this.costCargoTextBox.Size = new System.Drawing.Size(100, 20);
            this.costCargoTextBox.TabIndex = 1;
            // 
            // createCargoButton
            // 
            this.createCargoButton.Location = new System.Drawing.Point(64, 62);
            this.createCargoButton.Name = "createCargoButton";
            this.createCargoButton.Size = new System.Drawing.Size(75, 23);
            this.createCargoButton.TabIndex = 2;
            this.createCargoButton.Text = "Создать";
            this.createCargoButton.UseVisualStyleBackColor = true;
            this.createCargoButton.Click += new System.EventHandler(this.createCargoButton_Click);
            // 
            // CargoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 97);
            this.Controls.Add(this.createCargoButton);
            this.Controls.Add(this.costCargoTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargoForm";
            this.ShowIcon = false;
            this.Text = "CargoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costCargoTextBox;
        private System.Windows.Forms.Button createCargoButton;
    }
}