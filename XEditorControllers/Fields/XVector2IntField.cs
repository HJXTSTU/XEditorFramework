using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XVector2IntField : XBaseFieldController<Vector2Int>
    {
        public XVector2IntField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override Vector2Int OnPaint(string inTitle, Vector2Int inValue)
        {
            return EditorGUILayout.Vector2IntField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}