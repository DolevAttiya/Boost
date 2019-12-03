﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine;
using A20_EX01_Idan_203315098_Dolev_205811797.Engine.DataClasses;
using FacebookWrapper.ObjectModel;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{ 
    public partial class BiggestFans : UserControl
    {
        #region Data Members
        private readonly List<Label> r_BiggestFanLeaderboard;
        #endregion

        #region Ctor
        public BiggestFans()
        {
            InitializeComponent();
            r_BiggestFanLeaderboard = new List<Label>(BoostEngine.k_NumOfBiggestFans) { BiggestFanGoldLable, BiggestFanSilverLable, BiggestFanBronzeLable };
        }
        #endregion

        #region Methods
        public void DisplayBiggestFans(BiggestFanAnalysis i_BiggestFanAnalysis)
        {
            int numberOfIterations = 0;

            foreach (Label varAnalysisHolder in r_BiggestFanLeaderboard)
            {
                varAnalysisHolder.Text = $@"{numberOfIterations++} | Likes: {numberOfIterations++}";
            }

            KeyValuePair<object, int>[] sortedCombinedValues = BoostEngine.SortedSelectedDictionary(i_BiggestFanAnalysis.CombinedAnalysisHolders);
            numberOfIterations = 0;
            foreach(Label varAnalysisHolder in r_BiggestFanLeaderboard)
            {
                if (numberOfIterations > r_BiggestFanLeaderboard.Count || i_BiggestFanAnalysis.CombinedAnalysisHolders.Count - 1 < numberOfIterations)
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
            foreach (Label varAnalysisHolder in r_BiggestFanLeaderboard) // In case Facebook permissions do no allow access to friend's name
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
