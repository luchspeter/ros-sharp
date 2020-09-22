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
    public class GetPlanningSceneRequest : Message
    {
        public override string RosMessageName => "moveit_msgs/GetPlanningScene";

        //  Get parts of the planning scene that are of interest
        //  All scene components are returned if none are specified
        public PlanningSceneComponents components { get; set; }

        public GetPlanningSceneRequest()
        {
            this.components = new PlanningSceneComponents();
        }

        public GetPlanningSceneRequest(PlanningSceneComponents components)
        {
            this.components = components;
        }
    }
}
