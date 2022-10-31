namespace GenericPartialApplication.Tests
{
    public class CallerTests
    {
        [Test]
        public void Test1()
        {
            Assert.IsAssignableFrom<Result.OfType<int, double>>(Mapper.GetResultArity2("int", "double"));
        }

        [Test]
        public void Test2()
        {
            Assert.IsAssignableFrom<Result.OfType<string, double>>(Mapper.GetResultArity2("string", "double"));
        }

        [Test]
        public void Test3()
        {
            Assert.IsAssignableFrom<Result.OfType<DateTime, Version>>(Mapper.GetResultArity2("DateTime", "Version"));
        }

        [Test]
        public void Test4()
        {
            Assert.IsAssignableFrom<Result.OfType<DateTime, Version, string>>(Mapper.GetResultArity3("DateTime", "Version", "string"));
        }
    }
}