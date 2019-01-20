namespace Port.View
{
    partial class InfoForm
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
            this.titleShipLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costFuelLabel = new System.Windows.Forms.Label();
            this.cargoListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titlePortLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Корабль:";
            // 
            // titleShipLabel
            // 
            this.titleShipLabel.AutoSize = true;
            this.titleShipLabel.Location = new System.Drawing.Point(105, 15);
            this.titleShipLabel.Name = "titleShipLabel";
            this.titleShipLabel.Size = new System.Drawing.Size(55, 13);
            this.titleShipLabel.TabIndex = 1;
            this.titleShipLabel.Text = "название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Топливо:";
            // 
            // costFuelLabel
            // 
            this.costFuelLabel.AutoSize = true;
            this.costFuelLabel.Location = new System.Drawing.Point(105, 35);
            this.costFuelLabel.Name = "costFuelLabel";
            this.costFuelLabel.Size = new System.Drawing.Size(31, 13);
            this.costFuelLabel.TabIndex = 3;
            this.costFuelLabel.Text = "цена";
            // 
            // cargoListBox
            // 
            this.cargoListBox.FormattingEnabled = true;
            this.cargoListBox.Location = new System.Drawing.Point(13, 101);
            this.cargoListBox.Name = "cargoListBox";
            this.cargoListBox.Size = new System.Drawing.Size(186, 95);
            this.cargoListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Груз";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Порт прибытия:";
            // 
            // titlePortLabel
            // 
            this.titlePortLabel.AutoSize = true;
            this.titlePortLabel.Location = new System.Drawing.Point(105, 55);
            this.titlePortLabel.Name = "titlePortLabel";
            this.titlePortLabel.Size = new System.Drawing.Size(55, 13);
            this.titlePortLabel.TabIndex = 7;
            this.titlePortLabel.Text = "название";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 212);
            this.Controls.Add(this.titlePortLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cargoListBox);
            this.Controls.Add(this.costFuelLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleShipLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.ShowIcon = false;
            this.Text = "Информация";
            this.Activated += new System.EventHandler(this.InfoForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleShipLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costFuelLabel;
        private System.Windows.Forms.ListBox cargoListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label titlePortLabel;
    }
}