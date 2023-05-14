using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArzaqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzaqLibrary.Tests
{
    [TestClass()]
    public class MaterialInputTests
    {
        [TestMethod()]
        public void InputMaterialTest_ValidInputs()
        {
            // Arrange
            var input = new StringReader("logam\nplastik\naluminium\nkaca\nkertas\nkardus\n0");
            Console.SetIn(input);

            var expectedMaterials = new List<string> { "logam", "plastik", "aluminium", "kaca", "kertas", "kardus" };
            var expectedOutput = $"Material list: {string.Join(", ", expectedMaterials)}\nTotal yang dimasukkan: {expectedMaterials.Count}\n\n";

            var materialInput = new MaterialInput();

            // Act
            materialInput.InputMaterial();

            var writer = new StringWriter();
            Console.SetOut(writer);
            materialInput.PrintMaterialList();
            var actualOutput = writer.ToString();

            // Assert
            CollectionAssert.AreEqual(expectedMaterials, materialInput.materials);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void InputMaterialTest_InvalidInput()
        {
            // Arrange
            var input = new StringReader("logam\nplastik\nbesi\nkaca\nkertas\nkardus\n0");
            Console.SetIn(input);

            var expectedMaterials = new List<string> { "logam", "plastik", "kaca", "kertas", "kardus" };
            var expectedOutput = $"Material list: {string.Join(", ", expectedMaterials)}\nTotal yang dimasukkan: {expectedMaterials.Count}\n\n";

            var materialInput = new MaterialInput();

            // Act
            materialInput.InputMaterial();

            var writer = new StringWriter();
            Console.SetOut(writer);
            materialInput.PrintMaterialList();
            var actualOutput = writer.ToString();

            // Assert
            CollectionAssert.AreEqual(expectedMaterials, materialInput.materials);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}