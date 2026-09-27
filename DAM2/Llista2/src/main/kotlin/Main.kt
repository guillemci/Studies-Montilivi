package org.example
import java.io.InputStream
import java.util.Scanner
import kotlin.math.sqrt

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.

fun main() {
    var inputMenu = 999
    while (inputMenu != 0)
    {
        netejarEscena()
        pintarMenu()
        //nomes per el menu
        inputMenu = readln().toInt()
        netejarEscena()
        when (inputMenu) {
            1 -> {
                println("numero de caracters ${puntAmbFrase()}")
                sortir()
            }
            2 -> {
                println("numero de caracters ${puntAmbFraseIniciA()}")
                sortir()
            }
            3 -> {
                println("es una serie criexent: ${serieDeValorsIncremental()}")
                sortir()
            }
            4 -> {
                println("es una serie unicament de valors positius: ${serieDeValorsPositius()}")
                sortir()
            }
            5 -> {
                inputsFinsNumerMajorASuma()
                sortir()
            }
            6 -> {
                copiaDeSequencia()
                sortir()
            }
            7 -> {
                nEntersMde3ORMesGrans5()
                sortir()
            }
            8 -> {
                mesPetitenNNumeros()
                sortir()
            }
            9 -> {
                println("es un numero primer: ${esPrimer()}")
                sortir()
            }
        }
    }
}

fun pintarMenu() : Unit {
    println("1: donada una frase amb punt final, compti el nombre de caracters sense el punt")
    println("2: donads una frase amb punt final, compti el nombre de caracters a partir de l'aparicio de una a-A")
    println("3: serie de nombres amb final 0 si la serie es creixent")
    println("4: serie acabada en zero, si tots els valors son positius")
    println("5: programa que permeti una serie de numero fins que sigui major de la suma dels dos numeros anteriors")
    println("6: programa que faci una copia d'una sequencia de caracters acabada en punt suprimint caracters en blanc")
    println("7: programa que se l'hi entrin n enters que digui els superiors o iguals a 5 i multiples de 3 (no 0)")
    println("8: programa que se l'hi entrin n enters positius, i que el programa digui el mes petit i posicio")
    println("9; programa pasat un valor, que digui si es primer")
}

fun sortir() {
    println("enter per sortir")
    readln()
}

fun netejarEscena() {
    //buscat perque la consola de intellij no sembla poguer borrar els outputs
    repeat(50) {
        println()
    }
}

//ex1
/**
 * Donada una frase acabada en punt, fes un programa que compti
 * el nombre de caràcters que hi apareixen, sense comptar el punt finalitzador.
 * */
fun puntAmbFrase(input : InputStream = System.`in`) : Int {
    println("ex1: escriu la frase amb punt final")
    var ncontats = 0
    val entrada = Scanner(input)
    entrada.useDelimiter("")
    var caracterActual : Char = entrada.next()[0]

    while (caracterActual != '.') {
        ncontats++
        caracterActual = entrada.next()[0]
    }

    return ncontats
}

//ex2
/**
 * Donada una frase acabada en punt, fes un programa que compti el nombre de caràcters
 * que hi apareixen a partir de la primera ‘a’, ja sigui majúscula o minúscula.
 * */
fun puntAmbFraseIniciA(input: InputStream = System.`in`) : Int {
    println("ex2: escriu la frase amb punt final, llegira a partir de la a-A")
    var ncontats = 0
    var adetectada = false
    val entrada = Scanner(input)
    entrada.useDelimiter("")
    var caracterActual : Char = entrada.next()[0]

    while (caracterActual != '.') {
        if (caracterActual == 'a' || caracterActual == 'A') {
            adetectada = true
        }
        if (adetectada) {
            ncontats++
        }
        caracterActual = entrada.next()[0]
    }

    return ncontats
}

//ex3
/**
 * Donada una sèrie de nombres acabada en zero,
 * fes un programa que ens digui si aquesta sèrie és creixent.
 * */
fun serieDeValorsIncremental(input: InputStream = System.`in`) : Boolean {
    println("ex3: escriu la serie de nombes acabada amb zero")
    val entrada = Scanner(input)

    var numeroActual = entrada.next().toInt()
    var abans = numeroActual
    var esincremental = true

    if (numeroActual == 0) {
        esincremental = false
    }

    while(numeroActual != 0 && esincremental) {
        numeroActual = entrada.next().toInt()

        if (numeroActual != 0) {
            if (numeroActual <= abans ) {
                esincremental = false
            }
            abans = numeroActual
        }
    }



    return esincremental
}

//ex4
/**
 * Donada una sèrie de nombres acabada en zero, fes un programa
 * que ens digui si aquesta sèrie està formada únicament per valors positius.
 * */
