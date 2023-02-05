using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers
{
    public class XToggle : BaseMVC
    {
        public XToggle(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public bool OnPaint(string inTitle, bool inValue){
            return EditorGUILayout.Toggle(inTitle, inValue);
        }
    }
}