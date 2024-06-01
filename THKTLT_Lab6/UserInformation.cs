using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THKTLT_Lab6
{
    public class UserInformation
    {
        private string userName;
        private uint userAge;
        private uint userID;
        public UserInformation(string name, uint age, uint id)
        {
            UserName = name;
            UserAge = age;
            UserID = id;
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public uint UserAge
        {
            get { return userAge; }
            set
            {
                if (value < 18)
                    throw new Exception("User's age must be larger than 18!");
                else
                    userAge = value;
            }
        }
        public uint UserID
        {
            get { return userID; }
            set
            {
                if ((value < 1000) || (value > 9999))
                    throw new Exception("Invalid ID!");
                else
                    userID = value;
            }
        }

        public string OneLineInformation
        {
            get
            {
                return String.Format($"Username: {UserName}, user ID: {UserID}, user age: {UserAge}");
            }
        }
    }
}
