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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxSelectedImage = new System.Windows.Forms.PictureBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ColumnEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEnableAll = new System.Windows.Forms.Button();
            this.buttonDisableAll = new System.Windows.Forms.Button();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownRandomSelectCount = new System.Windows.Forms.NumericUpDown();
            this.buttonRandomSelect = new System.Windows.Forms.Button();
            this.buttonAddCharacter = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.saveJsonFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openJsonFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewWinner = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOpenSaveDirectoryPath = new System.Windows.Forms.Button();
            this.buttonSetSaveDirectoryPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomSelectCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWinner)).BeginInit();
            this.SuspendLayout();
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
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToResizeRows = false;
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEnable,
            this.ColumnImage,
            this.ColumnName,
            this.ColumnCaption});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewMain.Location = new System.Drawing.Point(20, 92);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowTemplate.Height = 80;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.ShowCellErrors = false;
            this.dataGridViewMain.Size = new System.Drawing.Size(333, 575);
            this.dataGridViewMain.TabIndex = 200;
            this.dataGridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellClick);
            this.dataGridViewMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellClick);
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
            // buttonEnableAll
            // 
            this.buttonEnableAll.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonEnableAll.Location = new System.Drawing.Point(20, 63);
            this.buttonEnableAll.Name = "buttonEnableAll";
            this.buttonEnableAll.Size = new System.Drawing.Size(94, 23);
            this.buttonEnableAll.TabIndex = 200;
            this.buttonEnableAll.Text = "전체 활성화";
            this.buttonEnableAll.UseVisualStyleBackColor = true;
            this.buttonEnableAll.Click += new System.EventHandler(this.buttonEnableAll_Click);
            // 
            // buttonDisableAll
            // 
            this.buttonDisableAll.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonDisableAll.Location = new System.Drawing.Point(120, 63);
            this.buttonDisableAll.Name = "buttonDisableAll";
            this.buttonDisableAll.Size = new System.Drawing.Size(106, 23);
            this.buttonDisableAll.TabIndex = 200;
            this.buttonDisableAll.Text = "전체 비활성화";
            this.buttonDisableAll.UseVisualStyleBackColor = true;
            this.buttonDisableAll.Click += new System.EventHandler(this.buttonDisableAll_Click);
            // 
            // buttonSimpleRandomNumber
            // 
            this.buttonSimpleRandomNumber.Location = new System.Drawing.Point(10, 74);
            this.buttonSimpleRandomNumber.Name = "buttonSimpleRandomNumber";
            this.buttonSimpleRandomNumber.Size = new System.Drawing.Size(75, 23);
            this.buttonSimpleRandomNumber.TabIndex = 2;
            this.buttonSimpleRandomNumber.Text = "시작";
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
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numericUpDownRandomSelectCount);
            this.groupBox3.Controls.Add(this.buttonRandomSelect);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 10F);
            this.groupBox3.Location = new System.Drawing.Point(369, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 87);
            this.groupBox3.TabIndex = 201;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "랜덤 선택";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "결과 =>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "선택 개수";
            // 
            // numericUpDownRandomSelectCount
            // 
            this.numericUpDownRandomSelectCount.Location = new System.Drawing.Point(90, 22);
            this.numericUpDownRandomSelectCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRandomSelectCount.Name = "numericUpDownRandomSelectCount";
            this.numericUpDownRandomSelectCount.Size = new System.Drawing.Size(58, 23);
            this.numericUpDownRandomSelectCount.TabIndex = 9;
            this.numericUpDownRandomSelectCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRandomSelectCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRandomSelectCount.ValueChanged += new System.EventHandler(this.numericUpDownRandomSelectCount_ValueChanged);
            // 
            // buttonRandomSelect
            // 
            this.buttonRandomSelect.Location = new System.Drawing.Point(16, 51);
            this.buttonRandomSelect.Name = "buttonRandomSelect";
            this.buttonRandomSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomSelect.TabIndex = 0;
            this.buttonRandomSelect.Text = "시작";
            this.buttonRandomSelect.UseVisualStyleBackColor = true;
            this.buttonRandomSelect.Click += new System.EventHandler(this.buttonRandomSelect_Click);
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
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonDelete.Location = new System.Drawing.Point(307, 63);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(46, 23);
            this.buttonDelete.TabIndex = 200;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonSave.Location = new System.Drawing.Point(199, 34);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(74, 23);
            this.buttonSave.TabIndex = 200;
            this.buttonSave.Text = "저장하기";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonLoad.Location = new System.Drawing.Point(279, 34);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(74, 23);
            this.buttonLoad.TabIndex = 200;
            this.buttonLoad.Text = "불러오기";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // saveJsonFileDialog
            // 
            this.saveJsonFileDialog.DefaultExt = "json";
            this.saveJsonFileDialog.Filter = "Json파일|*.json";
            // 
            // openJsonFileDialog
            // 
            this.openJsonFileDialog.DefaultExt = "json";
            this.openJsonFileDialog.Filter = "Json파일|*.json";
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.DefaultExt = "png";
            this.openImageFileDialog.Filter = "PNG파일|*.png|BMP파일|*.bmp|JPG파일|*.jpg|GIF파일|*.gif|모든파일|*.*";
            // 
            // dataGridViewWinner
            // 
            this.dataGridViewWinner.AllowUserToAddRows = false;
            this.dataGridViewWinner.AllowUserToResizeRows = false;
            this.dataGridViewWinner.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWinner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewWinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWinner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWinner.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewWinner.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewWinner.Location = new System.Drawing.Point(547, 371);
            this.dataGridViewWinner.MultiSelect = false;
            this.dataGridViewWinner.Name = "dataGridViewWinner";
            this.dataGridViewWinner.ReadOnly = true;
            this.dataGridViewWinner.RowHeadersVisible = false;
            this.dataGridViewWinner.RowTemplate.Height = 80;
            this.dataGridViewWinner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWinner.ShowCellErrors = false;
            this.dataGridViewWinner.Size = new System.Drawing.Size(333, 296);
            this.dataGridViewWinner.TabIndex = 202;
            this.dataGridViewWinner.SelectionChanged += new System.EventHandler(this.dataGridViewWinner_SelectionChanged);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "enable";
            this.dataGridViewCheckBoxColumn1.HeaderText = "활성화";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "image";
            this.dataGridViewImageColumn1.HeaderText = "이미지";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "이름";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "caption";
            this.dataGridViewTextBoxColumn2.HeaderText = "내용";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // buttonOpenSaveDirectoryPath
            // 
            this.buttonOpenSaveDirectoryPath.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonOpenSaveDirectoryPath.Location = new System.Drawing.Point(359, 34);
            this.buttonOpenSaveDirectoryPath.Name = "buttonOpenSaveDirectoryPath";
            this.buttonOpenSaveDirectoryPath.Size = new System.Drawing.Size(118, 23);
            this.buttonOpenSaveDirectoryPath.TabIndex = 200;
            this.buttonOpenSaveDirectoryPath.Text = "저장 폴더 열기";
            this.buttonOpenSaveDirectoryPath.UseVisualStyleBackColor = true;
            this.buttonOpenSaveDirectoryPath.Click += new System.EventHandler(this.buttonOpenSaveDirectoryPath_Click);
            // 
            // buttonSetSaveDirectoryPath
            // 
            this.buttonSetSaveDirectoryPath.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonSetSaveDirectoryPath.Location = new System.Drawing.Point(483, 34);
            this.buttonSetSaveDirectoryPath.Name = "buttonSetSaveDirectoryPath";
            this.buttonSetSaveDirectoryPath.Size = new System.Drawing.Size(118, 23);
            this.buttonSetSaveDirectoryPath.TabIndex = 200;
            this.buttonSetSaveDirectoryPath.Text = "저장 폴더 설정";
            this.buttonSetSaveDirectoryPath.UseVisualStyleBackColor = true;
            this.buttonSetSaveDirectoryPath.Click += new System.EventHandler(this.buttonSetSaveDirectoryPath_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 12);
            this.label7.TabIndex = 203;
            this.label7.Text = "https://github.com/min6435/RandomSelect";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 690);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewWinner);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDisableAll);
            this.Controls.Add(this.buttonSetSaveDirectoryPath);
            this.Controls.Add(this.buttonOpenSaveDirectoryPath);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddCharacter);
            this.Controls.Add(this.buttonEnableAll);
            this.Controls.Add(this.pictureBoxSelectedImage);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "FormMain";
            this.Resizable = false;
            this.Text = "Random select";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomSelectCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSelectedImage;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEnable;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCaption;
        private System.Windows.Forms.Button buttonEnableAll;
        private System.Windows.Forms.Button buttonDisableAll;
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
        private System.Windows.Forms.Button buttonAddCharacter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.SaveFileDialog saveJsonFileDialog;
        private System.Windows.Forms.OpenFileDialog openJsonFileDialog;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownRandomSelectCount;
        private System.Windows.Forms.Button buttonRandomSelect;
        private System.Windows.Forms.DataGridView dataGridViewWinner;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonOpenSaveDirectoryPath;
        private System.Windows.Forms.Button buttonSetSaveDirectoryPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label7;
    }
}

