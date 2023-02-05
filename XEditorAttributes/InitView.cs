using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XEditorFramework.XEditorAttributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class InitView : Attribute
    {
        public Type View{ get; set; }
        public InitView(Type inInitView)
        {
            View = inInitView;
        }
    }
}