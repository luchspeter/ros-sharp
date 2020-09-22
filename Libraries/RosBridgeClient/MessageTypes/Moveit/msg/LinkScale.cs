/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class LinkScale : Message
    {
        public override string RosMessageName => "moveit_msgs/LinkScale";

        // name for the link
        public string link_name { get; set; }
        //  scaling to apply to the link
        public double scale { get; set; }

        public LinkScale()
        {
            this.link_name = "";
            this.scale = 0.0;
        }

        public LinkScale(string link_name, double scale)
        {
            this.link_name = link_name;
            this.scale = scale;
        }
    }
}
