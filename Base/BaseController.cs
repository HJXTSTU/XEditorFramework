using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XEditorFramework.XEditorUtility;

namespace XEditorFramework.Base
{
    public abstract class BaseController:BaseMVC
    {
        public BaseController(EventChanel inEventChanel):base(inEventChanel)
        {
        }

        public abstract void OnPaint();
    }
}