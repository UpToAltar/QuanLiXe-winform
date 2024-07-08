using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.Helper
{
    internal class ChechImageUrl
    {
        private static ChechImageUrl checkLogin;

        public static ChechImageUrl Instance
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new ChechImageUrl();
                }
                return checkLogin;
            }
            private set
            {
                checkLogin = value;
            }
        }

        private ChechImageUrl() { }
        public bool IsImageUrlValid(string url)
        {
            try
            {
                // Tạo một yêu cầu HTTP tới URL
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD"; // Chỉ gửi yêu cầu HEAD để kiểm tra header

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // Kiểm tra trạng thái phản hồi có phải là 200 OK
                    return (response.StatusCode == HttpStatusCode.OK &&
                            response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase));
                }
            }
            catch (Exception)
            {
                // Nếu có lỗi xảy ra (ví dụ: URL không hợp lệ), trả về false
                return false;
            }
        }
    }
}
