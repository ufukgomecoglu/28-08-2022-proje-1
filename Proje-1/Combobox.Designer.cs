namespace Proje_1
{
    partial class Combobox
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
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.labelCN = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(102, 33);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxName.TabIndex = 0;
            //this.comboBoxName.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxName_Format);
            // 
            // labelCN
            // 
            this.labelCN.AutoSize = true;
            this.labelCN.Location = new System.Drawing.Point(22, 36);
            this.labelCN.Name = "labelCN";
            this.labelCN.Size = new System.Drawing.Size(74, 13);
            this.labelCN.TabIndex = 1;
            this.labelCN.Text = "Choose Name";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(229, 31);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 2;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // Combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 95);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.labelCN);
            this.Controls.Add(this.comboBoxName);
            this.Name = "Combobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox";
            this.Load += new System.EventHandler(this.Combobox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label labelCN;
        private System.Windows.Forms.Button buttonGet;
    }
}