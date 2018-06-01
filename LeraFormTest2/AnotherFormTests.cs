using System;
using System.Windows.Forms;
using NUnit.Framework;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;

using LeraForm;
using LeraCute;


namespace LeraFormTest2
{
    [TestFixture]
    public class AnotherFormTests
    {
        TestStack.White.Application leraApp;
        Window mainWindow;

        TestStack.White.UIItems.Button btn;
        TestStack.White.UIItems.Label label;

        [TestFixtureSetUp]
        public void SetUp()
        {
            leraApp = TestStack.White.Application.Launch("LeraForm.exe");
            mainWindow = leraApp.GetWindow("myWin");
            btn =
               mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByAutomationId("button1"));
            label =
              mainWindow.Get<TestStack.White.UIItems.Label>(SearchCriteria.ByAutomationId("label1"));

        }

        [Test]
        public void Test1()
        {
            btn.Click();
            Assert.AreEqual("awww", label.Text.ToString());
            mainWindow.Close();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            if (mainWindow != null && !mainWindow.IsClosed)
                mainWindow.Close();
        }
    }
}
