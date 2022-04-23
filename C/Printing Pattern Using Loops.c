#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
int main() 
{
    int n;
    scanf("%d", &n);
    int l=2*n-1;
    for(int i=0;i<l;i++){
        for(int j=0;j<l;j++){
            int r = i<j? i:j;
            r=r<l-i? r:l-i-1;
            r=r<l-j? r:l-j-1;
            printf("%d ",n-r);
        }
        printf("\n");
    }
    
    return 0;
}