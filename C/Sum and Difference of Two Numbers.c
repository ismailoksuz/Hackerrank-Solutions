#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main()
{
	int n,m;
    scanf("%d%d",&n,&m);
    float f,u;
    scanf("%f%f",&f,&u);
    printf("%d %d\n%.1f %.1f",n+m,n-m,f+u,f-u);
    return 0;
}