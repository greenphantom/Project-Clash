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
    public double growthRate;
    public uint experience;
    // Class 
    // Subclass

    public Unit(string Name = "Unit", double GrowthRate = .25){
        name = Name;
        growthRate = GrowthRate;
        experience = 0;
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

    // TODO: This is jank. Probably can be fixed with an interface?
    public void takeDamage(uint amount){
        Health.decrease(amount);
    }

    // TODO: This is jank. Probably can be fixed with an interface?
    public void Heal(uint amount){
        Health.increase(amount);
    }

    public uint gainExp(uint exp){
        uint totalExp = experience + exp;
        uint levels = 0;
        double clas = .25; // Set this later when classes are implemented
        while (totalExp > 100){
            totalExp -= 100;
            levels += rollStatLevels(clas);
            if (levels == 0){ // If they get a blank levelUp, try again for mercy.
                levels += rollStatLevels(clas);
            }
        }
        experience = totalExp;
        return levels;
    }

    private uint rollStatLevels(double clas){
        uint amount = 0;
        amount += Health.levelUp(growthRate,clas);
        amount += Stamina.levelUp(growthRate,clas);
        amount += Strength.levelUp(growthRate,clas);
        amount += Skill.levelUp(growthRate,clas);
        amount += Endurance.levelUp(growthRate,clas);
        amount += Magic.levelUp(growthRate,clas);
        amount += Defense.levelUp(growthRate,clas);
        amount += Resistance.levelUp(growthRate,clas);
        amount += Luck.levelUp(growthRate,clas);
        amount += Speed.levelUp(growthRate,clas);
        return amount;
    }


}