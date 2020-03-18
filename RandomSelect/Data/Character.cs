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

        public Character()
        {
        }

        //Class constructor chaining
        public Character(Image image, string imageFileName) : this(true, image, imageFileName, string.Empty, string.Empty) { }

        public Character(bool enable, Image image, string imageFileName, string name, string caption)
        {
            this.enable = enable;
            this.image = image;
            this.imageFileName = imageFileName;
            this.name = name;
            this.caption = caption;

        }

        public bool getWinning()
        {
            return winning;
        }

        public void setWinning(bool winning)
        {
            this.winning = winning;
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
