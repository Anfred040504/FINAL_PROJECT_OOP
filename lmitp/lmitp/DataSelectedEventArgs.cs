using System;

namespace lmitp
{
    public class DataSelectedEventArgs : EventArgs
    {
        public string[] Data { get; }

        public DataSelectedEventArgs(string[] data)
        {
            Data = data;
        }
    }
}
