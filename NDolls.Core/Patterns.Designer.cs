﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1022
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NDolls.Core {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Patterns {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Patterns() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NDolls.Core.Patterns", typeof(Patterns).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 ^[a-zA-Z][a-zA-Z0-9_]{4,15}$ 的本地化字符串。
        /// </summary>
        internal static string Account {
            get {
                return ResourceManager.GetString("Account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^[A-Za-z0-9]+$ 的本地化字符串。
        /// </summary>
        internal static string CaseOrNum {
            get {
                return ResourceManager.GetString("CaseOrNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^[\u4e00-\u9fa5]{0,}$ 的本地化字符串。
        /// </summary>
        internal static string Chinese {
            get {
                return ResourceManager.GetString("Chinese", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^\s*([A-Za-z0-9_-]+(\.\w+)*@([\w-]+\.)+\w{2,10})\s*$ 的本地化字符串。
        /// </summary>
        internal static string EMail {
            get {
                return ResourceManager.GetString("EMail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^[A-Za-z]+$ 的本地化字符串。
        /// </summary>
        internal static string English {
            get {
                return ResourceManager.GetString("English", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^-?([1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0)$ 的本地化字符串。
        /// </summary>
        internal static string Float {
            get {
                return ResourceManager.GetString("Float", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;(\S*?)[^&gt;]*&gt;.*?&lt;/\1&gt;|&lt;.*? /&gt; 的本地化字符串。
        /// </summary>
        internal static string HTML {
            get {
                return ResourceManager.GetString("HTML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^\d{15}|\d{18}$ 的本地化字符串。
        /// </summary>
        internal static string IDNo {
            get {
                return ResourceManager.GetString("IDNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^-?[1-9]\d*$ 的本地化字符串。
        /// </summary>
        internal static string Int {
            get {
                return ResourceManager.GetString("Int", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 \d+\.\d+\.\d+\.\d+ 的本地化字符串。
        /// </summary>
        internal static string IP {
            get {
                return ResourceManager.GetString("IP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^[a-z]+$ 的本地化字符串。
        /// </summary>
        internal static string LowerCase {
            get {
                return ResourceManager.GetString("LowerCase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^-([1-9]\d*\.\d*|0\.\d*[1-9]\d*)$ 的本地化字符串。
        /// </summary>
        internal static string NegativeFloat {
            get {
                return ResourceManager.GetString("NegativeFloat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^-[1-9]\d*$ 的本地化字符串。
        /// </summary>
        internal static string NegativeInt {
            get {
                return ResourceManager.GetString("NegativeInt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^[+-]?([0-9]*\.?[0-9]+|[0-9]+\.?[0-9]*)([eE][+-]?[0-9]+)?$ 的本地化字符串。
        /// </summary>
        internal static string Number {
            get {
                return ResourceManager.GetString("Number", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 \d{3}-\d{8}|\d{4}-\d{7} 的本地化字符串。
        /// </summary>
        internal static string Phone {
            get {
                return ResourceManager.GetString("Phone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^[1-9]\d*\.\d*|0\.\d*[1-9]\d*$ 的本地化字符串。
        /// </summary>
        internal static string PositiveFloat {
            get {
                return ResourceManager.GetString("PositiveFloat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^[1-9]\d*$ 的本地化字符串。
        /// </summary>
        internal static string PositiveInt {
            get {
                return ResourceManager.GetString("PositiveInt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [1-9]\d{5}(?!\d) 的本地化字符串。
        /// </summary>
        internal static string Postcode {
            get {
                return ResourceManager.GetString("Postcode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [1-9][0-9]{4,} 的本地化字符串。
        /// </summary>
        internal static string QQ {
            get {
                return ResourceManager.GetString("QQ", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ^[A-Z]+$ 的本地化字符串。
        /// </summary>
        internal static string UpperCase {
            get {
                return ResourceManager.GetString("UpperCase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)? 的本地化字符串。
        /// </summary>
        internal static string URL {
            get {
                return ResourceManager.GetString("URL", resourceCulture);
            }
        }
    }
}
