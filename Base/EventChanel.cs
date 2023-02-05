using System.ComponentModel;
using System;
using System.Collections.Generic;
using XEditorFramework.Messages;

namespace XEditorFramework.Base{
    public class EventChanel {
        private Dictionary<string, EditorActionEvent> m_ModelEvents;
        private Dictionary<string, EditorActionEvent> m_ViewEvents;
        public EventChanel() {
            m_ModelEvents = new Dictionary<string, EditorActionEvent>();
            m_ViewEvents = new Dictionary<string, EditorActionEvent>();
        }

        public void SendEventFromModel(string inEventType, object inSender, EditorMessageParams inParams) {
            if(m_ViewEvents.ContainsKey(inEventType)) {
                m_ViewEvents[inEventType].Send(inSender, inParams);
            }
        }

        public void SendEventFromView(string inEventType, object inSender, EditorMessageParams inParams) {
            if(m_ModelEvents.ContainsKey(inEventType)) {
                m_ModelEvents[inEventType].Send(inSender,inParams);
            }
        }

        public void RegisterModelEvent(string inEventType, EventCallback inCallback) {
            if(!m_ModelEvents.ContainsKey(inEventType)){
                m_ModelEvents.Add(inEventType, new EditorActionEvent());
            }
            m_ModelEvents[inEventType].AddListener(inCallback);
        }

        public void RegisterViewEvent(string inEventType, EventCallback inCallback) {
            if(!m_ViewEvents.ContainsKey(inEventType)) {
                m_ViewEvents.Add(inEventType, new EditorActionEvent());
            }
            m_ViewEvents[inEventType].AddListener(inCallback);
        }

        public void RemoveModelEvent(string inEventType, EventCallback inCallback) {
            if(m_ModelEvents.ContainsKey(inEventType)){
                m_ModelEvents[inEventType].RemoveListeners(inCallback);
            }
        }

        public void RemoveViewEvent(string inEventType, EventCallback inCallback) {
            if(m_ViewEvents.ContainsKey(inEventType)) {
                m_ViewEvents[inEventType].RemoveListeners(inCallback);
            }
        }
    }
}