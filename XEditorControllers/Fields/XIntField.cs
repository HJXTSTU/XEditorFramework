using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using XEditorFramework.Base;

namespace XEditorFramework.XEditorControllers.Fields
{
    public class XIntField : XBaseFieldController<int>
    {
        public XIntField(EventChanel inEventChanel) : base(inEventChanel)
        {
            
        }

        public override int OnPaint(string inTitle, int inValue)
        {
            return EditorGUILayout.IntField(inTitle,inValue);
        }

        public int OnPaint(string inTitle, int inValue, Action<int> inIfModifyCallback)
        {
            int res = OnPaint(inTitle, inValue);
            if(res != inValue)
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