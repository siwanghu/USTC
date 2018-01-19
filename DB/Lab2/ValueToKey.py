#!/usr/bin/python
#-*- coding:UTF-8 -*-

#以字符串生成唯一的标识符
class Hash(object):

    __slots__=("key", "value")

    def __init__(self, key, value):
        self.key=int(key)
        self.value=value  
      
    def __lt__(self, other):  
        if (type(self) == type(other)):  
            return self.key < other.key;  
        else:  
            return int(self.key) < int(other);  
              
    def __eq__(self, other):  
        if (type(self) == type(other)):  
            return self.key == other.key;  
        else:  
            return int(self.key) == int(other);  
  
    def __gt__(self, other):  
        return not self < other; 

    def __str__(self):  
        return str((self.key, self.value))  
      
    def __cmp__(self, key):  
        if self.key>key:  
            return 1  
        elif self.key < key:  
            return -1  
        else:  
            return 0  