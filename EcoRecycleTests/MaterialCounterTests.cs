using System;
using System.Collections.Generic;
using Xunit;

namespace TUBES_KPL_2023.Tests
{
    public class MaterialCounterTests
    {
        [Fact]
        public void Count_AddsNewEntryToDictionary_IfEntryDoesNotExist()
        {
            // Arrange
            var materialCounter = new MaterialCounter();

            // Act
            materialCounter.Count("bungkus indomie");

            // Assert
            Assert.Contains("bungkus indomie", materialCounter.GetJumlahSampah().Keys);
        }

        [Fact]
        public void Count_IncrementsValue_IfEntryExists()
        {
            // Arrange
            var materialCounter = new MaterialCounter();
            materialCounter.Count("bungkus indomie");

            // Act
            materialCounter.Count("bungkus indomie");

            // Assert
            Assert.Equal(2, materialCounter.GetJumlahSampah()["bungkus indomie"]);
        }

        [Fact]
        public void Count_IncrementsTotal()
        {
            // Arrange
            var materialCounter = new MaterialCounter();

            // Act
            materialCounter.Count("bungkus indomie");

            // Assert
            Assert.Equal(1, materialCounter.GetJumlahSampah()["total"]);
        }

        [Fact]
        public void Display_WritesJumlahSampahToConsole()
        {
            // Arrange
            var materialCounter = new MaterialCounter();
            materialCounter.Count("bungkus indomie");

            // Capture output written to console
            using (var consoleOutput = new ConsoleOutput())
            {
                // Act
                materialCounter.Display();

                // Assert
                Assert.Contains("Jumlah Sampah:", consoleOutput.GetOutput());
                Assert.Contains("bungkus indomie: 1", consoleOutput.GetOutput());
                Assert.Contains("total: 1", consoleOutput.GetOutput());
            }
        }
    }

    // Helper class to capture console output
    public class ConsoleOutput : IDisposable
    {
        private readonly StringWriter stringWriter;
        private readonly TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOutput()
        {
            return stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}
