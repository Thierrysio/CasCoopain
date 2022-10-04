using Microsoft.VisualStudio.TestTools.UnitTesting;
using CasCoopain.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCoopain.Modeles.Tests
{
    [TestClass()]
    public class InseminateurTests
    {
        [TestMethod()]
        public async void AjoutInseminateurTest()
        {
            ///Arrange - organiser
            Inseminateur I1 = new Inseminateur().AjoutInseminateur("inseminateur 01", "prenom 01", "0654254794", "tlg", "pwd");
            await App.Database.SaveItemAsync<Inseminateur>(I1);

            ///Act - agir1);
            var mDB = App.Database.GetItemAvecRelations(I1);

            ///Assert - affirmer
            Assert.AreEqual("inseminateur 01", mDB.Result.Prenom);
        }
    }
}