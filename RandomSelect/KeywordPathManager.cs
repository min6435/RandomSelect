using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSelect
{
    class KeywordPathManager
    {
        //키워드를 추가하고 싶으면 이부분에 추가하도록 하세요.
        private static Dictionary<string, string> keywordDictionary = new Dictionary<string, string>()
        {
            { "{DEFAULT_SAVE_ROOT_PATH}", $@"{Application.StartupPath}\Save" }, //앱 설치 위치의 Save폴더
            { "{START_UP_PATH}", Application.StartupPath }, //앱 설치 위치
            { "{DESKTOP}", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) }  //바탕화면
        };

        public static string GetOriginalPath(string path)
        {
            if (string.IsNullOrEmpty(path) == true)
                path = keywordDictionary["{DESKTOP}"];
            else
            {
                foreach(KeyValuePair<string, string> pair in keywordDictionary)
                    path = path.Replace(pair.Key, pair.Value);
            }
            
            return path;
        }

        public static string GetKeywordPath(string path)
        {
            if (string.IsNullOrEmpty(path) == true)
                path = string.Empty;
            else
            {
                foreach (KeyValuePair<string, string> pair in keywordDictionary)
                    path = path.Replace(pair.Value, pair.Key);
            }
            
            return path;
        }
    }
}
