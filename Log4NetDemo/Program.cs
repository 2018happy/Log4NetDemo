using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
namespace Log4NetDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //创建一个日志对象，返回的对象类实现了ILog接口中的所有方法
            ILog Log = LogManager.GetLogger("log4NetDemo");
            //应用应用程序配置文件中的log4net配置 
            XmlConfigurator.Configure();
            //LogicalThreadContext.Properties["Operator"] 属性:获取或设置Log4Net关于“日志输出到数据库”配置中名为"Operator"的参数值
            LogicalThreadContext.Properties["Operator"] = "李明";
            //输出Info级别的日志信息
            Log.Info("我是Info");
            //输出Debug级别的日志信息
            Log.Debug("我是Debug");
            //输出Error级别的日志信息
            Log.Error("我是Error");
            
            Console.ReadLine();
        }
    }
}
