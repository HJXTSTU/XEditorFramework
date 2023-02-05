using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XEditorFramework.XEditorAttributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public class WithModel:Attribute
    {
        public Type ModelType{ get; set; }
        public WithModel(Type inModelType){
            ModelType = inModelType;
        }
    }
}