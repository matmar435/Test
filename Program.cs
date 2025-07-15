// See https://aka.ms/new-console-template for more information



//calculator.Calculator _calculator = new calculator.Calculator();

//_calculator.Start();

using System.Security;

Console.WriteLine("Podaj działanie");
string x = Console.ReadLine();

char[] seperatory = {'+','-', '/', '*' };
string[] wyrażenie = x.Split(seperatory);

List<char> operacja = [' '];

foreach (var item in x)
{

    if (item.Equals('+') || item.Equals('-') || item.Equals('.') || item.Equals('*') )
        operacja.Add(item);
}



int sum = int.Parse(wyrażenie[0]);




for (int i = 0; i<wyrażenie.Length; i++)
{
    foreach (var oper in operacja)
    {
        if (oper.Equals('+'))
        {
            i++;   
            sum += int.Parse(wyrażenie[i]);
            Console.WriteLine(sum);
            

        }
        if (oper.Equals('-'))
        {
            i++;
            sum -= int.Parse(wyrażenie[i]);
            Console.WriteLine(sum);


        }

    }
}

Console.WriteLine(sum + "sum");





