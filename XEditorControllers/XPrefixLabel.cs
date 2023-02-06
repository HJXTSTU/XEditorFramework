using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers
{
    public class XPrefixLabel : BaseController
    {
        public XPrefixLabel(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public void OnPaint(string inLabel){
            EditorGUILayout.PrefixLabel(inLabel);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}