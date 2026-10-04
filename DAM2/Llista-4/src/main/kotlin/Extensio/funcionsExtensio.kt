package org.example.Extensio

import org.example.enums.Tipus

fun List<Tipus>.ConteTipus(tipus : Tipus) : Boolean {
    var trovat = false
    var i = 0;

    while (!trovat && i < this.size) {
        trovat = this[i] == tipus
        i++
    }

    return trovat
}