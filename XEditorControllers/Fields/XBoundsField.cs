using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;
using XEditorFramework.XEditorControllers.Fields;

namespace XEditorFramework.XEditorControllers
{
    public class XBoundsField:XBaseFieldController<Bounds>
    {
        public XBoundsField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override Bounds OnPaint(string inTitle, Bounds  inValue){
            return EditorGUILayout.BoundsField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            
        }
    }
}