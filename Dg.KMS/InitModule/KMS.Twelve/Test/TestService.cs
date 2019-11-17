using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;

namespace KMS.Twelve.Test
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    #region ITestService
    public interface ITestService
    {
        Guid MyProperty { get; }
        List<string> GetList(string a);
    }
    public interface ITestService2
    {
        Guid MyProperty { get; }
        List<string> GetList();
    }
    public interface ITestService3
    {
        Guid MyProperty { get; }
        List<string> GetList();
    }
    #endregion


    #region MyRegion
    [Intercept(typeof(AOPTest))]
    public class TestService : ITestService
    {
        public TestService()
        {
            MyProperty = Guid.NewGuid();
        }
        public Guid MyProperty { get; set; }
        public List<string> GetList(string a)
        {
            return new List<string>() { "LiLei", "ZhangSan", "LiSi" };
        }
    }

    public class TestService2 : ITestService2
    {
        public TestService2()
        {
            MyProperty = Guid.NewGuid();
        }
        public Guid MyProperty { get; set; }
        public List<string> GetList()
        {
            return new List<string>() { "LiLei", "ZhangSan", "LiSi" };
        }
    }
    public class TestService3 : ITestService3
    {

        public TestService3()
        {
            MyProperty = Guid.NewGuid();
        }
        public Guid MyProperty { get; set; }
        public List<string> GetList()
        {
            return new List<string>() { "LiLei", "ZhangSan", "LiSi" };
        }
    }
    #endregion
}
