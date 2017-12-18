#ifndef LINKTABLE_H
#define LINKTABLE_H

#define true 1
#define false 0
#define bool int

typedef struct tLinkTableNode
{
	struct tLinkTableNode * pNext;
}LinkTableNode;


typedef struct tLinkTable
{
	LinkTableNode *head;
	int sumOfTable;
}LinkTable;

LinkTable* createLinkTable();

bool deleteLinkTable(LinkTable* table);

LinkTableNode * getLinkTableHead(LinkTable* table);

bool addNodeToLinkTable(LinkTable* table,LinkTableNode* node);

bool deleteNodeOnLinkTable(LinkTable* table,LinkTableNode* node);

#endif
