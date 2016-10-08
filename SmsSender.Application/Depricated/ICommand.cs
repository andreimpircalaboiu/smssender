using System;

namespace SmsSender.Application.Depricated
{
    public interface ICommand
    {
        Action Execute();
    }
}
