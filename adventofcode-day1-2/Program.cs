using System.Collections.Generic;

string[] readings = System.IO.File.ReadAllLines(@"C:\Users\Axion\source\repos\adventofcode-day1-2\adventofcode-day1-2\measurements.txt");

int totalCount = readings.Count();
int[] measurements = new int[(totalCount)];

for (int line = 0; line < (totalCount); line++)
{
    measurements[line] = int.Parse(readings[line]);
}

// Create a list of A's
List<int> A = new List<int>();
// Create a list of B's
List<int> B = new List<int>();
// Create a list of C's
List<int> C = new List<int>();
// Create a list of D's
List<int> D = new List<int>();
// Create a list of E's
List<int> E = new List<int>();
// Create a list of F's
List<int> F = new List<int>();
// Create a list of G's
List<int> G = new List<int>();
// Create a list of H's
List<int> H = new List<int>();


int dummycounter = 0;
int stop = totalCount % 3;

for (int i = 0; i < (totalCount); i++)
{
    int remainder = (totalCount-1) - i;

    if (remainder >= stop)
    {

        if (dummycounter <= 2)
        {
            A.Add(measurements[i]);
        }
        if (dummycounter > 0 && dummycounter <= 3)
        {
            B.Add(measurements[i]);
        }
        if (dummycounter > 1 && dummycounter <= 4)
        {
            C.Add(measurements[i]);
        }
        if (dummycounter > 2 && dummycounter <= 5)
        {
            D.Add(measurements[i]);
        }
        if (dummycounter > 3 && dummycounter <= 6)
        {
            E.Add(measurements[i]);
        }
        if (dummycounter > 4 && dummycounter <= 7)
        {
            F.Add(measurements[i]);
        }
        if (dummycounter > 5 && dummycounter <= 8)
        {
            G.Add(measurements[i]);
        }
        if (dummycounter > 6 && dummycounter <= 9)
        {
            H.Add(measurements[i]);
        }

        dummycounter++;
        if (dummycounter > 9)
        {
            dummycounter = 0;
        }
    }
}

int[] sums = new int[] {A.Sum(), B.Sum(), C.Sum(), D.Sum(), E.Sum(), F.Sum(), G.Sum(), H.Sum()};

foreach (var item in sums)
{
    Console.WriteLine(item.ToString());
}


int counter = 0;
int last = sums[0];

foreach (int sum in sums)
{
    if (sum > last)
    {
        counter++;
    }
    last = sum;
}


//Print solution to problem
Console.WriteLine(counter.ToString());
