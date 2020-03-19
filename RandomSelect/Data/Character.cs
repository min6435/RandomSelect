using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RandomSelect
{
    public class Character
    {
        //dataGridView에 보여줄 데이터는 get/set구현
        public bool enable { get; set; } = true;
        public Image image { get; set; } = null;
        public string name { get; set; } = string.Empty;
        public string caption { get; set; } = string.Empty;

        //json에 기록할 데이터는 public구현
        public string imageFileName = string.Empty;

        //json에 기록하지 않을 데이터는 private구현
        private bool winning = false;
        private JsonCharacter parentJsonCharacter = null;

        //JsonObject에서 사용하는 기본 생성자입니다. 삭제시 exception 발생
        public Character() {}

        //Class constructor chaining
        public Character(Image image, string imageFileName, JsonCharacter parentJsonCharacter) : this(true, image, imageFileName, string.Empty, string.Empty, parentJsonCharacter) { }

        public Character(bool enable, Image image, string imageFileName, string name, string caption, JsonCharacter parentJsonCharacter)
        {
            this.enable = enable;
            this.image = image;
            this.imageFileName = imageFileName;
            this.name = name;
            this.caption = caption;
            this.parentJsonCharacter = parentJsonCharacter;
        }

        public bool GetWinning()
        {
            return winning;
        }

        public void SetWinning(bool winning)
        {
            this.winning = winning;
        }

        // Character의 단독 이미지 파일 경로 만들 시, 부모의 rootPath가 필요하므로 부모를 가져올 수 있도록 함.
        public JsonCharacter GetParentJsonCharacter()
        {
            return parentJsonCharacter;
        }

        public void SetParentJsonCharacter(JsonCharacter parentJsonCharacter)
        {
            this.parentJsonCharacter = parentJsonCharacter;
        }

        #region IDisposable 구현

        private bool isDisposed = false; // 중복 호출 방지
        protected void Dispose(bool disposing)
        {
            // 메모리 해제 코드
            if (!isDisposed)
            {
                if (disposing)
                    image?.Dispose();

                image = null;

                isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Character()
        {
            Dispose(false);
        }

        #endregion
    }
}
