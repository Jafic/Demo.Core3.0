using EZNEW.Module.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.DTO.Sys.Cmd
{
    /// <summary>
    /// 分组命令对象
    /// </summary>
    public class AuthorityGroupCmdDto
    {
        #region	属性

        /// <summary>
        /// 编号
        /// </summary>
        public long SysNo
        {
            get;
            set;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort
        {
            get;
            set;
        }

        /// <summary>
        /// 状态
        /// </summary>
        public AuthorityGroupStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// 上级分组
        /// </summary>
        public AuthorityGroupCmdDto Parent
        {
            get;
            set;
        }

        /// <summary>
        /// 分组等级
        /// </summary>
        public int Level
        {
            get;
            set;
        }

        /// <summary>
        /// 说明
        /// </summary>
        public string Remark
        {
            get;
            set;
        }

        #endregion
    }
}
