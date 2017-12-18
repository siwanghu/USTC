#include "node.h"

void error();
void help();
void version();

int find(LinkTableNode*node,void* argc)
{
	if(strcmp(((cNode*)node)->cmd,argc)==0)
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
	LinkTable* table=createLinkTable();
	cNode help_cmd={NULL,"help","help",help};
	cNode version_cmd={NULL,"version","version",version};
	addNodeToLinkTable(table,(LinkTableNode*)&help_cmd);
	addNodeToLinkTable(table,(LinkTableNode*)&version_cmd);
	char cmd[CMD_SIZE];
	while(true)
	{
		printf("siwanghu-shell:");
		scanf("%s",cmd);
		cNode *node=findCommand(table,find,cmd);
		if(node!=NULL)
		{	
			if(node->func!=NULL)
			{
				node->func();
			}
		}
		else
		{
			error();
		}
	}
}


void error()
{
	printf("%s","error!\n");
}

void help()
{
	printf("%s","welcome you use my shell!\n");
}

void version()
{
	printf("%s","siwanghu-shell version 1.0\n");
}
