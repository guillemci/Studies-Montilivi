
package org.example.enums

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