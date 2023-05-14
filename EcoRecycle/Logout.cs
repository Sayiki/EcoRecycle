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
            try
            {
                switch (currentState)
                {
                    case State.Idle:
                        if (input == null)
                        {
                            throw new ArgumentNullException(nameof(input));
                        }

                        if (input.Trim().ToLower() == "logout")
                        {
                            Console.WriteLine("Apakah anda yakin ingin logout? (iya/tidak)");
                            currentState = State.Confirming;
                        }
                        break;

                    case State.Confirming:
                        if (input == null)
                        {
                            throw new ArgumentNullException(nameof(input));
                        }

                        if (input.Trim().ToLower() == "iya")
                        {
                            Console.WriteLine("Anda telah Logout.");
                            currentState = State.LoggingOut;
                        }
                        else if (input.Trim().ToLower() == "tidak")
                        {
                            Console.WriteLine("Logout dibatalkan.");
                            currentState = State.Idle;
                        }
                        else
                        {
                            Console.WriteLine("Masukkan iya atau tidak !");
                        }
                        break;

                    case State.LoggingOut:
                        break;
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Terjadi kesalahan: {0}", ex.Message);
            }
        }
    }
}
