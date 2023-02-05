using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XLayerField : XBaseFieldController<int>
    {
        public XLayerField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override int OnPaint(string inTitle, int inValue)
        {
            return EditorGUILayout.LayerField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}