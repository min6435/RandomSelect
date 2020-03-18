using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomSelect
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        private RandomNumberGenerator randomNumberGenerator;
        private string saveDirectoryPath = string.Empty;
        private string jsonFilePath = string.Empty;

        public FormMain()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            dataGridViewMain.AutoGenerateColumns = false;
            dataGridViewWinner.AutoGenerateColumns = false;
            pictureBoxSelectedImage.Image = Properties.Resources.DefaultImage;

            string[] seedStringArray = null;
            int randomNumberSeedCount = 0;
            if(int.TryParse(AppConfiguration.GetAppConfig("Random_number_seed_count"), out randomNumberSeedCount))
            {
                seedStringArray = new string[randomNumberSeedCount];
                for (int i=0; i< randomNumberSeedCount; i++ )
                {
                    seedStringArray[i] = AppConfiguration.GetAppConfig($@"Seed_{(i+1).ToString("00")}");
                }
            }
            randomNumberGenerator = new RandomNumberGenerator(seedStringArray);

            saveDirectoryPath = AppConfiguration.GetAppConfig("Save_directory_path");
            saveDirectoryPath = KeywordPathManager.GetOriginalPath(saveDirectoryPath); //null, empty인 경우 바탕화면으로 설정됨.

            jsonFilePath = AppConfiguration.GetAppConfig("Json_file_path");
            if (string.IsNullOrEmpty(jsonFilePath) == false)
            {
                jsonFilePath = KeywordPathManager.GetOriginalPath(jsonFilePath);
                JsonCharacter jsonCharacter = new JsonCharacter();
                if (JsonCharacter.LoadJsonFile(jsonFilePath, out jsonCharacter) == false)
                {
                    MessageBox.Show($@"Json 파일 읽어오기 실패.{Environment.NewLine}{AppConfiguration.GetAppConfig("Json_file_path")}");
                    jsonFilePath = string.Empty;
                }
                else
                    JsonCharacter.SetInstance(jsonCharacter);
            }
            
            dataGridViewMain.DataSource = new BindingList<Character>(JsonCharacter.GetInstance().characterList);
        }

        private void buttonSimpleRandomNumber_Click(object sender, EventArgs e)
        {
            labelSimpleRandomNumber.Text = randomNumberGenerator.Generate((int)numericUpDownMin.Value, (int)numericUpDownMax.Value).ToString();
        }

        private void radioButtonRandomNumberGenerator_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRandomNumberGeneratorSecurity.Checked == true)
                randomNumberGenerator.generateMode = RandomNumberGenerator.GenerateMode.Security;
            else if(radioButtonRandomNumberGeneratorSeed.Checked == true)
                randomNumberGenerator.generateMode = RandomNumberGenerator.GenerateMode.Seed;
            else if (radioButtonRandomNumberGeneratorTime.Checked == true)
                randomNumberGenerator.generateMode = RandomNumberGenerator.GenerateMode.Time;
        }

        private void buttonAddCharacter_Click(object sender, EventArgs e)
        {
            JsonCharacter.GetInstance().characterList.Add(new Character(true,
                                                                        Properties.Resources.DefaultImage,
                                                                        "DefaultImage.gif",
                                                                        string.Empty,
                                                                        string.Empty));
            
            //데이터 리바인딩(데이터 갱신)
            dataGridViewMain.DataSource = new BindingList<Character>(JsonCharacter.GetInstance().characterList);
            //자동 스크롤
            dataGridViewMain.Rows[JsonCharacter.GetInstance().characterList.Count()-1].Selected = true;
            dataGridViewMain.FirstDisplayedScrollingRowIndex = JsonCharacter.GetInstance().characterList.Count()-1;
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(saveDirectoryPath);

            saveJsonFileDialog.InitialDirectory = saveDirectoryPath;
            saveJsonFileDialog.FileName = string.Empty;
            if (DialogResult.OK != saveJsonFileDialog.ShowDialog())
                return;
            
            JsonCharacter.GetInstance().SaveJsonFile(saveJsonFileDialog.FileName);
            jsonFilePath = $@"{JsonCharacter.GetInstance().rootPath}\{Path.GetFileName(saveJsonFileDialog.FileName)}";
            AppConfiguration.SetAppConfig("Json_file_path", KeywordPathManager.GetKeywordPath($@"{JsonCharacter.GetInstance().rootPath}\{Path.GetFileName(saveJsonFileDialog.FileName)}"));
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openJsonFileDialog.InitialDirectory = saveDirectoryPath;
            openJsonFileDialog.FileName = string.Empty;
            if (DialogResult.OK != openJsonFileDialog.ShowDialog())
                return;

            jsonFilePath = openJsonFileDialog.FileName;
            JsonCharacter jsonCharacter = new JsonCharacter();
            if (JsonCharacter.LoadJsonFile(jsonFilePath, out jsonCharacter) == false)
                MessageBox.Show($@"Json 파일 오류. {AppConfiguration.GetAppConfig("Json_file_path")}");
            else
                JsonCharacter.SetInstance(jsonCharacter);

            dataGridViewMain.DataSource = new BindingList<Character>(JsonCharacter.GetInstance().characterList);
            AppConfiguration.SetAppConfig("Json_file_path", KeywordPathManager.GetKeywordPath(jsonFilePath));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.SelectedRows.Count < 1)
                return;

            //자동 스크롤을 위한 변수 저장
            int scrollIndex = dataGridViewMain.FirstDisplayedScrollingRowIndex;
            int selectedIndex = dataGridViewMain.SelectedRows[0].Index;
            //선택 데이터 삭제
            JsonCharacter.GetInstance().characterList.Remove(dataGridViewMain.SelectedRows[0].DataBoundItem as Character);
            //데이터 리바인딩(데이터 갱신)
            dataGridViewMain.DataSource = new BindingList<Character>(JsonCharacter.GetInstance().characterList);
            //자동 스크롤
            if (JsonCharacter.GetInstance().characterList.Count > 0)
            {
                dataGridViewMain.Rows[selectedIndex == 0 ? 0 : selectedIndex - 1].Selected = true;
                dataGridViewMain.FirstDisplayedScrollingRowIndex = scrollIndex;
            }
        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count < 1)
                return;

            if ((sender as DataGridView).Columns[e.ColumnIndex].Name == ColumnEnable.Name)
            {
                //값 변경 후 EndEdit를 해줘야 클릭 이벤트마다 즉시 값을 적용함. (더블클릭 이벤트에도 넣어줘야 함.)
                ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Character).enable = !((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Character).enable;

                if(((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Character).enable == false)
                {
                    //numericUpDownRandomSelectCount 최대값 확인
                    numericUpDownRandomSelectCount_ValueChanged(numericUpDownRandomSelectCount, null);
                }

                //자동 스크롤을 위한 변수 저장
                int scrollIndex = (sender as DataGridView).FirstDisplayedScrollingRowIndex;
                int selectedIndex = (sender as DataGridView).SelectedRows[0].Index;
                //데이터 리바인딩(데이터 갱신)
                (sender as DataGridView).DataSource = new BindingList<Character>(JsonCharacter.GetInstance().characterList);
                //자동 스크롤
                (sender as DataGridView).Rows[selectedIndex].Selected = true;
                (sender as DataGridView).FirstDisplayedScrollingRowIndex = scrollIndex;
            }
            else if((sender as DataGridView).Columns[e.ColumnIndex].Name == ColumnImage.Name)
            {
                openImageFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                openImageFileDialog.FileName = string.Empty;
                if (DialogResult.OK != openImageFileDialog.ShowDialog())
                    return;

                try
                {
                    //File lock이 되므로 코드 변경함.
                    //((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Character).image = Image.FromFile(openImageFileDialog.FileName);
                    using (FileStream fileStream = new FileStream(openImageFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Character).image = Image.FromStream(fileStream);
                        fileStream.Close();
                    }
                    ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Character).imageFileName = openImageFileDialog.SafeFileName;
                    ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Character).name = Path.GetFileNameWithoutExtension(openImageFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("이미지 파일만 열 수 있습니다.");
                    return;
                }

                //자동 스크롤을 위한 변수 저장
                int scrollIndex = (sender as DataGridView).FirstDisplayedScrollingRowIndex;
                int selectedIndex = (sender as DataGridView).SelectedRows[0].Index;
                //데이터 리바인딩(데이터 갱신)
                (sender as DataGridView).DataSource = new BindingList<Character>(JsonCharacter.GetInstance().characterList);
                //자동 스크롤
                (sender as DataGridView).Rows[selectedIndex].Selected = true;
                (sender as DataGridView).FirstDisplayedScrollingRowIndex = scrollIndex;
            }
        }

        private void dataGridViewWinner_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count < 1)
                return;

            pictureBoxSelectedImage.Image = ((sender as DataGridView).SelectedRows[0].DataBoundItem as Character).image;
        }

        private void buttonEnableAll_Click(object sender, EventArgs e)
        {
            foreach(Character character in JsonCharacter.GetInstance().characterList)
                character.enable = true;

            //자동 스크롤을 위한 변수 저장
            int scrollIndex = dataGridViewMain.FirstDisplayedScrollingRowIndex;
            int selectedIndex = dataGridViewMain.SelectedRows[0].Index;
            //데이터 리바인딩(데이터 갱신)
            dataGridViewMain.DataSource = new BindingList<Character>(JsonCharacter.GetInstance().characterList);
            //자동 스크롤
            dataGridViewMain.Rows[selectedIndex].Selected = true;
            dataGridViewMain.FirstDisplayedScrollingRowIndex = scrollIndex;
        }

        private void buttonDisableAll_Click(object sender, EventArgs e)
        {
            foreach (Character character in JsonCharacter.GetInstance().characterList)
                character.enable = false;

            //자동 스크롤을 위한 변수 저장
            int scrollIndex = dataGridViewMain.FirstDisplayedScrollingRowIndex;
            int selectedIndex = dataGridViewMain.SelectedRows[0].Index;
            //데이터 리바인딩(데이터 갱신)
            dataGridViewMain.DataSource = new BindingList<Character>(JsonCharacter.GetInstance().characterList);
            //자동 스크롤
            dataGridViewMain.Rows[selectedIndex].Selected = true;
            dataGridViewMain.FirstDisplayedScrollingRowIndex = scrollIndex;

            numericUpDownRandomSelectCount.Value = 0;
        }

        private void numericUpDownRandomSelectCount_ValueChanged(object sender, EventArgs e)
        {
            //Linq 쿼리문으로 enable갯수 카운트
            int enableCount = (from character in JsonCharacter.GetInstance().characterList
                               where character.enable == true
                               select character).Count();

            if ((sender as NumericUpDown).Value > enableCount)
                (sender as NumericUpDown).Value = enableCount;
        }

        private void buttonRandomSelect_Click(object sender, EventArgs e)
        {
            List<Character> enableCharacterList = (from character in JsonCharacter.GetInstance().characterList
                                                   where character.enable == true
                                                   select character).ToList();

            if (numericUpDownRandomSelectCount.Value == enableCharacterList.Count)
            {
                //전부 당첨자
                foreach (Character character in enableCharacterList)
                    character.setWinning(true);
            }
            else
            {
                foreach (Character character in enableCharacterList)
                    character.setWinning(false);

                var winningCount = numericUpDownRandomSelectCount.Value;
                while (winningCount > 0)
                {
                    var randomNumber = randomNumberGenerator.Generate(0, enableCharacterList.Count - 1);
                    if (enableCharacterList[randomNumber].getWinning() == false)
                    {
                        enableCharacterList[randomNumber].setWinning(true);
                        winningCount--;
                    }
                }
            }

            dataGridViewWinner.DataSource = new BindingList<Character>((from character in enableCharacterList
                                                                        where character.getWinning() == true
                                                                        select character).ToList());
        }

        private void buttonOpenSaveDirectoryPath_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(saveDirectoryPath);
            Process.Start(saveDirectoryPath);
        }

        private void buttonSetSaveDirectoryPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = saveDirectoryPath;
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;

            saveDirectoryPath = folderBrowserDialog.SelectedPath;
            AppConfiguration.SetAppConfig("Save_directory_path", KeywordPathManager.GetKeywordPath(folderBrowserDialog.SelectedPath));
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //teachingTarget 변경점이 있는 경우, 저장할거냐고 물어봄.
            if (string.IsNullOrEmpty(JsonCharacter.GetInstance().GetOriginalJsonString()))
            {
                DialogResult dialogResult = MessageBox.Show("새로 저장하시겠습니까?", "Question", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    buttonSaveAs_Click(null, null);
                }
            }
            else if (JsonCharacter.GetInstance().GetOriginalJsonString() != JsonCharacter.GetInstance().ConvertJsonString())
            {
                DialogResult dialogResult = MessageBox.Show("변경사항을 저장하시겠습니까?", "Question", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    buttonSave_Click(null, null);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(jsonFilePath) == true)
                return;

            JsonCharacter.GetInstance().SaveJsonFile(KeywordPathManager.GetOriginalPath(jsonFilePath), true);
            AppConfiguration.SetAppConfig("Json_file_path", KeywordPathManager.GetKeywordPath(jsonFilePath));
        }
    }
}