fun serieDeValorsPositius(input: InputStream = System.`in`) : Boolean {
    println("ex4: escriu la serie de nombes acabada amb zero")
    val entrada = Scanner(input)
    var numeroActual = entrada.next().toInt()
    var espositiva = true;

    while (espositiva && numeroActual != 0) {
        espositiva = numeroActual > 0

        if (espositiva) {
            numeroActual = entrada.next().toInt()
        }
    }
    return espositiva
}

//ex5
/**
 * Feu un programa que permeti la introducció d’una sèrie de números
 * fins que un d’aquests números sigui major que la suma dels dos números anteriors.
 * Al finalitzar, ha de dir el número d'introduccions i valors dels números
 * que han complert la condició de finalització del programa.
 * */
fun inputsFinsNumerMajorASuma(input: InputStream = System.`in`) : Unit {
    val entrada = Scanner(input)
    var contar = 2
    System.out.println("introdueix els primers nombres")
    var primerNumero = entrada.next().toInt()
    var segonNumero = entrada.next().toInt()
    System.out.println("(anteriors ${primerNumero} i ${segonNumero}) introduir un numero menor a ${primerNumero + segonNumero} si no vols acabar el programa")
    var actual = entrada.next().toInt()

    while (actual <= primerNumero + segonNumero) {
        contar++;
        primerNumero = segonNumero
        segonNumero = actual
        System.out.println("(anteriors ${primerNumero} i ${segonNumero}) introduir un numero menor a ${primerNumero + segonNumero} si no vols acabar el programa")
        actual = entrada.next().toInt()
    }

    println("numero de numeros introduits abans del final: ${contar}")
    println("[suma final: ${primerNumero} + ${segonNumero} = ${primerNumero + segonNumero}] numero que a trancat la condicio [${actual}]")
}

//ex6
/**
 * Escriu un programa que faci una còpia d’una
 * seqüència de caràcters acabada en punt,
 * però suprimint tots els espais en blanc.
 * */
fun copiaDeSequencia(input: InputStream = System.`in`) : Unit {
    System.out.println("escriu la sequencia desitjada acabada en punt")
    val entrada = Scanner(input)
    entrada.useDelimiter("")
    var actual = entrada.next()[0]
    var final = false

    while (!final) {
        if (actual != ' ')
            print(actual)
        if (actual == '.')
            final = true
        else
            actual = entrada.next()[0]
    }
}

//ex7
/**
 * Feu un programa que a l’entrar N números enters, ens digui
 * quants d’ells eren múltiples de 3 i quants més grans o iguals a 5.
 * Cal tenir en compte que el zero no és múltiple de 3.
 * */
fun nEntersMde3ORMesGrans5(input: InputStream = System.`in`) : Unit {
    val escaner = Scanner(input)
    println("especifica el total de numeros que es demanaran")
    var repeticions = escaner.next().toInt()
    var valor : Int
    var multiplesDeTres = 0
    var mesgransOIgualA5 = 0

    println("posar els numeros")
    while(repeticions > 0) {
        valor = escaner.next().toInt()

        if (valor % 3 == 0 && valor != 0)
            multiplesDeTres++

        if (valor >= 5)
            mesgransOIgualA5++
        repeticions --
    }

    println("s'han trovat un total de ${multiplesDeTres} multiples de tres")
    println("s'han trovat un total de ${mesgransOIgualA5} numeros mes grans o igual que 5")
}

//ex8
/**
 * Feu un programa, que després d’haver-li entrat N números positius,
 * ens digui quin és el més petit, i quina posició ocupa dins la seqüència.
 * */
fun mesPetitenNNumeros(input: InputStream = System.`in`) : Unit {
    val escaner = Scanner(input)

    System.out.println("digues el total de numeros que vols revisar")
    var n = escaner.next().toInt()
    var iteracions = 2;
    var posicioNMesPetit = 1;

    System.out.println("introdueix els numeros mes petits")
    var actual = escaner.next().toInt()
    var mesPetit = actual

    while (iteracions <= n) {
        actual = escaner.next().toInt()

        if (mesPetit > actual) {
            mesPetit = actual
            posicioNMesPetit = iteracions
        }

        iteracions++
    }

    println("el numero mes petit a la secuenccia de ${n} numeros es el ${mesPetit} a la posicio ${posicioNMesPetit}")
}

//ex9
/**
 * Feu un programa, que ens digui si un número donat és primer.
 * */
fun esPrimer(input: InputStream = System.`in`) : Boolean {
    System.out.println("escriu el numero que en vulguis esbrinar si es primer")
    val entrada = Scanner(input)

    var esPrimer = true;
    var numero = entrada.next().toInt()
    var i = 2

    if (numero <= 1)
        esPrimer = false

    while (esPrimer && i <= sqrt(numero.toDouble()).toInt()) {
        esPrimer = numero % i != 0
        i++;
    }
    return esPrimer
}