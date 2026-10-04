package org.example

import org.example.Model.Eina
import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa
import org.example.`object`.Dades
import org.example.util.Metodes
import org.example.util.Metodes.Companion.desa
import org.example.util.Metodes.Companion.llegeix
import java.io.FileDescriptor
import java.io.FileOutputStream
import java.io.PrintStream

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.

fun main() {
    consolaUtf8()


    val CARPETA_DADES = "Dades"


//    println(colleccioCartes[911].toCsv())
//
//    print(colleccioCartes.count())
//
//    colleccioCartes.forEach { carta ->
//        if (carta is Eina)
//            println(carta)
//    }


    Metodes.cadenaEvolutiva("Ivysaur").forEach {
        elemnt -> println(elemnt)
    }

    //desa("DadesGuardades", colleccioCartes)

}

fun consolaUtf8() {
    System.setOut(PrintStream(FileOutputStream(FileDescriptor.out), true, Charsets.UTF_8))
    System.setErr(PrintStream(FileOutputStream(FileDescriptor.err), true, Charsets.UTF_8))
}

