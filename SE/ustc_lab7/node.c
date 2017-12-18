#include "node.h"

cNode *findCommand(LinkTable *table,condition function,char *cmd)
{
	return (cNode*)searchNodeOfLinktable(table,function,cmd);
}
