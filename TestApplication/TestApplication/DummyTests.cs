using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApplication
{
    [TestFixture]
    class DummyTests
    {
        [Test]
        public void Program_can_say_hello_world()
        {
            var program = new Program();
            Assert.That(program.SayHello(), Is.EqualTo("Hello World!"));
        }
    }
}
