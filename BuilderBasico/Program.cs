namespace BuilderBasico;

class Program
{
    static void Main(string[] args)
    {
      IRobotBuilder robotBuilder   = new RobotBuilder();
      RobotDirector robotDirector  =new RobotDirector(robotBuilder);

      robotDirector.CostructorRobot();

      Robot robot = robotBuilder.GetRobot();
      robot.DisplayRobotInfo();
    }
}
