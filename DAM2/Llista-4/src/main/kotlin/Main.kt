package org.example

import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa
import org.example.util.Metodes
import java.io.FileDescriptor
import java.io.FileOutputStream
import java.io.PrintStream

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.

fun main() {
    consolaUtf8()
    val diccionariExpansio = mutableMapOf<String, Expansio>()
    val diccionariRaresa = mutableMapOf<Int, Raresa>()
    val diccionariIllustrador = mutableMapOf<Int, Illustrador>()

    Metodes.llegirCsvDeTaules<String, Expansio>("src/main/resources/Expansions.csv", Expansio, diccionariExpansio)
    Metodes.llegirCsvDeTaules<Int, Raresa>("src/main/resources/Rareses.csv", Raresa, diccionariRaresa)
    Metodes.llegirCsvDeTaules<Int, Illustrador>("src/main/resources/illustradors.csv", Illustrador, diccionariIllustrador)

    diccionariExpansio.forEach { string, expansio ->
        println(string)
        println(expansio)
        println()
    }

    System.out.print("holla")

}

fun consolaUtf8() {
    System.setOut(PrintStream(FileOutputStream(FileDescriptor.out), true, Charsets.UTF_8))
    System.setErr(PrintStream(FileOutputStream(FileDescriptor.err), true, Charsets.UTF_8))
}

