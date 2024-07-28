using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Data.AppMetaData
{
    public static class Router
    {
        public const string Root = "Api";
        public const string Version = "V1";
        public const string Rule = Root + "/" + Version +"/";

        public static class StudentRouting
        {
            public const string Prefix = Rule + "student";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + "/{id}";
        }
    }
}
