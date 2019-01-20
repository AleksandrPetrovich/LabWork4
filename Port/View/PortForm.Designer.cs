namespace Port.View
{
    partial class PortForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.titlePortTextBox = new System.Windows.Forms.TextBox();
            this.coordinatePortTextBox = new System.Windows.Forms.TextBox();
            this.createPortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Координата:";
            // 
            // titlePortTextBox
            // 
            this.titlePortTextBox.Location = new System.Drawing.Point(105, 9);
            this.titlePortTextBox.Name = "titlePortTextBox";
            this.titlePortTextBox.Size = new System.Drawing.Size(100, 20);
            this.titlePortTextBox.TabIndex = 2;
            // 
            // coordinatePortTextBox
            // 
            this.coordinatePortTextBox.Location = new System.Drawing.Point(105, 33);
            this.coordinatePortTextBox.Name = "coordinatePortTextBox";
            this.coordinatePortTextBox.Size = new System.Drawing.Size(100, 20);
            this.coordinatePortTextBox.TabIndex = 3;
            // 
            // createPortButton
            // 
            this.createPortButton.Location = new System.Drawing.Point(70, 66);
            this.createPortButton.Name = "createPortButton";
            this.createPortButton.Size = new System.Drawing.Size(75, 23);
            this.createPortButton.TabIndex = 4;
            this.createPortButton.Text = "Создать";
            this.createPortButton.UseVisualStyleBackColor = true;
            this.createPortButton.Click += new System.EventHandler(this.createPortButton_Click);
            // 
            // PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 97);
            this.Controls.Add(this.createPortButton);
            this.Controls.Add(this.coordinatePortTextBox);
            this.Controls.Add(this.titlePortTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortForm";
            this.ShowIcon = false;
            this.Text = "Порт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titlePortTextBox;
        private System.Windows.Forms.TextBox coordinatePortTextBox;
        private System.Windows.Forms.Button createPortButton;
    }
}