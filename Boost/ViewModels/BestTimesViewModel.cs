using System;
using System.Linq;
using Boost.Model;
using Boost.Model.DataClasses;
using Boost.Model.DesignPatterns.Decorator;
using Boost.Model.DesignPatterns.Factory.AnalysisFactory;
using FacebookWrapper.ObjectModel;

namespace Boost.ViewModels
{
    public class BestTimesViewModel
    {
        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;

        public TimeAnalysis TimeAnalysis { get; set; }

        public SortedValueDictionary<object, int> AnalysisCollection { get; set; }

        public int MaxTimeAnalysisValue { get; set; }

        public void CreateTimeAnalysis(User i_User, eTimeFrame i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis)
        {
            Type analysisFactoryType = typeof(TimeAnalysisFactory);

            if (r_BoostEn.m_AnalysisFactory.GetType() != analysisFactoryType)
            {
                r_BoostEn.SelectAnalysisFactoryType(analysisFactoryType);
            }

            TimeAnalysis = (TimeAnalysis)r_BoostEn.CreateAnalysisUsingFactory(i_TimeFrame, i_AnalysisDataBasis);
            SelectAnalysisCollection(i_AnalysisDataBasis);
            MaxTimeAnalysisValue = AnalysisCollection.Values.Max();
        }

        public void SelectAnalysisCollection(eAnalysisDataBasis i_AnalysisDataBasis)
        {
            AnalysisCollection = TimeAnalysis.GetSpecificAnalysisCollection(i_AnalysisDataBasis);
        }
    }
}
