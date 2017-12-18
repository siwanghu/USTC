#include <stdio.h>
#include <string.h>
#include "LinkTable.h"

#define CMD_SIZE 10
#define CMD_DESC 50

typedef struct iNode
{
	LinkTableNode* pNext;
	char cmd[CMD_SIZE];
	char desc[CMD_DESC];
	void(*func)();
}cNode;

int findCommand(LinkTable *table,char *cmd);
