CarDealer dealer = new();
Consumer sebastiam = new ("Sebastian");
dealer.NewCarCreated += sebastiam.NewCarIsHere;
dealer.CreateANewCar("Williams");

Consumer max = new("Max");
dealer.NewCarCreated += max.NewCarIsHere;
dealer.CreateANewCar("Aston Martin");
dealer.NewCarCreated -= sebastiam.NewCarIsHere;
dealer.CreateANewCar("Ferrari");