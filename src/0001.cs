class Problem1{
    public static void afunc(int n){
        int sum=0;
        for (int i = 1; i < n; i++)
        {
            if(i%3==0 || i%5==0){
                sum+=i;
            }
        }
        Console.WriteLine(sum);
    }
}