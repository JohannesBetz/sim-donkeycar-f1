# Donkey Sim - F1 Edition!

Self Driving Car Sandbox


### INCLUDED TRACKS

- Nurburgring GP Circuit
- Monaco GP Ciruit
- Marina Bay Circuit
- Autodromo Algarve GP Circuit
- Circuit of Americas GP Circuit
- Circuit de Spa-Francorchamps
- Albert Park GP Circuit
- Shanghai GP Circuit
- Extra: Sydney Motorsport Park Brabham Circuit
- Extra: Baby Circuit (Mario Cart)
- Extra: Robotics Masters CHALLANGE Track
- Extra: Robotics Masters RACE Track


## Setup

You need to have [Unity](https://unity3d.com/get-unity/download) installed, and all python modules listed in the Requirements section below.

Linix Unity install [here](https://forum.unity3d.com/threads/unity-on-linux-release-notes-and-known-issues.350256/). Check last post in this thread.

You need python 3.4 or higher, 64 bit. You can create a virtual env if you like:
```bash
virtualenv -p python3 env
source env/bin/activate
```

And then you can install the dependancies. This installs a specific version of keras only because it will allow you to load the pre-trained model with fewer problems. If not an issue for you, you can install the latest keras.
```bash
pip install -r requirements.txt
```

This will install [Donkey Gym](https://github.com/tawnkramer/donkey_gym) and [Donkey Car](https://github.com/tawnkramer/donkey) packages from source.

Note: Tensorflow >= 1.10.1 is required

If you have an cuda supported GPU - probably NVidia
```bash
pip install tensorflow-gpu
```

Or without a supported gpu
```bash
pip install tensorflow
```



## Requirements
* [python 3.5+ 64 bit](https://www.python.org/)*
* [tensorflow-1.10+](https://github.com/tensorflow/tensorflow)
* [h5py](http://www.h5py.org/)  
* [pillow](https://python-pillow.org/)  
* [pygame](https://pypi.python.org/pypi/Pygame)**  
* [Unity 2018.+](https://unity3d.com/get-unity/download)  



## Credits

Tawn Kramer  
Maximellerbach
Sydney University Capstone 2020 Students (@robotics-masters)
