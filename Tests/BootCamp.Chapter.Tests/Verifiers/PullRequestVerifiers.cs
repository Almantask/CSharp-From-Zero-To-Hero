using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.PullRequest;
using FluentAssertions;
using FluentAssertions.Execution;

namespace BootCamp.Chapter.Tests.Verifiers
{
    public static class PullRequestVerifiers
    {
        public static void VerifyCantComplete(this PullRequest pr, PullRequest.State state)
        {
            using (new AssertionScope())
            {
                pr.CurrentState.Should().Be(state);
                pr.CanComplete.Should().Be(false);
                pr.Created.Should().BeAfter(PullRequestTests.TimeBeforeCreation);
                pr.Modified.Should().BeAfter(PullRequestTests.TimeBeforeCreation);
            }
        }

        public static void VerifyCanComplete(this PullRequest pr, PullRequest.State state)
        {
            using (new AssertionScope())
            {
                pr.CurrentState.Should().Be(state);
                pr.CanComplete.Should().Be(true);
                pr.Created.Should().BeAfter(PullRequestTests.TimeBeforeCreation);
                pr.Modified.Should().BeAfter(PullRequestTests.TimeBeforeCreation);
            }
        }

        public static void VerifyTransitionFailed(this PullRequest pr, Action stateChangeAction, PullRequest.State transitionToState)
        {
            stateChangeAction.Should()
                .Throw<InvalidStateTransitionException>()
                .Which.Message.Contains($"from {pr.CurrentState} to {transitionToState}");
        }
    }
}
