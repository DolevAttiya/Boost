using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{ 
    public partial class BiggestFansView : UserControl
    {
        #region Data Members
        private readonly List<Label> r_BiggestFanLeaderboard;
        #endregion

        #region Ctor
        public BiggestFansView()
        {
            InitializeComponent();
            r_BiggestFanLeaderboard = new List<Label>(BoostEngine.k_NumOfBiggestFans) { BiggestFanGoldLable, BiggestFanSilverLable, BiggestFanBronzeLable };
        }
        #endregion

        #region Methods
        public void DisplayBiggestFans(eTimeSelector i_TimeSelector= eTimeSelector.Month)
        {
            int numberOfIterations = 0;

            foreach (Label varAnalysisHolder in r_BiggestFanLeaderboard)
            {
                varAnalysisHolder.Text = $@"{numberOfIterations++} | Likes: {numberOfIterations++}";
            }

            BoostEngine.Instance.BiggestFanAnalysis.CreateAnalysisByTimeFrame(
                BoostEngine.Instance.LoggedInUser,
                i_TimeSelector);
            KeyValuePair<object, int>[] sortedCombinedValues =  BoostEngine.Instance.BiggestFanAnalysis.CombinedAnalysisHolders.SortByValue();
            numberOfIterations = 0;
            foreach(Label varAnalysisHolder in r_BiggestFanLeaderboard)
            {
                if (numberOfIterations > r_BiggestFanLeaderboard.Count || BoostEngine.Instance.BiggestFanAnalysis.CombinedAnalysisHolders.Count - 1 < numberOfIterations)
                {
                    break;
                }

                User userToGet = sortedCombinedValues[numberOfIterations].Key as User;
                int value = sortedCombinedValues[numberOfIterations].Value;
                try
                {
                    varAnalysisHolder.Text = $@"{userToGet.FirstName} | Likes: {value}";
                }
                catch
                {
                    varAnalysisHolder.Text = $@"Unable to get friend name | Likes: {value}";
                }  
            }

            numberOfIterations = 0;
            //// In case Facebook permissions do no allow access to friend's name
            foreach (Label varAnalysisHolder in r_BiggestFanLeaderboard)
            {
                if(char.IsDigit(varAnalysisHolder.Text[0]))
                {
                    varAnalysisHolder.Text = $@"Friend #{numberOfIterations++} | Likes: N/A";
                }
            }
        }
        #endregion
    }
}
