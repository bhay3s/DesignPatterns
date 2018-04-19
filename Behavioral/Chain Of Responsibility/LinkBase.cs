using System;

namespace DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    public abstract class LinkBase<T>
    {
        private LinkBase<T> _nextLink;
        private Func<T, bool> _conditional;
        private bool _continueAfterHandle = true;

        /// <summary>
        /// Entry point into the chain.
        /// </summary>
        /// <param name="obj">Data object to be processed.</param>
        public void Handle(T obj)
        {
            if (_conditional != null && _conditional.Invoke(obj))
                Process(obj);

            if (_continueAfterHandle)
                _nextLink?.Handle(obj);
        }

        /// <summary>
        /// Sets a reference to the next object in the chain.
        /// </summary>
        public void SetNextLink(LinkBase<T> nextLink)
        {
            _nextLink = nextLink;
        }

        /// <summary>
        /// Delegate which determines if the data object passed to this link in the chain should be processed. False by default.
        /// </summary>
        public void HandleWhen(Func<T, bool> conditional)
        {
            _conditional = conditional;
        }

        /// <summary>
        /// Sets whether the object should be passed down the chain after this link. True by default.
        /// </summary>
        public void SetContinueAfterHandle(bool continuation)
        {
            _continueAfterHandle = continuation;
        }
        
        /// <summary>
        /// Business logic for processing the data object. Must be supplied by the concrete implementation.
        /// </summary>
        protected abstract void Process(T obj);
    }
}
