﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhaoxi.Manage.BusinessInterface;

namespace Zhaoxi.Manage.BusinessService
{
    /// <summary>
    /// 这个方法中，可以有增删改查
    /// 不仅限于这个方法中需要 其他的类 也需要--提出公共的代码--把大家都需要的来一个父类，子类直接继承即可
    /// </summary>
    public class UserManagerService : BaseService, IUserManagerService
    {
        public UserManagerService(ISqlSugarClient client) : base(client)
        {
        }

        public void DeleteCompanyUser()
        {
            throw new NotImplementedException();
        }
    }
}
