using System;
using System.Runtime.CompilerServices;
using Windows.UI.Core;

namespace Kulman.WPA81.Code
{
    /*
    Taken from http://wpdev.apps-1and1.net/dispatcher-yield-when-and-how-to-use-it-on-winrt/
    */
    public static class DispatcherExtensions
    {
        public static DispatcherPriorityAwaitable Yield(this CoreDispatcher dispatcher)
        {
            return Yield(dispatcher, CoreDispatcherPriority.Low);
        }

        public static DispatcherPriorityAwaitable Yield(this CoreDispatcher dispatcher, CoreDispatcherPriority priority)
        {
            return new DispatcherPriorityAwaitable(dispatcher, priority);
        }
    }

    public struct DispatcherPriorityAwaitable
    {
        private readonly CoreDispatcher dispatcher;

        private readonly CoreDispatcherPriority priority;

        internal DispatcherPriorityAwaitable(CoreDispatcher dispatcher, CoreDispatcherPriority priority)
        {
            this.dispatcher = dispatcher;
            this.priority = priority;
        }

        public DispatcherPriorityAwaiter GetAwaiter()
        {
            return new DispatcherPriorityAwaiter(this.dispatcher, this.priority);
        }
    }

    public struct DispatcherPriorityAwaiter : INotifyCompletion
    {
        private readonly CoreDispatcher dispatcher;

        private readonly CoreDispatcherPriority priority;

        public bool IsCompleted
        {
            get
            {
                return false;
            }
        }

        internal DispatcherPriorityAwaiter(CoreDispatcher dispatcher, CoreDispatcherPriority priority)
        {
            this.dispatcher = dispatcher;
            this.priority = priority;
        }

        public void GetResult()
        {
        }

        public void OnCompleted(Action continuation)
        {
            this.dispatcher.RunAsync(this.priority, new DispatchedHandler(continuation));
        }
    }
}
