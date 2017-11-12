# -*- coding: utf-8 -*-
"""
Created on Sun Nov 12 23:02:45 2017

@author: Smith

Из трех данных чисел выбрать наименьшее.
"""

x = float(input("x = "))
y = float(input("y = "))
z = float(input("z = "))

if x < y:
    if x < z:
        print(x)
    else:
        print(z)
else:
    if y < z:
        print(y)
    else:
        print(z)
