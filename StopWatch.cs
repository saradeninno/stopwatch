using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
   public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;

        private bool _running; //di default è inizializzato come falso;

        public void Start()
        {
            if (_running)
            { throw new InvalidOperationException("It's already running"); }
            
            _startTime = DateTime.Now;
            _running = true;
       
        }

        public void Stop()
        {
            if (!_running)
            { throw new InvalidOperationException("It's not running"); }
           
            _stopTime = DateTime.Now;
            _running = false;

        }

        public TimeSpan GetTimeSpan()
        {
            return _stopTime - _startTime;

        }

    }
}
    

