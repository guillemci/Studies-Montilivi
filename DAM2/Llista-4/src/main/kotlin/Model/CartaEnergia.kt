package org.example.Model

import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa
import org.example.enums.Etiqueta

abstract class CartaEnergia(id : String, nom : String, expansio : Expansio, numero : String, raresa : Raresa,
                            illustrador: Illustrador? = null, marcaReglament : String,
                            etiquetes : List<Etiqueta>, imatgeCarta : String,
) : Carta
    (id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes,
    imatgeCarta) {

}