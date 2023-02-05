using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XLongField : XBaseFieldController<long>
    {
        public XLongField(EventChanel inEventChanel) : base(inEventChanel)
        {
        }

        public override long OnPaint(string inTitle, long inValue)
        {
            return EditorGUILayout.LongField(inTitle, inValue);
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}