using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Bu interface Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
