using System;
using System.Collections.Generic;
using System.Text;

namespace LookLykeMe.Common
{
    public interface IAuthenticateCommand : ICommand
    {
        Guid UserId { get; set; }
    }
}
