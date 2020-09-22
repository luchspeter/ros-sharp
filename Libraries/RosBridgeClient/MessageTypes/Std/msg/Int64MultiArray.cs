/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Std
{
    public class Int64MultiArray : Message
    {
        public override string RosMessageName => "std_msgs/Int64MultiArray";

        //  Please look at the MultiArrayLayout message definition for
        //  documentation on all multiarrays.
        public MultiArrayLayout layout { get; set; }
        //  specification of data layout
        public long[] data { get; set; }
        //  array of data

        public Int64MultiArray()
        {
            this.layout = new MultiArrayLayout();
            this.data = new long[0];
        }

        public Int64MultiArray(MultiArrayLayout layout, long[] data)
        {
            this.layout = layout;
            this.data = data;
        }
    }
}
