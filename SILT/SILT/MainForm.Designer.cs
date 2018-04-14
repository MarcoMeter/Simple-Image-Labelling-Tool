namespace SILT
{
    partial class MainForm
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
            this.toLabelPicture = new System.Windows.Forms.PictureBox();
            this.chooseDirButton = new System.Windows.Forms.Button();
            this.directoryPathText = new System.Windows.Forms.RichTextBox();
            this.label0 = new System.Windows.Forms.TextBox();
            this.labelsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.TextBox();
            this.picturePreview1 = new System.Windows.Forms.PictureBox();
            this.previewsText = new System.Windows.Forms.TextBox();
            this.picturePreview2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.TextBox();
            this.remainingImagesText = new System.Windows.Forms.TextBox();
            this.doLabelButton0 = new System.Windows.Forms.Button();
            this.doLabelButton1 = new System.Windows.Forms.Button();
            this.doLabelButton2 = new System.Windows.Forms.Button();
            this.doLabelButton3 = new System.Windows.Forms.Button();
            this.doLabelButton4 = new System.Windows.Forms.Button();
            this.doLabelButton5 = new System.Windows.Forms.Button();
            this.doLabelButton6 = new System.Windows.Forms.Button();
            this.doLabelButton7 = new System.Windows.Forms.Button();
            this.doLabelButton8 = new System.Windows.Forms.Button();
            this.doLabelButton9 = new System.Windows.Forms.Button();
            this.doLabelButton10 = new System.Windows.Forms.Button();
            this.doLabelButton11 = new System.Windows.Forms.Button();
            this.doLabelButton12 = new System.Windows.Forms.Button();
            this.pictureUndo2 = new System.Windows.Forms.PictureBox();
            this.pictureUndo1 = new System.Windows.Forms.PictureBox();
            this.undoButton = new System.Windows.Forms.Button();
            this.backspaceText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.toLabelPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUndo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUndo1)).BeginInit();
            this.SuspendLayout();
            // 
            // toLabelPicture
            // 
            this.toLabelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toLabelPicture.Location = new System.Drawing.Point(12, 43);
            this.toLabelPicture.Name = "toLabelPicture";
            this.toLabelPicture.Size = new System.Drawing.Size(533, 383);
            this.toLabelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toLabelPicture.TabIndex = 0;
            this.toLabelPicture.TabStop = false;
            // 
            // chooseDirButton
            // 
            this.chooseDirButton.Location = new System.Drawing.Point(12, 12);
            this.chooseDirButton.Name = "chooseDirButton";
            this.chooseDirButton.Size = new System.Drawing.Size(138, 25);
            this.chooseDirButton.TabIndex = 1;
            this.chooseDirButton.Text = "Working Directory";
            this.chooseDirButton.UseVisualStyleBackColor = true;
            this.chooseDirButton.Click += new System.EventHandler(this.OnChooseDirectoryClick);
            // 
            // directoryPathText
            // 
            this.directoryPathText.BackColor = System.Drawing.SystemColors.Control;
            this.directoryPathText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directoryPathText.Enabled = false;
            this.directoryPathText.Location = new System.Drawing.Point(156, 16);
            this.directoryPathText.Multiline = false;
            this.directoryPathText.Name = "directoryPathText";
            this.directoryPathText.ReadOnly = true;
            this.directoryPathText.Size = new System.Drawing.Size(389, 25);
            this.directoryPathText.TabIndex = 2;
            this.directoryPathText.TabStop = false;
            this.directoryPathText.Text = "Please select your working directory...";
            // 
            // label0
            // 
            this.label0.Location = new System.Drawing.Point(881, 43);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(219, 22);
            this.label0.TabIndex = 4;
            this.label0.TabStop = false;
            this.label0.Tag = "labels";
            // 
            // labelsText
            // 
            this.labelsText.BackColor = System.Drawing.SystemColors.Control;
            this.labelsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelsText.Enabled = false;
            this.labelsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsText.Location = new System.Drawing.Point(881, 15);
            this.labelsText.Name = "labelsText";
            this.labelsText.ReadOnly = true;
            this.labelsText.Size = new System.Drawing.Size(100, 21);
            this.labelsText.TabIndex = 5;
            this.labelsText.TabStop = false;
            this.labelsText.Text = "Labels";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(881, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 8;
            this.label1.TabStop = false;
            this.label1.Tag = "labels";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(881, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 10;
            this.label2.TabStop = false;
            this.label2.Tag = "labels";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(881, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 22);
            this.label3.TabIndex = 12;
            this.label3.TabStop = false;
            this.label3.Tag = "labels";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(881, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 22);
            this.label4.TabIndex = 14;
            this.label4.TabStop = false;
            this.label4.Tag = "labels";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(881, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 22);
            this.label5.TabIndex = 16;
            this.label5.TabStop = false;
            this.label5.Tag = "labels";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(881, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 22);
            this.label6.TabIndex = 18;
            this.label6.TabStop = false;
            this.label6.Tag = "labels";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(881, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 22);
            this.label7.TabIndex = 20;
            this.label7.TabStop = false;
            this.label7.Tag = "labels";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(881, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 22);
            this.label8.TabIndex = 22;
            this.label8.TabStop = false;
            this.label8.Tag = "labels";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(881, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 22);
            this.label9.TabIndex = 24;
            this.label9.TabStop = false;
            this.label9.Tag = "labels";
            // 
            // picturePreview1
            // 
            this.picturePreview1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePreview1.Location = new System.Drawing.Point(551, 43);
            this.picturePreview1.Name = "picturePreview1";
            this.picturePreview1.Size = new System.Drawing.Size(150, 150);
            this.picturePreview1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview1.TabIndex = 35;
            this.picturePreview1.TabStop = false;
            // 
            // previewsText
            // 
            this.previewsText.BackColor = System.Drawing.SystemColors.Control;
            this.previewsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.previewsText.Enabled = false;
            this.previewsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewsText.Location = new System.Drawing.Point(551, 16);
            this.previewsText.Name = "previewsText";
            this.previewsText.ReadOnly = true;
            this.previewsText.Size = new System.Drawing.Size(100, 21);
            this.previewsText.TabIndex = 36;
            this.previewsText.TabStop = false;
            this.previewsText.Text = "Previews";
            // 
            // picturePreview2
            // 
            this.picturePreview2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePreview2.Location = new System.Drawing.Point(707, 43);
            this.picturePreview2.Name = "picturePreview2";
            this.picturePreview2.Size = new System.Drawing.Size(150, 150);
            this.picturePreview2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview2.TabIndex = 37;
            this.picturePreview2.TabStop = false;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(881, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 22);
            this.label10.TabIndex = 39;
            this.label10.TabStop = false;
            this.label10.Tag = "labels";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(881, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 22);
            this.label11.TabIndex = 41;
            this.label11.TabStop = false;
            this.label11.Tag = "labels";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(881, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 22);
            this.label12.TabIndex = 43;
            this.label12.TabStop = false;
            this.label12.Tag = "labels";
            // 
            // remainingImagesText
            // 
            this.remainingImagesText.BackColor = System.Drawing.SystemColors.Control;
            this.remainingImagesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remainingImagesText.Enabled = false;
            this.remainingImagesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingImagesText.Location = new System.Drawing.Point(12, 432);
            this.remainingImagesText.Name = "remainingImagesText";
            this.remainingImagesText.Size = new System.Drawing.Size(231, 21);
            this.remainingImagesText.TabIndex = 44;
            this.remainingImagesText.TabStop = false;
            this.remainingImagesText.Text = "Remaining Images: ";
            // 
            // doLabelButton0
            // 
            this.doLabelButton0.Location = new System.Drawing.Point(1106, 42);
            this.doLabelButton0.Name = "doLabelButton0";
            this.doLabelButton0.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton0.TabIndex = 58;
            this.doLabelButton0.UseVisualStyleBackColor = true;
            this.doLabelButton0.Click += new System.EventHandler(this.DoLabelButton0_Click);
            // 
            // doLabelButton1
            // 
            this.doLabelButton1.Location = new System.Drawing.Point(1106, 71);
            this.doLabelButton1.Name = "doLabelButton1";
            this.doLabelButton1.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton1.TabIndex = 59;
            this.doLabelButton1.UseVisualStyleBackColor = true;
            this.doLabelButton1.Click += new System.EventHandler(this.DoLabelButton1_Click);
            // 
            // doLabelButton2
            // 
            this.doLabelButton2.Location = new System.Drawing.Point(1106, 103);
            this.doLabelButton2.Name = "doLabelButton2";
            this.doLabelButton2.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton2.TabIndex = 60;
            this.doLabelButton2.UseVisualStyleBackColor = true;
            this.doLabelButton2.Click += new System.EventHandler(this.DoLabelButton2_Click);
            // 
            // doLabelButton3
            // 
            this.doLabelButton3.Location = new System.Drawing.Point(1106, 132);
            this.doLabelButton3.Name = "doLabelButton3";
            this.doLabelButton3.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton3.TabIndex = 61;
            this.doLabelButton3.UseVisualStyleBackColor = true;
            this.doLabelButton3.Click += new System.EventHandler(this.DoLabelButton3_Click);
            // 
            // doLabelButton4
            // 
            this.doLabelButton4.Location = new System.Drawing.Point(1106, 162);
            this.doLabelButton4.Name = "doLabelButton4";
            this.doLabelButton4.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton4.TabIndex = 62;
            this.doLabelButton4.UseVisualStyleBackColor = true;
            this.doLabelButton4.Click += new System.EventHandler(this.DoLabelButton4_Click);
            // 
            // doLabelButton5
            // 
            this.doLabelButton5.Location = new System.Drawing.Point(1106, 192);
            this.doLabelButton5.Name = "doLabelButton5";
            this.doLabelButton5.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton5.TabIndex = 63;
            this.doLabelButton5.UseVisualStyleBackColor = true;
            this.doLabelButton5.Click += new System.EventHandler(this.DoLabelButton5_Click);
            // 
            // doLabelButton6
            // 
            this.doLabelButton6.Location = new System.Drawing.Point(1106, 222);
            this.doLabelButton6.Name = "doLabelButton6";
            this.doLabelButton6.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton6.TabIndex = 64;
            this.doLabelButton6.UseVisualStyleBackColor = true;
            this.doLabelButton6.Click += new System.EventHandler(this.DoLabelButton6_Click);
            // 
            // doLabelButton7
            // 
            this.doLabelButton7.Location = new System.Drawing.Point(1106, 253);
            this.doLabelButton7.Name = "doLabelButton7";
            this.doLabelButton7.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton7.TabIndex = 65;
            this.doLabelButton7.UseVisualStyleBackColor = true;
            this.doLabelButton7.Click += new System.EventHandler(this.DoLabelButton7_Click);
            // 
            // doLabelButton8
            // 
            this.doLabelButton8.Location = new System.Drawing.Point(1106, 283);
            this.doLabelButton8.Name = "doLabelButton8";
            this.doLabelButton8.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton8.TabIndex = 66;
            this.doLabelButton8.UseVisualStyleBackColor = true;
            this.doLabelButton8.Click += new System.EventHandler(this.DoLabelButton8_Click);
            // 
            // doLabelButton9
            // 
            this.doLabelButton9.Location = new System.Drawing.Point(1106, 313);
            this.doLabelButton9.Name = "doLabelButton9";
            this.doLabelButton9.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton9.TabIndex = 67;
            this.doLabelButton9.UseVisualStyleBackColor = true;
            this.doLabelButton9.Click += new System.EventHandler(this.DoLabelButton9_Click);
            // 
            // doLabelButton10
            // 
            this.doLabelButton10.Location = new System.Drawing.Point(1106, 343);
            this.doLabelButton10.Name = "doLabelButton10";
            this.doLabelButton10.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton10.TabIndex = 68;
            this.doLabelButton10.UseVisualStyleBackColor = true;
            this.doLabelButton10.Click += new System.EventHandler(this.DoLabelButton10_Click);
            // 
            // doLabelButton11
            // 
            this.doLabelButton11.Location = new System.Drawing.Point(1106, 373);
            this.doLabelButton11.Name = "doLabelButton11";
            this.doLabelButton11.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton11.TabIndex = 69;
            this.doLabelButton11.UseVisualStyleBackColor = true;
            this.doLabelButton11.Click += new System.EventHandler(this.DoLabelButton11_Click);
            // 
            // doLabelButton12
            // 
            this.doLabelButton12.Location = new System.Drawing.Point(1106, 403);
            this.doLabelButton12.Name = "doLabelButton12";
            this.doLabelButton12.Size = new System.Drawing.Size(25, 23);
            this.doLabelButton12.TabIndex = 70;
            this.doLabelButton12.UseVisualStyleBackColor = true;
            this.doLabelButton12.Click += new System.EventHandler(this.DoLabelButton12_Click);
            // 
            // pictureUndo2
            // 
            this.pictureUndo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureUndo2.Location = new System.Drawing.Point(707, 275);
            this.pictureUndo2.Name = "pictureUndo2";
            this.pictureUndo2.Size = new System.Drawing.Size(150, 150);
            this.pictureUndo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUndo2.TabIndex = 73;
            this.pictureUndo2.TabStop = false;
            // 
            // pictureUndo1
            // 
            this.pictureUndo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureUndo1.Location = new System.Drawing.Point(551, 275);
            this.pictureUndo1.Name = "pictureUndo1";
            this.pictureUndo1.Size = new System.Drawing.Size(150, 150);
            this.pictureUndo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUndo1.TabIndex = 72;
            this.pictureUndo1.TabStop = false;
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(551, 244);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(72, 25);
            this.undoButton.TabIndex = 74;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // backspaceText
            // 
            this.backspaceText.BackColor = System.Drawing.SystemColors.Control;
            this.backspaceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backspaceText.Enabled = false;
            this.backspaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.backspaceText.Location = new System.Drawing.Point(636, 246);
            this.backspaceText.Name = "backspaceText";
            this.backspaceText.Size = new System.Drawing.Size(122, 17);
            this.backspaceText.TabIndex = 75;
            this.backspaceText.TabStop = false;
            this.backspaceText.Text = "(or hit backspace)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(636, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 17);
            this.textBox1.TabIndex = 76;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "(press F5 to refresh)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 465);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.backspaceText);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.pictureUndo2);
            this.Controls.Add(this.pictureUndo1);
            this.Controls.Add(this.doLabelButton12);
            this.Controls.Add(this.doLabelButton11);
            this.Controls.Add(this.doLabelButton10);
            this.Controls.Add(this.doLabelButton9);
            this.Controls.Add(this.doLabelButton8);
            this.Controls.Add(this.doLabelButton7);
            this.Controls.Add(this.doLabelButton6);
            this.Controls.Add(this.doLabelButton5);
            this.Controls.Add(this.doLabelButton4);
            this.Controls.Add(this.doLabelButton3);
            this.Controls.Add(this.doLabelButton2);
            this.Controls.Add(this.doLabelButton1);
            this.Controls.Add(this.doLabelButton0);
            this.Controls.Add(this.remainingImagesText);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.picturePreview2);
            this.Controls.Add(this.previewsText);
            this.Controls.Add(this.picturePreview1);
            this.Controls.Add(this.labelsText);
            this.Controls.Add(this.directoryPathText);
            this.Controls.Add(this.chooseDirButton);
            this.Controls.Add(this.toLabelPicture);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Simple Image Labeling Tool";
            ((System.ComponentModel.ISupportInitialize)(this.toLabelPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUndo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUndo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox toLabelPicture;
        private System.Windows.Forms.Button chooseDirButton;
        private System.Windows.Forms.RichTextBox directoryPathText;
        private System.Windows.Forms.TextBox label0;
        private System.Windows.Forms.TextBox labelsText;
        private System.Windows.Forms.TextBox label1;
        private System.Windows.Forms.TextBox label2;
        private System.Windows.Forms.TextBox label3;
        private System.Windows.Forms.TextBox label4;
        private System.Windows.Forms.TextBox label5;
        private System.Windows.Forms.TextBox label6;
        private System.Windows.Forms.TextBox label7;
        private System.Windows.Forms.TextBox label8;
        private System.Windows.Forms.TextBox label9;
        private System.Windows.Forms.PictureBox picturePreview1;
        private System.Windows.Forms.TextBox previewsText;
        private System.Windows.Forms.PictureBox picturePreview2;
        private System.Windows.Forms.TextBox label10;
        private System.Windows.Forms.TextBox label11;
        private System.Windows.Forms.TextBox label12;
        private System.Windows.Forms.TextBox remainingImagesText;
        private System.Windows.Forms.Button doLabelButton0;
        private System.Windows.Forms.Button doLabelButton1;
        private System.Windows.Forms.Button doLabelButton2;
        private System.Windows.Forms.Button doLabelButton3;
        private System.Windows.Forms.Button doLabelButton4;
        private System.Windows.Forms.Button doLabelButton5;
        private System.Windows.Forms.Button doLabelButton6;
        private System.Windows.Forms.Button doLabelButton7;
        private System.Windows.Forms.Button doLabelButton8;
        private System.Windows.Forms.Button doLabelButton9;
        private System.Windows.Forms.Button doLabelButton10;
        private System.Windows.Forms.Button doLabelButton11;
        private System.Windows.Forms.Button doLabelButton12;
        private System.Windows.Forms.PictureBox pictureUndo2;
        private System.Windows.Forms.PictureBox pictureUndo1;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.TextBox backspaceText;
        private System.Windows.Forms.TextBox textBox1;
    }
}

