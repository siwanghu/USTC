#include <stdio.h>
#include <string.h>
#include "LinkTable.h"

#define CMD_SIZE 50
#define CMD_DESC 50
#define CMD_CONF 10

typedef struct iNode
{
	LinkTableNode* pNext;
	char cmd[CMD_SIZE];
	char desc[CMD_DESC];
	void(*func)(int argc,char* argv[]);
}cNode;

cNode *findCommand(LinkTable *table,condition function,char *cmd);
