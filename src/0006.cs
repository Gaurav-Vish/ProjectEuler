class Problem6{
    public static void afunc(int limit){
        int sumofsq =0, sqofsum =0;
        for (int i = 1; i <= limit; i++)
        {
            sumofsq+=(i*i);
            sqofsum+=i;
        }
        Console.WriteLine((sqofsum*sqofsum)-sumofsq);
    }
}