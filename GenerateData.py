import csv
with open('D:/Fichier/TIPE/Assets/data.csv', newline='') as csvfile:
     spamreader = csv.reader(csvfile, delimiter=';', quotechar='|')
     for row in spamreader:
         print('; '.join(row))



##


import csv
import random
def ekip():
     nbr = random.randint(10, 250)
     prcVaccin = round(random.uniform(0, 1),2)
     prcQuarantaine = round(random.uniform(0, 1-prcVaccin),2)
     txInfection = round(random.uniform(0, 1),2)
     tempsInfection = random.randint(2,20)
     tempsQuarantaine = random.randint(0,tempsInfection-1)
     tempsVoyage = round(random.uniform(0, 20),2)

     with open('D:/Fichier/build/TIPE_Data/data.csv', 'w', newline='') as file:
          writer = csv.writer(file)
          writer.writerow([nbr, prcVaccin, prcQuarantaine,txInfection, tempsInfection,tempsQuarantaine,tempsVoyage])

     with open('D:/Fichier/build/TIPE_Data/data.csv', newline='') as csvfile:
          spamreader = csv.reader(csvfile, delimiter=';', quotechar='|')
          for row in spamreader:
               print('; '.join(row))


##
import os
os.startfile("D:/Fichier/build/TIPE.exe")





##
import os
os.system("TASKKILL /F /IM TIPE.exe")
##Program csv
import os
def AddDataCSV(nbrRun,iteration):
     for i in range(nbrRun):

          nbr = random.randint(10, 250)
          prcVaccin = round(random.uniform(0, 1),2)
          prcQuarantaine = round(random.uniform(0, 1-prcVaccin),2)
          txInfection = round(random.uniform(0, 1),2)
          tempsInfection = random.randint(2,20)
          tempsQuarantaine = random.randint(0,tempsInfection-1)
          tempsVoyage = random.randint(0,50)

          for j in range(iteration):
               os.startfile("C:\Documents and Settings\flow_model\flow.exe")

##click
from pynput.keyboard import Key, Controller
import time

import csv
import random
def ekip():

     nbr = random.randint(20, 250)
     prcVaccin = round(random.uniform(0, 1),2)
     prcQuarantaine = round(random.uniform(0, 1-prcVaccin),2)
     txInfection = round(random.uniform(0, 1),2)
     tempsInfection = random.randint(2,20)
     tempsQuarantaine = random.randint(0,tempsInfection-1)
     tempsVoyage = round(random.uniform(0, 20),2)

     with open('D:/Fichier/build/TIPE_Data/data.csv', 'w', newline='') as file:
          writer = csv.writer(file)
          writer.writerow([nbr, prcVaccin, prcQuarantaine,txInfection, tempsInfection,tempsQuarantaine,tempsVoyage])

     with open('D:/Fichier/build/TIPE_Data/data.csv', newline='') as csvfile:
          spamreader = csv.reader(csvfile, delimiter=';', quotechar='|')
          for row in spamreader:
               print('; '.join(row))

ekip()


a = 0

while True:

     l = []
     with open('D:/Fichier/build/TIPE_Data/log.csv', newline='') as csvfile:
          spamreader = csv.reader(csvfile, delimiter=';', quotechar='|')
          for row in spamreader:
               l.append(row)


     n = len(l)

     if (a != n):
          a = n
          keyboard = Controller()
          key = "r"
          ekip()
          keyboard.press(key)
          keyboard.release(key)
          time.sleep(3)



##
import csv

with open('D:/Fichier/build/TIPE_Data/log.csv', newline='') as csvfile:
     spamreader = csv.reader(csvfile, delimiter=';', quotechar='|')
     for row in spamreader:
          print('; '.join(row))





