using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBES_KPL_2023
{
    internal class Logout
    {
        public enum State
        {
            Idle,
            Confirming,
            LoggingOut
        }

        public State currentState = State.Idle;

        public void ProcessInput(string input)
        {
            switch (currentState)
            {
                case State.Idle:
       
                    if (input == "logout")
                    {
                        Console.WriteLine("Apakah anda yakin ingin logout? (y/n)");
                        currentState = State.Confirming;
                    }
                    break;

                case State.Confirming:
                    if (input == "y")
                    {
                        Console.WriteLine("Anda telah logout.");
                        currentState = State.LoggingOut;
                    }
                    else if (input == "n")
                    {
                        Console.WriteLine("Logout dibatalkan.");
                        currentState = State.Idle;
                    }
                    else
                    {
                        Console.WriteLine("Masukkan y atau n.");
                    }
                    break;

                case State.LoggingOut:
                    break;
            }
        }
    }
}
