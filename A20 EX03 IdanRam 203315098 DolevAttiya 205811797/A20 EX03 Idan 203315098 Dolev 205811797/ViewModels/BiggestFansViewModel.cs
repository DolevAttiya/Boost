using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using A20_EX03_Idan_203315098_Dolev_205811797.Model;
using A20_EX03_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX03_Idan_203315098_Dolev_205811797.Model.DesignPatterns.Decorator;
using A20_EX03_Idan_203315098_Dolev_205811797.Model.DesignPatterns.Factory.AnalysisFactory;

namespace A20_EX03_Idan_203315098_Dolev_205811797.ViewModels
{
    public class BiggestFansViewModel
    {
        public SortedValueDictionary<object, int> AnalysisCollection { get; set; }

        public List<BiggestFan> BiggestFanLeaderboard { get; set; }

        public BiggestFanAnalysis BiggestFanAnalysis { get; set; }

        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;

        private bool m_FirstCalc = true;

        public BiggestFansViewModel()
        {
            BiggestFanLeaderboard = new List<BiggestFan>();
        }

        private void createBiggestFanAnalysis(User i_User, eTimeFrame i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis)
        {
            Type analysisFactoryType = typeof(BiggestFanAnalysisFactory);

            if (r_BoostEn.m_AnalysisFactory.GetType() != analysisFactoryType)
            {
                r_BoostEn.SelectAnalysisFactoryType(analysisFactoryType);
            }

            BiggestFanAnalysis =
                (BiggestFanAnalysis)r_BoostEn.CreateAnalysisUsingFactory(i_TimeFrame, i_AnalysisDataBasis);
            selectAnalysisCollection(i_AnalysisDataBasis);
        }

        private void selectAnalysisCollection(eAnalysisDataBasis i_AnalysisDataBasis)
        {
            AnalysisCollection = BiggestFanAnalysis.GetSpecificAnalysisCollection(i_AnalysisDataBasis);
        }

        public void CalculateBiggestFans(eTimeFrame i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis, ref eTimeFrame i_IoLastUsedTimeFrame, ref eAnalysisDataBasis io_LastUsedDataBasis)
        {
            int numOfIterations;

            for(int i = 0; i < BoostEngine.k_NumOfBiggestFans; i++)
            {
                BiggestFan biggestFan = new BiggestFan();
                BiggestFanLeaderboard.Add(biggestFan);
            }

            if (i_TimeFrame == i_IoLastUsedTimeFrame && m_FirstCalc == false)
            {
                if (i_AnalysisDataBasis != io_LastUsedDataBasis)
                {
                    selectAnalysisCollection(i_AnalysisDataBasis);
                    io_LastUsedDataBasis = i_AnalysisDataBasis;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if(m_FirstCalc)
                {
                    m_FirstCalc = false;
                }

                createBiggestFanAnalysis(r_BoostEn.LoggedInUser, i_TimeFrame, i_AnalysisDataBasis);
                i_IoLastUsedTimeFrame = i_TimeFrame;
                io_LastUsedDataBasis = i_AnalysisDataBasis;
            }

            KeyValuePair<object, int>[] rankedFans = AnalysisCollection.SortByValue();

            numOfIterations = 0;

            foreach (BiggestFan biggestFan in BiggestFanLeaderboard)
            {
                numOfIterations++;

                if(numOfIterations > BiggestFanLeaderboard.Count || AnalysisCollection.Count - 1 < numOfIterations)
                {
                    break;
                }

                User userToGet = rankedFans[numOfIterations].Key as User;
                int value = rankedFans[numOfIterations].Value;

                try
                {
                    biggestFan.Name = userToGet.Name;
                }
                catch(Exception)
                {
                    biggestFan.Name = numOfIterations.ToString();
                }

                try
                {
                    biggestFan.Likes = value;
                }
                catch(Exception)
                {
                    biggestFan.Likes = -1;
                }

                biggestFan.Ranking = numOfIterations;
            }
        }
    }
}