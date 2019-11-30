using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses
{
    public class TimeAnalysis : Analysis, IAnalysis
    {
        public TimeAnalysis()
        {
            initializeComponents();
        }

        private void initializeComponents()
        {
            PhotosDictionary = new Dictionary<object, int>();
            VideosDictionary = new Dictionary<object, int>();
            StatusDictionary = new Dictionary<object, int>();
            CombinedAnalysisHolders = new Dictionary<object, int>();
            const int k_ZeroLikesYet = 0;

            for(int days = 0; days < DayAndHour.k_NumberDaysOfWeek; days++)
            {
                for(int hour = 0; hour < DayAndHour.k_NumberHoursADay; hour++)
                {
                    DayAndHour tempDayAndHour = new DayAndHour(DayOfWeek.Sunday + days, TimeSpan.FromHours(hour));
                    //// Created At that exact time in order to match the days of the week (Sunday - Saturday ) with the date: Sunday = 1 Monday= 2 etc.
                    PhotosDictionary.Add(tempDayAndHour, k_ZeroLikesYet);
                    VideosDictionary.Add(tempDayAndHour, k_ZeroLikesYet);
                    StatusDictionary.Add(tempDayAndHour, k_ZeroLikesYet);
                    CombinedAnalysisHolders.Add(tempDayAndHour, k_ZeroLikesYet);
                }
            }
        }

        protected override Dictionary<object, int> PostsParser(
            Post i_PostToAnalysis,
            Dictionary<object, int> io_DictionaryToAnalysis)
        {
            io_DictionaryToAnalysis[new DayAndHour(
                i_PostToAnalysis.CreatedTime.Value.DayOfWeek, ////TODO 
                TimeSpan.FromHours(i_PostToAnalysis.CreatedTime.Value.Hour))] = i_PostToAnalysis.LikedBy.Count;

            return io_DictionaryToAnalysis;
        }

        private IAnalysis calculateAnalysis(TimeAnalysis i_CurrentTimeAnalysis)
        {
            return new TimeAnalysis
                       {
                           PhotosDictionary = Calculator(this.PhotosDictionary),
                           VideosDictionary = Calculator(this.VideosDictionary),
                           StatusDictionary = Calculator(this.StatusDictionary),
                           CombinedAnalysisHolders = Calculator(this.CombinedAnalysisHolders)
                       };
        }


        public IAnalysis CreateAnalysisByTimeStrict(
            User i_UserToDoAnalysisOn,
            eTimerSelector i_TimeToStrict = eTimerSelector.Month)
        {
            initializeComponents();
            AddByType(i_UserToDoAnalysisOn, i_TimeToStrict);
            return calculateAnalysis(this);
        }
        public TimeAnalysis GetAnalysisByTimeStrict(
            User i_UserToDoAnalysisOn,
            eTimerSelector i_TimeToStrict = eTimerSelector.Month)
        {
            initializeComponents();
            AddByType(i_UserToDoAnalysisOn, i_TimeToStrict);
            return this;
        }
    }
}
