
public class Enemy
{
    // FIELDS
    // Name (i.e. Bandit, Boss, Guard)
    private string Name;
    
    public string _Name
    {
        get { return Name; }
    }

    // Health
    public int Health { get; set; }

    // AttackList -- This will be a List of type Attack that will hold the various Attacks an enemy can perform
    public List<Attack> AttackList { get; set; }

    // Creating a constructor 
    public Enemy(string name, List<Attack> attackList)
    {
        Name = name;
        Health = 100;
        AttackList = attackList;
    }

    // Methods
    // RandomAttack: the enemy object performs a randomized attack from their AttackList
    public void RandomAttack()
    {
        Random randomNum = new Random();
        // choosing arbitrary index from the AttackList
        int randomAttackIndex = randomNum.Next(0, AttackList.Count);
        Attack randomAttack = AttackList[randomAttackIndex];
        Console.WriteLine($"{Name} has decided to Attack with {randomAttack.Name} and has dealth a total damage of {randomAttack.DamageAmount} leaving the opponent with {Health-randomAttack.DamageAmount} HP.");

        // randomAttack.PerformAttack();
    }
}