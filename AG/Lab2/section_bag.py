#-*- coding:UTF-8 -*-

def solve(value,weight,total):
    sums,values=0,0
    while(sums<total):
        index=value.index(max(value))
        if(weight[index]<=total-sums):
            sums=sums+weight[index]
            values=values+weight[index]*value[index]
            del value[index]
            del weight[index]           
        else:
            values=values+(total-sums)*value[index]
            sums=total
    return values

if __name__ == '__main__':
    v = [4,1,3]
    w = [1,2,3]
    weight = 5
    result = solve(v,w,weight)
    print(result)