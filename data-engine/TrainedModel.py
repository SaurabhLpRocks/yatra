#!/usr/bin/env python
# coding: utf-8

# In[1]:


import json
import tensorflow as tf
import numpy as np


# In[2]:


with open('parameters.json') as f:
    param = json.load(f)


# In[4]:


n_nodes_hl1 = 50
n_nodes_hl2 = 50
n_nodes_hl3 = 60
n_output = 2


# In[7]:


x = tf.placeholder('float')
y = tf.placeholder('float')

hidden_1_layer = {'f_fum':n_nodes_hl1,
                  'weight':tf.Variable(param['hidden_1_layer']['weight']),
                  'bias':tf.Variable(param['hidden_1_layer']['bias'])}

hidden_2_layer = {'f_fum':n_nodes_hl2,
                  'weight':tf.Variable(param['hidden_2_layer']['weight']),
                  'bias':tf.Variable(param['hidden_2_layer']['bias'])}

hidden_3_layer = {'f_fum':n_nodes_hl3,
                  'weight':tf.Variable(param['hidden_3_layer']['weight']),
                  'bias':tf.Variable(param['hidden_3_layer']['bias'])}
output_layer = {'f_fum':None,
                'weight':tf.Variable(param['output_layer']['weight']),
                'bias':tf.Variable(param['output_layer']['bias'])}


# In[21]:


# Nothing changes
def neural_network_model(data):

    l1 = tf.add(tf.matmul(data,hidden_1_layer['weight']), hidden_1_layer['bias'])
    l1 = tf.nn.tanh(l1)

    l2 = tf.add(tf.matmul(l1,hidden_2_layer['weight']), hidden_2_layer['bias'])
    l2 = tf.nn.tanh(l2)

    l3 = tf.add(tf.matmul(l2,hidden_3_layer['weight']), hidden_3_layer['bias'])
    l3 = tf.nn.tanh(l3)
    
    output = tf.add(tf.matmul(l3,output_layer['weight']), output_layer['bias'])
    
    with tf.Session() as sess:
        sess.run(tf.global_variables_initializer())
        op = sess.run(output)

    return op


# In[22]:


def predict(trainType, isHoliday, seatsVacant, delay, arrival):
    return neural_network_model([[trainType, isHoliday, seatsVacant, delay, arrival]])


# In[ ]:




