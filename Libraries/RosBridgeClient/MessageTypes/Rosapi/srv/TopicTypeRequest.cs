/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class TopicTypeRequest : Message
    {
        public override string RosMessageName => "rosapi/TopicType";

        public string topic { get; set; }

        public TopicTypeRequest()
        {
            this.topic = "";
        }

        public TopicTypeRequest(string topic)
        {
            this.topic = topic;
        }
    }
}
