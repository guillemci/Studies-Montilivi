package org.example.Model

import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa
import org.example.enums.Etiqueta

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