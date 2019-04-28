namespace WinGUI
{
    partial class Main
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
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputTextbox
            // 
            this.inputTextbox.AcceptsReturn = true;
            this.inputTextbox.BackColor = System.Drawing.Color.Black;
            this.inputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTextbox.Font = new System.Drawing.Font("Consolas", 30F);
            this.inputTextbox.ForeColor = System.Drawing.Color.White;
            this.inputTextbox.Location = new System.Drawing.Point(0, 0);
            this.inputTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(500, 47);
            this.inputTextbox.TabIndex = 0;
            this.inputTextbox.TextChanged += new System.EventHandler(this.InputTextbox_TextChanged);
            this.inputTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextbox_KeyPress);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 47);
            this.ControlBox = false;
            this.Controls.Add(this.inputTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextbox;
    }
}

