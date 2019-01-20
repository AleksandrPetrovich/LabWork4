namespace Port.View
{
    partial class RouteForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.arrivalPortComboBox = new System.Windows.Forms.ComboBox();
            this.createRouteButton = new System.Windows.Forms.Button();
            this.mainFormViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Порт прибытия:";
            // 
            // arrivalPortComboBox
            // 
            this.arrivalPortComboBox.FormattingEnabled = true;
            this.arrivalPortComboBox.Location = new System.Drawing.Point(105, 21);
            this.arrivalPortComboBox.Name = "arrivalPortComboBox";
            this.arrivalPortComboBox.Size = new System.Drawing.Size(121, 21);
            this.arrivalPortComboBox.TabIndex = 1;
            // 
            // createRouteButton
            // 
            this.createRouteButton.Location = new System.Drawing.Point(85, 62);
            this.createRouteButton.Name = "createRouteButton";
            this.createRouteButton.Size = new System.Drawing.Size(75, 23);
            this.createRouteButton.TabIndex = 2;
            this.createRouteButton.Text = "Создать";
            this.createRouteButton.UseVisualStyleBackColor = true;
            this.createRouteButton.Click += new System.EventHandler(this.createRouteButton_Click);
            // 
            // mainFormViewModelBindingSource
            // 
            this.mainFormViewModelBindingSource.DataSource = typeof(Port.View.MainFormViewModel);
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 97);
            this.Controls.Add(this.createRouteButton);
            this.Controls.Add(this.arrivalPortComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RouteForm";
            this.ShowIcon = false;
            this.Text = "Маршрут";
            this.Activated += new System.EventHandler(this.RouteForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox arrivalPortComboBox;
        private System.Windows.Forms.Button createRouteButton;
        private System.Windows.Forms.BindingSource mainFormViewModelBindingSource;
    }
}