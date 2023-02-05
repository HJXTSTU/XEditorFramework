using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XEditorFramework.Base;
using UnityEditor;
using UnityEngine;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XVector3Field : XBaseFieldController<Vector3>
    {
        public XVector3Field(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override Vector3 OnPaint(string inTitle, Vector3 inValue)
        {
            return EditorGUILayout.Vector3Field(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}