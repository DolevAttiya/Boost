using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    class TimeAnalysis : Analysis, IAnalysis
    {
        public TimeAnalysis()
        {
            initializeComponents();
        }

        private void initializeComponents()
        {
            const int k_ZeroLikesYet = 0;
            for(int days = 0; days < DayAndHour.k_NumberDaysOfWeek; days++)
            {
                for(int hour = 0; hour < DayAndHour.k_NumberHoursADay; hour++)
                {
                    DayAndHour tempDayAndHour = new DayAndHour(DayOfWeek.Sunday + days, TimeSpan.FromHours(hour));
                    // Created At that exact time in order to match the days of the week (Sunday - Saturday ) with the date: Sunday = 1 Monday= 2 etc.
                    PhotosDictionary.Add(tempDayAndHour, k_ZeroLikesYet);
                    VideosDictionary.Add(tempDayAndHour, k_ZeroLikesYet);
                    StatusDictionary.Add(tempDayAndHour, k_ZeroLikesYet);
                    CombinedAnalysisHolders.Add(tempDayAndHour, k_ZeroLikesYet);
                }
            }
        }

        protected override Dictionary<object, int> postsParser(
            Post i_PostToAnalysis,
            Dictionary<object, int> io_DictionaryToAnalysis)
        {
            io_DictionaryToAnalysis[new DayAndHour(
                i_PostToAnalysis.CreatedTime.Value.DayOfWeek,
                TimeSpan.FromHours(i_PostToAnalysis.CreatedTime.Value.Hour))] = i_PostToAnalysis.LikedBy.Count;

            return io_DictionaryToAnalysis;
        }

        private IAnalysis calculateAnalysis()
        {
            TimeAnalysis o_CalculatedTopFans = new TimeAnalysis();
            o_CalculatedTopFans.PhotosDictionary = calculator(this.PhotosDictionary);
            o_CalculatedTopFans.VideosDictionary = calculator(this.VideosDictionary);
            o_CalculatedTopFans.StatusDictionary = calculator(this.StatusDictionary);
            o_CalculatedTopFans.CombinedAnalysisHolders = calculator(this.CombinedAnalysisHolders);
            return o_CalculatedTopFans;
        }

        public IAnalysis CreateAnalysisByTimeStrict(eTimerSelector i_TimeToStrict = eTimerSelector.Month)
        {
            initializeComponents();
            addByType(i_TimeToStrict);
            return calculateAnalysis();
        }
    }
}
