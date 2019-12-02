using System;
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
        private readonly List<Label> r_BiggestFriendsScore;
        public BiggestFans()
        {
            InitializeComponent();
            r_BiggestFriendsScore = new List<Label>(BoostEngine.k_NumOfBiggestFans) { BiggestFriendGoldLable, BiggestFriendSilverLable, BiggestFriendBronzeLable };
        }

        public void DrawBiggestFans(BiggestFanAnalysis i_BiggestFanAnalysis)
        {

            int numberOfIterations = 0;

            foreach (Label varAnalysisHolder in r_BiggestFriendsScore)
            {
               
                varAnalysisHolder.Text = $@"{numberOfIterations++} | Likes: {numberOfIterations++}";
            }

            KeyValuePair<object,int>[] sortedCombinedValues = BoostEngine.SortedSelectedDictionary(i_BiggestFanAnalysis.CombinedAnalysisHolders);
            numberOfIterations = 0;
            foreach(Label varAnalysisHolder in r_BiggestFriendsScore)
            {
                if(numberOfIterations > r_BiggestFriendsScore.Count || i_BiggestFanAnalysis.CombinedAnalysisHolders.Count-1 < numberOfIterations)
                {
                    break;
                }

                User userToGet = sortedCombinedValues[numberOfIterations].Key as User;
                int value = sortedCombinedValues[numberOfIterations].Value;
                try
                {
                    varAnalysisHolder.Text = $@"{userToGet.FirstName} | Likes: {value}";
                }
                catch//TODO
                {
                    // Couldn't get Friend Name
                }
                   
            }
        }
    }
}
