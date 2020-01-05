using System;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory
{
    public interface IAnalysisFactory
    {
        Analysis CreateAnalysis(
            Post.eType i_Type,
            User i_User,
            eTimeSelector i_TimeSelector);

    }
}
