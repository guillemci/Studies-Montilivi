package org.example

import kotlin.collections.mutableListOf
import kotlin.math.roundToInt

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.

fun main() {
    var inputMenu : Double? = 999.0

    while (inputMenu != 0.0) {
        netejarEscena()
        escriureMenu()
        inputMenu = readlnOrNull()?.toDouble()
        netejarEscena()
        when (inputMenu) {
            1.0 -> {
                println("Numero mes gran de tes")
                println("especifica els numeros")
                var num1 = readln().toInt()
                var num2 = readln().toInt()
                var num3 = readln().toInt()

                println()
                println(numeroMesGranDeTres(num1, num2, num3))
                sortir()
            }
            2.0 -> {
                println("Valor absolut de la diferencia de dos numeros")
                println("especifica el numeros")
                var num1 = readln().toInt()
                var num2 = readln().toInt()

                println()
                println("el valor absoult de la diferencia dels 2 es: ${valorAbsolut(num1, num2)}")
                sortir()
            }
            3.0 -> {
                println("2 numeros son divisors (no negatius i no 0)")
                println("especifica el numeros")
                var num1 = readln().toInt()
                var num2 = readln().toInt()

                println()
                println("el resultat basat en true (si) i false (no) es: ${SonDivisors(num1, num2)}")
                sortir()
            }
            4.0 -> {
                println("Any es de traspas")
                println("especifica el any")
                var num1 = readln().toInt()

                println()
                println("el resultat basat en true (si) i false (no) es: ${EsAnyDeTraspas(num1)}")
                sortir()
            }
            5.0 -> {
                println("Pasar segons a D:H:M:S")
                println("especifica els segons")
                var num1 = readln().toInt()

                println()
                print(CalculSegonsATemps(num1))
                sortir()
            }
            6.0 -> {
                println("afegiex un segon a H:M:S (nomes pasar dates valides)")
                println("especifica el numeros de temps (H:M:S)")
                var num1 = readln().toInt()
                var num2 = readln().toInt()
                var num3 = readln().toInt()

                println(AfegeixUnSegon(num1,num2, num3))
                sortir()
            }
            7.0 -> {
                println("pasar monedes a centims i euros (fer canvis de moneda)")
                println("especifica quantitat i import en euros")
                var quantitat = readln().toDouble()
                var import = readln().toDouble()

                println(ImportAPagarIQuantitat(quantitat, import))
                sortir()
            }
            8.0 -> {
                println("representar taules de multiplicar de 1 a N")
                println("especifica la N")
                var num1 = readln().toInt()

                println()
                TaulesDeMultiplicarDe1aN(num1)
                sortir()
            }
            9.0 -> {
                println("output de sortidas acomulades basant-se amb N")
                println("especifica la N")
                var num1 = readln().toInt()

                println()
                SumasAcomulativas(num1)
                sortir()
            }
            10.0 -> {
                println("algorisme d'euclides")
                println("especifiala el numeros")
                var num1 = readln().toInt()
                var num2 = readln().toInt()

                println()
                println("el maxim comu divisor es ${Euclides(num1, num2)}")
                sortir()
            }
            11.0 -> {
                println("especifica quants primers termes de fibonacci vols veure")
                println("especifica la n")
                var num1 = readln().toInt()

                println()
                fibonacci(num1)
                sortir()
            }
            12.1 -> {
                println("longitud de circumferencia calculat amb radi")
                println("especifica el radi (permet decimals)")
                var num1 = readln().toDouble()

                println()
                println("el calcul de la longitud de la circumferencia es ${longitudCircumferencia(num1)}")
                sortir()
            }
            12.2 -> {
                println("area d'un cercle calculat amb radi")
                println("especifica el radi (permet decimals)")
                var num1 = readln().toDouble()

                println()
                println("el calcul de l'area de la circumferencia es ${areaCercle(num1)}")
                sortir()
            }
            12.3 -> {
                println("volum d'una esfera donat un radi")
                println("especifica el radi (permet decimals)")
                var num1 = readln().toDouble()

                println()
                println("el volum de la esfera es ${volumEsfera(num1)}")
                sortir()
            }
            13.0 -> {
                println("pasar lletra minuscula a majuscula")
                println("introdueix la lletra minuscula (en cas d'un altre simbol o majuscula el tornara sense canvis)")
                var car : Char = readln().toCharArray()[0]

                println()
                println("resultat: ${minusculaAMajuscula(car)}")
                sortir()
            }
        }
    }
}

