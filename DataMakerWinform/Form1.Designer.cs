namespace DataMakerWinform
{
    partial class Form1
    {
        //设计器变量
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            this.luckyNum = new System.Windows.Forms.GroupBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.rTb = new System.Windows.Forms.RichTextBox();
            this.luckyNum.SuspendLayout();
            this.total.SuspendLayout();
            this.SuspendLayout();
            // 
            // luckyNum
            // 
            this.luckyNum.Controls.Add(this.resultText);
            this.luckyNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luckyNum.Location = new System.Drawing.Point(0, 0);
            this.luckyNum.Margin = new System.Windows.Forms.Padding(4);
            this.luckyNum.Name = "luckyNum";
            this.luckyNum.Padding = new System.Windows.Forms.Padding(4);
            this.luckyNum.Size = new System.Drawing.Size(1125, 498);
            this.luckyNum.TabIndex = 0;
            this.luckyNum.TabStop = false;
            this.luckyNum.Text = "生成的随机量";
            // 
            // resultText
            // 
            this.resultText.Font = new System.Drawing.Font("宋体", 15F);
            this.resultText.Location = new System.Drawing.Point(21, 29);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(869, 438);
            this.resultText.TabIndex = 0;
            this.resultText.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // total
            // 
            this.total.Controls.Add(this.startButton);
            this.total.Controls.Add(this.rTb);
            this.total.Dock = System.Windows.Forms.DockStyle.Right;
            this.total.Location = new System.Drawing.Point(933, 0);
            this.total.Margin = new System.Windows.Forms.Padding(4);
            this.total.Name = "total";
            this.total.Padding = new System.Windows.Forms.Padding(4);
            this.total.Size = new System.Drawing.Size(192, 498);
            this.total.TabIndex = 1;
            this.total.TabStop = false;
            this.total.Text = "总数";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(7, 332);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(177, 80);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // rTb
            // 
            this.rTb.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rTb.Location = new System.Drawing.Point(8, 25);
            this.rTb.Margin = new System.Windows.Forms.Padding(4);
            this.rTb.Name = "rTb";
            this.rTb.Size = new System.Drawing.Size(171, 45);
            this.rTb.TabIndex = 0;
            this.rTb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 498);
            this.Controls.Add(this.total);
            this.Controls.Add(this.luckyNum);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "随机数生成";
            this.luckyNum.ResumeLayout(false);
            this.luckyNum.PerformLayout();
            this.total.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox luckyNum;
        private System.Windows.Forms.GroupBox total;
        private System.Windows.Forms.RichTextBox rTb;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox resultText;
    }
}

