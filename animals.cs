// 3 different genius (or more the idea is to have 15 species / animals total)

class Animal {
	public string AnimalName {get; set;}
	public bool IsMale{get;set;}
}

// 1. Genus
class Panthera: Animal {
	public string GenusName {get; set;}
	public bool HasStripes {get; set;}
	public bool NoisePurr {get; set;}
}

// 1. Species from Panthera Leo = Lion
class Leo: Panthera {
	public int ManeLength {get; set;} 
	public string Color { get; set; }
	public string FoodType {get; set;}
	public Leo () {
		HasStripes = false;

		
	}
}

Leo leo = new Leo;
leo.GenusName = "Lion";



Console.Write(Leo.GenusName);



// 2. Species from Panthera Onca = Jaguar
class Onca: Panthera 
{
	public bool spotColor {get; set;}
	public int Weight {get; set;}
	public string FoodType {get; set;}
}

// 3. Species from Panthera Pardus = Leopard
class Pardus: Panthera 
{
	public string scaleColor { get; set; }
	public int Weight {get; set;}
	public int Length {get; set;}
}
// 4. Species from Panthera = Tiger
class Tigris: Panthera 
{
	public string scaleColor { get; set; }
	public string Habitat { get; set; }
	public int Length {get; set;}
}
// 5. Species from Panthera Uncia = Snow leopard
class Uncia: Panthera 
{
	public string scaleColor { get; set; }
	public string Habitat { get; set; }
	public int Weight {get; set;}
	public int Length {get; set;}
}



// 2. Genus
class Felis: Animal {
	public bool IsSmall {get; set;}
	public string FoodType {get; set;}
}
// 1. Species from Felis Bieti = Chinese Mountain Cat
class Bieti: Felis {
	public string scaleColor { get; set; }
	public int Weight {get; set;}
	public int Length {get; set;}
}
// 2. Species from Felis Catus = domestic cat
class Catus: Felis {
	public string scaleColor { get; set; }
}
// 3. Species from Felis Chaus =  jungle cat
class Chaus: Felis {
	public string scaleColor { get; set; }
}
// 4. Species from Felis Margarita = sand cat
class Margarita: Felis {
	public string scaleColor { get; set; }
}
// 5. Species from Felis Nigripes = black-footed cat
class Nigripes: Felis {
	public string scaleColor { get; set; }
}


// 3. Genus
class Canis: Animal {
	
}
// 1. Species from Canis side-striped jackal
class Adustus: Canis {
	public string scaleColor { get; set; }
}
// 2. Species from Canis African golden wolf
class Anthus: Canis {
	public string scaleColor { get; set; }
}
// 3. Species from Canis golden jackal
class Aureus: Canis {
	public string scaleColor { get; set; }
}
// 4. Species from Canis coyote
class Latrans: Canis {
	public string scaleColor { get; set; }
}
// 5. Species from Canis grey wolf and domestic dog 
class Lupus: Canis {
	public string scaleColor { get; set; }
}




