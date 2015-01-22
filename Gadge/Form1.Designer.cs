namespace Gadge
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_timer = new System.Windows.Forms.Button();
            this.button_cal = new System.Windows.Forms.Button();
            this.button_note = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_timer);
            this.panel1.Controls.Add(this.button_cal);
            this.panel1.Controls.Add(this.button_note);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 372);
            this.panel1.TabIndex = 0;
            // 
            // button_timer
            // 
            this.button_timer.Location = new System.Drawing.Point(4, 126);
            this.button_timer.Name = "button_timer";
            this.button_timer.Size = new System.Drawing.Size(178, 60);
            this.button_timer.TabIndex = 2;
            this.button_timer.Text = "TIMER";
            this.button_timer.UseVisualStyleBackColor = true;
            this.button_timer.Click += new System.EventHandler(this.button_timer_Click);
            // 
            // button_cal
            // 
            this.button_cal.Location = new System.Drawing.Point(4, 64);
            this.button_cal.Name = "button_cal";
            this.button_cal.Size = new System.Drawing.Size(178, 55);
            this.button_cal.TabIndex = 1;
            this.button_cal.Text = "CALCULATOR";
            this.button_cal.UseVisualStyleBackColor = true;
            this.button_cal.Click += new System.EventHandler(this.button_cal_Click);
            // 
            // button_note
            // 
            this.button_note.Location = new System.Drawing.Point(4, 4);
            this.button_note.Name = "button_note";
            this.button_note.Size = new System.Drawing.Size(178, 53);
            this.button_note.TabIndex = 0;
            this.button_note.Text = "NOTE";
            this.button_note.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_note.UseVisualStyleBackColor = true;
            this.button_note.Click += new System.EventHandler(this.button_note_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 364);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_timer;
        private System.Windows.Forms.Button button_cal;
        private System.Windows.Forms.Button button_note;

    }
}

