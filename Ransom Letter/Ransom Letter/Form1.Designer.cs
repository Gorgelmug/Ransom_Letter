namespace Ransom_Letter
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
            this.RansomLetterBox = new System.Windows.Forms.RichTextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRansomIt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RansomLetterBox
            // 
            this.RansomLetterBox.Location = new System.Drawing.Point(188, 5);
            this.RansomLetterBox.Name = "RansomLetterBox";
            this.RansomLetterBox.Size = new System.Drawing.Size(509, 470);
            this.RansomLetterBox.TabIndex = 0;
            this.RansomLetterBox.Text = "";
            this.RansomLetterBox.TextChanged += new System.EventHandler(this.RansomLetterBox_TextChanged);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(49, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(133, 71);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRansomIt
            // 
            this.btnRansomIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRansomIt.Location = new System.Drawing.Point(49, 202);
            this.btnRansomIt.Name = "btnRansomIt";
            this.btnRansomIt.Size = new System.Drawing.Size(133, 71);
            this.btnRansomIt.TabIndex = 2;
            this.btnRansomIt.Text = "Ransom It";
            this.btnRansomIt.UseVisualStyleBackColor = true;
            this.btnRansomIt.Click += new System.EventHandler(this.btnRansomIt_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(49, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 71);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 487);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRansomIt);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.RansomLetterBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RansomLetterBox;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnRansomIt;
        private System.Windows.Forms.Button btnSave;
    }
}

