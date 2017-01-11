using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLTest2
{
    class Util
    {
        //数据文件路径
        public static string dataPath = "";

        //配置文件名
        public static string xmlName = "";

        //配置文件路径
        public static string xmlPath = "";

        //配置文件路径，不包括文件名
        public static string xmlPath2 = "";

        //新券别名字
        public static string newCash = "";

        /// <summary>
        /// 泛用券别信息路径
        /// </summary>
        public static string cashInfoPath = "";

        /// <summary>
        /// 券别核对启动状态
        /// </summary>
        public static bool start = false;


        
    }

    /// <summary>
    /// 泛用券别箱捆包信息类
    /// </summary>
    class CashInfo
    {
        private string type;
        private string box;
        private string bundle;
        private string bag;

        public string Type
        {
            get{ return type;}
            set {type = value;}
        }

        public string Box
        {
            get{return box;}
            set{box = value;}
        }

        public string Bundle
        {
            get{return bundle;}
            set{bundle = value;}
        }

        public string Bag
        {
            get{return bag;}
            set{bag = value;}
        }

        public CashInfo()
        {
            this.Type = "";
            this.Box = "";
            this.Bundle = "";
            this.Bag = "";
        }

        public CashInfo(string type,string box,string bundle,string bag)
        {
            this.Type = type;
            this.Box = box;
            this.Bundle = bundle;
            this.Bag = bag;
        }
    }

    class XMLCashInfo
    {
        private string type;
        private string label;
        private string version;
        private string box;
        private string bundle;
        private string bag;

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Label
        {
            get
            {
                return label;
            }

            set
            {
                label = value;
            }
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }

        public string Box
        {
            get
            {
                return box;
            }

            set
            {
                box = value;
            }
        }

        public string Bundle
        {
            get
            {
                return bundle;
            }

            set
            {
                bundle = value;
            }
        }

        public string Bag
        {
            get
            {
                return bag;
            }

            set
            {
                bag = value;
            }
        }
        public XMLCashInfo()
        {
            Type = "";
            Label = "";
            Version = "";
            Box = "";
            Bundle = "";
            Bag = "";
        }
        public XMLCashInfo(string type,string lable,string version,string box,string bundle,string bag)
        {
            Type = type;
            Label = lable;
            Version = version;
            Box = box;
            Bundle = bundle;
            Bag = bag;
        }
        //public override string ToString()
        //{
        //    return Type;
        //}
    }
}
