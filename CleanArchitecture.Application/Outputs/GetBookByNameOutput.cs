using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Outputs
{
    public  class GetBookByNameOutput : BaseOutput
    {
        public GetBookByNameOutput()
        {
        }

        public GetBookByNameOutput(string message) : base(message)
        {
        }

        public GetBookByNameOutput(string message, bool hasError) : base(message, hasError)
        {
        }
    }
}
