using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Controllers;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class CommentControllerTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            CommentsController Comment = new CommentsController();
            //test to see that it exists
            Assert.IsNotNull(Comment);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            CommentsController Comment = new CommentsController();
            //test to see that it exists           
            Assert.IsNotNull(Comment);
        }
    }
}
