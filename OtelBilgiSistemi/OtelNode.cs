using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    class OtelNode
    {
        public Otel otel;
        public OtelNode sağ;
        public OtelNode sol;

        public OtelNode()
        {
        }

        public OtelNode(Otel otel)
        {
            this.otel = otel;
            this.sağ = null;
            this.sol = null;
        }
    }
}
