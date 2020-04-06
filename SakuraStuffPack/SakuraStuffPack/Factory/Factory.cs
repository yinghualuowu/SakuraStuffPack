using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SakuraStuffPack.Factory
{
    class A : IFactoryHandler
    {
        public MyEnum TypEnum { get; } = MyEnum.A;
        public BaseClass Create()
        {
            return new ClassA();
        }
    }
    public class Factory
    {
        //反射到所有用到这个接口的类
        private Factory()
        {
            var type = typeof(IFactoryHandler);
            var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.GetInterfaces().Contains(type)
                select Activator.CreateInstance(t) as IFactoryHandler;
            FactoryList = instances.ToArray();
        }

        private IFactoryHandler[] FactoryList { get; }

        public BaseClass Create(MyEnum type)
        {
            try
            {
                var factoryHandler = FactoryList.Single(x => x.TypEnum == type).Create();
                return factoryHandler;
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("无效的操作，工厂和参数不匹配", e);
            }
        }
    }
}
