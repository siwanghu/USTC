#!/usr/bin/python
# -*- coding: UTF-8 -*-
import os
import handleDB

clean="clear"     #如果是在windows上运行，请改为clean="cls"
flag=True

menu_ui='''-------------欢迎使用旅游预订系统----------------------------       
                                         SA17225123 胡思旺
                    （插入数据必须要管理员权限）
        p.注册
        q.退出
        a.查询航班
        b.查询出租车
        c.查询宾馆房间
        d.查询预订信息
        e.查询旅行线路
        f.预定航班
        g.预定出租车
        h.预定宾馆房间
        j.查询客户'''


def main():
    os.system(clean)
    while(flag):
        global flag
        print(menu_ui)
        operate=raw_input("请输入操作符:")
        if 'p' in operate:
            os.system(clean)
            name=raw_input("请输入用户名：")
            handleDB.insertCustomers(name)
            print("注册成功")
            raw_input()
            os.system(clean)
            print(menu_ui)
        if 'q' in operate:
            os.system(clean)
            print("系统退出成功！")
            flag=False
        if 'a' in operate:
            os.system(clean)
            result = handleDB.selectFlights()
            for row in result:
                for key in row:
                    print(key," = ",row[key])
                print("----------------------------------------")
            raw_input("按回车键退出！")
            os.system(clean)
            print(menu_ui)
        if 'b' in operate:
            os.system(clean)
            result = handleDB.selectCars()
            for row in result:
                for key in row:
                    print(key," = ",row[key])
                print("----------------------------------------")
            raw_input("按回车键退出！")
            os.system(clean)
            print(menu_ui)
        if 'c' in operate:
            os.system(clean)
            result = handleDB.selectHotels()
            for row in result:
                for key in row:
                    print(key," = ",row[key])
                print("----------------------------------------")
            raw_input("按回车键退出！")
            os.system(clean)
            print(menu_ui)
        if 'd' in operate:
            os.system(clean)
            result = handleDB.selectReservations()
            for row in result:
                for key in row:
                    print(key," = ",row[key])
                print("----------------------------------------")
            raw_input("按回车键退出！")
            os.system(clean)
            print(menu_ui)
        if 'e' in operate:
            os.system(clean)
            name=raw_input("请输入用户名:")
            try:
                result=handleDB.searchCustomer(name)
                print("%s ---------> %s"%(result[0],result[1]))
                raw_input("按回车键退出！")
                os.system(clean)
                print(menu_ui)
            except:
                print("没有查到！")
                raw_input("按回车键退出！")
                os.system(clean)
                print(menu_ui)
        if 'f' in operate:
            os.system(clean)
            name=raw_input("请输入预定的航班名:")
            try:
                if(handleDB.reserveFlights(name)==True):
                    raw_input("预定成功,按回车键退出！")
                    os.system(clean)
                    print(menu_ui)
                else:
                    raw_input("预定失败,按回车键退出！")
                    os.system(clean)
                    print(menu_ui)
            except:
                raw_input("预定失败,按回车键退出！")
                os.system(clean)
                print(menu_ui)
        if 'g' in operate:
            os.system(clean)
            name=raw_input("请输入用户名:")
            type_s=raw_input("请输入预定出租车的类型:")
            try:
                if(handleDB.reserveCars(name,type_s)==True):
                    raw_input("预定成功,按回车键退出！")
                    os.system(clean)
                    print(menu_ui)
                else:
                    raw_input("预定失败,按回车键退出！")
                    os.system(clean)
                    print(menu_ui)
            except:
                raw_input("预定失败,按回车键退出！")
                os.system(clean)
                print(menu_ui)
        if 'h' in operate:
            os.system(clean)
            name=raw_input("请输入用户名:")
            type_s=raw_input("请输入预定宾馆名:")
            try:
                if(handleDB.reserveHotels(name,type_s)==True):
                    raw_input("预定成功,按回车键退出！")
                    os.system(clean)
                    print(menu_ui)
                else:
                    raw_input("预定失败,按回车键退出！")
                    os.system(clean)
                    print(menu_ui)
            except:
                raw_input("预定失败,按回车键退出！")
                os.system(clean)
                print(menu_ui)
        if 'j' in operate:
            os.system(clean)
            result = handleDB.selectCustomers()
            for row in result:
                for key in row:
                    print(key," = ",row[key])
            raw_input("按回车键退出！")
            os.system(clean)
            print(menu_ui)

if __name__=="__main__":
    main()
