using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THKTLT_Lab6
{
    public class UserInformationViewModel
    {
        private UserInformation defaultUser = new UserInformation(name: "ABC", age: 18, id: 1000);//Khởi tạo đối tượng mặc định
        public UserInformation DefaultUser //Tạo property DefaultUser
        {
            get { return this.defaultUser; }
        }
    }
}
