﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fast.Framework.Abstract;
using Fast.Framework.Enum;
using Fast.Framework.Extensions;
using Fast.Framework.Interfaces;

namespace Fast.Framework.Oracle
{

    /// <summary>
    /// Oracle插入建造者
    /// </summary>
    public class OracleInsertBuilder : InsertBuilder
    {

        /// <summary>
        /// 数据库类型
        /// </summary>
        public override DbType DbType => DbType.Oracle;

        /// <summary>
        /// 返回自增模板
        /// </summary>
        public override string ReturnIdentityTemplate => throw new NotSupportedException();
    }
}
