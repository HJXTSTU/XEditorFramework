using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers
{
    public class XTextArea : BaseController
    {
        public XTextArea(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public string OnPaint(string inText){
            return EditorGUILayout.TextArea(inText);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}