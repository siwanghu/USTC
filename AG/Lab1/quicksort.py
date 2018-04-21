#-*- coding:UTF-8 -*-
import random  
import time
import sys  

def quickSort(array, left, right):  
    if(array==None or len(array)==0):
        return
    else:  
        if left < right:  
            mid = partition(array, left, right)  
            quickSort(array, left, mid)  
            quickSort(array, mid + 1, right)  
        return array

def partition(array, left, right):
    while(left<right):
        if array[right]>array[left]:
            right=right-1
        else:
            array[right],array[left]=array[left],array[right]
            left=left+1
    return left

array=[]
for _ in range(10):
    array.append(random.randint(0,1000))
print(array)
begin=time.clock()
quickSort(array,0,len(array)-1)
print(array)
end=time.clock()
print("time:%f",end-begin)