#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#define CMD_SIZE 100
#define CMD_DESC 500
#define false 0
#define true 1

typedef struct iNode
{
	char cmd[CMD_SIZE];
	char desc[CMD_DESC];
	void(*func)();
	struct iNode *next;
}cNode;

int findCommand(cNode *node,char *cmd);
