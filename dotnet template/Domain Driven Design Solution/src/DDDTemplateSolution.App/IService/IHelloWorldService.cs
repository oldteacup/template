using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTemplateSolution.App.IService
{
    public interface IHelloWorldService
    {
        /// <summary>
        /// 说你好
        /// </summary>
        /// <returns></returns>
        string SayHello();
        /// <summary>
        /// 说再见
        /// </summary>
        /// <returns></returns>
        string SayGoodBye();
    }
}
