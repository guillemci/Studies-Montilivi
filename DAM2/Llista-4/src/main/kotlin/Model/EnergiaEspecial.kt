package org.example.Model

import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa
import org.example.enums.Etiqueta
import org.example.util.Metodes

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