#!/usr/bin/python
#-*- coding:UTF-8 -*-

import myException
from collections import deque  
from bisect import bisect_right, bisect_left  

class BPlusTree(object):  
       
    class __Leaf(object):  
        def __init__(self,L):  
            if not isinstance(L,int):  
                raise myException.InitException("必须是整数")  
            else:  
                self.__L=L  
                self.vlist=[]  
                self.brother=None 
                self.parent=None
        def isleaf(self):  
            return True  
        def isfull(self):  
            return len(self.vlist)>self.L  
        def isempty(self):  
            return len(self.vlist)<=(self.L+1)/2  
        @property  
        def L(self):  
            return self.__L  
   
    class __Node(object):  
        def __init__(self, M):  
            if not isinstance(M, int):  
                raise myException.InitException("必须是整数")  
            if M<=3:  
                raise myException.InitException("阶数必须大于3")  
            else:  
                self.__M=M  
                self.clist=[] 
                self.ilist=[] 
                self.parent=None  
        def isleaf(self):  
            return False  
        def isfull(self):  
            return len(self.ilist)>=self.M-1  
        def isempty(self):  
            return len(self.ilist)<=(self.M+1)/2-1  
        @property  
        def M(self):  
            return self.__M
  
    def __init__(self,M,L):  
        if L>M:  
            raise myException.InitException("阶数必须大于3")
        else:  
            self.__M=M  
            self.__L=L  
            self.__root=BPlusTree.__Leaf(L)  
            self.__leaf=self.__root  
    
    @property  
    def M(self):  
        return self.__M  

    @property  
    def L(self):  
        return self.__L  
  
     
    def insert(self, key_value):  
        node=self.__root  
        def split_node(n1):  
            mid=self.M//2
            newnode=BPlusTree.__Node(self.M)  
            newnode.ilist=n1.ilist[mid:]  
            newnode.clist=n1.clist[mid:]  
            newnode.parent=n1.parent  
            for c in newnode.clist:  
                c.parent=newnode  
            if n1.parent is None:  
                newroot=BPlusTree.__Node(self.M)  
                newroot.ilist=[n1.ilist[mid-1]]  
                newroot.clist=[n1,newnode]  
                n1.parent=newnode.parent=newroot  
                self.__root=newroot  
            else:  
                i=n1.parent.clist.index(n1)  
                n1.parent.ilist.insert(i,n1.ilist[mid-1])  
                n1.parent.clist.insert(i+1,newnode)  
            n1.ilist=n1.ilist[:mid-1]  
            n1.clist=n1.clist[:mid]  
            return n1.parent  
        def split_leaf(n2):  
            mid=(self.L+1)//2  
            newleaf=BPlusTree.__Leaf(self.L)  
            newleaf.vlist=n2.vlist[mid:]  
            if n2.parent==None:  
                newroot=BPlusTree.__Node(self.M)  
                newroot.ilist=[n2.vlist[mid].key]  
                newroot.clist=[n2,newleaf]  
                n2.parent=newleaf.parent=newroot  
                self.__root=newroot  
            else:  
                i=n2.parent.clist.index(n2)  
                n2.parent.ilist.insert(i,n2.vlist[mid].key)  
                n2.parent.clist.insert(i+1,newleaf)  
                newleaf.parent=n2.parent  
            n2.vlist=n2.vlist[:mid]  
            n2.brother=newleaf  
        def insert_node(n):  
            if not n.isleaf():  
                if n.isfull():  
                    insert_node(split_node(n))  
                else:  
                    p=bisect_right(n.ilist,key_value)  
                    insert_node(n.clist[p])  
            else:  
                p=bisect_right(n.vlist,key_value)  
                n.vlist.insert(p,key_value)  
                if n.isfull():  
                    split_leaf(n)  
                else:  
                    return  
        insert_node(node)  
  
    
    def search(self,mi=None,ma=None):  
        result=[]  
        node=self.__root  
        leaf=self.__leaf  
        if mi is None or ma is None:  
            raise myException.parentseException("必须设置搜索范围")  
        elif mi > ma:  
            raise myException.parentseException("搜索范围无效")  
        def search_key(n,k):  
            if n.isleaf():  
                p=bisect_left(n.vlist,k)  
                return (p,n)  
            else:  
                p=bisect_right(n.ilist,k)  
                return search_key(n.clist[p],k)  
        if mi is None:  
            while True:  
                for kv in leaf.vlist:  
                    if kv<=ma:  
                        result.append(kv)  
                    else:  
                        return result  
                if leaf.brother==None:  
                    return result  
                else:  
                    leaf=leaf.brother  
        elif ma is None:  
            index,leaf=search_key(node,mi)  
            result.extend(leaf.vlist[index:])  
            while True:  
                if leaf.brother==None:  
                    return result  
                else:  
                    leaf=leaf.brother  
                    result.extend(leaf.vlist)  
        else:  
            if mi==ma:  
                i,l=search_key(node,mi)  
                try:  
                    if l.vlist[i]==mi:  
                        result.append(l.vlist[i])  
                        return result  
                    else:  
                        return result  
                except IndexError:  
                    return result  
            else:  
                i1,l1=search_key(node,mi)  
                i2,l2=search_key(node,ma)  
                if l1 is l2:  
                    if i1==i2:  
                        return result  
                    else:  
                        result.extend(l2.vlist[i1:i2])  
                        return result  
                else:  
                    result.extend(l1.vlist[i1:])  
                    l=l1  
                    while True:                          
                        if l.brother==l2:  
                            result.extend(l2.vlist[:i2])  
                            return result  
                        elif l.brother != None:  
                            result.extend(l.brother.vlist)  
                            l=l.brother  
                        else:  
                            return result;  
    
    def show(self):  
        print("B+树为:")  
        q=deque()  
        h=0  
        q.append([self.__root,h])  
        while True:  
            try:  
                w,hei=q.popleft()  
            except IndexError:  
                return  
            else:  
                if not w.isleaf():  
                    print(w.ilist,"height:",hei)  
                    if hei==h:  
                        h+=1  
                    q.extend([[i,h] for i in w.clist])  
                else:  
                    print([(v.key,v.value) for v in w.vlist],"leaf:",hei)  