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
            log4net.Config.XmlConfigurator.Configure();
            Log.Info("我是Info");
            Log.Debug("我是Debug");
            Log.Error("我是Error");

        }
    }
}
