using VisitorPattern;

City village = new();
village.Add(new Proprietorship());
village.Add(new Llc());

village.Accept(new TaxOfficer());