﻿using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.MethodFactory
{
    public static class PhotosDictionaryFactory
    {
        private static readonly DictionaryFactory sr_BasicFactory = new DictionaryFactory();

        public static SortedValueDictionary<object, int> CreatePhotosTimeAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame)
        {
            return sr_BasicFactory.CreateTimeAnalysisDictionary(
                i_AnalysisUser,
                i_TimeFrame,
                i_EType => Post.eType.photo == i_EType);
        }

        public static SortedValueDictionary<object, int> CreatePhotosBiggestFansAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame)
        {
            return sr_BasicFactory.CreateBiggestFanAnalysisDictionary(i_AnalysisUser, i_TimeFrame, i_EType => Post.eType.photo == i_EType);
        }
    }   
}