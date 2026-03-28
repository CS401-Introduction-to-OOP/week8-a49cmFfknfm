using Week8;

DeliveryItem l1 = new Letter("24", 2);
DeliveryItem l2 = new Letter("354", 3);
DeliveryItem p1 = new Parcel("924", 43, "24x35x5");
DeliveryItem p2 = new Parcel("24566", 26, "24x35x5");
l1.PrintInfo();
CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
myCargo.AddItem(l1);
myCargo.AddItem(l2);
myCargo.AddItem(p2);
myCargo.AddItem(p1);

Console.Write(myCargo.GetTotalCost());