package org.example

import java.util.Scanner
import kotlin.collections.mutableListOf

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
fun main() {
//    printMatriu<Int>(matriu = omplirNxMVertical(3,3))
//    println()
//    printMatriu<Int>(matriu = omplirNxMHortizontal(3,3))
//    println()
//    printMatriu<Int>(matriu = omplirNxMNumerosNaturals(3,4))
//    println()
//    printMatriu<Int>(matriu = omplirNxMNumerosNaturalsInvers(3,3))
//    println()
//    printMatriu<Int>(matriu = omplirMatriuDiegonal(7,7))
//    println()
//    printVector<Int>(vector = omplirVectorPelTeclatLlista())
//    println()
//    buscarValorMesPetit(llista = listOf(6,6,6,3,9,7))
//    println()
//    bucarValorMesPetitMatriu(matriu = listOf(
//        listOf(7,3,4,9),
//        listOf(7,3,2,6),
//        listOf(7,0,4,1)))
//    println()
//    calcularMaximMinimIPromitg(llista = listOf(6,6,6,3,9,7))
//    println()
//    val llistaACapgirar = mutableListOf(1,2,3,4,5)
//    capgirarLlista(llistaACapgirar)
//    printVector<Int>(llistaACapgirar)
//    println()
//    printVector(elementsComunsDosTaules(llista1 = listOf(4,5,6,7,8,56,70), llista2 = listOf(1,2,4,7,9)))
//    println()
//    printVector(elementsNoComunsDosTaules(llista1 = listOf(1,2,4,6,10), llista2 = listOf(1,3,4,5)))
//    println()
//    printVector(fusionarTaulesOrdenades(llista1 = listOf(1,2,4,6,10), llista2 = listOf(1,3,5)))
//    println()
    numeroReis(listOf("joel","joel","odiseo","tadeo"))
}

fun <T>printMatriu(matriu : List<List<T>>) {
    matriu.forEach { fila ->
        fila.forEach { element -> print(element) }
        println()
    }
}

fun <T>printVector(vector : List<T>) {
    vector.forEach { element -> print(element) }
    println()
}

fun omplirNxMVertical(n : Int, m : Int) : List<List<Int>> {
    val matriu = mutableListOf<MutableList<Int>>()
    var numeros : Int = 0

    for (i in 1..n) {
        val fila = mutableListOf<Int>()
        numeros++

        for (j in 1..m) {
            fila.add(numeros)
        }

        matriu.add(fila)
    }

    return matriu
}

fun omplirNxMHortizontal(n : Int, m : Int) : List<List<Int>> {
    val matriu = mutableListOf<MutableList<Int>>()

    for (i in 1..n) {
        var fila = mutableListOf<Int>()

        for (j in 1..m) {
            fila.add(j)
        }

        matriu.add(fila)
    }

    return matriu
}

fun omplirNxMNumerosNaturals(n : Int, m : Int) : List<List<Int>> {
    val matriu = mutableListOf<MutableList<Int>>()
    var numeros : Int = 1

    for (i in 1..n) {
        val fila = mutableListOf<Int>()

        for (j in 1..m) {
            fila.add(numeros)
            numeros++
        }
        matriu.add(fila)
    }

    return matriu
}

fun omplirNxMNumerosNaturalsInvers(n : Int, m : Int) : List<List<Int>> {
    val matriu = mutableListOf<MutableList<Int>>()
    var numeros : Int = n * m

    for (i in 1..n) {
        val fila = mutableListOf<Int>()
        for (j in 1..m) {
            fila.add(numeros--)
        }
        matriu.add(fila)
    }
    return matriu
}

fun omplirMatriuDiegonal(n : Int, m : Int) : List<List<Int>> {
    val matriu = mutableListOf<MutableList<Int>>()

    for (i in 1..n) {
        val fila = mutableListOf<Int>()
        for (j in 1..m)
        {
            if (j == i)
                fila.add(1)
            else
                fila.add(0)
        }
        matriu.add(fila)
    }

    return matriu
}

fun omplirVectorPelTeclatArray() : Array<Int> {
    val scanner = Scanner(System.`in`)
    println("especifica el numero de valors")
    val numeros = Array(scanner.nextInt()) { 0 }

    numeros.forEachIndexed { index, _ ->
        numeros[index] = scanner.nextInt()
    }

    return numeros
}

fun omplirVectorPelTeclatLlista() : List<Int> {
    val scanner = Scanner(System.`in`)
    val numeros = mutableListOf<Int>()
    println("especifica el numero de valors que seran introduits")
    var numero = scanner.nextInt()

    while (numero > 0) {
        numeros.add(scanner.nextInt())
        numero--
    }

    return numeros
}

