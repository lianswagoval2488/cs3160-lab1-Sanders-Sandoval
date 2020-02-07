namespace Set
{
   public class IntegerSet
    {
        bool[] arr;

        IntegerSet()
        {
            arr = new bool[51];
        }
        IntegerSet(int[] arr_int)
        {
            
            foreach(int i in arr_int)
            {
                if(i >= 0 && i < 51)
                {
                    arr[i] = true;
                }
                else 
                    Syste.Console.WriteLine("Number not 0-50")
            }
        }
        EmptySet()
        {
            Arrays.filed(arr, false);
        }
    } 
}
