#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>

#define true 1

double add(double a,double b)
{
	return a+b;
}

double sub(double a,double b)
{
	return a-b;
}

double mul(double a,double b)
{
	return a*b;
}

double div_(double a,double b)
{
	return a/b;
}

double square(double a)
{
	return a*a;
}

void quit()
{
	exit(0);
}

void help()
{
	printf("%s","add  sub  mul  div\nsquare  echo help  quit\n");
}

int main()
{
	char cmd[10];
	while(true)
	{
		printf("siwanghu-shell:");
		scanf("%s",cmd);
		fflush(stdin);
		if(0==strcmp(cmd,"add"))
		{
			double a,b;
			printf("please input:");
			scanf("%lf",&a);
			printf("please input:");
			scanf("%lf",&b);
			printf("result:%lf\n",add(a,b));
		}
		else if(0==strcmp(cmd,"sub"))
		{
			double a,b;
			printf("please input:");
			scanf("%lf",&a);
			printf("please input:");
			scanf("%lf",&b);
			printf("result:%lf\n",sub(a,b));
		}
		else if(0==strcmp(cmd,"mul"))
		{
			double a,b;
			printf("please input:");
			scanf("%lf",&a);
			printf("please input:");
			scanf("%lf",&b);
			printf("result:%lf\n",mul(a,b));
		}
		else if(0==strcmp(cmd,"div"))
		{
			double a,b;
			printf("please input:");
			scanf("%lf",&a);
			printf("please input:");
			scanf("%lf",&b);
			printf("result:%lf\n",div_(a,b));
		}
		else if(0==strcmp(cmd,"square"))
		{
			double a;
			printf("please input:");
			scanf("%lf",&a);	
			printf("result:%lf\n",square(a));
		}
		else if(0==strcmp(cmd,"echo"))
		{
			char input[100];
			printf("please input:");
			scanf("%s",input);	
			printf("%s\n",input);
		}
		else if(0==strcmp(cmd,"help"))
		{
			help();
		}
		else if(0==strcmp(cmd,"quit"))
		{
			quit();
		}
		else
		{
			printf("error cmd!\n");
		}
	}
}





















































