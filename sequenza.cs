using System;
using System.Collections.Generic;
using System.Linq;

public static class Sequenza
{
    public static int[] Verifica( int N ) 
    {
        int[] vet = new int[N*(N+1)/2];
        
        if(N>0){
            int ind = 0;
            for(int i =0;i<=N;i++){
                for(int j=1;j<=i;j++){
                    vet[ind]=i;
                    ind++;
                }
            }
        }
        return vet;
    }
}