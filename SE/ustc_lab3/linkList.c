#include "linkList.h"

int findCommand(cNode *node,char *cmd)
{
	if(node==NULL)
	{
		return false;
	}
	else
	{
		while(node!=NULL)
		{
			if(strcmp(cmd,node->cmd)==0)
			{
				if(node->func!=NULL)
				{
					node->func();
					return true;
				}
				else
				{
					return false;
				}
			}
			node=node->next;
		}
		return false;
	}
}
