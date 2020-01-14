using System.Threading;
using System.Windows.Forms;
using A20_EX03_Idan_203315098_Dolev_205811797.Model;
using A20_EX03_Idan_203315098_Dolev_205811797.Model.DataClasses;

namespace A20_EX03_Idan_203315098_Dolev_205811797.ViewModels
{
    public delegate void BestTimesEventHandler(eTimeFrame i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis);
    
    public delegate void BiggestFansEventHandler(eTimeFrame i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis);

    public delegate void AnalysisFinishedEventHandler();

    public class AnalyticsViewModel
    {
        private readonly BoostEngine r_BoostEn = BoostEngine.Instance;

        public BestTimesEventHandler m_BestTimesEvent;

        public BiggestFansEventHandler m_BiggestFansEvent;

        public AnalysisFinishedEventHandler m_AnalysisFinishedEvent;

        private Thread m_Thread1;
        private Thread m_Thread2;

        public void Analyze(eTimeFrame i_TimeFrame, eAnalysisDataBasis i_AnalysisDataBasis, Button i_SelectedAnalysisButton)
        {
            ThreadStart threadStart1;
            ThreadStart threadStart2;

            if(i_SelectedAnalysisButton.Name.Contains("Time"))
            {
                threadStart1 = new ThreadStart(() => m_BestTimesEvent.Invoke(i_TimeFrame, i_AnalysisDataBasis));
                threadStart2 = new ThreadStart(() => m_BiggestFansEvent.Invoke(i_TimeFrame, i_AnalysisDataBasis));
            }
            else
            {
                threadStart2 = new ThreadStart(() => m_BestTimesEvent.Invoke(i_TimeFrame, i_AnalysisDataBasis));
                threadStart1 = new ThreadStart(() => m_BiggestFansEvent.Invoke(i_TimeFrame, i_AnalysisDataBasis));
            }

            // Notify subscribers as callback - Observer Pattern
            threadStart1 += () => { m_AnalysisFinishedEvent.Invoke(); };

            m_Thread1 = new Thread(threadStart1);
            m_Thread2 = new Thread(threadStart2);

            m_Thread1.Priority = ThreadPriority.Highest;

            m_Thread1.Start();
            m_Thread2.Start();
        }
    }
}
