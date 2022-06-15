using System;
using System.Collections.Generic;
using System.Text;

// Magic Home API
// By nathanielxd | https://github.com/nathanielxd/magic-home
// Modified by Xenox003

namespace Xenox003.MagicHome.Exceptions
{
    public class MagicHomeException : Exception
    {
        new public string Message { get; private set; }

        public MagicHomeException(string message) => Message = message;
    }
}