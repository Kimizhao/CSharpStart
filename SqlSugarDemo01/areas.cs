using System;
using System.Linq;
using System.Text;

namespace SqlSugarDemo01
{
    ///<summary>
    ///区域表
    ///</summary>
    public partial class areas
    {
           public areas(){


           }
           /// <summary>
           /// Desc:区域编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AreasID {get;set;}

           /// <summary>
           /// Desc:父区域编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AreasParentID {get;set;}

           /// <summary>
           /// Desc:区域名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AreasName {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? AreasEstate {get;set;}

    }
}
