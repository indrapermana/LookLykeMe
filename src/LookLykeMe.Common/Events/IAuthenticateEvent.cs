using System;
using System.Collections.Generic;
using System.Text;

namespace LookLykeMe.Common
{
    public interface IAuthenticateEvent : IEvent
    {
        Guid UserId { get; set; }
    }
}
