using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XGradientField : XBaseFieldController<Gradient>
    {
        public XGradientField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override Gradient OnPaint(string inTitle, Gradient inValue)
        {
            return EditorGUILayout.GradientField(inTitle,inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}