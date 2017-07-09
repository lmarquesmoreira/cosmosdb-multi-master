using System;
using System.Collections.Generic;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.SystemFunctions;
using System.Diagnostics;

class EnvReader
{
    static EnvReader()
    {

    }

        internal static string GetSafeEnvVar(string name)
        {
            var value = Environment.GetEnvironmentVariable(name);
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Could not initialize. Missing environment variable: " + name);
            }

            return value.Trim();
        }

    internal static IEnumerable<string> GetWriteRegions()
    {
        // TODO: Cache those to avoid rereading for every call
        return ParseEnvironmentVariable("WRITE_REGIONS");
    }

    private static IEnumerable<string> ParseEnvironmentVariable(string envVar)
    {
        IEnumerable<string> response = null;
        var locations = GetSafeEnvVar(envVar);

        if (!string.IsNullOrEmpty(locations))
        {
            response = locations.Split(new char[] { ':' });
        }
        return response;
    }

    internal static IEnumerable<string> GetReadRegions()
    {
        // TODO: Cache those to avoid rereading for every call
        return ParseEnvironmentVariable("READ_REGIONS");
    }

}