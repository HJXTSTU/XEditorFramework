using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers
{
    public class XSlider : BaseController
    {
        public XSlider(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public float OnPaint(string inTitile, float inValue, float inMin, float inMax){
            return EditorGUILayout.Slider(inTitile, inValue, inMin, inMax);
        }

        public override void OnPaint()
        {
            
        }
    }
}