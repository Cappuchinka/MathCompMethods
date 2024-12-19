namespace Dop_Lab_4
{
    partial class Form_Dop_Lab_4
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
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.panelProcess = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.countButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.splitContainerPictures = new System.Windows.Forms.SplitContainer();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.panelToolbar.SuspendLayout();
            this.panelProcess.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPictures)).BeginInit();
            this.splitContainerPictures.Panel1.SuspendLayout();
            this.splitContainerPictures.Panel2.SuspendLayout();
            this.splitContainerPictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panelToolbar.Controls.Add(this.panelProcess);
            this.panelToolbar.Controls.Add(this.panelButtons);
            this.panelToolbar.Location = new System.Drawing.Point(3, 2);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(1197, 144);
            this.panelToolbar.TabIndex = 0;
            // 
            // panelProcess
            // 
            this.panelProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.panelProcess.Controls.Add(this.labelInfo);
            this.panelProcess.Controls.Add(this.labelResult);
            this.panelProcess.Location = new System.Drawing.Point(126, 3);
            this.panelProcess.Name = "panelProcess";
            this.panelProcess.Size = new System.Drawing.Size(119, 141);
            this.panelProcess.TabIndex = 4;
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelInfo.Location = new System.Drawing.Point(15, 41);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(87, 30);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "—";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelResult.Location = new System.Drawing.Point(15, 7);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(87, 34);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Result:";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.panelButtons.Controls.Add(this.countButton);
            this.panelButtons.Controls.Add(this.saveButton);
            this.panelButtons.Controls.Add(this.loadButton);
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(120, 144);
            this.panelButtons.TabIndex = 3;
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.countButton.Font = new System.Drawing.Font("Arial", 9F);
            this.countButton.Location = new System.Drawing.Point(9, 50);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(106, 38);
            this.countButton.TabIndex = 1;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.saveButton.Font = new System.Drawing.Font("Arial", 9F);
            this.saveButton.Location = new System.Drawing.Point(9, 94);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 38);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.loadButton.Font = new System.Drawing.Font("Arial", 9F);
            this.loadButton.Location = new System.Drawing.Point(9, 6);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(106, 38);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // splitContainerPictures
            // 
            this.splitContainerPictures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainerPictures.Location = new System.Drawing.Point(1, 154);
            this.splitContainerPictures.Name = "splitContainerPictures";
            // 
            // splitContainerPictures.Panel1
            // 
            this.splitContainerPictures.Panel1.Controls.Add(this.pictureBoxInput);
            // 
            // splitContainerPictures.Panel2
            // 
            this.splitContainerPictures.Panel2.Controls.Add(this.pictureBoxOutput);
            this.splitContainerPictures.Size = new System.Drawing.Size(1200, 603);
            this.splitContainerPictures.SplitterDistance = 600;
            this.splitContainerPictures.TabIndex = 1;
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(8, 10);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(588, 581);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxInput.TabIndex = 1;
            this.pictureBoxInput.TabStop = false;
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Location = new System.Drawing.Point(5, 10);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(588, 580);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxOutput.TabIndex = 0;
            this.pictureBoxOutput.TabStop = false;
            // 
            // Form_Dop_Lab_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 762);
            this.Controls.Add(this.splitContainerPictures);
            this.Controls.Add(this.panelToolbar);
            this.Name = "Form_Dop_Lab_4";
            this.Text = "Form1";
            this.panelToolbar.ResumeLayout(false);
            this.panelProcess.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.splitContainerPictures.Panel1.ResumeLayout(false);
            this.splitContainerPictures.Panel1.PerformLayout();
            this.splitContainerPictures.Panel2.ResumeLayout(false);
            this.splitContainerPictures.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPictures)).EndInit();
            this.splitContainerPictures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelResult;

        private System.Windows.Forms.Label labelInfo;

        private System.Windows.Forms.Panel panelProcess;

        private System.Windows.Forms.Panel panelButtons;

        private System.Windows.Forms.PictureBox pictureBoxOutput;

        private System.Windows.Forms.PictureBox pictureBoxInput;

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SplitContainer splitContainerPictures;

        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button countButton;

        #endregion
    }
}