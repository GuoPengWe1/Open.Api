using Open.Tool.BaseClass.BaseServices;
using Open.User.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.User.IServices.Users
{
    public interface IUserInfoService :IService<UserInfo>
    {
        /// <summary>
        /// 异步添加用户信息
        /// </summary>
        /// <returns></returns>
        Task<int> AddUserInfoAsync(UserInfo user);

    }
}
