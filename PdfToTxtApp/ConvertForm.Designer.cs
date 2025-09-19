namespace PdfToTxtApp
{
    partial class ConvertFrm
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
            this.selectBtn = new System.Windows.Forms.Button();
            this.convertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfFileSelectedLbl = new System.Windows.Forms.Label();
            this.convertBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfConvertedFilesLbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressPic = new System.Windows.Forms.PictureBox();
            this.inprogressLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progressPic)).BeginInit();
            this.SuspendLayout();
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectBtn.Location = new System.Drawing.Point(52, 13);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(189, 28);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "Select File(s)";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // convertBtn
            // 
            this.convertBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.convertBtn.Location = new System.Drawing.Point(52, 50);
            this.convertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(189, 28);
            this.convertBtn.TabIndex = 2;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of selected files:";
            // 
            // numberOfFileSelectedLbl
            // 
            this.numberOfFileSelectedLbl.AutoSize = true;
            this.numberOfFileSelectedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfFileSelectedLbl.ForeColor = System.Drawing.Color.Black;
            this.numberOfFileSelectedLbl.Location = new System.Drawing.Point(237, 120);
            this.numberOfFileSelectedLbl.Name = "numberOfFileSelectedLbl";
            this.numberOfFileSelectedLbl.Size = new System.Drawing.Size(18, 20);
            this.numberOfFileSelectedLbl.TabIndex = 4;
            this.numberOfFileSelectedLbl.Text = "0";
            // 
            // convertBackgroundWorker
            // 
            this.convertBackgroundWorker.WorkerReportsProgress = true;
            this.convertBackgroundWorker.WorkerSupportsCancellation = true;
            this.convertBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.convertBackgroundWorker_DoWork);
            this.convertBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.convertBackgroundWorker_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of converted files:";
            // 
            // numberOfConvertedFilesLbl
            // 
            this.numberOfConvertedFilesLbl.AutoSize = true;
            this.numberOfConvertedFilesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfConvertedFilesLbl.ForeColor = System.Drawing.Color.Black;
            this.numberOfConvertedFilesLbl.Location = new System.Drawing.Point(247, 150);
            this.numberOfConvertedFilesLbl.Name = "numberOfConvertedFilesLbl";
            this.numberOfConvertedFilesLbl.Size = new System.Drawing.Size(18, 20);
            this.numberOfConvertedFilesLbl.TabIndex = 6;
            this.numberOfConvertedFilesLbl.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 211);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(282, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLbl.ForeColor = System.Drawing.Color.Black;
            this.progressLbl.Location = new System.Drawing.Point(121, 192);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(33, 16);
            this.progressLbl.TabIndex = 8;
            this.progressLbl.Text = "0 %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "(1)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "(2)";
            // 
            // progressPic
            // 
            this.progressPic.Image = global::PdfToTxtApp.Properties.Resources.loading2;
            this.progressPic.Location = new System.Drawing.Point(96, 104);
            this.progressPic.Name = "progressPic";
            this.progressPic.Size = new System.Drawing.Size(100, 13);
            this.progressPic.TabIndex = 9;
            this.progressPic.TabStop = false;
            this.progressPic.Visible = false;
            // 
            // inprogressLbl
            // 
            this.inprogressLbl.AutoSize = true;
            this.inprogressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inprogressLbl.Location = new System.Drawing.Point(93, 82);
            this.inprogressLbl.Name = "inprogressLbl";
            this.inprogressLbl.Size = new System.Drawing.Size(94, 18);
            this.inprogressLbl.TabIndex = 10;
            this.inprogressLbl.Text = "Please wait";
            this.inprogressLbl.Visible = false;
            // 
            // ConvertFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.inprogressLbl);
            this.Controls.Add(this.progressPic);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numberOfConvertedFilesLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberOfFileSelectedLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.selectBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConvertFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert2Txt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfFileSelectedLbl;
        private System.ComponentModel.BackgroundWorker convertBackgroundWorker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOfConvertedFilesLbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox progressPic;
        private System.Windows.Forms.Label inprogressLbl;
    }
}

