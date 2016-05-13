using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Web.Mvc;
using MES.Models;
using MES.Services;

namespace MyCode
{
    private class ColumnDesc{//自定义操作类，待后面扩展用
        public ColumnSchema Col;
        public string ColName;//列名称
        public string DefaultValue;//查询的时候赋初值  String类型的"",DateTime类型"",int类型-1
        public string varNmae;//html中定义的ID名称  String类型的s开头，int类型的n开头
        public bool IsKey;//是否为主键
        public bool IsNullable;//是否可空
    }
    
    public static class stringExtend
    {
        public static string getPritStr(this string src)
        {
            string[] strarr=src.Split('_');
            string name="";
            name=strarr[0][0].ToString().ToUpper()+strarr[0].Substring(1).ToLower();
            for(int j=1;j<strarr.Length;j++)
            {
                name+=strarr[j][0].ToString().ToUpper()+strarr[j].Substring(1).ToLower();
            }
            return name;
        }
    }
}