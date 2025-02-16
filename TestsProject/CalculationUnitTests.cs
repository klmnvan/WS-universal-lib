using WSUniversalLib;

namespace TestsProject
{
    [TestClass]
    public class CalculationUnitTests
    {
        //Негативные 5 ++
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(4, 1, 15, 20, 45);
            int correctResult = -1;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(3, 4, 15, 20, 45);
            int correctResult = -1;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeProductQuantity()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(3, 4, -4, 20, 45);
            int correctResult = -1;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeProductWidth()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(3, 4, 15, -20, 45);
            int correctResult = -1;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeProductLength()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(3, 4, 15, 20, -45);
            int correctResult = -1;
            Assert.AreEqual(actualResult, correctResult);
        }

        //Позитивные 5 ++
        [TestMethod]
        public void GetQuantityForProduct_MaterialType1ProductType1_CorrectResult()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(1, 1, 15, 20, 45);
            int correctResult = 14895;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_MaterialType2ProductType1_CorrectResult()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(2, 1, 15, 20, 45);
            int correctResult = 33852;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_MaterialType3ProductType1_CorrectResult()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(3, 1, 15, 20, 45);
            int correctResult = 114147;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_MaterialType1ProductType2_CorrectResult()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(1, 2, 15, 20, 45);
            int correctResult = 14868;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_MaterialType2ProductType2_CorrectResult()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(2, 2, 15, 20, 45);
            int correctResult = 33791;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_MaterialType3ProductType2_CorrectResult()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(3, 2, 15, 20, 45);
            int correctResult = 113942;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_ZeroWidthAndLength_CorrectResult()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(3, 2, 15, 0, 0);
            int correctResult = 0;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_SmallValues_CorrectResult()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(3, 2, 1, 1, 1);
            int correctResult = 9;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_LargeProduct_CorrectResult()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(3, 2, 2, 500, 500);
            int correctResult = 4220058;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_VeryDifferentWidthLength_CorrectResult()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(3, 2, 2, 1, 1000);
            int correctResult = 16881;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_NullValue_ReturnMinusOne()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(Convert.ToInt32(null), Convert.ToInt32(null),
                Convert.ToInt32(null), Convert.ToInt32(null), Convert.ToInt32(null));
            int correctResult = -1;
            Assert.AreEqual(actualResult, correctResult);
        }

        [TestMethod]
        public void GetQuantityForProduct_ReturnInt()
        {
            Calculation calculation = new Calculation();
            int actualResult = calculation.GetQuantityForProduct(2, 1, 15, 20, 45);
            Assert.IsInstanceOfType<int>(actualResult);
        }

    }
}