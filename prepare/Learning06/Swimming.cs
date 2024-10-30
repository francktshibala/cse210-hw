
public class Swimming : Activity
{
    private int _laps;
    private const double LAP_LENGTH_KM = 0.05; 

    public Swimming(DateTime date, int minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * LAP_LENGTH_KM;

    public override double GetSpeed() => (GetDistance() / Minutes) * 60;

    public override double GetPace() => Minutes / GetDistance();
}