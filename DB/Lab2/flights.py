#!/usr/bin/python
#-*- coding:UTF-8 -*-

import ValueToKey,BPlusTree
from random import randint, choice 

def main():  

    #存储B+树关键字索引
    keys=[]

    #假设flights表格存储的数据
    flights=[('A1', 100, 30, 1, 'nanjing','shanghai'),\
             ('A2', 200, 30, 2, 'nanjing','beijing'),\
             ('A3', 300, 30, 3, 'nanjing','wuhang'),\
             ('A4', 400, 30, 4, 'nanjing','hanzhou'),\
             ('A5', 500, 30, 5, 'nanjing','guangzhou'),\
             ('A6', 600, 30, 6, 'nanjing','hefei'),\
             ('A7', 700, 30, 7, 'nanjing','tianjing'),\
             ('A8', 800, 30, 8, 'nanjing','shengyang'),\
             ('A9', 900, 30, 9, 'nanjing','changchun'),\
             ('A10',1000,30, 10,'nanjing','haerbing')]   

    #生成唯一标识码
    for flight in flights:
        key=randint(1,1000)
        keys.append(ValueToKey.Hash(key,flight))

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