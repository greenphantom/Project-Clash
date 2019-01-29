// This script defines the basic functionality for all units 
public class Stat {
    public string name;
    public string description;
    public int value;
    public int MAX;
    public int MIN;

    public void increase(int inc=1) { // Define increase behavior
        if (inc > 0 && inc+value <= MAX){
            value += inc;
        }
    }

    public void decrease(int dec=1) { // Define decrease behavior
        if (dec != 0 && value - System.Math.Abs(dec) >= MIN){
            value -= dec;
        }
    }

    public Stat(string Name = "???", string Desc = "?????", int Value = 3, int Max = 100, int Min = 1) {
        name = Name;
        description = Desc;
        value = Value;
        MAX = Max;
        MIN = Min;
    }
}
