using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary11111
{
    public class PLC: IPLC
    {
        public string GetDI(int value)
        {
            return string.Format("DI: {0}", value);
        }

        public Motor GetMotor(Motor _motor)
        {
            Motor motor = new Motor();
            motor.MotorName ="A Line: " +_motor.MotorName;
            motor.CurrentSpeed=_motor.CurrentSpeed;
            return motor;
        }
    }
}
