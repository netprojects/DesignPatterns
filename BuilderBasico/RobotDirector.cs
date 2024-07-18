using BuilderBasico;

public class RobotDirector
{
    private IRobotBuilder _robotBuilder;
    public RobotDirector(IRobotBuilder robotBuilder)
    {
        _robotBuilder = robotBuilder;
    }

    public void CostructorRobot()
    {
        _robotBuilder.BuildHead("Round");
        _robotBuilder.BuildBody("Metal");
        _robotBuilder.BuildArms("Claws");
        _robotBuilder.BuildLegs("Wheels");
    }
}