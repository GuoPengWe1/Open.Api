using Open.Tool.BaseClass.BaseServices;
using Open.User.IRepositories.Users;
using Open.User.IServices.Users;
using Open.User.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.User.Services.Users
{
    public class UserInfoService : BaseService<UserInfo>, IUserInfoService
    {
        private readonly IUserInfoRepository _userInfoRepository;
        public UserInfoService(IUserInfoRepository userInfoRepository) : base(userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }



        /// <summary>
        /// 异步添加用户信息
        /// </summary>
        /// <returns></returns>
        public async Task<int> AddUserInfoAsync(UserInfo user)
        {
            
            user = new UserInfo()
            {
                UserName = "小郭",
                RealName = "郭鹏伟",
                Age = 8,
                Gender = 1,
                AddDatetime = DateTime.Now,
                UpdateDatetime = DateTime.Now,
                DeleteMark = 0,
            };

            //检查字段是否正确
            UserInfo userresault = ValueChecked(user);

            //执行异步添加
            return await _userInfoRepository.AddAsync(user);
        }

        protected UserInfo ValueChecked(UserInfo user)
        {
            if (string.IsNullOrEmpty(user.UserName))
            {
                user.UserName = $"OpenId{user.Id.Substring(0, 6)}";
            }


            return user;
        }
    }
}
