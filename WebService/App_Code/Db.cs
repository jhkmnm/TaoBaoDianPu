﻿using Dos.ORM;

/// <summary>
/// Db 的摘要说明
/// </summary>
class DB
{
    public static readonly DbSession Context = new DbSession("AccConn");

    static DB()
    {
        Context.RegisterSqlLogger(delegate (string sql)
        {
            //在此可以记录sql日志
            //写日志会影响性能，建议开发版本记录sql以便调试，发布正式版本不要记录
            //LogHelper.Debug(sql, "SQL日志");
        });
    }
}