fun netejarEscena() {
    //buscat perque la consola de intellij no sembla poguer borrar els outputs
    repeat(50) {
        println()
    }
}

fun sortir() {
    println("enter per sortir")
    readln()
}

fun escriureMenu()
{
    println("menu exercici repas")
    println("1: Numero mes gran de tes")
    println("2: Valor absolut de la diferencia de dos numeros")
    println("3: 2 numeros son divisors (no negatius i no 0)")
    println("4: Any es de traspas")
    println("5: Pasar segons a D:H:M:S")
    println("6: afegiex un segon a H:M:S (nomes pasar dates valides)")
    println("7: pasar monedes a centims i euros (fer canvis de moneda)")
    println("8: representar taules de multiplicar de 1 a N")
    println("9: output de sortidas acomulades basant-se amb N")
    println("10: algorisme d'euclides")
    println("11: N primers termes de Fibonacci")
    println("12.1: longitud de circumferencia calculat amb radi")
    println("12.2: area d'un cercle calculat amb radi")
    println("12.3: volum d'una esfera donat un radi")
    println("13: pasar lletra minuscula a majuscula")
    println("el menu funciona en decimal per a 12")
    println("introdueix 0 per tencar el programa:")
    print("posa accio: ")
}

//1
/**
 *Escriu un programa que demani tres números entrats pel teclat, i ens digui
 *quin és el més gran de tots tres.
 *Cal contemplar la possibilitat de que dos dels tres números, o tots tres siguin iguals.
 * */
fun numeroMesGranDeTres(num1 : Int, num2: Int, num3: Int) : String
{
    var numeroMax = num1
    var duplicat = ""

    return if (num1 == num2 && num2 == num3)
        "tots els valors son iguals: ${num1}"
    else {
        if (num2 > numeroMax)
            numeroMax = num2

        if (num3 > numeroMax)
            numeroMax = num3

        if (num1 == num2)
            duplicat = " i el numero ${num1} es repeteix"
        else if (num1 == num3)
            duplicat = " i el numero ${num1} es repeteix"
        else if (num2 == num3)
            duplicat = " i el numero ${num2} es duplica"

        "el valor mes gran es ${numeroMax}" + duplicat
    }
}

//2
/**
 * Escriu un programa en que calculi el valor
 * absolut de la diferència de dos números entrats pel teclat.
 * */
fun valorAbsolut (num1 : Int, num2 : Int) : Int
{
    var absolut = num1 - num2
    return if (absolut < 0) absolut * -1 else absolut
}

//3
/**
 * Donats dos números naturals (no negatius) entrats pel teclat que han de ser diferents de zero
 * (en cas de que algun dels números, o tots dos siguin zero, cal que tregui un missatge d’error per pantalla),
 * digues si són divisors entre ells.
 * No importa l'ordre en que s'entrin en número, són divisors entre ells i un d'ells divideix l'altre
 * */
fun SonDivisors(num1 : Int, num2 : Int) : Boolean
{
    if (num1 < 0 || num2 < 0  || num1 == 0 || num2 == 0)
        throw ArithmeticException("Operacio Aritmetica no permesa");
    return num1 % num2 == 0 || num2 % num1 == 0
}

//4
/**
 * Dissenyeu un programa que ens informi si un any qualsevol és de traspàs.
 * (Són de traspàs tots els anys múltiples de quatre, que no ho son de cent,
 * a no ser, que siguin múltiples de quatre-cents, que llavors sí que són de traspàs)
 */
