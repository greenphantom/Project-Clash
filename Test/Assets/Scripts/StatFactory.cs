public class StatFactory {
    public Stat GetStat(StatType type, int startValue=10, int min=1, int max=80){
        switch (type) {
            case StatType.Health:
                return new Stat("Health","The amount of hits you can take before your unit dies.",startValue,max,min);
            case StatType.Stamina:
                return new Stat("Stamina","The amount of actions you can take before inflicted with exhaustion.",startValue,max,min);
            case StatType.Strength:
                return new Stat("Strength","The amount of damage you inflict through physical weapons.",startValue,max,min);
            case StatType.Skill:
                return new Stat("Skill","Used to determine hit and trigger skills.",startValue,max,min);
            case StatType.Endurance:
                return new Stat("Endurance","Increases the amount of stamina alloted in a battle.",startValue,max,min);
            case StatType.Magic:
                return new Stat("Magic","The amount of damage you inflict through magical attacks.",startValue,max,min);
            case StatType.Defense:
                return new Stat("Defense","Reduces the damage taken from physical attacks.",startValue,max,min);
            case StatType.Resistance:
                return new Stat("Resistance","Reduces the damage taken from magical attacks.",startValue,max,min);
            case StatType.Luck:
                return new Stat("Luck","Determine critical chance / avoid amoung other things.",startValue,max,min);
            case StatType.Speed:
                return new Stat("Speed","Boosts evasion and accuracy and potential increase actions performed.",startValue,max,min);
            case StatType.Movement:
                return new Stat("Movement","Determines the number of tiles moved in a single in a turn.",startValue,max,min);
            default:
                throw new System.NotSupportedException();
        }
    }
}