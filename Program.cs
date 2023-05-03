// Testing:

// Create an instance of an Enemy in Program.cs (you can create any enemy you would like)
Enemy malfoy = new Enemy("Malfoy", new List<Attack> {new Attack("Magic", 13)});

// Create 3 instances of Attacks in Program.cs (again, you can create any attacks you would like. Have fun with it!)
// AttackStyles.Add("Melee");
Attack melee = new Attack("Melee", 10);
Attack magic = new Attack("Magic", 15);
Attack ranged = new Attack("Ranged", 17);

// Add the three Attacks to your Enemy instance's AttackList (hint: how do you add items to a List?)
malfoy.AttackList.Add(melee);
// Console.WriteLine(melee.Name);   // testing each console log
malfoy.AttackList.Add(magic);
// Console.WriteLine(magic);  // testing each console log
malfoy.AttackList.Add(ranged);
// Console.WriteLine(ranged);  // testing each console log

// Call your Enemy instance's RandomAttack method to test that a random Attack can be called on (a good developer will run this multiple times to ensure there are no bugs)
malfoy.RandomAttack();
