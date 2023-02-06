using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XPasswordField : XBaseFieldController<string>
    {
        public XPasswordField(EventChanel inEventChanel) : base(inEventChanel)
        {
            
        }

        public override string OnPaint(string inTitle, string inValue)
        {
            return EditorGUILayout.PasswordField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}