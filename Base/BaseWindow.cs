using System.Reflection;
using System.Collections.Generic;
using System;
using UnityEditor;
using UnityEngine;
using XEditorFramework.XEditorAttributes;
using XEditorFramework.Base;

namespace XEditorFramework.Base
{
    public class BaseWindow : EditorWindow
    {
        protected EventChanel m_EventChanel;

        protected Stack<BaseView> m_Views;

        protected virtual void Awake()
        {
            Debug.Log("[XEditorFramework Base Window Awake]");
            m_EventChanel = new EventChanel();

            Property[] properties = (Property[])Attribute.GetCustomAttributes(this.GetType(), typeof(Property));
            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].PropertyType == "Title")
                {
                    this.titleContent = new GUIContent(properties[i].Value);
                }
            }

            m_Views = new Stack<BaseView>();

            //  TODO::
            //  1. 创建初始的View
            InitView initView = (InitView)Attribute.GetCustomAttribute(this.GetType(), typeof(InitView));
            ConstructorInfo constructorInfo = initView.View.GetConstructor(new Type[] { typeof(EventChanel) });

            SwitchView(constructorInfo.Invoke(new object[] { m_EventChanel }) as BaseView);
        }

        public void SwitchView(BaseView inView)
        {
            if (m_Views.Count > 0)
            {
                m_Views.Peek().OnPause();
            }
            inView.OnStart();
            m_Views.Push(inView);
        }

        public void PopView()
        {
            m_Views.Peek().OnExit();
            m_Views.Pop();
            if (m_Views.Count > 0)
            {
                m_Views.Peek().OnResume();
            }
        }

        private void OnGUI()
        {
            if (m_Views.Count > 0)
            {
                m_Views.Peek().PaintView();
            }
        }

        protected void OnDestroy()
        {
            while (m_Views.Count > 0)
            {
                PopView();
            }
        }
    }
}