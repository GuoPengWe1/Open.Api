using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Tool.GeneratingStrings
{
    /// <summary>
    /// Guids类
    /// </summary>
    public class Guids
    {
        public Guids()
        {

        }
        /// <summary>
        /// 异步生成guid和时间拼接字符串
        /// </summary>
        public static async Task<string> GeneratingGuidWithTime()
        {

            return await Task.Run(() =>
            {
                string guid =$"{DateTime.Now.ToString("HHmmss")}{Guid.NewGuid().ToString().Substring(6)}";//时间生成+guid截取6位数
                return guid;
            });
            
        }
    }
}
