using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyak
{
	internal class Film
	{
		private string cim;
		private string rendezo;
		private int hosszPercekben;
		private string mufaj;
		private bool megjelent;


		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Megjelent { get => megjelent; set => megjelent = value; }

		public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = hosszPercekben;
			this.mufaj = mufaj;
			this.megjelent = megjelent;
		}

		public Film(string cim, string rendezo)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			hosszPercekben = 120;
			mufaj = "Ismeretlen";
			megjelent=false;
		}

		public string Megjelenes()
		{
			if (megjelent == true)
			{
				return "Megjelent";
			}
			else
			{
				return "Még nem jelent meg";
			}
		}

		public string Jatszas()
		{
			return $"A(z) {this.cim} elkezdődött.";
		}

		public void MufajModositas(string ujMufaj)
		{
			mufaj=ujMufaj;
		}

		public void HosszNovelese(int percek)
		{
			hosszPercekben += percek;
		}

		public override string? ToString()
		{
			return $"{cim} - {rendezo} / {HosszPercekben} / {mufaj} / {Megjelenes()}";
		}
	}
}
