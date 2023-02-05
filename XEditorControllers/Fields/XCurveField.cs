using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XCurveField : XBaseFieldController<AnimationCurve>
    {
        public XCurveField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override AnimationCurve OnPaint(string inTitle, AnimationCurve inValue){
            return EditorGUILayout.CurveField(inTitle,inValue);
        }

        public override void OnPaint()
        {
        }
    }
}