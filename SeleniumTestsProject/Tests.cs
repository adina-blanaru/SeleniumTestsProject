using NUnit.Framework;
using SeleniumTestsProject.PageObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestsProject
{
    [TestFixture]   //marks the class as a tests class
    class Tests:Hooks
    {
        [Test]  //marks the method as a test
        public void MyFirstTest()
        {
            HomePage myPage = new HomePage(Driver);
            myPage.AutentificareButton.Click();
            
            Thread.Sleep(1000);
        }

        [Test]
        public void MySecondTest()
        {
            Thread.Sleep(1000);
        }

        [Test]
        public void MyThirdTest()
        {
            Thread.Sleep(1000);
        }

    }
}
