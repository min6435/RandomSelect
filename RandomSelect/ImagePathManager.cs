using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSelect
{
    class ImagePathManager
    {
        //키워드를 추가하고 싶으면 이부분에 추가하도록 하세요.
        private static Dictionary<string, string> pathKeywordDictionary = new Dictionary<string, string>()
        {
            { "{DEFAULT_IMAGE_ROOT_PATH}", $@"{Application.StartupPath}\Image" },
            { "{START_UP_PATH}", Application.StartupPath }
        };

        public static string ValidateImageRootPath(string imageRootPath)
        {
            if (string.IsNullOrEmpty(imageRootPath) == true)
                imageRootPath = pathKeywordDictionary["{DEFAULT_IMAGE_ROOT_PATH}"];
            else
            {
                foreach(KeyValuePair<string, string> pair in pathKeywordDictionary)
                    imageRootPath = imageRootPath.Replace(pair.Key, pair.Value);
            }

            if (Directory.Exists(imageRootPath) == false)
                Directory.CreateDirectory(imageRootPath);

            return imageRootPath;
        }
    }
}
