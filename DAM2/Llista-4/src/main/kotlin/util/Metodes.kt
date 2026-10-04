package org.example.util

import org.example.Model.Carta
import org.example.Model.CartaPokemon
import org.example.Model.Eina
import org.example.Model.EnergiaBasica
import org.example.Model.EnergiaEspecial
import org.example.Model.Estadi
import org.example.Model.Objecte
import org.example.Model.PokemonBasic
import org.example.Model.PokemonFase1
import org.example.Model.PokemonFase2
import org.example.Model.Suport
import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa
import org.example.enums.Etiqueta
import org.example.enums.Fase
import org.example.enums.Tipus
import org.example.interficies.CsvReader
import org.example.interficies.TeId
import org.example.`object`.Dades
import java.io.File
import kotlin.Int
import kotlin.String
import kotlin.collections.set

class Metodes {
    companion object {
        //Un companion object no és realment un static. És un objecte singleton associat a la classe.
        //T ha d'implementar TeId, i el tipus que utilitza TeId és U
        fun <U,T: TeId<U>> llegeixTaules(fitxer : String, factory : CsvReader<T>, diccionari : MutableMap<U,T>) {

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

//        fun <T : Enum<T>> convertirLlistaATipus(llista: List<String>): List<T> {
//            var llistaEnum = mutableListOf<T>()
//
//            llista.forEach { element -> llistaEnum.add(enumValueOf<T>("BASIC")) }
//        }


        //ifs per comprovar tipus d'objecte que s'ha de crear
        //permetre la creacio d'un objecte amb certs parametres vuits (basicament tots vuits menys els de la classe pare de tots)
        //amb la idea d'adalt podre encapsular metodeGeneric usant : Pare
        //potser pasar el nom del document, per saber com tractar cada un...
        fun converteix(linea: String, nomFitxer : String) : Carta {

            var cartaRetornar : Carta

            val camps = linea.split(";")

            //Carta
            val id = camps[0]
            val nom = camps[1]
            val expansio = obtenirTipus<String,Expansio>(Dades.expansions ,camps[2])
            val numero = camps[3] //es int???
            val raresa = obtenirTipus<Int, Raresa>(Dades.rareses ,camps[4].toInt())
            val illustrador =
                if (camps[5].isEmpty())
                    null
                else
                    obtenirTipus<Int, Illustrador>(Dades.illustradors, camps[5].toInt())
            val marcaReglament = camps[6]
            val etiquetesString = separa(camps[7])
            val etiquetes = mutableListOf<Etiqueta>()
            etiquetesString.forEach {
                element -> etiquetes.add(Etiqueta.valueOf(element))
            }
            val imatgeCarta = camps[8]

            val text = if (nomFitxer == "Objecte.csv" || nomFitxer == "Suport.csv" || nomFitxer == "Estadi.csv" || nomFitxer == "Eina.csv" || nomFitxer == "EnergiesEspecials.csv")
                 separa(camps[9])
            else
                emptyList()


            when (nomFitxer) {
                "Pokemons.csv" -> {
                    val ps = camps[9].toInt()
                    val tipusString = separa(camps[10])
                    val tipus = mutableListOf<Tipus>()
                    tipusString.forEach {
                            element -> tipus.add(Tipus.valueOf(element))
                    }


                    val numPokedex = separa(camps[11])
                    val habilitats = separa(camps[12])
                    val atacs = separa(camps[13])
                    val debilitats = separa(camps[14])
                    val resistenciesString = separa(camps[15])
                    val resistencies = mutableListOf<Tipus>()
                    resistenciesString.forEach {
                            element -> resistencies.add(Tipus.valueOf(element))
                    }

                    val costRetirada = camps[16].toInt()
                    val regles = separa(camps[17])
                    val textAmbientacio = camps[18]
                    val imatge = camps[19]
                    val fase = Fase.valueOf(camps[20])
                    val evolucio = camps[21]

                    if (fase == Fase.BASIC) {
                        cartaRetornar = PokemonBasic(id, nom, expansio, numero, raresa, illustrador,
                            marcaReglament, etiquetes, imatgeCarta, ps, tipus, numPokedex,
                            habilitats, atacs, debilitats, resistencies, costRetirada,
                            regles, textAmbientacio, imatge)
                    }
                    else if (fase == Fase.FASE_1) {
                        cartaRetornar = PokemonFase1(id, nom, expansio, numero, raresa, illustrador,
                            marcaReglament, etiquetes, imatgeCarta, ps, tipus, numPokedex,
                            habilitats, atacs, debilitats, resistencies, costRetirada,
                            regles, textAmbientacio, imatge, evolucio)
                    }
                    else if (fase == Fase.FASE_2) {
                        cartaRetornar = PokemonFase2(id, nom, expansio, numero, raresa, illustrador,
                            marcaReglament, etiquetes, imatgeCarta, ps, tipus, numPokedex,
                            habilitats, atacs, debilitats, resistencies, costRetirada,
                            regles, textAmbientacio, imatge, evolucio)
                    }
                    else {
                        throw Exception("parametre ilegal")
                    }
                }
                "Objectes.csv" -> {
                    cartaRetornar = Objecte(id, nom, expansio, numero, raresa, illustrador,
                        marcaReglament, etiquetes, imatgeCarta, text)
                }
                "Suports.csv" -> {
                    cartaRetornar = Suport(id, nom, expansio, numero, raresa, illustrador,
                        marcaReglament, etiquetes, imatgeCarta, text)
                }
                "Estadis.csv" -> {
                    cartaRetornar = Estadi(
                        id, nom, expansio, numero, raresa, illustrador,
                        marcaReglament, etiquetes, imatgeCarta, text
                    )
                }
                "Eines.csv" -> {
                    cartaRetornar = Eina(
                        id, nom, expansio, numero, raresa, illustrador,
                        marcaReglament, etiquetes, imatgeCarta, text
                    )
                }
                "EnergiesBasiques.csv" -> {
                    val tipusEnergia = Tipus.valueOf(camps[9])

                    cartaRetornar = EnergiaBasica(
                        id, nom, expansio, numero, raresa, illustrador,
                        marcaReglament, etiquetes, imatgeCarta, tipusEnergia
                    )
                }
                "EnergiesEspecials.csv" -> {
                    cartaRetornar = EnergiaEspecial(
                        id, nom, expansio, numero, raresa, illustrador,
                        marcaReglament, etiquetes, imatgeCarta, text
                    )
                }
                else -> throw Exception("parametre ilegal")
            }

            return cartaRetornar
        }


        fun <U,T> obtenirTipus(diccionari : Map<U,T>, cerca : U) : T
        {
            return diccionari[cerca] ?: throw IllegalArgumentException("el camp a buscar no existex ${cerca}")
        }

        fun llegeix(carpeta : String) : MutableList<Carta> {
            val coleccio = mutableListOf<Carta>()

            val fitxers = File(carpeta).listFiles()


            fitxers?.forEach {
                fitxer ->

                if (fitxer.name == "Expansions.csv") {
                    Metodes.llegeixTaules<String, Expansio>(fitxer.path, Expansio, Dades.expansions)
                }

                if (fitxer.name == "Rareses.csv") {
                    Metodes.llegeixTaules<Int, Raresa>(fitxer.path, Raresa, Dades.rareses)
                }

                if (fitxer.name == "Illustradors.csv") {
                    Metodes.llegeixTaules<Int, Illustrador>(fitxer.path, Illustrador, Dades.illustradors)
                }
            }

            println("hola")
            println("hola")

            fitxers?.forEach {
                fitxer ->

                if (fitxer.name != "Illustradors.csv" && fitxer.name != "Rareses.csv" && fitxer.name != "Expansions.csv")
                {
                    fitxer.bufferedReader().use { reader ->
                        reader.readLine()

                        var linea = reader.readLine()

                        while (linea != null) {
                            coleccio.add(converteix(linea, fitxer.name))
                            linea = reader.readLine()
                        }
                    }
                }
            }

            return coleccio
        }

        fun <T> ajuntar(etiquetes : List<T>): String {
            var output = ""

            for (i in 0 until etiquetes.size) {
                output += "${etiquetes[i]}"
                if (i < etiquetes.size - 1) {
                    output += " // "
                }
            }

            return output
        }

        fun desa(carpeta: String, cartes: List<Carta>) {
            val fitxerIllustrador = File(carpeta, "Illustradors.csv")
            fitxerIllustrador.appendText("Id;Nom\n")

            Dades.illustradors.forEach { _, illustrador ->
                fitxerIllustrador.appendText(illustrador.toCsv() + "\n")
            }

            val fitxerExpansions = File(carpeta, "Expansions.csv")
            fitxerExpansions.appendText("Codi;Nom;Serie;DataPublicacio;TotalCartes;Logo;Simbol\n")

            Dades.expansions.forEach { _, expansion ->
                fitxerExpansions.appendText(expansion.toCsv() + "\n")
            }

            val fitxerRares = File(carpeta, "Rareses.csv")
            fitxerRares.appendText("Id;Nom;Ordre\n")

            Dades.rareses.forEach { _, rares ->
                fitxerRares.appendText(rares.toCsv() + "\n")
            }

            val fitxerEines = File(carpeta, "Eines.csv")
            fitxerEines.appendText("Id;Nom;CodiExpansio;Numero;IdRaresa;IdIllustrador;MarcaReglament;Etiquetes;ImatgeCarta;Text\n")

            val fitxerEnergiesBasiques = File(carpeta, "EnergiesBasiques.csv")
            fitxerEnergiesBasiques.appendText("Id;Nom;CodiExpansio;Numero;IdRaresa;IdIllustrador;MarcaReglament;Etiquetes;ImatgeCarta;TipusEnergia\n")

            val fitxerEnergiesEspecials = File(carpeta, "EnergiesEspecials.csv")
            fitxerEnergiesEspecials.appendText("Id;Nom;CodiExpansio;Numero;IdRaresa;IdIllustrador;MarcaReglament;Etiquetes;ImatgeCarta;Text\n")

            val fitxerEstadis = File(carpeta, "Estadis.csv")
            fitxerEstadis.appendText("Id;Nom;CodiExpansio;Numero;IdRaresa;IdIllustrador;MarcaReglament;Etiquetes;ImatgeCarta;Text\n")

            val fitxerObjectes = File(carpeta, "Objectes.csv")
            fitxerObjectes.appendText("Id;Nom;CodiExpansio;Numero;IdRaresa;IdIllustrador;MarcaReglament;Etiquetes;ImatgeCarta;Text\n")

            val fitxerPokemons = File(carpeta, "Pokemons.csv")
            fitxerPokemons.appendText("Id;Nom;CodiExpansio;Numero;IdRaresa;IdIllustrador;MarcaReglament;Etiquetes;ImatgeCarta;PS;Tipus;NumsPokedex;Habilitats;Atacs;Debilitats;Resistencies;CostRetirada;Regles;TextAmbientacio;ImatgePokemon;Fase;EvolucionaDe\n")

            val fitxerSuports = File(carpeta, "Suports.csv")
            fitxerSuports.appendText("Id;Nom;CodiExpansio;Numero;IdRaresa;IdIllustrador;MarcaReglament;Etiquetes;ImatgeCarta;Text\n")

            cartes.forEach {
                carta ->

                when (carta) {
                    is Eina -> fitxerEines.appendText(carta.toCsv() + "\n")
                    is EnergiaBasica -> fitxerEnergiesBasiques.appendText(carta.toCsv() + "\n")
                    is EnergiaEspecial -> fitxerEnergiesEspecials.appendText(carta.toCsv() + "\n")
                    is Estadi -> fitxerEstadis.appendText(carta.toCsv() + "\n")
                    is Objecte -> fitxerObjectes.appendText(carta.toCsv() + "\n")
                    is CartaPokemon -> fitxerPokemons.appendText(carta.toCsv() + "\n")
                    is Suport -> fitxerSuports.appendText(carta.toCsv() + "\n")
                }
            }
        }
    }
}