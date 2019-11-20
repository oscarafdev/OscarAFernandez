using NUnit.Framework;
using OscarAFernandez;

namespace Tests
{
    public class Tests
    {
        Control control = new Control();
        [TestCase]
        public void FooBar()
        {
            string query = "Foo Bar";
            string result = "333666 666022 2777";
            control.Start();
            string realresult = control.findString(query);
            Assert.AreEqual(result, realresult);
        }
        [TestCase]
        public void Hola()
        {
            string query = "Hola";
            string result = "446665552";
            control.Start();
            string realresult = control.findString(query);
            Assert.AreEqual(result, realresult);
        }
    }
}
