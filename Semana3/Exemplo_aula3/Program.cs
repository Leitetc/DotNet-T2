﻿using System.Globalization;
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