using System;

namespace UserManagerLibrary
{
    public class UserManager
    {
        public bool Add(string userId, string phone, string mail)
        {
            if (userId.Length < 4)
            {
                throw new  Exception("User Id должен быть боль 4");
            }

            if (phone.Contains("a"))
            {
                throw new Exception("Телефон должен содержать толькоцифры");
            }

            if (!mail.Contains("@"))
            {
                throw new Exception("Ошибка в емейл адресе");
            }


            return true;
        }
    }
}
