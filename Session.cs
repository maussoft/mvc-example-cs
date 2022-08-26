using System.Collections.Generic;

namespace Acme.Example
{
    public class Session
    {
        public List<string> Items { get; set; }

        public Session()
        {
            this.Items = new List<string>();
        }
    }
}