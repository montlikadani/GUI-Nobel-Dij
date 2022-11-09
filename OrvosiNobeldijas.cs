namespace NobelDij {

    internal class OrvosiNobeldijas {

        public readonly int Ev, Szuletes, Halalozas = -1;
        public readonly string Nev, OrszagKod;

        public OrvosiNobeldijas(int ev, string nev, string szuletesHalalozas, string orszagKod) {
            Ev = ev;
            Nev = nev;
            OrszagKod = orszagKod;

            string[] split = szuletesHalalozas.Split('-');
            Szuletes = int.Parse(split[0]);

            if (split.Length != 1) {
                string sec = split[1];

                if (sec.Length != 0) {
                    Halalozas = int.Parse(sec);
                }
            }
        }
    }
}
