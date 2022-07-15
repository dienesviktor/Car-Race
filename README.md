# Car-Race

Car race simulation in C#, with random weather conditions, using inheritance and composition.

We cannot set vehicles speed from the outside, since the speed setting logic is encapsulated into the vehicle classes.

### Description

1. The race itself, 10 cars, 10 trucks, and 10 motorcycles are created in the main method.
2. The race object store all the racers, and also allow the user to register them from outside. One race lasts 50 hours.
3. There is an option to check the weather during the current hour of the race and set a new random weather for the next hour.
4. Cars have imaginative names. Cars need to be careful and slow down when there is a broken truck on the race tracks.
5. Motorcycles are pretty fast but making turns in rain is dangerous, so they have to slow down in bad weather conditions. They do not care about broken down trucks.
6. Trucks are real powerhouses but their intricate engines are prone to failure. When they break down, they have to stop for a while to repair the engine.
7. The actual speed of a vehicle sometimes depends on the state of other vehicles or on contextual features, such as the weather.

### Instruction:

To start:
```
Open the CarRace.sln in Visual Studio then press Ctrl+F5 or select the green Start button from the top menu.
```
