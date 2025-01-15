using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors
        // Constructor to initialize the Duration
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        // Constructor that takes total seconds and converts to hours, minutes, and seconds
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        // Constructor that takes total seconds and converts to minutes and seconds
        public Duration(double totalSeconds)
        {
            Minutes = (int)(totalSeconds / 60);
            Seconds = (int)(totalSeconds % 60);
        }
        #endregion

        #region Method Overriding
        // Overriding ToString() to represent the Duration object as a string
        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
        }

        // Overriding Equals() to compare two Duration objects
        public override bool Equals(object obj)
        {
            if (obj is Duration duration)
            {
                return this.Hours == duration.Hours && this.Minutes == duration.Minutes
                       && this.Seconds == duration.Seconds;
            }
            return false;
        }

        // Overriding GetHashCode() to return a unique hash code for the Duration object
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        #endregion

        #region Method
        // Method to display the duration in HH:MM:SS format
        public void DisplayDuration()
        {
            Console.WriteLine(ToString());
        }
        #endregion

        #region Operator Overloading
        // Operator Overload: Addition of two Duration objects
        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) +
                               (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
            return new Duration(totalSeconds);
        }
        // Operator Overload: Addition of Duration and total seconds
        public static Duration operator +(Duration d1, int totalSeconds)
        {
            int newTotalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + totalSeconds;
            return new Duration(newTotalSeconds);
        }
        // Operator Overload: Addition of total seconds and Duration
        public static Duration operator +(int totalSeconds, Duration d1)
        {
            return d1 + totalSeconds;  // Reuses the above operator
        }
        // Operator Overload: Pre-increment (Increase one minute)
        public static Duration operator ++(Duration d)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) + 60; // Add 60 seconds
            return new Duration(totalSeconds);
        }
        // Operator Overload: Pre-decrement (Decrease one minute)
        public static Duration operator --(Duration d)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) - 60; // Subtract 60 seconds
            return new Duration(totalSeconds);
        }

        // Operator Overload: Subtraction of two Duration objects (difference in seconds)
        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            int sub = totalSeconds1 - totalSeconds2;
            return new Duration(sub);
        }
        // Operator Overload: Greater than comparison (D1 > D2)
        public static bool operator >(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 > totalSeconds2;
        }
        // Operator Overload: :Less than comparison (D1 < D2)
        public static bool operator <(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 < totalSeconds2;
        }

        // Operator Overload: Less than or equal comparison (D1 <= D2)
        public static bool operator <=(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 <= totalSeconds2;
        }
        // Operator Overload: Greater than or equal comparison (D1 >= D2)
        public static bool operator >=(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 >= totalSeconds2;
        }
        // Operator Overload: Implicit conversion of Duration to DateTime
        public static explicit operator DateTime(Duration d)
        {
            DateTime baseTime = new DateTime(1, 1, 1); // Start from a base date (1st Jan 0001)
            return baseTime.AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }

        // Check if the Duration is non-zero
        public static implicit operator bool(Duration d)
        {
            return (d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0);
        }
        #endregion
    }
}
