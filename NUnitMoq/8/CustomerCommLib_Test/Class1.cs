using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using CustomerCommLib;
using System.Net;
using System.Net.Mail;

namespace CustomerCommLib_Test
{
    public class Class1
    {
        /*[SetUp]
        public void Setup()
        {
        }*/

        [Test]
        public void Test1()
        {
            Mock<MailSend> obj = new Mock<MailSender>();
            obj.Setup(x => x.SendMail("abcd@gmail.com", "Hii,Welcome")).Returns(true);

            CustomerComm cust = new CustomerComm(obj.Object);
            bool isInserted = cust.SendMailToCustomer();

            Assert.AreEqual(isInserted, true);
        }
    }
}
