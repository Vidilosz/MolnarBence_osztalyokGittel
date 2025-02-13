using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyak
{
	internal class KemKuldetes
	{
		private string kodnev;
		private string orszag;
		private int veszelySzint;
		private int sikerEsely;

		public string Kodnev { get => kodnev; set => kodnev = value; }
		public string Orszag { get => orszag; set => orszag = value; }
		public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
		public int SikerEsely { get => sikerEsely; set => sikerEsely = value; }

		public KemKuldetes(string kodnev, string orszag, int veszelySzint, int sikerEsely)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = veszelySzint;
			this.sikerEsely = sikerEsely;
		}

		public KemKuldetes(string kodnev, string orszag)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			veszelySzint = 5;
			sikerEsely = 50;
		}

		public string KuldetesInditasa()
		{
			return $"A küldetés elkezdődött.";
		}

		public void VeszelySzintNoveles()
		{
			veszelySzint += 1;
		}

		public void SikerEsejNovelese()
		{
			sikerEsely += 1;
		}

		public override string? ToString()
		{
			return $"{kodnev}-{orszag}-{veszelySzint}-{sikerEsely}%";
		}
	}
}
