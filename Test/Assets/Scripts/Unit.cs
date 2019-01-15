using UnityEngine;
using System.Collections;
 
# This script defines the basic functionality for all units 

public class Stat {
    string name;
    string description;
    int value;
    int MAX;
    int MIN;

    public void increase(int inc=1) { // Define increase behavior
        if (inc > 0 && inc+value <= MAX){
            value += inc
        }
    }

    public void decrease(int dec=1) { // Define decrease behavior
        if (dec != 0 && value - Math.Abs(dec) >= MIN){
            value -= dec
        }
    }

    public Stat(string Name = "???", string Desc = "?????", int Value = 3, int Max = 100, int Min = 1) {
        name = Name;
        description = Desc;
        value = Value;
        max = Max;
        min = Min;
    }
}


public class Unit {
    Stat Health;
    Stat Stamina;
    Stat Strength;
    Stat Skill;
    Stat Endurance;
    Stat Magic;
    Stat Defense;
    Stat Resistance;
    Stat Luck;
    Stat Speed;
    Stat Movement;


}