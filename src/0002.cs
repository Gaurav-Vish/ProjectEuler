class Problem2{
    public static void afunc(){
        int sum=0;
        int i=2;
        while(sum<=4000000)
        {
            sum+=fibo(i);
            i=i+3;
        }
        Console.WriteLine(sum);
    }
    public static int fibo(int n){
        if(n==1){
            return 1;
        }
        else if (n==2)
        {
            return 2;
        }
        else{
            return fibo(n-2)+fibo(n-1);
        }
    }
}