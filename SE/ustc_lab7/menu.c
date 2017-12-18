#include "menu.h"

LinkTable* InitMenu()
{
    return createLinkTable();
}

void MenuConfig(LinkTable* menu,LinkTableNode* node)
{
    addNodeToLinkTable(menu,node);
}

void ExecMenu(LinkTable *menu,condition function)
{
	char tmp[CMD_SIZE];
	char cmd[CMD_SIZE];
	while(true)
	{
		int argc=0;
		char *argv[CMD_CONF];
		memset(tmp,0,CMD_SIZE);
		memset(cmd,0,CMD_SIZE);
		printf("siwanghu-shell:");
		fgets(tmp,CMD_SIZE,stdin);
		strncpy(cmd,tmp,strlen(tmp)-1);
		char* token = strtok(cmd," ");
		while(token!=NULL)
		{
			argv[argc]=token;
			argc++;
			token = strtok(NULL," ");
		}
		cNode *node=findCommand(menu,function,argv[0]);
		if(node!=NULL)
		{	
			if(node->func!=NULL)
			{
				node->func(argc,argv);
			}
		}
		else
		{
			MenuException();
		}
	}
}

void MenuException()
{
    printf("%s","sorry,we don't have this command!\n");
}