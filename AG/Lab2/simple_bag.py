#-*- coding:UTF-8 -*-
import numpy as np

def solve(value,weight,length,total):
    result = np.zeros((length+1,total+1),dtype=np.int32)
    for i in range(1,length+1):
        for j in range(1,total+1):
            if weight[i] <= j:
                result[i,j] = max(result[i-1,j-weight[i]]+value[i],result[i-1,j])
            else:
                result[i,j] = result[i-1,j]
    return result[-1,-1]

if __name__ == '__main__':
    v = [0,6,10,12]
    w = [0,1,2,3]
    weight = 5
    n = 3
    result = solve(v,w,n,weight)
    print(result)