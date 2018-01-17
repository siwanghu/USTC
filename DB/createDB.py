#!/usr/bin/python
#-*- coding:UTF-8 -*-
import MySQLdb
import config

db=MySQLdb.connect(user=config.user,db=config.db,passwd=config.passwd,host=config.host,charset=config.charset)
cursor = db.cursor()

cursor.execute("drop table if exists flights")
sql_flights = """create table flights(
        flightNum varchar(20) primary key,
        price int,
        numSeats int,  
        numAvail int,
        FromCity varchar(20),
        ArivCity varchar(20))"""
cursor.execute(sql_flights)


cursor.execute("drop table if exists hotels")
sql_hotels = """create table hotels(
        name varchar(20) primary key,
        location varchar(20),
        price int,
        numRooms int,
        numAvail int)"""
cursor.execute(sql_hotels)


cursor.execute("drop table if exists cars")
sql_cars = """create table cars(
        type varchar(20) primary key,
        location varchar(20),
        price int,
        numCars int,
        numAvail int)"""
cursor.execute(sql_cars)


cursor.execute("drop table if exists customers")
sql_customers = """create table customers(
        custName varchar(20) primary key)"""
cursor.execute(sql_customers)


cursor.execute("drop table if exists reservations")
sql_reservations = """create table reservations(
        custName varchar(20) primary key,
        resvType varchar(20),
        resvKey varchar(20))"""
cursor.execute(sql_reservations)
db.close()