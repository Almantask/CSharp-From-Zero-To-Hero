using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.PullRequest
{
    public class InvalidStateTransitionException : Exception
    {
        public InvalidStateTransitionException(PullRequest.State from, PullRequest.State to) : base(
            $"Invalid transition from {from} to {to}.")
        {
        }
    }
}
