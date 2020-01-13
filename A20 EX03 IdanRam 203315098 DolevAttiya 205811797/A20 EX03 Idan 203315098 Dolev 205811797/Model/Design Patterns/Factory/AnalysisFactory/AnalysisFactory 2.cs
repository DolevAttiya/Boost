﻿using System;
using System.Reflection;
using A20_EX03_Idan_203315098_Dolev_205811797.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX03_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.AnalysisFactory
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