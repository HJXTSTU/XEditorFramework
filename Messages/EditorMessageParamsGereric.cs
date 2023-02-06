namespace XEditorFramework.Messages {
    public class EditorMessageParamsGereric<T0>:EditorMessageParams{
        public T0 param;
        public EditorMessageParamsGereric(T0 inParam)
        {
            param = inParam;
        }
        public EditorMessageParamsGereric()
        {

        }
    }

    public class EditorMessageParamsGereric<T0,T1>:EditorMessageParams{
        public T0 param0;
        
        public T1 param1;
        public EditorMessageParamsGereric()
        {

        }
        public EditorMessageParamsGereric(T0 inParam0,T1 inParam1)
        {
            param0 = inParam0;
            param1 = inParam1;
        }
    }
    
    public class EditorMessageParamsGereric<T0,T1,T2>:EditorMessageParams{
        public T0 param0;
        
        public T1 param1;

        public T2 param2;

        public EditorMessageParamsGereric(T0 inParam0, T1 inParam1,T2 inParam2)
        {
            param0 = inParam0;
            param1 = inParam1;
            param2 = inParam2;
        }
        public EditorMessageParamsGereric()
        {

        }
    }

    public class EditorMessageParamsGereric<T0,T1,T2,T3>:EditorMessageParams{
        public T0 param0;
        
        public T1 param1;

        public T2 param2;

        public T3 param3;

        public EditorMessageParamsGereric(T0 inParam0, T1 inParam1, T2 inParam2,T3 inParam3)
        {
            param0 = inParam0;
            param1 = inParam1;
            param2 = inParam2;
            param3 = inParam3;
        }
        public EditorMessageParamsGereric()
        {

        }
    }
}
