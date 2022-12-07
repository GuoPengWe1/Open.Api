using Open.Tool.BaseClass.BaseRepositories;
using Open.User.IRepositories.Users;
using Open.User.Models;
using Open.User.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.User.Repositories.Users
{
    public class UserInfoRepository: BaseRepository<UserInfo> , IUserInfoRepository 
    {


        public UserInfoRepository(UserDbContext context):base(context)
        {

        }

    }
}
