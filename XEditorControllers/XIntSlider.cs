using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers
{
    public class XIntSlider : BaseController
    {
        public XIntSlider(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public int OnPaint(string inTitile, int inValue, int inMin, int inMax)
        {
            return EditorGUILayout.IntSlider(inTitile, inValue, inMin, inMax);
        }

        public override void OnPaint()
        {
            
        }
    }
}