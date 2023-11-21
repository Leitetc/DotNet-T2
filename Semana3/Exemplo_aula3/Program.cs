using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");


Console.WriteLine("Aula 03 - 21/11/2023");

Console.WriteLine("Exemplo Tuplas");

/* Conseitos Tuplas !

1 - Agrupar valores de dados leves
2 - (int, string) Keyvalor=("   ", "   ");
3 -  dois ponteiros com o mesmo nome

*/

#region Tupla

 var tuple1 = (10,20);
 Console.WriteLine($"Tuple1: {tuple1.Item1}, {tuple1.Item2}");

var tuple2 = (X: 5, Y: 50);
 Console.WriteLine($"Tuple2: {tuple2.X}, {tuple2.Y}");

var tuple3 = (id: 10, nome: "Thiago", Born: new DateTime(1993, 8, 02));
 Console.WriteLine($"Tuple3: {tuple3.id}, {tuple3.nome}, {tuple3.Born}");
 
List<(int id, string name, DateTime born)> list = new();
list.Add(tuple3);
list.Add((11, "Nicole", new DateTime(2019, 1, 12)));
list.ForEach(x => Console.WriteLine($"Tuple 4: {x.id}, {x.name}, {x.born.ToShortDateString()}"));

#endregion

#region Question 1

Console.WriteLine($"{CalcAge("Thiago", new DateTime(1993, 08, 02))}");


(string,int) CalcAge(string name, DateTime BirthDate){
   var yearsOld = DateTime.Today.Year - BirthDate.Year;
   if (BirthDate.Date.DayOfYear >= DateTime.Now.DayOfYear) yearsOld--;
   return (name, yearsOld);
}

#endregion

Console.WriteLine("Exemplo Tuplas");

/* Conseitos Lambda !

1 - Agrupar valores de dados leves
2 - (int, string) Keyvalor=("   ", "   ");
3 -  dois ponteiros com o mesmo nome

*/

#region Lambda

Func<int, int, int> sum = (x, y) => x + y;
Console.WriteLine($"Sum: {sum(10, 20)}");
// Sum: 30

Action<string> greet = name =>
{
   string greeting = $"Hello {name}!";
   Console.WriteLine(greeting);
};
string person = Console.ReadLine() ?? "";
greet(person);
// Hello `person or Someone`
// ?? and ??= are null-coalescing operators, 
//    which return the left-hand operand if the operand is not null; 
//    otherwise, they return the right operand.

Func<string, int, string> isBiggerThan = (string s, int x) => s.Length > x ? "Yes" : "No";
var size = 5;
Console.WriteLine($"The text {person} has more than {size} chars? {isBiggerThan(person, size)}");

string[] people = { "Helder", "Nicole", "Gilvana" };
char letter = 'N';
Console.WriteLine($"People with name started with '{letter}': {string.Join(", ", people.Where(x => x.StartsWith(letter)))}");

#endregion 