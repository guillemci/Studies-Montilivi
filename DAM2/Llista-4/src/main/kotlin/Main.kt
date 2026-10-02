package org.example

import java.io.FileDescriptor
import java.io.FileOutputStream
import java.io.PrintStream
import java.time.LocalDate
import java.time.LocalDateTime

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.

enum class Tipus(val nom : String,val tipus : Char) {
    GRASS("planta",'G'),
    FIRE("foc",'F'),
    WATER("aigua",'W'),
    LIGHTNING("electric",'L'),
    PSYCHIC("Psiquic",'P'),
    FIGHTING("Lluita", 'F'),
    DARKNESS("foscor",'D'),
    METAL("metall",'M'),
    DRAGON("drac",'N'),
    COLORLESS("incolor",'C')
}

enum class Fase(val text : String) {
    Basic("fasic"),
    FASE_1("fase 1"),
    FASE_2("fase 2"),
}

enum class Etiqueta(val text : String) {
    EX("ex"),
    TERA("tera"),
    MEGA("mega"),
    ANCIENT("ancient"),
    FUTURE("future"),
    ACE_SPECIAL("ace spec"),
}

data class Expansio(val nom : String, val serie : String, val dataPublicacio : LocalDate,
                    val totalCartes: Int, val logo : String, val simbol : String) {

    override fun toString(): String {
        return nom
    }

    companion object {
        fun formatCsv(csv : String) : Expansio {
            val camps = csv.split(",")
            val nom = camps[0]
            val serie = camps[1]
            val dataPublicacio = camps[2]
            val dataProcesada = LocalDate.parse(dataPublicacio)
            val totalCartes = camps[3].toInt()
            val logo = camps[4]
            val simbol = camps[5]

            return Expansio(nom, serie, dataProcesada, totalCartes, logo, simbol)
        }
    }
}

data class Raresa(val id : String, val nom : String, val ordre : String) {

    override fun toString(): String {
        return nom
    }

    companion object {
        fun formatCsv(csv : String) : Raresa {
            val camps = csv.split(",")
            val id = camps[0]
            val nom = camps[1]
            val ordre = camps[2]

            return Raresa(id, nom, ordre)
        }
    }
}

data class Illustrador(val id : String, val nom : String)
{
    override fun toString(): String {
        return nom
    }

    companion object {
        fun formatCsv(csv : String) : Illustrador {
            val camps = csv.split(",")
            val id = camps[0]
            val nom = camps[1]

            return Illustrador(id, nom)
        }
    }
}

fun montarLlistes(mapaExpansio : Map<String, Expansio>,
                  mapaRaresa : Map<Int, Raresa>,
                  mapaIllustrador : Map<Int, Illustrador>)
{
    val reader = File()
}

fun main() {
    consolaUtf8()
}

fun consolaUtf8() {
    System.setOut(PrintStream(FileOutputStream(FileDescriptor.out), true, Charsets.UTF_8))
    System.setErr(PrintStream(FileOutputStream(FileDescriptor.err), true, Charsets.UTF_8))
}

