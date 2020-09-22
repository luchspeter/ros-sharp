/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Sensor
{
    public class RelativeHumidity : Message
    {
        public override string RosMessageName => "sensor_msgs/RelativeHumidity";

        //  Single reading from a relative humidity sensor.  Defines the ratio of partial
        //  pressure of water vapor to the saturated vapor pressure at a temperature.
        public Header header { get; set; }
        //  timestamp of the measurement
        //  frame_id is the location of the humidity sensor
        public double relative_humidity { get; set; }
        //  Expression of the relative humidity
        //  from 0.0 to 1.0.
        //  0.0 is no partial pressure of water vapor
        //  1.0 represents partial pressure of saturation
        public double variance { get; set; }
        //  0 is interpreted as variance unknown

        public RelativeHumidity()
        {
            this.header = new Header();
            this.relative_humidity = 0.0;
            this.variance = 0.0;
        }

        public RelativeHumidity(Header header, double relative_humidity, double variance)
        {
            this.header = header;
            this.relative_humidity = relative_humidity;
            this.variance = variance;
        }
    }
}
