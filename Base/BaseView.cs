using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using XEditorFramework.Messages;
using XEditorFramework.XEditorAttributes;
using XEditorFramework.XEditorUtility;

namespace XEditorFramework.Base
{
    public abstract class BaseView:BaseMVC
    {
        protected BaseModel m_Model;

        public BaseView(EventChanel inEventChanel):base(inEventChanel)
        {
            WithModel modelInfo = (WithModel)Attribute.GetCustomAttribute(this.GetType(),typeof(WithModel));
            if (modelInfo != null)
            {
                ConstructorInfo modelConstructor = modelInfo.ModelType.GetConstructor(new Type[] { typeof(EventChanel) });
                m_Model = (BaseModel)modelConstructor.Invoke(new object[] { inEventChanel });
            }
        }

        public abstract void OnStart();

        public abstract void OnPause();

        public abstract void OnResume();

        public abstract void OnExit();

        public abstract void PaintView();
    }
}