using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public interface IDataRetriever
    {
        string GetData();
        void Send();
    }

    public class DataRetriever : IDataRetriever
    {
        public string GetData() { return "so much data!"; }

        public void Send() { }
    }

    public class DataRetrieverProxy : IDataRetriever
    {
        private readonly DataRetriever _retriever;

        public string Credentials { get; set; }

        private bool IsValidated => Credentials == "abc123"; // mimic DB lookup

        public DataRetrieverProxy()
        {
            _retriever = new DataRetriever();
        }
        public string GetData()
        {
            return IsValidated ? _retriever.GetData() : string.Empty;
        }

        public void Send()
        {
            if (IsValidated)
            {
                _retriever.Send();
            }
        }
    }
}