fun EsAnyDeTraspas(num1 : Int) : Boolean {
    return num1 % 4 == 0 && (num1 % 100 != 0 || num1 % 400 == 0)
}

//5
/**
 * Escriu un programa que donat un número enter que designa un període de temps expressat en segons,
 * ens informi per pantalla de l’equivalent en format dies, hores : minuts : segons.
 * */
fun CalculSegonsATemps(num : Int) : String {
    var numProcesat = num;
    var dies = 0
    var hores = 0
    var minuts = 0
    var segons = 0

    dies = numProcesat / 86400
    numProcesat %= 86400

    hores = numProcesat / 3600
    numProcesat %= 3600

    minuts = numProcesat / 60
    numProcesat %= 60

    segons = numProcesat

    return "[dies: ${dies}] [hores: ${hores}] [minuts: ${minuts}] [segons: ${segons}]"
}

//6
/**
 * Donada una expressió horària en el format hores, minuts, segons (cal que entrin 3 números i valideu que
 * estiguin entre 0 i 23 o 0 i 59 en el cas dels minuts i segons),
 * afegiu-hi un segon i retorneu el resultat en el mateix format.
 * */
fun AfegeixUnSegon(hores : Int, minuts : Int, segons : Int) : String {
    var segonsProcesats = segons + 1;
    var minutsProcesats = minuts;
    var horesProcesats = hores;

    return if (hores >= 24 || minuts >= 60 || segons >= 60 || hores < 0 || minuts < 0 || segons < 0) {
        "ERROR: hora incorrecte"
    }
    else {

        if (segonsProcesats > 59) {
            segonsProcesats = 0;
            minutsProcesats++;
        }

        if (minutsProcesats > 59) {
            minutsProcesats = 0;
            horesProcesats++;
        }

        if (horesProcesats > 23) {
            horesProcesats = 0;
        }
        "${horesProcesats}:${minutsProcesats}:${segonsProcesats}"
    }
}

//7
/**
 * Fes un programa que donat un import a pagar en Euros i una quantitat d’Euros amb la que es paga,
 * ens descomposi el canvi en els diferents tipus de monedes
 * (1 cèntim, 2 cèntims, 5 cèntims, 10 cèntims, 20 cèntims, 50 cèntims, 1 euro, 2 euros),
 * de tal manera que hi hagi el mínim número de monedes. Si no hi haguès canvi
 * no es pagués amb prou diners, cal informar d'aquest fet.
 * */
fun ImportAPagarIQuantitat(quantitatEuros : Double, import : Double) : String {
    var canvi : Int

    return if (quantitatEuros < import)
        "no hi ha suficients diners per al import"
    else {
        canvi = ((quantitatEuros - import) * 100).roundToInt()
        OrganitzarDiners(canvi)
    }
}

fun OrganitzarDiners(num : Int) : String {
    var dinersProcesats = num

    var dosEuros = dinersProcesats / 200
    dinersProcesats %= 200

    var unEuros = dinersProcesats / 100
    dinersProcesats %= 100

    var cincuantaCentims = dinersProcesats / 50
    dinersProcesats %= 50

    var vintCentims = dinersProcesats / 20
    dinersProcesats %= 20

    var deuCentims = dinersProcesats / 10
    dinersProcesats %= 10

    var cincCentims = dinersProcesats / 5
    dinersProcesats %= 5

    var dosCentims = dinersProcesats / 2
    dinersProcesats %= 2

    var uncentCentims = dinersProcesats

    return "Dos Euros ${dosEuros}" +
            "\nUn Euro ${unEuros}" +
            "\ncincuanta centims ${cincuantaCentims}" +
            "\nvint Centims ${vintCentims}" +
            "\ndeu centims ${deuCentims}" +
            "\ncinc centims ${cincCentims}" +
            "\ndos centims ${dosCentims}" +
            "\nun centims ${uncentCentims}"
}

