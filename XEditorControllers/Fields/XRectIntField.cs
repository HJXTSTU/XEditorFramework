using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XRectIntField : XBaseFieldController<RectInt>
    {
        public XRectIntField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override RectInt OnPaint(string inTitle, RectInt inValue)
        {
            return EditorGUILayout.RectIntField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}