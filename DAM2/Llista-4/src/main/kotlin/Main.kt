package org.example

import org.example.Extensio.altaCarta
import org.example.Model.Carta
import org.example.Model.Eina
import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa
import org.example.`object`.Dades
import org.example.util.Metodes
import org.example.util.Metodes.Companion.desa
import org.example.util.Metodes.Companion.llegeix
import org.example.util.Metodes.Companion.ompleCarta
import java.io.File
import java.io.FileDescriptor
import java.io.FileOutputStream
import java.io.PrintStream

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.

fun main() {
    consolaUtf8()

    val llistaPokemons = llegeix("Dades")
    var inputMenu = 999
    var colleccio : MutableList<Carta>? = null

    while (inputMenu != 0) {
        netejarEscena()
        printMenu()

        when (inputMenu) {
            1 -> {
                netejarEscena()
                println("Introdueix el nom de la carpeta, per defecte serà la carpeta 'Dades'")
                val entrada = readlnOrNull()
                val carpeta = File(if (entrada.isNullOrBlank()) "Dades" else entrada)

                println("Buscant a: ${carpeta.absolutePath}")

                if (!carpeta.exists() || !carpeta.isDirectory) {
                    println("La carpeta no existeix")
                } else {
                    colleccio = llegeix(carpeta.absolutePath)
                    println("S'han llegit ${colleccio.size}")
                }
                sortir()
            }
            2 -> {
                netejarEscena()
                if (colleccio == null) {
                    println("tens que carregar la coleccio primer")
                }
                else {
                    println("introdueix el nom de la carpeta on vols deixar els fitxers")
                    var carpeta = readln()
                    desa(carpeta, colleccio)
                    println ("s'han desat les cartes a $carpeta")
                }
                sortir()
            }
            3 -> {
                netejarEscena()
                var carta = ompleCarta()

                if (colleccio == null) {
                    println("tens que carregar la coleccio primer")
                }
                else {
                    if(colleccio.altaCarta(carta)) {
                        println("carta nova afegida")
                    }
                    else {
                        println("carta substituida")
                    }
                }
                sortir()
            }
            4 -> {
                netejarEscena()
            }
            5 -> {
                netejarEscena()
            }
            6 -> {
                netejarEscena()
            }
            7 ->  {
                netejarEscena()
            }
            8 ->  {
                netejarEscena()
            }
            9 -> {
                netejarEscena()
            }
            10 -> {
                netejarEscena()
            }
            11 -> {
                netejarEscena()
            }
            12 -> {
                netejarEscena()
            }
            13 -> {
                netejarEscena()
            }
            14 -> {
                netejarEscena()
            }
            15 -> {
                netejarEscena()
            }
            16 -> {
                netejarEscena()
            }
        }

        inputMenu = readln().toInt()

    }

}

fun printMenu() {
    println("MENU POKEMON")
    println("1: Carregar Dades")
    println("2: Desar dades")
    println("3: Afegir o modificar una carta")
    println("4: Eliminar una carta per Id ")
    println("5: Eliminar una carta per posició")
    println("6: Llistar els tipus")
    println("7: Llistar els Pokémon d'un tipus")
    println("8: Llistar les expansions")
    println("9: Llistar les cartes d'una expansió")
    println("10: Llistar les rareses")
    println("11: Mostrar una carta per Id")
    println("12: Mostrar una carta per posició")
    println("13: Mostrar les cartes entre dues posicions")
    println("14: Comptar les cartes per categoria")
    println("15: Cadena evolutiva d'un Pokémon")
    println("16: Pokémon amb més PS")
    println("0: Sortir")
}

fun netejarEscena() {
    repeat(50) {
        println()
    }
}

fun consolaUtf8() {
    System.setOut(PrintStream(FileOutputStream(FileDescriptor.out), true, Charsets.UTF_8))
    System.setErr(PrintStream(FileOutputStream(FileDescriptor.err), true, Charsets.UTF_8))
}

fun sortir() {
    println("enter per sortir")
    readln()
}

