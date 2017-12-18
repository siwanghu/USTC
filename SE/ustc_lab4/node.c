#include "node.h"

int findCommand(LinkTable *table,char *cmd)
{
	if(table==NULL)
	{
		return false;
	}
	else
	{
		cNode* node=(cNode*)(table->head->pNext);
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
			node=(cNode*)(node->pNext);
		}
		return false;
	}
}
