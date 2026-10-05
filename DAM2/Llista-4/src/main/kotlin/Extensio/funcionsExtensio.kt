package org.example.Extensio

import org.example.Model.Carta
import org.example.Model.CartaPokemon
import org.example.Model.PokemonBasic
import org.example.Model.PokemonEvolucionat
import org.example.Model.PokemonFase1
import org.example.Model.PokemonFase2
import org.example.data_class.Expansio
import org.example.data_class.Raresa
import org.example.enums.Tipus
import org.example.`object`.Dades

fun List<Tipus>.ConteTipus(tipus : Tipus) : Boolean {
    var trovat = false
    var i = 0;

    while (!trovat && i < this.size) {
        trovat = this[i] == tipus
        i++
    }

    return trovat
}

fun MutableList<Carta>.altaCarta(carta: Carta): Boolean {

    var trovat = false
    var i = 0

    while (i < this.size && !trovat) {
        if (this[i].id == carta.id) {
            trovat = true
            this[i] = carta
        }
        else {
            i++
        }
    }

    if (!trovat) {
        this.add(carta)
    }

    return !trovat
}

fun MutableList<Carta>.eliminaCarta(id: String): Boolean {
    var trovat = false
    var i = 0

    while (i < this.size && !trovat) {
        if (this[i].id == id) {
            this.removeAt(i)
            trovat = true
        }
        else {
            i++
        }
    }

    return !trovat
}

fun MutableList<Carta>.eliminaPosicio(posicio: Int): Boolean {
    return if (posicio < 0 || posicio > this.size - 1) {
        false
    }
    else {
        this.removeAt(posicio)
        true
    }
}

//tambe es podria fer amb un Set
fun MutableList<Carta>.llistaTipus(): List<Tipus> {
    val tipus = mutableListOf<Tipus>()
    var  i = 0;

    this.forEach { carta ->
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

fun MutableList<Carta>.llistaDeTipus(tipus: Tipus) : List<CartaPokemon> {
    val llistaPokemons = mutableListOf<CartaPokemon>()
    var i = 0

    this.forEach {
            carta ->
        if (carta is CartaPokemon) {
            if (carta.tipus.ConteTipus(tipus))
                llistaPokemons.add(carta)
        }
    }

    return llistaPokemons
}

fun MutableList<Carta>.llistaExpansions(): Map<Expansio, Int> {
    val map = mutableMapOf<Expansio, Int>()

    Dades.expansions.values
        .sortedBy { it.dataPublicacio }
        .forEach { expansio ->
            map[expansio] = 0
        }

    this.forEach { carta ->
        map[carta.expansio] = (map[carta.expansio] ?: 0) + 1
    }

    return map
}

fun MutableList<Carta>.llistaExpansio(codi: String): List<Carta> {
    //val expansio = Dades.expansions[codi] ?:

    if (!Dades.expansions.keys.contains(codi)) {
        throw Exception("expansio $codi not found")
    }

    var llistaExpansio = mutableListOf<Carta>()

    this.forEach { carta ->
        if (carta.expansio.codi == codi) {
            llistaExpansio.add(carta)
        }
    }

    return llistaExpansio
}

fun MutableList<Carta>.llistaRareses(): Map<Raresa, Int> {
    val map = mutableMapOf<Raresa, Int>()

    Dades.rareses.values
        .sortedBy { it.ordre }
        .forEach { raresa ->
            map[raresa] = 0
        }

    this.forEach { carta ->
        map[carta.raresa] = (map[carta.raresa] ?: 0) + 1
    }

    return map
}

fun MutableList<Carta>.llistaCarta(id: String): Carta? {

    var i = 0
    var trovat = false
    var carta: Carta? = null

    while(!trovat && i < this.size) {
        if (this[i].id == id) {
            trovat = true
            carta = this[i]
        }
        else
            i++
    }

    return carta

}

fun MutableList<Carta>.llistaPos(posicio: Int): Carta? {
    return if (posicio < this.size && posicio > this.size - 1) {
        null
    }
    else {
        this[posicio]
    }
}

fun MutableList<Carta>.llistaRang(desde: Int, fins: Int): List<Carta> {

    if (desde < 0)
        throw Exception("no pot ser mes petit que 0")

    var llista = mutableListOf<Carta>()
    var i = 0
    var final = false

    while (i < this.size && !final) {

        if (i >= desde && i < desde + fins) {
            llista.add(this[i])
        }

        if (i > desde + fins) {
            final = true
        }

        i++
    }

    return llista
}

fun MutableList<Carta>.llistaCategories(): Map<String, Int> {
    var map = mutableMapOf<String, Int>()

    this.forEach { carta ->
        map[carta.categoria] = (map[carta.categoria] ?: 0) + 1
    }

    return map
}

fun MutableList<Carta>.cadenaEvolutiva(nom: String): List<String> {
    val cadena = mutableListOf<String>()

    var totalTrovats = 0
    var pokemonEndarrera: CartaPokemon? = null
    var pokemonEndavant: CartaPokemon? = null

    this.forEach { carta ->
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

fun MutableList<Carta>.Endarrera(cartaInicial: PokemonEvolucionat): CartaPokemon? {
    var trovat = false
    var i = 0
    var pokemon: CartaPokemon? = null

    while (!trovat && i < this.size) {
        val carta = this[i]

        if (carta is CartaPokemon && carta.nom == cartaInicial.evolucioDe) {
            trovat = true
            pokemon = carta
        }

        i++
    }

    return pokemon
}

fun MutableList<Carta>.Endavant(cartaInicial: CartaPokemon): CartaPokemon? {
    var trovat = false
    var i = 0
    var pokemon: CartaPokemon? = null

    while (!trovat && i < this.size) {
        val carta = this[i]

        if (carta is PokemonEvolucionat && carta.evolucioDe == cartaInicial.nom) {
            trovat = true
            pokemon = carta
        }

        i++
    }

    return pokemon
}

fun MutableList<Carta>.PokemonMesFort() : CartaPokemon? {
    var cartaRetornar : CartaPokemon? = null

    this.forEach { carta ->
        if (carta is PokemonEvolucionat && (cartaRetornar?.ps ?: Int.MIN_VALUE) < carta.ps) {
            cartaRetornar = carta
        }
    }

    return cartaRetornar
}