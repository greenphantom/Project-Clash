// This script defines the basic functionality for all units 
using UnityEngine;

public class Stat {
    public string name;
    public string description;
    public uint value;
    public uint MAX;
    public uint MIN;

    public void increase(uint inc=1) { // Define increase behavior
        if (inc > 0 && inc+value <= MAX){
            value += inc;
        }
    }

    public void decrease(uint dec=1) { // Define decrease behavior
        if (dec != 0 && value - System.Math.Abs(dec) >= MIN){
            value -= dec;
        }
    }

    public Stat(string Name = "???", string Desc = "?????", uint Value = 3, uint Max = 100, uint Min = 1) {
        name = Name;
        description = Desc;
        value = Value;
        MAX = Max;
        MIN = Min;
    }

    public uint levelUp(double baseGrowth, double classGrowth){
        double comboGrowth = baseGrowth + classGrowth;
        uint grown = 0;
        while (comboGrowth > 1){
            increase();
            comboGrowth -= 1;
            grown++;
        }
        double roll = Random.Range(0f,1f);
        if (roll <= comboGrowth){
            increase();
            grown++;
        }
        return grown;
    }
}
