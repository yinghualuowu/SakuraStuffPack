using System;
using System.Collections.Generic;
using System.Text;

namespace SakuraStuffPack.Factory
{
    /// <summary>
    /// 业务的基类，包含一些公共的业务逻辑
    /// </summary>
    public abstract class BaseClass
    {
        protected BaseClass() { }

        public virtual void Print()
        {
            throw new InvalidOperationException();
        }
    }
}
