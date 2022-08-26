using System.Collections.Generic;

namespace Acme.Example
{
    public class Session
    {
        public List<string> Names { get; set; }

        public Session()
        {
            this.Names = new List<string>();
        }
    }
}