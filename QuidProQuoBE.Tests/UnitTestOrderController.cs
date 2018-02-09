using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using QuidProQuo.BE.Controllers;
using QuidProQuo.BE.Models;

namespace QuidProQuoBE.Tests
{
    [TestClass]
    public class UnitTestOrderController
    {
        [TestMethod]
        public void GetAllOrders_ShouldReturnAllOrders()
        {
            var controller = new OrderController();

            var result = controller.Get();

            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void DeleteOrder()
        //{
        //    var controller = new OrderController();
        //    int id = 1;

        //    string result = controller.Get();

        //    var testOrder = controller.Get("any service"); 

        //    result = controller.Get();

        //    ICollection orders = (ICollection)JsonConvert.DeserializeObject(result);

        //    CollectionAssert.DoesNotContain(orders, testOrder);
        //}
    }
}
