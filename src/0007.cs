class Problem7{
    public static void afunc(int n){
        int i=2;
        int prime=0;
        int primeCount=0;
        while(primeCount<n){
            int count=0;
            for (int j = 2; j <= i; j++)
            {
                if(i%j==0){
                    count++;
                }
                if(count>1) {
                    break;
                }
            }
            if(count==1){
                primeCount++;
            }
            prime=i;
            i++;
        }
        Console.WriteLine("prime count: "+ primeCount);
        Console.WriteLine("prime: "+ prime);
        
    }
}