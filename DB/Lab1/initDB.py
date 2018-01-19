#!/usr/bin/python
#-*- coding:UTF-8 -*-
import MySQLdb
import config

db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
cursor = db.cursor()

try:
    cursor.execute("insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values ('A1', 100, 30, 1, 'nanjing','shanghai')")
    cursor.execute("insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values ('A2', 200, 30, 2, 'nanjing','beijing')")
    cursor.execute("insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values ('A3', 300, 30, 3, 'nanjing','wuhang')")
    cursor.execute("insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values ('A4', 400, 30, 4, 'nanjing','hanzhou')")
    cursor.execute("insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values ('A5', 500, 30, 5, 'nanjing','guangzhou')")
    cursor.execute("insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values ('A6', 600, 30, 6, 'nanjing','hefei')")
    cursor.execute("insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values ('A7', 700, 30, 7, 'nanjing','tianjing')")
    cursor.execute("insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values ('A8', 800, 30, 8, 'nanjing','shengyang')")
    cursor.execute("insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values ('A9', 900, 30, 9, 'nanjing','changchun')")
    cursor.execute("insert into flights(flightNum,price,numSeats,numAvail,FromCity,ArivCity) values ('A10',1000,30, 10,'nanjing','haerbing')")
    db.commit()

    cursor.execute("insert into hotels(name,location,price,numRooms,numAvail) values ('H1','nanjing',100, 10, 1)")
    cursor.execute("insert into hotels(name,location,price,numRooms,numAvail) values ('H2','shanghai',100, 10, 2)")
    cursor.execute("insert into hotels(name,location,price,numRooms,numAvail) values ('H3','hanzhou',100, 10, 3)")
    cursor.execute("insert into hotels(name,location,price,numRooms,numAvail) values ('H4','beijing',100, 10, 4)")
    cursor.execute("insert into hotels(name,location,price,numRooms,numAvail) values ('H5','wuhang',100, 10, 5)")
    cursor.execute("insert into hotels(name,location,price,numRooms,numAvail) values ('H6','tianjing',100, 10, 6)")
    cursor.execute("insert into hotels(name,location,price,numRooms,numAvail) values ('H7','hefei',100, 10, 7)")
    cursor.execute("insert into hotels(name,location,price,numRooms,numAvail) values ('H8','shengyang',100, 10, 8)")
    cursor.execute("insert into hotels(name,location,price,numRooms,numAvail) values ('H9','changchun',100, 10, 9)")
    cursor.execute("insert into hotels(name,location,price,numRooms,numAvail) values ('H10','haerbing',100, 10, 10)")
    db.commit()

    cursor.execute("insert into cars(type,location,price,numCars,numAvail) values ('C1','nanjing',100, 10, 1)")
    cursor.execute("insert into cars(type,location,price,numCars,numAvail) values ('C2','shanghai',100, 10, 2)")
    cursor.execute("insert into cars(type,location,price,numCars,numAvail) values ('C3','hanzhou',100, 10, 3)")
    cursor.execute("insert into cars(type,location,price,numCars,numAvail) values ('C4','beijing',100, 10, 4)")
    cursor.execute("insert into cars(type,location,price,numCars,numAvail) values ('C5','wuhang',100, 10, 5)")
    cursor.execute("insert into cars(type,location,price,numCars,numAvail) values ('C6','tianjing',100, 10, 6)")
    cursor.execute("insert into cars(type,location,price,numCars,numAvail) values ('C7','hefei',100, 10, 7)")
    cursor.execute("insert into cars(type,location,price,numCars,numAvail) values ('C8','shengyang',100, 10, 8)")
    cursor.execute("insert into cars(type,location,price,numCars,numAvail) values ('C9','changchun',100, 10, 9)")
    cursor.execute("insert into cars(type,location,price,numCars,numAvail) values ('C10','haerbing',100, 10, 10)")
    db.commit()

    cursor.execute("insert into customers(custName) values ('P1')")
    cursor.execute("insert into customers(custName) values ('P2')")
    cursor.execute("insert into customers(custName) values ('p3')")
    cursor.execute("insert into customers(custName) values ('p4')")
    cursor.execute("insert into customers(custName) values ('p5')")
    cursor.execute("insert into customers(custName) values ('p6')")
    cursor.execute("insert into customers(custName) values ('p7')")
    cursor.execute("insert into customers(custName) values ('p8')")
    cursor.execute("insert into customers(custName) values ('p9')")
    cursor.execute("insert into customers(custName) values ('p10')")
    db.commit()
    
    cursor.execute("insert into reservations(custName,resvType,resvKey) values ('p1','H1','C1')")
    cursor.execute("insert into reservations(custName,resvType,resvKey) values ('p2','H2','C2')")
    cursor.execute("insert into reservations(custName,resvType,resvKey) values ('p3','H3','C3')")
    cursor.execute("insert into reservations(custName,resvType,resvKey) values ('p4','H4','C4')")
    cursor.execute("insert into reservations(custName,resvType,resvKey) values ('p5','H5','C5')")
    cursor.execute("insert into reservations(custName,resvType,resvKey) values ('p6','H6','C6')")
    cursor.execute("insert into reservations(custName,resvType,resvKey) values ('p7','H7','C7')")
    cursor.execute("insert into reservations(custName,resvType,resvKey) values ('p8','H8','C8')")
    cursor.execute("insert into reservations(custName,resvType,resvKey) values ('p9','H9','C9')")
    cursor.execute("insert into reservations(custName,resvType,resvKey) values ('p10','H10','C10')")
    db.commit()
except:
    db.rollback()
db.close()