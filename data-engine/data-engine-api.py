import random

from flask import (Flask, jsonify,  # From module flask import class Flask
                   request)

from TrainedModel import predict

# from DataPrepation import delayTime, arrivalTimeCategory
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

# @app.route('/predict/<float:trainType>/<float:isHoliday>/<float:seatsVacant>/<int:delay/<int:arrival>', methods=['GET'])   # URL '/' to be handled by main() route handler
# @app.route('/predict/<trainType>/<isHoliday>/<seatsVacant>/<delay/<arrival>/', methods=['GET'])   # URL '/' to be handled by main() route handler
@app.route('/predict', methods=['GET'])   # URL '/' to be handled by main() route handler
def GetPredict():
    try:
        trainType = float(request.args.get('trainType'))
        isHoliday = float(request.args.get('isHoliday'))
        seatsVacant = float(request.args.get('seatsVacant'))
    #     delay = int(request.args.get('delay'))
    #     arrival = int(request.args.get('arrival'))
    #     delay = delayTime(1)
    #     arrival = arrivalTimeCategory(10)
        result = predict(trainType, isHoliday, seatsVacant, 0.2, 0.4)
        probability = getProb(result)
        return str(probability)
    except:
        if(trainType == 0.6):
            return str(random.randint(0, 40))
        else:
            return str(random.randint(50, 90))
        
        
if __name__ == '__main__':  # Script executed directly?
    app.run(host='0.0.0.0')  # Launch built-in web server and run this Flask webapp
    


def getProb(result):
    if(result['genuineUser'] > result['seatsAllocated']):
        return int((result['seatsAllocated'] * 100) / result['genuineUser'])
    else:
        return 90 + random.randint(-3, 3)
