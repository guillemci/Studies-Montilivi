package org.example.data_class

import org.example.interficies.CsvReader
import org.example.interficies.TeId
import java.time.LocalDate

data class Expansio(val codi : String, val nom : String, val serie : String, val dataPublicacio : LocalDate,
                    val totalCartes: Int, val logo : String, val simbol : String) : TeId<String> {
    override fun toString(): String {
        return nom
    }

    override fun RetornaId(): String {
        return codi
    }

    companion object : CsvReader<Expansio> {
        override fun formatCsv(csv: String): Expansio {
            val camps = csv.split(";")

            val codi = camps[0]
            val nom = camps[1]
            val serie = camps[2]
            val dataPublicacio = LocalDate.parse(camps[3])
            val totalCartes = camps[4].toInt()
            val logo = camps[5]
            val simbol = camps[6]

            return Expansio(
                codi,
                nom,
                serie,
                dataPublicacio,
                totalCartes,
                logo,
                simbol
            )
        }
    }
}

data class Raresa(val id : Int, val nom : String, val ordre : String): TeId<Int> {
    override fun toString(): String {
        return nom
    }

    override fun RetornaId(): Int {
        return id
    }

    companion object : CsvReader<Raresa> {
        override fun formatCsv(csv : String) : Raresa {
            val camps = csv.split(";")
            val id = camps[0].toInt()
            val nom = camps[1]
            val ordre = camps[2]

            return Raresa(id, nom, ordre)
        }
    }
}

data class Illustrador(val id : Int, val nom : String): TeId<Int>
{
    override fun toString(): String {
        return nom
    }

    override fun RetornaId(): Int {
        return id
    }

    companion object : CsvReader<Illustrador> {
        override fun formatCsv(csv : String) : Illustrador {
            val camps = csv.split(";")
            val id = camps[0].toInt()
            val nom = camps[1]

            return Illustrador(id, nom)
        }
    }
}