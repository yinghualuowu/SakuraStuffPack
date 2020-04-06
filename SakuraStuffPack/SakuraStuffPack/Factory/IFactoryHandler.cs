using System;
using System.Collections.Generic;
using System.Text;

namespace SakuraStuffPack.Factory
{
    interface IFactoryHandler
    {
        MyEnum TypEnum { get; }

        BaseClass Create();
    }
}
