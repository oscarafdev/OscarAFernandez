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
            control.Start();
            control.findString("Foo Bar");
        }
        [TestCase]
        public void Hola()
        {
            control.Start();
            control.findString("Hola");
        }
    }
}