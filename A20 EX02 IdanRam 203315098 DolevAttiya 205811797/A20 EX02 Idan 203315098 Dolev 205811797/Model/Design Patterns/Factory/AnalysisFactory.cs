using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Documents;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory
{
    internal class AnalysisFactory 
    {
        public  Analysis Analysiser(
            Post.eType i_Type,
            User i_User,
            eTimeSelector i_TimeSelector,
            Type i_AnalysisToCreate)
        {
            Analysis selectedAnalysis = (Analysis)i_AnalysisToCreate.GetConstructors()[0].Invoke(null);
            string methodName = "CreateAnalysisByTimeFrame";

            foreach(MethodInfo method in i_AnalysisToCreate.GetMethods())
            {
                if(method.Name == methodName)
                {
                    selectedAnalysis = (Analysis)method.Invoke(
                        selectedAnalysis,
                        new object[] { i_User, i_TimeSelector });
                    ;
                    break;
                }
            }

            return selectedAnalysis;
        }

    }
}