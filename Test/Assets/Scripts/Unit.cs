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

public enum StatType {
    Health,
    Stamina,
    Strength,
    Skill,
    Endurance,
    Magic,
    Defense,
    Resistance,
    Luck,
    Speed,
    Movement
}

public class StatFactory {
    public Stat GetStat(StatType type, int startValue=10, int min=1, int max=80){
        switch (type) {
            case type.Health:
                return new Stat("Health","The amount of hits you can take before your unit dies.",startValue,max,min);
            case type.Stamina:
                return new Stat("Stamina","The amount of actions you can take before inflicted with exhaustion.",startValue,max,min);
            case type.Strength:
                return new Stat("Strength","The amount of damage you inflict through physical weapons.",startValue,max,min);
            case type.Skill:
                return new Stat("Skill","Used to determine hit and trigger skills.",startValue,max,min);
            case type.Endurance:
                return new Stat("Endurance","Increases the amount of stamina alloted in a battle.",startValue,max,min);
            case type.Magic:
                return new Stat("Magic","The amount of damage you inflict through magical attacks.",startValue,max,min);
            case type.Defense:
                return new Stat("Defense","Reduces the damage taken from physical attacks.",startValue,max,min);
            case type.Resistance:
                return new Stat("Resistance","Reduces the damage taken from magical attacks.",startValue,max,min);
            case type.Luck:
                return new Stat("Luck","Determine critical chance / avoid amoung other things.",startValue,max,min);
            case type.Speed:
                return new Stat("Speed","Boosts evasion and accuracy and potential increase actions performed.",startValue,max,min);
            case type.Movement:
                return new Stat("Movement","Determines the number of tiles moved in a single in a turn.",startValue,max,min);
        }
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
    string name;
    // Class 
    // Subclass

    public Unit(string Name = "Unit"){
        name = Name;
        StatFactory sf = new StatFactory();
        Health = sf.GetStat(StatType.Health);
        Stamina = sf.GetStat(StatType.Stamina);
        Strength = sf.GetStat(StatType.Strength);
        Skill = sf.GetStat(StatType.Skill);
        Endurance = sf.GetStat(StatType.Endurance);
        Magic = sf.GetStat(StatType.Magic);
        Defense = sf.GetStat(StatType.Defense);
        Resistance = sf.GetStat(StatType.Resistance);
        Luck = sf.GetStat(StatType.Luck);
        Speed = sf.GetStat(StatType.Speed);
        Movement = sf.GetStat(StatType.Movement,4,8);
    }


}