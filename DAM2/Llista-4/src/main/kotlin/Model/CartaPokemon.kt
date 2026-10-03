package org.example.Model

import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa
import org.example.enums.Etiqueta
import org.example.enums.Fase
import org.example.enums.Tipus
import org.example.util.Metodes

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