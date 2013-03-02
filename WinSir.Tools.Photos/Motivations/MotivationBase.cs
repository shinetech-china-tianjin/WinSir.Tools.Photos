using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos.Motivations
{
    public abstract class MotivationBase : IMotivation
    {
        protected PathBase Path {
            get {
                return OSEnvironment.Current.PathHelper;
            }
        }

        public abstract void Execute();
    }
}
