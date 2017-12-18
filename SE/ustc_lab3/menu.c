#include "linkList.h"

void add();
void quit();
void help();
void error();

static cNode help_cmd={"help","help",help,NULL};
static cNode quit_cmd={"quit","quit",quit,&help_cmd};
static cNode add_cmd={"add","add",add,&quit_cmd};

int main()
{
	cNode * head=&add_cmd;
	char cmd[CMD_SIZE];
	while(true)
	{
		printf("siwanghu-shell:");
		scanf("%s",cmd);
		if(findCommand(head,cmd)==false)
		{	
			error();
		}
	}
}

void add()
{
	double a,b;
	printf("please input:");
	scanf("%lf",&a);
	printf("please input:");
	scanf("%lf",&b);
	printf("result:%lf\n",a+b);
}

void error()
{
	printf("the command is error!\n");
}

void quit()
{
	exit(0);
}

void help()
{
	printf("%s","add  help  quit\n");
}
