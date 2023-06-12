using System;
namespace CSharp
{
    public class Variable
    {
        public Variable()
        {

        }
        static void Main(String[] agrs)
        {
            //biến => Biến trong "Biến đổi"
            /*Biến 
			 * là một giá trị dữ liệu có thể thay đổi được
			 * là tên gọi tham chiến đến một vùng nhớ nào đó
			 * là một thành phần cốt lõi của một ngôn ngữ lập trình
			 * 
			 * => Lưu trữ dữ liệu và tái sử dụng
			 * => Thao tác với bộ nhớ một cách dễ dàng 
			 * (Cấu trúc của một bộ nhớ bao gồm nhiều ô nhớ liên tiếp với nhau 
			 * mỗi ô nhớ có một địa chỉ riêng và địa chỉ của mỗi ô nhớ thường
			 * là mã nhị phân, mã hex, mã 16 => nếu muốn sử dụng một ô nhớ sẽ phải
			 * thông qua địa chỉ của nó điều đó trở nên phức tạp hơn)
			 * => khai báo 1 biến là cho nó tham chiếu đến ô nhớ mình cần
			 */
            //=================================================================

            //int intergerType = 14;
            //float realNumberType = 14.9f;
            //string stringType = "Hello World!";
            //bool logicType = true;
            //char characterType = 'N';

            int a = 14;
            int b = 9;
            int c = a + b;


            Console.WriteLine(c);
            Console.WriteLine("a + b = c: {0} + {1} = {2}", a, b, c);
            Console.ReadKey();

            /*Quy tắc đặt tên biến
             * - Tên biến là 1 chuỗi ký tự không có khoảng trắng
             * - Không có dấu
             * - Không có ký tự đặt biệt
             * - Không bắt đầu bằng số
             * - Không được trùng nhau 
             * - Không được trùng các từ khóa (abstract, as, base, bool ...)
             */

            /*Quy tắc lạc đà:
             * - Viết thường từ đầu tiên và viết hoa chữ cái đầu tiên của những từ tiếp 
             * --> iAmSpiderMan 
             */

            /*Quy tắc pascal
             * - Viết hoa chữ cái đầu tiên của mỗi từ 
             * --> IAmSpiderMan 
             */

            /* Nên đăt tên ngắn gọn dễ hiểu, thể hiện rõ mục đích của biến
             * C# có phân biệt chữ hoa chữ thường a != A 
             */
        }
    }
}



