using System;
using System.Reflection;
using Boost.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace Boost.Model.DesignPatterns.Factory.AnalysisFactory
{
    internal class AnalysisFactory 
    {
        public Analysis AnalysisCreator(
            eAnalysisDataBasis i_AnalysisDataBasis,
            User i_User,
            eTimeFrame i_TimeFrame,
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
                        new object[] { i_User, i_TimeFrame });
                    break;
                }
            }

            return selectedAnalysis;
        }
    }
}