using System;
using System.Collections.Generic;
using System.Data;
using System.Text;using CleanArch.Domain.Core.Events;

namespace CleanArch.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
