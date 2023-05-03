using System;
using Google.Protobuf.WellKnownTypes;

namespace BlazorGrpc2// Note that the namespace must match the generated type
{
    public partial class CheckInCode
    {
        // Properties for the underlying data are generated from the .proto file
        // This partial class just adds some extra convenience properties

        private string m_code;
        public string Code
        {
            get => m_code;
            set { m_code = value; }
        }

    }
}
