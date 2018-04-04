using Test_unitaire;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_ean13
{
    
    
    /// <summary>
    ///Classe de test pour Ean13Test, destinée à contenir tous
    ///les tests unitaires Ean13Test
    ///</summary>
    [TestClass()]
    public class Ean13Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur Ean13
        ///</summary>
        [TestMethod()]
        public void Ean13ConstructorTest()
        {
            try
            {

                int[] ean13 = new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 }; // TODO: initialisez à une valeur appropriée
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, " un code ean13 doit etre un tableau de 12 entiers");
            }
            try
            {
                Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, " un code ean13 doit etre un tableau de 12 entiers");
                return;
            }
            Assert.Fail("aucune exception n'a été soulevée");
        }
          

        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            
            Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 }); // TODO: initialisez à une valeur appropriée
            string expected = "4719-5120-0288-9"; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour cle
        ///</summary>
        [TestMethod()]
        public void cleTest()
        {
            int[] ean13 = new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 }; // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(ean13); // TODO: initialisez à une valeur appropriée
            int expected = 9; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.cle();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour poidsimpair
        ///</summary>
        [TestMethod()]
        public void poidsimpairTest()
        {
            int[] ean13 = new int[]{4,7,1,9,5,1,2,0,0,2,8,8}; // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(ean13); // TODO: initialisez à une valeur appropriée
            int expected = 20; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.poidsimpair();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour poidspair
        ///</summary>
        [TestMethod()]
        public void poidspairTest()
        {
            int[] ean13 = new int[] {4,7,1,9,5,1,2,0,0,2,8,8}; // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(ean13); // TODO: initialisez à une valeur appropriée
            int expected = 81; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.poidspair();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour reste
        ///</summary>
        [TestMethod()]
        public void resteTest()
        {
            int[] ean13 = {4,7,1,9,5,1,2,0,0,2,8,8}; // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(ean13); // TODO: initialisez à une valeur appropriée
            int expected = 1; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.reste();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
