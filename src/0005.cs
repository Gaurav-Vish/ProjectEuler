class Problem5
{
    public static void afunc(int m, int n){
        List<int> primeF = new List<int>(){};
        int primeProd=1;
        for (int i = m; i <= n; i++)
        {
            for (int j = 2; j <= i; j++)
            {
                if(i%j!=0){
                    Console.WriteLine(i);
                }
            }
        }
        // while(n%2==0){
        //     Console.WriteLine(n);
        //     n/=2;
        // }
        // for (long i = 3; i < n; i+=2)
        // {
        //     while(n%i==0){
        //         Console.WriteLine(n);
        //         n/=i;
        //     }
        // }
        // Console.WriteLine(n);
    }
}