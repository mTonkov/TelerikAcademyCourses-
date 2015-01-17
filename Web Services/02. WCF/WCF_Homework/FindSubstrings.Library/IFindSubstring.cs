using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FindSubstrings.Library
{
    [ServiceContract]
    public interface IFindSubstring
    {
        [OperationContract]
        int SubstringCount(string substring, string fullString);

    }
}
