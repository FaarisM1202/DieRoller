using DieRoller;
Die myDie = new Die(); // When die is created, the random number should be set
myDie.FaceValue = 6; // Setting the value shouldn't be allowed
byte currentValue = myDie.FaceValue;
myDie.Roll();
myDie.Roll();
myDie.Roll();

Console.ReadKey();