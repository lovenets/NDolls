﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.IO;
using System.Xml;

namespace NDolls.Core.Util
{
    public class ValidateUtil
    {
        /// <summary>
        /// 通过正则表达式验证字符串是否符合模式
        /// </summary>
        /// <param name="validateInput">要验证的字符串</param>
        /// <param name="pattern">正则模式</param>
        /// <returns>是否匹配</returns>
        public static bool IsMatch(String validateInput,String pattern)
        {
            Regex reg = new Regex(pattern);
            Match m = reg.Match(validateInput);
            return m.Success;
        }

        /// <summary>
        /// 根据模式字典key获取正则模式字符串
        /// </summary>
        /// <param name="patternKey">字典表key</param>
        /// <returns>正则表达式</returns>
        public static string GetPattern(String patternKey)
        {
            return NDolls.Core.Patterns.ResourceManager.GetString(patternKey);
        }
    }
}
