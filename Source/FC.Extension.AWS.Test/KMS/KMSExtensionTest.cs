using System;
using System.Collections.Generic;
using System.Text;
using Amazon;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace FC.Extension.AWS.Test
{
    public class KMSExtensionTest
    {
        private readonly ITestOutputHelper _output;
        public KMSExtensionTest(ITestOutputHelper output)
        {
            this._output = output;
        }

        //[Fact]
        public void GetKMSKey_Test()
        {
            string kmsMasterKey = "";
            var keyInfo = kmsMasterKey.GetKMSKeyInfo(clientAccessKey: "",
                clientSecretKey: "",
                RegionEndpoint.USEast1
                );
            keyInfo.Result.CypherKey.ShouldBeEmpty();
            _output.WriteLine($" Cypher Key : ", keyInfo.Result.CypherKey , $" Plain Key : " + keyInfo.Result.Plainkey);
            _output.WriteLine(kmsMasterKey);
        }
    }
}
