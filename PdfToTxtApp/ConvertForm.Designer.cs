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
            this.operationResultLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfConvertedFilesLbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(64, 13);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(196, 28);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "Select File(s)";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(64, 50);
            this.convertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(196, 28);
            this.convertBtn.TabIndex = 2;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of selected files:";
            // 
            // numberOfFileSelectedLbl
            // 
            this.numberOfFileSelectedLbl.AutoSize = true;
            this.numberOfFileSelectedLbl.Location = new System.Drawing.Point(144, 117);
            this.numberOfFileSelectedLbl.Name = "numberOfFileSelectedLbl";
            this.numberOfFileSelectedLbl.Size = new System.Drawing.Size(15, 16);
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
            // operationResultLbl
            // 
            this.operationResultLbl.AutoSize = true;
            this.operationResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationResultLbl.ForeColor = System.Drawing.Color.Green;
            this.operationResultLbl.Location = new System.Drawing.Point(268, 132);
            this.operationResultLbl.Name = "operationResultLbl";
            this.operationResultLbl.Size = new System.Drawing.Size(48, 20);
            this.operationResultLbl.TabIndex = 5;
            this.operationResultLbl.Text = "result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of converted files:";
            // 
            // numberOfConvertedFilesLbl
            // 
            this.numberOfConvertedFilesLbl.AutoSize = true;
            this.numberOfConvertedFilesLbl.Location = new System.Drawing.Point(144, 184);
            this.numberOfConvertedFilesLbl.Name = "numberOfConvertedFilesLbl";
            this.numberOfConvertedFilesLbl.Size = new System.Drawing.Size(15, 16);
            this.numberOfConvertedFilesLbl.TabIndex = 6;
            this.numberOfConvertedFilesLbl.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 203);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Location = new System.Drawing.Point(255, 184);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(30, 16);
            this.progressLbl.TabIndex = 8;
            this.progressLbl.Text = "0 %";
            // 
            // ConvertFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 238);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numberOfConvertedFilesLbl);
            this.Controls.Add(this.operationResultLbl);
            this.Controls.Add(this.numberOfFileSelectedLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.selectBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConvertFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert2Txt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfFileSelectedLbl;
        private System.ComponentModel.BackgroundWorker convertBackgroundWorker;
        private System.Windows.Forms.Label operationResultLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOfConvertedFilesLbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressLbl;
    }
}

