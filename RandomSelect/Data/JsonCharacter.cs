using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSelect
{
    public class JsonCharacter : IDisposable
    {
        private static JsonCharacter instance = new JsonCharacter();

        //json에 기록하지 않을 데이터는 private구현
        private const int DEFAULT_MAX_CHARACTER = 12;
        private string originalJsonString = string.Empty;

        //json에 기록할 데이터는 public구현
        public List<Character> characterList = new List<Character>();
        public string rootPath = string.Empty;

        public static JsonCharacter GetInstance()
        {
            if (instance == null)
                instance = new JsonCharacter();

            return instance;
        }

        public static void SetInstance(JsonCharacter jsonCharacter)
        {
            instance?.Dispose();
            instance = jsonCharacter;
        }

        #region IDisposable 구현

        private bool isDisposed = false; // 중복 호출 방지
        protected void Dispose(bool disposing)
        {
            // 메모리 해제 코드
            if (!isDisposed)
            {
                if (disposing)
                {
                    if(characterList != null)
                        foreach (Character character in characterList)
                            character?.Dispose();
                }

                for (int i = 0; i < characterList.Count(); i++)
                    characterList[i] = null;
                characterList = null;

                isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~JsonCharacter()
        {
            Dispose(false);
        }

        #endregion

        public static bool LoadJsonFile(string filePath, out JsonCharacter jsonCharacter)
        {
            if (File.Exists(filePath) == false)
            {
                jsonCharacter = new JsonCharacter();
                return false;
            }

            //파일을 읽어서 Json string 생성
            string jsonString = System.IO.File.ReadAllText(filePath);

            try
            {
                //Json object로 생성
                Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(jsonString);
                //Json object를 JsonCharacter 객체로 형변환 후 Instance로 설정
                jsonCharacter = jObject.ToObject(typeof(JsonCharacter)) as JsonCharacter;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            jsonCharacter.rootPath = KeywordPathManager.GetOriginalPath(jsonCharacter.rootPath);

            for (int i = 0; i < jsonCharacter.characterList.Count(); i++)
            {
                string imageFilePath = $@"{jsonCharacter.rootPath}\{jsonCharacter.characterList[i].imageFileName}";
                if (File.Exists(imageFilePath))
                {
                    //File lock이 되므로 코드 변경함.
                    //jsonCharacter.characterList[i].image = Image.FromFile(imageFilePath);
                    using (FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
                    {
                        jsonCharacter.characterList[i].image = Image.FromStream(fileStream);
                        fileStream.Close();
                    }
                }
                else
                    jsonCharacter.characterList[i].image = Properties.Resources.DefaultImage;
            }

            //창 닫기 전에 변경사항 확인용 원본 저장
            jsonCharacter.originalJsonString = jsonCharacter.ConvertJsonString();

            return true;
        }

        public void SaveJsonFile(string filePath, bool overwrite = false)
        {
            if(overwrite == false)
            {
                rootPath = $@"{Path.GetDirectoryName(filePath)}\{Path.GetFileNameWithoutExtension(filePath)}";
                Directory.CreateDirectory(rootPath);
                filePath = $@"{rootPath}\{Path.GetFileName(filePath)}";
            }

            for (int i = 0; i < characterList.Count(); i++)
            {
                if (File.Exists($@"{rootPath}\{characterList[i].imageFileName}"))
                    File.Delete($@"{rootPath}\{characterList[i].imageFileName}");

                characterList[i].image?.Save($@"{rootPath}\{characterList[i].imageFileName}",
                                                characterList[i].image.RawFormat);
            }

            //Json string으로 변경합니다.
            //창 닫기 전에 변경사항 확인용 원본 저장
            originalJsonString = ConvertJsonString();
            rootPath = KeywordPathManager.GetKeywordPath(rootPath);

            //파일로 저장합니다.
            File.WriteAllText(filePath, originalJsonString);
        }

        public string ConvertJsonString()
        {
            Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.FromObject(this);
            string jsonString = jObject.ToString();
            jsonString = jsonString.Replace("\"System.Drawing.Bitmap\"", "null");   //load시, exception 방지
            return jsonString;
        }

        public string GetOriginalJsonString()
        {
            return originalJsonString;
        }
    }
}
