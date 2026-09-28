using System;
using System.Collections.Generic;
using System.Text;

namespace cegapp
{
    public class Menedzser : Alkalmazott
    {
        public int Bonusz { get; set; }
        public Menedzser(string nev, int alapber, int bonusz) : base(nev, alapber)
        {
            Bonusz = bonusz;
        }
        public override int FizetesSzamitas()
        {
            return Alapber + Bonusz;
        }
    }
}
