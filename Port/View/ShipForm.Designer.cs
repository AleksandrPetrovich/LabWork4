namespace Port.View
{
    partial class ShipForm
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
            this.titleShipTextBox = new System.Windows.Forms.TextBox();
            this.portShipComboBox = new System.Windows.Forms.ComboBox();
            this.createShipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Порт:";
            // 
            // titleShipTextBox
            // 
            this.titleShipTextBox.Location = new System.Drawing.Point(102, 11);
            this.titleShipTextBox.Name = "titleShipTextBox";
            this.titleShipTextBox.Size = new System.Drawing.Size(121, 20);
            this.titleShipTextBox.TabIndex = 2;
            // 
            // portShipComboBox
            // 
            this.portShipComboBox.FormattingEnabled = true;
            this.portShipComboBox.Location = new System.Drawing.Point(102, 38);
            this.portShipComboBox.Name = "portShipComboBox";
            this.portShipComboBox.Size = new System.Drawing.Size(121, 21);
            this.portShipComboBox.TabIndex = 3;
            // 
            // createShipButton
            // 
            this.createShipButton.Location = new System.Drawing.Point(74, 65);
            this.createShipButton.Name = "createShipButton";
            this.createShipButton.Size = new System.Drawing.Size(75, 23);
            this.createShipButton.TabIndex = 4;
            this.createShipButton.Text = "Создать";
            this.createShipButton.UseVisualStyleBackColor = true;
            this.createShipButton.Click += new System.EventHandler(this.createShipButton_Click);
            // 
            // ShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 97);
            this.Controls.Add(this.createShipButton);
            this.Controls.Add(this.portShipComboBox);
            this.Controls.Add(this.titleShipTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShipForm";
            this.ShowIcon = false;
            this.Text = "ShipForm";
            this.Activated += new System.EventHandler(this.ShipForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleShipTextBox;
        private System.Windows.Forms.ComboBox portShipComboBox;
        private System.Windows.Forms.Button createShipButton;
    }
}