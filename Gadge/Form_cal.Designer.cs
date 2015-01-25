namespace Gadge
{
    partial class Form_Cal
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_result = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(13, 13);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(313, 20);
            this.textBox_input.TabIndex = 0;
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(13, 50);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(75, 23);
            this.button_result.TabIndex = 1;
            this.button_result.Text = "Result";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(94, 52);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(232, 20);
            this.textBox_result.TabIndex = 2;
            // 
            // Form_Cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 89);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form_Cal";
            this.Text = "Form_cal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.TextBox textBox_result;
    }
}