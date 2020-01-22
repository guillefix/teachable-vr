using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseX;
using FrooxEngine;
//using FrooxEngine.LogiX;

using Grpc.Core;
using Grpc.Core.Utils;
//using LogiX;
using FrooxEngine.LogiX;

namespace ServeData
{
    [Category("LogiX/Network")]
    [NodeName("Serve data")]
    public class ServeData : LogixNode
    {
        public readonly Input<float> TestNumber;
        public readonly Input<float> TestNumber2;

        public override void RunStartup()
        {

        }

        protected override void OnChanges()
        {

        }

        //[ImpulseTarget]
        //public void Run()
        //{

        //}
    }
}
