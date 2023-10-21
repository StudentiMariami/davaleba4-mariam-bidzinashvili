using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba4
{
    /*    
     შექმენით საბაზო კლასი, რომელიც შეიცავს სამკუთხედის გვერდებს.ერთი
    გვერდი არის ღია, მეორე და მესამე დაცული. შექმენით სამკუთხედის მემკვიდრე
    კლასი, რომელიც დამატებით შეიცავს პრივატულ ცვლადებს - სამკუთხედის
    პერიმეტრს და ფართობს; ასევე ორ ღია მეთოდს.პირველი მეთოდი გამოთვლის
    და აბრუნებს სამკუთხედის ფართობს. მეორე მეთოდი გამოთვლის და გასცემს
    სამკუთხედის პერიმეტრს.მთავარ პროგრამაში შექმენით მემკვიდრე კლასის
    ტიპის მქონე ობიექტი და გამოიძახეთ ორივე მეთოდი.*/

    class samkutxedi
    {
        public int gverdi1;
        protected int gverdi2, gverdi3;
    }
    class memkvidre : samkutxedi
    {
        private int perimetri, fartobi;
        public memkvidre(int par2,int par3)
        {
            gverdi2 = par2;
            gverdi3 = par3;
        }
        public int metodi_1()
        {
            perimetri = gverdi1 + gverdi2 + gverdi3;
            return perimetri;
        }
        public int metodi_2()
        {
            fartobi = (gverdi1 * gverdi2) / 2;
            return fartobi;
        }
    }
}

