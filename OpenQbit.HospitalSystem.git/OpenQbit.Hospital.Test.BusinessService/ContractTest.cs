//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQbit.Hospital.Common.Models;
//using OpenQbit.Hospital.DataAccsess.DAL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OpenQbit.Hospital.Test.BusinessService
//{
//    [TestClass]
//    public class ContractTest
//    {
//        public ContractTest()
//        {

//        }
//        private TestContext testContextInstance;
//        public TestContext TestContext
//        {
//            get
//            {
//                return testContextInstance;
//            }
//            set
//            {
//                testContextInstance = value;
//            }
//        }
//        [TestMethod]
//        public void TestMethod1()
//        {
//            int expected = 10;

//            int actual = 10;

//            Assert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        public void CustomerInsertTest()
//        {
//            PharmacyContext db = new PharmacyContext();
//            Item item =
//              new Item
//              { ID = 10, Name = "Abi", Description = "drug", ItemType };

//            db.Item.Add(item);
//            db.SaveChanges();

//            Resorce findResorce =
//                db.Resorce.Where(C => C.ID == 10).FirstOrDefault();

//            Assert.AreEqual(newResorce.ID, findResorce.ID);

//            if (findResorce != null)
//            {
//                db.Resorce.Remove(findResorce);
//            }

//        }
//    }
//}
