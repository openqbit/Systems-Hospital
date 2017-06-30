using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQbit.Hospital.Common.Models.Phamarcy.OpenQbit.Hospital.Common.Models.Phamarcy;
using OpenQbit.Hospital.DataAccsess.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Test.DAL
{
    [TestClass]
    public class DALTest
    {
        public DALTest()
        {

        }

        private TestContext testContextInstance;

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

        #region Additional test attributes

        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            int expected = 10;

            int actual = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomerInsertTest()
        {
            PharmacyContext db = new PharmacyContext();
            Drug newDrug =
              new Drug
              { ID = 1122, drugName = "TestAddress", Description = "helo", Company = "ijse", MedicineId = 1010, CategoryId = 1034 };

            db.Drug.Add(newDrug);
            db.SaveChanges();

            Drug findDrug =
                db.Drug.Where(C => C.ID == 1122).FirstOrDefault();

            Assert.AreEqual(newDrug.ID, findDrug.ID);

            if (findDrug != null)
            {
                db.Drug.Remove(findDrug); // remove from Db
            }

        }
    }
}
