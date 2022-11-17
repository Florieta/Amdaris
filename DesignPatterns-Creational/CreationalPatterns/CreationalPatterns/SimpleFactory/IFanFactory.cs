namespace CreationalPatterns.SimpleFactory
{
    public interface IFanFactory
    {
        IFan CreateFan(FanType type);
    }
}