using DemoOA.Zhang.Model;
using DemoOA.Zhang.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOA.Zhang.IBLL
{
   public partial interface IUserInfoService:IBaseService<UserInfo>
    {
       bool DeleteEntities(List<int>list);
       IQueryable<UserInfo> LoadSearchEntities(UserInfoSearch userInfoSearch, short delFlag);
       bool SetUserRoleInfo(int userId,List<int>roleIdList);
       bool SetUserActionInfo(int actionId,int userId,bool isPass);
    }
}
