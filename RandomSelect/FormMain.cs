using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSelect
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        private const int DEFAULT_MAX_CHARACTER = 12;
        private readonly int MAX_CHARACTER;
        private string imageRootPath = string.Empty;
        private List<Character> characterList = new List<Character>();
        private RandomNumberGenerator randomNumberGenerator;

        public FormMain()
        {
            InitializeComponent();

            //readonly 키워드로 인해 생성자에서만 작성 가능.
            if (int.TryParse(AppConfiguration.GetAppConfig("MaxCharacter"), out MAX_CHARACTER) == false)
            {
                richTextBoxLog.AppendText(Properties.Resources.AppSettingsError_MaxCharacter);
                MAX_CHARACTER = DEFAULT_MAX_CHARACTER;
            }

            Initialize();
        }

        private void Initialize()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            randomNumberGenerator = new RandomNumberGenerator(new string[] { string.Empty });
            pictureBoxSelectedImage.Image = Properties.Resources.Default;
            dataGridView1.DataSource = new BindingList<Character>(characterList);

            imageRootPath = ImagePathManager.ValidateImageRootPath(AppConfiguration.GetAppConfig("ImageRootPath"));



            
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
            (dataGridView1.DataSource as BindingList<Character>).Add(new Character(true,
                                                                                    Properties.Resources.Default,
                                                                                    "test",
                                                                                    "testcaption"));
        }
    }
}
