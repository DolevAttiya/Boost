using System;
using System.Collections.Generic;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory.AnalysisFactory;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.ViewModels
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

        private void createBiggestFanAnalysis(User i_User, eTimeSelector i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis)
        {
            //BoostEngine.Instance.BiggestFanAnalysis = BoostEngine.Instance.m_AnalysisFactory.CreateAnalysis((Post.eType)i_AnalysisDataBasis, i_User, i_TimeFrame) as BiggestFanAnalysis;
            r_BoostEn.SwitchAnalysisFactory();
            BiggestFanAnalysis = (BiggestFanAnalysis)r_BoostEn.m_AnalysisFactory.CreateAnalysis(
                i_AnalysisDataBasis,
                r_BoostEn.LoggedInUser,
                i_TimeFrame);
            selectAnalysisCollection(i_AnalysisDataBasis);
        }

        private void selectAnalysisCollection( eAnalysisDataBasis i_AnalysisDataBasis)
        {
            //AnalysisCollection = r_BoostEn.BiggestFanAnalysis.GetSpecificAnalysisCollection(i_AnalysisDataBasis);
            AnalysisCollection = BiggestFanAnalysis.GetSpecificAnalysisCollection(i_AnalysisDataBasis);
        }

        public void CalculateBiggestFans(eTimeSelector i_TimeSelector, eAnalysisDataBasis i_AnalysisDataBasis, ref eTimeSelector io_LastUsedTimeSelector, ref eAnalysisDataBasis io_LastUsedDataBasis)
        {
            int numOfIterations;

            for(int i = 0; i < BoostEngine.k_NumOfBiggestFans; i++)
            {
                BiggestFan biggestFan = new BiggestFan();
                BiggestFanLeaderboard.Add(biggestFan);
            }

            if (i_TimeSelector == io_LastUsedTimeSelector && m_FirstCalc == false)
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

                createBiggestFanAnalysis(r_BoostEn.LoggedInUser, i_TimeSelector, i_AnalysisDataBasis);
                io_LastUsedTimeSelector = i_TimeSelector;
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