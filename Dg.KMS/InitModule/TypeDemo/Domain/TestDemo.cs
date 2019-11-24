using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypeDemo.Domain
{
    //builder.RegisterType(typeof(TestDemo)).AsSelf();
    /// <summary>
    /// https://www.cnblogs.com/yanweidie/p/autofac.html
    /// </summary>
    public class TestDemo
    {
        private readonly string _name;

        private readonly string _sex;

        private readonly int _age;

        public TestDemo(string name, string sex, int age)
        {
            _name = name;
            _age = age;
            _sex = sex;
        }
        public string Sex
        {
            get
            {
                return _sex;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }
    }
}
