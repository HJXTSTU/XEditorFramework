namespace XEditorFramework.Messages {
    public class EditorMessageParamsGereric<T0>:EditorMessageParams{
        public T0 param;
    }

    public class EditorMessageParamsGereric<T0,T1>:EditorMessageParams{
        public T0 param0;
        
        public T1 param1;
    }
    
    public class EditorMessageParamsGereric<T0,T1,T2>:EditorMessageParams{
        public T0 param0;
        
        public T1 param1;

        public T2 param2;
    }

    public class EditorMessageParams<T0,T1,T2,T3>:EditorMessageParams{
        public T0 param0;
        
        public T1 param1;

        public T2 param2;

        public T3 param3;
    }
}
