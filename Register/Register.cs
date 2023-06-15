using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class Register<T>
    {
        // Invariants
        // username, password, confirmPassword, and email cannot be null
        // password and confirmPassword must be equal

        private T username;
        private T password;
        private T confirmPassword;
        private T email;

        // Precondition: username, password, confirmPassword, and email must not be null
        // Postcondition: a new Register object is created
        public Register(T username, T password, T confirmPassword, T email)
        {
            Contract.Requires(username != null, "username must not be null");
            Contract.Requires(password != null, "password must not be null");
            Contract.Requires(confirmPassword != null, "confirmPassword must not be null");
            Contract.Requires(email != null, "email must not be null");
            Contract.Requires(password.Equals(confirmPassword), "password and confirmPassword must be equal");

            this.username = username;
            this.password = password;
            this.confirmPassword = confirmPassword;
            this.email = email;
        }

        // Precondition: object harus valid
        // Postcondition: user telah berhasil register dan info akun ditampil
        public bool RegisterUser()
        {
            if (string.IsNullOrWhiteSpace(username.ToString()) || string.IsNullOrWhiteSpace(password.ToString()) || string.IsNullOrWhiteSpace(confirmPassword.ToString())
                || string.IsNullOrWhiteSpace(email.ToString()))
            {
                return false;
            }

            if (!password.Equals(confirmPassword))
            {
                return false;
            }

            if (!IsValidEmail(email.ToString()))
            {
                return false;
            }

            return true;
        }


        // Precondition: email tidak harus null
        // Postcondition: mengembalikan true ketika email valid, false otherwise
        private static bool IsValidEmail(string email)
        {
            Contract.Requires(email != null, "email must not be null");

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
