using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuidProQuo.BE.Models;
using QuidProQuo.BE.Controllers;

namespace QuidProQuo.Test
{
    [TestClass]
    public class TestOrderController
    {
        [TestMethod]
        public void PostOrder()
        {
            var controller = new OrderController(new TestQpqContext());

            var testOrder = GetTestActionData();
            var result = controller.Post(testOrder, 1) as HttpResponseMessage;

            Assert.IsNotNull(result);
            Assert.AreEqual(result, new HttpResponseMessage(HttpStatusCode.Created)); 
        }

        private ActionData GetTestActionData()
        {
            ActionData testOrder = new ActionData();
            testOrder.orderFields = new object[4];
            testOrder.orderFields[0] = "01.01.1000";
            testOrder.orderFields[1] = "тапки";
            testOrder.orderFields[2] = "женские";
            testOrder.orderFields[3] = 1;

            return testOrder;
        }

        
    }
}
