#include "menu.h"

void help(int argc,char *argv[]);
void version(int argc,char *argv[]);
void quit(int argc,char *argv[]);
void add(int argc,char *argv[]);

cNode help_cmd={NULL,"help","This is help command!",help};
cNode version_cmd={NULL,"version","This is version command!",version};
cNode quit_cmd={NULL,"quit","This is quit command!",quit};
cNode add_cmd={NULL,"add","This is add command!",add};

int find(LinkTableNode*node,void* argc)
{
	if(strcmp(((cNode*)node)->cmd,(char *)argc)==0)
	{
		return true;
	}
	else
	{
		return false;
	}
}

int main()
{
	LinkTable* menu=InitMenu();
	MenuConfig(menu,(LinkTableNode*)&help_cmd);
	MenuConfig(menu,(LinkTableNode*)&version_cmd);
	MenuConfig(menu,(LinkTableNode*)&quit_cmd);
	MenuConfig(menu,(LinkTableNode*)&add_cmd);
	ExecMenu(menu,find);
}

void add(int argc,char *argv[])
{
	if(argc==0)
	{
		printf("no input number!\n");
	}
	else
	{
		int i=0;
		int sum=0;
		for(i=1;i<argc;i++)
		{
			sum=sum+atoi(argv[i]);
		}
		printf("sum:%d\n",sum);
	}
}

void help(int argc,char *argv[])
{
	printf("%s","welcome you use my shell!\n");
}

void version(int argc,char *argv[])
{
	printf("%s","siwanghu-shell version 1.0\n");
}

void quit(int argc,char *argv[])
{
	printf("bye bye!\n\n");
	exit(0);
}
