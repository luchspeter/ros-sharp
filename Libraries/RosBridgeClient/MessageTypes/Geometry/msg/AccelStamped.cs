/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class AccelStamped : Message
    {
        public override string RosMessageName => "geometry_msgs/AccelStamped";

        //  An accel with reference coordinate frame and timestamp
        public Header header { get; set; }
        public Accel accel { get; set; }

        public AccelStamped()
        {
            this.header = new Header();
            this.accel = new Accel();
        }

        public AccelStamped(Header header, Accel accel)
        {
            this.header = header;
            this.accel = accel;
        }
    }
}
