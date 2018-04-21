#-*- coding:UTF-8 -*-
import random  

class Node:
    def __init__(self,key,left,right,parent):
        self.key=key
        self.left=left
        self.right=right
        self.parent=parent

class Tree:
    def __init__(self,root):
        self.root=root
    
    def insert(self,node):
        p_node=None
        x_node=self.root
        while x_node!=None:
            p_node=x_node
            if x_node.key > node.key:
                x_node=x_node.left
            else:
                x_node=x_node.right
        node.parent=p_node
        if p_node==None:
            self.root=node
        elif node.key < p_node.key:
            p_node.left=node
        else:
            p_node.right=node
    
    def search(self,node,key):
        if node==None or key==node.key:
            return node
        if key < node.key:
            return self.search(node.left,key)
        else:
            return self.search(node.right,key)
    
    def max(self,node):
        while node.right!=None:
            node=node.right
        return node

    def min(self,node):
        while node.left!=None:
            node=node.left
        return node

    def transplant(self,old,new):
        if old.parent == None:
            self.root=new
        elif old == old.parent.left:
            old.parent.left=new
        else:
            old.parent.right==new
        if new!=None:
            new.parent=old.parent

    def delete(self,key):
        node=self.search(self.root,key)
        if node == None:
            print("在树中没有找到相关节点！")
            return
        if node.left == None:
            self.transplant(node,node.right)
        elif node.right == None:
            self.transplant(node,node.left)
        else:
            next_node=self.min(node.right)
            if next_node.parent!=node:
                self.transplant(next_node,next_node.right)
                next_node.right=node.right
                next_node.right.parent=next_node
            self.transplant(node,next_node)
            next_node.left=node.left
            next_node.left.parent=next_node
    
    def printTree(self,node):
        if node==None:
            return
        self.printTree(node.left)
        print(node.key)
        self.printTree(node.right)

array=[]
for _ in range(10):
    array.append(random.randint(0,100))
print(array)
node=Node(array[0],None,None,None)
tree=Tree(node)
for i in range(1,10):
    node=Node(array[i],None,None,None)
    tree.insert(node)
print("...............插入结果..................")
tree.printTree(tree.root)
print("...............最大值..................")
print(tree.max(tree.root).key)
print("...............最小值..................")
print(tree.min(tree.root).key)
print("...............查找..................")
print(tree.search(tree.root,array[2]).key)
print("...............删除..................")
tree.delete(array[2])
print("删除后结果：")
tree.printTree(tree.root)
