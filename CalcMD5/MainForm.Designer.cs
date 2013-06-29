namespace CalcMD5
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MD5HashLabel = new System.Windows.Forms.Label();
            this.MD5HashTextBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.ComputeMD5Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MD5HashLabel
            // 
            this.MD5HashLabel.AutoSize = true;
            this.MD5HashLabel.Location = new System.Drawing.Point(12, 59);
            this.MD5HashLabel.Name = "MD5HashLabel";
            this.MD5HashLabel.Size = new System.Drawing.Size(58, 12);
            this.MD5HashLabel.TabIndex = 0;
            this.MD5HashLabel.Text = "MD5 Hash";
            // 
            // MD5HashTextBox
            // 
            this.MD5HashTextBox.Location = new System.Drawing.Point(76, 56);
            this.MD5HashTextBox.Name = "MD5HashTextBox";
            this.MD5HashTextBox.Size = new System.Drawing.Size(216, 19);
            this.MD5HashTextBox.TabIndex = 1;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 24);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(24, 12);
            this.FileNameLabel.TabIndex = 2;
            this.FileNameLabel.Text = "File";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.AllowDrop = true;
            this.FileNameTextBox.Location = new System.Drawing.Point(76, 21);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(216, 19);
            this.FileNameTextBox.TabIndex = 3;
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(298, 19);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(60, 23);
            this.FileSelectButton.TabIndex = 4;
            this.FileSelectButton.Text = "Browse";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // ComputeMD5Button
            // 
            this.ComputeMD5Button.Location = new System.Drawing.Point(298, 54);
            this.ComputeMD5Button.Name = "ComputeMD5Button";
            this.ComputeMD5Button.Size = new System.Drawing.Size(60, 23);
            this.ComputeMD5Button.TabIndex = 5;
            this.ComputeMD5Button.Text = "Compute";
            this.ComputeMD5Button.UseVisualStyleBackColor = true;
            this.ComputeMD5Button.Click += new System.EventHandler(this.ComputeMD5Button_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 99);
            this.Controls.Add(this.ComputeMD5Button);
            this.Controls.Add(this.FileSelectButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.MD5HashTextBox);
            this.Controls.Add(this.MD5HashLabel);
            this.Name = "MainForm";
            this.Text = "MD5 Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MD5HashLabel;
        private System.Windows.Forms.TextBox MD5HashTextBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button FileSelectButton;
        private System.Windows.Forms.Button ComputeMD5Button;
    }
}

