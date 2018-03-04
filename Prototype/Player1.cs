using System;

namespace Prototype
{
    public class Player1 : Player
    {
        /* 
        Clone -> da imame edin originalen obekt 
        i po nqkakav nachin da sazdadem obekt s
        absolutno sashtite stoinosti na negovite 
        property-ta. Obektite sa 2 razlichni no kato
        stoinostite na property-ta sa ednakvi.
        Instanciq 1 igrach v momenta, koito prodaljava da igrae
        no v nqkakav moment natiska Control + S nie sazdavame
        edin obekt 2, koito e sashtiq kato nego i puskame zapisa
        da se osashtestvqva asyncronno nqkade s dannite na clonitaneto. 
        */
        public override Player Clone()
        {
            /* tai kato MemberwiseClone vrashta nqkakav 
            obekt nie trqbva da go castnem do tipa, koito ochakva
            da varne
            1.as Player
            2.otpred (Player)
            */
            return this.MemberwiseClone() as Player;
            /*
             obekti, koito sa v obekta po trudno mogat
             da budat prototipirani(clonirani). 
             trqbva da zapazqt 
             parvonachalnata informaciq deep copy.
             inache se poluchava swallow copy.
            */
        }
    }
}
