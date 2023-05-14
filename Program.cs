using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using NUnit.Framework;

namespace VendingMachine
{
    public enum SampahType
    {
        Metal,
        Aluminum,
        Plastic,
        Glass,
        Paper,
        Cardboard
    }

    public class VendingMachine
    {
        private readonly Dictionary<SampahType, int> _sampahCounts;

        public VendingMachine()
        {
            _sampahCounts = new Dictionary<SampahType, int>()
            {
                { SampahType.Metal, 0 },
                { SampahType.Aluminum, 0 },
                { SampahType.Plastic, 0 },
                { SampahType.Glass, 0 },
                { SampahType.Paper, 0 },
                { SampahType.Cardboard, 0 }
            };
        }

        public void AddSampah(SampahType sampahType)
        {
            Contract.Requires(Enum.IsDefined(typeof(SampahType), sampahType));

            _sampahCounts[sampahType]++;
        }

        public int GetTotalPoints()
        {
            int totalPoints = 0;

            foreach (var sampahType in _sampahCounts.Keys)
            {
                totalPoints += _sampahCounts[sampahType] * 5;
            }

            return totalPoints;
        }
    }

    [TestFixture]
    public class VendingMachineTests
    {
        [Test]
        public void AddSampah_ValidSampahType_IncreasesSampahCount()
        {
            // Arrange
            var vendingMachine = new VendingMachine();
            var sampahType = SampahType.Metal;

            // Act
            vendingMachine.AddSampah(sampahType);

            // Assert
            Assert.AreEqual(1, vendingMachine.GetTotalPoints());
        }

        [Test]
        public void AddSampah_InvalidSampahType_ThrowsException()
        {
            // Arrange
            var vendingMachine = new VendingMachine();
            var sampahType = (SampahType)10;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => vendingMachine.AddSampah(sampahType));
        }

        [Test]
        public void GetTotalPoints_NoSampah_ReturnsZeroPoints()
        {
            // Arrange
            var vendingMachine = new VendingMachine();

            // Act
            var totalPoints = vendingMachine.GetTotalPoints();

            // Assert
            Assert.AreEqual(0, totalPoints);
        }

        [Test]
        public void GetTotalPoints_WithSampah_ReturnsCorrectPoints()
        {
            // Arrange
            var vendingMachine = new VendingMachine();
            vendingMachine.AddSampah(SampahType.Metal);
            vendingMachine.AddSampah(SampahType.Aluminum);
            vendingMachine.AddSampah(SampahType.Plastic);
            vendingMachine.AddSampah(SampahType.Glass);
            vendingMachine.AddSampah(SampahType.Paper);
            vendingMachine.AddSampah(SampahType.Cardboard);

            // Act
            var totalPoints = vendingMachine.GetTotalPoints();

            // Assert
            Assert.AreEqual(1100, totalPoints);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            SampahType[] daftarJenisSampah = new SampahType[]
            {
            SampahType.Metal,
            SampahType.Aluminum,
            SampahType.Plastic,
            SampahType.Glass,
            SampahType.Paper,
            SampahType.Cardboard
            };

            Console.WriteLine("Masukkan sampah (1 = Metal, 2 = Alumunium, 3 = Plastic, 4 = Glass, 5 = Paper, 6 = Cardboard, 0 = Selesai)");
            int sampahType = -1;
            while (sampahType != 0)
            {
                Console.Write("Jenis sampah: ");
                sampahType = int.Parse(Console.ReadLine());

                if (sampahType > 0 && sampahType <= daftarJenisSampah.Length)
                {
                    vendingMachine.AddSampah(daftarJenisSampah[sampahType - 1]);
                }
            }

            Console.WriteLine("Total Poin: " + vendingMachine.GetTotalPoints());
        }
    }
}