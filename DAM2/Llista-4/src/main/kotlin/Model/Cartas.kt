package org.example.Model

import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa
import org.example.enums.Etiqueta
import org.example.enums.Fase
import org.example.enums.Tipus
import org.example.util.Metodes


abstract class Carta(val id : String, val nom : String, val expansio : Expansio, val numero : String, val raresa : Raresa,
                     val illustrador: Illustrador? = null, val marcaReglament : String,
                     val etiquetes : List<Etiqueta>, val imatgeCarta : String,
) {
    abstract val categoria : String

    override fun equals(other : Any?): Boolean {
        var retornar = false

        if (other is Carta && other.id == this.id) {
            retornar = true
        }

        return retornar
    }

    override fun toString(): String {
        return  "CATEGORIA : $categoria" +
                "ID : $id\n" +
                "NOM : $nom\n" +
                "EXPANSIO : $expansio\n" +
                "NUMERO : $numero\n" +
                "RARESA : $raresa\n" +
                "ILLUSTRADOR : $illustrador\n" +
                "MARCA DE REGLAMENT : $marcaReglament\n" +
                "ETIQUETES: ${Metodes.Escriurellista<Etiqueta>(etiquetes)}\n" +
                "IMATGE CARTA: ${imatgeCarta}\n"

    }

    //Diu override hashCode, pero no em fet HashCode, ni GetHashCode en Csharp
}

abstract class CartaPokemon
    (id : String,
     nom : String,
     expansio : Expansio,
     numero : String,
     raresa : Raresa,
     illustrador: Illustrador? = null,
     marcaReglament : String,
     etiquetes : List<Etiqueta>,
     imatgeCarta : String,
     val ps : Int,
     val tipus : Tipus,
     val pokedex : Int,
     val habilitats : String,
     val atacs : List<String>,
     val debilitat : Tipus,
     val resistencia : Tipus,
     val costRetirada : Int,
     val regles : List<String>,
     val textAmbientacio : String,
     val imatgePokemon : String,
) : Carta
    (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

    abstract val fase : Fase

    override fun toString(): String {
        return super.toString() +
                "PS : $ps\n" +
                "TIPUS : $tipus\n" +
                "POKEDEX : $pokedex\n" +
                "HABILITATS : $habilitats\n" +
                "ATACS : ${Metodes.Escriurellista<String>(atacs)}\n" +
                "DEBILITAT : $debilitat\n" +
                "RESISTENCIA : $resistencia\n" +
                "COST RETIRADA : $costRetirada\n" +
                "REGLES : ${Metodes.Escriurellista<String>(regles)}\n" +
                "TEXT AMBIENTACIO : $textAmbientacio\n" +
                "IMATGE POKEMON : $imatgePokemon\n" +
                "FASE : $fase\n"
    }

}

class PokemonBasic(id : String,
                   nom : String,
                   expansio : Expansio,
                   numero : String,
                   raresa : Raresa,
                   illustrador: Illustrador? = null,
                   marcaReglament : String,
                   etiquetes : List<Etiqueta>,
                   imatgeCarta : String,
                   ps : Int,
                   tipus : Tipus,
                   pokedex : Int,
                   habilitats : String,
                   atacs : List<String>,
                   debilitat : Tipus,
                   resistencia : Tipus,
                   costRetirada : Int,
                   regles : List<String>,
                   textAmbientacio : String,
                   imatgePokemon : String,
) : CartaPokemon(id, nom, expansio, numero, raresa, illustrador, marcaReglament , etiquetes,
    imatgeCarta, ps, tipus, pokedex, habilitats, atacs, debilitat, resistencia, costRetirada, regles,
    textAmbientacio, imatgePokemon) {

    override val categoria: String
        get() = "Pokémon Bàsic"

    override val fase: Fase
        get() = Fase.Basic
}

abstract class PokemonEvolucionat(id : String,
                                  nom : String,
                                  expansio : Expansio,
                                  numero : String,
                                  raresa : Raresa,
                                  illustrador: Illustrador? = null,
                                  marcaReglament : String,
                                  etiquetes : List<Etiqueta>,
                                  imatgeCarta : String,
                                  ps : Int,
                                  tipus : Tipus,
                                  pokedex : Int,
                                  habilitats : String,
                                  atacs : List<String>,
                                  debilitat : Tipus,
                                  resistencia : Tipus,
                                  costRetirada : Int,
                                  regles : List<String>,
                                  textAmbientacio : String,
                                  imatgePokemon : String,
                                  val evolucioDe : String) : CartaPokemon(id, nom, expansio, numero, raresa, illustrador, marcaReglament , etiquetes,
    imatgeCarta, ps, tipus, pokedex, habilitats, atacs, debilitat, resistencia, costRetirada, regles,
    textAmbientacio, imatgePokemon) {

    override fun toString(): String {
        return super.toString() +
                "EVOLUCIO DE : $evolucioDe\n"
    }

}

