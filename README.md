# Epidemic_Regression_Model
Neural network model based on an epidemic simulation, with the aim of finding the parameters to stem an epidemic
https://youtu.be/sXSPE1favXY

![Screenshot](https://github.com/EbonGit/Epidemic_Regression_Model/blob/main/Image/Simulation_2.PNG)

## Table of Contents
+ [About](#About)
+ [Folders](#Folders)
  + [Unity Project](#UnityProject)
  + [Database](#Database)
  + [Model](#Model)
+ [Installation](#Installation)

# About
This project utilizing a genetic algorithm and regression model to predict the number of infected individuals in a population. The algorithm takes into account various parameters such as the number of individuals who can cross, the percentage vaccinated, the percentage of individuals respecting quarantine, and the time of quarantine and travel. The results of the algorithm are then visualized and analyzed.

# Folders

### UnityProject
The whole project under unity

Doc -> https://docs.unity3d.com/Manual/index.html

### Model
All the models used in the project for each parameter are in .h5 format.

![Screenshot](https://github.com/EbonGit/Epidemic_Regression_Model/blob/main/Image/Netron_1.PNG)

### Database
The set of databases for each parameter, all parameters are fixed except for the parameter treated by this database.

| Infected | Number | %Infected | %Quarantine | Infection Rate | Infection Time | Quarantine Time | Travel Time |
|----------|--------|-----------|-------------|----------------|----------------|-----------------|-------------|
|    81    |   104  |    0.2    |      0      |       0.7      |        4       |        1        |     100     |
|    ...   |   ...  |    ...    |     ...     |       ...      |       ...      |       ...       |     ...     |
|          |        |           |             |                |                |                 |             |

And all .pdf results from Google Colab for each parameters :

![Screenshot](https://github.com/EbonGit/Epidemic_Regression_Model/blob/main/Image/Capture.PNG)


# Installation

To reuse the project:

You can build the entire Unity project to get the simulation executable, and then use the code in [GenerateData.py](https://github.com/EbonGit/Epidemic_Regression_Model/blob/main/GenerateData.py) to create a database for each of the parameters. Finally, train the neural networks with [Epidemic_Regression_Model.ipynb](https://github.com/EbonGit/Epidemic_Regression_Model/blob/main/Epidemic_Regression_Model.ipynb).

Or you can directly use the models [here](https://github.com/EbonGit/Epidemic_Regression_Model/tree/main/Model).

To finally use the genetic algorithm in [Genetic_Algo.ipynb](https://github.com/EbonGit/Epidemic_Regression_Model/blob/main/Genetic_Algo.ipynb) in order to obtain the results

![Screenshot](https://github.com/EbonGit/Epidemic_Regression_Model/blob/main/Image/algo_gen.png)

Enjoy! 

