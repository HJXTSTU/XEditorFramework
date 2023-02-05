using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XRectField : XBaseFieldController<Rect>
    {
        public XRectField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override Rect OnPaint(string inTitle, Rect inValue)
        {
            return EditorGUILayout.RectField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}