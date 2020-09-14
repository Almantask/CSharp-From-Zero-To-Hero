using System;
using System.Collections.Generic;
using BootCamp.Chapter.Examples.PullRequest;
using BootCamp.Chapter.Tests.Verifiers;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PullRequestTests
    {
        public static DateTime TimeBeforeCreation { get; } = DateTime.Now;

        public PullRequestTests()
        {
            var _ = TimeBeforeCreation;
        }

        [Theory]
        [MemberData(nameof(SetInvalidName_Expectations))]
        public void SetName_Given_InvalidName_Throws_ArgumentException(string name)
        {
            var pr = Open;

            Action action = () => pr.Name = name;

            using (new AssertionScope())
            {
                action.Should()
                    .Throw<ArgumentException>()
                    .Which.Message.Contains("Name");
            }
        }

        [Fact]
        public void SetName_Given_NonEmptyName_SetsName_SetsModified_ToNow()
        {
            var pr = Open;
            var timeBeforeChangingName = DateTime.Now;
            const string newName = "Changed name";

            pr.Name = newName;

            using (new AssertionScope())
            {
                pr.Name.Should().Be(newName);
                pr.Modified.Should().BeAfter(timeBeforeChangingName);
            }
        }

        [Fact]
        public void SetDescription_SetsDescription_SetsModified_ToNow()
        {
            var pr = Open;
            var timeBeforeChangingDescription = DateTime.Now;
            const string newDescription = "Changed description";

            pr.Description = newDescription;

            using (new AssertionScope())
            {
                pr.Description.Should().Be(newDescription);
                pr.Modified.Should().BeAfter(timeBeforeChangingDescription);
            }
        }

        [Theory]
        [MemberData(nameof(NewValidPullRequestExpectations))]
        public void Draft_CreatesPR_In_Draft_State(string name, string description)
        {
            var pr = PullRequest.Draft(name, description);

            pr.VerifyCantComplete(PullRequest.State.Draft);
        }

        [Theory]
        [MemberData(nameof(NewValidPullRequestExpectations))]
        public void Open_CreatesPR_In_Open_State(string name, string description)
        {
            var pr = PullRequest.Open(name, description);

            pr.VerifyCantComplete(PullRequest.State.Open);
        }

        [Theory]
        [MemberData(nameof(CanBeDrafted))]
        public void Unpublish_When_CanBeUnpublished_Sets_State_Draft_And_CanComplete_False(PullRequest pr)
        {
            pr.UnPublish();

            pr.VerifyCantComplete(PullRequest.State.Draft);
        }

        [Theory]
        [MemberData(nameof(CannotBeDrafted))]
        public void Unpublish_When_CannotBeDraft_Throws_InvalidStateTransitionException(PullRequest pr)
        {
            pr.VerifyTransitionFailed(pr.UnPublish, PullRequest.State.Draft);
        }

        [Theory]
        [MemberData(nameof(CanBeOpened))]
        public void Publish_When_CanBeOpened_Sets_State_Open_And_CanComplete_False(PullRequest pr)
        {
            pr.Publish();

            pr.VerifyCantComplete(PullRequest.State.Open);
        }

        [Theory]
        [MemberData(nameof(CannotBeOpened))]
        public void Publish_When_CannotBeOpened_Throws_InvalidStateTransitionException(PullRequest pr)
        {
            pr.VerifyTransitionFailed(pr.Publish, PullRequest.State.Open);
        }

        [Theory]
        [MemberData(nameof(CanBeChangesRequested))]
        public void RequestChanges_When_CanBeChangesRequested_Sets_State_ChangesRequested_And_CanComplete_False(PullRequest pr)
        {
            pr.RequestChanges();

            pr.VerifyCantComplete(PullRequest.State.ChangesRequested);
        }

        [Theory]
        [MemberData(nameof(CannotBeChangesRequested))]
        public void RequestChanges_When_CannotBeChangesRequested_Throws_InvalidStateTransitionException(PullRequest pr)
        {
            pr.VerifyTransitionFailed(pr.RequestChanges, PullRequest.State.ChangesRequested);
        }

        [Theory]
        [MemberData(nameof(CanBeAbandoned))]
        public void Abandon_When_CanBeAbandoned_Sets_State_Abandoned_And_CanComplete_False(PullRequest pr)
        {
            pr.Abandon();

            pr.VerifyCantComplete(PullRequest.State.Abandoned);
        }

        [Theory]
        [MemberData(nameof(CannotBeAbandoned))]
        public void Abandon_When_CannotBeAbandoned_Throws_InvalidStateTransitionException(PullRequest pr)
        {
            pr.VerifyTransitionFailed(pr.Abandon, PullRequest.State.Abandoned);
        }

        [Theory]
        [MemberData(nameof(CanBeReviewed))]
        public void PassPolicy_When_CanBeReadyForComplete_Sets_State_ReadyToComplete_And_CanComplete_True(PullRequest pr)
        {
            pr.PassPolicy();

            pr.VerifyCanComplete(PullRequest.State.ReadyToComplete);
        }

        [Theory]
        [MemberData(nameof(CannotBeReviewed))]
        public void PassPolicy_When_CannotBeReviewed_Throws_InvalidStateTransitionException(PullRequest pr)
        {
            pr.VerifyTransitionFailed(pr.PassPolicy, PullRequest.State.ReadyToComplete);
        }

        [Theory]
        [MemberData(nameof(CanBeCompleted))]
        public void Complete_When_CanBeCompleted_Sets_State_Completed_And_CanComplete_False(PullRequest pr)
        {
            pr.Complete();

            pr.VerifyCantComplete(PullRequest.State.Completed);
        }


        [Theory]
        [MemberData(nameof(CannotBeCompleted))]
        public void Complete_When_CannotBeCompleted_Throws_InvalidStateTransitionException(PullRequest pr)
        {
            pr.VerifyTransitionFailed(pr.Complete, PullRequest.State.Completed);
        }

        public static IEnumerable<object[]> CanBeOpened
        {
            get
            {
                yield return new object[] { Draft };
                yield return new object[] { Abandoned };
                yield return new object[] { Completed };
            }
        }

        public static IEnumerable<object[]> CannotBeOpened
        {
            get
            {
                yield return new object[] {Open};
                yield return new object[] { ChangesRequested };
                yield return new object[] { ReadyToComplete };
                yield return new object[] { Completed };
            }
        }

        public static IEnumerable<object[]> CanBeDrafted
        {
            get
            {
                yield return new object[] { Open };
                yield return new object[] { ChangesRequested };
                yield return new object[] { ReadyToComplete };
            }
        }

        public static IEnumerable<object[]> CannotBeDrafted
        {
            get
            {
                yield return new object[] { Draft };
                yield return new object[] { Completed };
                yield return new object[] { Abandoned };
            }
        }

        public static IEnumerable<object[]> CannotBeChangesRequested
        {
            get
            {
                yield return new object[] { Abandoned };
                yield return new object[] { ChangesRequested };
                yield return new object[] { ReadyToComplete };
                yield return new object[] { Completed };
                yield return new object[] { Draft };
            }
        }

        public static IEnumerable<object[]> CanBeChangesRequested
        {
            get
            {
                yield return new object[] { Open };
            }
        }

        public static IEnumerable<object[]> CanBeAbandoned
        {
            get
            {
                yield return new object[] { Open };
                yield return new object[] { ChangesRequested };
                yield return new object[] { ReadyToComplete };
                yield return new object[] { Draft };
            }
        }

        public static IEnumerable<object[]> CannotBeAbandoned
        {
            get
            {
                yield return new object[] { Abandoned };
                yield return new object[] { Completed };
            }
        }

        public static IEnumerable<object[]> CanBeCompleted
        {
            get
            {
                yield return new object[] { ReadyToComplete };
            }
        }

        public static IEnumerable<object[]> CannotBeCompleted
        {
            get
            {
                yield return new object[] { Open };
                yield return new object[] { Abandoned };
                yield return new object[] { ChangesRequested };
                yield return new object[] { Completed };
                yield return new object[] { Draft };
            }
        }

        public static IEnumerable<object[]> CanBeReviewed
        {
            get
            {
                yield return new object[] { Open };
            }
        }

        public static IEnumerable<object[]> CannotBeReviewed
        {
            get
            {
                yield return new object[] { Abandoned };
                yield return new object[] { ChangesRequested };
                yield return new object[] { ReadyToComplete };
                yield return new object[] { Completed };
                yield return new object[] { Draft };
            }
        }

        public static IEnumerable<object[]> NewValidPullRequestExpectations
        {
            get
            {
                yield return New_NoDescription_Ok();
                yield return New_NullDescription_Ok();
            }
        }

        public static IEnumerable<object[]> SetInvalidName_Expectations
        {
            get
            {
                yield return Empty_Throws_ArgumentException;
                yield return Null_Throws_ArgumentException;
                yield return EmptySpaced_Throws_ArgumentException;
            }
        }

        private static object[] New_NoDescription_Ok() => new object[]{"name", ""};
        private static object[] New_NullDescription_Ok() => new object[] { "name", null };

        private static object[] Empty_Throws_ArgumentException => new object[] {""};
        private static object[] Null_Throws_ArgumentException => new object[] {null};
        private static object[] EmptySpaced_Throws_ArgumentException => new object[] {" "};

        private static PullRequest Open => PullRequest.Open("asd");
        private static PullRequest Draft => PullRequest.Draft("asd");
        private static PullRequest Abandoned
        {
            get
            {
                var pr = Open;
                pr.Abandon();
                return pr;
            }
        }

        private static PullRequest ChangesRequested
        {
            get
            {
                var pr = Open;
                pr.RequestChanges();
                return pr;
            }
        }

        private static PullRequest ReadyToComplete
        {
            get
            {
                var pr = Open;
                pr.PassPolicy();
                return pr;
            }
        }

        private static PullRequest Completed
        {
            get
            {
                var pr = Open;
                pr.PassPolicy();
                pr.Complete();
                return pr;
            }
        }
    }
}