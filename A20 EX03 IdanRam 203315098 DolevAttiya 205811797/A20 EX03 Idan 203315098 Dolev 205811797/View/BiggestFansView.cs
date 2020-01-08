using System;
using System.Collections.Generic;
using System.Windows.Forms;
using A20_EX03_Idan_203315098_Dolev_205811797.Model;
using A20_EX03_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX03_Idan_203315098_Dolev_205811797.ViewModels;

namespace A20_EX03_Idan_203315098_Dolev_205811797.View
{ 
    public partial class BiggestFansView : UserControl
    {
        #region Data Members
        private readonly List<Label> r_BiggestFanLeaderboardLabels;

        private eTimeFrame m_LastUsedTimeFrame = BoostEngine.Instance.m_BoostSettings.DefaultAnalysisTimeFrame;
        private eAnalysisDataBasis m_LastUsedDataBasis = BoostEngine.Instance.m_BoostSettings.DefaultAnalysisDataBasis;

        private BiggestFansViewModel m_BiggestFansViewModel = new BiggestFansViewModel();
        #endregion

        #region Ctor
        public BiggestFansView()
        {
            InitializeComponent();
            r_BiggestFanLeaderboardLabels = new List<Label>(BoostEngine.k_NumOfBiggestFans) { BiggestFanLabelGold, BiggestFanLabelSilver, BiggestFanLabelBronze };
        }
        #endregion

        #region Methods

        public void DisplayBiggestFans(
            eTimeFrame i_TimeFrame = eTimeFrame.Month,
            eAnalysisDataBasis i_AnalysisDataBasis = eAnalysisDataBasis.Combined)
        {
            m_BiggestFansViewModel.CalculateBiggestFans(
                i_TimeFrame,
                i_AnalysisDataBasis,
                ref m_LastUsedTimeFrame,
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

                Invoke(new Action(() => r_BiggestFanLeaderboardLabels[i].Text = $@"{name} | Likes: {likesString}"));
            }
        }
        #endregion
    }
}
