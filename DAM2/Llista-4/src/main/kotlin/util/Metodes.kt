package org.example.util

import org.example.Model.Carta
import org.example.Model.CartaPokemon
import org.example.enums.Tipus
import org.example.interficies.CsvReader
import org.example.interficies.TeId
import java.io.File
import kotlin.collections.set

class Metodes {
    companion object {
        //Un companion object no és realment un static. És un objecte singleton associat a la classe.
        //T ha d'implementar TeId, i el tipus que utilitza TeId és U
        fun <U,T: TeId<U>> llegirCsvDeTaules(fitxer : String, factory : CsvReader<T>, diccionari : MutableMap<U,T>) {

            diccionari.clear()

            File(fitxer).bufferedReader().use { reader ->
                reader.readLine()

                var linea = reader.readLine()

                while (linea != null) {
                    val objecte = factory.formatCsv(linea)
                    diccionari[objecte.RetornaId()] = objecte

                    linea = reader.readLine()
                }
            }
        }

        fun <T> Escriurellista(llista : List<T>) : String {
            var output = "("

            for (i in 0 until llista.size) {
                output += llista[i]
                if (i < llista.size - 1) {
                    output += ", "
                }
            }

            output += ")"

            return output
        }

        fun separa(fragment : String) : List<String> {
            var retornar: List<String>

            if (fragment.isEmpty()) {
                retornar = emptyList()
            } else {
                retornar = fragment.split(" // ")
            }

            return retornar
        }


        //ifs per comprovar tipus d'objecte que s'ha de crear
        //permetre la creacio d'un objecte amb certs parametres vuits (basicament tots vuits menys els de la classe pare de tots)
        //amb la idea d'adalt podre encapsular metodeGeneric usant : Pare
        //potser pasar el nom del document, per saber com tractar cada un...
        fun <T : CartaPokemon> factoryLlegirPokemon(linea: String, nomFitxer : String) : Carta {
//            val camps = linea.split(";")
//            val id = camps[0]
//            val nom = camps[1]
//            val codiExpansio = camps[2]
//            val numero = camps[3].toInt()
//            val idRaresa = camps[4].toInt()
//            val idIllustra = camps[5].toInt()
//            val marcaReglament = camps[6]
//            val etiquetes = separa(camps[7])
//            val imatgeCarta = camps[8]
//            val ps = camps[9].toInt()
//            val tipus = listOf<Tipus>(Tipus.valueOf(camps[10]))  //potser no pot llegir el enum aixi
//            val numPokedex = camps[11]
//            val habilitats = camps[12]
//            val atacs = separa(camps[13])


        }
    }
}