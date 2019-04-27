FROM tensorflow/tensorflow:1.13.1

# $ docker run -v $(pwd)/server:/app -it -p 5000:5000 tensorflow/tensorflow:1.1.0
WORKDIR /usr/src/app

COPY data-engine-api.py data-engine-api.py
# install flask
RUN pip install flask

# install packages used inside container (optional)
RUN apt-get update
RUN apt-get -y install zsh vim
EXPOSE 80
EXPOSE 5000
CMD [ "python", "data-engine-api.py" ]
