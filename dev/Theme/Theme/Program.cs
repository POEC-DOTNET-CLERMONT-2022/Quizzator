// See https://aka.ms/new-console-template for more information
using Theme;

Console.WriteLine("Hello, World!");

ThemeEx t = new ThemeEx("test1","erggeezge");
List<Question> list = new List<Question>();
t.AfficherList();
ThemeEx t2 = new ThemeEx("test2", "eriugren", list);
t2.AfficherList();
Console.WriteLine(t2.SerializingTheme());




