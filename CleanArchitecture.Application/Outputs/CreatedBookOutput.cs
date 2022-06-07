using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Outputs
{
    public sealed class CreatedBookOutput : BaseOutput
    {
        public CreatedBookOutput(string message) : base(message)
        {
        }

        public CreatedBookOutput(string message, bool hasError) : base(message, hasError)
        {
        }
    }
}
