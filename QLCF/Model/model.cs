using System;

//mỗi model đều tạo một file hoặc tạo chung đang suy nghĩ 
namespace Model
{
    public class Authentication
    {
        public int authenticationID { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public int userId { get; set; }
        public int InfoFeildID { get; set; }
    }

    public class UserModel
    {
        public int userID { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public DateTime birthDay { get; set; }
        public string emailUser { get; set; }
        public int InfoFeildID { get; set; }
    }
}