class PokemonFase1(id : String,
                   nom : String,
                   expansio : Expansio,
                   numero : String,
                   raresa : Raresa,
                   illustrador: Illustrador? = null,
                   marcaReglament : String,
                   etiquetes : List<Etiqueta>,
                   imatgeCarta : String,
                   ps : Int,
                   tipus : Tipus,
                   pokedex : Int,
                   habilitats : String,
                   atacs : List<String>,
                   debilitat : Tipus,
                   resistencia : Tipus,
                   costRetirada : Int,
                   regles : List<String>,
                   textAmbientacio : String,
                   imatgePokemon : String,
                   evolucioDe : String) :
    PokemonEvolucionat(id, nom, expansio, numero, raresa, illustrador, marcaReglament , etiquetes,
        imatgeCarta, ps, tipus, pokedex, habilitats, atacs, debilitat, resistencia,
        costRetirada, regles, textAmbientacio, imatgePokemon, evolucioDe) {

    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Pokémon Fase 1"

    override val fase: Fase
        get() = Fase.FASE_1

}

class PokemonFase2(id : String,
                   nom : String,
                   expansio : Expansio,
                   numero : String,
                   raresa : Raresa,
                   illustrador: Illustrador? = null,
                   marcaReglament : String,
                   etiquetes : List<Etiqueta>,
                   imatgeCarta : String,
                   ps : Int,
                   tipus : Tipus,
                   pokedex : Int,
                   habilitats : String,
                   atacs : List<String>,
                   debilitat : Tipus,
                   resistencia : Tipus,
                   costRetirada : Int,
                   regles : List<String>,
                   textAmbientacio : String,
                   imatgePokemon : String,
                   evolucioDe : String) :
    PokemonEvolucionat(id, nom, expansio, numero, raresa, illustrador, marcaReglament , etiquetes,
        imatgeCarta, ps, tipus, pokedex, habilitats, atacs, debilitat, resistencia, costRetirada, regles,
        textAmbientacio, imatgePokemon, evolucioDe) {

    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Pokémon Fase 2"

    override val fase: Fase
        get() = Fase.FASE_2

}

abstract class CartaEntrenador(id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
                               illustrador: Illustrador? = null, marcaReglament : String,
                               etiquetes : List<Etiqueta>, imatgeCarta : String, val text : List<String>)
    : Carta (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

    override fun toString(): String {
        return super.toString() +
                "TEXT : ${Metodes.Escriurellista<String>(text)}\n"
    }

}

class Objecte (id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
               illustrador: Illustrador? = null, marcaReglament : String,
               etiquetes : List<Etiqueta>, imatgeCarta : String, text : List<String>)
    : CartaEntrenador (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta, text) {

    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Entrenador · Objecte"
}

class Suport (id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
              illustrador: Illustrador? = null, marcaReglament : String,
              etiquetes : List<Etiqueta>, imatgeCarta : String, text : List<String>)
    : CartaEntrenador (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta, text) {

    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Entrenador · Suport"

}

class Estadi (id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
              illustrador: Illustrador? = null, marcaReglament : String,
              etiquetes : List<Etiqueta>, imatgeCarta : String, text : List<String>)
    : CartaEntrenador (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta, text) {

    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Entrenador · Estadi"

}

class Eina (id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
            illustrador: Illustrador? = null, marcaReglament : String,
            etiquetes : List<Etiqueta>, imatgeCarta : String, text : List<String>)
    : CartaEntrenador (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta, text) {

    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Entrenador · Eina Pokémon"
}

abstract class CartaEnergia(id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
                            illustrador: Illustrador? = null, marcaReglament : String,
                            etiquetes : List<Etiqueta>, imatgeCarta : String,
) : Carta
    (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

}

class EnergiaBasica(id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
                    illustrador: Illustrador? = null, marcaReglament : String,
                    etiquetes : List<Etiqueta>, imatgeCarta : String, val tipusEnergia : Tipus

) : CartaEnergia
    (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

    override fun toString(): String {
        return super.toString() +
                "TIPUS ENERGIA : $tipusEnergia\n"
    }

    override val categoria: String
        get() = "Energia Bàsica"

}

class EnergiaEspecial(id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
                      illustrador: Illustrador? = null, marcaReglament : String,
                      etiquetes : List<Etiqueta>, imatgeCarta : String, val text : List<String>

) : CartaEnergia
    (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

    override fun toString(): String {
        return super.toString() +
                "TEXT : ${Metodes.Escriurellista<String>(text)}\n"
    }

    override val categoria: String
        get() = "Energia Especial"

}


