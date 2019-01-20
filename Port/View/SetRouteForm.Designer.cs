namespace Port.View
{
    partial class SetRouteForm
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
            this.routeListBox = new System.Windows.Forms.ListBox();
            this.setRouteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Маршрут";
            // 
            // routeListBox
            // 
            this.routeListBox.FormattingEnabled = true;
            this.routeListBox.Location = new System.Drawing.Point(12, 29);
            this.routeListBox.Name = "routeListBox";
            this.routeListBox.Size = new System.Drawing.Size(187, 134);
            this.routeListBox.TabIndex = 1;
            // 
            // setRouteButton
            // 
            this.setRouteButton.Location = new System.Drawing.Point(64, 177);
            this.setRouteButton.Name = "setRouteButton";
            this.setRouteButton.Size = new System.Drawing.Size(75, 23);
            this.setRouteButton.TabIndex = 2;
            this.setRouteButton.Text = "Ok";
            this.setRouteButton.UseVisualStyleBackColor = true;
            this.setRouteButton.Click += new System.EventHandler(this.setRouteButton_Click);
            // 
            // SetRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 212);
            this.Controls.Add(this.setRouteButton);
            this.Controls.Add(this.routeListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetRouteForm";
            this.ShowIcon = false;
            this.Text = "Установить маршрут";
            this.Activated += new System.EventHandler(this.SetRouteForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox routeListBox;
        private System.Windows.Forms.Button setRouteButton;
    }
}