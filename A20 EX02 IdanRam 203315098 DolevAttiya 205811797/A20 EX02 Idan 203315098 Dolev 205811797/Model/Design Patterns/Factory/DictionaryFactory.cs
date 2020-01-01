using System;
using System.Collections.Generic;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory
{
    internal class DictionaryFactory
    {

        public static SortedValueDictionary<object, int> CreateTimeAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame,
            Func<Post.eType?, bool> Tester)
        {
            SortedValueDictionary<object, int> o_DictionaryToAnalysis =
                new SortedValueDictionary<object, int>(new Dictionary<object, int>());
            const int k_ZeroLikesYet = 0;

            for(int days = 0; days < DayAndHour.k_NumOfWeekDays; days++)
            {
                for(int hour = 0; hour < DayAndHour.k_NumOfHours; hour++)
                {
                    DayAndHour tempDayAndHour = new DayAndHour(DayOfWeek.Sunday + days, TimeSpan.FromHours(hour));
                    o_DictionaryToAnalysis.Add(tempDayAndHour, k_ZeroLikesYet);
                }
            }

            try
            {

                foreach(Post postToAnalysis in i_AnalysisUser.Posts)
                {
                    if(i_TimeFrame.GetHashCode() < DateTime.Now.Subtract(postToAnalysis.CreatedTime.Value).Days)
                    {
                        break;
                    }


                    if(Tester.Invoke(postToAnalysis.Type))
                    {
                        o_DictionaryToAnalysis[new DayAndHour(
                            postToAnalysis.CreatedTime.Value.DayOfWeek,
                            TimeSpan.FromHours(postToAnalysis.CreatedTime.Value.Hour))] += postToAnalysis.LikedBy.Count;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("Could not get posts", e);
            }

            return o_DictionaryToAnalysis;
        }

        public static SortedValueDictionary<object, int> CreateBiggestFanAnalysisDictionary(
            User i_AnalysisUser,
            eTimeSelector i_TimeFrame,
            Post.eType? i_PostType)
        {
            SortedValueDictionary<object, int> o_DictionaryToAnalysis =
                new SortedValueDictionary<object, int>(new Dictionary<object, int>());
            try
            {
                foreach(Post postToAnalysis in i_AnalysisUser.Posts)
                {
                    if(i_TimeFrame.GetHashCode() < DateTime.Now.Subtract(postToAnalysis.CreatedTime.Value).Days)
                    {
                        break;
                    }

                    if(i_PostType != null && i_PostType != postToAnalysis.Type)
                    {
                        continue;
                    }

                    const int k_LikeByUser = 1;

                    foreach(User likedBy in postToAnalysis.LikedBy)
                    {
                        if(o_DictionaryToAnalysis.ContainsKey(likedBy))
                        {
                            o_DictionaryToAnalysis[likedBy] += k_LikeByUser;
                        }
                        else
                        {
                            o_DictionaryToAnalysis.Add(likedBy, k_LikeByUser);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("Could not get posts", e);
            }

            return o_DictionaryToAnalysis;
        }
    }
}
