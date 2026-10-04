package org.example.`object`

import org.example.data_class.Expansio
import org.example.data_class.Illustrador
import org.example.data_class.Raresa

object Dades {
    val expansions = mutableMapOf<String, Expansio>()
    val rareses = mutableMapOf<Int, Raresa>()
    val illustradors = mutableMapOf<Int, Illustrador>()
}