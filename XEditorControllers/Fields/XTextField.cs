using System.Data.SqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;
using XEditorFramework.XEditorControllers.Fields;

namespace XEditorFramework.XEditorControllers
{
    public class XTextField : XBaseFieldController<string>
    {
        public XTextField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override string OnPaint(string inTitle, string  inValue){
            return EditorGUILayout.TextField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            
        }
    }
}