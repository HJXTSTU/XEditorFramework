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

        public float OnPaint(string inTitle, float inValue, Action<float> inIfModifyCallback)
        {
            float res = OnPaint(inTitle, inValue);
            if (res != inValue)
            {
                inIfModifyCallback?.Invoke(res);
            }
            return res;
        }

        public override void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}