//8
/**
 * Escriu un programa per representar les taules de multiplicar de l’1 a N,
 * on N es un natural entrat pel teclat.
 * Cada taula ha de mostrar les multiplicacions del 0 al 10.
 * */
fun TaulesDeMultiplicarDe1aN(num : Int) : Unit {
    for (i in 1..num) {
        println("Taula de multiplicar de: ${i}")
        for (j in 0..10) {
            println(i * j)
        }
    }
}

//9
/**
 * Escriu un programa que ens proporcioni la següent sortida:
 * 1 = 1
 * 1 + 2 = 3
 * 1 + 2 + 3 = 6
 * Cal generar tantes línies com indiqui una entrada pel teclat.
 * */
fun SumasAcomulativas(num : Int) : Unit {
    var temp = ""
    var suma = 0
    for (i in 1..num) {
        temp = ""
        suma = 0
        for (j in 1..i) {
            temp += "${j}"
            suma += j
            if (j == i) {
                temp += " = ${suma}"
            }
            else {
                temp += " + "
            }
        }
        println(temp)
    }
}

//10
/**
 * Escriu l’algorisme d’Euclides per calcular el Màxim Comú Divisor
 * de dos números estrictament positius.
 * */
fun Euclides(num1 : Int, num2 : Int) : Int {
    if (num1 <= 0 || num2 <= 0)
        throw IllegalArgumentException("Els numeros han de ser estrictament positius")

    var backup = 0;
    var resultatnum1 = num1;
    var resultatnum2 = num2;

    while (resultatnum2 > 0) {
        backup = resultatnum2
        resultatnum2 = resultatnum1 - ((resultatnum1 / resultatnum2) * resultatnum2)
        resultatnum1 = backup;
    }

    return backup
}

//11
/**
 * Escriu un programa que ens mostri els N primers termes de la
 * sèrie de Fibonacci, on N és un natural entrat pel teclat. (1, 1, 2, 3, 5, 8, 13, ... )
 * */
fun fibonacci(num : Int) : Unit {
    if (num < 1)
        throw IllegalArgumentException("no pot ser ni 0 ni negatiu")

    println("els ${num} primers valors de fibonacci son :")
    println(1)

    if (num > 1)
        println(1)

    if (num > 2) {
        val resultat = immersioFibonacci(num,3,1,1)
    }
}

fun immersioFibonacci(n : Int, index : Int, num1 : Int, num2 : Int) : Int {
    var index = index
    var resultat : Int
    var sum1i2 = num1 + num2
    println(sum1i2)

    if (index == n)
        resultat = sum1i2
    else
        resultat = immersioFibonacci(n,index + 1,sum1i2,num1)

    return resultat
}

//12
/**
 * Fes un programa que permeti triar entre calcular la longitud d’una circumferència,
 * l’àrea d’un cercle o el volum d’una
 * esfera donat un Radi entrat pel teclat.
 * (Longitud = 2 * π * Radi; Àrea = π * Radi * Radi; Volum = 4/3 * π * Radi * Radi * Radi)
 * */
fun longitudCircumferencia(radi : Double) : Double {
    return 2 * Math.PI * radi
}

fun areaCercle(radi : Double) : Double {
    return Math.PI * radi * radi
}

fun volumEsfera(radi : Double) : Double {
    return 4.0/3.0 * Math.PI * radi * radi * radi
}

//13
/*
* Escriure un programa en el que quan se li entra un lletra minúscula,
* ensenya la seva majúscula corresponent. (Només si se li entra una lletra minúscula)
**/
fun minusculaAMajuscula(lletra : Char) : Char {
    var lletraInt = lletra.code
    return if (!(lletraInt >= 123 || lletraInt <= 96))
            (lletraInt - 32).toChar()
    else
        lletra
}

//readlnornull
//tointornull
//if pot tornar valors
