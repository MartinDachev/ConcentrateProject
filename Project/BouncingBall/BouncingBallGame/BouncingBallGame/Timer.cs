using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BouncingBallGame
{
    public class Timer
    {
        private double _elapsedTime;

        public double Interval { get; set; }
        public double ElapsedTime { get { return this._elapsedTime; } set { if (this.IsActive) this._elapsedTime = value; } }
        public double MinIntervalTime { get; set; }
        public double MaxIntervalTime { get; set; }
        public bool IsActive { get; set; }

        public Timer()
        {
            this.Interval = 0;
            this.Reset();
        }

        public void RandomInterval(Random r)
        {
            this.Interval = r.NextDouble() * (this.MaxIntervalTime - this.MinIntervalTime) + this.MinIntervalTime;
        }

        public void Reset()
        {
            this._elapsedTime = 0;
        }

        public void Stop()
        {
            this.IsActive = false;
        }

        public void Start()
        {
            this.IsActive = true;
        }
    }
}
