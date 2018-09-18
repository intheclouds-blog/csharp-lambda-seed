using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace InTheClouds.Lambda.Seed
{
    /// <summary>
    /// Represents a Lambda function for converting a string to upper case.
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Converts an input string to upper case.
        /// </summary>
        /// <param name="input">The string to convert to upper case.</param>
        /// <param name="context">The <see cref="ILambdaContext" /> for the function.</param>
        /// <returns>An upper case version of the input string.</returns>
        public string FunctionHandler(string input, ILambdaContext context)
        {
            return input?.ToUpper();
        }
    }
}
