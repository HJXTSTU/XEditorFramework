using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
        public class XBoundsIntField:XBaseFieldController<BoundsInt>
    {
        public XBoundsIntField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override BoundsInt OnPaint(string inTitle, BoundsInt  inValue){
            return EditorGUILayout.BoundsIntField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            
        }
    }
}