namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    public interface  IAnalysis
    {
        IAnalysis CalculateAnalysis(eTimerSelector i_TimeToStrict);

        void AddByType(eTimerSelector i_TimeToStrict);
    }
}
