using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzaqLibrary;

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
    public void RegisterUser()
    {
        Contract.Requires(username != null && password != null && confirmPassword != null && email != null, "input fields must not be null");

        if (string.IsNullOrWhiteSpace(username.ToString()) || string.IsNullOrWhiteSpace(password.ToString()) || string.IsNullOrWhiteSpace(confirmPassword.ToString()) 
            || string.IsNullOrWhiteSpace(email.ToString()))
        {
            Console.WriteLine("Please fill in all fields.");
            return;
        }

        if (!password.Equals(confirmPassword))
        {
            Console.WriteLine("Passwords do not match.");
            return;
        }

        if (!IsValidEmail(email.ToString()))
        {
            Console.WriteLine("Invalid email address.");
            return;
        }

        Console.WriteLine("User registered successfully.");
        Console.WriteLine("Username: " + username);
        Console.WriteLine("Email: " + email);
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
