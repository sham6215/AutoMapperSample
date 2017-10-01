using AutoMapper;
using AutoMapperSample.Mapping;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    class AutoMapperTest
    {
        [Test]
        public void MapperProfileTest()
        {
            Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());
            Mapper.AssertConfigurationIsValid<AutoMapperProfile>();
        }
    }
}
