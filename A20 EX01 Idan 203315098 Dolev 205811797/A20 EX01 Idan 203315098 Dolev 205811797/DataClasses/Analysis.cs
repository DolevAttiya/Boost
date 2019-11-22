using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.DataClasses
{

    public abstract class Analysis
    {
        public Analysis()
        {
            int numberDaysOfWeek = 7;
            int numberHoursADay = 24;
            int minutesAndSecond = 0;
            PhotosArrayList = new AnalysisHolder[numberDaysOfWeek, numberHoursADay];
            VideosArrayList = new AnalysisHolder[numberDaysOfWeek, numberHoursADay];
            PostsArrayList = new AnalysisHolder[numberDaysOfWeek, numberHoursADay];
            CombinedAnalysisHolders = new AnalysisHolder[numberDaysOfWeek, numberHoursADay];

            for(int days = 0; days < numberDaysOfWeek; days++)
            {
                for(int hour = 0; hour < numberHoursADay; hour++)
                {

                    PhotosArrayList[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, minutesAndSecond, minutesAndSecond));
                    VideosArrayList[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, minutesAndSecond, minutesAndSecond));
                    PostsArrayList[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, minutesAndSecond, minutesAndSecond));
                    CombinedAnalysisHolders[days, hour] = new AnalysisHolder(
                        new DateTime(2019, 9, days + 1, hour, minutesAndSecond, minutesAndSecond));
                }
            }
        }

        public AnalysisHolder[,] PhotosArrayList { get; }

        public AnalysisHolder[,] VideosArrayList { get; }

        public AnalysisHolder[,] PostsArrayList { get; }

        public AnalysisHolder[,] CombinedAnalysisHolders { get; }

        public void AddLikesSchedule(TimerSelector i_Time)
        {

            /*widrow from DB
             *For Each photos, videos and photos
             * += to attribute by time and place
             * += to combined
             */
        }
    }

    public enum TimerSelector
    {
    Day = 7,
    Month=31,
    Year=365
    }
}
    


