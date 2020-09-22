/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Octomap
{
    public class BoundingBoxQueryRequest : Message
    {
        public override string RosMessageName => "octomap_msgs/BoundingBoxQuery";

        //  Clear a region specified by a global axis-aligned bounding box in stored OctoMap
        //  minimum corner point of axis-aligned bounding box in global frame
        public Point min { get; set; }
        //  maximum corner point of axis-aligned bounding box in global frame
        public Point max { get; set; }

        public BoundingBoxQueryRequest()
        {
            this.min = new Point();
            this.max = new Point();
        }

        public BoundingBoxQueryRequest(Point min, Point max)
        {
            this.min = min;
            this.max = max;
        }
    }
}