/* abstract class Carta(val id : String, val nom : String, val expansio : Expansio, val numero : String, val raresa : Raresa,
                     val illustrador: Illustrador? = null, val marcaReglament : String,
                     val etiquetes : List<Etiqueta>, val imatgeCarta : String,
) {
    abstract val categoria : String

    override fun equals(other: Any?): Boolean {
        var retornar = false

        if (other is Carta && other.id == this.id) {
            retornar = true
        }

        return retornar
    }

    override fun toString(): String {
        return  "CATEGORIA : $categoria" +
                "ID : $id\n" +
                "NOM : $nom\n" +
                "EXPANSIO : $expansio\n" +
                "NUMERO : $numero\n" +
                "RARESA : $raresa\n" +
                "ILLUSTRADOR : $illustrador\n" +
                "MARCA DE REGLAMENT : $marcaReglament\n" +
                "ETIQUETES: ${Metodes.Escriurellista<Etiqueta>(etiquetes)}\n" +
                "IMATGE CARTA: ${imatgeCarta}\n"

    }

    //Diu override hashCode, pero no em fet HashCode, ni GetHashCode en Csharp
}

abstract class CartaPokemon
    (id : String,
     nom : String,
     expansio : Expansio,
     numero : String,
     raresa : Raresa,
     illustrador: Illustrador? = null,
     marcaReglament : String,
     etiquetes : List<Etiqueta>,
     imatgeCarta : String,
     val ps : Int,
     val tipus: List<Tipus>,
     //val Pokedex : List<String>,
     val habilitats : List<String>,
     val atacs : List<String>,
     val debilitats : List<String>,
     val resistencies : List<Tipus>,
     val costRetirada : Int,
     val regles : List<String>,
     val textAmbientacio : String,
     val imatgePokemon : String,
) : Carta
    (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

    abstract val fase : Fase

    override fun toString(): String {
        return super.toString() +
                "PS : $ps\n" +
                "TIPUS : ${Metodes.Escriurellista<Tipus>(tipus)}\n" +
                //"POKEDEX : ${Metodes.Escriurellista<String>(Pokedex)}\n" +
                "POKEDEX : $pokedex"
                "HABILITATS : ${Metodes.Escriurellista<String>(habilitats)}\n" +
                "ATACS : ${Metodes.Escriurellista<String>(atacs)}\n" +
                "DEBILITATS : ${Metodes.Escriurellista<String>(debilitats)}\n" +
                "RESISTENCIES : ${Metodes.Escriurellista<Tipus>(resistencies)}\n" +
                "COST RETIRADA : $costRetirada\n" +
                "REGLES : ${Metodes.Escriurellista<String>(regles)}\n" +
                "TEXT AMBIENTACIO : $textAmbientacio\n" +
                "IMATGE POKEMON : $imatgePokemon\n" +
                "FASE : $fase\n"
    }

}

class PokemonBasic(id : String,
                   nom : String,
                   expansio : Expansio,
                   numero : String,
                   raresa : Raresa,
                   illustrador: Illustrador? = null,
                   marcaReglament : String,
                   etiquetes : List<Etiqueta>,
                   imatgeCarta : String,
                   ps : Int,
                   tipus: List<Tipus>,
                   //Pokedex : List<String>,
                   habilitats : List<String>,
                   atacs : List<String>,
                   debilitats : List<String>,
                   resistencies : List<Tipus>,
                   costRetirada : Int,
                   regles : List<String>,
                   textAmbientacio : String,
                   imatgePokemon : String,
                   ) : CartaPokemon(id, nom, expansio, numero, raresa, illustrador, marcaReglament , etiquetes,
                    imatgeCarta, ps, tipus, habilitats, atacs, debilitats, resistencies, costRetirada, regles,
                    textAmbientacio, imatgePokemon) {

    override val categoria: String
        get() = "Pokémon Bàsic"

    override val fase: Fase
        get() = Fase.Basic
}

abstract class PokemonEvolucionat(id : String,
                   nom : String,
                   expansio : Expansio,
                   numero : String,
                   raresa : Raresa,
                   illustrador: Illustrador? = null,
                   marcaReglament : String,
                   etiquetes : List<Etiqueta>,
                   imatgeCarta : String,
                   ps : Int,
                   tipus: List<Tipus>,
                   Pokedex : List<String>,
                   habilitats : List<String>,
                   atacs : List<String>,
                   debilitats : List<String>,
                   resistencies : List<Tipus>,
                   costRetirada : Int,
                   regles : List<String>,
                   textAmbientacio : String,
                   imatgePokemon : String,
                   val evolucioDe : String) : CartaPokemon(id, nom, expansio, numero, raresa, illustrador, marcaReglament , etiquetes,
    imatgeCarta, ps, tipus, Pokedex, habilitats, atacs, debilitats, resistencies, costRetirada, regles,
    textAmbientacio, imatgePokemon) {

    override fun toString(): String {
        return super.toString() +
                "EVOLUCIO DE : $evolucioDe\n"
    }

}

class PokemonFase1(id : String,
                   nom : String,
                   expansio : Expansio,
                   numero : String,
                   raresa : Raresa,
                   illustrador: Illustrador? = null,
                   marcaReglament : String,
                   etiquetes : List<Etiqueta>,
                   imatgeCarta : String,
                   ps : Int,
                   tipus: List<Tipus>,
                   Pokedex : List<String>,
                   habilitats : List<String>,
                   atacs : List<String>,
                   debilitats : List<String>,
                   resistencies : List<Tipus>,
                   costRetirada : Int,
                   regles : List<String>,
                   textAmbientacio : String,
                   imatgePokemon : String, evolucioDe : String) :
                    PokemonEvolucionat(id, nom, expansio, numero, raresa, illustrador, marcaReglament , etiquetes,
                        imatgeCarta, ps, tipus, Pokedex, habilitats, atacs, debilitats, resistencies,
                        costRetirada, regles, textAmbientacio, imatgePokemon, evolucioDe) {

    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Pokémon Fase 1"

    override val fase: Fase
        get() = Fase.FASE_1

}

class PokemonFase2(id : String,
                   nom : String,
                   expansio : Expansio,
                   numero : String,
                   raresa : Raresa,
                   illustrador: Illustrador? = null,
                   marcaReglament : String,
                   etiquetes : List<Etiqueta>,
                   imatgeCarta : String,
                   ps : Int,
                   tipus: List<Tipus>,
                   Pokedex : List<String>,
                   habilitats : List<String>,
                   atacs : List<String>,
                   debilitats : List<String>,
                   resistencies : List<Tipus>,
                   costRetirada : Int,
                   regles : List<String>,
                   textAmbientacio : String,
                   imatgePokemon : String,
                   evolucioDe : String) :
    PokemonEvolucionat(id, nom, expansio, numero, raresa, illustrador, marcaReglament , etiquetes,
        imatgeCarta, ps, tipus, Pokedex, habilitats, atacs, debilitats, resistencies,
        costRetirada, regles, textAmbientacio, imatgePokemon, evolucioDe) {

    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Pokémon Fase 2"

    override val fase: Fase
        get() = Fase.FASE_2

}

abstract class CartaEntrenador(id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
                               illustrador: Illustrador? = null, marcaReglament : String,
                               etiquetes : List<Etiqueta>, imatgeCarta : String, val text : List<String>)
    : Carta (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

    override fun toString(): String {
        return super.toString() +
                "TEXT : ${Metodes.Escriurellista<String>(text)}\n"
    }

}

class Objecte (id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
               illustrador: Illustrador? = null, marcaReglament : String,
               etiquetes : List<Etiqueta>, imatgeCarta : String, text : List<String>)
    : CartaEntrenador (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta, text) {


    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Entrenador · Objecte"
}

class Suport (id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
               illustrador: Illustrador? = null, marcaReglament : String,
               etiquetes : List<Etiqueta>, imatgeCarta : String, text : List<String>)
    : CartaEntrenador (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta, text) {
    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Entrenador · Suport"

}

class Estadi (id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
               illustrador: Illustrador? = null, marcaReglament : String,
               etiquetes : List<Etiqueta>, imatgeCarta : String, text : List<String>)
    : CartaEntrenador (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta, text) {
    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Entrenador · Estadi"

}

class Eina (id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
               illustrador: Illustrador? = null, marcaReglament : String,
               etiquetes : List<Etiqueta>, imatgeCarta : String, text : List<String>)
    : CartaEntrenador (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta, text) {
    override fun toString(): String {
        return super.toString()
    }

    override val categoria: String
        get() = "Entrenador · Eina Pokémon"
}

abstract class CartaEnergia(id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
                            illustrador: Illustrador? = null, marcaReglament : String,
                            etiquetes : List<Etiqueta>, imatgeCarta : String,
) : Carta
    (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

}

class EnergiaBasica(id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
                   illustrador: Illustrador? = null, marcaReglament : String,
                   etiquetes : List<Etiqueta>, imatgeCarta : String, val tipusEnergia : Tipus

) : CartaEnergia
    (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

    override fun toString(): String {
        return super.toString() +
                "TIPUS ENERGIA : $tipusEnergia\n"
    }

    override val categoria: String
        get() = "Energia Bàsica"

}

class EnergiaEspecial(id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
                    illustrador: Illustrador? = null, marcaReglament : String,
                    etiquetes : List<Etiqueta>, imatgeCarta : String, val text : List<String>

) : CartaEnergia
    (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

    override fun toString(): String {
        return super.toString() +
                "TEXT : ${Metodes.Escriurellista<String>(text)}\n"
    }

    override val categoria: String
        get() = "Energia Especial"

} */