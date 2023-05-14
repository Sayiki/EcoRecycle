using System;
using System.Collections.Generic;

namespace TUBES_KPL_2023.Tests
{
    public class MaterialCounterTests
    {
        public object Assert { get; private set; }

        [Fact]
        public void Count_AddsNewEntryToDictionary_IfEntryDoesNotExist()
        {
            // Arrange
            var materialCounter = new MaterialCounter();

            // Act
            materialCounter.Count("metal");

            // Assert
            Assert.Contains("metal", materialCounter.GetJumlahSampah().Keys);
        }

        [Fact]
        public void Count_IncrementsValue_IfEntryExists()
        {
            // Arrange
            var materialCounter = new MaterialCounter();
            materialCounter.Count("metal");

            // Act
            materialCounter.Count("metal");

            // Assert
            Assert.Equals(2, materialCounter.GetJumlahSampah()["metal"]);
        }

        [Fact]
        public void Count_IncrementsTotal()
        {
            // Arrange
            var materialCounter = new MaterialCounter();

            // Act
            materialCounter.Count("metal");

            // Assert
            Assert.Equals(1, materialCounter.GetJumlahSampah()["total"]);
        }

        [Fact]
        public void Display_WritesJumlahSampahToConsole()
        {
            // Arrange
            var materialCounter = new MaterialCounter();
            materialCounter.Count("metal");

            // Capture output written to console
            using (var consoleOutput = new ConsoleOutput())
            {
                // Act
                materialCounter.Display();

                // Assert
                Assert.Contains("Jumlah Sampah:", consoleOutput.GetOutput());
                Assert.Contains("metal: 1", consoleOutput.GetOutput());
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
