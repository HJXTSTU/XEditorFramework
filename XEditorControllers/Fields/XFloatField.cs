using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XFloatField : XBaseFieldController<float>
    {
        public XFloatField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override float OnPaint(string inTitle, float inValue)
        {
            return EditorGUILayout.FloatField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}