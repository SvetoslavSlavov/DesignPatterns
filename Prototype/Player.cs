using System;
using System.Text;

namespace Prototype
{
    /* Prototype - sazdavame cloningi na obektite. Taikato
    obektite darjat edna i sashta referenciq kam pametta ako
    gi prisvuim po normalniq nachin s ravenstvo. Zatova imame
    nujda ot shablona sazdavane na kopie chrez izvikvane na
    nqkakav metod. V nachiq sluchai metoda izvikva MemberwiseClone(),
    koito si e vgraden v .net obache MemberwiseClone() ne se griji
    za vutreshnite obekti DeepCopyMethod clonira obekta sazdava
    nova instanciq na vatreshniq mu obekt i vzima stoinostite.
    */
    public abstract class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        /* 
        Metoda, koito shte bade override-nat
        za da moje vseki igrach v igrata da mu
        se sazdava kopie i v posledstvie
        tova kopie da bude zapisvano. 
        V povecheto sluchai zapisvaneto na 
        igrata ne bi trqbvalo da vliq na 
        razvitieto i. Edin takuv save moje 
        da bude asyncronen, a za da bude 
        asyncronen igracha moje da prodalji
        deistviqta si. Saotvetno da vdigne level
        do momenta, v koito vse oshte se osashtestvqva
        zapisvaneto na save.
        */
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name" + this.Name);
            sb.Append("Age:" + this.Age);
            sb.Append("Level" + this.Level);

            return sb.ToString();

        }
        public abstract Player Clone();


    }
}