﻿namespace Kenc.ACMELib.Exceptions.API
{
    [ACMEException("urn:ietf:params:acme:error:dns")]
    public class DNSException : ACMEException
    {
        public DNSException(int status, string detail) : base(status, detail)
        {
        }
    }
}
