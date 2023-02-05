using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XDoubleField : XBaseFieldController<double>
    {
        public XDoubleField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override double OnPaint(string inTitle, double inValue)
        {
            return EditorGUILayout.DoubleField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}