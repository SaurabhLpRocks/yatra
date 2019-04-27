#!/usr/bin/env python
# coding: utf-8

# In[1]:


import enum 
import random
from sklearn import preprocessing


# In[2]:


trainType = {'passenger': 0.2,
    'express': 0.4,
    'superfast': 0.6, 
    'special': 0.8
}


# In[4]:


def delayTime(hrs):
    if(hrs <= 1):
        return 0.2
    elif (hrs <= 4):
        return 0.4
    elif (hrs <= 12):
        return 0.6
    else:
        return 0.8


# In[5]:


def isHoliday(day):
    if (day > 90 and day < 120):
        value = True
    elif ((day > 275 and day< 295) or (day > 300 and day < 302)):
        value = True
    elif ((day > 358 or day < 2)):
        value = True
    else:
        value = False
        
    if(value == True):
        return 0.33
    else:
        return 0.66


# In[6]:


def arrivalTimeCategory(hrs):
    if (hrs < 6 or hrs > 22):
        return 0.2
    elif(hrs < 10 ):
        return 0.4
    elif(hrs < 18):
        return 0.6
    else:
        return 0.8


# In[7]:


trainNames = {'12859' : {'name' : 'Gitanjali Express', 
                        'trainType' : trainType['superfast'],
                        'start' : 12}, 
              '12101': {'name' : 'Jnaneswari Delx', 
                        'trainType' : trainType['superfast'],
                       'start' : 3},
              '12869': {'name' : 'Howrah Superfast', 
                        'trainType' : trainType['superfast'],
                       'start' : 11},
              '12809': {'name' : 'Howrah Mail', 
                        'trainType' : trainType['superfast'],
                       'start' : 20},
              '15611': {'name' : 'Karmabhoomi', 
                        'trainType' : trainType['superfast'],
                       'start' : 11},
              '05611': {'name' : 'Lokmanyatilak Special', 
                        'trainType' : trainType['special'],
                       'start' : 11},
              '12151': {'name' : 'Samarsata', 
                        'trainType' : trainType['express'],
                       'start' : 8},
              '18029': {'name' : 'Shalimar', 
                        'trainType' : trainType['express'],
                     'start' : 21}
             }
           


# In[8]:


def seatVacants(day, trainType):
    minValue = 0
    maxValue = 100
    if isHoliday(day) == 0.33:
        seats =  random.randint(0, 5)
    elif trainType == 0.6:
        seats =  random.randint(0, 50)
    else:
        seats = random.randint(40, 100)
    return (seats - minValue)/maxValue


# In[9]:


def seatFilled (seatVacant):
    if(seatVacant <= 10):
        return random.randint(int(seatVacant * 0.8), int(seatVacant))
    else:
        return random.randint(int(seatVacant * 0.65), int(seatVacant))


# In[13]:


x = []
y = []
noOfUser = 10
for day in range(365):
    noOfUser += random.randint(-2, 2)
    holiday = isHoliday
    for train in trainNames:
        delay = random.randint(0, 2)
        arrivalTime = trainNames[train]['start']
        for stops in range(10):
            seatVacant = seatVacants(day, trainNames[train]['trainType'])
            x.append([trainNames[train]['trainType'], 
                         isHoliday(day), 
                         seatVacant,
                        delayTime(delay + random.uniform(-0.10, 0.10)),
                        arrivalTimeCategory(arrivalTime)
                        ])
            y.append([seatFilled(seatVacant * 100), 
                      noOfUser + random.randint(-(int(noOfUser * 0.35)), int(noOfUser * 0.35))
                     ])
            arrivalTime += random.randint(2, 4)
            if(arrivalTime > 24):
                arrivalTime -= 24


# In[15]:


import json


# In[16]:


values = {'x' : x, 'y': y}


# In[17]:


with open("data.json","w") as f:
    json.dump(values, f)


# In[18]:


import tensorflow as tf


# In[ ]:




