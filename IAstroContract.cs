using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malin_s_AstroMath_App
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        Tuple<double, string, bool> StarVelocity(double observedLength, double restLength);

        [OperationContract]
        Tuple<double, string, bool> StarDistance(double arcsec);

        [OperationContract]

        Tuple<double, string, bool> KelvinTemperature(double celsius);
        [OperationContract]

        Tuple<double, string, bool> EventHorizon(double blackHoleMass);
    }
}
