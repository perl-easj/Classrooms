using System;
using System.Threading.Tasks;

namespace ClassRoomD
{
    /// <summary>
    /// This class generates a Pulse event at regular intervals.
    /// </summary>
    public class PulseGenerator
    {
        /// <summary>
        /// Subscribe to this event to be notified whenever
        /// a new Pulse event is invoked.
        /// </summary>
        public event Action Pulse;

        /// <summary>
        /// Subscribe to this event to be notified whenever
        /// a new PulseWithCount event is invoked.
        /// </summary>
        public event Action<int> PulseWithCount;

        public PulseGenerator()
        {
            Pulse = null;
            PulseWithCount = null;
        }

        /// <summary>
        /// Start a "session" of event invocations.
        /// </summary>
        /// <param name="intervalInMilliSecs">
        /// Interval (in milliseconds) between each event invocation.
        /// </param>
        /// <param name="noOfPulses">
        /// Number of event invocations in this session
        /// </param>
        public async Task Start(int intervalInMilliSecs, int noOfPulses = 1000)
        {
            while (noOfPulses > 0)
            {
                await Task.Delay(intervalInMilliSecs);

                Pulse?.Invoke();
                PulseWithCount?.Invoke(noOfPulses);

                noOfPulses--;
            }
        }
    }
}