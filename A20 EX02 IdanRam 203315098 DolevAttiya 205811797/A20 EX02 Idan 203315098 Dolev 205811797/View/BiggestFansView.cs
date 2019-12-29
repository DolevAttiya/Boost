using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns;
using A20_EX02_Idan_203315098_Dolev_205811797.ViewModels;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{ 
    public partial class BiggestFansView : UserControl
    {
        #region Data Members
        private readonly List<Label> r_BiggestFanLeaderboardLabels;

        private eTimeSelector m_LastUsedTimeSelector = BoostEngine.Instance.m_BoostSettings.DefaultAnalysisTimeFrame;
        private eAnalysisDataBasis m_LastUsedDataBasis = BoostEngine.Instance.m_BoostSettings.DefaultAnalysisDataBasis;

        private BiggestFansViewModel m_BiggestFansViewModel = new BiggestFansViewModel();
        #endregion

        #region Ctor
        public BiggestFansView()
        {
            InitializeComponent();
            r_BiggestFanLeaderboardLabels = new List<Label>(BoostEngine.k_NumOfBiggestFans) { BiggestFanGoldLable, BiggestFanSilverLable, BiggestFanBronzeLable };
        }
        #endregion

        #region Methods
        public void DisplayBiggestFans_Legacy(eTimeSelector i_TimeSelector = eTimeSelector.Month, eAnalysisDataBasis i_AnalysisDataBasis = eAnalysisDataBasis.Combined)
        {
            int numberOfIterations = 0;

            foreach (Label biggestFanLabel in r_BiggestFanLeaderboardLabels)
            {
                biggestFanLabel.Text = $@"{numberOfIterations++} | Likes: {numberOfIterations++}";
            }

            BoostEngine.Instance.BiggestFanAnalysis.CreateAnalysisByTimeFrame(
                BoostEngine.Instance.LoggedInUser,
                i_TimeSelector);

            SortedValueDictionary<object, int> analysisCollection =
                BoostEngine.Instance.BiggestFanAnalysis.GetSpecificAnalysisCollection(i_AnalysisDataBasis);

            KeyValuePair<object, int>[] sortedValues =
                analysisCollection.SortByValue();
            numberOfIterations = 0;
            foreach(Label biggestFanLabel in r_BiggestFanLeaderboardLabels)
            {
                if (numberOfIterations > r_BiggestFanLeaderboardLabels.Count || analysisCollection.Count - 1 < numberOfIterations)
                {
                    break;
                }

                User userToGet = sortedValues[numberOfIterations].Key as User;
                int value = sortedValues[numberOfIterations].Value;
                try
                {
                    biggestFanLabel.Text = $@"{userToGet.FirstName} | Likes: {value}";
                }
                catch
                {
                    biggestFanLabel.Text = $@"Unable to get friend name | Likes: {value}";
                }  
            }

            numberOfIterations = 0;
            //// In case Facebook permissions do no allow access to friend's name
            foreach (Label biggestFanLabel in r_BiggestFanLeaderboardLabels)
            {
                if(char.IsDigit(biggestFanLabel.Text[0]))
                {
                    biggestFanLabel.Text = $@"Friend #{numberOfIterations++} | Likes: N/A";
                }
            }
        }

        public void DisplayBiggestFans(
            eTimeSelector i_TimeSelector = eTimeSelector.Month,
            eAnalysisDataBasis i_AnalysisDataBasis = eAnalysisDataBasis.Combined)
        {
            m_BiggestFansViewModel.CalculateBiggestFans(
                i_TimeSelector,
                i_AnalysisDataBasis,
                ref m_LastUsedTimeSelector,
                ref m_LastUsedDataBasis);

            for(int i = 0; i < r_BiggestFanLeaderboardLabels.Count; i++)
            {
                string name = m_BiggestFansViewModel.BiggestFanLeaderboard[i].Name;
                int likes = m_BiggestFansViewModel.BiggestFanLeaderboard[i].Likes;
                string likesString = likes.ToString();
                int ranking = m_BiggestFansViewModel.BiggestFanLeaderboard[i].Ranking;

                if (char.IsDigit(name[0]))
                {
                    name = $@"Friend #{ranking}";
                }

                if(likes == -1)
                {
                    likesString = "N/A";
                }

                r_BiggestFanLeaderboardLabels[i].Text = $@"{name} | Likes: {likesString}";
            }
        }
        #endregion
    }
}
