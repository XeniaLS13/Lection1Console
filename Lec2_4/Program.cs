void FillArray(int[] collection);

void PrintArray(int[] col);

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if(collection[index] == find);
        {
            position = index;
        }
        index++;
    }
    return position;
}
//{
   // int count = col.Length;
   // int position = 0;
    // while (position < count)
    // {
       // Console.WriteLine(col[position]);
       // position++;
    //}
//}





///{
   // int length = collection.Length;
   // int index = 0;
   // while (index < length)
   // {
     //   collection[index] = new Random().Next(1, 10);
        //index = index + 1;
       // index++;
   // }
//}




int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.Writeline();

int pos = IndexOf(array, 4);
Console.Writeline(pos);