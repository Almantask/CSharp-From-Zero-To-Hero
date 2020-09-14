using System;

namespace BootCamp.Chapter.Examples.PullRequest
{
    public class PullRequest
    {
        public enum State
        {
            Draft,
            Open,
            ChangesRequested,
            Abandoned,
            ReadyToComplete,
            Completed
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(Name));
                }
                _name = value;
                Modified = DateTime.Now;
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                Modified = DateTime.Now;
            }
        }

        public DateTime Created { get; private set; }
        public DateTime? Completed { get; private set; }
        public DateTime Modified { get; private set; }

        public bool CanComplete { get; private set; }

        private State _currentState;
        public State CurrentState
        {
            get => _currentState;
            private set
            {
                _currentState = value;
                Modified = DateTime.Now;
            }
        }

        private PullRequest(string name, State state, string description = "")
        {
            Name = name;
            Description = description;
            CurrentState = state;
            CanComplete = false;
        }

        public void UnPublish() => CurrentState = State.Draft;
        public void Publish() => CurrentState = State.Open;
        public void RequestChanges() => CurrentState = State.ChangesRequested;
        public void Abandon() => CurrentState = State.Abandoned;
        public void PassPolicy()
        {
            CurrentState = State.ReadyToComplete;
            CanComplete = true;
        }

        public void Complete() => CurrentState = State.Completed;
        public void Reopen() => CurrentState = State.Open;
        
        public static PullRequest Draft(string name, string description = "")
        {
            return new PullRequest(name, State.Draft, description)
            {
                Created = DateTime.Now
            };
        }

        public static PullRequest Open(string name, string description = "")
        {
            return new PullRequest(name, State.Open, description)
            {
                Created = DateTime.Now
            };
        }

    }
}
