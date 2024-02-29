class Problem4{
    public static void afunc(){
        
        int max_prod=-1, prod=0;
        for (int i = 999; i >= 100; i--)
        {
            for (int j = i; j >= 100; j--)
            {
                prod=i*j;
                if(isPal(i*j) && prod> max_prod){
                    max_prod=prod;
                }
            }
        }
        Console.WriteLine(max_prod);
    }

    public static bool isPal(int n){
        int temp=n, rev=0;
        while(temp>0){
            rev=(rev*10)+temp%10;
            temp/=10;
        }
        if(rev==n){
            return true;
        }
        return false;
    }
}