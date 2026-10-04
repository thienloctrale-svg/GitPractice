using System;

class Login
{
    static void Main()
    {
        string username = "admin";
        string password = "123456";

        if (username == "admin" && password == "123456")
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Login failed!");
        }
    }
}