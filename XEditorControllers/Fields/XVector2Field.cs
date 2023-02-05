using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XVector2Field : XBaseFieldController<Vector2>
    {
        public XVector2Field(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override Vector2 OnPaint(string inTitle, Vector2 inValue)
        {
            return EditorGUILayout.Vector2Field(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}