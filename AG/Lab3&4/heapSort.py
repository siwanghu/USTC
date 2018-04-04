#-*- coding:UTF-8 -*-
import random  
import time
import sys

array=[]
for _ in range(10):
    array.append(random.randint(0,100))
print("原始数组：",array)

def heapAdjust(node,size):
    l_child,r_child=2*node+1,2*node+2
    if node<size/2 and node>-1:
        if l_child<size and array[l_child]<array[node]:
            array[l_child],array[node]=array[node],array[l_child]
        if r_child<size and array[r_child]<array[node]:
            array[r_child],array[node]=array[node],array[r_child]
        heapAdjust(node-1,size)

def buildMinHeap(size):
    node=size-1
    while node>-1:
        heapAdjust(node,size)
        node=node-1

def heapSort():
    size=len(array)
    for i in range(len(array)):
        buildMinHeap(size)
        array[0],array[size-1]=array[size-1],array[0]
        size=size-1

heapSort()
print("排序结果：",array)