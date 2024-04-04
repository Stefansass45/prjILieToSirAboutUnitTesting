using prjILieToSirAboutUnitTesting;

namespace TestIWantANewProgLecturer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestName()
        {
            doWhatever doWhat = new doWhatever();
            String actual = doWhat.getName();   
            String expected = "Jeff";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestEmail()
        {
            doWhatever doWhat = new doWhatever();
            String actual = doWhat.getEmail();
            String expected = "Jess@gmail.com";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Testdate()
        {
            doWhatever doWhat = new doWhatever();
            String actual = doWhat.getDate();
            String expected = "2024/04/04";
            Assert.AreEqual(expected, actual);
        }
    }
}