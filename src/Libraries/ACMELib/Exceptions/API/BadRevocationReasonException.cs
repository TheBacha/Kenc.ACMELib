﻿namespace Kenc.ACMELib.Exceptions.API
{
    using System;

    [Serializable]
    [ACMEException("urn:ietf:params:acme:error:badrevocationreason")]
    public class BadRevocationReasonException : ACMEException
    {
        public BadRevocationReasonException(int status, string detail) : base(status, detail)
        {
        }
    }
}
