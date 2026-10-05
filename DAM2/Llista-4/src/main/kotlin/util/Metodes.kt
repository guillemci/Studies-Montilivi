package org.example.util

import org.example.Extensio.ConteTipus
import org.example.Model.Carta
import org.example.Model.CartaPokemon
import org.example.Model.Eina
import org.example.Model.EnergiaBasica
import org.example.Model.EnergiaEspecial
import org.example.Model.Estadi
import org.example.Model.Objecte
import org.example.Model.PokemonBasic
import org.example.Model.PokemonEvolucionat
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
import kotlin.collections.forEach
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

            val text = if (nomFitxer == "Objectes.csv" || nomFitxer == "Suports.csv" || nomFitxer == "Estadis.csv" || nomFitxer == "Eines.csv" || nomFitxer == "EnergiesEspecials.csv")
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
                    val debilitatsString = separa(camps[14])
                    val debilitats = mutableListOf<Tipus>()
                    debilitatsString.forEach {
                            element -> debilitats.add(Tipus.valueOf(element))
                    }

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

        fun ompleCarta() : Carta {
            val carta : Carta
            println("tria el tipus de carta que vols")
            println("1: Eina")
            println("2: EnergiaBasica")
            println("3: EnergiaEspecial")
            println("4: Estadi")
            println("5: Objecte")
            println("6: Pokemon")
            println("7: Suport")

            var opcio = readln().toInt()

            //id
            println("Id:")
            val id = readln()

            //nom
            println("Nom:")
            val nom = readln()

            //expansio
            println("tria l'expansio:")
            Dades.expansions.forEach { string, expansio ->
                println("$string : $expansio")
            }
            val expansio = Dades.expansions[readln()]!!

            //numero
            println("numero:")
            val numero = readln()

            //raresa
            println("raresa:")
            Dades.rareses.forEach { int, raresa ->
                println("$int : $raresa")
            }
            val raresa = Dades.rareses[readln().toInt()]!!

            //illustrador
            println("illustrador deixa vuit si no en te:")
            Dades.illustradors.forEach { int, illustrador ->
                println("$int : $illustrador")
            }

            val lecturaIllustrador = readlnOrNull()?.toInt()

            val illustrador: Illustrador?

            if (lecturaIllustrador != null) {
                illustrador = Dades.illustradors[lecturaIllustrador]
            }
            else {
                illustrador = null
            }

            //marca reglament
            println("marca reglament:")
            val marcaReglament = readln()

            //etiquetes
            Etiqueta.values().forEachIndexed { index, etiqueta ->
                println("${index + 1}: $etiqueta")
            }
            println("tria les etiquetes. Escriu 0 per acabar:")
            val etiquetes = mutableListOf<Etiqueta>()

            var valor = readln().toInt()

            while (valor != 0) {
                etiquetes.add(Etiqueta.values()[valor - 1])
                valor = readln().toInt()
            }

            println("imatge de la carta:")
            val imatgeCarta = readln()

            when (opcio) {
                1 -> {
                    println("text de l'eina:")

                    val text = mutableListOf<String>()
                    var lectura = readln()

                    while (lectura.isNotEmpty()) {
                        text.add(lectura)
                        lectura = readln()
                    }

                    carta = Eina(id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes, imatgeCarta, text)
                }
                2 -> {
                    println("tria el tipus d'energia:")

                    Tipus.values().forEachIndexed { index, tipus ->
                        println("${index + 1}: $tipus")
                    }

                    val tipusEnergia = Tipus.values()[readln().toInt() - 1]

                    carta = EnergiaBasica(id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes, imatgeCarta, tipusEnergia)
                }
                3 -> {
                    println("text de l'energia especial:")

                    val text = mutableListOf<String>()
                    var lectura = readln()

                    while (lectura.isNotEmpty()) {
                        text.add(lectura)
                        lectura = readln()
                    }

                    carta = EnergiaEspecial(id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes, imatgeCarta, text)
                }
                4 -> {
                    println("text de l'estadi:")

                    val text = mutableListOf<String>()
                    var lectura = readln()

                    while (lectura.isNotEmpty()) {
                        text.add(lectura)
                        lectura = readln()
                    }

                    carta = Estadi(id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes, imatgeCarta, text)
                }
                5 -> {
                    println("text de l'objecte:")

                    val text = mutableListOf<String>()
                    var lectura = readln()

                    while (lectura.isNotEmpty()) {
                        text.add(lectura)
                        lectura = readln()
                    }

                    carta = Objecte(id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes, imatgeCarta, text)
                }
                6 -> {
                    // ps
                    println("punts de salut:")
                    val ps = readln().toInt()

                    // tipus
                    println("tria els tipus. Escriu 0 per acabar:")

                    Tipus.values().forEachIndexed { index, tipus ->
                        println("${index + 1}: $tipus")
                    }

                    val tipus = mutableListOf<Tipus>()

                    var lecturaTipus = readln().toInt()

                    while (lecturaTipus != 0) {
                        tipus.add(Tipus.values()[lecturaTipus - 1])
                        lecturaTipus = readln().toInt()
                    }

                    // numero pokedex
                    println("numero de Pokedex:")

                    val numPokedex = mutableListOf<String>()
                    var lecturaPokedex = readln()

                    while (lecturaPokedex.isNotEmpty()) {
                        numPokedex.add(lecturaPokedex)
                        lecturaPokedex = readln()
                    }

                    // habilitats
                    println("habilitats:")

                    val habilitats = mutableListOf<String>()
                    var lecturaHabilitat = readln()

                    while (lecturaHabilitat.isNotEmpty()) {
                        habilitats.add(lecturaHabilitat)
                        lecturaHabilitat = readln()
                    }

                    // atacs
                    println("atacs:")

                    val atacs = mutableListOf<String>()
                    var lecturaAtac = readln()

                    while (lecturaAtac.isNotEmpty()) {
                        atacs.add(lecturaAtac)
                        lecturaAtac = readln()
                    }

                    // debilitats
                    println("tria les debilitats. Escriu 0 per acabar:")

                    Tipus.values().forEachIndexed { index, tipus ->
                        println("${index + 1}: $tipus")
                    }

                    val debilitats = mutableListOf<Tipus>()

                    var lecturaDebilitat = readln().toInt()

                    while (lecturaDebilitat != 0) {
                        debilitats.add(Tipus.values()[lecturaDebilitat - 1])
                        lecturaDebilitat = readln().toInt()
                    }

                    // resistencies
                    println("tria les resistencies. Escriu 0 per acabar:")

                    Tipus.values().forEachIndexed { index, tipus ->
                        println("${index + 1}: $tipus")
                    }

                    val resistencies = mutableListOf<Tipus>()

                    var lecturaResistencia = readln().toInt()

                    while (lecturaResistencia != 0) {
                        resistencies.add(Tipus.values()[lecturaResistencia - 1])
                        lecturaResistencia = readln().toInt()
                    }

                    // cost retirada
                    println("cost de retirada:")
                    val costRetirada = readln().toInt()

                    // regles
                    println("regles:")

                    val regles = mutableListOf<String>()
                    var lecturaRegla = readln()

                    while (lecturaRegla.isNotEmpty()) {
                        regles.add(lecturaRegla)
                        lecturaRegla = readln()
                    }

                    // text ambientacio
                    println("text d'ambientacio:")
                    val textAmbientacio = readln()

                    // imatge
                    println("imatge:")
                    val imatge = readln()

                    carta = PokemonBasic(id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes, imatgeCarta, ps, tipus, numPokedex, habilitats, atacs, debilitats, resistencies, costRetirada, regles, textAmbientacio, imatge)
                }
                7 -> {
                    println("text del suport:")

                    val text = mutableListOf<String>()
                    var lectura = readln()

                    while (lectura.isNotEmpty()) {
                        text.add(lectura)
                        lectura = readln()
                    }

                    carta = Suport(id, nom, expansio, numero, raresa, illustrador, marcaReglament, etiquetes, imatgeCarta, text)
                }
                else -> {
                    throw Exception("opcio ilegal")
                }
            }
            return carta
        }


        fun altaCarta(carta: Carta): Boolean {

            var trovat = false
            var i = 0

            while (i < Dades.colleccioCartes.size && !trovat) {
                if (Dades.colleccioCartes[i].id == carta.id) {
                    trovat = true
                    Dades.colleccioCartes[i] = carta
                }
                else {
                    i++
                }
            }

            if (!trovat) {
                Dades.colleccioCartes.add(carta)
            }

            return !trovat
        }

        fun eliminaCarta(id: String): Boolean {
            var trovat = false
            var i = 0

            while (i < Dades.colleccioCartes.size && !trovat) {
                if (Dades.colleccioCartes[i].id == id) {
                    Dades.colleccioCartes.removeAt(i)
                    trovat = true
                }
                else {
                    i++
                }
            }

            return !trovat
        }

        fun eliminaPosicio(posicio: Int): Boolean {
            return if (posicio < 0 || posicio > Dades.colleccioCartes.size - 1) {
                false
            }
            else {
                Dades.colleccioCartes.removeAt(posicio)
                true
            }
        }

        //tambe es podria fer amb un Set
        fun llistaTipus(): List<Tipus> {
            val tipus = mutableListOf<Tipus>()
            var  i = 0;

            Dades.colleccioCartes.forEach { carta ->
                if (carta is CartaPokemon) {
                    while (i < carta.tipus.size) {
                        if (!tipus.ConteTipus(carta.tipus[i])) {
                            tipus.add(carta.tipus[i])
                        }

                        i++
                    }

                    i = 0
                }
            }

            return tipus.sortedBy { it.ordinal }
        }

        fun llistaDeTipus(tipus: Tipus) : List<CartaPokemon> {
            val llistaPokemons = mutableListOf<CartaPokemon>()
            var i = 0

            Dades.colleccioCartes.forEach {
                    carta ->
                if (carta is CartaPokemon) {
                    if (carta.tipus.ConteTipus(tipus))
                        llistaPokemons.add(carta)
                }
            }

            return llistaPokemons
        }

        fun llistaExpansions(): Map<Expansio, Int> {
            val map = mutableMapOf<Expansio, Int>()

            Dades.expansions.values
                .sortedBy { it.dataPublicacio }
                .forEach { expansio ->
                    map[expansio] = 0
                }

            Dades.colleccioCartes.forEach { carta ->
                map[carta.expansio] = (map[carta.expansio] ?: 0) + 1
            }

            return map
        }

        fun llistaExpansio(codi: String): List<Carta> {
            //val expansio = Dades.expansions[codi] ?:

            if (!Dades.expansions.keys.contains(codi)) {
                throw Exception("expansio $codi not found")
            }

            var llistaExpansio = mutableListOf<Carta>()

            Dades.colleccioCartes.forEach { carta ->
                if (carta.expansio.codi == codi) {
                    llistaExpansio.add(carta)
                }
            }

            return llistaExpansio
        }

        fun llistaRareses(): Map<Raresa, Int> {
            val map = mutableMapOf<Raresa, Int>()

            Dades.rareses.values
                .sortedBy { it.ordre }
                .forEach { raresa ->
                    map[raresa] = 0
                }

            Dades.colleccioCartes.forEach { carta ->
                map[carta.raresa] = (map[carta.raresa] ?: 0) + 1
            }

            return map
        }

        fun llistaCarta(id: String): Carta? {

            var i = 0
            var trovat = false
            var carta: Carta? = null

            while(!trovat && i < Dades.colleccioCartes.size) {
                if (Dades.colleccioCartes[i].id == id) {
                    trovat = true
                    carta = Dades.colleccioCartes[i]
                }
                else
                    i++
            }

            return carta

        }

        fun llistaPos(posicio: Int): Carta? {
            return if (posicio < Dades.colleccioCartes.size && posicio > Dades.colleccioCartes.size - 1) {
                null
            }
            else {
                Dades.colleccioCartes[posicio]
            }
        }

        fun llistaRang(desde: Int, fins: Int): List<Carta> {

            if (desde < 0)
                throw Exception("no pot ser mes petit que 0")

            var llista = mutableListOf<Carta>()
            var i = 0
            var final = false

            while (i < Dades.colleccioCartes.size && !final) {

                if (i >= desde && i < desde + fins) {
                    llista.add(Dades.colleccioCartes[i])
                }

                if (i > desde + fins) {
                    final = true
                }

                i++
            }

            return llista
        }

        fun llistaCategories(): Map<String, Int> {
            var map = mutableMapOf<String, Int>()

            Dades.colleccioCartes.forEach { carta ->
                map[carta.categoria] = (map[carta.categoria] ?: 0) + 1
            }

            return map
        }

        fun cadenaEvolutiva(nom: String): List<String> {
            val cadena = mutableListOf<String>()

            var totalTrovats = 0
            var pokemonEndarrera: CartaPokemon? = null
            var pokemonEndavant: CartaPokemon? = null

            Dades.colleccioCartes.forEach { carta ->
                if (carta is CartaPokemon && carta.nom == nom) {
                    pokemonEndarrera = carta
                    pokemonEndavant = carta
                }
            }

            if (pokemonEndarrera == null) {
                throw Exception("cadenaEvolutiva $nom not exist")
            }

            cadena.add(nom)
            totalTrovats++

            // Buscar endarrera
            if (pokemonEndarrera is PokemonFase2) {
                pokemonEndarrera = Endarrera(pokemonEndarrera)
                if (pokemonEndarrera != null)
                    cadena.add(pokemonEndarrera.nom)
                totalTrovats++
            }

            // Buscar endarrera
            if (pokemonEndarrera is PokemonFase1) {
                pokemonEndarrera = Endarrera(pokemonEndarrera)
                if (pokemonEndarrera != null)
                    cadena.add(pokemonEndarrera.nom)
                totalTrovats++
            }

            // Buscar endavant
            if (pokemonEndavant is PokemonBasic && totalTrovats < 3) {
                pokemonEndavant = Endavant(pokemonEndavant)
                if (pokemonEndavant != null)
                    cadena.add(pokemonEndavant.nom)
                totalTrovats++
            }

            // Buscar endavant
            if (pokemonEndavant is PokemonFase1 && totalTrovats < 3) {
                pokemonEndavant = Endavant(pokemonEndavant)
                if (pokemonEndavant != null)
                    cadena.add(pokemonEndavant.nom)
            }

            return cadena
        }

        fun Endarrera(cartaInicial: PokemonEvolucionat): CartaPokemon? {
            var trovat = false
            var i = 0
            var pokemon: CartaPokemon? = null

            while (!trovat && i < Dades.colleccioCartes.size) {
                val carta = Dades.colleccioCartes[i]

                if (carta is CartaPokemon && carta.nom == cartaInicial.evolucioDe) {
                    trovat = true
                    pokemon = carta
                }

                i++
            }

            return pokemon
        }

        fun Endavant(cartaInicial: CartaPokemon): CartaPokemon? {
            var trovat = false
            var i = 0
            var pokemon: CartaPokemon? = null

            while (!trovat && i < Dades.colleccioCartes.size) {
                val carta = Dades.colleccioCartes[i]

                if (carta is PokemonEvolucionat && carta.evolucioDe == cartaInicial.nom) {
                    trovat = true
                    pokemon = carta
                }

                i++
            }

            return pokemon
        }

        fun PokemonMesFort() : CartaPokemon? {
            var cartaRetornar : CartaPokemon? = null

            Dades.colleccioCartes.forEach { carta ->
                if (carta is PokemonEvolucionat && (cartaRetornar?.ps ?: Int.MIN_VALUE) < carta.ps) {
                    cartaRetornar = carta
                }
            }

            return cartaRetornar
        }
    }
}