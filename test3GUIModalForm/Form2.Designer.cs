namespace test3GUIModalForm
{
    partial class modalForm
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
            this.sendBox = new System.Windows.Forms.TextBox();
            this.sendText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendBox
            // 
            this.sendBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::test3GUIModalForm.Properties.Settings.Default, "msg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sendBox.Location = new System.Drawing.Point(12, 12);
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(268, 20);
            this.sendBox.TabIndex = 0;
            this.sendBox.Text = global::test3GUIModalForm.Properties.Settings.Default.msg;
            // 
            // sendText
            // 
            this.sendText.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sendText.Location = new System.Drawing.Point(105, 38);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(75, 23);
            this.sendText.TabIndex = 1;
            this.sendText.Text = "sendText";
            this.sendText.UseVisualStyleBackColor = true;
            this.sendText.Click += new System.EventHandler(this.sendText_Click);
            // 
            // modalForm
            // 
            this.AcceptButton = this.sendText;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 76);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.sendBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "modalForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.Button sendText;
    }
}