using System.Collections.Generic;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory
{
    public interface IAnalysisFactoryDictionary
    {
        IDictionary<object, int> CreateTimeAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame,
            Post.eType i_PostType);

        IDictionary<object, int> CreateBiggestFanAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame,
            Post.eType i_PostType);
    }
}
