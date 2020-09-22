/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Actionlib
{
    public class GoalStatusArray : Message
    {
        public override string RosMessageName => "actionlib_msgs/GoalStatusArray";

        //  Stores the statuses for goals that are currently being tracked
        //  by an action server
        public Header header { get; set; }
        public GoalStatus[] status_list { get; set; }

        public GoalStatusArray()
        {
            this.header = new Header();
            this.status_list = new GoalStatus[0];
        }

        public GoalStatusArray(Header header, GoalStatus[] status_list)
        {
            this.header = header;
            this.status_list = status_list;
        }
    }
}
