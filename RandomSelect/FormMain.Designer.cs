namespace RandomSelect
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSelectedImage = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSimpleRandomNumber = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSimpleRandomNumber = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonRandomNumberGeneratorTime = new System.Windows.Forms.RadioButton();
            this.radioButtonRandomNumberGeneratorSeed = new System.Windows.Forms.RadioButton();
            this.radioButtonRandomNumberGeneratorSecurity = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddCharacter = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.AutoWordSelection = true;
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxLog.Location = new System.Drawing.Point(20, 673);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(860, 107);
            this.richTextBoxLog.TabIndex = 200;
            this.richTextBoxLog.Text = "";
            // 
            // pictureBoxSelectedImage
            // 
            this.pictureBoxSelectedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSelectedImage.Location = new System.Drawing.Point(547, 63);
            this.pictureBoxSelectedImage.Name = "pictureBoxSelectedImage";
            this.pictureBoxSelectedImage.Size = new System.Drawing.Size(333, 293);
            this.pictureBoxSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSelectedImage.TabIndex = 1;
            this.pictureBoxSelectedImage.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEnable,
            this.ColumnImage,
            this.ColumnName,
            this.ColumnCaption});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(20, 92);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(333, 575);
            this.dataGridView1.TabIndex = 200;
            // 
            // ColumnEnable
            // 
            this.ColumnEnable.DataPropertyName = "enable";
            this.ColumnEnable.HeaderText = "활성화";
            this.ColumnEnable.Name = "ColumnEnable";
            this.ColumnEnable.Width = 60;
            // 
            // ColumnImage
            // 
            this.ColumnImage.DataPropertyName = "image";
            this.ColumnImage.HeaderText = "이미지";
            this.ColumnImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.Width = 80;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "name";
            this.ColumnName.HeaderText = "이름";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 90;
            // 
            // ColumnCaption
            // 
            this.ColumnCaption.DataPropertyName = "caption";
            this.ColumnCaption.HeaderText = "내용";
            this.ColumnCaption.Name = "ColumnCaption";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 10F);
            this.button1.Location = new System.Drawing.Point(20, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 200;
            this.button1.Text = "전체 활성화";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 10F);
            this.button2.Location = new System.Drawing.Point(120, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 200;
            this.button2.Text = "전체 비활성화";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSimpleRandomNumber
            // 
            this.buttonSimpleRandomNumber.Location = new System.Drawing.Point(10, 74);
            this.buttonSimpleRandomNumber.Name = "buttonSimpleRandomNumber";
            this.buttonSimpleRandomNumber.Size = new System.Drawing.Size(75, 23);
            this.buttonSimpleRandomNumber.TabIndex = 2;
            this.buttonSimpleRandomNumber.Text = "숫자뽑기";
            this.buttonSimpleRandomNumber.UseVisualStyleBackColor = true;
            this.buttonSimpleRandomNumber.Click += new System.EventHandler(this.buttonSimpleRandomNumber_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSimpleRandomNumber);
            this.groupBox1.Controls.Add(this.numericUpDownMax);
            this.groupBox1.Controls.Add(this.numericUpDownMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSimpleRandomNumber);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 10F);
            this.groupBox1.Location = new System.Drawing.Point(369, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "단순 숫자 뽑기";
            // 
            // labelSimpleRandomNumber
            // 
            this.labelSimpleRandomNumber.AutoSize = true;
            this.labelSimpleRandomNumber.Location = new System.Drawing.Point(135, 79);
            this.labelSimpleRandomNumber.Name = "labelSimpleRandomNumber";
            this.labelSimpleRandomNumber.Size = new System.Drawing.Size(0, 14);
            this.labelSimpleRandomNumber.TabIndex = 8;
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(96, 43);
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(58, 23);
            this.numericUpDownMax.TabIndex = 1;
            this.numericUpDownMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMax.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(11, 43);
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(58, 23);
            this.numericUpDownMin.TabIndex = 0;
            this.numericUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "결과 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "최대";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "최소";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonRandomNumberGeneratorTime);
            this.groupBox2.Controls.Add(this.radioButtonRandomNumberGeneratorSeed);
            this.groupBox2.Controls.Add(this.radioButtonRandomNumberGeneratorSecurity);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 10F);
            this.groupBox2.Location = new System.Drawing.Point(369, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 109);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "랜덤 생성 방식";
            // 
            // radioButtonRandomNumberGeneratorTime
            // 
            this.radioButtonRandomNumberGeneratorTime.AutoSize = true;
            this.radioButtonRandomNumberGeneratorTime.Location = new System.Drawing.Point(16, 74);
            this.radioButtonRandomNumberGeneratorTime.Name = "radioButtonRandomNumberGeneratorTime";
            this.radioButtonRandomNumberGeneratorTime.Size = new System.Drawing.Size(53, 18);
            this.radioButtonRandomNumberGeneratorTime.TabIndex = 5;
            this.radioButtonRandomNumberGeneratorTime.Text = "시간";
            this.radioButtonRandomNumberGeneratorTime.UseVisualStyleBackColor = true;
            this.radioButtonRandomNumberGeneratorTime.CheckedChanged += new System.EventHandler(this.radioButtonRandomNumberGenerator_CheckedChanged);
            // 
            // radioButtonRandomNumberGeneratorSeed
            // 
            this.radioButtonRandomNumberGeneratorSeed.AutoSize = true;
            this.radioButtonRandomNumberGeneratorSeed.Location = new System.Drawing.Point(16, 52);
            this.radioButtonRandomNumberGeneratorSeed.Name = "radioButtonRandomNumberGeneratorSeed";
            this.radioButtonRandomNumberGeneratorSeed.Size = new System.Drawing.Size(53, 18);
            this.radioButtonRandomNumberGeneratorSeed.TabIndex = 4;
            this.radioButtonRandomNumberGeneratorSeed.Text = "시드";
            this.radioButtonRandomNumberGeneratorSeed.UseVisualStyleBackColor = true;
            this.radioButtonRandomNumberGeneratorSeed.CheckedChanged += new System.EventHandler(this.radioButtonRandomNumberGenerator_CheckedChanged);
            // 
            // radioButtonRandomNumberGeneratorSecurity
            // 
            this.radioButtonRandomNumberGeneratorSecurity.AutoSize = true;
            this.radioButtonRandomNumberGeneratorSecurity.Checked = true;
            this.radioButtonRandomNumberGeneratorSecurity.Location = new System.Drawing.Point(16, 30);
            this.radioButtonRandomNumberGeneratorSecurity.Name = "radioButtonRandomNumberGeneratorSecurity";
            this.radioButtonRandomNumberGeneratorSecurity.Size = new System.Drawing.Size(67, 18);
            this.radioButtonRandomNumberGeneratorSecurity.TabIndex = 3;
            this.radioButtonRandomNumberGeneratorSecurity.TabStop = true;
            this.radioButtonRandomNumberGeneratorSecurity.Text = "암호화";
            this.radioButtonRandomNumberGeneratorSecurity.UseVisualStyleBackColor = true;
            this.radioButtonRandomNumberGeneratorSecurity.CheckedChanged += new System.EventHandler(this.radioButtonRandomNumberGenerator_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(369, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 374);
            this.groupBox3.TabIndex = 201;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "랜덤 선택";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(547, 362);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 80;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(333, 305);
            this.dataGridView2.TabIndex = 202;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "enable";
            this.dataGridViewCheckBoxColumn1.HeaderText = "활성화";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "image";
            this.dataGridViewImageColumn1.HeaderText = "이미지";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "이름";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "caption";
            this.dataGridViewTextBoxColumn2.HeaderText = "내용";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // buttonAddCharacter
            // 
            this.buttonAddCharacter.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonAddCharacter.Location = new System.Drawing.Point(255, 63);
            this.buttonAddCharacter.Name = "buttonAddCharacter";
            this.buttonAddCharacter.Size = new System.Drawing.Size(46, 23);
            this.buttonAddCharacter.TabIndex = 200;
            this.buttonAddCharacter.Text = "추가";
            this.buttonAddCharacter.UseVisualStyleBackColor = true;
            this.buttonAddCharacter.Click += new System.EventHandler(this.buttonAddCharacter_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 10F);
            this.button4.Location = new System.Drawing.Point(307, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 23);
            this.button4.TabIndex = 200;
            this.button4.Text = "삭제";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAddCharacter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxSelectedImage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBoxLog);
            this.Name = "FormMain";
            this.Resizable = false;
            this.Text = "Random select";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.PictureBox pictureBoxSelectedImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEnable;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCaption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSimpleRandomNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonRandomNumberGeneratorTime;
        private System.Windows.Forms.RadioButton radioButtonRandomNumberGeneratorSeed;
        private System.Windows.Forms.RadioButton radioButtonRandomNumberGeneratorSecurity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSimpleRandomNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonAddCharacter;
        private System.Windows.Forms.Button button4;
    }
}

