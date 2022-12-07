using Open.Tool.GeneratingStrings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.User.Models.Users
{
    [Table("OpenDB_UserInfo")]
    public class UserInfo
    {
        public UserInfo()
        {
            this.Id = Guids.GeneratingGuidWithTime().Result;

        }
        /// <summary>
        /// Id
        /// </summary>
        [MaxLength(50)]
        public string Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [MaxLength(20)]
        public string UserName { get; set; }
        /// <summary>
        /// 真实名字
        /// </summary>
        [MaxLength(20)]
        public string? RealName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int DeleteMark { get; set; }
        /// <summary>
        /// 新增时间
        /// </summary>
        public DateTime AddDatetime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDatetime { get; set; }
    }
}
