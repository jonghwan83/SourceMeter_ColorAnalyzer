namespace SourceMeter_ColorAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenBtn = new System.Windows.Forms.Button();
            this.Logbox = new System.Windows.Forms.ListBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.VoltageTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CurrLabel = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.CurrTextBox = new System.Windows.Forms.TextBox();
            this.MeasureBtn = new System.Windows.Forms.Button();
            this.OpenLabel = new System.Windows.Forms.Label();
            this.OutputDataGrid = new System.Windows.Forms.DataGridView();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SAVEBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ZeroCalBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AbortBtn = new System.Windows.Forms.Button();
            this.OpenVoltageBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SweepTextBox = new System.Windows.Forms.TextBox();
            this.SweepBtn = new System.Windows.Forms.Button();
            this.OpenStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(13, 62);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // Logbox
            // 
            this.Logbox.FormattingEnabled = true;
            this.Logbox.ItemHeight = 12;
            this.Logbox.Location = new System.Drawing.Point(305, 24);
            this.Logbox.Name = "Logbox";
            this.Logbox.Size = new System.Drawing.Size(288, 280);
            this.Logbox.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(12, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.41958F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.58042F));
            this.tableLayoutPanel1.Controls.Add(this.TimeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.VoltageTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CurrLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TimeTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 154);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 87);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(3, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(81, 29);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time [s]";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VoltageTextBox
            // 
            this.VoltageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VoltageTextBox.Location = new System.Drawing.Point(90, 61);
            this.VoltageTextBox.Name = "VoltageTextBox";
            this.VoltageTextBox.Size = new System.Drawing.Size(193, 21);
            this.VoltageTextBox.TabIndex = 3;
            this.VoltageTextBox.TextChanged += new System.EventHandler(this.VoltageTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Voltage [V]";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrLabel
            // 
            this.CurrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrLabel.AutoSize = true;
            this.CurrLabel.Location = new System.Drawing.Point(3, 29);
            this.CurrLabel.Name = "CurrLabel";
            this.CurrLabel.Size = new System.Drawing.Size(81, 29);
            this.CurrLabel.TabIndex = 1;
            this.CurrLabel.Text = "Current [µA]";
            this.CurrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTextBox.Location = new System.Drawing.Point(90, 3);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(193, 21);
            this.TimeTextBox.TabIndex = 2;
            this.TimeTextBox.TextChanged += new System.EventHandler(this.TimeTextBox_TextChanged);
            // 
            // CurrTextBox
            // 
            this.CurrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrTextBox.Location = new System.Drawing.Point(90, 32);
            this.CurrTextBox.Name = "CurrTextBox";
            this.CurrTextBox.Size = new System.Drawing.Size(193, 21);
            this.CurrTextBox.TabIndex = 3;
            this.CurrTextBox.TextChanged += new System.EventHandler(this.CurrTextBox_TextChanged);
            // 
            // MeasureBtn
            // 
            this.MeasureBtn.Location = new System.Drawing.Point(12, 317);
            this.MeasureBtn.Name = "MeasureBtn";
            this.MeasureBtn.Size = new System.Drawing.Size(75, 23);
            this.MeasureBtn.TabIndex = 4;
            this.MeasureBtn.Text = "Measure";
            this.MeasureBtn.UseVisualStyleBackColor = true;
            this.MeasureBtn.Click += new System.EventHandler(this.MeasureBtn_Click);
            // 
            // OpenLabel
            // 
            this.OpenLabel.AutoSize = true;
            this.OpenLabel.Location = new System.Drawing.Point(94, 67);
            this.OpenLabel.Name = "OpenLabel";
            this.OpenLabel.Size = new System.Drawing.Size(76, 12);
            this.OpenLabel.TabIndex = 5;
            this.OpenLabel.Text = "curent mode";
            this.OpenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputDataGrid
            // 
            this.OutputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputDataGrid.Location = new System.Drawing.Point(12, 348);
            this.OutputDataGrid.Name = "OutputDataGrid";
            this.OutputDataGrid.RowTemplate.Height = 23;
            this.OutputDataGrid.Size = new System.Drawing.Size(581, 226);
            this.OutputDataGrid.TabIndex = 6;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(93, 322);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 12);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log";
            // 
            // SAVEBtn
            // 
            this.SAVEBtn.Location = new System.Drawing.Point(518, 319);
            this.SAVEBtn.Name = "SAVEBtn";
            this.SAVEBtn.Size = new System.Drawing.Size(75, 23);
            this.SAVEBtn.TabIndex = 9;
            this.SAVEBtn.Text = "SAVE";
            this.SAVEBtn.UseVisualStyleBackColor = true;
            this.SAVEBtn.Click += new System.EventHandler(this.SAVEBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(437, 319);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ZeroCalBtn
            // 
            this.ZeroCalBtn.Location = new System.Drawing.Point(13, 283);
            this.ZeroCalBtn.Name = "ZeroCalBtn";
            this.ZeroCalBtn.Size = new System.Drawing.Size(75, 23);
            this.ZeroCalBtn.TabIndex = 11;
            this.ZeroCalBtn.Text = "Zero Cal";
            this.ZeroCalBtn.UseVisualStyleBackColor = true;
            this.ZeroCalBtn.Click += new System.EventHandler(this.ZeroCalBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "CA210/CA310";
            // 
            // AbortBtn
            // 
            this.AbortBtn.Location = new System.Drawing.Point(205, 317);
            this.AbortBtn.Name = "AbortBtn";
            this.AbortBtn.Size = new System.Drawing.Size(75, 23);
            this.AbortBtn.TabIndex = 13;
            this.AbortBtn.Text = "Abort";
            this.AbortBtn.UseVisualStyleBackColor = true;
            this.AbortBtn.Click += new System.EventHandler(this.AbortBtn_Click);
            // 
            // OpenVoltageBtn
            // 
            this.OpenVoltageBtn.Location = new System.Drawing.Point(12, 33);
            this.OpenVoltageBtn.Name = "OpenVoltageBtn";
            this.OpenVoltageBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenVoltageBtn.TabIndex = 15;
            this.OpenVoltageBtn.Text = "Open";
            this.OpenVoltageBtn.UseVisualStyleBackColor = true;
            this.OpenVoltageBtn.Click += new System.EventHandler(this.OpenVoltageBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "voltage mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "start, stop, step";
            // 
            // SweepTextBox
            // 
            this.SweepTextBox.Location = new System.Drawing.Point(111, 126);
            this.SweepTextBox.Name = "SweepTextBox";
            this.SweepTextBox.Size = new System.Drawing.Size(92, 21);
            this.SweepTextBox.TabIndex = 18;
            this.SweepTextBox.TextChanged += new System.EventHandler(this.SweepTextBox_TextChanged);
            // 
            // SweepBtn
            // 
            this.SweepBtn.Location = new System.Drawing.Point(211, 125);
            this.SweepBtn.Name = "SweepBtn";
            this.SweepBtn.Size = new System.Drawing.Size(75, 23);
            this.SweepBtn.TabIndex = 19;
            this.SweepBtn.Text = "Sweep";
            this.SweepBtn.UseVisualStyleBackColor = true;
            this.SweepBtn.Click += new System.EventHandler(this.SweepBtn_Click);
            // 
            // OpenStatus
            // 
            this.OpenStatus.AutoSize = true;
            this.OpenStatus.Location = new System.Drawing.Point(12, 98);
            this.OpenStatus.Name = "OpenStatus";
            this.OpenStatus.Size = new System.Drawing.Size(119, 12);
            this.OpenStatus.TabIndex = 20;
            this.OpenStatus.Text = "source: Not Opened";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 584);
            this.Controls.Add(this.OpenStatus);
            this.Controls.Add(this.SweepBtn);
            this.Controls.Add(this.SweepTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OpenVoltageBtn);
            this.Controls.Add(this.AbortBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZeroCalBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SAVEBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.OutputDataGrid);
            this.Controls.Add(this.OpenLabel);
            this.Controls.Add(this.MeasureBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Logbox);
            this.Controls.Add(this.OpenBtn);
            this.Name = "Form1";
            this.Text = "TEG tester (Park Jonghwan)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.ListBox Logbox;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CurrLabel;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.TextBox CurrTextBox;
        private System.Windows.Forms.Button MeasureBtn;
        private System.Windows.Forms.Label OpenLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SAVEBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ZeroCalBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AbortBtn;
        public System.Windows.Forms.DataGridView OutputDataGrid;
        private System.Windows.Forms.Button OpenVoltageBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SweepTextBox;
        private System.Windows.Forms.Button SweepBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VoltageTextBox;
        private System.Windows.Forms.Label OpenStatus;
    }
}

