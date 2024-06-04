using Allure.NUnit;
using Allure.NUnit.Attributes;
using NUnit.Framework;

namespace allure_nunit_ignore_bug
{
    [AllureNUnit]
    [AllureDisplayIgnored]
    public class Class1
    {
        [Ignore("ignored")]
        [Test]
        public void Ignored()
        {

        }

        [Ignore("ignored with cases")]
        [TestCase(true)]
        [TestCase(false)]
        public void Ignored_Cases(bool tmp)
        {

        }

        [Test]
        public void Passed()
        {

        }
    }
}
