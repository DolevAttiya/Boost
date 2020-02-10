using System;
using System.Threading;
using System.Windows.Forms;
using Boost.Model;
using Boost.Model.DataClasses;

namespace Boost.ViewModels
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

            //// Observer Pattern - Callback method to notify subscribers when main analysis thread is finished
            threadStart1 += () =>
            {
                try
                {
                    m_AnalysisFinishedEvent.Invoke();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            };

            m_Thread1 = new Thread(threadStart1);
            m_Thread2 = new Thread(threadStart2);

            m_Thread1.Priority = ThreadPriority.Highest;

            m_Thread1.Start();
            m_Thread2.Start();
        }
    }
}
