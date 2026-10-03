package org.example.interficies

interface CsvReader<T> {
    fun formatCsv(fitxer : String) : T
}

interface TeId<T> {
    fun RetornaId() : T
}