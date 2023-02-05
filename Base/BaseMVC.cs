using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XEditorFramework.XEditorUtility;

namespace XEditorFramework.Base
{
    public class BaseMVC
    {
        private EventChanel m_EventChanel;
        protected EventChanel InternalEventChanel { get { return m_EventChanel; } }

        public BaseMVC(EventChanel inEventChanel){
            m_EventChanel = inEventChanel;
            Utility.BindEvents(this, InternalEventChanel);
        }
    }
}