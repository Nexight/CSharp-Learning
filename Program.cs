#region If
/*
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

daysUntilExpiration=0;

Console.WriteLine($"days until expiration {daysUntilExpiration}.");


if(daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        if (daysUntilExpiration <= 1)
        {
            if (daysUntilExpiration == 0)
            {

                Console.WriteLine($"Your subscription has expired.");

            }else
            {              
                discountPercentage = 20;

                Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");

            }
        }else 
        {        
            discountPercentage = 10;

            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");

        }

    }else
    {
        Console.WriteLine($"Your subscription will expire soon.\nRenew now!");
    }
}
*/
#endregion
#region Matrices y for each
/*                                          Otra manera de inicializar un array
string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0]= "A123";
fraudulentOrderIDs[1]= "B456";
fraudulentOrderIDs[2]= "C789";
//fraudulentOrderIDs[3]= "D000";
*/
/*                                         
string[] fraudulentOrderIDs = {"A123","B456","C789"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassing First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");

int [] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin ++;
    Console.WriteLine($"Bin {bin} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
*/
#endregion
#region Legibilidad de codigo
    #region Explicaion sobre el uso de comentarios.
/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
/*
Random random = new Random();
string[] orderIDs = new string [5];

for ( int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65,70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1,1000).ToString("000");

    orderIDs[i]= prefix + suffix;
}

foreach (var orderId in orderIDs)
{
    Console.WriteLine(orderId);
}
*/
    #endregion
    #region Uso de Espacios en blanco
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
*/
    #endregion
#endregion
#region Booleans
// booleanos son expresiones que devuelven un unico valor que puede ser True o False.
/*operadores
    igualdad:       ==
    desigualdad:    !=


    Bonus----

    ToLower(); // sirve para poner todo un string en minuscula
    ToUpper(); // sirve para poner todo un string en mayuscula

    Trim(); // remueve los espacios en blanco 

*/

// las siguientes declaraciones devuelven un booleano, true o false

/*string value1 = " a";
string value2 = "A ";

Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

#endregion