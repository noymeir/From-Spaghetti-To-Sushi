using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using LogicModule;
using LogicContracts;
using ImageProcessContracts;
namespace UnitTestsProject
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<IImageProcess> imgModule = new Mock<IImageProcess>();
        //private Mock<IImageProvider> imgProvider = new Mock<IImageProvider>();
        
        [TestMethod]
        public void TestMethod1()
        {
            Logic logic = new Logic(imgModule.Object);
            string[] args = { @"src:Images\Src", @"dest:Images\dest" };
            logic.GetSrcAndDestDirectory(args);
            imgModule.Verify(m => m.ProcessImg(It.IsAny<string>(), It.IsAny<string>()), Times.AtLeastOnce, "processImg method hasn't invoked at all");
        }
    }
}
