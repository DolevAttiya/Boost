using System;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.AnalysisFactory
{
    public static class FactorySelector
    {
        public static IAnalysisFactory CreateFactory(this Type i_FactoryType)
        {
            return (IAnalysisFactory)i_FactoryType.GetConstructors()[0].Invoke(null);
        }
    }
}
