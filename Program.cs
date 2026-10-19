/* System.Console.WriteLine($"Логических процессов (ядер): {Environment.ProcessorCount}"); */

/* System.Console.WriteLine("Нагружаем процессор... Остановите программу (Ctrl + C) когда посмотрите на графики.");

long counter = 0;
while (true)
{
    counter++;
} */

using System.Diagnostics;

#if DEBUG
System.Console.WriteLine("mode: DEBUG");
#else
System.Console.WriteLine("mode: RELEASE");
#endif

long counter = 0;
var stopwatch = Stopwatch.StartNew();

while (stopwatch.ElapsedMilliseconds < 1000)
{
    counter++;
}

System.Console.WriteLine($"Итераций примерно за 1 секунду: {counter:N0}");