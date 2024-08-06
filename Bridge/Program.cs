using Bridge;

IEngine electricEngine = new ElectricEngine();
IEngine steamEngine = new SteamEngine();

Vehicle electricBoat = new Boat(electricEngine);
Vehicle steamTrain = new Train(steamEngine);
Vehicle electricTrain = new Train(electricEngine);

electricBoat.Drive();
steamTrain.Drive();
electricTrain.Drive();
