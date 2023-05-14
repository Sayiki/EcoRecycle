using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBES_KPL_2023
{
    public class Logout
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
            //precondition: User input logout, masukkan inputan pilihan ya atau tidak, user input random diluar ya atau tidak.
            //postcondition: User berhasil logout, user batal logout, user diminta memasukkan pilihan iya tatu tidak!.
            try
            {
                switch (currentState)
                {
                    case State.Idle:
                        if (input == null)
                        {
                            throw new ArgumentNullException(nameof(input));
                        }
                        //precondition: memasukkan inputan awal untuk lakukan logout
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
                        //precondition: user memilih pilihan iya
                        if (input.Trim().ToLower() == "iya")
                        {
                            //postcondition: berhasil untuk logout
                            Console.WriteLine("Anda telah Logout.");
                            currentState = State.LoggingOut;
                        }
                        //precondition: user meilih pilihan tidak
                        else if (input.Trim().ToLower() == "tidak")
                        {
                            //postcondition: logout batal karena pilihan tidak oleh user
                            Console.WriteLine("Logout dibatalkan.");
                            currentState = State.Idle;
                        }
                        else
                        {
                            //postcondition: ketika user tidak memilih pilihan antara iya atau tidak.
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
