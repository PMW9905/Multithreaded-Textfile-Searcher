
namespace Asg4_pmw180000
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
            this.StringView = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.debug1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FilenameTextbox = new System.Windows.Forms.TextBox();
            this.TextfileLabel = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.SubstringLabel = new System.Windows.Forms.Label();
            this.SubstringTextbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textreadWorker = new System.ComponentModel.BackgroundWorker();
            this.SearchProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressBarLabel = new System.Windows.Forms.Label();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // StringView
            // 
            this.StringView.AllowColumnReorder = true;
            this.StringView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StringView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.Line});
            this.StringView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StringView.FullRowSelect = true;
            this.StringView.HideSelection = false;
            this.StringView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StringView.Location = new System.Drawing.Point(12, 145);
            this.StringView.Name = "StringView";
            this.StringView.Size = new System.Drawing.Size(1306, 617);
            this.StringView.TabIndex = 0;
            this.StringView.UseCompatibleStateImageBehavior = false;
            this.StringView.View = System.Windows.Forms.View.Details;
            // 
            // Index
            // 
            this.Index.Text = "Index";
            this.Index.Width = 120;
            // 
            // Line
            // 
            this.Line.Text = "Text";
            this.Line.Width = 600;
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.debug1});
            this.Status.Location = new System.Drawing.Point(0, 765);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(1330, 25);
            this.Status.TabIndex = 1;
            this.Status.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(299, 20);
            this.StatusLabel.Text = "Currently Selecting Substring and Textfile";
            // 
            // debug1
            // 
            this.debug1.Name = "debug1";
            this.debug1.Size = new System.Drawing.Size(0, 20);
            // 
            // FilenameTextbox
            // 
            this.FilenameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilenameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FilenameTextbox.Location = new System.Drawing.Point(193, 24);
            this.FilenameTextbox.Name = "FilenameTextbox";
            this.FilenameTextbox.ReadOnly = true;
            this.FilenameTextbox.Size = new System.Drawing.Size(954, 26);
            this.FilenameTextbox.TabIndex = 2;
            this.FilenameTextbox.TextChanged += new System.EventHandler(this.FilenameTextbox_TextChanged);
            // 
            // TextfileLabel
            // 
            this.TextfileLabel.AutoSize = true;
            this.TextfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextfileLabel.Location = new System.Drawing.Point(3, 27);
            this.TextfileLabel.Name = "TextfileLabel";
            this.TextfileLabel.Size = new System.Drawing.Size(175, 20);
            this.TextfileLabel.TabIndex = 3;
            this.TextfileLabel.Text = "Name of File to Search:";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BrowseButton.Location = new System.Drawing.Point(1165, 18);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(153, 38);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RunButton.Location = new System.Drawing.Point(1165, 65);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(153, 38);
            this.RunButton.TabIndex = 7;
            this.RunButton.Text = "Begin Search";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // SubstringLabel
            // 
            this.SubstringLabel.AutoSize = true;
            this.SubstringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SubstringLabel.Location = new System.Drawing.Point(12, 74);
            this.SubstringLabel.Name = "SubstringLabel";
            this.SubstringLabel.Size = new System.Drawing.Size(166, 20);
            this.SubstringLabel.TabIndex = 6;
            this.SubstringLabel.Text = "Word / Phrase to Find:";
            // 
            // SubstringTextbox
            // 
            this.SubstringTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubstringTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SubstringTextbox.Location = new System.Drawing.Point(193, 71);
            this.SubstringTextbox.Name = "SubstringTextbox";
            this.SubstringTextbox.Size = new System.Drawing.Size(954, 26);
            this.SubstringTextbox.TabIndex = 5;
            this.SubstringTextbox.TextChanged += new System.EventHandler(this.SubstringTextbox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select Text File";
            // 
            // textreadWorker
            // 
            this.textreadWorker.WorkerReportsProgress = true;
            this.textreadWorker.WorkerSupportsCancellation = true;
            this.textreadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.textreadWorker_DoWork);
            this.textreadWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.textreadWorker_ProgressChanged);
            this.textreadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.textreadWorker_RunWorkerCompleted);
            // 
            // SearchProgressBar
            // 
            this.SearchProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProgressBar.Location = new System.Drawing.Point(193, 116);
            this.SearchProgressBar.Name = "SearchProgressBar";
            this.SearchProgressBar.Size = new System.Drawing.Size(1125, 23);
            this.SearchProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SearchProgressBar.TabIndex = 8;
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.AutoSize = true;
            this.ProgressBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProgressBarLabel.Location = new System.Drawing.Point(18, 116);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(160, 20);
            this.ProgressBarLabel.TabIndex = 9;
            this.ProgressBarLabel.Text = "File Search Progress:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 790);
            this.Controls.Add(this.ProgressBarLabel);
            this.Controls.Add(this.SearchProgressBar);
            this.Controls.Add(this.StringView);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.SubstringLabel);
            this.Controls.Add(this.SubstringTextbox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.TextfileLabel);
            this.Controls.Add(this.FilenameTextbox);
            this.Controls.Add(this.Status);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Substring Searcher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView StringView;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.TextBox FilenameTextbox;
        private System.Windows.Forms.Label TextfileLabel;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label SubstringLabel;
        private System.Windows.Forms.TextBox SubstringTextbox;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader Line;
        private System.Windows.Forms.ToolStripStatusLabel debug1;
        private System.ComponentModel.BackgroundWorker textreadWorker;
        private System.Windows.Forms.ProgressBar SearchProgressBar;
        private System.Windows.Forms.Label ProgressBarLabel;
    }
}

