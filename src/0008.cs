class Problem8{
    public static void afunc(string n){
        string[] stSplit = n.Split('0');
        string maxProdSub="";
        int maxProd=1,prod=1;
        for (int i = 0; i < n.Length-12; i++)
        {
            string sub = n.Substring(i,13);
            if(!sub.Contains('0')){
                // Console.WriteLine(sub);
                for (int j = 0; j < sub.Length; j++)
                {
                    // Console.WriteLine(sub);
                    prod*=Convert.ToInt32(sub[j]);
                    Console.WriteLine(prod);
                }
                if(prod>maxProd){
                    maxProd=prod;
                    maxProdSub=sub;
                }
            }
        }
        // Console.WriteLine(maxProd);
        // Console.WriteLine(maxProdSub);
    }
}