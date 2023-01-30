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

### Database

### Model
The set of databases for each parameter, all parameters are fixed except for the parameter treated by this database.

| Infected | Number | %Infected | %Quarantine | Infection Rate | Infection Time | Quarantine Time | Travel Time |
|----------|--------|-----------|-------------|----------------|----------------|-----------------|-------------|
|    81    |   104  |    0.2    |      0      |       0.7      |        4       |        1        |     100     |
|    ...   |   ...  |    ...    |     ...     |       ...      |       ...      |       ...       |     ...     |
|          |        |           |             |                |                |                 |             |

And all .pdf results from Google Colab for each parameters :

![Screenshot](https://github.com/EbonGit/Epidemic_Regression_Model/blob/main/Image/Capture.PNG)


# Installation

