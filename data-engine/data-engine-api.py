#!/usr/bin/env python
# coding: utf-8

# In[ ]:

from flask import Flask, jsonify  # From module flask import class Flask

import tensorflow

app = Flask(__name__)    # Construct an instance of Flask class for our webapp

@app.route('/', methods=['GET'])   # URL '/' to be handled by main() route handler
def main():
    return jsonify(
        {
            "user" : "admin",
            "pass" : "admin"
        })

@app.route('/city', methods=['GET'])   # URL '/' to be handled by main() route handler
def GetCity():
    return jsonify(
        {
            "id" : "1",
            "name" : "Nagpur"
        },
          {
            "id" : "2",
            "name" : "Mumbai"
        },
    )

if __name__ == '__main__':  # Script executed directly?
    app.run(host='0.0.0.0')  # Launch built-in web server and run this Flask webapp


# In[ ]:
