using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzaqLibrary;

public class Register<T>
{
    // Input variables
    public T username { get; set; }
    public T password { get; set; }
    public T confirmPassword { get; set; }
    public T email { get; set; }

    // Constructor Register
    public Register(T username, T password, T confirmPassword, T email)
    {
        this.username = username;
        this.password = password;
        this.confirmPassword = confirmPassword;
        this.email = email;
    }

    // Registration method
    public void RegisterUser()
    {
        // Check if all fields are filled
        if (string.IsNullOrEmpty(username.ToString()) || string.IsNullOrEmpty(password.ToString()) ||
            string.IsNullOrEmpty(confirmPassword.ToString()) || string.IsNullOrEmpty(email.ToString()))
        {
            Console.WriteLine("Please fill in all fields.");
        }
        // Check if password and confirm password match
        else if (!password.Equals(confirmPassword))
        {
            Console.WriteLine("Passwords do not match.");
        }
        // Check if email is valid
        else if (!IsValidEmail(email.ToString()))
        {
            Console.WriteLine("Invalid email address.");
        }
        else
        {
            // Register user
            Console.WriteLine("User registered successfully.");
            Console.WriteLine("Username: " + username);
            Console.WriteLine("Email: " + email);
        }
    }

    // Defensive programming
    static bool IsValidEmail(string email)
    {
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