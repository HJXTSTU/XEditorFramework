using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XVector3IntField : XBaseFieldController<Vector3Int>
    {
        public XVector3IntField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override Vector3Int OnPaint(string inTitle, Vector3Int inValue)
        {
            return EditorGUILayout.Vector3IntField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}