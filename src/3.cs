class Problem3{
    public static void afunc(long n){
        while(n%2==0){
            Console.WriteLine(n);
            n/=2;
        }
        for (long i = 3; i < n; i+=2)
        {
            while(n%i==0){
                Console.WriteLine(n);
                n/=i;
            }
        }
        Console.WriteLine(n);
        // while (n%2)
        // {
            
        // }

        // primefactor(n);
    }
    // public static int primefactor(n){

    // }
}