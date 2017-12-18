#include "LinkTable.h"
#include "node.h"
#include <string.h>

LinkTable* InitMenu();

void MenuConfig(LinkTable* menu,LinkTableNode* node);

void ExecMenu(LinkTable *menu,condition function);

void MenuException();