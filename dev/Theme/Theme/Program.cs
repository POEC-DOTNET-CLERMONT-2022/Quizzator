// See https://aka.ms/new-console-template for more information
using Theme;

Console.WriteLine("Hello, World!");

ThemeEx t = new ThemeEx("test1","erggeezge");
List<Question> list = new List<Question>();
t.AfficherList();
ThemeEx t2 = new ThemeEx("test2", "eriugren", list);
t2.AfficherList();
<<<<<<< HEAD
Console.WriteLine(t2.SerializingTheme());



=======
Persistance<ThemeEx> maPersistance= new Persistance<ThemeEx>();
maPersistance.Save(t);
List<ThemeEx> themeLoaded= maPersistance.Load();
>>>>>>> 83d8cc82a766e3fb06f2f60a1043c9784fd3c6d5

