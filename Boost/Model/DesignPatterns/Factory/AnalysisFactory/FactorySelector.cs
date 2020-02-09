using System;

namespace Boost.Model.DesignPatterns.Factory.AnalysisFactory
{
    public static class FactorySelector
    {
        public static IAnalysisFactory CreateFactory(this Type i_FactoryType)
        {
            return (IAnalysisFactory)i_FactoryType.GetConstructors()[0].Invoke(null);
        }
    }
}
