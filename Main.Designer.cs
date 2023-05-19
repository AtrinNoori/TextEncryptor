
namespace TextEncryptorAndDecryptor
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
            this.KeyINFO = new System.Windows.Forms.Label();
            this.TextINFO = new System.Windows.Forms.Label();
            this.ResultINFO = new System.Windows.Forms.Label();
            this.Key_TXT = new System.Windows.Forms.TextBox();
            this.Text_TXT = new System.Windows.Forms.TextBox();
            this.Result_TXT = new System.Windows.Forms.TextBox();
            this.Flag_CHBX = new System.Windows.Forms.CheckBox();
            this.Start_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyINFO
            // 
            this.KeyINFO.AutoSize = true;
            this.KeyINFO.Location = new System.Drawing.Point(23, 17);
            this.KeyINFO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyINFO.Name = "KeyINFO";
            this.KeyINFO.Size = new System.Drawing.Size(31, 16);
            this.KeyINFO.TabIndex = 0;
            this.KeyINFO.Text = "Key";
            // 
            // TextINFO
            // 
            this.TextINFO.AutoSize = true;
            this.TextINFO.Location = new System.Drawing.Point(23, 71);
            this.TextINFO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextINFO.Name = "TextINFO";
            this.TextINFO.Size = new System.Drawing.Size(34, 16);
            this.TextINFO.TabIndex = 1;
            this.TextINFO.Text = "Text";
            // 
            // ResultINFO
            // 
            this.ResultINFO.AutoSize = true;
            this.ResultINFO.Location = new System.Drawing.Point(276, 17);
            this.ResultINFO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultINFO.Name = "ResultINFO";
            this.ResultINFO.Size = new System.Drawing.Size(49, 16);
            this.ResultINFO.TabIndex = 2;
            this.ResultINFO.Text = "Result ";
            // 
            // Key_TXT
            // 
            this.Key_TXT.Location = new System.Drawing.Point(19, 39);
            this.Key_TXT.Name = "Key_TXT";
            this.Key_TXT.Size = new System.Drawing.Size(213, 22);
            this.Key_TXT.TabIndex = 3;
            this.Key_TXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_TXT_KeyDown);
            // 
            // Text_TXT
            // 
            this.Text_TXT.Location = new System.Drawing.Point(19, 90);
            this.Text_TXT.Name = "Text_TXT";
            this.Text_TXT.Size = new System.Drawing.Size(213, 22);
            this.Text_TXT.TabIndex = 4;
            this.Text_TXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_TXT_KeyDown);
            // 
            // Result_TXT
            // 
            this.Result_TXT.Location = new System.Drawing.Point(273, 39);
            this.Result_TXT.Multiline = true;
            this.Result_TXT.Name = "Result_TXT";
            this.Result_TXT.Size = new System.Drawing.Size(213, 131);
            this.Result_TXT.TabIndex = 5;
            // 
            // Flag_CHBX
            // 
            this.Flag_CHBX.AutoSize = true;
            this.Flag_CHBX.Location = new System.Drawing.Point(26, 127);
            this.Flag_CHBX.Name = "Flag_CHBX";
            this.Flag_CHBX.Size = new System.Drawing.Size(72, 20);
            this.Flag_CHBX.TabIndex = 6;
            this.Flag_CHBX.Text = "Encrypt";
            this.Flag_CHBX.UseVisualStyleBackColor = true;
            this.Flag_CHBX.Click += new System.EventHandler(this.Flag_CHBX_Click);
            // 
            // Start_BTN
            // 
            this.Start_BTN.Location = new System.Drawing.Point(19, 184);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(106, 42);
            this.Start_BTN.TabIndex = 7;
            this.Start_BTN.Text = "Start";
            this.Start_BTN.UseVisualStyleBackColor = true;
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 241);
            this.Controls.Add(this.Start_BTN);
            this.Controls.Add(this.Flag_CHBX);
            this.Controls.Add(this.Result_TXT);
            this.Controls.Add(this.Text_TXT);
            this.Controls.Add(this.Key_TXT);
            this.Controls.Add(this.ResultINFO);
            this.Controls.Add(this.TextINFO);
            this.Controls.Add(this.KeyINFO);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cool Text Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeyINFO;
        private System.Windows.Forms.Label TextINFO;
        private System.Windows.Forms.Label ResultINFO;
        private System.Windows.Forms.TextBox Key_TXT;
        private System.Windows.Forms.TextBox Text_TXT;
        private System.Windows.Forms.TextBox Result_TXT;
        private System.Windows.Forms.CheckBox Flag_CHBX;
        private System.Windows.Forms.Button Start_BTN;
    }
}

