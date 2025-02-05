namespace Demo3
{
    public class Duration
    {
        int hours, minutes, seconds;
        public Duration(int _hours = 0, int _minutes = 0, int _seconds = 0)
        {
            SetHours(_hours);
            SetMinutes(_minutes);
            SetSeconds(_seconds);
        }
        public Duration(int _seconds)
        {
            SetSeconds(_seconds);
        }
        public void SetHours(int _hours)
        {
            hours = _hours;
        }
        public int GetHours() { return hours; }

        public void SetMinutes(int _minutes) 
        {
            if (_minutes > 59)
                ConvertMinutesToHours(_minutes);
            else
                minutes += _minutes;
        }
        public int GetMinutes() { return minutes; }
        public void SetSeconds(int _seconds)
        {
            if (_seconds > 59)
                ConvertSecondsToMinutes(_seconds);
            else
                seconds += _seconds;
        }
        public int GetSeconds() {  return seconds; }
        private void ConvertMinutesToHours(int _minutes)
        {
            hours += _minutes / 60;
            minutes += _minutes % 60;
        }

        private void ConvertSecondsToMinutes(int _second)
        {
            SetMinutes(_second / 60); 
            seconds += _second % 60;
        }

        private int  ConvertDurationToSeconds()
        {
            return (hours * 60 * 60) + (minutes * 60) + seconds;
        }

        public override bool Equals(object? obj)
        {
            Duration d = obj as Duration;
            if (d is null || d.GetType() != this.GetType())
                return false;
            else
            {
                int d1InSeconds = ConvertDurationToSeconds();
                int d2InSeconds = d.ConvertDurationToSeconds();
                
                return d1InSeconds == d2InSeconds;
            }
        }

        public static bool operator == (Duration d1, Duration d2)
        {
            int d1InSeconds = d1.ConvertDurationToSeconds();
            int d2InSeconds = d2.ConvertDurationToSeconds();

            return d1InSeconds == d2InSeconds;
        }

        public static bool operator !=(Duration d1, Duration d2)
        {
            
            return !(d1 == d2);
        }
        public static Duration operator+(Duration d1 , Duration d2)
        {
            Duration result = new Duration();
            result.SetHours(d1.hours + d2.hours);
            result.SetMinutes(d1.minutes + d2.minutes);
            result.SetSeconds(d1.seconds + d2.seconds);
            return result;
        }

        public static Duration operator+(Duration d, int _minutes)
        {
            return new Duration(d.hours, d.minutes + _minutes, d.seconds);
        }

        public static Duration operator +(int _minutes, Duration d)
        {
            return d + _minutes;
        }

        public static Duration operator++(Duration d)
        {
            return new Duration(d.hours, ++d.minutes, d.seconds);
        }

        public static Duration operator --(Duration d)
        {
            Duration result = new Duration();

            if (d.minutes == 0)
            {
               result.SetHours(d.hours - 1);
               result.SetMinutes(59);
            }
            else
            {
                result.SetHours(d.hours);
                result.SetMinutes(d.minutes - 1);
            }
            result.SetSeconds(d.seconds);

            return result;
        }


        public static bool operator>(Duration d1, Duration d2)
        {
            int d1InSeconds = d1.ConvertDurationToSeconds();
            int d2InSeconds = d2.ConvertDurationToSeconds();
            return d1InSeconds > d2InSeconds;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return !(d1 > d2) && !(d1 == d2);
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            if (d1.ConvertDurationToSeconds() < d2.ConvertDurationToSeconds())
            {
                Console.WriteLine("Cannot Subtract Large Durtation From Small Duration!");
                return null;
            }
            else
            {

                Duration result = new Duration();
                
                result.SetHours(d1.hours - d2.hours);
                result.SetMinutes(d1.minutes - d2.minutes);
                result.SetSeconds(d1.seconds - d2.seconds);
                return result;
            }            
        }

        public override string ToString()
        {
            if (hours == 0 && minutes == 0)
                return $"seconds: {seconds}";
            else if (hours == 0)
                return $"Minutes: {minutes}, seconds: {seconds}";
            else
                return $"Hours: {hours}, Minutes: {minutes}, seconds: {seconds}";
        }
    }

}
