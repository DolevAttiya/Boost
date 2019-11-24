using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{
    class TimeAnalysis : IAnalysis
    {
        public TimeAnalysis()
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

        public Dictionary<DayAndHour, int> PhotosDictionary { get; private set; }

        public Dictionary<DayAndHour, int> VideosDictionary { get; private set; }

        public Dictionary<DayAndHour, int> StatusDictionary { get; private set; }

        public Dictionary<DayAndHour, int> CombinedAnalysisHolders { get; private set; }

        public void AddByType(eTimerSelector i_TimeToStrict)
        {
            DateTime timeIndicator = DateTime.Now;
            const int k_OlderThanTimeToStrict = 0;

            timeIndicator.AddDays((-1) * double.Parse(i_TimeToStrict.ToString())); //TODO 
            foreach(Post postToAnalysis in BoostEngine.LoggedInUser.Posts)
            {
                try
                {
                    if(timeIndicator.CompareTo(postToAnalysis.CreatedTime.Value.Date) < k_OlderThanTimeToStrict)
                    {
                        break;
                    }
                }

                catch(InvalidOperationException eOperation)
                {

                }

                postsParser(postToAnalysis, CombinedAnalysisHolders);
                switch(postToAnalysis.Type)
                {
                    case Post.eType.status:
                        PhotosDictionary = postsParser(postToAnalysis, PhotosDictionary); // TODO
                        break;
                    case Post.eType.photo:
                        PhotosDictionary = postsParser(postToAnalysis, PhotosDictionary); // TODO
                        break;
                    case Post.eType.video:
                        VideosDictionary = postsParser(postToAnalysis, VideosDictionary); // TODO
                        break;
                }
            }
        }

        private Dictionary<DayAndHour, int> postsParser(
            Post i_PostToAnalysis,
            Dictionary<DayAndHour, int> io_DictionaryToAnalysis)
        {
            io_DictionaryToAnalysis[new DayAndHour(
                i_PostToAnalysis.CreatedTime.Value.DayOfWeek,
                TimeSpan.FromHours(i_PostToAnalysis.CreatedTime.Value.Hour))] = i_PostToAnalysis.LikedBy.Count;

            return io_DictionaryToAnalysis;
        }

        public IAnalysis CalculateAnalysis(eTimerSelector i_TimeToStrict)
        {
            AddByType(i_TimeToStrict);

            TimeAnalysis o_CalculatedTopFans = new TimeAnalysis();
            o_CalculatedTopFans.PhotosDictionary = calculator(this.PhotosDictionary);
            o_CalculatedTopFans.VideosDictionary = calculator(this.VideosDictionary);
            o_CalculatedTopFans.StatusDictionary = calculator(this.StatusDictionary);
            o_CalculatedTopFans.CombinedAnalysisHolders = calculator(this.CombinedAnalysisHolders);
            return o_CalculatedTopFans;
        }

        private Dictionary<DayAndHour, int> calculator(Dictionary<DayAndHour, int> i_DictionaryToSort)
        {
            int numberOfIterations = BoostEngine.k_TopNumber;
            const int k_ZeroIterations = 0;

            Dictionary<DayAndHour, int> o_SortedDictionary = new Dictionary<DayAndHour, int>();
            foreach(KeyValuePair<DayAndHour, int> itemToSort in i_DictionaryToSort.OrderBy(key => key.Value))
            {
                if(numberOfIterations-- > k_ZeroIterations)
                {
                    break;
                }

                o_SortedDictionary.Add(itemToSort.Key, itemToSort.Value);
            }

            return o_SortedDictionary;
        }
    }
}
