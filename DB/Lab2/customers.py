#!/usr/bin/python
#-*- coding:UTF-8 -*-

import ValueToKey,BPlusTree
from random import randint, choice 

def main():  

    #存储B+树关键字索引
    keys=[]

    #选择customers表格构造B+树
    customers=["P1","P2","P3","P4","P5","P6","P7","P8","P9","P10"]   #假设customer表格存储的数据

    for customer in customers:
        key=randint(1,1000)
        keys.append(ValueToKey.Hash(key,customer))

    #打印索引与数据的对应关系
    for key in keys:
        print key

    #初始化B树  
    myBPlusTree=BPlusTree.BPlusTree(4, 4)  
  
    #构造B+树  
    for key in keys:
        myBPlusTree.insert(key)  
  
    #打印B+树
    myBPlusTree.show()  
  
    #查找操作  
    min=int(raw_input("请输入要查找的用户范围上限:"))
    max=int(raw_input("请输入要查找的用户范围下限:"))

    results=myBPlusTree.search(min,max)
    if results.count==0:
        print("没有找到对应数据")
    else:
        for result in results:
            print result

if __name__ == '__main__':  
    main();  