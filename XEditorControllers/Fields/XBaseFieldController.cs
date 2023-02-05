using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public abstract class XBaseFieldController<T> : BaseController
    {
        public XBaseFieldController(EventChanel inEventChanel) : base(inEventChanel)
        {
        }
        
        public abstract T OnPaint(string inTitle, T inValue);
    }
}