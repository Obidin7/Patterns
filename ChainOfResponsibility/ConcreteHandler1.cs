﻿namespace ChainOfResponsibility;

class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request == 1)
        {
            Console.WriteLine("One");
        }
        else
        {
            Successor?.HandleRequest(request);
        }

    }
}
