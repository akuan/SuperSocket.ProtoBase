using System;
using log4net; 

namespace SuperSocket.ProtoBase
{
    /// <summary>
    /// 
    /// </summary>
    public class EE
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <param name="log"></param>
        public static void LogError(string s, Exception e, ILog log)
        {
            log.Error($"{s}{e.Message}");
            log.Error(e.StackTrace);
            while (e.InnerException != null)
            {
                log.Error($"InnerException:{e.InnerException.Message}\r\n{e.InnerException.StackTrace}");
                e = e.InnerException;
            }
        }
    }
}
