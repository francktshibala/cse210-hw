class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by focusing on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 6; i++) // Alternate between "breathe in" and "breathe out"
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}