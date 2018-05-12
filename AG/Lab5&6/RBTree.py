#-*- coding:UTF-8 -*-
import random  

arrays=[]
for _ in range(10):
    arrays.append(random.randint(0,100))
print(arrays[:])

class RBNode:
    def __init__(self,x):
        self.key=x
        self.left=None
        self.right=None
        self.parent=None
        self.color='black'
        self.size=None

class RBTree:
    def __init__(self,x):
        self.nil=RBNode(x)
        self.root=self.nil
        self.data=x
        self.root_flag=True

    def printTree(self,node):
        if node==None:
            return
        self.printTree(node.left)
        if node==self.root and self.root_flag==True:
            print(node.key,node.color)
            self.root_flag=False
        elif node.key!=self.data:
            print(node.key,node.color)
        self.printTree(node.right)

def leftRotate(T,x):
    y=x.right
    x.right=y.left
    if y.left!=T.nil:
        y.left.parent=x
    y.parent=x.parent
    if x.parent==T.nil:
        T.root=y
    elif x==x.parent.left:
        x.parent.left=y
    else:
        x.parent.right=y
    y.left=x
    x.parent=y

def rightRotate(T,x):
    y=x.left
    x.left=y.right
    if y.right!=T.nil:
        y.right.parent=x
    y.parent=x.parent
    if x.parent==T.nil:
        T.root=y
    elif x==x.parent.right:
        x.parent.right=y
    else:
        x.parent.left=y
    y.right=x
    x.parent=y

def RBInsert(T, z):
    y = T.nil
    x = T.root
    while x != T.nil:
        y = x
        if z.key < x.key:
            x = x.left
        else:
            x = x.right
    z.parent = y
    if y == T.nil:
        T.root = z
    elif z.key < y.key:
        y.left = z
    else:
        y.right = z
    z.left = T.nil
    z.right = T.nil
    z.color = 'red'
    RBInsertFixup(T, z)
    return z.key

def RBInsertFixup(T, z):
    while z.parent.color == 'red':
        if z.parent == z.parent.parent.left:
            y = z.parent.parent.right
            if y.color == 'red':
                z.parent.color = 'black'
                y.color = 'black'
                z.parent.parent.color = 'red'
                z = z.parent.parent
            else:
                if z == z.parent.right:
                    z = z.parent
                    leftRotate(T, z)
                z.parent.color = 'black'
                z.parent.parent.color = 'red'
                rightRotate(T,z.parent.parent)
        else:
            y = z.parent.parent.left
            if y.color == 'red':
                z.parent.color = 'black'
                y.color = 'black'
                z.parent.parent.color = 'red'
                z = z.parent.parent
            else:
                if z == z.parent.left:
                    z = z.parent
                    rightRotate(T, z)
                z.parent.color = 'black'
                z.parent.parent.color = 'red'
                leftRotate(T, z.parent.parent)
    T.root.color = 'black'

def TreeMinimum( x):
    while x.left != T.nil:
        x = x.left
    return x

def RBTransplant( T, u, v):
    if u.parent == T.nil:
        T.root = v
    elif u == u.parent.left:
        u.parent.left = v
    else:
        u.parent.right = v
    v.parent = u.parent

def RBDelete(T, z):
    y = z
    y_original_color = y.color
    if z.left == T.nil:
        x = z.right
        RBTransplant(T, z, z.right)
    elif z.right == T.nil:
        x = z.left
        RBTransplant(T, z, z.left)
    else:
        y = TreeMinimum(z.right)
        y_original_color = y.color
        x = y.right
        if y.parent == z:
            x.parent = y
        else:
            RBTransplant(T, y, y.right)
            y.right = z.right
            y.right.parent = y
        RBTransplant(T, z, y)
        y.left = z.left
        y.left.parent = y
        y.color = z.color
    if y_original_color == 'black':
        RBDeleteFixup(T, x)

def RBDeleteFixup(T, x):
    while x != T.root and x.color == 'black':
        if x == x.parent.left:
            w = x.parent.right
            if w.color == 'red':
                w.color = 'black'
                x.parent.color = 'red'
                LeftRotate(T, x.parent)
                w = x.parent.right
            if w.left.color == 'black' and w.right.color == 'black':
                w.color = 'red'
                x = x.parent
            else:
                if w.right.color == 'black':
                    w.left.color = 'black'
                    w.color = 'red'
                    RightRotate(T, w)
                    w = x.parent.right
                w.color = x.parent.color
                x.parent.color = 'black'
                w.right.color = 'black'
                LeftRotate(T, x.parent)
                x = T.root
        else:
            w = x.parent.left
            if w.color == 'red':
                w.color = 'black'
                x.parent.color = 'red'
                RightRotate(T, x.parent)
                w = x.parent.left
            if w.right.color == 'black' and w.left.color == 'black':
                w.color = 'red'
                x = x.parent
            else:
                if w.left.color == 'black':
                    w.right.color = 'black'
                    w.color = 'red'
                    LeftRotate(T, w)
                    w = x.parent.left
                w.color = x.parent.color
                x.parent.color = 'black'
                w.left.color = 'black'
                RightRotate(T, x.parent)
                x = T.root
    x.color = 'black'

T = RBTree(arrays[0])
for i in range(1,10):
    print('插入数据',RBInsert(T,RBNode(arrays[i])))
print('中序遍历')
T.printTree(T.root)

print("删除")
RBDelete(T,T.root.left)
T.printTree(T.root)