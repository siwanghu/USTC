#!/usr/bin/python
#-*- coding:UTF-8 -*-

import ValueToKey,BPlusTree
from random import randint, choice 

def test():  
    #初始化数据源  
    mini=50  
    maxi=200  
    testlist=[]  

    key=randint(1,1000)
    testlist.append(ValueToKey.Hash(key,"Do"))
    key=randint(1,1000)
    testlist.append(ValueToKey.Hash(key,"Re"))
    key=randint(1,1000)
    testlist.append(ValueToKey.Hash(key,"Mi"))
    key=randint(1,1000)
    testlist.append(ValueToKey.Hash(key,"Fa"))
    key=randint(1,1000)
    testlist.append(ValueToKey.Hash(key,"So"))
    key=randint(1,1000)
    testlist.append(ValueToKey.Hash(key,"La"))
    key=randint(1,1000)
    testlist.append(ValueToKey.Hash(key,"Si"))

    #打印hash表
    for i in testlist:
        print i

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