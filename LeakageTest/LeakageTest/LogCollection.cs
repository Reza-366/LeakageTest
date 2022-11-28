using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LeakageTest
{
   public class LogCollection
    {
        public event Action LogChanged;
        List<StringBuilder> sb = new List<StringBuilder>();
        int _lines = 100;


        private static LogCollection instance = null;
        public static LogCollection GetInstance {
            get {
                if (instance == null)
                    instance = new LogCollection();
                return instance;
            }
        }

        private LogCollection()
        {

        }

        public void AddLog(string line)
        {
            sb.Add(new StringBuilder(line));
            if (sb.Count > _lines)
                sb.RemoveRange(0, sb.Count - _lines);
            OnLogChanged();
        }

        public  string ToString(int linesCount)
        {
            StringBuilder ret = new StringBuilder();
            foreach (var item in sb)
            {
                ret.AppendLine(item.ToString());
            }
            return ret.ToString();
        }

        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            foreach (var item in sb)
            {
                ret.AppendLine(item.ToString());
            }
            return ret.ToString();
        }

        public void Clear()
        {
            sb.Clear();
            OnLogChanged();
        }

        protected void OnLogChanged()
        {
            if (LogChanged != null)
                try
                {
                    LogChanged();
                }
                catch { }
        }

    }
}
