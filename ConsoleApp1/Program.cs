using ConsoleApp1;
using System.Collections;
using System.Runtime.InteropServices;

int[] ints = new int[10];
int[] ints2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

ints2[1] = 11;

List<int> intslist = new();
intslist.Add(1);
intslist.Remove(1);
intslist.Contains(1);
intslist.Select(x => x * 2).ToList();

Cat cat1 = new Cat() { name = "Annie"};
Cat cat2 = new Cat() { name = "Spot"};
List<Cat> cats = new();
cats.Add(cat1);
cats.Add(cat2);
cats.Contains(cat1);
Cat[] catsarr = new Cat[10];
Cat[] catsarr2 = { cat1, cat2 };
List<int> intslist2 = new(ints);

var spotcats = cats.Any(c => c.name == "Spot");


foreach (Cat c in cats)
{
    Console.WriteLine(c.name);
}

Console.WriteLine(cats[1].name);

List<Cat> catslist2 = new List<Cat>(5);

Dictionary<string, Cat> catdict = new();
catdict.Add(cat1.name, cat1);
catdict.Add(cat2.name, cat2);
catdict.Remove("Annie");
Cat caatfromdcit = catdict["Spot"];

var catlinq = catdict.Where(c => c.Value.name == "Spot").First().Value;

foreach (string catkey in catdict.Keys)
{
    Console.WriteLine(catkey);
}

foreach (var cat in catdict)
{
    Console.WriteLine(cat.Key);
    Console.WriteLine(cat.Value.name);
}
Dictionary<int, List<Cat>> nested = new();

var firstcat = catdict.First().Value;

var dictnested = new Dictionary<int, Dictionary<int,string>>();

Queue<int> queue = new();
queue.Enqueue(1);
queue.Enqueue(2);
int peeked = queue.Peek(); //1
int dequeued = queue.Dequeue(); //1

Stack<char> mystack = new();
mystack.Push('a');
mystack.Push('b');
mystack.Pop(); //b and removes it

Cat annie = new Cat() { name = "Annie" };
Object annieobject = annie;

Console.WriteLine(annieobject.name);
Console.WriteLine(annie.name);

foreach (Cat cat in catslist2)
{
    Console.WriteLine(cat.name);
}

List<Object>
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add(cat1);

List<int> intsnew =new() { 1, 2, 3 };
Class1.ProcessInput(intsnew, IntBox.mymethod);

catslist2.Sort();
catslist2.Sort(new ReverseCatAgeComparer());