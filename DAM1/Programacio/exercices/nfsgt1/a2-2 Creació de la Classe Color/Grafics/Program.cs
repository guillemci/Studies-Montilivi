using System.Text;

namespace Grafics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //proves classe color
            Console.WriteLine("proves classe color");

            #region "metodes de validacio"

            #endregion

            #region "constructors"

            //Constructor basic
            Console.WriteLine("Constructor basic");

            //exemples transparencia i array
            Console.WriteLine("exemples transparencia i array");
            Color c1 = new Color([140, 150, 240, 255], true); //exemple de constructor de 4 digits transparencia true
            Console.WriteLine(c1);

            Color c2 = new Color([150, 240, 255], true); //exemple de constructor de 3 digits transparencia true
            Console.WriteLine(c2);

            Color c3 = new Color([150, 240, 255], false); //exemple de constructor de 3 digits transparencia false
            Console.WriteLine(c3);

            Color c4 = new Color([130, 150, 240, 255], false); //exemple de constructor de 4 digits transparencia false
            Console.WriteLine(c4);

            Color cnull = new Color(null); //exemple null
            Console.WriteLine(cnull);

            //exemple profunditat
            Console.WriteLine("exemple profunditat");
            Color c5 = new Color([130, 150, 399, 255], true, 400); //exemple de constructor amb profunditat custom
            Console.WriteLine(c5);

            //exemple ints separats 
            Console.WriteLine("exemple ints separats true");
            Color c6 = new Color(290, 130, 240, 120, true, 300); //true
            Console.WriteLine(c6);

            Console.WriteLine("exemple ints separats false");
            Color c7 = new Color(290, 130, 240, 120, false, 300); //false
            Console.WriteLine(c7);

            //constructors overload
            Console.WriteLine("constructors overload");
            Color c8 = new Color(255, 130, 240, 120, false); //separats profunditat default
            Console.WriteLine(c8);

            Console.WriteLine("valor canal unicament");
            Color c9 = new Color([150, 139, 200, 199]); //valor canal unicament
            Console.WriteLine(c9);

            Console.WriteLine("valor transparencia unicament");
            Color c10 = new Color(true); //valor transparencia unicament
            Console.WriteLine(c10);

            Console.WriteLine("sense valors");
            Color c11 = new Color(); //sense valors
            Console.WriteLine(c11);

            Console.WriteLine("unicament profunditat");
            Color c12 = new Color(50); //unicament profunditat
            Console.WriteLine(c12);

            Console.WriteLine("profunditat i transparencia");
            Color c13 = new Color(true, 256); //profunditat i transparencia
            Console.WriteLine(c13);
            #endregion

            #region "metodes publics"
            Console.WriteLine("desactivem transparencia amb set");
            c1.TeTransparencia = false; //desactivem transparencia amb set
            Console.WriteLine(c1);

            Console.WriteLine("activem transparencia amb set");
            c1.TeTransparencia = true; //desactivem transparencia amb set
            Console.WriteLine(c1);

            Console.WriteLine("get transparencia");
            bool transparenciaC1 = c1.TeTransparencia;
            Console.WriteLine(transparenciaC1);

            Console.WriteLine("profunditatcolor set");
            c13.ProfunditatDeColor = 100; //profunditatcolor set
            Console.WriteLine(c13);

            Console.WriteLine("profunditatcolor get");
            int profunditat = c13.ProfunditatDeColor; //profunditatcolor get
            Console.WriteLine(profunditat);

            Console.WriteLine("get indexador, en cas de transparencia false agafara el valor 1 fent 0 + 1");
            int ValorRandom = c4[2]; //get indexador
            Console.WriteLine(ValorRandom);

            Console.WriteLine("get indexador en cas de transparencia true s'agafa el valor 0 sense fer pasos extras");
            int valorRandom2 = c5[0]; //get indexador
            Console.WriteLine(valorRandom2);
            #endregion

            #region "Objectes prefets de la classe/statics"
            Console.WriteLine("color vermell default");
            Color vermell = Color.Vermell; //color vermell default
            Console.WriteLine(vermell);

            Console.WriteLine("color Verd default");
            Color verd = Color.Verd; //color Verd default
            Console.WriteLine(verd);

            Console.WriteLine("color blau default");
            Color blau = Color.Blau; //color blau default
            Console.WriteLine(blau);

            Console.WriteLine("color negre default");
            Color negre = Color.Negre; //color negre default
            Console.WriteLine(negre);

            Console.WriteLine("color transparent default");
            Color transparent = Color.Transparent; //color transparent default
            Console.WriteLine(transparent);
            #endregion

            #region "metodes de manipulacio"
            Console.WriteLine("metode de manipulacio que funciona igual que el get canal");
            int canal = c8.ObtenCanal(1);
            Console.WriteLine(canal);

            Console.WriteLine("inverteix color seguint formula");
            Color invertit = c8.Inverteix();
            Console.WriteLine(invertit);

            Console.WriteLine("color a escala de grisos");
            Color escalaAGrisos = c8.A_EscalaDeGrisos();
            Console.WriteLine(escalaAGrisos);

            //prova static equals
            Console.WriteLine("prova static equals");
            bool condicioTest;
            Color clonc8 = c8;
            condicioTest = Color.Equals(clonc8, c8); //iguals
            Console.WriteLine(condicioTest);
            condicioTest = Color.Equals(clonc8, c7); //diferents
            Console.WriteLine(condicioTest);
            condicioTest = Color.Equals(null, c7); //diferents i null
            Console.WriteLine(condicioTest);
            condicioTest = Color.Equals(null, null); //iguals nulls
            Console.WriteLine(condicioTest);
            condicioTest = Color.Equals(c7, canal); //diferents objectes
            Console.WriteLine(condicioTest);

            //prova equals
            Console.WriteLine("prova equals");
            condicioTest = c8.Equals(clonc8); //iguals
            Console.WriteLine(condicioTest);
            condicioTest = c8.Equals(c7); //diferents
            Console.WriteLine(condicioTest);
            condicioTest = c8.Equals(null); //diferents null
            Console.WriteLine(condicioTest);
            condicioTest = c8.Equals(canal); //diferents objectes
            Console.WriteLine(condicioTest);
            #endregion

            #region "operadors"
            //operador sum
            Console.WriteLine("operador sum");
            Color test1 = new Color([255, 100, 100, 214], true, 300);
            Color test2 = new Color([100, 100, 214], false);

            Color sumaTests = test1 + test2;
            Console.WriteLine(sumaTests);

            //operador ==
            Console.WriteLine("operador ==");
            condicioTest = clonc8 == c8;
            Console.WriteLine(condicioTest);

            condicioTest = clonc8 != c8;
            Console.WriteLine(condicioTest);

            condicioTest = clonc8 != c7;
            Console.WriteLine(condicioTest);

            condicioTest = clonc8 != null;
            Console.WriteLine(condicioTest);
            #endregion

            #region "explicits i implicits"
            Console.WriteLine("int a color");
            Color ColorInt = 300; //int a color
            Console.WriteLine(ColorInt);

            Console.WriteLine("color a int");
            int colorAenter = (int)c8; //color a int
            Console.WriteLine(colorAenter);

            //string hexa a color
            Console.WriteLine("6 valors amb #");
            Color hexaExemple = "#FFAA22"; //6 valors amb #
            Console.WriteLine(hexaExemple);

            Console.WriteLine("6 valors sense #");
            Color hexaExemple2 = "FFAAFF"; //6 valors sense #
            Console.WriteLine(hexaExemple2);

            Console.WriteLine("8 valors sense #");
            Color hexaExemple3 = "FFAAff22"; //8 valors sense #
            Console.WriteLine(hexaExemple3);

            Console.WriteLine("8 valors amb #");
            Color hexaExemple4 = "#FFAA4422"; //8 valors amb #
            Console.WriteLine(hexaExemple4);
            #endregion

        }
    }
}
