#!/usr/bin/env python
# coding: utf-8

# In[ ]:

from flask import Flask, jsonify  # From module flask import class Flask

import tensorflow

# from TrainedModel import predict

app = Flask(__name__)    # Construct an instance of Flask class for our webapp


# URL '/' to be handled by main() route handler
@app.route('/', methods=['GET'])
def main():
    return jsonify(
        {
            "user": "admin",
            "pass": "admin"
        })


# URL '/' to be handled by main() route handler
@app.route('/city', methods=['GET'])
def GetCity():
    return jsonify(
        {
            "id": "1",
            "name": "Nagpur"
        },
        {
            "id": "2",
            "name": "Mumbai"
        },
    )


if __name__ == '__main__':  # Script executed directly?
    # Launch built-in web server and run this Flask webapp
    app.run(host='0.0.0.0')


# In[ ]:
