using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XColorField : XBaseFieldController<Color>
    {
        public XColorField(EventChanel inEventChanel) : base(inEventChanel)
        {

        }

        public override Color OnPaint(string inTitle, Color inValue) {
            return EditorGUILayout.ColorField(inTitle,inValue);
        }

        public override void OnPaint()
        {

        }
    }
}