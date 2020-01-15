using BLL;
using DAL.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange : préparer le scénario I/O
            // input : nothing
            // output : list of categories

            List<Categorie> lCatAttendu = new List<Categorie>
             {
                 new Categorie () {IdCat = 1 ,DescriptionCat =  "Test" },
                 new Categorie () {IdCat = 2 ,DescriptionCat =  "RH" }

             };

            //Act : Exécuter la méthode
            var busComp = new BusinessCompanyCore();
            var lCatObtenu = busComp.GetListCategorie();

            //Assert : s'assurer que le résultat obtenu = attendu
            Assert.AreEqual(lCatAttendu.Count, lCatObtenu.Count);
            for (int i = 0; i < lCatAttendu.Count; i++)
            {
                Assert.AreEqual(lCatAttendu[i].IdCat, lCatObtenu[i].IdCat);
                Assert.AreEqual(lCatAttendu[i].DescriptionCat, lCatObtenu[i].DescriptionCat);
            }
        }
    }
}