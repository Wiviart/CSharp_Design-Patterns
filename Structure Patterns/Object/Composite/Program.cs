CompositeEquipment cabinet = new Cabinet("PC Cabinet");
CompositeEquipment chassis = new Chassis("PC Chassis");
cabinet.Add(chassis);

Equipment bus = new CompositeEquipment("MCA Bus");
bus.Add(new Card("16Mbs Token Ring"));
chassis.Add(bus);
chassis.Add(new FloppyDisk("3.5in Floppy"));

Console.WriteLine("The net price is " + cabinet.NetPrice());
