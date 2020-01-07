using System.Threading;
using System.Windows.Forms;
using A20_EX02_Idan_203315098_Dolev_205811797.Model;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;

namespace A20_EX02_Idan_203315098_Dolev_205811797.ViewModels
{
    public delegate void BestTimesEventHandler(eTimeFrame i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis);
    
    public delegate void BiggestFansEventHandler(eTimeFrame i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis);

    public class AnalyticsViewModel
    {
        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;

        public BestTimesEventHandler m_BestTimesEvent;

        public BiggestFansEventHandler m_BiggestFansEvent;

        private Thread m_Thread1;
        private Thread m_Thread2;

        public void Analyze(eTimeFrame i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis, Button i_SelectedAnalysisButton)
        {
            if(i_SelectedAnalysisButton.Name.Contains("Time"))
            {
                m_Thread1 = new Thread(new ThreadStart(() => m_BestTimesEvent.Invoke(i_TimeFrame, i_AnalysisDataBasis)));
                m_Thread2 = new Thread(new ThreadStart(() => m_BiggestFansEvent.Invoke(i_TimeFrame, i_AnalysisDataBasis)));
            }
            else
            {
                m_Thread2 = new Thread(new ThreadStart(() => m_BestTimesEvent.Invoke(i_TimeFrame, i_AnalysisDataBasis)));
                m_Thread1 = new Thread(new ThreadStart(() => m_BiggestFansEvent.Invoke(i_TimeFrame, i_AnalysisDataBasis)));
            }

            m_Thread1.Priority = ThreadPriority.Highest;

            m_Thread1.Start();
            m_Thread2.Start();
        }
    }
}
