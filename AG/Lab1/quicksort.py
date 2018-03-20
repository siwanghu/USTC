#-*- coding:UTF-8 -*-
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

print(quickSort(None,0,0))
print(quickSort([],0,0))
print(quickSort([5],0,0))
print(quickSort([5,4,3,2,1],0,4))
print(quickSort([1,3,5,2,11,353,12,33],0,7))
print(quickSort([1,3,5,2,11,353,12,33,45],0,8))
