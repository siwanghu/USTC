#include "LinkTable.h"
#include <stdlib.h>

LinkTable* createLinkTable()
{
	LinkTable* table=(LinkTable*)malloc(sizeof(LinkTable));
	if(table==NULL)
	{
		return NULL;
	}
	else
	{
		LinkTableNode* head=(LinkTableNode*)malloc(sizeof(LinkTableNode));
		if(head==NULL)
		{
			return NULL;
		}
		else
		{
			head->pNext=NULL;
			table->head=head;
			table->sumOfTable=0;
			return table;
		}
		
	}
}

bool deleteLinkTable(LinkTable* table)
{
	LinkTableNode* head=table->head;
	while(head->pNext!=NULL)
	{
		LinkTableNode* temp=head->pNext;
		head->pNext=temp->pNext;
		free(temp);
	}
	free(head);
	free(table);
	return true;
}

LinkTableNode * getLinkTableHead(LinkTable* table)
{
	if(table==NULL)
	{
		return NULL;
	}
	else
	{
		return table->head;
	}
}

bool addNodeToLinkTable(LinkTable* table,LinkTableNode* node)
{
	if(table!=NULL&&node!=NULL)
	{
		LinkTableNode* head=table->head;
		while(head->pNext!=NULL)
		{
			head=head->pNext;
		}
		head->pNext=node;
		node->pNext=NULL;
		table->sumOfTable+=1;
		return true;
	}
	else
	{
		return false;
	}
}

bool deleteNodeOnLinkTable(LinkTable* table,LinkTableNode* node)
{
	if(table!=NULL&&node!=NULL)
	{
		LinkTableNode* head=table->head;
		while(head->pNext!=NULL)
		{
			if(head->pNext==node)
			{
				LinkTableNode* temp=head->pNext;
				head->pNext=temp->pNext;
				free(temp);
				return true;
			}
			head=head->pNext;
		}
		return false;
	}
	else
	{
		return false;
	}
}

LinkTableNode * searchNodeOfLinktable(LinkTable* table,condition function,void* argc)
{
	if(table==NULL)
	{
		return false;
	}
	else
	{
		char * cmd=(char*)argc;
		LinkTableNode* node=table->head->pNext;
		while(node!=NULL)
		{
			if((*function)(node,cmd)==true)
			{
				return node;
			}
			node=node->pNext;
		}
		return NULL;
	}
}

































