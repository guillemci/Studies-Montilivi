package org.example.Model

import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa
import org.example.enums.Etiqueta
import org.example.enums.Fase
import org.example.enums.Tipus

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