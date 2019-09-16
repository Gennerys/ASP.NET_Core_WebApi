using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NekoMarket.API.Domain.Services.Communication
{
    //request-response pattern
    //If we need to change our service to receive more parameters, we don’t have to break its signature;
    //We can define a standard contract for our request and/or responses;
    //We can handle business logic and potential fails without stopping the application process, 
    //    and we won’t need to use tons of try-catch blocks.
    public abstract class BaseResponse
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }

        public BaseResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
