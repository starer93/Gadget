namespace Gadge
{
    partial class Form_Note
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
            this.button_close = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.TextBox_Note = new System.Windows.Forms.RichTextBox();
            this.list_note = new System.Windows.Forms.ListBox();
            this.textbox_subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textbox_subject);
            this.panel1.Controls.Add(this.list_note);
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.TextBox_Note);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 303);
            this.panel1.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(246, 266);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(85, 266);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // TextBox_Note
            // 
            this.TextBox_Note.Location = new System.Drawing.Point(85, 30);
            this.TextBox_Note.Name = "TextBox_Note";
            this.TextBox_Note.Size = new System.Drawing.Size(236, 230);
            this.TextBox_Note.TabIndex = 0;
            this.TextBox_Note.Text = "";
            // 
            // list_note
            // 
            this.list_note.FormattingEnabled = true;
            this.list_note.Location = new System.Drawing.Point(4, 4);
            this.list_note.Name = "list_note";
            this.list_note.Size = new System.Drawing.Size(75, 277);
            this.list_note.TabIndex = 3;
            // 
            // textbox_subject
            // 
            this.textbox_subject.Location = new System.Drawing.Point(132, 4);
            this.textbox_subject.Name = "textbox_subject";
            this.textbox_subject.Size = new System.Drawing.Size(189, 20);
            this.textbox_subject.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "subject";
            // 
            // Form_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 328);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Note";
            this.Text = "note";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.RichTextBox TextBox_Note;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_subject;
        private System.Windows.Forms.ListBox list_note;

    }
}