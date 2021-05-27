using System;
using System.Linq;
using System.Text;

namespace SqlSugarDemo01
{
    ///<summary>
    ///用户
    ///</summary>
    public partial class User
    {
           public User(){


           }
           /// <summary>
           /// Desc:用户编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserID {get;set;}

           /// <summary>
           /// Desc:登录账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserAccount {get;set;}

           /// <summary>
           /// Desc:用户名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// Desc:Mail邮箱
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserMail {get;set;}

           /// <summary>
           /// Desc:密码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserPwd {get;set;}

           /// <summary>
           /// Desc:状态	            删除：-1,	            停用：0,	            正常：1
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int UserEstate {get;set;}

           /// <summary>
           /// Desc:第一次访问时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UserFirstVisit {get;set;}

           /// <summary>
           /// Desc:上一次访问时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UserPreviousVisit {get;set;}

           /// <summary>
           /// Desc:最后访问时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UserLastVisist {get;set;}

           /// <summary>
           /// Desc:登录次数
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? UserLoginCount {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserDescription {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime UserCreateDate {get;set;}

           /// <summary>
           /// Desc:修改日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime UserUpdateDate {get;set;}

           /// <summary>
           /// Desc:手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserPhone {get;set;}

           /// <summary>
           /// Desc:账号等级(2超级管理员 1管理员 0普通用户)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte UserAccountLevel {get;set;}

    }
}
