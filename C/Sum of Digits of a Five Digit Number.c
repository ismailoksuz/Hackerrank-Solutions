#include <stdio.h>
int main() {
    int n;
    scanf("%d", &n);
    int sod=0;
    while(n!=0){
        sod+=n%10;
        n/=10;
    }
    printf("%d",sod);    
    return 0;
}