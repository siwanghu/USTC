#-*- coding:UTF-8 -*-
import random  
import time
import sys

array=[]

def heapShift(node,size):
    l_child,r_child=2*node+1,2*node+2
    if node>-1:
        if l_child<size and array[l_child]<array[node]:
            array[l_child],array[node]=array[node],array[l_child]
        if r_child<size and array[r_child]<array[node]:
            array[r_child],array[node]=array[node],array[r_child]
        heapShift(node-1,size)

for _ in range(10):
    data=random.randint(0,100)
    print("插入数据：",data)
    array.append(data)
    heapShift(len(array)-1,len(array))
    print("调整结果：",array)