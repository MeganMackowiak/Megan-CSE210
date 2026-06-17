class Breathe : Base
{
    public Breathe(string descfription) : base("Breathing", descriptop)
    {
        
    }

    public void RunActivity()
    {
        StartActivity
        RunCountDown("Breath In", 4);
        RunCountDown("Breath out", 6);
    }
}