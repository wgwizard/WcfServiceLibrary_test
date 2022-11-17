using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary11111
{
    [ServiceContract]
    public interface IPLC
    {
        [OperationContract]
        string GetDI(int value);

        [OperationContract]
        Motor GetMotor(Motor _motor);
    }


    [DataContract]
    public class Motor
    {
        string motorName = "motor";
        int currentSpeed=0;

        [DataMember]
        public string MotorName
        {
            get { return motorName; }
            set { motorName = value; }
        }

        [DataMember]
        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }
    }


}
