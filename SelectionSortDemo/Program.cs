int[] pole = new int[10] { 50,4,3,9,1054,3986,0,-99,2,47 }; // pole deseti neseřazených čísel
int minIndex;
int temp;
// pro každý prvek
for (int i = 0; i < pole.Length; i++)
{
    // najít minimum (od aktuálního prvku do konce)
    minIndex = i;
    for (int j = i; j < pole.Length; j++)
    {
        if (pole[j] < pole[minIndex])
        {
            minIndex = j;
        }
    }
    // dát minimum na začátek (prohodit minimum za aktuální prvek)
    temp = pole[minIndex];
    pole[minIndex] = pole[i];
    pole[i] = temp;
}
foreach(int item in pole)
{
    Console.WriteLine(item);
}