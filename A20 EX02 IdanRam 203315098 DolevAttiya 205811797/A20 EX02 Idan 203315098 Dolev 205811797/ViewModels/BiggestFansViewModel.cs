using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.ViewModels
{
    public class BiggestFansViewModel
    {
        public BiggestFanAnalysis BiggestFanAnalysis { get; set; }

        public SortedValueDictionary<object, int> AnalysisCollection { get; set; }

        public List<BiggestFan> BiggestFanLeaderboard { get; set; }

        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;

        public BiggestFansViewModel()
        {
            BiggestFanAnalysis = new BiggestFanAnalysis();
            BiggestFanLeaderboard = new List<BiggestFan>();
        }

        private void createBiggestFanAnalysis(User i_User, eTimeSelector i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis)
        {
            BiggestFanAnalysis.CreateAnalysisByTimeFrame(i_User, i_TimeFrame);
            selectAnalysisCollection(this.BiggestFanAnalysis, i_AnalysisDataBasis);
        }

        private void selectAnalysisCollection(BiggestFanAnalysis i_BiggestFanAnalysis, eAnalysisDataBasis i_AnalysisDataBasis)
        {
            AnalysisCollection = i_BiggestFanAnalysis.GetSpecificAnalysisCollection(i_AnalysisDataBasis);
        }

        public void CalculateBiggestFans(eTimeSelector i_TimeSelector, eAnalysisDataBasis i_AnalysisDataBasis, ref eTimeSelector io_LastUsedTimeSelector, ref eAnalysisDataBasis io_LastUsedDataBasis)
        {
            int numOfIterations;

            for(int i = 0; i < BoostEngine.k_NumOfBiggestFans; i++)
            {
                BiggestFan biggestFan = new BiggestFan();
                BiggestFanLeaderboard.Add(biggestFan);
            }

            if (i_TimeSelector == io_LastUsedTimeSelector && this.BiggestFanAnalysis != null)
            {
                if (i_AnalysisDataBasis != io_LastUsedDataBasis)
                {
                    selectAnalysisCollection(this.BiggestFanAnalysis, i_AnalysisDataBasis);
                    io_LastUsedDataBasis = i_AnalysisDataBasis;
                }
                else
                {
                    return;
                }
            }
            else
            {
                createBiggestFanAnalysis(BoostEngine.Instance.LoggedInUser, i_TimeSelector, i_AnalysisDataBasis);
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