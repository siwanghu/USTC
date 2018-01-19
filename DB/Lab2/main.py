#!/usr/bin/python
#-*- coding:UTF-8 -*-

import ValueToKey,BPlusTree
from random import randint, choice 

def test():  
    #初始化数据源  
    mini=50  
    maxi=200  
    testlist=[]  
    for i in range(20):  
        key=randint(1,1000)  
        #key=i  
        value=choice(['Do', 'Re', 'Mi', 'Fa', 'So', 'La', 'Si'])  
        testlist.append(ValueToKey.Hash(key,value))  
  
    #初始化B树  
    myBPlusTree=BPlusTree.BPlusTree(4, 4)  
  
    #插入操作  
    for x in testlist:  
        myBPlusTree.insert(x)  
  
    myBPlusTree.show()  
  
    #查找操作  
    print('\nnow we are searching item between %d and %d\n==>'%(mini,maxi))  
    print([v.key for v in myBPlusTree.search(mini,maxi)])  
  
    
if __name__ == '__main__':  
    test();  