namespace CreationalPatterns.SimpleFactory
{
    public interface IFan
    {
        void SwitchOn();
        void SwitchOff();
        string GetState();

    }
}