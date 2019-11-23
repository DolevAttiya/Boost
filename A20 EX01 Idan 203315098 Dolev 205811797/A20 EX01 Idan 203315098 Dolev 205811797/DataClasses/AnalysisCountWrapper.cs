using System;


namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    public class AnalysisCountWrapper<T>
    {
        public int Value { get;private set; }

        public void AddAmount(int i_AmountToAdd)
        {
            Value += i_AmountToAdd;
        }

        public T DataAnalysis { get; }

        public AnalysisCountWrapper(T i_DataAnalysis)
        {
            Value = 0;
            DataAnalysis = i_DataAnalysis;
        }
    }
}