fun omplirVectorPelTeclatLlistaVariacio() : List<Int> {
    val scanner = Scanner(System.`in`)
    val numeros = mutableListOf<Int>()

    println("especifica el numero de valors fins que possis un -1")
    var numero = scanner.nextInt()


    while (numero != -1)
    {
        numeros.add(numero)
        numero = scanner.nextInt()
    }

    return numeros
}

fun buscarValorMesPetit(llista : List<Int>) {
    var mesPetit = llista[0]
    var index = 0

    for (i in 1 until llista.size)
    {
        if (llista[i] < mesPetit)
        {
            mesPetit = llista[i]
            index = i
        }
    }

    println("el valor mes petit es: $mesPetit i el seu index es: $index")
}

fun bucarValorMesPetitMatriu(matriu : List<List<Int>>) {
    var mesPetit = matriu[0][0]
    var indexY = 0
    var indexX = 0

    for (i in 0 until matriu.size) {
        for (j in 0 until matriu[i].size)
        {
            if (matriu[i][j] < mesPetit)
            {
                mesPetit = matriu[i][j]
                indexX = j
                indexY = i
            }
        }
    }

    println("el valor mes petit es: $mesPetit i el seu indexX es: $indexX i el seu indexY es: $indexY")
}

fun calcularMaximMinimIPromitg(llista : List<Int>) {
    var totalNumeros = 0
    var maxim = llista[0]
    var minim = llista[0]
    var sum = 0

    llista.forEach {
        element ->
        sum += element
        totalNumeros++
        if (element > maxim)
            maxim = element
        if (element < minim)
            minim = element
    }

    println("el valor mes gran es ${maxim}")
    println("el valor mes petit es ${minim}")
    println("el promitg es ${sum.toDouble() / totalNumeros}")
}

fun capgirarLlista(llista: MutableList<Int>) {
    var cache : Int
    for (i in 0 until llista.size / 2) {
        cache = llista[llista.size - 1 - i]
        llista[llista.size - 1 - i] = llista[i]
        llista[i] = cache
    }
}

fun elementsComunsDosTaules(llista1 : List<Int>, llista2: List<Int>) : List<Int> {
    var i = 0
    var j = 0
    val llista = mutableListOf<Int>()

    while (i < llista1.size && j < llista2.size) {
        if (llista1[i] == llista2[j]) {
            llista.add(llista2[j])
            i++
            j++
        }
        else if (llista1[i] > llista2[j]) {
            j++
        }
        else {
            i++
        }
    }

    for (i in i until llista1.size)
        llista.add(llista1[i])

    for (j in j until llista2.size)
        llista.add(llista2[j])

    return llista
}

fun elementsNoComunsDosTaules(llista1 : List<Int>, llista2: List<Int>) : List<Int> {
    var i = 0
    var j = 0
    val llista = mutableListOf<Int>()

    while (i < llista1.size && j < llista2.size) {
        if (llista1[i] == llista2[j]) {
            i++
            j++
        }
        else if (llista1[i] > llista2[j]) {
            llista.add(llista2[j])
            j++
        }
        else {
            llista.add(llista1[i])
            i++
        }
    }

    for (i in i until llista1.size)
        llista.add(llista1[i])

    for (j in j until llista2.size)
        llista.add(llista2[j])

    return llista
}

fun fusionarTaulesOrdenades(llista1 : List<Int>, llista2: List<Int>) : List<Int>
{
    var i = 0
    var j = 0
    val llista = mutableListOf<Int>()

    while (i < llista1.size && j < llista2.size) {
        if (llista1[i] == llista2[j]) {
            llista.add(llista1[i])
            llista.add(llista2[j])
            i++
            j++
        }
        else if (llista1[i] > llista2[j]) {
            llista.add(llista2[j])
            j++
        }
        else {
            llista.add(llista1[i])
            i++
        }
    }

    for (i in i until llista1.size)
        llista.add(llista1[i])

    for (j in j until llista2.size)
        llista.add(llista2[j])

    return llista
}

fun numeroReis(llista : List<String>) {
    val diccionari = mutableMapOf<String, Int>()
    var clau = ""
    var preguntes = ""
    val scanner = Scanner(System.`in`)

    llista.forEach { element ->
        clau = element.lowercase()
        diccionari[clau] = (diccionari[clau] ?: 0) + 1
    }

    println("tenca el programa posant -1")
    preguntes = scanner.nextLine()
    while (preguntes != "-1") {
        println((diccionari[preguntes] ?: 0) + 1)
        preguntes = scanner.nextLine()
    }
}

fun reunioVeins()
{
    val scanner = Scanner(System.`in`)
    var numeroDePisos = scanner.nextLine().toInt()
    var numeroPortesDePis = scanner.nextLine().toInt()

}