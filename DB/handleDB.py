#!/usr/bin/python
# -*- coding: UTF-8 -*-

import MySQLdb
import config

#航班基础数据的入库
def insertFlights(flightNum,price,numSeats,numAvail,FromCity,ArivCity):
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        cursor = db.cursor()
        sql = "insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values('%s', %d,%d,%d,'%s','%s') "%(flightNum,price,numSeats,numAvail,FromCity,ArivCity)
        cursor.execute(sql)
        db.commit()       
    except:
        db.rollback()
    finally:
        db.close()

#酒店基础数据的入库
def insertHotels(name,location,price,numRooms,numAvail):
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        cursor = db.cursor()
        sql = "insert into hotels(name,location,price,numRooms,numAvail) values ('%s','%s',%d, %d, %d)" %(name,location,price,numRooms,numAvail)
        cursor.execute(sql)
        db.commit()
    except:
        db.rollback()
    finally:
        db.close()

#出租车基础数据的入库
def insertCars(type_s,location,price,numCars,numAvail):
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        cursor = db.cursor()
        sql = "insert into cars(type,location,price,numCars,numAvail) values ('%s','%s',%d,%d,%d)"%(type_s,location,price,numCars,numAvail)
        cursor.execute(sql)
        db.commit()
    except:
        db.rollback()
    finally:
        db.close()

#客户基础数据的入库
def insertCustomers(custName):
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        cursor = db.cursor()
        sql = "insert into customers(custName) values ('%s')" %(custName)
        cursor.execute(sql)
        db.commit()
    except:
        db.rollback()
    finally:
        db.close()
        
#客户与酒店和出租车的关系基础数据的入库
def insertReservations(custName,resvType,resvKey):
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        cursor = db.cursor()
        sql = "insert into reservations(custName,resvType,resvKey) values ('%s','%s','%s')" %(custName,resvType,resvKey)
        cursor.execute(sql)
        db.commit()
    except:
        db.rollback()
    finally:
        db.close()

#预定航班
def reserveFlights(flightNum):
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        cursor = db.cursor(MySQLdb.cursors.DictCursor)
        sql = "select * from flights where flightNum = '%s'" %(flightNum)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        for row in results:     #如果航班还有席位，则预定成功
            if(row['numAvail']>0):
                numAvail=row['numAvail']-1
                sql = "update flights set numAvail=%d where flightNum='%s' "%(numAvail,flightNum)
                cursor.execute(sql)
                db.commit()
                db.close()
                return True
    except:
        db.close()
        db.rollback()

#预定出租车
def reserveCars(custName,type_s):
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        cursor = db.cursor(MySQLdb.cursors.DictCursor)
        sql = "select * from cars where type = '%s'" %(type_s)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        for row in results:     #如果出租车还有席位，则预定成功
            if(row['numAvail']>0):
                numAvail=row['numAvail']-1
                sql = '''update cars set numAvail=%d where type='%s' 
                      '''%(numAvail,type_s)
                cursor.execute(sql)
                #更新联系表
                sql = '''update reservations set resvKey='%s' where custName='%s' 
                      '''%(type_s,custName)
                cursor.execute(sql)
                db.commit()
                db.close()
                return True
    except:
        db.close()
        db.rollback()

#预定宾馆
def reserveHotels(custName,name):
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        cursor = db.cursor(MySQLdb.cursors.DictCursor)
        sql = "select * from hotels where name = '%s'" %(name)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        for row in results:     #如果宾馆还有房间，则预定成功
            if(row['numAvail']>0):
                numAvail=row['numAvail']-1
                sql = "update hotels set numAvail=%d where name='%s' "%(numAvail,name)
                cursor.execute(sql)
                #更新联系表
                sql = "update reservations set resvType='%s' where custName='%s' "%(name,custName)
                cursor.execute(sql)
                db.commit()
                db.close()
                return True
    except:
        db.close()
        db.rollback()

#查询航班
def selectFlights():
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        sql="select * from flights"
        cursor = db.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        db.close()
        return results
    except:
        db.close()

#查询出租车
def selectCars():
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        sql="select * from cars"
        cursor = db.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        db.close()
        return results
    except:
        db.close()

#查询宾馆房间
def selectHotels():
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        sql="select * from hotels"
        cursor = db.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        db.close()
        return results
    except:
        db.close()

#查询客户
def selectCustomers():
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        sql="select * from customers"
        cursor = db.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        db.close()
        return results
    except:
        db.close()

#查询预订信息
def selectReservations():
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        sql="select * from reservations"
        cursor = db.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        db.close()
        return results
    except:
        db.close()

#查询客户的旅行线路
def searchCustomer(custName):
    db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
    try:
        sql="select * from reservations where custName='%s'" % (custName)
        cursor = db.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        for row in results:
            resvType=row['resvType']
            resvKey=row['resvKey']
        sql="select * from cars where type='%s'" %(resvKey)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        for row in results:
            fromCity=row['location']
        sql="select * from hotels where name='%s'" %(resvType)
        cursor.execute(sql)
        results=cursor.fetchallDict()
        for row in results:
            availCity=row['location']
        return (fromCity,availCity)
    except:
        db.close()
