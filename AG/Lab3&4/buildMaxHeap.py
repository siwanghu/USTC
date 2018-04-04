#-*- coding:UTF-8 -*-
import random  
import time
import sys

array=[]
for _ in range(10):
    array.append(random.randint(0,100))
print("原始数组：",array)

def heapAdjust(node):
    l_child,r_child=2*node+1,2*node+2
    if node<len(array)/2 and node>-1:
        if l_child<len(array) and array[l_child]>array[node]:
            array[l_child],array[node]=array[node],array[l_child]
        if r_child<len(array) and array[r_child]>array[node]:
            array[r_child],array[node]=array[node],array[r_child]
        heapAdjust(node-1)

def buildMaxHeap():
    node=len(array)-1
    while node>-1:
        heapAdjust(node)
        node=node-1

def printArray():
    print("建大顶堆：",array)

buildMaxHeap()
printArray()