#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
#define MAX_LEN 128
int main() 
{
    char ch;
    scanf("%c", &ch);
    char word[MAX_LEN];
    scanf("%s\n", &word);
    char sen[MAX_LEN];
    scanf("%[^\n]%*c", &sen);
    printf("%c\n%s\n%s\n", ch, word, sen);     
    return 0;
}