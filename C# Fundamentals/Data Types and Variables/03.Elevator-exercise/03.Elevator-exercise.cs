byte people = byte.Parse(Console.ReadLine());
byte capacity = byte.Parse(Console.ReadLine());
byte courses = (byte)(people / capacity);
if (people % capacity != 0) courses++;
Console.WriteLine(courses);