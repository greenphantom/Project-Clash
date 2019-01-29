using UnityEngine;
using System.Collections;
public class Unit : MonoBehaviour{
    public Stat Health;
    public Stat Stamina;
    public Stat Strength;
    public Stat Skill;
    public Stat Endurance;
    public Stat Magic;
    public Stat Defense;
    public Stat Resistance;
    public Stat Luck;
    public Stat Speed;
    public Stat Movement;
    public new string name;
    // Class 
    // Subclass

    public Unit(string Name = "Unit"){
        name = Name;
        StatFactory sf = new StatFactory();
        Health = sf.GetStat(StatType.Health,0,99);
        Stamina = sf.GetStat(StatType.Stamina,0,99);
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

    public void takeDamage(int amount){
        Health.decrease(amount);
    }

    public void Heal(int amount){
        Health.increase(amount);
    }


}