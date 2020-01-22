'''
ah good old sandbox.py :)
'''

#RPC server stuff

import grpc

import basic_comm_pb2
import basic_comm_pb2_grpc

with grpc.insecure_channel('localhost:50051') as channel:
    stub = basic_comm_pb2_grpc.DataCommStub(channel)
    features = stub.GetFeature(new Empty())

#%%

import tensorflow as tf
from tensorflow import keras

hidden_dim = 128
layer1 = keras.layers.Dense(hidden_dim)
layer2 = keras.layers.Dense(output_dim)
output1 = layer1(inputs)

model = keras.models.Model(inputs = inputs, outputs = output)
model.compile("adam",loss="mse")
model.fit(train_x,train_y)

#%%
n_steps=10
input_dim = 3
output_dim = 1
inputs = keras.layers.Input(shape=(n_steps,input_dim))
hidden_state_dim = 128
layer1 = keras.layers.GRU(hidden_state_dim,return_sequences=True)
layer2 = keras.layers.Dense(output_dim)
output1 = layer1(inputs)
output = layer2(output1)
#%%

model = keras.models.Model(inputs = inputs, outputs = output)
model.compile("adam",loss="mse")
model.fit(train_x,train_y)
