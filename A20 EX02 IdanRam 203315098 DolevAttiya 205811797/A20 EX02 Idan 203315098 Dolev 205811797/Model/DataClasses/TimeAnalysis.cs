using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public class TimeAnalysis : Analysis, IAnalysis
    {
        #region Ctor
        public TimeAnalysis()
        {
            initializeComponents();
        }
        #endregion

        #region Methods
        private void initializeComponents()
        {
            PhotosDictionary = new Design_Patterns.SortedDictionary<object, int>(new Dictionary<object, int>());
            VideosDictionary = new Design_Patterns.SortedDictionary<object, int>(new Dictionary<object, int>());
            StatusDictionary = new Design_Patterns.SortedDictionary<object, int>(new Dictionary<object, int>());
            CombinedAnalysisHolders = new Design_Patterns.SortedDictionary<object, int>(new Dictionary<object, int>());
            const int k_ZeroLikesYet = 0;

            for(int days = 0; days < DayAndHour.k_NumOfWeekDays; days++)
            {
                for(int hour = 0; hour < DayAndHour.k_NumOfHours; hour++)
                {
                    DayAndHour tempDayAndHour = new DayAndHour(DayOfWeek.Sunday + days, TimeSpan.FromHours(hour));
                    //// Created at that exact time in order to match week days (Sunday - Saturday ) with the date: Sunday = 1 Monday= 2 etc.
                    PhotosDictionary.Add(tempDayAndHour, k_ZeroLikesYet);
                    VideosDictionary.Add(tempDayAndHour, k_ZeroLikesYet);
                    StatusDictionary.Add(tempDayAndHour, k_ZeroLikesYet);
                    CombinedAnalysisHolders.Add(tempDayAndHour, k_ZeroLikesYet);
                }
            }
        }

        protected override void PostParser(
            Post i_PostToAnalysis,
            ref Design_Patterns.SortedDictionary<object, int> io_DictionaryToAnalysis)
        {
            try
            {
                io_DictionaryToAnalysis[new DayAndHour(
                    i_PostToAnalysis.CreatedTime.Value.DayOfWeek,
                    TimeSpan.FromHours(i_PostToAnalysis.CreatedTime.Value.Hour))] = i_PostToAnalysis.LikedBy.Count;
            }
            catch(Exception e)
            {
                throw new NullReferenceException("The there is no post to Parse", e);
            }
        }
               
        public IAnalysis CreateAnalysisByTimeFrame(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame = eTimeSelector.Month)
        {
            initializeComponents();
            AddByType(i_AnalysisUser, i_TimeFrame);
            return this;
        }
        #endregion
    }
}
