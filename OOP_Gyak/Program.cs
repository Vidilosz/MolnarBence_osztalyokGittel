namespace OOP_Gyak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Konyv konyv1 = new("A Kis Herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
			Konyv konyv2 = new("Ez még készül", "Én");

            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			konyv1.Kedvezmeny(20);
			
			konyv1.Arnoveles(500);

			Console.WriteLine( "\n" + konyv1.ToString() + "\n" + konyv1.HanyOldalMaradt(20));



			Film film1 = new("Star Wars", "George Lucas", 150, "Sci-Fi", true);
			Film film2 = new("Bombaclad", "Vidilosz Ginos");

			film1.MufajModositas("Fantasy");

			film1.HosszNovelese(30);

			Console.WriteLine("\n" + film1.ToString() + "\n" + film1.Jatszas());



			Videójáték_karakter kar1 = new("Johnny", 10, 100, 20);
			Videójáték_karakter kar2 = new("Baiken", 30);

			kar1.Gyogyulas(15);
			kar1.Szintlepes();

			Console.WriteLine("\n" + kar1.ToString() + "\n" + kar2.ToString());



			Urhajo urhajo1 = new("Apollo", 200, 3, 87);
			Urhajo urhajo2 = new("Apollon",4);

			urhajo1.Indulas();
			//urhajo1.Landolas();
			//urhajo1.Tankolas(10);

            Console.WriteLine("\n" + urhajo1.ToString() + "\n" + urhajo2.ToString());



			KemKuldetes kuldetes1 = new("pruksz", "Mongólia", 4, 60);
			KemKuldetes kuldetes2 = new("Tutel", "Bindzsisztán");

			kuldetes1.VeszelySzintNoveles();
			kuldetes1.SikerEsejNovelese();

            Console.WriteLine("\n"+ kuldetes1.KuldetesInditasa()+ "\n" + kuldetes1.ToString() + "\n" + kuldetes2.ToString());
        }
	}
}
