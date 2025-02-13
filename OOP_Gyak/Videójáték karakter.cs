﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyak
{
	internal class Videójáték_karakter
	{
		private string nev;
		private int szint;
		private int eletero;
		private int ero;

		public string Nev { get => nev; set => nev = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }

		public Videójáték_karakter(string nev, int szint, int eletero, int ero)
		{
			this.nev = nev;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}

		public Videójáték_karakter(string nev, int ero)
		{
			this.nev = nev;
			this.ero = ero;
			szint = 1;
			eletero = 100;
		}

		public string Tamadas()
		{
			return $"{this.nev} támad, {this.ero} erővel";
		}

		public void Gyogyulas(int mennyiseg)
		{
			eletero += mennyiseg;
		}

		public void Szintlepes()
		{
			szint += 1;
			ero += 1;
		}

		public override string? ToString()
		{
			return $"{nev} - {szint} - {eletero} - {ero}";
		}
	}
}
