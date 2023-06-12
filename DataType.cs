using System;
namespace CSharp
{
	public class DataType
	{
		public DataType()
		{

		}

		static void Main(String[] agrs)
		{
			int? a = null; // được phép


			#region Eg1
			//Số nguyên
			byte Byte = 10; // -128 => 127
			short Short = 10;
			int Interger = 10;
			long Lonhg = 10;

			//Số thực
			float Float = 14.9f; // float cần hậu  f hoặc 
			double Double = 10.9; // không cần hậu 
			decimal Decimal = 7.9m; // cần hậu tố

			//Kiểu ký tự và kiểu chuỗi
			char Character = 'H';
			string String = "Hello World!";

            #endregion
        }
    }
}

/* Kiểu dữ liệu
 * - là tập hợp các nhóm dữ liệu có cùng đặc tính
 * cách lưu trữ và thao tác xử lý trên trường dữ liệu đó
 * - là một tính hiệu để trình biên dịch nhận biết kích thước của một biến và khả năng của nó
 * - là thành phần cốt lõi của một ngôn ngữ lập trình 
 */

/* => dựng sẵn			|| kiểu dữ liệu giá trị 
 * => tự địn nghĩa		|| kiểu dữ liệu tham chiếu (khi khai báo chỉ chứa địa chỉ vùng nhớ)
 */


/* kích thước stack là không thể thay đổi và sẽ tự giải phóng khi không sử dụng nữa
 * , khi vùng nhớ stack không còn đủ sẽ gây ra hiện tượng tràn bộ nhớ "Stack Over Flow"
 * hiện tượng xảy ra khi nhiều hàm lồng vào nhau
 * 
 * vùng nhớ heap có thể thay đổi được, tự điều chỉnh do hđh, và có thể được tự giải phóng bởi C#
 */