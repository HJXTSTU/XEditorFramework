using System;
using System.Collections.Generic;
using System.Reflection;
using XEditorFramework.Messages;
using XEditorFramework.XEditorAttributes;
using XEditorFramework.XEditorUtility;

namespace XEditorFramework.Base
{
    public class BaseModel:BaseMVC
    {
        public BaseModel(EventChanel inEventChanel):base(inEventChanel)
        {
        }
    }
}